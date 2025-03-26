use erp;



create table pedidos(
	id int primary key identity,
	fk_pessoas int not null,
	status tinyint not null,
	constraint Fk_Pedidos_pessoa foreign key (fk_pessoas)
	references pessoas(id) on delete cascade on update cascade
);

create table pedido_item (
	id int primary key identity,
	fk_pedidos int not null,
	fk_estoque int not null,
	preco_venda decimal(9,2),
	quantidade int not null,
	constraint Fk_Pedido_Item_pedidos foreign key (fk_pedidos)
	references pedidos(id), --on delete cascade on update cascade,
	constraint Fk_Pedido_Item_Estoque foreign key (fk_estoque)
	references estoque(id) --on delete cascade on update cascade
);

insert into produtos(
	fk_fornecedor, nome, imagem, descricao, marca, categoria, referencia, preco_fornecedor,
	custo, markup_minimo, markup_venda, preco_venda
) values (
	1, 'Pudim', 'https://www.pudim.com.br/pudim.jpg', 'Pudim comestível', 'Positivo',
	'Padaria', 'P-001', '2.99', '2.99', '0', '0', 29.99
);

insert into produtos(
	fk_fornecedor, nome, imagem, descricao, marca, categoria, referencia, preco_fornecedor,
	custo, markup_minimo, markup_venda, preco_venda
) values (
	1, 'Café', 'https://m.media-amazon.com/images/I/61cjsci53VL._AC_SL1000_.jpg', 'Café torrado', 'Cafezin',
	'Cafeteria', 'C-001', '2.99', '2.99', '0', '0', 49.99
);

insert into estoque(
	fk_produto, cod_barras, unidade_medida, cor, tamanho, lote, validade,
	estoque_minimo, estoque_quantidade, ativo
) values(
	1, '00000001', 'UN', 'Padrão', 'M', '2025-03-19-A', '2025-03-22', '3', '8', 1
);

insert into estoque(
	fk_produto, cod_barras, unidade_medida, cor, tamanho, lote, validade,
	estoque_minimo, estoque_quantidade, ativo
) values(
	2, '00048523', 'UN', 'Padrão', 'M', '2025-01-19-A', '2025-07-22', '3', '15', 1
);

insert into pedidos (
	fk_pessoas, status
)values (
	1, 1
);

insert pedido_item (
	fk_pedidos, fk_estoque, quantidade, preco_venda
) values (
	1, 1, 5, '10.50'
);

select * from pessoas;
select * from endereco;
select * from contato;
select * from produtos;
select * from estoque;
select * from pedidos;
select * from pedido_item;


select 
	-- Pedido
	p.status AS status_pedido,
	p.id AS cod_pedido,

	-- Pessoa
	pe.nome as nome_pessoa

from pedidos p 
left join pessoas pe on p.fk_pessoas = pe.id
left join pedido_item pi on pi.fk_pedidos = p.id;

/*LEFT JOIN exibe todos os resultados, priorizando a tabela da esquerda*/
SELECT 
	-- pessoas
	p.id AS pessoa_id,
	p.nome,
	p.email,

	-- enderecos
	e.id AS pessoa_id,
	e.uf,
	e.cidade,

	-- contato
	c.telefone

FROM pessoas p
LEFT JOIN endereco e ON p.id = e.fk_pessoas
LEFT JOIN contato c ON p.id = c.fk_pessoas;

/* RIGHT JOIN trás somente os dados que estão completos, dando prioridade a tabela da direita*/
SELECT 
	-- pessoas
	p.id AS pessoa_id,
	p.nome,
	p.email,

	-- enderecos
	e.id AS pessoa_id,
	e.uf,
	e.cidade
FROM pessoas p
RIGHT JOIN endereco e ON p.id = e.fk_pessoas;

SELECT 
	-- produtos
	p.id AS produto_id,
	p.nome,
	p.imagem,
	p.descricao,

	-- fornecedor
	pes.id AS id_fornecedor,
	pes.nome AS nome_fornecedor,
	pes.email,
	-- ESTOQUE
	e.cod_barras,
	e.unidade_medida,
	e.cor,
	e.validade
FROM produtos p
LEFT JOIN estoque e ON p.id = e.fk_produto
LEFT JOIN pessoas pes ON p.fk_fornecedor = pes.id
WHERE e.ativo = 1;