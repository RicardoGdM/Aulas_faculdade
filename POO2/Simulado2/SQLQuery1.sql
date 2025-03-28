create database Cad_clientes;

use Cad_clientes;

DROP TABLE Clientes;

CREATE TABLE Clientes (
	id INT PRIMARY KEY IDENTITY,
	fk_cliente_cidade int not null,
	nome VARCHAR(100) NOT NULL,
	idade INT NOT NULL
	CONSTRAINT Fk_cliente_cidade FOREIGN KEY
	(fk_cliente_cidade) references Cidades(id)
	ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Cidades (
	id INT PRIMARY KEY IDENTITY,
	cidade VARCHAR(100) NOT NULL,
	estado VARCHAR(2) NOT NULL
);

select * from Clientes;

select * from Cidades;