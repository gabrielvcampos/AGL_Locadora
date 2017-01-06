Imports System.Data.SqlClient
Public Class ClsCarro
    'properties para manter a integridade dos dados do sistema
    Dim cn As New conexaosql
    Dim InsertQuery As String
    Dim car_cod As Short
    Dim car_CodCategoria As String
    Dim car_placa As String
    Dim car_marca As String
    Dim car_modelo As String
    Dim car_cor As String
    Dim car_dataFabri As String
    Dim car_TipoCombustivel As String
    Dim car_Status As Short
    Dim car_Situacao As Short
    Dim car_ano As String
    Dim car_chassi As String
    Dim car_renavam As String
    Dim car_CodHistorico As String
    Dim car_HodoAnterior As String
    Dim car_HodoAtual As String
    Dim car_HodoUltAluguel As String
    Dim car_qtdeCombusAnterior As String
    Dim car_qtdeCOmbusAtual As String
    Dim car_qtdeCombusUltAluguel As String
    Dim car_Obs As String
    Dim car_imagem As String

    Public Property Cod_Carro() As Short
        Get
            Return car_cod

        End Get
        Set(ByVal value As Short)
            car_cod = value

        End Set
    End Property
    Public Property Categoria_Carro() As String
        Get
            Return car_CodCategoria

        End Get
        Set(ByVal value As String)
            car_CodCategoria = value
        End Set
    End Property
    Public Property Placa_Carro() As String
        Get
            Return car_placa

        End Get
        Set(ByVal value As String)
            car_placa = value

        End Set
    End Property
    Public Property Marca_Carro() As String
        Get
            Return car_marca

        End Get
        Set(ByVal value As String)
            car_marca = value

        End Set
    End Property
    Public Property Modelo_Carro() As String
        Get
            Return car_modelo

        End Get
        Set(ByVal value As String)
            car_modelo = value

        End Set
    End Property
    Public Property Cor_Carro() As String
        Get
            Return car_cor

        End Get
        Set(ByVal value As String)
            car_cor = value

        End Set
    End Property
    Public Property DataFabri_Carro() As String
        Get
            Return car_dataFabri

        End Get
        Set(ByVal value As String)
            car_dataFabri = value

        End Set
    End Property
    Public Property Combustivel_Carro() As String
        Get
            Return car_TipoCombustivel

        End Get
        Set(ByVal value As String)
            car_TipoCombustivel = value

        End Set
    End Property
    Public Property Status_Carro() As Short
        Get
            Return car_Status

        End Get
        Set(ByVal value As Short)
            car_Status = value

        End Set
    End Property
    Public Property Situacao_Carro() As Short
        Get
            Return car_Situacao

        End Get
        Set(ByVal value As Short)
            car_Situacao = value

        End Set
    End Property
    Public Property Ano_Carro() As String
        Get
            Return car_ano

        End Get
        Set(ByVal value As String)
            car_ano = value

        End Set
    End Property
    Public Property Chassi_Carro() As String
        Get
            Return car_chassi

        End Get
        Set(ByVal value As String)
            car_chassi = value

        End Set
    End Property
    Public Property Renavam_Carro() As String
        Get
            Return car_renavam

        End Get
        Set(ByVal value As String)
            car_renavam = value

        End Set
    End Property
    Public Property codHist_Carro() As String
        Get
            Return car_CodHistorico

        End Get
        Set(ByVal value As String)
            car_CodHistorico = value

        End Set
    End Property
    Public Property HodoAnterior_Carro() As String
        Get
            Return car_HodoAnterior

        End Get
        Set(ByVal value As String)
            car_HodoAnterior = value

        End Set
    End Property
    Public Property HodoAtual_Carro() As String
        Get
            Return car_HodoAtual

        End Get
        Set(ByVal value As String)
            car_HodoAtual = value

        End Set
    End Property
    Public Property HodoUltAluguel_Carro() As String
        Get
            Return car_HodoUltAluguel
        End Get
        Set(ByVal value As String)
            car_HodoUltAluguel = value

        End Set
    End Property
    Public Property QtdeCombusAnterior_Carro() As String
        Get
            Return car_qtdeCombusAnterior

        End Get
        Set(ByVal value As String)
            car_qtdeCombusAnterior = value

        End Set
    End Property
    Public Property qdteCombusAtual() As String
        Get
            Return car_qtdeCOmbusAtual

        End Get
        Set(ByVal value As String)
            car_qtdeCOmbusAtual = value

        End Set
    End Property
    Public Property QtdeCombusUltAluguel As String
        Get
            Return car_qtdeCombusUltAluguel

        End Get
        Set(ByVal value As String)
            car_qtdeCombusUltAluguel = value

        End Set
    End Property
    Public Property Obs_Carro() As String
        Get
            Return car_Obs

        End Get
        Set(ByVal value As String)
            car_Obs = value

        End Set
    End Property
    Public Property Imagem_Carro() As String
        Get
            Return car_imagem

        End Get
        Set(ByVal value As String)
            car_imagem = value
        End Set
    End Property

    Public Sub inserir()
        'sb que executa a procedure de inclusão de carros... para inserção no banco de dados
        InsertQuery = "exec sp_CadCarro @Cod_Cat = " & car_CodCategoria _
                    & " , @Placa = '" & car_placa _
                    & "' , @Modelo = '" & car_modelo _
                    & "' , @Cor = '" & car_cor _
                    & "' , @Marca = '" & car_marca _
                    & "' , @Data_Fabricacao = '" & car_dataFabri _
                    & "' , @Cod_Tipo_Combus = '" & car_TipoCombustivel _
                    & "' , @Renavam = '" & car_renavam _
                    & "' , @Chassi = '" & car_chassi _
                    & "' , @Ano = '" & car_ano _
                    & "' , @Cod_Situacao = " & car_Situacao _
                    & " ,@Status_Carro = " & car_Status _
                    & ", @Caminho_Foto = '" & car_imagem & "'"
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = InsertQuery
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Public Sub InserirAcessoriosCarro(ByVal CodAcess As Short)
        'sub que insere o acessorio do carro de acordo com o parametro recebido ex se for passado o parametro 1, sera inserido o acessorio ar condicionado para o carro
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "insert into TB_Acessorios_Carro(Cod_Carro,Cod_Acess) values (" & frmCarro.txtcodcarro.Text & "," & CodAcess & ")"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.cnn.Close()
    End Sub

    Public Sub InserirAcessoriosCategoria(ByVal CodAcess As Short)
        'sub que insere o acessorios que o carro da categoria pode ter de acordo com o parametro recebido ex se for passado o parametro 1, sera inserido o acessorio ar condicionado para o carro
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "insert into Tb_Acessorios_Categoria(Cod_Cat,Cod_Acess) values (" & frmCategoria.txtcodcat.Text & "," & CodAcess & ")"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.cnn.Close()
    End Sub
    Public Sub ConsultaHistorico(ByVal Cod_Carro As Short)
        ' sub que realiza a consulta do historico ao cadastrar o carro e verifica se é necessário cadastrar o primeiro historico
        Dim mr As SqlDataReader
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select * from TB_Historico_Carro where Cod_Carro = " & Cod_Carro
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()

            If IsDBNull(mr) Then
                MessageBox.Show("Carro não possui histórico cadastrado. Cadastre antes de continuar.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cn.cnn.Close()
                frmHistoricoCarro.txtcodcarro.Text = Cod_Carro
                frmHistoricoCarro.txtcodcarro.Enabled = False
                frmHistoricoCarro.txtcodaluguel.Enabled = False
                frmHistoricoCarro.Show()
                Exit Sub
            Else
                If mr.HasRows = True Then
                    frmHistoricoCarro.txtcodcarro.Text = mr!Cod_carro
                    If IsDBNull(mr!Cod_Ultimo_Aluguel) = False Then
                        frmHistoricoCarro.txtcodaluguel.Text = mr!Cod_Ultimo_Aluguel
                    End If
                    frmHistoricoCarro.txthodometro1.Text = mr!Hodometro_inicial
                    frmHistoricoCarro.txthodometro2.Text = mr!Hodometro_Final
                    frmHistoricoCarro.lblcombus1.Text = mr!Qtde_Combus_Antigo
                    frmHistoricoCarro.lblCombus2.Text = mr!Qtde_Combus_Atual
                    frmHistoricoCarro.txtobservacoes.Text = mr!Observacoes
                End If
            End If
            'If mr.HasRows Then

            'End If
            'desabilita os campos
            For Each controle As Control In frmHistoricoCarro.GrupoHod.Controls
                If TypeOf controle Is MaskedTextBox Then
                    controle.Enabled = False
                End If
            Next
            For Each controle As Control In frmHistoricoCarro.GroupBox2.Controls
                If TypeOf controle Is TextBox Then
                    controle.Enabled = False
                End If
                If TypeOf controle Is Button Then
                    controle.Enabled = False
                End If
            Next
            For Each controle As Control In frmHistoricoCarro.GroupBox3.Controls
                If TypeOf controle Is TextBox Then
                    controle.Enabled = False
                End If
                If TypeOf controle Is RichTextBox Then
                    controle.Enabled = False
                End If
                If TypeOf controle Is Button Then
                    controle.Enabled = False
                End If
            Next
            frmHistoricoCarro.txtatualizacoes.Enabled = False
            frmHistoricoCarro.txtcodaluguel.Enabled = False
            frmHistoricoCarro.txtcodcarro.Enabled = False

            'define qtde combustivel
            With frmHistoricoCarro
                Select Case .lblcombus1.Text
                    Case "1/4"
                        .pbar1.Value = 25
                    Case "1/2"
                        .pbar1.Value = 50
                    Case "3/4"
                        .pbar1.Value = 75
                    Case "1/1"
                        .pbar1.Value = 100
                End Select
                Select Case .lblCombus2.Text
                    Case "1/4"
                        .pbar2.Value = 25
                    Case "1/2"
                        .pbar2.Value = 50
                    Case "3/4"
                        .pbar2.Value = 75
                    Case "1/1"
                        .pbar2.Value = 100
                End Select
            End With
            Call BuscaQtdeAtualizacoesHistorico(CShort(mr!Cod_carro))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.cnn.Close()
    End Sub

    Sub BuscaQtdeAtualizacoesHistorico(ByVal CodCarro As Short)
        'sub que consulta a quantidade de atualizações feita no historico do carro
        cn.FechaConexaoSejaAberta()
        Dim mr As SqlDataReader
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Cod_update as 'Resultado' from TB_Updates_Historico_Carro where Cod_Carro = " & CodCarro
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            Dim contaatualizacoes As Short = 0 'armazena quantos registros existem na tabela
            While mr.Read
                contaatualizacoes = contaatualizacoes + 1
            End While
            frmHistoricoCarro.txtatualizacoes.Text = contaatualizacoes
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()

    End Sub


    Sub CarregaAcessoriosDacategoria(ByVal CodCat As Short, ByVal VarForm As Boolean) ' Varform quando falso executa rotina para frmCarro, quando verdadeiro executa rotina para frmCategoria
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        ' sub que lista todos os acessórios da categoria, no caso os acessórios que a categoria pode ter.
        'LIMPA A CHECKEDLISTBOX
        If VarForm = False Then

            frmCarro.ListBox1.Items.Clear()
        Else
            frmCategoria.ListBox1.Items.Clear()
        End If


        cn.FechaConexaoSejaAberta()
        'CONSULTA ACESSÓRIOS DISPONÍVEIS POR CATEGORIA
        Try
            cn.conexaoon()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select TB_Acessorios_Categoria.Cod_Acess,Tb_Acessorios.Descricao_Acess from " _
                & "Tb_Acessorios_Categoria inner join Tb_Acessorios on " _
                & "Tb_Acessorios_Categoria.Cod_Acess = Tb_Acessorios.Cod_Acess where  Tb_Acessorios_Categoria.Cod_Cat = " & CodCat
                .ExecuteNonQuery()
            End With

            'preenche data table
            da.SelectCommand = cn.cmd
            da.Fill(dt)
            da.Dispose()

            'percorre data table
            Dim contador As Integer = 0
            For Each Row As DataRow In dt.Rows
                If VarForm = False Then
                    frmCarro.ListBox1.Items.Add(dt.Rows(contador)("Descricao_Acess").ToString)
                    contador = contador + 1
                Else
                    frmCategoria.ListBox1.Items.Add(dt.Rows(contador)("Descricao_Acess").ToString)
                    contador = contador + 1
                End If
            Next Row

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        cn.conexaooff()
    End Sub
End Class
