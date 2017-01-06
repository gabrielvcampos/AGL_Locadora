select * from TB_Categoria
select Nome_Cat as 'Nome' from TB_Categoria
select * from Tb_Tipo_Combustivel
select * from TB_Situacao_Carro
select * from Tb_Carro
delete from TB_Categoria where Cod_Cat = 4


/* CADASTRO DE CATEGORIAS - BASE DE TESTE */
exec dbo.sp_CadCategoria @Nome_cat = 'Executivo',@Diaria = 115.00, @Km_Extra = 1.10, @Semana = 979.00, @Dia_Extra = 120.00


/* CADASTRO DE CARROS - BASE DE TESTE */
exec dbo.sp_CadCarro @Cod_Cat = 2, @Placa = 'DWY-9980', @Modelo = 'Fusion', @Cor = 'Preto', @Marca = 'Ford',
@Data_Fabricacao = '01/01/2013',@Cod_Tipo_Combus = 3, @Renavam = '00000000005', @Chassi = '00000000000000005',
@Ano = '2013', @Cod_Situacao = '1', @Status_Carro = '1'


update Tb_Carro set Cod_Cat = 3 where Cod_Carro = 6 or Cod_carro = 6




select dbo.Tb_carro.Cod_Carro,dbo.Tb_carro.Placa,dbo.TB_Carro.Modelo,dbo.TB_Carro.Marca,dbo.TB_Carro.Ano,dbo.TB_Categoria.Nome_Cat,dbo.Tb_Tipo_Combustivel.Descricao as 'Combustivel' from Tb_Carro, Tb_Categoria,Tb_Tipo_Combustivel where
Tb_Carro.Cod_Cat = Tb_Categoria.Cod_Cat and Tb_Carro.Cod_Tipo_Combus = Tb_Tipo_Combustivel.Cod_Tipo_Combus

create proc sp_ExibeCarrosDeCategoria
@Cod_Cat smallint
as
begin
select Tb_Carro.Placa,Tb_carro.Modelo,TB_Carro.Marca,tb_carro.cor,Tb_Tipo_Combustivel.Descricao as 'Combustivel' from TB_Carro, TB_Tipo_Combustivel where
TB_Carro.Cod_Tipo_Combus = Tb_Tipo_Combustivel.Cod_Tipo_Combus and Tb_carro.Cod_Cat = @Cod_Cat
end


select dbo.Tb_carro.Cod_Carro,dbo.Tb_carro.Placa,dbo.TB_Carro.Modelo,dbo.TB_Carro.Marca,dbo.TB_Carro.Ano,dbo.TB_Categoria.Nome_Cat, dbo.Tb_Tipo_Combustivel.Descricao as 'Combustivel' from Tb_Carro, Tb_Categoria,Tb_Tipo_Combustivel where Tb_Carro.Cod_Cat = Tb_Categoria.Cod_Cat and Tb_Carro.Cod_Tipo_Combus = Tb_Tipo_Combustivel.Cod_Tipo_Combus and tb_Carro.Placa = 'EAI-4140'


create proc SelecionaAcessoriosCarros
@Cod_Carro smallint
as
begin

select TB_Acessorios_Carro.Cod_Acess_Carro,Tb_Acessorios.Descricao_Acess from TB_Acessorios_Carro,Tb_Acessorios 
where TB_Acessorios_Carro.Cod_Acess_Carro = Tb_Acessorios.Cod_Acess and TB_Acessorios_Carro.Cod_Carro = 1
end

insert into TB_Acessorios_Carro(Cod_Carro,Cod_Acess_Carro) values
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,6)
alter table TB_Seguro
alter column Taxa_Seguro float

delete from TB_Seguro where Cod_Seguro = 1
select * from TB_Seguro
update TB_Seguro set Taxa_Seguro = 1.10 where Cod_Seguro = 1
insert into TB_Seguro values (1,0.10)

select * from TB_Categoria
select * from TB_Aluguel

create proc sp_NovoAluguel
@Cod_Cli smallint,
@Cod_Func smallint,
@Cod_Carro smallint,
@Cod_Seguro smallint,
@Condutor_Principal varchar(15),
@Data_Retirada date,
@Data_Entrega date,
@Condicao_Entrega varchar(45),
@Preco_Final money
as 
begin
insert into TB_Aluguel(Cod_Cli,
Cod_Func,
Cod_Carro,
Cod_Seguro,
Condutor_Principal,
Data_Retirada,
Data_Entrega,
Condicao_Entrega,
Preco_Final) values
(@Cod_Cli,
@Cod_Func,
@Cod_Carro,
@Cod_Seguro,
@Condutor_Principal,
@Data_Retirada,
@Data_Entrega,
@Condicao_Entrega,
@Preco_Final)
end


alter table TB_Aluguel
drop column Tipo_Tarifa