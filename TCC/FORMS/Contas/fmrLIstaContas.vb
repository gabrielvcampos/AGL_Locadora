Imports System.Data.SqlClient

Public Class fmrLIstaContas
    Dim listagem As New ListViewItem

    Private Sub fmrLIstaContas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listCOntas.Items.Clear()
        If TipoConsConta = False Then
            Call ConsultarContasPendentes()
        ElseIf TipoConsConta = True Then
            Call ConsultarContasPagas()
        End If
    End Sub
    Public Sub ConsultarContasPagas()
        Dim CN As New conexaosql
        Dim naopago As String
        naopago = "Não Pago"
        Dim mr As SqlDataReader
        CN.cnn.Open()
        Try
            With CN.cmd
                .Connection = CN.cnn
                .CommandText = "select TB_Contas.Cod_Func," _
                    & "TB_Contas.Cod_Pagamento, " _
                    & " TB_Contas.MesReferencia," _
                    & "TB_Contas.Data_Venc, " _
                    & "TB_Contas.Valor_Conta," _
                    & "TB_Contas.Status_Conta, " _
                    & " Tb_Tipo_Contas.Descricao " _
                    & "from TB_Contas inner join Tb_Tipo_Contas " _
                    & " on Tb_Contas.Cod_Conta = Tb_Tipo_Contas.Cod_Conta " _
                    & "where Status_Conta = 'Pago'"
                .ExecuteNonQuery()
            End With
            mr = CN.cmd.ExecuteReader
            For Each datarow In mr
                listagem = listCOntas.Items.Add(mr!Cod_Pagamento)
                listagem.SubItems.Add(mr!Cod_Func)
                listagem.SubItems.Add(mr!Descricao)
                listagem.SubItems.Add(mr!MesReferencia)
                listagem.SubItems.Add(mr!Data_Venc)
                listagem.SubItems.Add(mr!Valor_Conta)
                listagem.SubItems.Add(mr!Status_Conta)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CN.cnn.Close()

    End Sub
    Public Sub ConsultarContasPendentes()
        Dim CN As New conexaosql
        Dim naopago As String
        naopago = "Não Pago"
        Dim mr As SqlDataReader
        CN.cnn.Open()
        Try
            With CN.cmd
                .Connection = CN.cnn
                .CommandText = "select TB_Contas.Cod_Func," _
                    & "TB_Contas.Cod_Pagamento, " _
                    & " TB_Contas.MesReferencia," _
                    & "TB_Contas.Data_Venc, " _
                    & "TB_Contas.Valor_Conta," _
                    & "TB_Contas.Status_Conta, " _
                    & " Tb_Tipo_Contas.Descricao " _
                    & "from TB_Contas inner join Tb_Tipo_Contas " _
                    & " on Tb_Contas.Cod_Conta = Tb_Tipo_Contas.Cod_Conta " _
                    & "where Status_Conta like '%Não pago%'"
                .ExecuteNonQuery()
            End With
            mr = CN.cmd.ExecuteReader
            For Each datarow In mr
                listagem = listCOntas.Items.Add(mr!Cod_Pagamento)
                listagem.SubItems.Add(mr!Cod_Func)
                listagem.SubItems.Add(mr!Descricao)
                listagem.SubItems.Add(mr!MesReferencia)
                listagem.SubItems.Add(mr!Data_Venc)
                listagem.SubItems.Add(mr!Valor_Conta)
                listagem.SubItems.Add(mr!Status_Conta)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CN.cnn.Close()

    End Sub
    Private Sub BtnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtualiza.Click
        listCOntas.Items.Clear()

        Call ConsultarContasPendentes()
    End Sub

    Private Sub listCOntas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listCOntas.DoubleClick
        'Retorna valor que estpa selecionado na listview e isola os números. 
        Dim tempValor As New System.Text.StringBuilder()
        For Each c As Char In listCOntas.SelectedItems.Item(0).ToString.ToCharArray()
            If Char.IsNumber(c) OrElse c.Equals("."c) OrElse c.Equals(","c) Then
                tempValor.Append(c)
            End If
        Next
        'variavel q armazena somente o numero da string 
        Dim novoValor As Short = CShort(tempValor.ToString)


        Dim CN As New conexaosql
        Dim mr As SqlDataReader
        CN.FechaConexaoSejaAberta()
        CN.cnn.Open()

        Try
            With CN.cmd
                .Connection = CN.cnn
                .CommandText = "select TB_contas.*,TB_Tipo_Contas.Descricao from TB_Contas inner join" _
                    & " TB_Tipo_Contas on Tb_Contas.Cod_Conta = Tb_Tipo_Contas.Cod_Conta " _
                    & "where COd_Pagamento = " & novoValor
                .ExecuteNonQuery()
            End With
            mr = CN.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) = False Then
                CodPagamento = mr!Cod_Pagamento
                frmContas.cbTipo.Text = mr!Descricao
                frmContas.cbMes.Text = mr!MesReferencia
                frmContas.txtvalorConta.Text = mr!Valor_Conta
                frmContas.txtValorPAgo.Text = mr!Valor_Pago
                frmContas.txtCodFunc.Text = CodUsuario
                If mr!Status_Conta = "Não Pago" Then
                    frmContas.rbNaoPaga.Checked = True
                ElseIf mr!Status_Conta = "Pago" Then
                    frmContas.rbPaga.Checked = True
                End If
                For Each controle As Control In frmContas.GroupBox1.Controls
                    If TypeOf controle Is TextBox Then
                        controle.Enabled = False
                    ElseIf TypeOf controle Is MaskedTextBox Then
                        controle.Enabled = False
                    ElseIf TypeOf controle Is RadioButton Then
                        controle.Enabled = False
                    ElseIf TypeOf controle Is DateTimePicker Then
                        controle.Enabled = False
                    ElseIf TypeOf controle Is ComboBox Then
                        controle.Enabled = False

                    End If
                Next

                frmContas.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        listCOntas.Items.Clear()

        Call ConsultarContasPagas()
    End Sub
End Class