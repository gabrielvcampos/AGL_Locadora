
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



Public Class frmRelatorios


    Dim objcontrole As New clnValidaControles
    Dim cn As New conexaosql
    Private Sub frmRelatorioAluguel_Load(sender As Object, e As System.EventArgs)
        If objcontrole.ValidaSeUsuarioTemAcesso() = True Then
            Me.Close()
        End If
        txtdata1.Enabled = False
        txtdata2.Enabled = False
    End Sub

    'Sub GerarRelatorio(ByVal Strquery As String) 'ByVal data1 As Date, ByVal data2 As Date
    '    Dim ds As DataSet
    '    Dim dt As DataTable
    '    Dim da As SqlDataAdapter
    '    cn.FechaConexaoSejaAberta()
    '    Try
    '        cn.cnn.Open()
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandTimeout = 30
    '            .CommandType = CommandType.Text
    '            .CommandText = Strquery
    '            .ExecuteNonQuery()
    '        End With
    '        da = New SqlDataAdapter(cn.cmd)
    '        ds = New DataSet
    '        da.Fill(ds)
    '        dt = ds.Tables(0)
    '        frmExibeRelatorio.dtReport.DataSource = dt
    '        frmExibeRelatorio.Show()

    '        ''********************** CRIAR ARQUIVO EXCEL ***************************
    '        'Dim objExcel As Microsoft.Office.Interop.Excel.Application
    '        'Dim Pasta1 As Microsoft.Office.Interop.Excel.Workbook
    '        'Dim Plan1 As Microsoft.Office.Interop.Excel.Worksheet
    '        'Pasta1 = objExcel.Workbooks.Add
    '        'Plan1 = objExcel.Worksheets.Add
    '        'Plan1.Name = "Relatório de aluguéis"
    '        'Plan1.Activate()
    '        'Dim i As Integer
    '        'Dim linha As Integer = 4
    '        ''Alimentar
    '        'For i = 0 To dt.Rows.Count - 1
    '        '    linha += 1
    '        '    objExcel.ActiveSheet.cells(linha, 1) = dt.Rows(0).
    '        'Next


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    cn.cnn.Close()
    'End Sub



    Private Sub rbCustom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbCustom.CheckedChanged
        If rbCustom.Checked = True Then
            txtdata1.Enabled = True
            txtdata2.Enabled = True
        Else
            txtdata1.Enabled = False
            txtdata2.Enabled = False
        End If
    End Sub


    Private Sub ckprog_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckprog.CheckedChanged
        If ckprog.Checked = True Then
            ckfechados.Checked = False
        End If
    End Sub

    Private Sub ckfechados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckfechados.CheckedChanged
        If ckfechados.Checked = True Then
            ckprog.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmReportUpdatesCarrro.Show()

    End Sub

    Private Sub btnGerar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnGerar.Click
        Dim query As String = ""
        Dim tiporealtorio As String = Nothing
        'valida datas customizadas
        If txtdata1.Text = txtdata2.Text AndAlso rbCustom.Checked = True Then
            MessageBox.Show("Datas coincidem", "Datas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdata1.BackColor = Color.Red
            txtdata2.BackColor = Color.Red
            Exit Sub
        Else
            txtdata1.BackColor = Color.White
            txtdata2.BackColor = Color.White
        End If
        'valida se ambas as opções foram selecionadas juntas
        If ckfechados.Checked = True AndAlso ckprog.Checked = True Then
            MessageBox.Show("Selecione somente uma opção", "Opções!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ckfechados.ForeColor = Color.Red
            ckprog.ForeColor = Color.Red
            Exit Sub
        Else
            ckfechados.ForeColor = Color.Black
            ckprog.ForeColor = Color.Black
        End If

        'valida o periodo selecionado para extração de relatorio
        If rbSemana.Checked = True Then
            query = "select * from TB_Aluguel where Data_Retirada > dateadd(WEEK, -1, getdate())"
            tiporealtorio = "Relatórios desta semana"

        ElseIf rbMes.Checked = True Then
            query = "select * from TB_Aluguel where Data_Retirada > dateadd(month, -1, getdate())"
            tiporealtorio = "Relatórios deste mês"

        ElseIf rbAno.Checked = True Then
            query = "select * from TB_Aluguel where Data_Retirada > dateadd(year, -1, getdate())"
            tiporealtorio = "Relatórios deste ano"

        ElseIf rbCustom.Checked = True Then
            query = "select* from TB_Aluguel where Data_Retirada between '" _
                & Format(CDate(txtdata1.Text), "MM/dd/yyyy") & "' and '" _
                & Format(CDate(txtdata2.Text), "MM/dd/yyyy") & "'"
            tiporealtorio = "Relatórios de " & txtdata1.Text & "até " & txtdata2.Text
        End If
        If ckfechados.Checked = True Then
            query = query & " and Status_Aluguel = 'FECHADO'"
        ElseIf ckprog.Checked = True Then
            query = query & " and Status_Aluguel = 'EM PROGRESSO'"
        End If
        Call CarregaReportViewer(query, tiporealtorio)

    End Sub
    Sub CarregaReportViewer(ByVal query As String, ByVal titulorelatorio As String)
        Dim Tabela As New Relatorio.RelatorioDataTableDataTable
        Dim Linha As Relatorio.RelatorioDataTableRow
        Dim mr As SqlDataReader
        '************** CAMPOS DO RELATORIO ********************8
        'Cod_Aluguel()  'Cod_Cli()   'Cod_Func()  'Cod_Carro() 'Cod_seguro()     'Condutor_Principal()
        'Data_Retirada()  'Data_Entrega() 'Horaretirada() 'HoraEntrega() 'condicao_Entrega()
        'Preco_Final()  'Status_Aluguel()  'Preco_Final_Real()

        Try
            'Abre conexao com o Banco de Dados para pegar as infos do relatorio

            cn.FechaConexaoSejaAberta()
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = query 'Query que vem de acordo com a opçao selecionada no form
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            While mr.Read ' Para cada linha da consulta efetuada acima, será adicionada a tabela Relatorio, criada no Dataset "Relatorio.xsd"
                Linha = Tabela.NewRow()
                Linha("Cod_Aluguel") = mr!Cod_Aluguel
                Linha("Cod_Cli") = mr!Cod_Cli
                Linha("Cod_Func") = mr!Cod_Func
                Linha("Cod_Carro") = mr!Cod_Carro
                Linha("Cod_seguro") = mr!Cod_seguro
                Linha("Condutor_Principal") = mr!Condutor_Principal
                Linha("Data_Retirada") = mr!Data_Retirada
                Linha("Data_Entrega") = mr!Data_Entrega
                Linha("Horaretirada") = mr!Horaretirada
                Linha("HoraEntrega") = mr!HoraEntrega
                Linha("condicao_Entrega") = mr!condicao_Entrega
                Linha("Preco_Final") = mr!Preco_Final
                Linha("Status_Aluguel") = mr!Status_Aluguel
                Linha("Preco_Final_Real") = mr!Preco_Final_Real
                Tabela.AddRelatorioDataTableRow(Linha)
            End While

            Dim TmpDT As DataTable = Tabela 'Constroi a tabela formada acima
            Dim objrpt As New CrystalReport2 'Objeto do crystalreport
            objrpt.SetDataSource(TmpDT) 'Define a fonte do crystalreport como sendo a tabela construida
            frmReportAluguel.CrystalReportViewer1.ReportSource = objrpt 'Atribui a fonte ao Visualizador do crystalreport
            frmReportAluguel.CrystalReportViewer1.Refresh() 'Atualiza o visualizador
            frmReportAluguel.Text = titulorelatorio ' atribui o titulo do relatorio ao form
            frmReportAluguel.Show() ' Exibe form do relatorio gerado

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao extrair relatório", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub frmRelatorios_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If objcontrole.ValidaSeUsuarioTemAcesso() = True Then
            Me.Close()
        End If
    End Sub
End Class