
/* LOCADORA DE AUTOMÓVEIS */
create database DB_Locadora
go
use DB_Locadora
go


/* telefone */

create table TB_Tipo_Tel
(
Cod_Tipo_Tel int primary key identity(1,1),
Descricao varchar(15) NOT NULL,
)
go
/*Cliente */
Create Table Tb_Cliente
(
Cod_Cli int primary key identity(1,1),
NomeCompleto_Cli varchar(50) NOT NULL,
Sexo_Cli char(1) check(Sexo_Cli in('F','M')) NOT NULL,
DataNasc_Cli date NOT NULL,
CPF_Cli char(14) NOT NULL,
RG_Cli char(12) NOT NULL,
Habilitacao char(11) NOT NULL, --11 NUMEROS !!!!
Cat_CNH varchar(3),
Nacionalidade_Cli varchar(30),
Logradouro_Cli varchar(45) NOT NULL,
NumCasa_Cli varchar(6),
Complemento_Cli char(15),
Bairro_Cli varchar(30) NOT NULL,
Cidade_Cli varchar(30) NOT NULL,
Estado_Cli char(2) NOT NULL,
CEP_Cli char(8) NOT NULL,
Email varchar(45),
CaminhoFotoCli varchar(60) --Inserida depois !!!
)

go

Create Table TB_TelCli
(
Cod_Tel_Cli int primary key identity(1,1),
Cod_Cli int NOT NULL,
Telefone varchar(15),
Forma_Tratamento varchar(10),
Cod_Tipo_Tel int NOT NULL,
Constraint FK_ClienteTelefone foreign key(Cod_Cli) references Tb_Cliente(Cod_Cli),
Constraint FK_ClienteTipoTelefone foreign key(Cod_Tipo_Tel) references Tb_Tipo_Tel(Cod_Tipo_Tel)
)
go

/* funcionario */



create table TB_Cargo
(
Cod_Cargo int primary key identity(1,1),
Nome_Cargo varchar(15) NOT NULL,
)
go


Create Table TB_Funcionario
(
Cod_Func int primary key identity(1,1),
Nome_Func varchar(50) NOT NULL,
Sexo_Func char(1) check(Sexo_Func in('F','M')),
CPF_Func char(14) NOT NULL,
DataNasc_Func date NOT NULL,
RG_Func char(12) NOT NULL,
Logradouro_Func varchar(45),
NumCasa_Func int,
Complemento_Func varchar(15),
Bairro_Func varchar(45) NOT NULL,
Cidade_Func varchar(45) NOT NULL,
CEP_Func char(9),
Estado_Func char(2) NOT NULL,
Email varchar(45),
Cod_Cargo int NOT NULL
Constraint FK_Funcionario_Cargo foreign key(Cod_Cargo) references TB_Cargo(Cod_Cargo)
)
go


Create Table TB_Tel_Func
(
Cod_Tel_Func int primary key identity(1,1),
Cod_Func int NOT NULL,
Telefone varchar(15),
Cod_Tipo_Tel int NOT NULL,
Constraint FK_FuncionarioTelefone foreign key(Cod_Func) references TB_Funcionario(Cod_Func),
Constraint FK_FuncionarioTipoTelefone foreign key(Cod_Tipo_Tel) references TB_Tipo_Tel(Cod_Tipo_Tel)
)
go



/*  Carros, categoria
*/
Create Table TB_Categoria
(
Cod_Cat int primary key identity(1,1),
Nome_Cat varchar(20),
Diaria money,
Km_Extra money,
Semana money,
Dia_Extra money
)
insert into TB_Categoria(Nome_Cat,Diaria,Km_Extra,Semana,Dia_Extra) values
('Economica',45.00,0.86,290.00,50.00),

go




create table Tb_Acessorios(
Cod_Acess int primary key identity(1,1),
Descricao_Acess varchar(20),
Sigla_Acess varchar(3)
)
go




create table TB_Situacao_Carro(
Cod_Situacao int primary key identity (1,1),
Situacao varchar(20) NOT NULL
)
insert into TB_Situacao_Carro(Situacao) Values
('Disponivel'),
('Alugado'),
('Em manutenção'),
('Bloqueado'),
('Em preparação'),
('Roubado'),
('A venda'),
('Vendido'),
('Reservado')
go


create table Tb_Tipo_Combustivel(
Cod_Tipo_Combus int primary key identity(1,1),
Descricao varchar(10)
)
go

Create table TB_Seguro
(
Cod_Seguro bit primary key,
Taxa_Seguro smallint NOT NULL
)
GO


Create Table TB_Carro
(
Cod_Carro int primary key identity(1,1),
Cod_Cat int NOT NULL,
Placa char(8) NOT NULL,
Modelo varchar(45) NOT NULL,
Cor varchar(25) NOT NULL,
Marca varchar(45) NOT NULL,
Data_Fabricacao date NOT NULL,
Cod_Tipo_Combus int NOT NULL,
Renavam char(11) NOT NULL,
Chassi char(17) NOT NULL,
Ano char(4) NOT NULL,
Cod_Situacao int NOT NULL,
Status_Carro bit NOT NULL,
Constraint FK_Carro_Categoria foreign key(Cod_Cat) references TB_Categoria(Cod_Cat),
Constraint FK_CArro_Situacao foreign key(Cod_Situacao) references Tb_Situacao_Carro(Cod_Situacao),
constraint Fk_Carro_Tipo_Combus foreign key(Cod_Tipo_Combus) references Tb_Tipo_Combustivel(Cod_Tipo_Combus),
)
go

create table TB_Acessorios_Carro(
Cod_Carro int primary key identity(1,1),
Cod_Acess_Carro int 
constraint FK_Acess_Carro foreign key(COd_Acess_Carro) references Tb_Acessorios(Cod_Acess),
constraint FK_Carro_Acess foreign key(Cod_Carro) references TB_Carro(Cod_Carro)
)
go

/* aluguel */



Create Table TB_Aluguel
(
Cod_Aluguel int primary key identity(1,1),
Cod_Cli int NOT NULL,
Cod_Func int NOT NULL,
Cod_Carro int NOT NULL,
Cod_seguro bit NOT NULL,
Condutor_Principal varchar(15) NOT NULL,
Tipo_Tarifa varchar(20) NOT NULL,
Data_Retirada date NOT NULL,
Data_Entrega date NOT NULL,
Condicao_Entrega varchar(45),
Preco_Final money,
Constraint FK_Cliente Foreign key(Cod_Cli) references TB_Cliente(Cod_Cli),
Constraint FK_Funcionario1 Foreign key(cod_Func) references TB_Funcionario(Cod_Func),
Constraint FK_Aluguel_Carro Foreign Key(Cod_Carro) references TB_Carro(Cod_Carro),
constraint FK_Aluguel_Seguro foreign key(Cod_Seguro) references TB_Seguro(Cod_Seguro)
)
go
/* HISTORIO DE CARROS */


create table TB_Historico_Carro(
Cod_Hist_Carro int primary key identity(1,1),
Hodometro_inicial int NOT NULL,
Hodometro_Final int NOT NULL,
Qtde_Combus varchar(3) NOT NULL,
Cod_Aluguel int,
Cod_Carro int,
Observacoes varchar(150),
constraint FK_Hist_Carro foreign key(Cod_carro) references Tb_Carro(Cod_Carro),
constraint FK_Hist_Aluguel foreign key(Cod_Aluguel) references TB_Aluguel(Cod_Aluguel)
)
go


/* finanças */

create table Tb_Contas_Pagas
(
Cod_Pagamento int primary key identity(1,1),
Cod_Func int NOT NULL,
Cod_Conta int NOT NULL,
MesReferencia varchar(15),
Data_Venc date NOT NULL,
Data_Pgto date NOT NULL,
Valor_Pago money NOT NULL,
Valor_Conta money NOT NULL,
Constraint FK_FuncionarioPagante foreign key(Cod_Func) references TB_Funcionario(Cod_Func)
)


Create Table Tb_Contas
(
Cod_Conta int primary key identity(1,1),
Descrição varchar(10) NOT NULL,
Cod_Pagamento int NOT NULL,
Constraint PK_Contas foreign key(cod_Pagamento) references Tb_Contas_Pagas(Cod_Pagamento)
)




/* Login */


create table Login(
cod_func int primary key,
senha_func varchar(10),
tipo_login smallint
)
