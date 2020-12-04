create database bdsql_T2;
use bdsql_T2;


create table postal (Codigo int primary key, 
localidade VarChar(30));


create table pessoa (Id int auto_increment primary key, 
Nome VarChar(30), Idade int(11), 
Salario int, 
Telefone varchar(12), 
Cod_Postal int,
foreign key (Cod_Postal) REFERENCES postal(Codigo));


create table mensagem (Id_Msg int auto_increment primary key, 
Mensagem VarChar(30));


create table comissao (
Id int, 
Id_Msg int,
Valor int,
foreign key (Id_Msg) REFERENCES mensagem(Id_Msg),
foreign key (Id) REFERENCES pessoa (Id));
 
insert into comissao Values (7, 1, 1);
insert into comissao Values (8, 2, 2);

