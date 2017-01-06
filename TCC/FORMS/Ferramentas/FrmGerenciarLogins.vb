Imports System.Data.SqlClient
Public Class FrmGerenciarLogins
    Dim TipoOperacao As Boolean ''Se falso, salva NOVO login, se true ALTERA login existente
    Dim TipoLogin As Short
    Dim objcontrole As New clnValidaControles
    Dim ObjComando As New ClsComando
    Dim cn As New conexaosql
    Private Sub FrmGerenciarLogins_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If objcontrole.ValidaSeUsuarioTemAcesso() = True Then
            Me.Close()
        End If
        lberro.Text = ""
    End Sub

    Private Sub btnPesquisa_Click(sender As System.Object, e As System.EventArgs) Handles btnPesquisa.Click
        Call Consultar()
        txtnovasenha.Text = Nothing
        txtconfirmarsenha.Text = Nothing
    End Sub
    Public Sub Consultar()
        ObjComando.Limpar_tela(GroupBox1)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Login.Cod_func as 'Código do funcionário', TB_Funcionario.Nome_Func as 'Nome completo' from Login inner join TB_Funcionario on Login.Cod_Func = TB_Funcionario.Cod_Func"
                .CommandType = CommandType.Text
            End With
            frmConsultaFuncionario.Show()
            FormAbertoFunc = True
            da.SelectCommand = cn.cmd
            da.Fill(dt)
            da.Dispose()       '  libera recursos ou melhora a performance  
            frmConsultaFuncionario.DataGrid.DataSource = dt        ' dt1 name do datagrid
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
    Sub inserelogin()
        If ObjComando.ValidaSeJaExiste(txtcod, "COd_Func", "Login") = True Then
            Exit Sub
        End If
        Dim senha As String
        cn.FechaConexaoSejaAberta()
        cn.cnn.Open()
        'valida senha
        If txtnovasenha.Text = txtconfirmarsenha.Text Then
            senha = txtconfirmarsenha.Text
        Else
            lberro.Text = "Senhas diferem"
            Exit Sub
        End If
        'valida tipo de acesso
        If rbadm.Checked = True Then
            MessageBox.Show("Tem certeza que inserir como Administrador?", "Cadastro de login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf Windows.Forms.DialogResult.OK Then

            End If
            TipoLogin = 1
        ElseIf rbuser.Checked = True Then
            TipoLogin = 2
        End If
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "insert into Login(cod_func,senha_func,tipo_login) values(" & txtcod.Text & ",'" & senha & "', " & TipoLogin & ")"
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Inserido com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub AlteraLogin()
        If txtnovasenha.Text <> txtconfirmarsenha.Text Then
            lberro.Text = "Senhas divergentes"
            Exit Sub
        Else
            lberro.Text = ""
        End If
        If rbadm.Checked = True Then
            MessageBox.Show("Tem certeza que deseja alterar o perfil deste usuário para Administrador?", "Alteração de login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf Windows.Forms.DialogResult.OK Then

            End If
            TipoLogin = 1
        ElseIf rbuser.Checked = True Then
            TipoLogin = 2
        End If
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "update Login set senha_func = '" & txtnovasenha.Text & "',tipo_login = " & TipoLogin & " where cod_func = " & txtcod.Text & ""
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Alterado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Private Sub btngrava_Click(sender As System.Object, e As System.EventArgs) Handles btngrava.Click
        If TipoOperacao = False Then
            Call InsereLogin()
        ElseIf TipoOperacao = True Then
            Call AlteraLogin()
        End If
    End Sub

    Private Sub btnAltera_Click(sender As System.Object, e As System.EventArgs) Handles btnAltera.Click
        txtsenhaatual.Enabled = True
        txtnovasenha.Enabled = True
        txtconfirmarsenha.Enabled = True
        rbadm.Enabled = True
        rbuser.Enabled = True
        TipoOperacao = True

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        If txtcod.Text <> Nothing Or txtcod.Text = " " Then
            MessageBox.Show("Tem certeza que deseja excluir este login?", "Exclusão de login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If Windows.Forms.DialogResult.OK Then
                Call ExcluiLogin()
            Else : Exit Sub
            End If
        Else
            MessageBox.Show("Selecione um login.", "Nenhum login selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub ExcluiLogin()
        cn.FechaConexaoSejaAberta()
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "delete from Login where cod_func = " & txtcod.Text
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Removido com sucesso.", "Removido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        txtcod.Enabled = True
        txtnomefunc.Enabled = False
        TipoOperacao = False
        txtsenhaatual.Enabled = False
        txtnovasenha.Enabled = True
        txtconfirmarsenha.Enabled = True
        txtsenhaatual.Text = Nothing

    End Sub

    Private Sub txtcod_LostFocus(sender As Object, e As System.EventArgs) Handles txtcod.LostFocus
        If TipoOperacao = False Then
            cn.FechaConexaoSejaAberta()
            cn.cnn.Open()
            Dim mr As SqlDataReader
            Try
                With cn.cmd
                    .Connection = cn.cnn
                    .CommandText = "select Nome_Func from TB_Funcionario where Cod_func = " & txtcod.Text
                    .ExecuteNonQuery()
                End With
                mr = cn.cmd.ExecuteReader
                mr.Read()
                If IsDBNull(mr) Then
                    MessageBox.Show("Este funcionário não existe", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                txtnomefunc.Text = mr!Nome_Func
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            cn.cnn.Close()
        End If
    End Sub


End Class