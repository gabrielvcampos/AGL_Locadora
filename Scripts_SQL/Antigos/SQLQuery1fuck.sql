Select * from Tb_Categoria
select

alter table Tb_Categoria
add Letra_Cat char(1) null

alter table Tb_Categoria
alter column Nome_cat varchar(40)

insert into Tb_Categoria(Nome_cat,Diaria,Km_Extra,Semana,Dia_extra,Letra_Cat) values
('Economico',39.90,0.46,601.30,85.00,'A'),
('Economico com ar',74.90,0.75,839.50,100.00,'B'),
('Intermediário',95.90,0.90,1070.00,150.00,'C'),
('Intermediário WAGON',101.90,0.96,1140.30,162.00,'D'),
('Intermediário WAGON ESPECIAL',126.90,1.12,1472.00,210.00,'E'),
('Executivo Compacto',157.00,1.50,1770.30,252.90,'F'),
('Executivo',190.90,1.62,2141.30,305.90,'G'),
('Executivo Especial',211.90,1.76,2365.90,337.90,'H'),
('Pick-up',83.00,0.80,923.30,131.90,'I'),
('Furgão',91.90,0.87,1056.30,150.00,'J'),
('Pick-up com ar',95.90,0.89,1056.30,150.90,'K'),
('Utilitários',123.90,1.27,1343.30,192.90,'L'),
('Minivan',132.90,1.30,1476.30,210.90,'M'),
('4X4',262.90,2.78,2925.30,417.90,'N')





select Tb_tipo_combustivel.* , TB_Situacao_Carro.* from tb_tipo_combustivel
delete  from Tb_Tipo_Combustivel where Cod_Tipo_Combus = 10


Select*from tb_Carro






select *  from Tb_historico_Carro
delete from Tb_Acessorios_carro
delete from TB_Carro
delete from TB_Categoria

Delete from Tb_Categoria





create proc DeletaRegistros
@Campo varchar(30),
@Codigo smallint,
@Tabela 
as
begin
delete from @Tabela where @Campo = @Codigo
DBCC Checkident(Tb_Acessorios_carro,reseed,0)
end


select * from TB_Situacao_Carro
select * from TB_



insert into Tb_Carro(Cod_Cat,Placa,Modelo,Cor,Marca,Data_Fabricacao,Cod_Tipo_Combus,Renavam,Chassi,Ano,Cod_Situacao,Status_Carro) values
(1,'ABC-1234','GM Celta 1.0','Prata','General Motors','01/01/2013',3,'00000000001','00000000000000001','2013',1,1)
