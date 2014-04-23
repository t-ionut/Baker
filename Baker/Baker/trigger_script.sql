create or replace function trig_add_details()
returns trigger as
$BODY$
BEGIN
insert into app_livrari_detalii (id_raport_livrare, id_prod, cantitate_livrata)
values (new.id_raport_livrare, new.id_prod, new.cantitate
END;
$BODY$
LANGUAGE plpgsql VOLATILE;

create trigger trig_add_details
after insert on app_livrari
for each row
execute procedure trig_add_details();