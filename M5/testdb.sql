create database testdb;
use testdb;

create table users(
id int primary key auto_increment,
fname varchar(30) not null,
lname varchar(30) not null,
age int not null
);
