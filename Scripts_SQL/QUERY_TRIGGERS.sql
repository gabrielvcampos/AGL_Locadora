/* trigger que armazena todas as atualizações feitas na TB_Historico_Carro */ 


create trigger ContaAtualizacoes on dbo.TB_Historico_Carro
for update

as
-- VERIFICA SE O UPDATE FOI FEITO NO CAMPO HOD INICIAL, SE SIM INSERE NA TABELA.
if update(Hodometro_inicial)
insert into TB_Updates_Historico_Carro select ins.Cod_Carro, GETDATE(),'Hodometro_inicial',
CAST(del.Hodometro_inicial as varchar(150)), cast(ins.Hodometro_inicial as varchar(150))
from inserted as Ins
inner join Deleted as Del on Ins.Cod_Carro = Del.Cod_Carro


-- VERIFICA SE O UPDATE FOI FEITO NO CAMPO HOD FINAL, SE SIM INSERE NA TABELA.
if update(Hodometro_Final)
insert into TB_Updates_Historico_Carro select ins.Cod_Carro, GETDATE(),'Hodometro_Final',
CAST(del.Hodometro_Final as varchar(150)), cast(ins.Hodometro_Final as varchar(150))
from inserted as Ins
inner join Deleted as Del on Ins.Cod_Carro = Del.Cod_Carro

-- VERIFICA SE O UPDATE FOI FEITO NO CAMPO COMBUS ANTIGO, SE SIM INSERE NA TABELA.
if update(Qtde_Combus_Antigo)
insert into TB_Updates_Historico_Carro select ins.Cod_Carro, GETDATE(),'Qtde_Combus_Antigo',
CAST(del.Qtde_Combus_Antigo as varchar(150)), cast(ins.Qtde_Combus_Antigo as varchar(150))
from inserted as Ins
inner join Deleted as Del on Ins.Cod_Carro = Del.Cod_Carro

-- VERIFICA SE O UPDATE FOI FEITO NO CAMPO COMBUS ATUAL, SE SIM INSERE NA TABELA.

if update(Qtde_Combus_Atual)
insert into TB_Updates_Historico_Carro select ins.Cod_Carro, GETDATE(),'Qtde_Combus_Atual',
CAST(del.Qtde_Combus_Atual as varchar(150)), cast(ins.Qtde_Combus_Atual as varchar(150))
from inserted as Ins
inner join Deleted as Del on Ins.Cod_Carro = Del.Cod_Carro

-- VERIFICA SE O UPDATE FOI FEITO NO CAMPO DO ULTIMO ALUGUEL, SE SIM INSERE NA TABELA.

if update(Cod_Ultimo_Aluguel)
insert into TB_Updates_Historico_Carro select ins.Cod_Carro, GETDATE(),'Cod_Ultimo_Aluguel',
CAST(del.Cod_Ultimo_Aluguel as varchar(150)), cast(ins.Cod_Ultimo_Aluguel as varchar(150))
from inserted as Ins
inner join Deleted as Del on Ins.Cod_Carro = Del.Cod_Carro


-- VERIFICA SE O UPDATE FOI FEITO NO CAMPO DO ALUGUEL ATUAL, SE SIM INSERE NA TABELA.

if update(Cod_Aluguel_Atual)
insert into TB_Updates_Historico_Carro select ins.Cod_Carro, GETDATE(),'Cod_Aluguel_Atual',
CAST(del.Cod_Aluguel_Atual as varchar(150)), cast(ins.Cod_Aluguel_Atual as varchar(150))
from inserted as Ins
inner join Deleted as Del on Ins.Cod_Carro = Del.Cod_Carro

-- VERIFICA SE O UPDATE FOI FEITO NO CAMPO DO Observacoes, SE SIM INSERE NA TABELA.

if update(Observacoes)
insert into TB_Updates_Historico_Carro select ins.Cod_Carro, GETDATE(),'Observacoes',
CAST(del.Observacoes as varchar(150)), cast(ins.Observacoes as varchar(150))
from inserted as Ins
inner join Deleted as Del on Ins.Cod_Carro = Del.Cod_Carro

