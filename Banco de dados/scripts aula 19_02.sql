create database erp; /*cria o banco de dados*/

use erp; /*usa o banco de dados*/

create table contato(
	id int primary key identity(1,1),
	fk_pessoas int not null,
	email varchar(100),
	telefone varchar(15)
	constraint Fk_pessoa_contato foreign key
	(fk_pessoas) references pessoas(id) 
	on delete cascade on update cascade
);

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

create table endereco (
	id int primary key identity(1,1),
	Fk_pessoas int not null,
	tipo int not null,
	pais varchar(100) not null,
	uf varchar(2) not null,
	estado varchar(30)not null,
	cidade varchar(100) not null,
	bairro varchar(100) not null,
	rua varchar(100) not null,
	numero varchar(6) not null,
	complemento varchar(100),
	obs text,
	constraint FK_pessoas_enderecos foreign key
	(Fk_pessoas) references pessoas(id) on
	delete cascade on update cascade
);

create table produtos (
	id int primary key identity(1,1),
	nome varchar(100) not null,
	descricao text,
	imagem text not null,
	situacao tinyint not null,
	categoria varchar(100) not null,
	referencia_interna varchar(100),
	fornecedor varchar(100) not null,
	preco_fornecedor decimal(9,2) not null	
);

create table estoque (
	id int primary key identity(1,1),
	fk_produto int not null,
	qtd int not null,
	tamanho varchar(50) not null,
	cor varchar(50) not null,
	cod_barras varchar(100)not null,
	custo decimal(9,2) not null,
	preco_venda decimal(9,2) not null,
	preco_minimo decimal(9,2) not null,
	markup_minimo decimal(9,2) not null,
	markup_venda decimal(9,2) not null,
	constraint FK_estoque_produtos foreign key
	(fk_produto) references produtos(id)
	on delete cascade on update cascade
);