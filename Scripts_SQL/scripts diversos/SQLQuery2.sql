select * from TB_Aluguel


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
insert into TB_Aluguel(Cod_Cli,Cod_Func,Cod_Carro,Cod_seguro,Condutor_Principal,Data_Retirada,Data_Entrega,HoraRetirada,HoraEntrega,Condicao_Entrega,Preco_Final)
values
(@Cod_Cli,@Cod_Func,@Cod_Carro,@Cod_seguro,@Condutor_Principal,@Data_Retirada,@Data_Entrega,@HoraRetirada,@HoraEntrega,@Condicao_Entrega,@Preco_Final)
end

/* Alteração em TB_Aluguel. Adicionar os campos: 
Horaretirada varchar(8)
HoraEntrega varchar(8)
*/
Condicao_Entrega varchar(45)
Preco_Final money
alter table TB_Aluguel
add  Preco_Final money
select * from TB_Seguro
exec sp_InsereAluguel @Cod_Cli = 4, @Cod_Func = 1, @Cod_Carro = 1, @Cod_seguro = 0, @Condutor_Principal = 'Arthur Alencar de Oliveira',@Data_Retirada = '03/08/2013', @Data_Entrega = '10/08/2013', @HoraRetirada = '21:25:07',@HoraEntrega = '23:25:07',@Condicao_Entrega = 'PENDENTE', @Preco_Final = 359.1


select TB_Cliente.NomeCompleto_Cli,TB_Carro.Modelo,TB_Aluguel.Condutor_Principal,TB_Aluguel.Data_Retirada,
TB_Aluguel.Data_Entrega,TB_Aluguel.HoraRetirada,TB_Aluguel.HoraEntrega,TB_Aluguel.Condicao_Entrega,TB_Aluguel.Preco_Final from
TB_CLiente,TB_Carro,TB_Aluguel where TB_Cliente.Cod_Cli = TB_Aluguel.Cod_Cli and TB_Carro.Cod_Carro = TB_Aluguel.Cod_Carro


SELECT [name] FROM sysdatabases where [name] like '%Locadora%'