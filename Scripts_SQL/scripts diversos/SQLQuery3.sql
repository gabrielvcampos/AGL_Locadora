USE [Db_Locadora]
GO
/****** Object:  StoredProcedure [dbo].[sp_CadastrarContas]    Script Date: 22/09/2013 14:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_CadastrarContas
@Cod_Func int,
@Cod_Conta int,
@MesReferencia varchar(15),
@Data_Venc date,
@Data_Pgto date,
@Valor_Pago money,
@Valor_Conta money,
@Status_Conta varchar(10)
as
begin
insert into Tb_Contas(Cod_Func,Cod_Conta,MesReferencia,Data_Venc,Data_Pgto,Valor_Pago,Valor_Conta,Status_Conta) values
(@Cod_Func,@Cod_Conta,@MesReferencia,@Data_Venc,@Data_Pgto,@Valor_Pago,@Valor_Conta,@Status_Conta)
end


exec sp_PesquisaContasPend

select TB_Contas.Cod_Func,
TB_Contas.MesReferencia,
TB_Contas.Data_Venc,
TB_Contas.Valor_Conta,
TB_Contas.Status_Conta,
Tb_Tipo_Contas.Descricao 
from TB_Contas inner join Tb_Tipo_Contas 
on
Tb_Contas.Cod_Conta = Tb_Tipo_Contas.Cod_Conta
 where Status_Conta like '%Não pago%'

select TB_Contas.*,TB_Tipo_contas.Descricao from TB_Contas inner join TB_Tipo_Contas 
on TB_Contas.Cod_Conta = TB_Tipo_Contas.Cod_conta
where 



