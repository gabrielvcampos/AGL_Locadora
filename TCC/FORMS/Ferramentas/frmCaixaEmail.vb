Imports System.Data.SqlClient
Public Class frmCaixaEmail
    Dim codigo As String
    Dim Consulta As Boolean
    Public Sub ListarInformacoes()
        'variáveis

        Dim CN As New conexaosql
        Dim listagem As New ListViewItem
        Dim mr As SqlDataReader

        'define se a consulta é do contato ou reserva do web site
        If Consulta = True Then
            codigo = "Select * from Tb_ContatoSite"
        Else
            codigo = "Select * from Tb_ReservaSite"
        End If

        CN.cnn.Open() 'abre a conexão
        Try
            'realiza a consulta no sql
            With CN.cmd
                .Connection = CN.cnn
                .CommandText = codigo
                .ExecuteNonQuery()
            End With
            mr = CN.cmd.ExecuteReader
            'mr.Read()
            '  ID,Cod_Func,Nome,Endereco,Telefone,Cidade,Email,Veiculo,Data_Inicio,Mensagem

            'atribui valores para o formulário

            For Each DataRow In mr
                listagem = lstReserva.Items.Add(mr!ID)
                listagem.SubItems.Add(mr!Nome)
                listagem.SubItems.Add(mr!Email)
                listagem.SubItems.Add(mr!Mensagem)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CN.cnn.Close()
    End Sub

    Private Sub lstReserva_DoubleClick(sender As Object, e As System.EventArgs) Handles lstReserva.DoubleClick
        'Retorna valor que estpa selecionado na listview e isola os números. 
        Dim tempValor As New System.Text.StringBuilder()
        For Each c As Char In lstReserva.SelectedItems.Item(0).ToString.ToCharArray()
            If Char.IsNumber(c) OrElse c.Equals("."c) OrElse c.Equals(","c) Then
                tempValor.Append(c)
            End If
        Next
        'variavel q armazena somente o numero da string 
        Dim novoValor As Short = CShort(tempValor.ToString)
        IDReserva = novoValor
        Dim CN As New conexaosql
        Dim mr As SqlDataReader
        CN.FechaConexaoSejaAberta()
        CN.cnn.Open()

        Try
            With CN.cmd
                .Connection = CN.cnn
                .CommandText = codigo & " where ID = " & novoValor
                .ExecuteNonQuery()
            End With

            'ID, Cod_Func, nome, Endereco, Telefone, Cidade, email, Veiculo, Data_Inicio, Mensagem
            mr = CN.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) = False Then

                frmConfirmaReserva.txtEmail.Text = mr!Email
                frmConfirmaReserva.txtNome.Text = mr!Nome
                frmConfirmaReserva.txtMensagem.Text = mr!Mensagem
                frmConfirmaReserva.Show()
                'Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnContato_Click(sender As System.Object, e As System.EventArgs) Handles btnContato.Click
        Consulta = True
        lstReserva.Items.Clear()
        Call ListarInformacoes()

    End Sub

    Private Sub btnReserva_Click(sender As System.Object, e As System.EventArgs) Handles btnReserva.Click
        Consulta = False
        lstReserva.Items.Clear()
        Call ListarInformacoes()

    End Sub

End Class