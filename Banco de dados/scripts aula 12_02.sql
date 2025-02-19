/*create database erp; /*cria o banc de dados*/

use erp; /*usa o banco de dados*/


create table contato(
	id int primary key identity(1,1),
	nome varchar(45),
	idade int
);

select * from contato;

select nome from contato order by nome asc;

select idade * 5 from contato;

select * from contato where idade = 35;

select * from contato order by idade desc;

insert into contato (nome, idade) values
	('Ricardo', 29),
	('Eduardo', 35),
	('Vinão', 28),
	('Paulinho', 23),
	('Daniel', 22),
	('Monique', 22);

drop table contato;*/ /*apaga a tabela*/

/*drop table cliente;*/

create table cliente(
	id int primary key identity(1,1),
	tipo int not null,
	nome varchar(100) not null,
	status tinyint not null,
	email varchar(100) not null,
	data_nasc date not null,
	fornecedor tinyint not null,
	transportadora tinyint not null,
	representante tinyint not null,
	funcionario tinyint not null,
	parceiro_comercial tinyint not null
);

/*select * from cliente;*/

/*alter table cliente add transportadora tinyint not null;*/
