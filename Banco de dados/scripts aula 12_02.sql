create database erp; /*cria o banco de dados*/

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

/*drop table contato;*/ /*apaga a tabela*/


