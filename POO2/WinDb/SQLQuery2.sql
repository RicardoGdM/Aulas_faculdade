use WinDb;

create table Itens (
	Id int primary key identity,
	Descricao varchar(100) not null
);

select * from Itens;