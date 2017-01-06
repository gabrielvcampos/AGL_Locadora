Imports System.Data.SqlClient
Public Class frmConsultaFuncionario
    Dim cn As New conexaosql
    Dim mr As SqlDataReader
    Dim TipoTelefone As String = Nothing
    Dim str As String


    Private Sub DataGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        Select Case FormAbertoFunc
            Case False
                Call CarregaDadosFunc()
            Case True
                Call CarregaDadosLogin()
        End Select
    End Sub
    Public Sub CarregaDadosFunc()
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "exec sp_consultafunc @Cod_Func = " & DataGrid.CurrentRow.Cells(0).Value & ""
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If
            If mr.HasRows = True Then
                frmFuncionario.txtCodFunc.Text = mr!Cod_Func
                frmFuncionario.txtNomeFunc.Text = mr!Nome_func
                If mr!Sexo_Func = "M" Then
                    frmFuncionario.txtsexofunc.Text = "Masculino"
                ElseIf mr!Sexo_Func = "F" Then
                    frmFuncionario.txtsexofunc.Text = "Feminino"
                End If
                frmFuncionario.txtcargo.SelectedIndex = CInt(mr!Cod_Cargo)
                frmFuncionario.listTel.Items.Clear()
                frmFuncionario.txtcpf.Text = mr!CPF_Func
                frmFuncionario.txtdata.Text = mr!DataNasc_Func
                frmFuncionario.txtrg.Text = mr!RG_Func
                frmFuncionario.txtlograFunc.Text = mr!Logradouro_Func
                frmFuncionario.txtnumcasa.Text = mr!NumCasa_Func
                frmFuncionario.txtcompl.Text = mr!Complemento_Func
                frmFuncionario.txtbairro.Text = mr!Bairro_Func
                frmFuncionario.txtcidade.Text = mr!Cidade_Func
                frmFuncionario.txtCepFunc.Text = mr!CEP_Func
                frmFuncionario.txtestado.Text = mr!Estado_Func
                frmFuncionario.txtemail.Text = mr!Email
                If IsDBNull(mr!CaminhoFoto_Func) = False Then
                    frmFuncionario.PicFotoFunc.ImageLocation = mr!CaminhoFoto_Func
                End If
                Call CarregaTelefoneFunc()
                Call ArmazenaTelefones()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        Me.Close()


    End Sub
    Public Sub CarregaTelefoneFunc()

        cn.FechaConexaoSejaAberta()
        frmFuncionario.listTel.Items.Clear()
        frmFuncionario.txttipotel.Visible = False
        frmFuncionario.txttipotel2.Visible = False
        frmFuncionario.txtnumtel.Visible = False
        frmFuncionario.txtnumtel2.Visible = False
        frmFuncionario.listTel.Visible = True
        str = "exec sp_consultatelfunc @Cod_Func = " & DataGrid.CurrentRow.Cells(0).Value & ""
        'For Each lvItem As ListViewItem In frmFuncionario.listTel.Items
        '    lvItem.Remove()
        'Next

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = str
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If
            frmFuncionario.listTel.CheckBoxes = False
            frmFuncionario.listTel.FullRowSelect = True
            Dim listagem As New ListViewItem
            While mr.Read
                If mr!Cod_Tipo_Tel = "1" Then
                    TipoTelefone = "Residencial"
                ElseIf mr!Cod_Tipo_Tel = "2" Then
                    TipoTelefone = "Celular"
                ElseIf mr!Cod_Tipo_Tel = "3" Then
                    TipoTelefone = "Comercial"
                ElseIf mr!Cod_Tipo_Tel = "4" Then
                    TipoTelefone = "Outro"
                End If
                listagem = frmFuncionario.listTel.Items.Add(mr!Telefone)
                listagem.SubItems.Add(TipoTelefone)
            End While
            cn.cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cn.cnn.Close()
        End Try

    End Sub
    Public Sub ArmazenaTelefones()
        cn.FechaConexaoSejaAberta()
        Dim contador As Integer = 0
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = str
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If

            While mr.Read
                contador = contador + 1
                If mr!Cod_Tipo_Tel = "1" Then
                    TipoTelefone = "Residencial"
                ElseIf mr!Cod_Tipo_Tel = "2" Then
                    TipoTelefone = "Celular"
                ElseIf mr!Cod_Tipo_Tel = "3" Then
                    TipoTelefone = "Comercial"
                ElseIf mr!Cod_Tipo_Tel = "4" Then
                    TipoTelefone = "Outro"
                End If
                Telefones_Func(contador - 1) = mr!Telefone
                Tipo_Telefones_Func(contador - 1) = TipoTelefone
                CodTelefoneFunc(contador) = mr!Cod_Tel_Func
            End While
            cn.cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cn.cnn.Close()
        End Try
        'MsgBox("Valor 1: " & Telefones(0) & "     Valor2: " & Telefones(1))
        cn.cnn.Close()
    End Sub
    Public Sub CarregaDadosLogin()
        For Each campo As Control In FrmGerenciarLogins.Controls
            If TypeOf campo Is RadioButton Then
            ElseIf TypeOf campo Is TextBox Then
                campo.Text = ""
            End If
        Next
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select tipo_login,Cod_Func,senha_func from Login where Cod_Func = " & DataGrid.CurrentRow.Cells(0).Value & ""
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If
            FrmGerenciarLogins.txtcod.Text = DataGrid.CurrentRow.Cells(0).Value
            FrmGerenciarLogins.txtnomefunc.Text = DataGrid.CurrentRow.Cells(1).Value
            FrmGerenciarLogins.txtsenhaatual.Text = mr!senha_func
            If mr!tipo_login = 1 Then
                FrmGerenciarLogins.rbadm.Checked = True
            ElseIf mr!tipo_login = 2 Then
                FrmGerenciarLogins.rbuser.Checked = True
            End If
            VarTipoLogin = mr!tipo_login

            FrmGerenciarLogins.txtsenhaatual.Enabled = False
            FrmGerenciarLogins.txtnovasenha.Enabled = False
            FrmGerenciarLogins.txtconfirmarsenha.Enabled = False
            FrmGerenciarLogins.rbadm.Enabled = False
            FrmGerenciarLogins.rbuser.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        Me.Close()
    End Sub


End Class