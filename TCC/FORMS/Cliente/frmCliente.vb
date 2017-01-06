Imports System.Data.SqlClient
Public Class frmCliente
    Dim VarCons As Boolean = False
    Dim varAltera As Boolean = False
    Dim cn As New conexaosql
    Dim querycadastro As String
    Dim mr As SqlClient.SqlDataReader
    Dim testar As Integer
    Dim objcliente As New ClsCliente
    Dim ObjValida As New clnValidaControles
    Dim ObjControle As New ClsComando
    Public sexo As String
    Public codtelcli As Integer = 0
    Public strcodtelcli As String = Nothing
    Dim NextCodCli As Short
    Dim PrevCodCLi As String
    Public Sub UploadFoto()
        OpenFileDialog1.Filter = "Arquivos de imagem|*.jpg; *.bmp; *.gif;|Todos os Arquivos|*.*"
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\fotos\"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Caminho = OpenFileDialog1.FileName.Trim.ToString
            'testar = 2
        End If
    End Sub

    Public Sub OrdemFoco()
        txtnomecli.TabIndex = 1
        txtcpfcli.TabIndex = 2
        txtrgcli.TabIndex = 3
        txtnaccli.TabIndex = 4
        txtsexocli.TabIndex = 5
        txtcathabcli.TabIndex = 6
        txtlogracli.TabIndex = 7
        txtnumcasa.TabIndex = 8
        txtcompl.TabIndex = 9
        txtcepcli.TabIndex = 10
        txtbairro.TabIndex = 11
        txtcidade.TabIndex = 12
        txtestado.TabIndex = 13
        txttipotel.TabIndex = 14
        txtnumtel.TabIndex = 15
        txttipotel2.TabIndex = 16
        txtnumtel2.TabIndex = 17
        txtformatrat.TabIndex = 18
        txtemail.TabIndex = 19

    End Sub

    Public Sub AlteraDados()
        sexo = ""
        If txtsexocli.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o sexo do cliente", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsexocli.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtsexocli.Focus()
            Exit Sub
        ElseIf txtsexocli.SelectedIndex = 1 Then
            sexo = "M"
            txtsexocli.BackColor = System.Drawing.Color.White
        ElseIf txtsexocli.SelectedIndex = 2 Then
            sexo = "F"
            txtsexocli.BackColor = System.Drawing.Color.White
        End If

        If ObjValida.gfConsisteCampos(txthabcli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtlogracli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtnumcasa, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtnumcasa, clnValidaControles.OpcaoConsiste.VerNumerico) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcompl, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcepcli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcepcli, clnValidaControles.OpcaoConsiste.verCep) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtbairro, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcidade, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtestado, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.ValidEMail(txtemail.Text) = False Then Exit Sub
        Dim cn As New conexaosql
        cn.FechaConexaoSejaAberta()

        cn.conexaoon()
        Try
            With cn.cmd
                .Connection = cn.cnn
                '@Cod_Cli int, @NomeCompleto_Cli varchar(50),@Sexo_Cli char(1),@DataNasc_Cli date ,@RG_Cli char(12)  ,@Habilitacao char(11)  , @Cat_CNH varchar(3),@Nacionalidade_Cli varchar(30),
                '@Logradouro_Cli varchar(45),@NumCasa_Cli int,@Complemento_Cli char(15),@Bairro_Cli varchar(30)  ,@Cidade_Cli varchar(30)  ,  @Estado_Cli char(2)  ,@CEP_Cli char(8),@Email varchar(45),
                '@CaminhoFotoCli varchar(60)
                .CommandType = CommandType.Text
                .CommandText = "exec sp_AlteraCli @Cod_Cli = " _
                    & txtcodcli.Text & ", @NomeCompleto_Cli = '" _
                    & txtnomecli.Text & "', @Sexo_Cli ='" _
                    & sexo & "', @DataNasc_Cli = '" _
                    & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "',@RG_Cli ='" _
                    & txtrgcli.Text & "', @Habilitacao ='" _
                    & txthabcli.Text & "', @Cat_CNH ='" _
                    & txtcathabcli.Text & "', @Nacionalidade_Cli ='" _
                    & txtnaccli.Text & "', @Logradouro_Cli ='" _
                    & txtlogracli.Text & "', @NumCasa_Cli = " _
                    & txtnumcasa.Text & ", @Complemento_Cli ='" _
                    & txtcompl.Text & "', @Bairro_Cli  = '" _
                    & txtbairro.Text & "', @Cidade_Cli = '" _
                    & txtcidade.Text & "', @Estado_Cli = '" _
                    & txtestado.Text & "', @CEP_Cli = '" _
                    & txtcepcli.Text & "', @Email = '" _
                    & txtemail.Text & "', @CaminhoFotoCli = '" _
                    & Caminho & "'"
                .ExecuteNonQuery()
            End With
            Call alteratelefones(txtnumtel, Telefones(1), txttipotel, 1)
            If txtnumtel2.Text <> Telefones(2) Then
                Call alteratelefones(txtnumtel2, Telefones(2), txttipotel2, 2)
            End If
            MessageBox.Show("Alterado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.cmd.Parameters.Clear()
            cn.FechaConexaoSejaAberta()
            Call DesativaCampos()
        End Try

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
            cn.cmd.Dispose()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "update TB_TelCli set Telefone = '" & telefone.Text & "'" _
                    & ", Cod_Tipo_Tel = " & tipotel _
                    & " where Cod_Tel_Cli = " & CodTelefoneCli(x)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrava.Click
        If varAltera = True Then
            Call AlteraDados()
        Else : varAltera = False
            Call Cadastrar()
        End If

    End Sub
    
    Public Sub Cadastrar()

        ' CONSISTENCIA DOS CAMPOS 

        If ObjValida.gfConsisteCampos(txtnomecli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        ' VALIDA CPF
        If txtcpfcli.TextLength <> 14 Then
            MessageBox.Show("CPF digitado está inválido!", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcpfcli.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtcpfcli.Focus()
            Exit Sub
        Else
            txtcpfcli.BackColor = Color.White
        End If
        If ObjControle.ValidaSeJaExiste(txtcpfcli, "CPF_Cli", "TB_Cliente") = True Then Exit Sub
        If ObjValida.gfConsisteCampos(txtrgcli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjControle.ValidaSeJaExiste(txtrgcli, "RG_Cli", "TB_Cliente") = True Then Exit Sub
        If ObjValida.gfConsisteCampos(txtrgcli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        If txthabcli.TextLength <> 11 Then
            MessageBox.Show("Habilitação digitada está inválida!", "Habilitação inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txthabcli.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txthabcli.Focus()
            Exit Sub
        End If

        If DateDiff("YYYY", DateTimePicker1.Text, Now) < 21 Then
            MessageBox.Show("Cliente não possui mais que 21 anos", "Não é possível cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DateTimePicker1.Focus()
            DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        End If


        sexo = ""
        If txtsexocli.SelectedIndex = 0 Then
            MessageBox.Show("Selecione o sexo do cliente", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsexocli.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtsexocli.Focus()
            Exit Sub
        ElseIf txtsexocli.SelectedIndex = 1 Then
            sexo = "M"
            txtsexocli.BackColor = System.Drawing.Color.White

        ElseIf txtsexocli.SelectedIndex = 2 Then
            sexo = "F"
            txtsexocli.BackColor = System.Drawing.Color.White
        End If
        If ObjValida.gfConsisteCampos(txtrgcli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

        If txtnaccli.SelectedIndex = 0 Then
            MessageBox.Show("Selecione a nacionalidade do cliente", "Dados Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnaccli.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtsexocli.Focus()
            Exit Sub
        End If

        If ObjValida.gfConsisteCampos(txthabcli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtlogracli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtnumcasa, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtnumcasa, clnValidaControles.OpcaoConsiste.VerNumerico) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcompl, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcepcli, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcepcli, clnValidaControles.OpcaoConsiste.verCep) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtbairro, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.gfConsisteCampos(txtcidade, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If ObjValida.ValidEMail(txtemail.Text) = False Then
            MsgBox("O Campo Email deve ser Preenchido corretamento!", MsgBoxStyle.Information, "Dados faltantes ou inválidos")

            Exit Sub
        End If

        If txtestado.SelectedIndex = -1 Then
            MsgBox("O Campo " & txtestado.Tag & " deve ser Preenchido!!!", MsgBoxStyle.Information, "Dados faltantes ou inválidos")
            'Altera a cor de fundo para amarelo
            txtestado.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            txtestado.Focus()
            Exit Sub
        End If

        If ObjValida.gfConsisteCampos(txtestado, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If txtnumtel.Text = txtnumtel2.Text Then
            MessageBox.Show("Telefones duplicados.", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnumtel2.Focus()

        End If

        'ATRIBUICAO DE VALORES AS PROPERTIES
        objcliente.Nome_cli = txtnomecli.Text
        objcliente.Sexo_Cli = sexo
        objcliente.DataNasc_Cli = Format(DateTimePicker1.Value, "MM/dd/yyyy")
        objcliente.CPF_cli = txtcpfcli.Text
        objcliente.RG_cli = txtrgcli.Text
        objcliente.CNH_Cli = txthabcli.Text
        objcliente.Cat_CNH_Cli = txtcathabcli.Text
        objcliente.Nac_Cli = txtnaccli.Text
        objcliente.Logra_Cli = txtlogracli.Text
        objcliente.NumCasa_Cli = txtnumcasa.Text
        objcliente.Compl_Cli = txtcompl.Text
        objcliente.Bairro_Cli = txtbairro.Text
        objcliente.Cidade_Cli = txtcidade.Text
        objcliente.Estado_cli = txtestado.Text
        objcliente.CEP_Cli = txtcepcli.Text
        objcliente.CaminhoFotoCli = Caminho

        If txtemail.Text = Nothing Then
            objcliente.Email_Cli = " "
        Else
            objcliente.Email_Cli = txtemail.Text
        End If
        objcliente.InserirCliente()
        Call InsereTelefoneCLi()
        MessageBox.Show("Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub


  
    Public Sub InsereTelefoneCLi()

        If ObjValida.gfConsisteCampos(txtnumtel, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub

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

        Dim formatrat As String = Nothing

        If txtformatrat.SelectedIndex = 0 Then
            formatrat = "Sr."
        ElseIf txtformatrat.SelectedIndex = 1 Then
            formatrat = "Sr."
        ElseIf txtformatrat.SelectedIndex = 2 Then
            formatrat = "Sra."

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
        '(@Cod_Cli,@Telefone,@Email,@Forma_Tratamento,@Cod_Tipo_Tel)
        objcliente.Cod_Cli = NextCodCli
        objcliente.Telefone1_Cli = txtnumtel.Text
        objcliente.Telefone2_Cli = txtnumtel2.Text
        objcliente.FormaTrat_cli = formatrat
        objcliente.CodTipoTel_Cli = tipotel
        objcliente.CodTipoTel2_Cli = tipotel2


        objcliente.InserirTelefone()
    End Sub
    Private Sub frmCadastroCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OrdemFoco()
        txtcodcli.Text = cn.getIdentCurrent("TB_Cliente") + 1
        txtnomecli.Focus()
        listTel.Visible = False
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        frmCapturarFoto.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTirar.Click
        frmCapturarFoto.Show()
        form = Me.Name
        CodFoto = txtcodcli.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Call UploadFoto()

    End Sub

    Public Sub LimparCampos()
        ObjControle.Limpar_tela(groupInfo)
        ObjControle.Limpar_tela(groupEnd)
        ObjControle.Limpar_tela(groupConCli)
        txtnaccli.Text = "Selecione..."
        txttipotel.Text = "Selecione..."
        txttipotel2.Text = "Selecione..."
        txtformatrat.Text = "Selecione..."
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        VarCons = False
        varAltera = False
        btngrava.Enabled = True
        txttipotel.Visible = True
        txttipotel2.Visible = True
        txtnumtel.Visible = True
        txtnumtel2.Visible = True
        listTel.Visible = False
        Call LimparCampos()
        txtcodcli.Text = cn.getIdentCurrent("TB_Cliente") + 1
        Call AtivaCampos()
        listTel.Items.Clear()

        listTel.Visible = False


    End Sub

    Private Sub txttipotel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttipotel.LostFocus
        If txttipotel.SelectedIndex = 2 Then
            txtnumtel.Mask = "(00)00000-0000"
        Else
            txtnumtel.Mask = "(00)0000-0000"
        End If
    End Sub

    Private Sub txttipotel2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttipotel2.LostFocus
        If txttipotel2.SelectedIndex = 2 Then
            txtnumtel2.Mask = "(00)00000-0000"
        Else
            txtnumtel2.Mask = "(00)0000-0000"
        End If
    End Sub
    Private Sub txtcpfcli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcpfcli.KeyPress
        If IsNumeric(e.KeyChar) AndAlso txtcpfcli.TextLength < txtcpfcli.MaxLength Then
            txtcpfcli.Text &= e.KeyChar
            txtcpfcli.SelectionStart = txtcpfcli.TextLength
            Call formatacpf(txtcpfcli)
        End If
        e.Handled = True
        If e.KeyChar = Convert.ToChar(8) Then
            e.Handled = True
            txtcpfcli.Text = ""

        End If
    End Sub
    Private Sub txtRG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If txtrgcli.TextLength < txtrgcli.MaxLength Then
            txtrgcli.Text &= e.KeyChar
            txtrgcli.SelectionStart = txtrgcli.TextLength
            Call formatarg(txtrgcli)
        End If
        e.Handled = True
        If e.KeyChar = Convert.ToChar(8) Then
            e.Handled = True
            txtrgcli.Text = ""
        End If
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


    Private Sub txtnomecli_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnomecli.LostFocus
        If VarCons = True Then
            Call Consultar("NomeCompleto_Cli", txtnomecli.Text)
        Else
            Exit Sub
        End If
    End Sub

    Public Sub Consultar(ByVal campo As String, ByVal value As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()

            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Cod_Cli as 'Código do cliente',NomeCompleto_Cli as 'Nome completo',CPF_Cli as 'CPF' ,Habilitacao from TB_Cliente where NomeCompleto_Cli like '%" & value & "%'"
                .CommandType = CommandType.Text
            End With

            FrmConsultaCliente.Show()
            FormAberto = False
            da.SelectCommand = cn.cmd
            da.Fill(dt)
            da.Dispose()       '  libera recursos ou melhora a performance  
            FrmConsultaCliente.DataGrid.DataSource = dt        ' dt1 name do datagrid
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisa.Click
        Call LimparCampos()
        VarCons = True
        TipoConsulta = "Cliente"
        Call DesativaCampos()
        btngrava.Enabled = False
        ObjControle.backgroundCampo(txtnomecli)
        PictureBox1.Enabled = False


    End Sub
    Public Sub AtivaCampos()
        txtcodcli.Enabled = False
        txtsexocli.Enabled = True
        txtnaccli.Enabled = True
        txthabcli.Enabled = True
        DateTimePicker1.Enabled = True
        txtcathabcli.Enabled = True
        txtlogracli.Enabled = True
        txtnumcasa.Enabled = True
        txtcompl.Enabled = True
        txtbairro.Enabled = True
        txtcidade.Enabled = True
        txtestado.Enabled = True
        txtcepcli.Enabled = True
        txttipotel.Enabled = True
        txttipotel2.Enabled = True
        txtnumtel.Enabled = True
        txtnumtel2.Enabled = True
        txtformatrat.Enabled = True
        txtemail.Enabled = True
        txtcpfcli.Enabled = True
        txtrgcli.Enabled = True


    End Sub
    Public Sub DesativaCampos()
        txtcodcli.Enabled = False
        txtsexocli.Enabled = False
        txtnaccli.Enabled = False
        txthabcli.Enabled = False
        DateTimePicker1.Enabled = False
        txtcathabcli.Enabled = False
        txtlogracli.Enabled = False
        txtnumcasa.Enabled = False
        txtcompl.Enabled = False
        txtbairro.Enabled = False
        txtcidade.Enabled = False
        txtestado.Enabled = False
        txtcepcli.Enabled = False
        txttipotel.Enabled = False
        txttipotel2.Enabled = False
        txtnumtel.Enabled = False
        txtnumtel2.Enabled = False
        txtformatrat.Enabled = False
        txtemail.Enabled = False
        txtcpfcli.Enabled = False
        txtrgcli.Enabled = False

    End Sub


    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltera.Click
        VarCons = False

        varAltera = True
        Call AtivaCampos()
        txtcodcli.Enabled = False
        btngrava.Enabled = True
        txtcpfcli.Enabled = False
        txtrgcli.Enabled = False
        txttipotel.Visible = True
        txttipotel2.Visible = True
        txtnumtel.Visible = True
        txtnumtel2.Visible = True
        listTel.Visible = False
        txttipotel.Text = Tipo_Telefones(0)
        txttipotel2.Text = Tipo_Telefones(1)
        If Len(Telefones(0)) = 14 Then
            txtnumtel.Mask = "(00)00000-0000"
        End If
        If Len(Telefones(1)) = 14 Then
            txtnumtel2.Mask = "(00)00000-0000"
        End If
        txtnumtel.Text = Telefones(0)
        txtnumtel2.Text = Telefones(1)

    End Sub

    'Private Sub RdInativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If RdInativo.Checked = True Then
    '        Call DesativaCampos()
    '        btnAltera.Enabled = False
    '        btngrava.Enabled = False
    '    ElseIf RdAtivo.Checked = True Then
    '        MessageBox.Show("Deseja realmente alterar o status?", "Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        If Windows.Forms.DialogResult.Yes Then
    '            Call AtivaCampos()
    '            btnAltera.Enabled = True
    '            btngrava.Enabled = True

    '        Else
    '            Exit Sub
    '        End If
    '    End If
    'End Sub



    Private Sub txtrgcli_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class