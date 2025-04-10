INSERT INTO Escola (nome) 
	VALUES ('EMEF Jhon Connor');

INSERT INTO Aluno (fk_escola, nome)
VALUES 
	(1 ,'Magneto'),
	(1,'Jean Grey'),
	(1,'Scoot'),
	(1,'Vampira');
	

INSERT INTO Professor (fk_escola, nome)
	VALUES
		(1,'Charles Xavier'),
		(1, 'Wolverine'),
		(1, 'Tempestade');

INSERT INTO Curso (nome)
	VALUES
	('Matemática Indiscreta'),
	('Astrologia');

INSERT INTO Disciplina (fk_curso, nome)
	VALUES
	(2, 'Ciências'),
	(1, 'IndiscretaTecnologia'),
	(1, 'IndiscretaArtes Marciais'),
	(1, 'IndiscretaCombate'),
	(2, 'História');

INSERT INTO Bloco (nome)
VALUES
	('A'),
	('B'),
	('C'),
	('D'),
	('E');

INSERT INTO Sala (fk_bloco, nome)
VALUES
	(1, '1'),
	(1, '2'),
	(2, '3'),
	(2, '4'),
	(3, '5'),
	(3, '6'),
	(4, '7'),
	(4, '8'),
	(5, '9'),
	(5, '10');