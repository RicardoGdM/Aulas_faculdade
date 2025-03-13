create database menuAula;

use menuAula;

create table Pessoas (
	id int identity(1,1),
	nome varchar(100),
	email varchar(150)
);

select * from pessoas;

exec sp_rename Pessoas, pessoas; 
