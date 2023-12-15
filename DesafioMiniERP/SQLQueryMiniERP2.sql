CREATE DATABASE MiniERP

create login minierp4 with password='Senha1234';
create user usuario4 from login minierp4;
exec sp_addrolemember 'DB_DATAREADER', 'usuario4';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario4';


CREATE TABLE Clientes
(
    Id int primary key identity,
	Nome varchar(50) not null,
	Cnpj varchar(20) not null,
	Email varchar(50),
    Telefone varchar(20)
);

CREATE TABLE Fornecedores
(
    Id int primary key identity,
	Nome varchar(50) not null,
	Cnpj varchar(20) not null,
	Email varchar(50),
    Telefone varchar(20)
);

drop table Fornecedor
drop table Produto
drop table Cliente


CREATE TABLE Produtos
(
	Id int primary key identity,
	Nome varchar(50) not null,
	Preco decimal(4, 2) not null,
    --QuantidadeEmEstoque int not null,    
	FornecedorId varchar(20) not null,
	foreign key (FornecedorId) references Fornecedor(Id)
);

insert into Clientes(Nome, Cnpj, Email, Telefone) values ('jose', '0123456', 'jose@email.com', '40044000')
insert into Clientes(Nome, Cnpj, Email, Telefone) values ('alex', '0987654', 'alex@email.com', '40049999')

insert into Fornecedores(Nome, Cnpj, Email, Telefone) values ('coca-cola', '999999', 'coca@email.com', '08004000')
insert into Fornecedores(Nome, Cnpj, Email, Telefone) values ('pepsi', '777777', 'pepsi@email.com', '08009999')


insert into Produtos(Nome, Preco, FornecedorId) values ('coca-cola', 4.99, '')
insert into Produtos(Nome, Preco, FornecedorId) values ('pepsi', 5.99, '')

select * from Clientes
select * from Fornecedores
select * from Produtos
--USE MiniERP;
--ALTER TABLE Produtos DROP COLUMN QuantidadeEmEstoque;



--USE MiniERP;
--GRANT SELECT, INSERT, UPDATE, DELETE TO usuario4; -- permissões necessárias

--USE MiniERP;
--EXEC sp_helprotect NULL, 'usuario4'; -- teste de permissão

--USE MiniERP;

--GRANT DELETE ON clientes4 TO usuario4;
--GRANT DELETE ON fornecedores4 TO usuario4;
--GRANT DELETE ON produtos4 TO usuario4;

--USE MiniERP;
--GRANT CONNECT TO usuario4;
