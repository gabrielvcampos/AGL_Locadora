Module modulo

    'Estas são todas as variaveis que são utilizadas em mais de um form. Por isso estão declaradas de forma global em um module. 
    Public CaminhoFoto As String
    Public IDReserva As Short ' armazena ID da reserva que sera confirmada via e-mail com o cliente
    Public CodFoto As String
    Public form As String
    Public PictureBox As Windows.Forms.PictureBox
    Public FormAberto As Boolean ' se falso, frmcliente aberto / se true frmnovoaluguel aberto
    Public FormAbertoFunc As Boolean 'se falso, frmfunc aberto / se true frmgerenciarlogin aberto
    Public CodUsuario As Short  'armazena valor do codigo do usuario que esta logado no sistema
    Public VarTipoLogin As Short 'usado para verificar se o usuario alterou o tipo do login frmgerenciarlogins
    Public Caminho As String
    Public TipoConsulta As String
    Public nextcodcarro As Short
    Public prevcodcarro As Short
    Public Telefones(2) As String
    Public Tipo_Telefones(2) As String
    Public Telefones_Func(2) As String
    Public Tipo_Telefones_Func(2) As String
    Public VarConsulta_Aluguel As Boolean
    Public CodCategoria As Short
    Public ObsCarro As String
    Public CodCarroHist As Short
    Public CodTelefoneCli(2) As Short
    Public CodTelefoneFunc(2) As Short
    Public statusConta As String 'Status da conta - pago e não pago
    Public CodPagamento As Short
    Public TipoConsConta As Boolean 'se falso, consulta contas pagas, se true, contas nao pagas
    Public varForm As Boolean 'Valida se o form para inserão de categoria é o frmcarro ou frmcategoria
    Public DataEntrega As Date
    Public HoraEntrega As String
    Public PrecoPrevisto As Double

End Module
