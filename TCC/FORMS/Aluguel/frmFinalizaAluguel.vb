Imports System.Data.SqlClient
Public Class frmFinalizaAluguel
    Dim DataRetirada As Date
    Dim DataEntrega As Date
    Dim PrecoFinal As Double
    Dim precoFinalReal As Double
    Dim TaxaSeguro As Double
    Dim CodSeguro As Byte
    Dim cn As New conexaosql
    Dim mr As SqlDataReader
    Private Sub frmFinalizaAluguel_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lbErro.Text = ""
        lbdias.Text = ""


    End Sub
    Private Sub AllTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F2
                Call ConsultarAluguelEmProgresso()
        End Select
    End Sub
    Public Sub ConsultarAluguelEmProgresso()
        Dim QueryConsulta As String = "SELECT Tb_Aluguel.Cod_Aluguel as 'Cod. Aluguel',TB_Aluguel.Status_Aluguel as 'Status do aluguel', Tb_Cliente.NomeCompleto_Cli as 'Nome do cliente'," _
                                & "TB_Aluguel.Data_Retirada as 'Data de retirada',TB_Carro.Modelo as 'Carro'" _
                                & "from TB_Aluguel inner join Tb_Cliente " _
                                & "on TB_Aluguel.Cod_Cli = Tb_Cliente.Cod_Cli " _
                                & "inner join TB_Carro on TB_Aluguel.Cod_Carro = TB_Carro.Cod_Carro  where Tb_Cliente.NomeCompleto_Cli like '%" & txtnomecli.Text & "%'" _
                                & "And TB_Aluguel.Cod_Carro = TB_Carro.Cod_Carro and TB_Aluguel.Status_Aluguel = 'EM PROGRESSO'"
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.FechaConexaoSejaAberta()

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = QueryConsulta
                .CommandType = CommandType.Text
            End With
            If IsDBNull(mr) Then
                MessageBox.Show("Nenhum valor encontrado", "0 resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                'Dim f As New frmConsultaAluguel
                frmConsultaAluguel.Show()
                da.SelectCommand = cn.cmd
                da.Fill(dt)
                da.Dispose()       '  libera recursos ou melhora a performance  
                frmConsultaAluguel.DataGridAluguel.DataSource = dt        ' dt1 name do datagrid
                'VarConsulta_Aluguel = True
                'FormAberto = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
    Public Function BuscaValorseguro()
        Dim mr As SqlDataReader
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Taxa_Seguro from tb_seguro where Cod_Seguro = 1"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If mr.HasRows = False Then
                MessageBox.Show("Erro ao retornar taxa do seguro", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
                Exit Function
            Else
                TaxaSeguro = mr!Taxa_Seguro
                Return TaxaSeguro
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        If pbar2.Value < 76 Then
            pbar2.Value = pbar2.Value + 25
            Call DefineCombus(pbar2, lblCombus2)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If pbar2.Value > 0 AndAlso pbar2.Value <= 100 Then
            pbar2.Value = pbar2.Value - 25
            Call DefineCombus(pbar2, lblCombus2)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Call ConsultarAluguelEmProgresso()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If chkAvaria.Checked = True And rbsim.Checked = False Then
            Call CalculaPrecoFinal()
            Call CalcularPrecoFinalReal(PrecoFinal, 1.25)
        Else
            Call CalculaPrecoFinal()
            Call CalcularPrecoFinalReal(PrecoFinal, 1.0)
        End If
    End Sub
    Sub CalcularPrecoFinalReal(ByVal PrecoFinal As Double, ByVal Ajustes As Double)

        precoFinalReal = (PrecoFinal * Ajustes)
        lbajustes.Text = Format((precoFinalReal - PrecoPrevisto), "00.00")
        precoFinalReal = Format(precoFinalReal, "00.00")
        lbPrecoReal.Text = precoFinalReal
    End Sub
    Private Sub CalculaPrecoFinal()
        Dim HoraRetirada As Date = mskHoraRetirada.Text
        Dim HoraEntrega As Date = mskHoraEntrega.Text
        Dim DiferencaHoras As Short = DateDiff("H", HoraRetirada, HoraEntrega)

        If CDate(DateTimePicker1.Text) > CDate(DateTimePicker2.Text) Then
            DateTimePicker2.BackColor = Color.Red
            lbErro.Text = "Data de entrega menor do que data de retirada"
            Exit Sub
        Else
            DateTimePicker2.BackColor = Color.White
            lbErro.Text = ""
        End If

        Dim QtdeDias As Short = DateDiff("d", DateTimePicker1.Text, DateTimePicker2.Text) + 1
        If DiferencaHoras >= 1 Then
            lbdias.Text = DiferencaHoras & vbCrLf & "hora(s) extra"
            QtdeDias = QtdeDias + 1
        End If

        cn.FechaConexaoSejaAberta()
        Dim mr As SqlDataReader
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Diaria,Km_Extra,Semana,Dia_Extra from Tb_Categoria where Cod_Cat = " & CodCategoria
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) Then
                MessageBox.Show("Não foi possível obter dados para o cálculo do preço", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For Each DataRow In mr
                    PrecoFinal = QtdeDias * CDbl(mr!Diaria)
                    If cbSeguro.Checked = True Then
                        Call BuscaValorseguro()
                        PrecoFinal = PrecoFinal * TaxaSeguro
                        CodSeguro = 1
                    End If
                    If DateTimePicker2.Text = DataEntrega Then
                    Else
                        lbajustes.Text = PrecoFinal - PrecoPrevisto
                    End If

                    Exit Sub
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtnomecli_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtnomecli.KeyDown, DateTimePicker2.KeyDown, txthodatual.KeyDown, mskHoraEntrega.KeyDown, txtobs.KeyDown

        Select Case e.KeyCode
            Case Keys.F2
                Call ConsultarAluguelEmProgresso()
            Case Keys.F3
                Call AlteraDados()
            Case Keys.F5
                If chkAvaria.Checked = True And rbsim.Checked = False Then
                    Call CalcularPrecoFinalReal(lblPreco.Text, 1.25)
                Else
                    Call CalcularPrecoFinalReal(lblPreco.Text, 1.0)
                End If
            Case Keys.Escape
                MessageBox.Show("DEseja sair sem salvar?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                ElseIf Windows.Forms.DialogResult.No Or Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If
        End Select
    End Sub
    Sub AlteraDados()
        cn.FechaConexaoSejaAberta()

        If rbFechado.Checked = False Then
            MessageBox.Show("Deseja prosseguir sem alterar o status do aluguel para Fechado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        'DEfine status do aluguel
        Dim Status As String = Nothing
        If rbPendente.Checked = True Then
            Status = rbPendente.Text
            Panel2.BackColor = Color.White
        ElseIf rbProgresso.Checked = True Then
            Status = rbProgresso.Text
            Panel2.BackColor = Color.White
        ElseIf rbFechado.Checked = True Then
            Status = rbFechado.Text
            Panel2.BackColor = Color.White
        Else
            MessageBox.Show("Selecione o status", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Panel2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        End If

        'Valida se preco final foi calculado
        If precoFinalReal <= 0 Then
            MessageBox.Show("Preço real não calculado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbPrecoReal.BackColor = Color.Red
            Exit Sub
        Else
            lbPrecoReal.BackColor = Color.Green
        End If
        If lblCombus2.Text = "???" Then
            MessageBox.Show("Insire a quantidade de combustível no tanque!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txthodatual.Text = Nothing Then
            MessageBox.Show("Insira a quilometragem atual", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txthodatual.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        Else
            txthodatual.BackColor = Color.White
        End If
        'valida se hodometro final é menor do que o inicial
        If txthodretirada.Text > txthodatual.Text Then
            MessageBox.Show("Quilometragem atual é menor que quilometragem antiga!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txthodatual.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        Else
            txthodatual.BackColor = Color.White
        End If
        'valida se foi digitado observações
        If IsNothing(txtobs.Text) Then
            MessageBox.Show("Digite as observações!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtobs.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        Else
            txtobs.BackColor = Color.White
        End If
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "exec sp_FinalizaAluguel @Cod_Aluguel = " & lblCod.Text _
                    & ",  @Cod_Carro = " & txtcodcarro.Text _
                    & ", @Data_Entrega = '" & Format(CDate(DateTimePicker2.Text), "MM/dd/yyyy") _
                    & "', @HoraEntrega = '" & mskHoraEntrega.Text _
                    & "', @Preco_Final_Real = " & Replace(lbPrecoReal.Text, ",", ".") _
                    & ", @Status_Aluguel = '" & Status _
                    & "', @Qtde_Combus_Atual = '" & lblCombus2.Text _
                    & "', @Hodometro_Final = " & txthodatual.Text _
                    & ", @Observacoes = '" & txtobs.Text & "'"

                .ExecuteNonQuery()
            End With
            rbFechado.Checked = True
            MessageBox.Show("Aluguel finalizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Private Sub chkAvaria_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAvaria.CheckedChanged
        rbsim.Checked = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Call AlteraDados()
    End Sub

    
    Private Sub txtnomecli_LostFocus(sender As Object, e As System.EventArgs) Handles txtnomecli.LostFocus
        Call ConsultarAluguelEmProgresso()
    End Sub

    Private Sub listAcessorios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles listAcessorios.SelectedIndexChanged

    End Sub
End Class