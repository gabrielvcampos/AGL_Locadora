Imports System.IO
Imports System.Object
Imports System.Security.CodeAccessPermission
Imports System.Security.Permissions.FileIOPermission
Imports System.Security.Permissions
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmIndex
    Dim cn As New conexaosql
    Dim mr As SqlClient.SqlDataReader


    Private Sub frmIndex_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_LocadoraDataSet.TB_Aluguel' table. You can move, or remove it, as needed.

        Timer1.Start()
        CodUsuario = 1
        'Valida se a dll \crdb_adoplus.dll existe no caminho que é utilizado pelos frameworks e se o caminho nao existir, cria automaticamente

        Dim Caminho As String = "C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win64_x64\dotnet1"

        'Dim CaminhoOrigem As String = "C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win64_x64"

        If Directory.Exists(Caminho) = False Then
            
            MkDir(Caminho)

            File.Copy("C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win64_x64\crdb_adoplus.dll", "C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win64_x64\dotnet1\crdb_adoplus.dll")
        ElseIf Directory.Exists(Caminho) = True And Directory.Exists("C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win64_x64\dotnet1\crdb_adoplus.dll") = False Then
            Try
                File.Copy("C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win64_x64\crdb_adoplus.dll", "C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win64_x64\dotnet1\crdb_adoplus.dll")
            Catch ex As Exception

                Exit Sub
            End Try
        End If

    End Sub

    Private Sub NovoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmCadastroCliente As New frmCliente
        frmCadastroCliente.MdiParent = Me
        frmCadastroCliente.Show()
    End Sub

    Private Sub NovoCarroToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmCadastroCarro As New frmCarro
        frmCadastroCarro.MdiParent = Me
        frmCadastroCarro.Show()
    End Sub

    Private Sub NovoFuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmCadastroFuncionario As New frmFuncionario
        frmCadastroFuncionario.MdiParent = Me
        frmCadastroFuncionario.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem.Click


        ContasToolStripMenuItem.Enabled = False
        AjudaToolStripMenuItem.Enabled = False
        EmailToolStripMenuItem.Enabled = False
        For Each controle As Control In Me.Controls
            If TypeOf controle Is Button Then
                controle.Enabled = False
            End If


        Next
        frmLogin.Show()

    End Sub
    Private Sub AluguelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AluguelToolStripMenuItem.Click

        frmNovoAluguel.Show()
    End Sub

    Private Sub CarrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmConsultaCliente.Show()
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        Dim DataSistema As String = DateAndTime.Now 'Exibi horá do sistema
        lbData.Text = DataSistema

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmConsultaCliente.Show()

    End Sub

    Private Sub CadastrarNovaContaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarNovaContaToolStripMenuItem.Click
        frmContas.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmCliente.Show()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailToolStripMenuItem.Click



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        frmCliente.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmFuncionario.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarro.Click
        frmCarro.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        frmNovoAluguel.Show()
    End Sub

    Private Sub GerenciarLoginsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GerenciarLoginsToolStripMenuItem.Click
        FrmGerenciarLogins.Show()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogin.Show()
    End Sub


    Private Sub BackupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        frmBackup.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        frmFinalizaAluguel.Show()

    End Sub

    Private Sub RelatórioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RelatórioToolStripMenuItem.Click
        frmRelatorios.Show()
    End Sub

    Private Sub ContasAPagarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContasAPagarToolStripMenuItem.Click
        fmrLIstaContas.Show()

    End Sub

    Private Sub ContasPagasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        fmrLIstaContas.Show()
        TipoConsConta = True
    End Sub

    Private Sub CaixaDeEnrtradaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CaixaDeEnrtradaToolStripMenuItem.Click
        frmCaixaEmail.Show()

    End Sub

    Private Sub NovoEmailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NovoEmailToolStripMenuItem.Click
        FrmEnviaEmail.Show()

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmCategoria.Show()
    End Sub

    Private Sub SuporteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuporteToolStripMenuItem.Click
        frmSuporte.Show()

    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        frmSobre.Show()
    End Sub

    Private Sub NovoCarroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NovoCarroToolStripMenuItem.Click
        frmCarro.Show()
    End Sub

    Private Sub NovoClienteToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles NovoClienteToolStripMenuItem.Click
        frmCliente.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCategoria.Show()

    End Sub

    Private Sub NovoFuncionárioToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles NovoFuncionárioToolStripMenuItem.Click
        frmFuncionario.Show()
    End Sub
End Class

