--Jean Grey vai estudar todos os dias.
INSERT INTO Semana (dia, fk_professor, fk_aluno, fk_disciplina, fk_sala)
VALUES
	('Segunda-feira', 1, 2, 1, 1),
	('Terça-feira', 1, 2, 2, 2),
	('Quarta-feira', 1, 2, 3, 3),
	('Quinta-feira', 1, 2, 4, 4),
	('Sexta-feira', 1, 2, 5, 5);

INSERT INTO Nota (fk_aluno, fk_disciplina, pontos)
VALUES 
	(2, 1, 950),
	(2, 2, 1000),
	(2, 3, 800),
	(2, 4, 875),
	(2, 5, 975);

--Preencha o calendário de aula com apenas 2 dias da semana para Scoot
INSERT INTO Semana (dia, fk_professor, fk_aluno, fk_disciplina, fk_sala)
VALUES
	('Segunda-feira', 1, 3, 1, 1),
	('Sexta-feira', 1, 3, 5, 5);

INSERT INTO Nota (fk_aluno, fk_disciplina, pontos)
VALUES 
	(3, 1, 650),
	(3, 5, 950);

--e 3 dias da semana para Vampira.
INSERT INTO Semana (dia, fk_professor, fk_aluno, fk_disciplina, fk_sala)
VALUES
	('Segunda-feira', 1, 4, 1, 1),
	('Terça-feira', 1, 4, 2, 2),
	('Quarta-feira', 1, 4, 3, 3);

INSERT INTO Nota (fk_aluno, fk_disciplina, pontos)
VALUES 
	(4, 1, 940),
	(4, 2, 800),
	(4, 3, 1000);