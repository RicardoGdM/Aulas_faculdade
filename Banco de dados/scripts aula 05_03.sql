insert into pessoas (
	tipo, nome, status, email, data_nasc, fornecedor, transportadora, representante, funcionario, parceiro_comercial
	)
	values (
	2, 'Ricardo Gomes de Moraes', 1, 'teste@teste.com', '1995-09-09', 0, 0, 0, 0, 0
	);

select * from pessoas;

update pessoas set 
	tipo = 3, 
	nome = 'Dona Florinda', 
	data_nasc = '1958-12-25',
	fornecedor = 1 
where id = 1;

insert into endereco (
	fk_pessoas, tipo, pais, uf, estado, cidade, bairro, rua, numero, complemento, obs
) values (
	1, 1, 'Brasil', 'SP', 'São Paulo', 'Americana', 'Centro', 'Rua principal','100', 'Sala 2', 'Ao lado de lá'
);

select * from endereco;

insert into contato (
	fk_pessoas, email, telefone
) values (
	1, 'teste2@teste.com', '(19)99302-9444'
);