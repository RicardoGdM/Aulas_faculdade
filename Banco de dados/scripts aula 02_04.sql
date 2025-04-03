USE erp;

CREATE VIEW VW_pessoas AS
	SELECT 
	-- PESSOAS
	p.nome,

	-- CIDADE
	e.cidade,

	-- CONTATO
	c.email

FROM pessoas p 
LEFT JOIN endereco e ON e.fk_pessoas = p.id
LEFT JOIN contato c ON c.fk_pessoas = p.id;

SELECT * FROM VW_pessoas;

--DROP VIEW VW_pessoas;