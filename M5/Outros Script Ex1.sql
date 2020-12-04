select * from postal;
select * from pessoa;
select * from mensagem;
select * from comissao;


-- 3.1
select * from postal;

-- 3.2
select id, nome from pessoa;

-- 3.3
select * from pessoa;

-- 3.4
select Nome, Id , Idade, Cod_Postal, Telefone, Salario from pessoa; 

-- 3.5
Select * From pessoa Where Idade = 35;

-- 3.6
select Id, Nome, Salario  from pessoa where Idade > 18;

-- 3.7
select Mensagem from mensagem where Id_Msg != 20; 

-- 3.8
select Id, Nome, Idade, Salario from pessoa where Idade > 30 AND Idade < 40;

-- 3.9
select Id, Nome, Idade, Salario from pessoa where Idade < 30 OR Idade > 40;

-- 3.10
select Nome, Salario from pessoa where Salario > 50000 AND Salario < 90000; 

-- 3.11
select Nome, Salario from pessoa where Salario < 50000 OR Salario > 90000; 

-- 3.12
select * from postal where localidade = "Tomar" OR localidade = "Lisboa"; 

-- 3.13
select * from postal where localidade != "Tomar" AND localidade != "Lisboa";

-- 3.14
select Nome from pessoa where  telefone is not null;

-- 3.15
select Nome from pessoa where  telefone is null;

-- 3.16
select Mensagem from mensagem where Mensagem like 'T%';

-- 3.17
select Mensagem from mensagem where Mensagem like '%as';

-- 3.18
select Mensagem from mensagem where Mensagem like '%Vendas%';

-- 3.19 
select Nome from pessoa where Nome like '%da%';

-- 3.20
select Nome from pessoa where Nome not like '%da%';

-- 3.21
select Nome from pessoa where Nome like '_a%';

-- 3.22
select Nome from pessoa where Nome like 'a%' OR nome like 'b%' OR nome like 'f%';

-- 4.1
select * from pessoa order by idade;

-- 4.2
 select Nome, Salario from pessoa order by Salario DESC;
 
 -- 4.3
 select Nome, Salario from pessoa where  telefone is not null order by Salario;
 
 -- 4.4
 select * from comissao order by id;
 
 -- 4.5
 select * from comissao order by id AND Id_Msg;
 
 -- 4.6
 select * from comissao where Id < 40 order by Id ASC, Valor DESC;
 
 -- 4.7
 select Nome, idade, idade + 5 as "Idade futura" from pessoa;
 
 
 -- 5.1
 insert into postal Values (1250, "Mouraria");
 
 -- 5.2
 insert into pessoa Values (999, "Ana Rita", 35, 560000, null, 2300);
 
 -- 6.1
 delete from pessoa where Nome = "Ana Rita";