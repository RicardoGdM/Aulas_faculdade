create database erp; /*cria o banco de dados*/

use erp; /*usa o banco de dados*/

drop database erp; /*deleta o banco de dados*/

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

create table endereco (
	id int primary key identity(1,1),
	fk_pessoas int not null,
	tipo int not null,
	pais varchar(100) not null,
	uf varchar(2) not null,
	estado varchar(30)not null,
	cidade varchar(100) not null,
	bairro varchar(100) not null,
	rua varchar(100) not null,
	numero varchar(6),
	complemento varchar(100),
	obs text,
	constraint FK_pessoas_enderecos foreign key
	(fk_pessoas) references pessoas(id) on
	delete cascade on update cascade
);

create table contato(
	id int primary key identity(1,1),
	fk_pessoas int,
	email varchar(100),
	telefone varchar(15),
	constraint Fk_pessoa_contato foreign key
	(fk_pessoas) references pessoas(id) 
	on delete cascade on update cascade
);

create table produtos (
	id int primary key identity(1,1),
	fk_fornecedor int, 
	nome varchar(100),
	imagem text,
	descricao text,
	marca varchar(15),
	categoria varchar(15),
	referencia varchar(15),
	preco_fornecedor decimal(9,2),
	custo decimal(9,2),
	markup_minimo decimal(9,2),
	preco_minimo decimal(9,2),
	markup_venda decimal(9,2),
	preco_venda decimal(9,2),
	constraint FK_fornecedor_produto foreign key
	(fk_fornecedor) references pessoas(id)
	on delete cascade on update cascade
);

create table estoque (
	id int primary key identity(1,1),
	fk_produto int not null,
	cod_barras varchar(15),
	unidade_medida varchar(2),
	cor varchar(50),
	tamanho varchar(50),
	lote varchar(15),
	validade date,
	estoque_minimo int,
	estoque_quantidade int,
	ativo tinyint,	
	constraint FK_estoque_produtos foreign key
	(fk_produto) references produtos(id)
	on delete cascade on update cascade
);