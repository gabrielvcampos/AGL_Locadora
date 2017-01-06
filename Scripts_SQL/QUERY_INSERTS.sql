/* INSERT DOS CARGOS DOS FUNCIONÁRIOS */
insert into TB_Cargo(Nome_Cargo) values
('Recepcionista'),
('Atendente'),
('Gerente'),
('Faixineiro')
GO





/*INSERT DOS TIPPOS DE TELEFONE PARA FUNCIONÁRIOS E CLIENTES*/
exec sp_CadTipoTel @Descricao = 'Residencial'
exec sp_CadTipoTel 'Celular'
exec sp_CadTipoTel 'Comercial'
exec sp_CadTipoTel 'Outros'



GO



/* INSERT NA TABELA DO TIPO DE COMBUSTÍVEL - USADO NA HORA DE INSERIR O CARRO */
insert into Tb_Tipo_Combustivel(Descricao) values
('Diesel'),
('Etanol'),
('Flex'),
('Gasolina'),
('GNV')


GO



/*INSERT DE SITUAÇÕES DOS CARROS*/
insert into TB_Situacao_Carro(Situacao) Values
('Disponivel'),
('Alugado'),
('Em manutenção'),
('Bloqueado'),
('Em preparação'),
('Roubado'),
('A venda'),
('Vendido'),
('Reservado')




GO




/*INSERT NA TABELA DE ACESSÓRIOS DO CARRO*/
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

/*INSERE ACESSORIOS DAS CATEGORIAS*/
INSERT INTO Tb_Acessorios_Categoria(Cod_Cat,Cod_Acess) VALUES
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),




GO



/* INSERT DE CATEGORIAS */  
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
('4X4 Especial',262.90,2.78,2925.30,417.90,'N'),
('VANS',120.90,0.78,1347.30,220.90,'O'),
('Executivo Blindado',270.90,3.78,3025.30,505.90,'P'),
('Esportivo de Luxo',350.90,3.90,3025.30,517.90,'Q')




GO




/* INSERT DE CARROS PARA CATEGORIA */
insert into Tb_Carro(Cod_Cat,Placa,Modelo,Cor,Marca,Data_Fabricacao,Cod_Tipo_Combus,Renavam,Chassi,Ano,Cod_Situacao,Status_Carro) values
(1,'ABC-1234','GM Celta 1.0','Prata','General Motors','01/01/2013',3,'00000000001','00000000000000001','2013',1,1),
(1,'ABC-0000','Fiat Novo Uno 1.0','Preto','Fiat','01/01/2013',3,'00000000002','00000000000000002','2013',1,1),

(2,'ABC-0001','GM Celta 1.0','Preto','General Motor','01/01/2013',3,'00000000003','00000000000000003','2013',1,1),
(2,'ABC-0002','VW Gol 1.0','Preto','Volkswagen','01/01/2013',3,'00000000004','00000000000000004','2013',1,1),
(2,'ABC-0003','Fiat Novo Uno 1.0','Preto','Fiat','01/01/2013',3,'00000000005','00000000000000005','2013',1,1),
(2,'ABC-0004','Ford Fiesta Hatch 1.0','Prata','Ford','01/01/2013',3,'00000000006','00000000000000006','2013',1,1),
(2,'ABC-0005','Renault Logan 1.0','Prata','Renault','01/01/2013',3,'00000000007','00000000000000007','2013',1,1),

(3,'ABC-0006','Renault Sandero 1.6','Prata','Renault','01/01/2013',3,'00000000008','00000000000000008','2013',1,1),
(3,'ABC-0007','Renault Voyage 1.6','Preto','Renault','01/01/2013',3,'00000000009','00000000000000009','2013',1,1),
(3,'ABC-0008','Ford Fiesta Sedan 1.6','Prata','Ford','01/01/2013',3,'00000000010','00000000000000010','2013',1,1),


(4,'ABC-0010','Fiat Idea 1.4','Cinza Metálico','Fiat','01/01/2013',3,'00000000011','00000000000000011','2013',1,1),

(5,'ABC-0011','Ford EcoSport 1.6','Prata','Ford','01/01/2013',3,'00000000012','00000000000000012','2013',1,1),
(5,'ABC-0012','Duster Dynamique','Prata','Renault','01/01/2013',3,'00000000013','00000000000000013','2013',1,1),

(6,'ABC-0013','Ford Focus 1.6-Abag/ABS','Preto','Ford','01/01/2013',3,'00000000014','00000000000000014','2013',1,1),

(7,'ABC-0014','Fiat Linea 1.8','Branco','Fiat','01/01/2013',3,'00000000015','00000000000000015','2013',1,1),
(7,'ABC-0015','Ford Focus Sedan 2.0','Preto','Ford','01/01/2013',3,'00000000016','00000000000000016','2013',1,1),

(8,'ABC-0016','Ford Fusion Sedan 2.5','Preto','','01/01/2013',3,'00000000017','00000000000000017','2013',1,1),
(8,'ABC-0017','Peugeot 408 Sedan Allure 2.0','Cinza','Peugeot','01/01/2013',3,'00000000018','00000000000000018','2013',1,1),
(8,'ABC-0018','Renault Fluence Dynamique 2.0','Prata','Renault','01/01/2013',3,'00000000019','00000000000000019','2013',1,1),

(9,'ABC-0019','Fiat Strada 1.4','Branco','Fiat','01/01/2013',3,'00000000020','00000000000000020','2013',1,1),

(10,'ABC-0020','Fiat Fiorino Furgão 1.3','Branco','Fiat','01/01/2013',3,'00000000021','00000000000000021','2013',1,1),

(11,'ABC-0021','VW Saveiro 1.6','Prata','Volkswagen','01/01/2013',3,'00000000022','00000000000000022','2013',1,1),

(12,'ABC-0022','VW Kombi 1.4','Branca','Volkswagen','01/01/2013',3,'00000000023','00000000000000023','2013',1,1),

(13,'ABC-0023','Fiat Doblo 1.8','Branca','Fiat','01/01/2013',3,'00000000024','00000000000000024','2013',1,1),

(14,'ABC-0024','Ford Ranger','Cinza Metálico','Ford','01/01/2013',3,'00000000025','00000000000000025','2013',1,1),

(15,'ABC-0025','Van','Branca','Renault','01/01/2013',3,'00000000026','00000000000000026','2013',1,1),

(16,'ABC-0026','Ford Fusion Sedan 3.0 V6','Preto','Ford','01/01/2013',3,'00000000027','00000000000000027','2013',1,1),

(17,'ABC-0027','Chevrolet Camaro SS 6.2 V8','Branca','Chevrolet','01/01/2013',3,'00000000028','00000000000000028','2013',1,1)




GO

/* INSERT NOS VALORES DE COMBUSTIVEL PARA PROGRESSBAR */
  insert into TB_ValoresCombustivel(Fracao,valor) values
  ('1/1',100),
  ('3/4',75),
  ('1/2',50),
  ('1/4',25)






/* INSERT DA TAXA DE SEGURO NA TABELA DE SEGURO */
insert into TB_Seguro(Cod_Seguro,Taxa_Seguro) values
(0,0),
(1,1.10)



GO



/*INSERT NA TABELA DE LOGINS DOS FUNCIONARIOS*/
exec sp_CadLogin '01','arthur','1'
exec sp_CadLogin '02','gabriel','2'
exec sp_CadLogin '03','leonardo','2'
exec sp_CadLogin '04','coral','2'



GO

/*ALTERAÇÃO A SER FEITA NA TABELA TB_TIPO_CONTAS*/
alter table TB_tipo_Contas
alter column Descricao varchar(30) not null
/* INSERE TODOS OS TIPOS DE CONTA NA TABELA tb_tipo_contas */

INSERT INTO tb_tipo_contas(Descricao) values
('Água'),('Luz'),('Telefone'),('Folha de pagamento'),('Outros'),('Gás'),('Carros: Manutenção'),
('Carros: Aquisição')



/* ALTERAÇÃO FEITA NA TABELA DE ACESSORIO E CATEGORIA E TAL
 - NÃO ESQUECER DE MUDAR O NOME DE TODOS OS CAMPOS NO CÓDIGO VB*/
alter table Tb_acessorios_Categoria
add constraint FK_Acessorio_Categoria foreign key(Cod_Cat) REFERENCES Tb_Categoria(Cod_Cat)
GO
alter table Tb_Acessorios_Categoria
drop constraint FK_Carro_Acess


