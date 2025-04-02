CREATE DATABASE SimuladoProva;

USE SimuladoProva;

CREATE TABLE Clientes (
	id INT PRIMARY KEY IDENTITY,
	nome VARCHAR(100) NOT NULL,
	idade INT NOT NULL,
	fk_cidade INT NOT NULL
	CONSTRAINT fk_cidade FOREIGN KEY
	(fk_cidade) REFERENCES Cidades(id)
	ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Cidades (
	id INT PRIMARY KEY IDENTITY,
	cidade VARCHAR(100) NOT NULL,
	uf VARCHAR(2) NOT NULL
);

select * from Cidades;

Select * from Clientes;

SELECT c.id, c.nome, c.idade,c.fk_cidade, cid.cidade, cid.uf FROM Clientes c LEFT JOIN Cidades cid ON c.fk_cidade = cid.id;

UPDATE Clientes nome = nome, idade = idade, fk_cidade = fk_cidade WHERE id = @id