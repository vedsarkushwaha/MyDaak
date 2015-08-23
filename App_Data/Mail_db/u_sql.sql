conn system/a;
drop user db_mail cascade;
create user db_mail identified by db_mail;
grant dba to db_mail;
conn db_mail/db_mail;