use Db_Locadora
select * from Tb_Tipo_Contas
truncate table TB_Contas
go
delete  from TB_Tipo_Contas
DBCC Checkident(TB_Tipo_Contas, reseed, 0)
exec sp_CadastrarContas @Cod_Func = '1', @Cod_Conta = '2', @MesReferencia = 'Janeiro', @Data_Venc = '07/23/2012', @Data_Pgto = '07/23/2012', @Valor_Pago = '1', @Valor_Conta = '1',@Status_Conta = 'Pago'

EXEC  SP_ALTERA_CONTA @Cod_Pagamento = 2, @Cod_Conta = 9, @MesReferencia = 'Fevereiro',@Data_Venc = '07/23/2012',@Data_Pgto =  '07/23/2012', @Valor_Pago = 12.0000, @Valor_Conta = 12.0000, @Status_Conta = 'Não Pago'