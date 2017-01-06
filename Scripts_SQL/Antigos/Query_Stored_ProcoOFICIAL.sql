create procedure sp_CadCli
@NomeCompleto_Cli varchar(50),@Sexo_Cli char(1),@DataNasc_Cli date ,@CPF_Cli char(14)  ,@RG_Cli char(12)  ,@Habilitacao char(11)  , @Cat_CNH varchar(3),@Nacionalidade_Cli varchar(30),
@Logradouro_Cli varchar(45),@NumCasa_Cli int,@Complemento_Cli char(15),@Bairro_Cli varchar(30)  ,@Cidade_Cli varchar(30)  ,  @Estado_Cli char(2)  ,@CEP_Cli char(9),@Email varchar(45),
@CaminhoFotoCli varchar(60)

as
begin
insert into Tb_Cliente(
NomeCompleto_Cli,Sexo_Cli,DataNasc_Cli,CPF_Cli,RG_Cli,Habilitacao,Cat_CNH,Nacionalidade_Cli,Logradouro_Cli,NumCasa_Cli,Complemento_Cli,Bairro_Cli,Cidade_Cli,Estado_Cli,CEP_Cli,Email,
CaminhoFotoCli )
values
(@NomeCompleto_Cli,@Sexo_Cli,@DataNasc_Cli,@CPF_Cli  ,@RG_Cli  ,@Habilitacao  ,@Cat_CNH ,@Nacionalidade_Cli ,@Logradouro_Cli,@NumCasa_Cli ,@Complemento_Cli ,@Bairro_Cli  ,@Cidade_Cli  ,  
@Estado_Cli  ,@CEP_Cli ,@Email,@CaminhoFotoCli )
end

go
drop proc sp_cadcli


create procedure sp_AlteraCli
@Cod_Cli int,
@NomeCompleto_Cli varchar(50),@Sexo_Cli char(1),@DataNasc_Cli date ,@RG_Cli char(12)  ,@Habilitacao char(11)  , @Cat_CNH varchar(3),@Nacionalidade_Cli varchar(30),
@Logradouro_Cli varchar(45),@NumCasa_Cli int,@Complemento_Cli char(15),@Bairro_Cli varchar(30)  ,@Cidade_Cli varchar(30)  ,  @Estado_Cli char(2)  ,@CEP_Cli char(9),@Email varchar(45),
@CaminhoFotoCli varchar(60)
as
begin
update TB_Cliente set NomeCompleto_Cli = @NomeCompleto_Cli, Sexo_Cli = @Sexo_Cli, DataNasc_Cli = @DataNasc_Cli, RG_Cli = @RG_Cli,
Habilitacao = @Habilitacao, Cat_CNH = @Cat_CNH, Nacionalidade_Cli = @Nacionalidade_Cli , Logradouro_Cli = @Logradouro_Cli , NumCasa_Cli = @NumCasa_Cli
, Complemento_Cli =  @Complemento_Cli , Bairro_Cli = @Bairro_Cli , Cidade_Cli = @Cidade_Cli , Estado_Cli = @Estado_Cli , CEP_Cli = @CEP_Cli , Email = @Email where Cod_Cli = @Cod_Cli
end

drop proc sp_AlteraCli


create procedure ExcluiRegistroCliente
@Cod_Cli smallint
as
begin
delete from TB_TelCli where Cod_Cli = @Cod_Cli
delete from Tb_Cliente where Cod_Cli = @Cod_Cli
DBCC Checkident (TB_TelCli,reseed,0)
DBCC Checkident (Tb_Cliente,reseed,0)
end
drop proc ExcluiRegistro

create proc ResetaCampoIdent
@Table varchar(30)
as
begin
DBCC Checkident (@Table,reseed,0)
end



/*--------------------------------------------------*/
create procedure sp_CadTipoTel
@Descricao varchar(15)
as
begin
	insert into TB_Tipo_Tel(Descricao) values(@Descricao)
	
end



exec sp_CadTipoTel @Descricao = 'Residencial'
exec sp_CadTipoTel 'Celular'
exec sp_CadTipoTel 'Comercial'
exec sp_CadTipoTel 'Outros'

delete from TB_Tipo_Tel




/*--------------------------------------------------*/
create procedure sp_CadTelCli
@Cod_Cli int,
@Telefone varchar(15),
@Forma_Tratamento varchar(10),
@Cod_Tipo_Tel int 
as
begin
	insert into TB_TelCli(Cod_Cli,Telefone,Forma_Tratamento,Cod_Tipo_Tel) values(@Cod_Cli,@Telefone,@Forma_Tratamento,@Cod_Tipo_Tel)
end


/*--------------------------------------------------*/
create procedure sp_CadTelFunc
@Cod_Func int,
@Telefone varchar(15),
@Cod_Tipo_Tel int
as
begin
	insert into TB_Tel_Func(Cod_Func,Telefone,Cod_Tipo_Tel) values(@Cod_Func,@Telefone,@Cod_Tipo_Tel)
end


/*--------------------------------------------------*/

create procedure sp_CadFunc
@Nome_Func varchar(50),
@Sexo_Func char(1),
@CPF_Func char(14),
@DataNasc_Func date,
@RG_Func char(12),
@Logradouro_Func varchar(45),
@NumCasa_Func int,
@Complemento_Func varchar(15),
@Bairro_Func varchar(45),
@Cidade_Func varchar(45),
@CEP_Func char(9),
@Estado_Func char(2),
@Email varchar(45),
@Cod_Cargo int
as
begin
		insert into TB_Funcionario(Nome_Func,Sexo_Func,CPF_Func,DataNasc_Func,RG_Func,Logradouro_Func,NumCasa_Func,Complemento_Func,Bairro_Func,Cidade_Func,CEP_Func,Estado_Func,Email,Cod_Cargo) values
		(@Nome_Func,@Sexo_Func,@CPF_Func,@DataNasc_Func,@RG_Func,@Logradouro_Func,@NumCasa_Func,@Complemento_Func,@Bairro_Func,@Cidade_Func,@CEP_Func,@Estado_Func,@Email,@Cod_Cargo)
end

/*--------------------------------------------------*/
drop table Login

Create procedure sp_CadLogin
@cod_func int,
@senha_func varchar(10),
@tipo_login smallint
as
begin
	insert into Login(cod_func,senha_func,tipo_login) values(@cod_func,@senha_func,@tipo_login)
end
select * from login
exec sp_CadLogin '01','arthur','1'
exec sp_CadLogin '02','gabriel','2'
exec sp_CadLogin '03','leonardo','2'
exec sp_CadLogin '04','coral','2'


drop proc sp_CadLogin
select * from TB_Funcionario

select * from TB_Cargo

select * from TB_TelCli
select * from TB_Tipo_Tel

exec sp_CadFunc @Nome_Func = 'o', @Sexo_Func = 'M', @CPF_Func = '000.000.000-00', @DataNasc_Func = '04/14/2013', @RG_Func = '00.000.000-00', @Logradouro_Func = 'o', @NumCasa_Func = '0', @Complemento_Func = 'o', @Bairro_Func = 'o', @Cidade_Func = 'o', @CEP_Func = '00000-000', @Estado_Func = 'oo', @Email = '', @Cod_Cargo = 1


Create procedure sp_CadCarro
@Cod_Cat int ,
@Placa char(8)  ,
@Modelo varchar(45)  ,
@Cor varchar(25)  ,
@Marca varchar(45)  ,
@Data_Fabricacao date  ,
@Cod_Tipo_Combus int  ,
@Renavam char(11)  ,
@Chassi char(17)  ,
@Ano char(4)  ,
@Cod_Situacao int  ,
@Status_Carro bit 
as
begin
insert into Tb_Carro(Cod_Cat,
Placa ,
Modelo  ,
Cor  ,
Marca  ,
Data_Fabricacao  ,
Cod_Tipo_Combus  ,
Renavam ,
Chassi ,
Ano,
Cod_Situacao,
Status_Carro) values
(@Cod_Cat,
@Placa ,
@Modelo  ,
@Cor  ,
@Marca  ,
@Data_Fabricacao  ,
@Cod_Tipo_Combus  ,
@Renavam ,
@Chassi ,
@Ano,
@Cod_Situacao,
@Status_Carro)

end

create proc sp_CadCategoria
@Nome_Cat varchar(20),
@Diaria money,
@Km_Extra money,
@Semana money,
@Dia_Extra money
as
begin
insert into TB_Categoria(Nome_Cat,
Diaria,
Km_Extra,
Semana,
Dia_Extra)
values(
@Nome_Cat,
@Diaria,
@Km_Extra,
@Semana,
@Dia_Extra)
end

drop proc sp_ConsultaCliente
CREATE PROC sp_ConsultaCliente
@Cod_Cli int
as
begin
select * from TB_Cliente where Cod_Cli = @Cod_Cli
end

drop proc sp_consultatelcliente
create proc sp_consultatelcliente
@Cod_Cli int
as
begin
select * from TB_TelCli where Cod_Cli = @Cod_Cli
end

create proc sp_consultafunc
@Cod_Func int
as
begin
select * from Tb_funcionario where Cod_Func = @Cod_Func
end


create proc sp_consultatelfunc
@Cod_Func int
as
begin
select Telefone,Cod_Tipo_Tel from TB_Tel_Func where Cod_Func = @Cod_Func
end

drop proc sp_CriaHistoricoCarro
create proc sp_CriaHistoricoCarro

@Hodometro_inicial int,
@Hodometro_final int,
@Qtde_Combus_Antigo varchar(3),
@Qtde_Combus_Atual varchar(3),
@Cod_Carro int,
@Observacoes varchar(150)
as
begin
insert into TB_Historico_Carro(Hodometro_inicial,Hodometro_Final,Qtde_Combus_Antigo,Qtde_Combus_Atual,Cod_Carro,Observacoes)
values
(@Hodometro_inicial,@Hodometro_final,@Qtde_Combus_Antigo,@Qtde_Combus_Atual, @Cod_Carro,@Observacoes)

end

create proc sp_AtualizaHistoricoCarro
@Hodometro_inicial int,
@Hodometro_final int,
@Qtde_Combus varchar(3),
@Cod_Aluguel int,
@Observacoes varchar(150),
@Cod_Carro int
as
begin
update TB_Historico_Carro set 
Hodometro_inicial = @Hodometro_inicial,
Hodometro_final = @Hodometro_final,
Qtde_Combus_Atual = @Qtde_Combus,
Cod_Aluguel_Atual = @Cod_Aluguel,
Observacoes = @Observacoes
where Cod_Carro = @Cod_Carro
end

 