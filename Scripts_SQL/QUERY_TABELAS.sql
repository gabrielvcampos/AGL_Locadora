
/* LOCADORA DE AUTOMÓVEIS */
create database DB_Locadora
go
use DB_Locadora
go




 /* TELEFONE - TIPO */

create table TB_Tipo_Tel
(
Cod_Tipo_Tel int primary key identity(1,1),
Descricao varchar(15) NOT NULL,
)



go



/*CLIENTE */
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
CEP_Cli char(9) NOT NULL,
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




/* CARGO */

create table TB_Cargo
(
Cod_Cargo int primary key identity(1,1),
Nome_Cargo varchar(15) NOT NULL,
)


go



/* FUNCIONÁRIO */

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
Cod_Cargo int NOT NULL,
CaminhoFoto_Func varchar(60)
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



/*  TABELA DE CATEGORIA DOS CARROS*/

Create Table TB_Categoria
(
Cod_Cat int primary key identity(1,1),
Nome_Cat varchar(40),
Diaria money,
Km_Extra money,
Semana money,
Dia_Extra money
)



go



/* ACESSÓRIOS */
create table Tb_Acessorios(
Cod_Acess int primary key identity(1,1),
Descricao_Acess varchar(20),
Sigla_Acess varchar(3)
)
go



/* TABELA DE SITUAÇÃO DO CARRO*/
create table TB_Situacao_Carro(
Cod_Situacao int primary key identity (1,1),
Situacao varchar(20) NOT NULL
)



go



/*TABELA DE TIPO DO COMBUSTÍVEL DO CARRO*/

create table Tb_Tipo_Combustivel(
Cod_Tipo_Combus int primary key identity(1,1),
Descricao varchar(10)
)



go




/* SEGURO DOS CARROS - ESCOLHIDO NA HORA DO ALUGUES */

Create table TB_Seguro
(
Cod_Seguro bit primary key,
Taxa_Seguro smallint NOT NULL
)


GO

/* TABELA DOS CARROS */


Create Table TB_Carro
(
Cod_Carro int primary key identity(1,1),
Cod_Cat int NOT NULL,
Placa char(8) NOT NULL,
Modelo varchar(100) NOT NULL,
Cor varchar(25) NOT NULL,
Marca varchar(45) NOT NULL,
Data_Fabricacao date NOT NULL,
Cod_Tipo_Combus int NOT NULL,
Renavam char(11) NOT NULL,
Chassi char(17) NOT NULL,
Ano char(4) NOT NULL,
Cod_Situacao int NOT NULL,
Status_Carro bit NOT NULL,
Caminho_Foto varchar(65),
Constraint FK_Carro_Categoria foreign key(Cod_Cat) references TB_Categoria(Cod_Cat),
Constraint FK_CArro_Situacao foreign key(Cod_Situacao) references Tb_Situacao_Carro(Cod_Situacao),
constraint Fk_Carro_Tipo_Combus foreign key(Cod_Tipo_Combus) references Tb_Tipo_Combustivel(Cod_Tipo_Combus),
)


go



/*TABELA DE ACESSÓRIOS DA CATEGORIA*/


create table TB_Acessorios_Categoria(
Cod_Cat int,
Cod_Acess int 
constraint FK_Acess_Carro foreign key(Cod_Acess) references Tb_Acessorios(Cod_Acess),
CONSTRAINT FK_Acessorio_Categoria foreign key(Cod_Cat) REFERENCES Tb_Categoria(Cod_Cat)
)


go

/* tabela de acessorios do carro */
create table TB_Acessorios_Carro(
Cod_Carro int,
Cod_Acess int 
constraint FK_Acess_Carro2 foreign key(Cod_Acess) references Tb_Acessorios(Cod_Acess),
CONSTRAINT FK_Acessorio_Carro foreign key(Cod_Carro) REFERENCES Tb_Carro(Cod_Carro)
)


go



/* ALUGUEL DOS CARROS */

Create Table TB_Aluguel
(
Cod_Aluguel int primary key identity(1,1),
Cod_Cli int NOT NULL,
Cod_Func int NOT NULL,
Cod_Carro int NOT NULL,
Cod_seguro bit NOT NULL,
Condutor_Principal varchar(15) NOT NULL,
Data_Retirada date NOT NULL,
Data_Entrega date NOT NULL,
Horaretirada varchar(8),
HoraEntrega varchar(8),
Condicao_Entrega varchar(45),
Preco_Final money,
Status_Aluguel varchar(12),
Preco_Final_Real money
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
Hodometro_Final int,
Qtde_Combus_Antigo varchar(3) NOT NULL,
Qtde_Combus_Atual varchar(3),
Cod_Ultimo_Aluguel int,
Cod_Aluguel_Atual int,
Cod_Carro int,
Observacoes varchar(150),
constraint FK_Hist_Carro foreign key(Cod_carro) references Tb_Carro(Cod_Carro),
constraint FK_Hist_Aluguel foreign key(Cod_Aluguel_Atual) references TB_Aluguel(Cod_Aluguel)
)


go

/*    TABELA QUE ARMAZENA TODAS AS ALTERAÇÕES FEITAS NA TB_HISTORICO_CARRO      */

create table TB_Updates_Historico_Carro(
Cod_update int identity(1,1),
Cod_Carro smallint,
Data_Update datetime,
Coluna_alterada sysname,
Valor_Antigo varchar(150),
Valor_Novo varchar(150)
)
go


/* FINANCEIRO  CONTAS E CONTAS A PAGAR */

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

go

Create Table Tb_Contas
(
Cod_Pagamento int NOT NULL,
Cod_Func int not null,
Cod_Conta int primary key identity(1,1),
Descricao varchar(10) NOT NULL,
MesReferencia varchar(15) not null,
Data_Venc date not null,
Data_Pgto date not null,
Valor_Pago money,
Valor_Conta money not null,
Status_Conta varchar(10) not null,
Constraint PK_Contas foreign key(cod_Pagamento) references Tb_Contas_Pagas(Cod_Pagamento)
)

go
select * from TB_Contas

/* LOGIN DOS FUNCIONÁRIOS */


create table Login(
cod_func int primary key,
senha_func varchar(10),
tipo_login smallint
)

go


/* VALORES DO COMBUSTÍVEL DO CARRO */

  create table TB_ValoresCombustivel
  (
  Fracao varchar(3) NOT NULL,
  Valor smallint NOT NULL
  )

  go
  

  /* TABELA DE CONTATO PELO SITE */
  
  Create table Tb_ContatoSite
  (
  ID int identity(1,1) primary key,
  Cod_Cli int,
  Cod_Func int,
  Nome varchar(50),
  Email varchar(80),
  Endereco varchar(200),
  Telefone varchar(14),
  Mensagem varchar(300)
  Constraint FK_Cliente_Site foreign key (Cod_Cli) references Tb_Cliente(Cod_Cli),
  Constraint FK_Func_Site foreign key (Cod_Func) references Tb_Funcionario(Cod_Func)
  )

Select * from Tb_ContatoSite
  

  


  /*TABELA DE RESERVA PELO SITE */
  
  CREATE TABLE Tb_ReservaSite
  (
  ID int identity(1,1) primary key,
  Cod_Func int,
  Nome varchar(50),
  Endereco varchar(200),
  Telefone varchar(14),
  Cidade varchar(40),
  Email varchar(80),
  Veiculo varchar(30),
  Data_Inicio date,
  Mensagem varchar(300),
  Constraint Func_Reserva foreign key (Cod_Func) references Tb_Funcionario(Cod_Func)
  )

  Select * from Tb_ReservaSite