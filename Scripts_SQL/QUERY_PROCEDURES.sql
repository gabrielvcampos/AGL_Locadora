/*PRODCEDURE PARA CADASTRDAR E INSERIR O CLIENTE DO SISTEMA*/
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




GO





/*PRODCEDURE PARA REALIZAR ALTERAÇÕES NO CLIENTE*/
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



GO




/*PRODCEDURE PARA EXCLUIR OS REGISTROS DO CLIENTE - 
UTILIZADA APENAS PARA TESTES DO SISTEMA - 
O CLIENTE NO SISTEMA CORPORATIVO NÃO PODE SER EXCLUÍDO*/
create procedure ExcluiRegistroCliente
@Cod_Cli smallint
as
begin
delete from TB_TelCli where Cod_Cli = @Cod_Cli
delete from Tb_Cliente where Cod_Cli = @Cod_Cli
DBCC Checkident (TB_TelCli,reseed,0)
DBCC Checkident (Tb_Cliente,reseed,0)
end





GO




/*PRODCEDURE PARA RESETAR TODOS OS CAMPOS DE UMA TABELA*/
create proc ResetaCampoIdent
@Table varchar(30)
as
begin
DBCC Checkident (@Table,reseed,0)
end



GO




/*PRODCEDURE PARA CADASTRAR O TIPO DE TELEFONE */
create procedure sp_CadTipoTel
@Descricao varchar(15)
as
begin
	insert into TB_Tipo_Tel(Descricao) values(@Descricao)
	
end




GO





/*PRODCEDURE PARA* CADASTRAR E INSERIR O TELEFONE DO CLIENTE*/
create procedure sp_CadTelCli
@Cod_Cli int,
@Telefone varchar(15),
@Forma_Tratamento varchar(10),
@Cod_Tipo_Tel int 
as
begin
	insert into TB_TelCli(Cod_Cli,Telefone,Forma_Tratamento,Cod_Tipo_Tel) values(@Cod_Cli,@Telefone,@Forma_Tratamento,@Cod_Tipo_Tel)
end




GO




/*PROCEDURE PARA CADASTRAR E INSERIR O TELEFONE DO FUNCIONÁRIO*/
create procedure sp_CadTelFunc
@Cod_Func int,
@Telefone varchar(15),
@Cod_Tipo_Tel int
as
begin
	insert into TB_Tel_Func(Cod_Func,Telefone,Cod_Tipo_Tel) values(@Cod_Func,@Telefone,@Cod_Tipo_Tel)
end



GO





/*PROCEDURE PARA CADASTRAR O LOGIN DOS FUNCONÁRIOS*/
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
@CaminhoFoto_Func varchar(60),
@Cod_Cargo int
as
begin
		insert into TB_Funcionario(Nome_Func,Sexo_Func,CPF_Func,DataNasc_Func,RG_Func,Logradouro_Func,NumCasa_Func,Complemento_Func,Bairro_Func,Cidade_Func,CEP_Func,Estado_Func,Email,Cod_Cargo,CaminhoFoto_Func) values
		(@Nome_Func,@Sexo_Func,@CPF_Func,@DataNasc_Func,@RG_Func,@Logradouro_Func,@NumCasa_Func,@Complemento_Func,@Bairro_Func,@Cidade_Func,@CEP_Func,@Estado_Func,@Email,@Cod_Cargo,@CaminhoFoto_Func)
end



GO



/*PROCEDURE PARA CADASTRAR O LOGIN DOS FUNCONÁRIOS*/
Create procedure sp_CadLogin
@cod_func int,
@senha_func varchar(10),
@tipo_login smallint
as
begin
	insert into Login(cod_func,senha_func,tipo_login) values(@cod_func,@senha_func,@tipo_login)
end





GO





/*PRODCEDURE PARA CRIAR E INSERIR O HISTÓRICO DO CARRO*/
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
@Status_Carro bit,
@Caminho_Foto varchar(65)
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
Status_Carro, Caminho_Foto) values
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
@Status_Carro,
@Caminho_Foto)

end




GO




/*PRODCEDURE PARA CADASTRDAR A CATEGORIA DO CARRO*/
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



GO



/*PRODCEDURE PARA CONSULTAR OS DADOS DO CLIENTE*/
CREATE PROC sp_ConsultaCliente
@Cod_Cli int
as
begin
select * from TB_Cliente where Cod_Cli = @Cod_Cli
end



GO



/*PRODCEDURE PARA CONSULTAR O TELEFONE DO CLIENTE*/
create proc sp_consultatelcliente
@Cod_Cli int
as
begin
select * from TB_TelCli where Cod_Cli = @Cod_Cli
end

go

create proc sp_consultafunc
@Cod_Func int
as
begin
select * from Tb_funcionario where Cod_Func = @Cod_Func
end


GO



/*PRODCEDURE PARA CONSULTAR O TELEFONE DO FUNCIONÁRIO*/
create proc sp_consultatelfunc
@Cod_Func int
as
begin
select Telefone,Cod_Tipo_Tel from TB_Tel_Func where Cod_Func = @Cod_Func
end



GO



/*PRODCEDURE PARA CRIAR E INSERIR O HISTÓRICO DO CARRO*/
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



GO



/*PROCEDURE PARA ATUALIZAR O HISTÓRICO DO CARRO*/
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

 



GO





/*PROCEDURE PARA EXIBIR OS CARROS DE CADA CATEGORIA -
 USADO NA HORA DE SELECIONAR OS CARROS PARA O ALUGUEL*/
create proc sp_ExibeCarrosDeCategoria
@Cod_Cat smallint
as
begin
select Tb_Carro.Placa,Tb_carro.Modelo,TB_Carro.Marca,tb_carro.cor,Tb_Tipo_Combustivel.Descricao as 'Combustivel' from TB_Carro, TB_Tipo_Combustivel where
TB_Carro.Cod_Tipo_Combus = Tb_Tipo_Combustivel.Cod_Tipo_Combus and Tb_carro.Cod_Cat = @Cod_Cat
end




GO





/* PROCEDURE PARA EXIBIR E SELECIONAR OS ACESSÓRIOS DE CADA CARRO
 - USADA TAMBÉM NA HORA DE SELECIONAR O CARRO NO ALUGUEL */
create proc SelecionaAcessoriosCarros
@Cod_Carro smallint
as
begin

select TB_Acessorios_Categoria.Cod_Acess,Tb_Acessorios.Descricao_Acess from TB_Acessorios_Categoria,Tb_Acessorios 
where TB_Acessorios_Categoria.Cod_Acess = Tb_Acessorios.Cod_Acess and TB_Acessorios_Categoria.Cod_Cat = @Cod_Carro
end



GO





/* PROCEDURE PARA INSERIR UM NOVO ALUGUEL */
create procedure sp_InsereAluguel
@Cod_Cli smallint,
@Cod_Func smallint,
@Cod_Carro smallint,
@Cod_Seguro bit,
@Condutor_Principal varchar(15),
@Data_Retirada date,
@Data_Entrega date,
@Horaretirada varchar(8),
@HoraEntrega varchar(8),
@Condicao_Entrega varchar(45),
@Preco_Final money
as
begin
insert into TB_Aluguel(Cod_Cli,Cod_Func,Cod_Carro,Cod_seguro,Condutor_Principal,Data_Retirada,Data_Entrega,HoraRetirada,HoraEntrega,Condicao_Entrega,Preco_Final,Status_Aluguel)
values
(@Cod_Cli,@Cod_Func,@Cod_Carro,@Cod_seguro,@Condutor_Principal,@Data_Retirada,@Data_Entrega,@HoraRetirada,@HoraEntrega,@Condicao_Entrega,@Preco_Final,'EM PROGRESSO')
end


/* PROCEDURE QUE FINALIZA UM ALUGUEL E ATUALIZA O HISTORICO DO CARRO */
create proc sp_FinalizaAluguel
@Cod_Aluguel smallint,
@Cod_Carro smallint,
@Data_Entrega date,
@HoraEntrega varchar(8),
@Preco_Final_Real money,
@Status_Aluguel varchar(12),
@Qtde_Combus_Atual varchar(3),
@Hodometro_Final int,
@Observacoes varchar(150)
as
begin
update TB_Aluguel set Data_Entrega = @Data_Entrega, HoraEntrega = @HoraEntrega, Status_Aluguel = @Status_Aluguel,
Preco_Final_Real= @Preco_Final_Real where Cod_Aluguel = @Cod_Aluguel

update TB_Historico_Carro set Qtde_Combus_Atual = @Qtde_Combus_Atual, Hodometro_Final = @Hodometro_Final, 
Observacoes = @Observacoes where Cod_Carro = @Cod_Carro
end



/*  PROCEDURE PARA ALTERAR REGISTRO DE FUNCIONARIO */


create procedure sp_AlteraFuncionario

@Cod_Func int,
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
@CEP_Func varchar(9),
@Estado_Func char(2), 
@Email varchar(45),
@Cod_Cargo int, 
@CaminhoFoto_Func varchar(60)
as
begin
update TB_Funcionario 
 set 
Nome_Func = @Nome_Func,
Sexo_Func = @Sexo_Func,
CPF_Func = @CPF_Func,
DataNasc_Func = @DataNasc_Func,
RG_Func = @RG_Func,
Logradouro_Func = @Logradouro_Func,
NumCasa_Func = NumCasa_Func,
Complemento_Func = @Complemento_Func  ,
 Bairro_Func = @Bairro_Func,
Cidade_Func =  @Cidade_Func,
CEP_Func = @Cidade_Func,
Estado_Func = @Estado_Func,
Email = @Email,
Cod_Cargo = @Cod_Cargo ,
CaminhoFoto_Func = @CaminhoFoto_Func
where Cod_Func = @Cod_Func
end



/* PROCEDURE PARA ALTERAR REGISTRO DE CONTA NA TB_CONTAS */

CREATE PROCEDURE SP_ALTERA_CONTA
@Cod_Pagamento int,
@Cod_Conta int,
@MesReferencia varchar(15),
@Data_Venc date,
@Data_Pgto date ,
@Valor_Pago money,
@Valor_Conta money,
@Status_Conta varchar(10)
AS
BEGIN
update tb_Contas set
MesReferencia = @MesReferencia,
Data_Venc = @Data_Venc,
Data_Pgto = @Data_Pgto,
Valor_Pago = @Valor_Pago,
Valor_Conta = @Valor_Conta,
Status_Conta = @Status_conta
where Cod_Pagamento = @Cod_Pagamento
END
