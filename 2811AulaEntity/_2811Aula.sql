create database _2811aula

create login _2811aulab with password='senha1234';
create user _2811aulab from login _2811aulab;
exec sp_addrolemember 'DB_DATAREADER', '_2811aulab';
exec sp_addrolemember 'DB_DATAWRITER', '_2811aulab';