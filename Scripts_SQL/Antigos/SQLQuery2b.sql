/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT [Hodometro_Final] 
     ,[Qtde_Combus_Atual]
      ,[Observacoes]
  FROM [DB_Locadora].[dbo].[TB_Historico_Carro] where Cod_Carro = 1

  select * from tb_carro
  exec sp_CriaHistoricoCarro @Hodometro_inicial = 0,@Hodometro_final = 1200,
  @Qtde_Combus_Antigo = '1/1',
  @Qtde_Combus_Atual = '1/2',
  @Cod_Carro = 3,
  @Observacoes = 'Pneu murcho'

  create table TB_ValoresCombustivel
  (
  Fracao varchar(3) NOT NULL,
  Valor smallint NOT NULL
  )
  insert into TB_ValoresCombustivel(Fracao,valor) values
  ('1/1',100),
  ('1/2',50),
  ('1/4',25),

  select Valor from TB_ValoresCombustivel where Fracao = '1/1'
select * from TB_Historico_Carro where Cod_Carro = 15
  select Diaria,Km_Extra,Semana,Dia_Extra from Tb_Categoria where Cod_Cat = 1
  select Cod_Carro from TB_Carro
  delete from TB_Carro where Cod_Carro >= 8
  exec sp_CadCarro @Cod_Cat = 1 , @Placa = 'EAI-4142' , @Modelo = 'teste' , @Cor = 'Verm.' , @Marca = 'o' , @Data_Fabricacao = '07/13/2013' , @Cod_Tipo_Combus = '1' , @Renavam = '00000000020' , @Chassi = '01000000000000000' , @Ano = '1992' , @Cod_Situacao = 1 , @Status_Carro = 1

  select @@LANGUAGE,@@LANGID from syslanguages where @@LANGID = 0
  select name from syslanguages where langid = 0
  exec sp_configure 'default language' , 0
  exec sp_defaultlanguage 'sa', 'us_english'
  reconfigure
  delete from tb_Carro where COd_Carro >= 8
  DBCC Checkident(TB_Carro,reseed,0)
  exec sp_CadCarro @Cod_Cat = 1 , @Placa = 'EAI-4142' , @Modelo = 'O' , @Cor = 'Verm.' , @Marca = 'O' , @Data_Fabricacao = '07/13/2013' , @Cod_Tipo_Combus = '2' , @Renavam = '28309283293' , @Chassi = '39208309283290389' , @Ano = '1992' , @Cod_Situacao = 1 , @Status_Carro = 1
  
  exec sp_CriaHistoricoCarro @Hodometro_inicial = 0 , @Hodometro_final = 100 , @Qtde_Combus_Antigo = '1/1' , @Qtde_Combus_Atual = '1/2' , @Cod_Carro = 9, @Observacoes = 'OK'