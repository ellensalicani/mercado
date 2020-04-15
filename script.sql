create database firma;

use firma; 

create table funcionarios(
	username varchar(6),
    id int auto_increment,
    senha varchar(6),
    cpf varchar(11),
    nome_completo varchar(255),
    idade int(2),
    email varchar(100),
    cargo varchar(20),
    ddd int(2),
    telefone int(10),
    pais varchar(30),
    estado varchar(30),
    rua varchar(100),
    numero int(4),
    bairro varchar(50),
    cep int(8),
    cidade varchar(50),
    primary key(id)
);

create table cliente(
	nome_completo varchar(255),
    id int auto_increment,
    cpf varchar(11),
    ddd int(2),
    telefone int(10),
    email varchar(100),
    data_nascimento date,
    pais varchar(30),
    estado varchar(30),
    rua varchar(100),
    numero int(4),
    bairro varchar(50),
    cep int(8),
    cidade varchar(50),
    primary key(id)
);

create table fornecedor(
	codigo_fornecedor int auto_increment,
    cnpj varchar(14),
    razao_social varchar(100),
    nome_fantasia varchar(100),
    ddd int(2),
    telefone int(10),
    ramal int(4),
    pais varchar(30),
    estado varchar(30),
    rua varchar(100),
    numero int(4),
    bairro varchar(50),
    cep int(8),
    cidade varchar(50),
    primary key(codigo_fornecedor)
);

create table produto(
	codigo_produto int auto_increment,
    nome_produto varchar(100),
    preco_compra decimal(8,2),
    data_vencimento date,
    id_fornecedor int,
    categoria varchar(50),
    qnt_estoque int(4),
    codigo_barra varchar(100),
    preco_venda decimal(8,2),
    primary key(codigo_produto),
    foreign key(id_fornecedor) references fornecedor(codigo_fornecedor)
);

create table compra(
	codigo_compra int auto_increment,
    id_produto int, 
    preco decimal(8,2),
    primary key(codigo_compra),
    foreign key(id_produto) references produto(codigo_produto)
);

create table servico(
	codigo_servico int auto_increment,
    descricao_servico varchar(255),
    id_cliente int,
    valor_servico decimal(8,2),
    primary key(codigo_servico),
    foreign key(id_cliente) references cliente(id)
);

create table forma_pagamento(
	codigo int auto_increment,
    tipo_pagamento varchar(50),
    primary key(codigo)
);

create table venda(
	codigo_venda int auto_increment,
    id_produto int,
    id_cliente int, 
    valor_unitario decimal(8,2),
    valor_total decimal(8,2),
    qnt_produto int,
    datahora_venda datetime,
    primary key(codigo_venda),
    foreign key(id_produto) references produto(codigo_produto),
    foreign key(id_cliente) references cliente(id)
);

create table fatura(
	codigo_fatura int auto_increment,
    valor_total decimal(8,2),
    id_cliente int,
    data_pagamento date,
    data_vencimento date,
    primary key(codigo_fatura),
    foreign key(id_cliente) references cliente(id)
);

insert into forma_pagamento(tipo_pagamento) values('A Vista'),('Cartão de Debito'),('Cartão de Crédito A vista'),('Parcelado');

insert into funcionarios(username, senha, cpf, nome_completo, idade, email, cargo, ddd, telefone, pais, estado, rua, numero, bairro, cep, cidade)
values('esalic','admin1', '44443923802', 'Ellen Salicani', 23, 'ec.salicani8@gmail.com', 'admin', 19, '983902199', 'Brasil', 'Sao Paulo', 'Conego Nery', 112,'Guanabara',13073180,'Campinas');
