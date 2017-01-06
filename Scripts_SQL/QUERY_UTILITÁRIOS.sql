/* RESET DE TODOS OS REGISTROS DE CADA TABELA */

DBCC Checkident(Tb_carro,reseed,0)




/* TROCAR A LINGUAGEM DO SQL SERVER */

  select @@LANGUAGE,@@LANGID from syslanguages where @@LANGID = 0
  select name from syslanguages where langid = 0
  exec sp_configure 'default language' , 0
  exec sp_defaultlanguage 'sa', 'us_english'
  reconfigure




/* LISTA TODAS AS CONSTRAINTS DO DATABASE */

SELECT
KCU1.CONSTRAINT_NAME AS 'FK_Nome_Constraint'
, KCU1.TABLE_NAME AS 'FK_Nome_Tabela'
, KCU1.COLUMN_NAME AS 'FK_Nome_Coluna'
, FK.is_disabled AS 'FK_Esta_Desativada'
, KCU2.CONSTRAINT_NAME AS 'PK_Nome_Constraint_Referenciada'
, KCU2.TABLE_NAME AS 'PK_Nome_Tabela_Referenciada'
, KCU2.COLUMN_NAME AS 'PK_Nome_Coluna_Referenciada'
FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1
ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG
AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA
AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2
ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG
AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA
AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME
AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION
JOIN sys.foreign_keys FK on FK.name = KCU1.CONSTRAINT_NAME
Order by
KCU1.TABLE_NAME

/* RENOMEAR UMA COLUNA/CAMPO DA TABELA */
exec sp_rename 'NOME_DA_TABELA.NOME_DO_CAMPO','NOME_DO_NOVO_CAMPO','column'


/* RENOMEAR/ALTERAR O NOME DE UMA TABELA */
sp_rename 'NOME_DA_TABELA','NOME_DA_NOVA_TABELA'


/* CADASTRO DE CATEGORIAS - BASE DE TESTE */
exec dbo.sp_CadCategoria @Nome_cat = 'Executivo',@Diaria = 115.00, @Km_Extra = 1.10, @Semana = 979.00, @Dia_Extra = 120.00




/* CADASTRO DE CARROS - BASE DE TESTE */
exec dbo.sp_CadCarro @Cod_Cat = 2, @Placa = 'DWY-9980', @Modelo = 'Fusion', @Cor = 'Preto', @Marca = 'Ford',
@Data_Fabricacao = '01/01/2013',@Cod_Tipo_Combus = 3, @Renavam = '00000000005', @Chassi = '00000000000000005',
@Ano = '2013', @Cod_Situacao = '1', @Status_Carro = '1'



/*SELECT DE INFORMAÇÕES DOS CARROS E SUAS CATEGORIAS*/
select dbo.Tb_carro.Cod_Carro,dbo.Tb_carro.Placa,dbo.TB_Carro.Modelo,dbo.TB_Carro.Marca,dbo.TB_Carro.Ano,dbo.TB_Categoria.Nome_Cat,dbo.Tb_Tipo_Combustivel.Descricao as 'Combustivel' from Tb_Carro, Tb_Categoria,Tb_Tipo_Combustivel where
Tb_Carro.Cod_Cat = Tb_Categoria.Cod_Cat and Tb_Carro.Cod_Tipo_Combus = Tb_Tipo_Combustivel.Cod_Tipo_Combus



/*SELECT PARA PESQUISAR O CLIENTE*/
select Tb_CLiente.*,TB_TelCli.* from Tb_Cliente Inner Join TB_TelCLi on Tb_Cliente.Cod_Cli = TB_TelCLi.Cod_Cli 
where NomeCompleto_Cli like '%%'



/*SELECT TESTE PARA BUSCAR UM REGISTRO DO CLIENTE COM O TELEFONE*/
select Tb_CLiente.*,TB_TelCli.* from Tb_Cliente Inner Join TB_TelCLi on Tb_Cliente.Cod_Cli = TB_TelCLi.Cod_Cli
where Tb_Cliente.Cod_Cli = '3'



/*SELECT PARA A TABELA DO HISTÓRICO DO CARRO*/
SELECT [Hodometro_Final] 
     ,[Qtde_Combus_Atual]
      ,[Observacoes]
  FROM [DB_Locadora].[dbo].[TB_Historico_Carro] where Cod_Carro = 1


  /*INSERT TESTE DE HISTÓRICO*/
  exec sp_CriaHistoricoCarro @Hodometro_inicial = 0, @Hodometro_final = 0, @Qtde_Combus_Antigo = '1/1', 
  @Qtde_Combus_Atual = '1/1', @Cod_Carro = 9, @Observacoes = 'OK'

  /*EXECUTA PROCEDURE PARA PESQUISAR FUNCIONARIO*/
 exec sp_consultafunc @Cod_func = 1

 /* SELECT QUE MOSTRA O NOME E CÓDIGO LOGIN DO FUNCIONÁRIO */
  select Cod_func as 'Código do funcionário',Nome_Func as 'Nome completo' from TB_Funcionario where Nome_Func like '%o%'

  /*SELECT DA CATEGORIA COM OS VALORES PARA O ALUGUEL*/
  select Nome_Cat,Diaria,Km_Extra,Semana,Dia_Extra from Tb_Categoria

  
/* CADASTRO DE CATEGORIAS - BASE DE TESTE */
exec dbo.sp_CadCategoria @Nome_cat = 'Executivo',@Diaria = 115.00, @Km_Extra = 1.10, @Semana = 979.00, @Dia_Extra = 120.00


/* CADASTRO DE CARROS - BASE DE TESTE */
exec dbo.sp_CadCarro @Cod_Cat = 2, @Placa = 'DWY-9980', @Modelo = 'Fusion', @Cor = 'Preto', @Marca = 'Ford',
@Data_Fabricacao = '01/01/2013',@Cod_Tipo_Combus = 3, @Renavam = '00000000005', @Chassi = '00000000000000005',
@Ano = '2013', @Cod_Situacao = '1', @Status_Carro = '1'


/* SELECT DE ALUGUEL EM PROGRESSO PELO CLIENTE */

  SELECT Tb_cliente.Cod_Cli,TB_Cliente.NomeCompleto_Cli,TB_Cliente.RG_Cli,TB_Cliente.DataNasc_Cli, TB_Cliente.Habilitacao,TB_Cliente.Cat_CNH,
   TB_Aluguel.Condutor_Principal,TB_Aluguel.Cod_Aluguel,TB_Aluguel.Data_Retirada,TB_Aluguel.Cod_seguro,TB_Aluguel.Data_Entrega,TB_Aluguel.HoraRetirada,TB_Aluguel.HoraEntrega,TB_Aluguel.condicao_Entrega,
    TB_Aluguel.Preco_Final,TB_Carro.Placa,TB_Carro.Modelo,TB_Carro.Ano,TB_Carro.Marca,TB_Categoria.Nome_Cat, 
    TB_Historico_Carro.Hodometro_inicial,TB_Historico_Carro.Qtde_Combus_Antigo,TB_Historico_Carro.Observacoes from
    TB_Cliente,TB_Aluguel,TB_Carro,TB_Historico_Carro,TB_Categoria
    where
    Tb_Cliente.Cod_Cli = TB_Aluguel.Cod_Cli
	and
    TB_Carro.Cod_Carro = TB_Aluguel.Cod_Carro
    and
    TB_Carro.Cod_Carro = TB_Historico_Carro.Cod_Carro
    and
    TB_Carro.Cod_Cat = TB_Categoria.Cod_Cat
    and
    TB_Aluguel.Status_Aluguel = 'EM PROGRESSO'
    and
    TB_Aluguel.Cod_Aluguel = 0

/* SELECT DE INFORMAÇÕES BASICAS DE ALUGUEL EM PROGRESSO PELO CLIENTE */
SELECT Tb_Aluguel.Cod_Aluguel as 'Cod. Aluguel',TB_Aluguel.Status_Aluguel as 'Status do aluguel', Tb_Cliente.NomeCompleto_Cli as 'Nome do cliente',TB_Aluguel.Data_Retirada as 'Data de retirada',TB_Carro.Modelo as 'Carro'
from
TB_Aluguel,Tb_Cliente,TB_Carro
where
Tb_Cliente.NomeCompleto_Cli like '%%'
and
TB_Aluguel.Cod_Carro = TB_Carro.Cod_Carro