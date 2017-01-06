 DBCC Checkident (TB_Carro,reseed,0)

 select * from TB_Cliente
 select * from TB_Carro
 delete from TB_Carro
   exec sp_CadCarro @Cod_Cat = 1 , @Placa = 'EAI-4140' , @Modelo = 'Gol' , @Cor = 'Verm.' , @Marca = 'Volks' , @Data_Fabricacao = '07/07/2008' , @Cod_Tipo_Combus = 0 , @Renavam = '32323232323' , @Chassi = '89765435678908765' , @Ano = '2008', @Cod_Situacao = 1 , @Status_Carro = 0
   select * from TB_Categoria
   select * from TB_Situacao_Carro
   drop table TB_TelCli
   drop table Tb_Cliente

      select * from TB_Acessorios

	  insert into TB_Acessorios(Descricao_Acess,Sigla_Acess) values
	  ('Ar condicionado','AC'),
	  ('Roda Liga Leve','LL'),
	  ('Basico','B'),
	  ('Teto Solar','TS'),
	  ('Tração 4x4','4x4'),
	  ('Banco de Couro','BC'),
	  ('CD Player','CD'),
	  ('DVD Player','DVD'),
	  ('Som adicional','SOM'),
	  ('Freio ABS','ABS'),
	  ('GPS','GPS'),
	  ('AirBags','AB')

   select * from TB_Acessorios_Carro



Select * from TB_TelCli
Select * from Tb_Cliente
delete from Tb_Cliente where Cod_Cli='2'
select Tb_CLiente.*,TB_TelCli.* from Tb_Cliente Inner Join TB_TelCLi on Tb_Cliente.Cod_Cli = TB_TelCLi.Cod_Cli where Tb_Cliente.Cod_Cli = '3' 
delete Tb_Cliente  from Tb_Cliente inner join TB_TelCli on Tb_Cliente.Cod_Cli=TB_TelCli.Cod_Cli where Tb_Cliente.Cod_CLi ='5'
delete from Tb_Cliente,TB_TelCli using Tb_Cliente inner join TB_TelCLi 

select Tb_CLiente.*,TB_TelCli.* from Tb_Cliente Inner Join TB_TelCLi on Tb_Cliente.Cod_Cli = TB_TelCLi.Cod_Cli 
where NomeCompleto_Cli like '%jorge%'
exec sp_consultatelcliente @Cod_Cli = 7
exec sp_consultatelcliente @Cod_Cli = 7

alter table TB_Cliente
alter column
CEP_Cli char(9) NOT NULL


exec sp_consultatelcliente @Cod_Cli = 7

use DB_Locadora
alter table TB_Funcionario
add
CaminhoFoto_Func varchar(60)



alter table TB_Historico_Carro
modify column
Qtde_Combus_Atual varchar(3)

select Cod_func as 'Código do funcionário',Nome_Func as 'Nome completo' from TB_Funcionario where Nome_Func like '%o%'
exec sp_consultafunc @Cod_func = 4


exec sp_CriaHistoricoCarro @Hodometro_inicial = 0, @Hodometro_final = 0, @Qtde_Combus_Antigo = '1/1', @Qtde_Combus_Atual = '1/1', @Cod_Carro = 9, @Observacoes = 'OK'



