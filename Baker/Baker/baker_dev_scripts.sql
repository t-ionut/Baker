CREATE TABLE app_users
(
  id_user serial NOT NULL,
  user_name character varying(30),
  salt character varying(255),
  hash character varying(255),
  firstname character varying(255),
  lastname character varying(255),
  isadmin boolean DEFAULT false,
  CONSTRAINT pk_id_user PRIMARY KEY (id_user)
);

CREATE TABLE app_tip_prod
(
  id_tip_prod serial NOT NULL,
  nume_tip_prod character varying(50),
  CONSTRAINT pk_id_tip_prod PRIMARY KEY (id_tip_prod)
);

CREATE TABLE app_prod
(
  id_prod serial NOT NULL,
  nume_prod character varying(150),
  gramaj_prod integer,
  id_tip_prod integer,
  comercializat boolean DEFAULT true,
  pret_prod_ftva double precision,
  tva_prod double precision,
  CONSTRAINT pk_id_prod PRIMARY KEY (id_prod),
  CONSTRAINT fk_id_tip_prod FOREIGN KEY (id_tip_prod)
      REFERENCES app_tip_prod (id_tip_prod) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
);

CREATE TABLE app_magazine
(
  id_mag serial NOT NULL,
  nume_mag character varying(150),
  cui_mag character varying(50),
  adr_mag text,
  tel_mag character varying(30),
  partener boolean DEFAULT true,
  CONSTRAINT pk_id_mag PRIMARY KEY (id_mag)
);

CREATE TABLE app_soferi
(
  id_sofer serial NOT NULL,
  nume_sofer character varying(100),
  cnp_sofer character varying(50),
  adr_sofer text,
  tel_sofer character varying(30),
  angajat boolean DEFAULT true,
  CONSTRAINT pk_id_sofer PRIMARY KEY (id_sofer)
);

CREATE TABLE app_pers_cont
(
  id_pers_cont serial NOT NULL,
  nume_pers_cont character varying(100),
  tel_pers_cont character varying(30),
  id_mag integer,
  CONSTRAINT pk_id_pers_cont PRIMARY KEY (id_pers_cont),
  CONSTRAINT fk_id_mag FOREIGN KEY (id_mag)
      REFERENCES app_magazine (id_mag) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
);

CREATE TABLE app_livrari
(
  id_raport_livrare serial NOT NULL,
  id_sofer integer,
  id_mag integer,
  tura integer,
  tur boolean DEFAULT false,
  retur boolean DEFAULT false,
  data_livrare timestamp without time zone,
  suma_incasata double precision,
  CONSTRAINT pk_id_raport_livrare PRIMARY KEY (id_raport_livrare),
  CONSTRAINT fk_id_mag FOREIGN KEY (id_mag)
      REFERENCES app_magazine (id_mag) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT fk_id_sofer FOREIGN KEY (id_sofer)
      REFERENCES app_soferi (id_sofer) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
);

CREATE TABLE app_livrari_detalii
(
  id_detalii serial NOT NULL,
  id_raport_livrare integer,
  id_prod integer,
  cantitate_livrata integer,
  CONSTRAINT pk_id_detalii PRIMARY KEY (id_detalii),
  CONSTRAINT fk_id_raport_livrare FOREIGN KEY (id_raport_livrare)
      REFERENCES app_livrari (id_raport_livrare) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
);

CREATE OR REPLACE VIEW app_prod_info AS 
 SELECT app_prod.id_prod,
    app_prod.nume_prod,
    app_prod.gramaj_prod,
    app_tip_prod.nume_tip_prod AS tip_prod,
    app_prod.comercializat,
    app_prod.pret_prod_ftva,
    app_prod.tva_prod,
    app_prod.pret_prod_ftva + app_prod.pret_prod_ftva * app_prod.tva_prod / 100::double precision AS pret_prod_ctva
   FROM app_prod,
    app_tip_prod
  WHERE app_prod.id_tip_prod = app_tip_prod.id_tip_prod
  ORDER BY app_prod.id_prod;

CREATE OR REPLACE VIEW app_livrari_prod AS 
 SELECT app_livrari.id_raport_livrare,
    app_soferi.id_sofer,
    app_soferi.nume_sofer,
    app_magazine.id_mag,
    app_magazine.nume_mag,
    app_livrari.tura,
    app_livrari.tur,
    app_livrari.retur,
    app_livrari.data_livrare,
    app_livrari.suma_incasata,
    app_prod_info.id_prod,
    app_prod_info.nume_prod,
    app_prod_info.gramaj_prod,
    app_prod_info.tip_prod,
    app_prod_info.pret_prod_ftva,
    app_prod_info.tva_prod,
    app_prod_info.pret_prod_ctva,
    app_livrari_detalii.cantitate_livrata
   FROM app_livrari,
    app_livrari_detalii,
    app_soferi,
    app_magazine,
    app_prod_info
  WHERE app_livrari.id_raport_livrare = app_livrari_detalii.id_raport_livrare AND app_livrari.id_sofer = app_soferi.id_sofer AND app_livrari.id_mag = app_magazine.id_mag AND app_livrari_detalii.id_prod = app_prod_info.id_prod
  ORDER BY app_livrari.id_raport_livrare;

  CREATE OR REPLACE VIEW app_livrari_cost AS 
 SELECT app_livrari_prod.id_raport_livrare,
    app_livrari_prod.id_mag,
    app_livrari_prod.nume_mag,
    app_livrari_prod.data_livrare,
    sum(app_livrari_prod.cantitate_livrata::double precision * app_livrari_prod.pret_prod_ctva) AS cost_livrare,
    app_livrari_prod.suma_incasata,
    sum(app_livrari_prod.cantitate_livrata::double precision * app_livrari_prod.pret_prod_ctva) - sum(app_livrari_prod.suma_incasata) AS rest_plata
   FROM app_livrari_prod
  GROUP BY app_livrari_prod.id_raport_livrare, app_livrari_prod.suma_incasata, app_livrari_prod.id_mag, app_livrari_prod.nume_mag, app_livrari_prod.data_livrare
  ORDER BY app_livrari_prod.id_raport_livrare;

CREATE TABLE app_livrari_costuri
(
  id_raport_livrare integer,
  id_mag integer,
  nume_mag character varying(150),
  data_livrare timestamp without time zone,
  cost_livrare double precision,
  suma_incasata double precision,
  rest_plata double precision
);

CREATE OR REPLACE VIEW app_magazine_datorii AS 
 SELECT app_livrari_costuri.id_mag,
    app_livrari_costuri.nume_mag,
    sum(app_livrari_costuri.rest_plata) AS sold_restant
   FROM app_livrari_costuri
  GROUP BY app_livrari_costuri.id_mag, app_livrari_costuri.nume_mag
  ORDER BY app_livrari_costuri.id_mag;

  CREATE OR REPLACE VIEW app_pers_cont_mag AS 
 SELECT app_pers_cont.id_pers_cont,
    app_pers_cont.nume_pers_cont,
    app_pers_cont.tel_pers_cont,
    app_magazine.id_mag,
    app_magazine.nume_mag
   FROM app_pers_cont,
    app_magazine
  WHERE app_pers_cont.id_mag = app_magazine.id_mag
  ORDER BY app_magazine.id_mag;

  






