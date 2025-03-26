insert into pessoas (
	tipo, nome, status, email, data_nasc, fornecedor, transportadora, representante, funcionario, parceiro_comercial
	)
values (
	2, 'Ricardo Gomes de Moraes', 1, 'teste@teste.com', '1995-09-09', 0, 0, 0, 0, 0
	);

insert into pessoas (
	tipo, nome, status, email, data_nasc, fornecedor, transportadora, representante, funcionario, parceiro_comercial
	)
values (
	1, 'Jo�o Ant�nio', 1, 'joao@teste.com', '1985-09-09', 1, 0, 0, 0, 0
	);

insert into pessoas (
	tipo, nome, status, email, data_nasc, fornecedor, transportadora, representante, funcionario, parceiro_comercial
	)
	values (
	1, 'Maria Cristina', 1, 'maria@teste.com', '2005-09-09', 0, 0, 0, 1, 0
	);

select * from pessoas;

select * from pessoas where fornecedor = 1;

update pessoas set 
	tipo = 3, 
	nome = 'Dona Florinda', 
	data_nasc = '1958-12-25',
	fornecedor = 1 
where id = 1;

insert into endereco (
	fk_pessoas, tipo, pais, uf, estado, cidade, bairro, rua, numero, complemento, obs
) values (
	1, 1, 'Brasil', 'SP', 'S�o Paulo', 'Americana', 'Centro', 'Rua principal','100', 'Sala 2', 'Ao lado de l�'
);

insert into endereco (
	fk_pessoas, tipo, pais, uf, estado, cidade, bairro, rua, numero, complemento, obs
) values (
	2, 1, 'Brasil', 'RJ', 'Rio de Janeiro', 'Rio de Janeiro', 'Centro', 'Rua principal','1000', 'Sala 20', 'Ao lado de c�'
);

insert into endereco (
	fk_pessoas, tipo, pais, uf, estado, cidade, bairro, rua, numero, complemento, obs
) values (
	3, 1, 'Brasil', 'SP', 'S�o Paulo', 'Santa B�rbara d Oeste', 'Centro', 'Rua principal','200', 'Sala 2', 'Ao lado de l�'
);

select * from endereco;

insert into contato (
	fk_pessoas, email, telefone
) values (
	1, 'teste2@teste.com', '(19)99302-9444'
);

insert into contato (
	fk_pessoas, email, telefone
) values (
	3, 'joao@teste.com', '(19)99302-9555'
);