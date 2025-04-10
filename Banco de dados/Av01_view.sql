SELECT 
	c.nome AS nome_curso,
	d.nome AS disciplina_nome,
	a.nome AS aluno_nome
FROM Curso c
RIGHT JOIN Disciplina d ON c.id = fk_curso
RIGHT JOIN Semana s ON s.fk_disciplina  = d.id 
RIGHT JOIN Aluno a ON s.fk_aluno = a.id;

SELECT * FROM Disciplina;

create view aluno_nota as
Select 
	a.nome as nome_aluno,
	d.nome as disciplina,
	n.pontos AS nota
From Aluno a
LEFT JOIN Nota n ON fk_aluno = a.id
left join Disciplina d ON n.fk_aluno = d.id;