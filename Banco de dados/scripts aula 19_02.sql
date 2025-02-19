create database erp; /*cria o banco de dados*/

use erp; /*usa o banco de dados*/

create table pessoas(
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

select * from pessoas;