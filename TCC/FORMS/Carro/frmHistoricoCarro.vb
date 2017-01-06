
Imports System.Data.SqlClient
Public Class frmHistoricoCarro
    Dim cn As New conexaosql
    Dim objcontrle As New ClsComando
    Dim varalter As Boolean = False
    Public Sub InsereHistorico()
        If Valida() = True Then
            Try
                cn.FechaConexaoSejaAberta()
                cn.cnn.Open()
                With cn.cmd
                    .Connection = cn.cnn
                    .CommandText = "exec sp_CriaHistoricoCarro @Hodometro_inicial = " & txtHodometro1.Text _
                        & " , @Hodometro_final = " & txtHodometro2.Text _
                        & " , @Qtde_Combus_Antigo = '" & lblcombus1.Text _
                        & "', @Qtde_Combus_Atual = '" & lblCombus2.Text _
                        & "' ,@Cod_Carro = " & txtcodcarro.Text _
                        & ", @Observacoes = '" & txtobservacoes.Text & "'"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Histórico cadastrado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            cn.cnn.Close()
        End If
    End Sub
    Sub AtualizaHistorico()
        If Valida() = True Then
            Try
                cn.FechaConexaoSejaAberta()
                cn.cnn.Open()
                With cn.cmd
                    .Connection = cn.cnn
                    .CommandText = "update TB_Historico_Carro set Hodometro_inicial = " & txtHodometro1.Text _
                        & " , Hodometro_final = " & txtHodometro2.Text _
                        & " , Qtde_Combus_Antigo = '" & lblcombus1.Text _
                        & "', Qtde_Combus_Atual = '" & lblCombus2.Text _
                        & "' ,Cod_Carro = " & txtcodcarro.Text _
                        & ", Observacoes = '" & txtobservacoes.Text & "'"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Histórico atualizado.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            cn.cnn.Close()
        End If
    End Sub
    Function Valida()
        If txtHodometro1.Text > txtHodometro2.Text Then
            MessageBox.Show("Hodometro inicial é maior que hodometro atual", "Hodometro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHodometro1.Focus()
            Return False
        ElseIf txtHodometro1.Text = Nothing Or txtHodometro1.Text = "" Then
            MessageBox.Show("Digite o hodometro inicial", "Hodometro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHodometro1.Focus()
            Return False
        ElseIf txtHodometro2.Text = Nothing Or txtHodometro2.Text = "" Then
            MessageBox.Show("Digite o hodometro atual", "Hodometro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHodometro2.Focus()
            Return False
        ElseIf txtobservacoes.Text = Nothing Or txtobservacoes.Text = "" Then
            MessageBox.Show("Digite as observações", "Observações", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtobservacoes.Focus()
            Return False
        ElseIf pbar1.Value = 0 Or pbar1.Value < 0 Then
            MessageBox.Show("insira a quantidade antiga de combustível", "Combustível", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button2.Focus()
            Return False
        ElseIf pbar2.Value = 0 Or pbar2.Value < 0 Then
            MessageBox.Show("insira a quantidade atual de combustível", "Combustível", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button4.Focus()
            Return False
        Else
            Return True
        End If

    End Function
    Public Sub PesquisaHistorico(ByVal CodCarro As Short)
        Dim mr As SqlDataReader

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select * from TB_Historico_Carro where Cod_Carro = " & CodCarro
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) Then
                MessageBox.Show("Esse carro ainda não possui nenhum Histórico, Insira o primeiro")
            Else
                txtcodcarro.Text = mr!Cod_carro
                If IsDBNull(mr!Cod_Ultimo_Aluguel) = False Then
                    txtcodaluguel.Text = mr!Cod_Ultimo_Aluguel
                End If

                txtHodometro1.Text = mr!Hodometro_inicial
                txtHodometro2.Text = mr!Hodometro_Final
                'txtCombus1.Text = mr!Qtde_Combus_Antigo
                'txtCombus2.Text = mr!Qtde_Combus_Atual
                txtobservacoes.Text = mr!Observacoes
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub


    Private Sub frmHistoricoCarro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call PesquisaHistorico()
        'Call DesabilitaCampos()
        pbar1.Value = frmNovoAluguel.ProgressBar1.Value
        lblcombus1.Text = frmNovoAluguel.lbltanque.Text



    End Sub

    Public Sub DesabilitaCampos()
        txtatualizacoes.Enabled = False
        txtcodaluguel.Enabled = False
        txtcodcarro.Enabled = False
        'txtCombus1.Enabled = False
        'txtCombus2.Enabled = False
        txtHodometro1.Enabled = False
        txtHodometro2.Enabled = False
        txtobservacoes.Enabled = False


    End Sub

    Private Sub DefineCombus(ByVal pbar As Windows.Forms.ProgressBar, ByVal campo As Control)
        Select Case pbar.Value
            Case 0
                campo.Text = 0
            Case 25
                campo.Text = "1/4"
            Case 50
                campo.Text = "1/2"
            Case 75
                campo.Text = "3/4"
            Case 100
                campo.Text = "1/1"
        End Select
    End Sub

    'Exibe os valores de combustivel
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If pbar1.Value < 76 Then
            pbar1.Value = pbar1.Value + 25
            Call DefineCombus(pbar1, lblcombus1)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If pbar1.Value > 0 AndAlso pbar1.Value <= 100 Then
            pbar1.Value = pbar1.Value - 25
            Call DefineCombus(pbar1, lblcombus1)
        Else
            Exit Sub
        End If
    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If pbar2.Value > 0 AndAlso pbar2.Value <= 100 Then
            pbar2.Value = pbar2.Value - 25
            Call DefineCombus(pbar2, lblCombus2)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If pbar2.Value < 76 Then
            pbar2.Value = pbar2.Value + 25
            Call DefineCombus(pbar2, lblCombus2)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Call InsereHistorico()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If varalter = False Then
            Call InsereHistorico()
        ElseIf varalter = True Then
            Call AtualizaHistorico()
        End If
    End Sub

    Sub ativacampos()
        txtHodometro1.Enabled = True
        txtHodometro2.Enabled = True
        Button5.Enabled = True
        Button2.Enabled = True
        Button4.Enabled = True
        Button3.Enabled = True
        txtobservacoes.Enabled = True
        ''habilita os campos
        ''For Each controle As Control In Me.GroupBox1.Controls
        ''    If TypeOf controle Is MaskedTextBox Then
        ''        controle.Enabled = True
        ''    End If
        ''Next
        'For Each controle As Control In Me.GroupBox2.Controls
        '    If TypeOf controle Is TextBox Then
        '        controle.Enabled = True
        '    End If
        '    If TypeOf controle Is Button Then
        '        controle.Enabled = True
        '    End If
        'Next
        'For Each controle As Control In Me.GroupBox3.Controls
        '    If TypeOf controle Is TextBox Then
        '        controle.Enabled = True
        '    End If
        '    If TypeOf controle Is RichTextBox Then
        '        controle.Enabled = True
        '    End If
        '    If TypeOf controle Is Button Then
        '        controle.Enabled = True
        '    End If
        'Next
        txtatualizacoes.Enabled = True
        txtcodaluguel.Enabled = True
        txtcodcarro.Enabled = True
    End Sub



    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles Altera.Click
        varalter = True
        Call ativacampos()
        Call PesquisaHistorico(frmCarro.txtcodcarro.Text)
        'habilita os campos
        txtatualizacoes.Enabled = False
        txtcodaluguel.Enabled = False
        txtcodcarro.Enabled = False
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        objcontrle.Limpar_tela(GrupoHod)
        objcontrle.Limpar_tela(GroupBox2)
        objcontrle.Limpar_tela(GroupBox3)
        Call ativacampos()
    End Sub
End Class