create database carros;
use carros;

create table encomenda(
registo int primary key auto_increment,
Marca varchar(30) not null,
Modelo varchar(30) not null,
Categoria varchar(30) not null,
Combustivel varchar(30) not null,
Cilindrada int not null,
Tipo varchar(30) not null,
Ano int not null,
Preco int not null
);