
Imports System.Data.SqlClient
Public Class frmFuncionario
    Dim cn As New conexaosql
    Dim comando As New ClsComando
    Dim CaminhoFoto As String = Nothing
    Dim ObjControle As New ClsComando

    Dim querycadastro As String
    Dim mr As SqlClient.SqlDataReader
    Dim testar As Integer
    Dim objFunc As New ClsFunc
    Dim NextCodFunc As Short
    Dim PrevCodFunc As String
    Dim sexo As String

    Dim objvalida As New clnValidaControles
    Dim varCons As Boolean = False
    Dim varAlter As Boolean = False
    Dim str As String

   
    Public Sub OrdemFoco()
        txtNomeFunc.Focus()
        txtNomeFunc.TabIndex = 1
        txtcpf.TabIndex = 2
        txtrg.TabIndex = 3

        txtsexofunc.TabIndex = 5
        txtdata.TabIndex = 6
        txtsexofunc.TabIndex = 7
        txtcargo.TabIndex = 8
        txtlograFunc.TabIndex = 9
        txtnumcasa.TabIndex = 10
        txtcompl.TabIndex = 11
        txtCepFunc.TabIndex = 12
        txtbairro.TabIndex = 13
        txtcidade.TabIndex = 14
        txtestado.TabIndex = 15
        txttipotel.TabIndex = 16

        txtnumtel.TabIndex = 17
        txttipotel2.TabIndex = 18
        txtnumtel2.TabIndex = 19
        txtemail.TabIndex = 20


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If varAlter = False Then
            Call Inserir()
        ElseIf varAlter = True Then
            Call Alterar()
        End If
    End Sub

    Public Sub insereTelefoneFunc()

        Dim tipotel As Short
        If txttipotel.SelectedIndex = 0 Then
            tipotel = 4
        ElseIf txttipotel.SelectedIndex = 1 Then
            tipotel = 1
        ElseIf txttipotel.SelectedIndex = 2 Then
            tipotel = 2
        ElseIf txttipotel.SelectedIndex = 3 Then
            tipotel = 3
        ElseIf txttipotel.SelectedIndex = 4 Then
            tipotel = 4
        End If



        Dim tipotel2 As String = Nothing
        If txttipotel2.SelectedIndex = 0 Then
            tipotel2 = 4
        ElseIf txttipotel2.SelectedIndex = 1 Then
            tipotel2 = 1
        ElseIf txttipotel2.SelectedIndex = 2 Then
            tipotel2 = 2
        ElseIf txttipotel2.SelectedIndex = 3 Then
            tipotel2 = 3
        ElseIf txttipotel2.SelectedIndex = 4 Then
            tipotel2 = 4
        End If

        objFunc.Cod_Func = NextCodFunc
        objFunc.Telefone1_Func = txtnumtel.Text
        objFunc.CodTipoTel_Func = tipotel
        objFunc.InsereTelefone()
        If IsNothing(txtnumtel2.Text) Then
            Exit Sub
        Else
            objFunc.Telefone2_Func = txtnumtel2.Text
            objFunc.CodTipoTel2_Func = tipotel2
            objFunc.InsereSegundoTelFUnc()
        End If

        MessageBox.Show("Inserido funcionário", "Inserido Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Public Sub ValidaTipoTel()
        If txttipotel.SelectedIndex = 2 Then
            txtnumtel.Mask = "(00)00000-0000"
        Else
            txtnumtel.Mask = "(00)0000-0000"
        End If
    End Sub

    Public Sub ValidaTipoTel2()

        If txttipotel2.SelectedIndex = 2 Then
            txtnumtel2.Mask = "(00)00000-0000"
        Else
            txtnumtel2.Mask = "(00)0000-0000"
        End If
    End Sub


    Public Sub Inserir()
        'VALIDA CAMPO NOME
        If objvalida.gfConsisteCampos(txtNomeFunc, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        'VALIDA CAMPO CPF
        If txtcpf.TextLength <> 14 Then
            MessageBox.Show("CPF digitado está inválido!", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcpf.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtcpf.Focus()
            Exit Sub
        Else
            txtcpf.BackColor = Color.White
        End If
        If ObjControle.ValidaSeJaExiste(txtcpf, "CPF_Func", "TB_Funcionario") = True Then Exit Sub

        'VALIDA  CAMPO RG
        If objvalida.gfConsisteCampos(txtrg, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjControle.ValidaSeJaExiste(txtrg, "RG_Func", "TB_Funcionario") = True Then Exit Sub

        If DateDiff("YYYY", txtdata.Text, Now) < 16 Then
            MessageBox.Show("Funcionário não possui mais que 16 anos", "Não é possível cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtdata.Focus()
            txtdata.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        End If
        'VALIDA HABILITAÇÃO
        'If objvalida.gfConsisteCampos(txtHabFunc, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        'VALIDA SEXO
        If txtsexofunc.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o sexo do Funcionário", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsexofunc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtsexofunc.Focus()
            Exit Sub

        ElseIf txtsexofunc.SelectedIndex = 1 Then
            sexo = "M"
            txtsexofunc.BackColor = System.Drawing.Color.White

        ElseIf txtsexofunc.SelectedIndex = 2 Then
            sexo = "F"
            txtsexofunc.BackColor = System.Drawing.Color.White
        End If

        'VALIDA CARGO DO FUNCIONÁRIO
        If txtcargo.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o cargo do funcionário", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcargo.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtcargo.Focus()
            Exit Sub
        End If


        'VALIDA DATA DE NASCIMENTO DO FUNCIONÀRIO
        If DateDiff("yyyy", txtdata.Text, Now) < 16 Then
            MessageBox.Show("Funcionário menor de idade!", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdata.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtdata.Focus()
            Exit Sub


        End If

        'VALIDA CAMPOS DE ENDEREÇO1
        If objvalida.gfConsisteCampos(txtlograFunc, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtnumcasa, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        'VALIDA CEP DO FUNCIONÀRIO
        If IsNothing(txtCepFunc.Text) Or txtCepFunc.Text = " " Then
            MessageBox.Show("Digite o CEP do funcionário", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCepFunc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtCepFunc.Focus()

        End If

        'VALIDA CAMPOS DE ENDEREÇO2
        If objvalida.gfConsisteCampos(txtbairro, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtcidade, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub


        'VALIDA ESTADO
        If CStr(txtestado.Text) = "---" Then
            MsgBox("O campo Estado deve ser digitado")
            txtestado.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtestado.Focus()
            Exit Sub
        Else
            txtestado.Text = CStr(txtestado.Text)
        End If


        'VALIDA TELEFONE1
        If txttipotel.SelectedIndex = 0 Then
            MessageBox.Show("Digite o tipo de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txttipotel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txttipotel.Focus()
            Exit Sub
        ElseIf txtnumtel.Text = "" Then
            MessageBox.Show("Digite um número de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnumtel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtnumtel.Focus()
            Exit Sub
        End If

        'VALIDA TELEFONE2
        If txttipotel2.SelectedIndex = 0 Then
            MessageBox.Show("Digite o tipo de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txttipotel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txttipotel.Focus()
            Exit Sub
        ElseIf txtnumtel2.Text = "" Then
            MessageBox.Show("Digite um número de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnumtel2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtnumtel2.Focus()
            Exit Sub
        End If



        'VALIDA SE O TELEFONE ESTA DUPLICADO
        If txtnumtel.Text = txtnumtel2.Text Then
            MessageBox.Show("Telefones duplicados.", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnumtel2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtnumtel2.Focus()
            Exit Sub
        End If


        If objvalida.ValidEMail(txtemail.Text) = False Then Exit Sub


        objFunc.Nome_Func = txtNomeFunc.Text
        objFunc.DataNasc_Func = Format(txtdata.Value, "MM/dd/yyyy")
        objFunc.Sexo_Func = sexo
        objFunc.CPF_Func = txtcpf.Text
        objFunc.RG_Func = txtrg.Text
        objFunc.Logradouro_Func = txtlograFunc.Text
        objFunc.NumCasa_Func = txtnumcasa.Text
        objFunc.Complemento_Func = txtcompl.Text
        objFunc.Bairro_Func = txtbairro.Text
        objFunc.Cidade_Func = txtcidade.Text
        objFunc.Cep_Func = txtCepFunc.Text
        objFunc.UF_func = txtestado.Text
        objFunc.Email_Func = txtemail.Text
        objFunc.Cargo_Func = txtcargo.SelectedIndex
        objFunc.Foto_Func = Caminho
        objFunc.IncluirFuncionario()
        Call insereTelefoneFunc()







    End Sub
    Public Sub Alterar()
        cn.FechaConexaoSejaAberta()
        'VALIDA CAMPO NOME
        If objvalida.gfConsisteCampos(txtNomeFunc, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        'VALIDA CAMPO CPF
        If txtcpf.TextLength <> 14 Then
            MessageBox.Show("CPF digitado está inválido!", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcpf.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtcpf.Focus()
            Exit Sub
        Else
            txtcpf.BackColor = Color.White
        End If

        'VALIDA  CAMPO RG
        If objvalida.gfConsisteCampos(txtrg, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        'If DateDiff("YYYY", txtdata.Text, Now) < 16 Then
        '    MessageBox.Show("Funcionário não possui mais que 16 anos", "Não é possível cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtdata.Focus()
        '    txtdata.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        '    Exit Sub
        'End If
        'VALIDA HABILITAÇÃO
        'If objvalida.gfConsisteCampos(txtHabFunc, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        'VALIDA SEXO
        If txtsexofunc.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o sexo do Funcionário", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsexofunc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtsexofunc.Focus()
            Exit Sub

        ElseIf txtsexofunc.SelectedIndex = 1 Then
            sexo = "M"
            txtsexofunc.BackColor = System.Drawing.Color.White

        ElseIf txtsexofunc.SelectedIndex = 2 Then
            sexo = "F"
            txtsexofunc.BackColor = System.Drawing.Color.White
        End If

        'VALIDA CARGO DO FUNCIONÁRIO
        If txtcargo.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o cargo do funcionário", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcargo.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtcargo.Focus()
            Exit Sub

        End If
        'VALIDA DATA DE NASCIMENTO DO FUNCIONÀRIO
        If DateDiff("yyyy", txtdata.Text, Now) < 16 Then
            MessageBox.Show("Funcionário menor de idade!", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdata.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtdata.Focus()
            Exit Sub


        End If

        'VALIDA CAMPOS DE ENDEREÇO1
        If objvalida.gfConsisteCampos(txtlograFunc, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtnumcasa, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        'VALIDA CEP DO FUNCIONÀRIO
        If IsNothing(txtCepFunc.Text) Or txtCepFunc.Text = " " Then
            MessageBox.Show("Digite o CEP do funcionário", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCepFunc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtCepFunc.Focus()

        End If

        'VALIDA CAMPOS DE ENDEREÇO2
        If objvalida.gfConsisteCampos(txtbairro, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtcidade, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub


        'VALIDA ESTADO
        If txtestado.SelectedIndex = 0 Or txtestado.Text = "---" Then
            MessageBox.Show("Digite o CEP do funcionário", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtestado.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtestado.Focus()
            Exit Sub
        Else
            txtestado.BackColor = Color.White
        End If


        'VALIDA TELEFONE1
        If txttipotel.SelectedIndex = 0 Then
            MessageBox.Show("Digite o tipo de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txttipotel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txttipotel.Focus()
            Exit Sub
        ElseIf txtnumtel.Text = "" Then
            MessageBox.Show("Digite um número de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnumtel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtnumtel.Focus()
            Exit Sub
        End If

        'VALIDA TELEFONE2
        'If txttipotel2.SelectedIndex = 0 Then
        '    MessageBox.Show("Digite o tipo de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txttipotel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        '    txttipotel.Focus()
        '    Exit Sub
        'ElseIf txtnumtel2.Text = "" Then
        '    MessageBox.Show("Digite um número de telefone", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtnumtel2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        '    txtnumtel2.Focus()
        '    Exit Sub
        'End If

        'VALIDA SE O TELEFONE ESTA DUPLICADO
        If txtnumtel.Text = txtnumtel2.Text Then
            MessageBox.Show("Telefones duplicados.", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnumtel2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtnumtel2.Focus()
            Exit Sub
        End If
        If objvalida.ValidEMail(txtemail.Text) = False Then
            MsgBox("Digite o e-mail corretamente!")
            Exit Sub
        End If



        If IsNothing(PicFotoFunc.ImageLocation) Then
            CaminhoFoto = ""
        Else
            CaminhoFoto = PicFotoFunc.ImageLocation
        End If

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandType = CommandType.Text
                .CommandText = "exec sp_AlteraFuncionario @Cod_Func = " & txtCodFunc.Text _
                    & ",  @Nome_Func = '" & txtNomeFunc.Text _
                    & "', @Sexo_Func = '" & sexo _
                    & "', @CPF_Func = '" & txtcpf.Text _
                    & "', @DataNasc_Func ='" & Format(CDate(txtdata.Text), "MM/dd/yyyy") _
                    & "', @RG_Func = '" & txtrg.Text _
                    & "', @Logradouro_Func = '" & txtlograFunc.Text _
                    & "', @NumCasa_Func = " & txtnumcasa.Text _
                    & ",  @Complemento_Func = '" & txtcompl.Text _
                    & "', @Bairro_Func = '" & txtbairro.Text _
                    & "', @Cidade_Func = '" & txtcidade.Text _
                    & "', @CEP_Func = '" & txtCepFunc.Text _
                    & "', @Estado_Func = '" & txtestado.Text _
                    & "', @Email = '" & txtemail.Text _
                    & "', @Cod_Cargo = " & txtcargo.SelectedIndex _
                    & ", @CaminhoFoto_Func = '" & CaminhoFoto & "'"
                .ExecuteNonQuery()
            End With
            Call alteratelefones(txtnumtel, Telefones_Func(1), txttipotel, 1)
            If txtnumtel2.Text <> Nothing Then
                Call alteratelefones(txtnumtel2, Telefones_Func(2), txttipotel2, 2)
            End If
            MessageBox.Show("Alterado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Sub alteratelefones(ByVal telefone As Control, ByVal referencia As String, ByVal tipoteltext As ComboBox, ByVal x As Short)
        Dim tipotel As Short
        If tipoteltext.SelectedIndex = 0 Then
            tipotel = 4
        ElseIf tipoteltext.SelectedIndex = 1 Then
            tipotel = 1
        ElseIf tipoteltext.SelectedIndex = 2 Then
            tipotel = 2
        ElseIf tipoteltext.SelectedIndex = 3 Then
            tipotel = 3
        ElseIf tipoteltext.SelectedIndex = 4 Then
            tipotel = 4
        End If
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "update TB_Tel_Func set Telefone = '" & telefone.Text & "'" _
                    & ", Cod_Tipo_Tel = " & tipotel _
                    & " where Cod_Tel_Func = " & CodTelefoneFunc(x)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCadastroFuncionario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNomeFunc.Focus()
        Call OrdemFoco()
        txtCodFunc.Text = cn.getIdentCurrent("TB_Funcionario") + 1
        listTel.Visible = False
        Call CarregaCargos()

    End Sub
    Sub CarregaCargos()
        txtcargo.Items.Clear()
        txtcargo.Items.Add("Selecione...")
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Nome_Cargo from TB_Cargo"
                .ExecuteNonQuery()
            End With
            Dim mr As SqlDataReader
            mr = cn.cmd.ExecuteReader
            While mr.Read
                txtcargo.Items.Add(mr!Nome_Cargo)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Private Sub txtsexoFunc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Call ValidaSexo()

    End Sub
    Public Sub LimparCampos()
        ObjControle.Limpar_tela(groupInfo)
        ObjControle.Limpar_tela(groupEnd)
        ObjControle.Limpar_tela(groupConFunc)
        txttipotel.Text = "Selecione..."
        txttipotel2.Text = "Selecione..."
        listTel.Visible = False
        txtnumtel.Enabled = True
        txttipotel.Enabled = True
        txtnumtel2.Enabled = True
        txttipotel2.Enabled = True
        txtemail.Enabled = True

    End Sub


    Private Sub txttipotel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttipotel.LostFocus
        Call ValidaTipoTel()
    End Sub

    Private Sub txttipotel2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttipotel2.LostFocus
        Call ValidaTipoTel2()
    End Sub


    Private Sub formatacpf(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 7 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 11 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub
    Private Sub formatarg(ByVal txttexto As Object)
        If Len(txttexto.text) = 2 Then
            txttexto.text = txttexto.text & "."
            txttexto.SelectionStart = Len(txttexto.Text) + 1
        ElseIf Len(txttexto.text) = 6 Then
            txttexto.text = txttexto.text & "."
            txttexto.SelectionStart = Len(txttexto.Text) + 1
        ElseIf Len(txttexto.text) = 10 Then
            txttexto.text = txttexto.text & "-"
            txttexto.SelectionStart = Len(txttexto.Text) + 1
        End If
    End Sub

    Private Sub txtcpf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcpf.KeyPress
        If IsNumeric(e.KeyChar) AndAlso txtcpf.TextLength < txtcpf.MaxLength Then
            txtcpf.Text &= e.KeyChar
            txtcpf.SelectionStart = txtcpf.TextLength
            Call formatacpf(txtcpf)
        End If
        e.Handled = True
        If e.KeyChar = Convert.ToChar(8) Then
            e.Handled = True
            txtcpf.Text = ""
        End If
    End Sub


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        For Each lstitem As ListViewItem In Me.listTel.Items
            lstitem.Remove()
        Next
        varAlter = False
        varCons = True
        Call LimparCampos()
        txtNomeFunc.Enabled = True
        txtCodFunc.Enabled = False
        txtcpf.Enabled = False
        txtrg.Enabled = False
        'txtHabFunc.Enabled = False
        txtsexofunc.Enabled = False
        txtcargo.Enabled = False
        txtdata.Enabled = False
        txtlograFunc.Enabled = False
        txtnumcasa.Enabled = False
        txtcompl.Enabled = False
        txtCepFunc.Enabled = False
        txtbairro.Enabled = False
        txtcidade.Enabled = False
        txtestado.Enabled = False
        txtnumtel.Enabled = False
        txttipotel.Enabled = False
        txtnumtel2.Enabled = False
        txttipotel2.Enabled = False
        txtemail.Enabled = False

    End Sub

    Private Sub txtNomeFunc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeFunc.LostFocus
        If varCons = True Then
            Call Consultar("Nome_Func", txtNomeFunc.Text)
        Else
            Exit Sub
        End If
    End Sub

    Public Sub Consultar(ByVal campo As String, ByVal value As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.FechaConexaoSejaAberta()
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Cod_func as 'Código do funcionário',Nome_Func as 'Nome completo'," _
                    & "TB_Cargo.Nome_Cargo as 'Cargo' from TB_Funcionario inner join TB_Cargo on" _
                    & " TB_Funcionario.Cod_Cargo = TB_Cargo.Cod_Cargo" _
                    & " where TB_Funcionario.Nome_Func like '%" & txtNomeFunc.Text & "%'"
                .CommandType = CommandType.Text
            End With

            frmConsultaFuncionario.Show()
            FormAbertoFunc = False
            da.SelectCommand = cn.cmd
            da.Fill(dt)
            da.Dispose()       '  libera recursos ou melhora a performance  
            frmConsultaFuncionario.DataGrid.DataSource = dt        ' dt1 name do datagrid
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCapturarFoto.Show()
        form = "frmFuncionario"
        CodFoto = txtCodFunc.Text
    End Sub

    Private Sub btnUploadFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadFoto.Click
        OpenFileDialog1.Filter = "Arquivos de imagem|*.jpg; *.bmp; *.gif;|Todos os Arquivos|*.*"
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\fotos\"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PicFotoFunc.Image = Image.FromFile(OpenFileDialog1.FileName)
            PicFotoFunc.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Call LimparCampos()
        txtCodFunc.Text = cn.getIdentCurrent("TB_Funcionario") + 1
        varCons = False
        txtNomeFunc.Enabled = True
        txtCodFunc.Enabled = False
        txtcpf.Enabled = True
        txtrg.Enabled = True
        'txtHabFunc.Enabled = True
        txtsexofunc.Enabled = True
        txtcargo.Enabled = True
        txtdata.Enabled = True
        txtlograFunc.Enabled = True
        txtnumcasa.Enabled = True
        txtcompl.Enabled = True
        txtCepFunc.Enabled = True
        txtbairro.Enabled = True
        txtcidade.Enabled = True
        txtestado.Enabled = True
        txtnumtel.Enabled = True
        txttipotel.Enabled = True
        txtnumtel2.Enabled = True
        txttipotel2.Enabled = True
        txtemail.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Call ativacampos()
        varAlter = True
        varCons = False
        txttipotel.Visible = True
        txttipotel2.Visible = True
        txtnumtel.Visible = True
        txtnumtel2.Visible = True
        txtcpf.Enabled = False
        txtrg.Enabled = False
        listTel.Visible = False
        txttipotel.Text = Tipo_Telefones_Func(0)
        txttipotel2.Text = Tipo_Telefones_Func(1)
        If Len(Telefones_Func(0)) = 14 Then
            txtnumtel.Mask = "(00)00000-0000"
        End If
        If Len(Telefones_Func(1)) = 14 Then
            txtnumtel2.Mask = "(00)00000-0000"
        End If
        txtnumtel.Text = Telefones_Func(0)
        txtnumtel2.Text = Telefones_Func(1)

    End Sub
    Sub ativacampos()
        txtNomeFunc.Enabled = True
        txtCodFunc.Enabled = False
        txtcpf.Enabled = True
        txtrg.Enabled = True
        'txtHabFunc.Enabled = True
        txtsexofunc.Enabled = True
        txtcargo.Enabled = True
        txtdata.Enabled = True
        txtlograFunc.Enabled = True
        txtnumcasa.Enabled = True
        txtcompl.Enabled = True
        txtCepFunc.Enabled = True
        txtbairro.Enabled = True
        txtcidade.Enabled = True
        txtestado.Enabled = True
        txtnumtel.Enabled = True
        txttipotel.Enabled = True
        txtnumtel2.Enabled = True
        txttipotel2.Enabled = True
        txtemail.Enabled = True
    End Sub

    Private Sub groupInfo_Enter(sender As System.Object, e As System.EventArgs) Handles groupInfo.Enter

    End Sub

    Private Sub txtcargo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtcargo.SelectedIndexChanged

    End Sub
End Class