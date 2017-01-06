Imports System.Data.SqlClient
Public Class frmContas
    Dim InsertQuery As String
    Dim objvalida As New clnValidaControles
    Dim cn As New conexaosql
    Dim objcontrole As New ClsComando
    Dim objCarro As New ClsCarro
    Dim CodCOnta As String
    Dim varalter As Boolean 'valida se é para atualizar ou inserir conta
 
    Public Sub DefineStatus()
        If rbNaoPaga.Checked = True Then
            statusConta = "Não Pago"
        ElseIf rbPaga.Checked = True Then
            statusConta = "Pago"
        End If
    End Sub
   
    Public Sub AtualizarConta()


        'consistencias
        If cbTipo.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o tipo da conta.", "Tipo da conta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If cbMes.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o mês de referência.", "Mês de referência", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtvalorConta.Text = "0.00" Or txtvalorConta.Text = Nothing Or IsNumeric(txtvalorConta.Text) = False Then
            MessageBox.Show("Digite o valor da conta corretamente.", "Valor da conta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If rbPaga.Checked = True And txtValorPAgo.Text = Nothing Or IsNumeric(txtValorPAgo.Text) = False Then
            If rbNaoPaga.Checked = True Then
            Else
                MessageBox.Show("Digite o valor pago corretamente.", "Valor pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If
        If rbPaga.Checked = False AndAlso rbNaoPaga.Checked = False Then
            MessageBox.Show("Selecione o status da conta.", "Status da conta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'define status da conta
        Call DefineStatus()


        Dim valorConta As String
        Dim valorPago As String = Nothing

        valorConta = txtvalorConta.Text
        valorConta = Replace(valorConta, ",", ".")

        If txtValorPAgo.Text <> Nothing Then

            valorPago = txtValorPAgo.Text
            valorPago = Replace(valorPago, ",", ".")
        End If
        Try
            cn.FechaConexaoSejaAberta()
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "EXEC  SP_ALTERA_CONTA" _
                & " @Cod_Pagamento = " & CodPagamento _
                & ", @Cod_Conta = " & cbTipo.SelectedIndex _
                & ", @MesReferencia = '" & cbMes.Text _
                & "',@Data_Venc = '" & Format(CDate(DTVencimento.Text), "MM/dd/yyy") _
                & "',@Data_Pgto =  '" & Format(CDate(DTPagamento.Text), "MM/dd/yyy") _
                & "', @Valor_Pago = " & valorPago _
                & ", @Valor_Conta = " & valorConta _
                & ", @Status_Conta = '" & statusConta & "'"
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Conta atualizada.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        cn.cnn.Close()
    End Sub
    Public Sub CadastraConta()

        'consistencias
        If cbTipo.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o tipo da conta.", "Tipo da conta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If cbMes.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o mês de referência.", "Mês de referência", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtvalorConta.Text = "0.00" Or txtvalorConta.Text = Nothing Or IsNumeric(txtvalorConta.Text) = False Then
            MessageBox.Show("Digite o valor da conta corretamente.", "Valor da conta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If rbPaga.Checked = True And txtValorPAgo.Text = Nothing Or IsNumeric(txtValorPAgo.Text) = False Then
            If rbNaoPaga.Checked = True Then
            Else
                MessageBox.Show("Digite o valor pago corretamente.", "Valor pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
           
        End If
        If rbPaga.Checked = False AndAlso rbNaoPaga.Checked = False Then
            MessageBox.Show("Selecione o status da conta.", "Status da conta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'define status da conta
        Call DefineStatus()


        Dim valorConta As String
        Dim valorPago As String = Nothing

        valorConta = txtvalorConta.Text
        valorConta = Replace(valorConta, ",", ".")

        If txtValorPAgo.Text <> Nothing Then

            valorPago = txtValorPAgo.Text
            valorPago = Replace(valorPago, ",", ".")
        End If


        InsertQuery = "exec sp_CadastrarContas" _
            & " @Cod_Func = '" & CodUsuario _
            & "', @Cod_Conta = '" & cbTipo.SelectedIndex _
            & "', @MesReferencia = '" & cbMes.Text _
            & "', @Data_Venc = '" & Format(CDate(DTVencimento.Text), "MM/dd/yyy") _
            & "', @Data_Pgto = '" & Format(CDate(DTPagamento.Text), "MM/dd/yyy") _
            & "', @Valor_Pago = '" & valorPago _
            & "', @Valor_Conta = '" & valorConta _
            & "',@Status_Conta = '" & statusConta & "'"

        Try
            cn.FechaConexaoSejaAberta()
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = InsertQuery
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Conta cadastrada.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub


    Private Sub frmContas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If objvalida.ValidaSeUsuarioTemAcesso() = True Then
            Me.Close()
        End If

        picNPaga.Visible = False
        picPaga.Visible = False
        txtCodFunc.Text = CodUsuario
        txtCodFunc.Enabled = False
        txtValorPAgo.Enabled = True
        lbErro.Text = ""
        Call CarregaTipoContas()
        'Call DesativaCampos()




    End Sub

    Sub CarregaTipoContas()
        cbTipo.Items.Add("Selecione...")
        cbTipo.Text = "Selecione..."
        Try
            cn.FechaConexaoSejaAberta()
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Descricao from TB_Tipo_Contas order by Descricao asc"
                .ExecuteNonQuery()
            End With
            Dim mr As SqlDataReader = cn.cmd.ExecuteReader
            If IsDBNull(mr) = False Then
                For Each DataRow In mr
                    cbTipo.Items.Add(mr!Descricao)
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao retornar contas!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If varalter = False Then
            Call CadastraConta()
        ElseIf varalter = True Then
            Call AtualizarConta()
        End If


    End Sub

    Private Sub chkNaoPaga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNaoPaga.CheckedChanged



        If rbNaoPaga.Enabled = True Then
            picNPaga.Visible = True
            picPaga.Visible = False
        End If
    End Sub

    Private Sub chkPaga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPaga.CheckedChanged
        If rbPaga.Enabled = True Then
            picPaga.Visible = True
            picNPaga.Visible = False

        End If


    End Sub

  
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        fmrLIstaContas.Show()
        TipoConsConta = False

    End Sub

    
 



    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        varalter = False
        For Each controle As Control In Me.GroupBox1.Controls
            If TypeOf controle Is TextBox Then
                controle.Enabled = True
                controle.Text = Nothing
            ElseIf TypeOf controle Is MaskedTextBox Then
                controle.Enabled = True
                controle.Text = Nothing
            ElseIf TypeOf controle Is RadioButton Then
                controle.Enabled = True
            ElseIf TypeOf controle Is DateTimePicker Then
                controle.Enabled = True
                controle.Text = Nothing
            ElseIf TypeOf controle Is ComboBox Then
                controle.Enabled = True

            End If
        Next
        lbErro.BackColor = Color.Black
        lbErro.Text = Nothing
        cbTipo.SelectedIndex = 0
        cbMes.SelectedIndex = 0
       
    End Sub


    Private Sub DTPagamento_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DTPagamento.ValueChanged
        If DTPagamento.Value = DTVencimento.Value Then
            lbErro.ForeColor = Color.Black
            lbErro.Text = ""

        ElseIf DTPagamento.Value > DTVencimento.Value Then
            lbErro.Text = "Conta paga após vencimento"
            lbErro.ForeColor = Color.Red
        Else
            lbErro.ForeColor = Color.Black
            lbErro.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        varalter = True
        For Each controle As Control In Me.GroupBox1.Controls
            If TypeOf controle Is TextBox Then
                controle.Enabled = True
            ElseIf TypeOf controle Is MaskedTextBox Then
                controle.Enabled = True
            ElseIf TypeOf controle Is RadioButton Then
                controle.Enabled = True
            ElseIf TypeOf controle Is DateTimePicker Then
                controle.Enabled = True
            ElseIf TypeOf controle Is ComboBox Then
                controle.Enabled = True

            End If
        Next
    End Sub
End Class