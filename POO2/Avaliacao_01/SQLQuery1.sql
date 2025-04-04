CREATE DATABASE db_avaliacao;

USE db_avaliacao;

CREATE TABLE clientes (
	id INT PRIMARY KEY IDENTITY,
	nome VARCHAR(100) NOT NULL,
	empresa VARCHAR (100) NOT NULL,
	email VARCHAR(100)
);

CREATE TABLE tipo_servico (
	id INT PRIMARY KEY IDENTITY,
	servico VARCHAR(100) NOT NULL,
	valor DECIMAL(9,2) NOT NULL
);

INSERT INTO tipo_servico (servico, valor) VALUES 
('Desenvolvimento de Software', 5000.00),
('Suporte Técnico', 200.00),
('Consultoria em TI', 1500.00),
('Gerenciamento de Servidores', 2500.00),
('Segurança da Informação', 3000.00),
('Manutenção de Computadores', 150.00),
('Configuração de Rede', 800.00),
('Criação de Websites', 3500.00),
('Banco de Dados e Administração', 2800.00),
('Computação em Nuvem', 4000.00);

CREATE TABLE manutencoes_realizadas (
	id INT PRIMARY KEY IDENTITY,
	fk_tipo_servico INT NOT NULL,
	fk_cliente INT NOT NULL,
	data_servico DATE NOT NULL,
	CONSTRAINT Fk_tipo_servico FOREIGN KEY
	(fk_tipo_servico) REFERENCES tipo_servico(id),
	CONSTRAINT Fk_cliente FOREIGN KEY 
	(fk_cliente) REFERENCES clientes(id)
	ON DELETE CASCADE ON UPDATE CASCADE
);

SELECT * FROM clientes;

SELECT id, servico, valor FROM tipo_servico;

SELECT * FROM manutencoes_realizadas;

SELECT 
manu.id, c.nome, c.empresa, s.servico, manu.data_servico 
FROM manutencoes_realizadas AS manu 
LEFT JOIN clientes c ON manu.fk_cliente = c.id 
LEFT JOIN tipo_servico s ON manu.fk_tipo_servico = s.id
ORDER BY c.id DESC;