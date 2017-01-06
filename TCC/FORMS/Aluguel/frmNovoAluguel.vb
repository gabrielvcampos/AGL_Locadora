Imports System.Data.SqlClient
Public Class frmNovoAluguel
    Dim nextcodaluguel As Short
    Dim prevcodaluguel As Short
    Dim DataRetirada As Date
    Dim DataEntrega As Date
    Dim PrecoFinal As Double
    Dim TaxaSeguro As Double
    Dim CodSeguro As Byte
    Dim cn As New conexaosql
    Dim mr As SqlDataReader
    Dim objcontrole As New ClsComando

    '*********************************************** NÃO ESQUECER DE ZERAR VARIAVEL OBSCARRO AO FINALIZAR ALUGUEL 
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim HoraSistema As String = TimeOfDay 'Exibe horá do sistema
        mskHoraEntrega.Text = HoraSistema

        Dim DataSistema As String = Date.Now 'Exibi horá do sistema
        mskDataEntrega.Text = DataSistema

    End Sub
    Private Sub frmNovoAluguel_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        mskDataRetirada.Text = Format("dd/MM/yyyy", MonthCalendar1.SelectionStart.ToString)
        txtcod.Text = cn.getIdentCurrent("Tb_Aluguel") + 1
        lblCod.Text = cn.getIdentCurrent("Tb_Aluguel") + 1
        'Call CarregaCodAluguel()
        mskHoraRetirada.Text = Format(TimeOfDay, "HH:mm:ss")
        mskHoraEntrega.Text = Format(TimeOfDay, "HH:mm:ss")
        lbErro.Text = ""
        lbdias.Text = ""
    End Sub

    '*********************************************** NÃO ESQUECER DE ZERAR VARIAVEL OBSCARRO AO FINALIZAR ALUGUEL 
    Public Sub ConsultarCliente(ByVal value As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.FechaConexaoSejaAberta()

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Cod_Cli,NomeCompleto_Cli,RG_Cli,Habilitacao,cat_CNH from TB_Cliente where NomeCompleto_Cli like '%" & value & "%'"
                .CommandType = CommandType.Text
            End With
            If IsDBNull(mr) Then
                MessageBox.Show("Nenhum valor encontrado", "0 resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                FrmConsultaCliente.Show()
                da.SelectCommand = cn.cmd
                da.Fill(dt)
                da.Dispose()       '  libera recursos ou melhora a performance  
                FrmConsultaCliente.DataGrid.DataSource = dt        ' dt1 name do datagrid
                VarConsulta_Aluguel = True
                FormAberto = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Public Sub InsereAluguel()
        PrecoFinal = Format(PrecoFinal, "00.00")
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "exec sp_InsereAluguel @Cod_Cli = " & txtcod.Text _
                & ", @Cod_Func = " & CodUsuario _
                & ", @Cod_Carro = " & txtcodcarro.Text _
                & ", @Cod_seguro = " & CodSeguro _
                & ", @Condutor_Principal = '" & txtcondutor.Text _
                & "',@Data_Retirada = '" & Format(CDate(mskDataRetirada.Text), "MM/dd/yyyy") _
                & "', @Data_Entrega = '" & Format(CDate(mskDataEntrega.Text), "MM/dd/yyyy") _
                & "', @HoraRetirada = '" & mskHoraRetirada.Text _
                & "',@HoraEntrega = '" & mskHoraEntrega.Text _
                & "',@Condicao_Entrega = 'PENDENTE'" _
                & ", @Preco_Final = " & Replace(PrecoFinal, ",", ".") & ""
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Aluguel cadastrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        cn.cnn.Close()
        ObsCarro = Nothing
    End Sub

    Private Sub txtnomecli_ControlRemoved(sender As Object, e As System.Windows.Forms.ControlEventArgs) Handles txtnomecli.ControlRemoved

    End Sub

    '*********************************************** NÃO ESQUECER DE ZERAR VARIAVEL OBSCARRO AO FINALIZAR ALUGUEL 
    Private Sub txtnomecli_LostFocus(sender As Object, e As System.EventArgs) Handles txtnomecli.LostFocus
        Call ConsultarCliente(txtnomecli.Text)
    End Sub

    Private Sub lblCarros_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCarros.LinkClicked
        frmBuscarCarros.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmObsAluguel.Show()
    End Sub


    '*********************************************** NÃO ESQUECER DE ZERAR VARIAVEL OBSCARRO AO FINALIZAR ALUGUEL 
    Private Sub CalculaPrecoFinal()
        Dim HoraRetirada As Date = mskHoraRetirada.Text
        Dim HoraEntrega As Date = mskHoraEntrega.Text
        Dim DiferencaHoras As Short = DateDiff("H", HoraRetirada, HoraEntrega)

        If CDate(mskDataRetirada.Text) > CDate(mskDataEntrega.Text) Then
            mskDataEntrega.BackColor = Color.Red
            lbErro.Text = "Data de entrega menor do que data de retirada"
            Exit Sub
        Else
            mskDataEntrega.BackColor = Color.White
            lbErro.Text = ""
        End If

        Dim QtdeDias As Short = DateDiff("d", mskDataRetirada.Text, mskDataEntrega.Text) + 1
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
                    lblPreco.Text = PrecoFinal
                    Exit Sub
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '*********************************************** NÃO ESQUECER DE ZERAR VARIAVEL OBSCARRO AO FINALIZAR ALUGUEL 
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Call InsereAluguel()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        DataRetirada = e.Start.ToString
        mskDataRetirada.Text = DataRetirada
        mskDataRetirada.Text = Format("dd/MM/yyyy", mskDataRetirada.Text)
    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        DataEntrega = e.Start.ToString
        mskDataEntrega.Text = DataEntrega
        mskDataEntrega.Text = Format("dd/MM/yyyy", mskDataEntrega.Text)
        Call CalculaPrecoFinal()
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

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        objcontrole.Limpar_tela(GroupBox1)
        objcontrole.Limpar_tela(GroupBox2)
        objcontrole.Limpar_tela(GroupBox3)
        objcontrole.Limpar_tela(GroupBox4)
        objcontrole.Limpar_tela(GroupBox5)
        mskDataRetirada.Text = Format("dd/MM/yyyy", MonthCalendar1.SelectionStart.ToString)
        txtcod.Text = cn.getIdentCurrent("Tb_Aluguel") + 1
        lblCod.Text = cn.getIdentCurrent("Tb_Aluguel") + 1
        mskHoraRetirada.Text = Format(TimeOfDay, "HH:mm:ss")
        mskHoraEntrega.Text = Format(TimeOfDay, "HH:mm:ss")
        lbErro.Text = ""
        lbdias.Text = ""

    End Sub

    Private Sub lblCod_Click(sender As System.Object, e As System.EventArgs) Handles lblCod.Click

    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call CalculaPrecoFinal()
    End Sub

    Private Sub txtnomecli_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnomecli.TextChanged

    End Sub
End Class