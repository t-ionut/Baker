Pasi de instalare Baker

1) Instaleaza Postgres
2) Creeaza o baza de date numita baker
3) Asigura-te ca datele de conectare sunt :
	User Id=postgres;Password=postgres;Host=localhost;Port=5432;Database=baker;
4) Ruleaza baker_dev_scripts.sql pentru crearea tabelelor si a userului Admin
5) Intra in aplicatie si logheaza-te cu user: admin si pass: admin
6) Inregistreaza un user cu drepturi de admin pentru client
7) Logheaza-te cu userul clientului si sterge definitiv userul admin
8) Verifica functionalitatile aplicatiei + locul in care se creeaza folderul de logging si de pdf exporting

Posibile dependinte: .NET Framework 3.5