Imports System.Data.SqlClient

Public Class frmCarro
    Dim VarCons, VarAlter As Boolean
    Dim objvalida As New clnValidaControles
    Dim cn As New conexaosql
    Dim objcontrole As New ClsComando
    Dim objCarro As New ClsCarro
    Dim CaminhoFoto As String
    Dim SitCarro As Short
    Dim StatusCarro As Short
    Dim TipoCombus As Short

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If VarAlter = False Then
            Call inserir()
        ElseIf VarAlter = True Then
            atualizaCarro()
        End If
    End Sub
    'Public Sub CarregaCodCarro()
    '    txtcodcarro.Enabled = False

    '    Dim mr As System.Data.SqlClient.SqlDataReader

    '    Try
    '        cn.cnn.Open()
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandText = "select MAX(Cod_Carro) as 'UltCod' from TB_Carro"
    '            .ExecuteNonQuery()
    '        End With
    '        mr = cn.cmd.ExecuteReader
    '        mr.Read()
    '        If IsDBNull(mr!UltCod) Then
    '            nextcodcarro = 1
    '        Else
    '            prevcodcarro = mr!UltCod
    '            nextcodcarro = prevcodcarro + 1
    '        End If
    '        txtcodcarro.Text = nextcodcarro
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    cn.cnn.Close()
    'End Sub
    Public Sub DefineSitCarro()
        If rbDisp.Checked = True Then
            SitCarro = 1
        ElseIf rbAlugado.Checked = True Then
            SitCarro = 2
        ElseIf rbManu.Checked = True Then
            SitCarro = 3
        ElseIf rbBloqueado.Checked = True Then
            SitCarro = 4
        ElseIf rbPrep.Checked = True Then
            SitCarro = 5
        ElseIf rbRoubado.Checked = True Then
            SitCarro = 6
        ElseIf rbAVenda.Checked = True Then
            SitCarro = 7
        ElseIf rbVend.Checked = True Then
            SitCarro = 8
        ElseIf rbReserv.Checked = True Then
            SitCarro = 9
        End If
    End Sub
    Public Sub DefineStatusCarro()
        If rbAtivo.Checked = True Then
            StatusCarro = 0
        ElseIf rbInativo.Checked = True Then
            StatusCarro = 1
        End If
    End Sub
   
   

    Public Sub inserir()
        cn.FechaConexaoSejaAberta()
        ' realiza todas validações
        If objvalida.gfConsisteCampos(txtplaca, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtmodelo, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtCor, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txttipocombus, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        'If objvalida.gfConsisteCampos(txtcatcarro, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtano, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtmarca, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        'If objvalida.gfConsisteCampos(txtdatafabr, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtrenavam, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        If objvalida.gfConsisteCampos(txtchassi, clnValidaControles.OpcaoConsiste.VerNulo) = False Then Exit Sub
        'valida placa
        If VarCons = False Then
            If ValidaSeJaExiste("Placa", txtplaca) = True Then Exit Sub
        Else
            txtplaca.BackColor = Color.White
        End If

        'valida chassi
        If IsNumeric(txtchassi.Text) Then
            If ValidaSeJaExiste("Chassi", txtchassi) = True Then Exit Sub

        ElseIf Not IsNumeric(txtchassi.Text) Then
            MessageBox.Show("Digite apenas números", "Chassi inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchassi.Focus()
            txtchassi.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        End If


        'valida renavam
        If IsNumeric(txtrenavam.Text) Then
            If ValidaSeJaExiste("Renavam", txtrenavam) = True Then Exit Sub
        ElseIf Not IsNumeric(txtrenavam.Text) Then
            MessageBox.Show("Digite apenas números", "RENAVAM inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtrenavam.Focus()
            txtrenavam.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
            Exit Sub
        End If

        Call DefineSitCarro()
        Call DefineStatusCarro()
        objCarro.Categoria_Carro = lstCategoria.SelectedIndex + 1
        objCarro.Placa_Carro = txtplaca.Text
        objCarro.Modelo_Carro = txtmodelo.Text
        objCarro.Cor_Carro = txtCor.Text
        objCarro.Marca_Carro = txtmarca.Text
        objCarro.DataFabri_Carro = Format(txtdatafabr.Value, "MM/dd/yyyy")
        objCarro.Combustivel_Carro = TipoCombus
        objCarro.Renavam_Carro = txtrenavam.Text
        objCarro.Chassi_Carro = txtchassi.Text
        objCarro.Ano_Carro = txtano.Text
        objCarro.Situacao_Carro = SitCarro
        objCarro.Status_Carro = StatusCarro
        objCarro.Imagem_Carro = CaminhoFoto
        objCarro.inserir()
        CodCarroHist = txtcodcarro.Text
        Call InsereOsAcessoriosDoCarro()


    End Sub

    Private Sub frmCadastroCarro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtcodcarro.Clear()
        txtcodcarro.Text = cn.getIdentCurrent("TB_Carro") + 1
        txtcodcarro.Enabled = False
        rbAtivo.Checked = True
        Call CarregaCategorias()
        txtcodcarro.TabIndex = 0
        txtplaca.TabIndex = 1
        txtmodelo.TabIndex = 2
        txtCor.TabIndex = 3
        txttipocombus.TabIndex = 4
        lstCategoria.TabIndex = 5
        txtano.TabIndex = 6
        txtmarca.TabIndex = 7
        txtdatafabr.TabIndex = 8
        txtrenavam.TabIndex = 9
        txtchassi.TabIndex = 10
        rbDisp.TabIndex = 11
        rbManu.TabIndex = 12
        rbPrep.TabIndex = 13
        rbAlugado.TabIndex = 14
        rbBloqueado.TabIndex = 15
        rbBloqueado.TabIndex = 16
        rbRoubado.TabIndex = 17
        rbAVenda.TabIndex = 18
        rbVend.TabIndex = 19
        rbReserv.TabIndex = 20
        ListBox1.TabIndex = 21
        rbInativo.TabIndex = 21
        Button1.TabIndex = 22



    End Sub
    Public Sub CarregaCategorias() 'Carrega categorias disponíveis em listCategorias
        Dim mr As SqlDataReader
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Cod_Cat,Nome_Cat from TB_Categoria"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) Then
                cn.cnn.Close()
                Exit Sub
            Else
                For Each DataRow In mr
                    lstCategoria.Items.Add(mr!Nome_Cat)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        lstCategoria.SelectedIndex = 0

    End Sub

    Private Sub InsereOsAcessoriosDoCarro()
        cn.FechaConexaoSejaAberta()
        Dim x As Integer
        Dim s As String = ""
        For x = 0 To ListBox1.Items.Count - 1

            If ListBox1.Items(x).ToString = "Ar condicionado" Then
                objCarro.InserirAcessoriosCarro(1)

            ElseIf ListBox1.Items(x).ToString = "Roda Liga Leve" Then
                objCarro.InserirAcessoriosCarro(2)

            ElseIf ListBox1.Items(x).ToString = "Basico" Then
                objCarro.InserirAcessoriosCarro(3)

            ElseIf ListBox1.Items(x).ToString = "Teto Solar" Then
                objCarro.InserirAcessoriosCarro(4)

            ElseIf ListBox1.Items(x).ToString = "Tração 4x4" Then
                objCarro.InserirAcessoriosCarro(5)

            ElseIf ListBox1.Items(x).ToString = "Banco de Couro" Then
                objCarro.InserirAcessoriosCarro(6)

            ElseIf ListBox1.Items(x).ToString = "CD Player" Then
                objCarro.InserirAcessoriosCarro(7)

            ElseIf ListBox1.Items(x).ToString = "DVD Player" Then
                objCarro.InserirAcessoriosCarro(8)

            ElseIf ListBox1.Items(x).ToString = "Som adicional" Then
                objCarro.InserirAcessoriosCarro(9)

            ElseIf ListBox1.Items(x).ToString = "Freio ABS" Then
                objCarro.InserirAcessoriosCarro(10)

            ElseIf ListBox1.Items(x).ToString = "GPS" Then
                objCarro.InserirAcessoriosCarro(11)

            ElseIf ListBox1.Items(x).ToString = "AirBags" Then
                objCarro.InserirAcessoriosCarro(12)
            End If
        Next x
        MessageBox.Show("Registre o primeiro histórico do carro", "Histórico", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If Windows.Forms.DialogResult.OK Then
            frmHistoricoCarro.txtcodcarro.Text = Me.txtcodcarro.Text
            frmHistoricoCarro.txtcodcarro.Enabled = False
            frmHistoricoCarro.txtcodaluguel.Enabled = False
            frmHistoricoCarro.Show()
        End If
    End Sub
    Public Function ValidaSeJaExiste(ByVal campo As String, ByVal controle As Control)
        cn.FechaConexaoSejaAberta()
        If IsNothing(controle.Text) = True Or controle.Text = " " Then
            Return False
        End If
        Dim mr As System.Data.SqlClient.SqlDataReader
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select " & campo & " as 'Campo' from TB_Carro"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            'mr.Read()
            While mr.Read
                If controle.Text = mr!Campo Then
                    MessageBox.Show("O valor inserido já existe!", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    controle.Focus()
                    controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                    cn.cnn.Close()
                    Return True
                Else
                    controle.BackColor = Color.White
                    'Return False
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return False
        cn.cnn.Close()

    End Function


  


    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        objcontrole.Limpar_tela(groupInfo)
        ListBox1.Items.Clear()
        VarCons = False
        Call ativacampos()
        txtcodcarro.Clear()
        txtcodcarro.Text = cn.getIdentCurrent("TB_Carro") + 1
        txtcodcarro.Enabled = False


    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        Call DesativaCampos()
        VarCons = True
        txtplaca.Enabled = True
    End Sub

    Public Sub ConsultarCarro(ByVal campo As String, ByVal controle As Control)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.FechaConexaoSejaAberta()
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "Select * from TB_Carro where " & campo & " like '%" & controle.Text & "%'"
                .ExecuteNonQuery()
            End With
            FrmConsultaCarro.Show()
            da.SelectCommand = cn.cmd
            da.Fill(dt)
            da.Dispose()       '  libera recursos ou melhora a performance  
            FrmConsultaCarro.DataGridCarro.DataSource = dt        ' dt1 name do datagrid
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
    Private Sub DesativaCampos()
        txtcodcarro.Enabled = False
        txtmodelo.Enabled = False
        txtCor.Enabled = False
        txttipocombus.Enabled = False
        lstCategoria.Enabled = False
        txtano.Enabled = False
        txtmarca.Enabled = False
        txtdatafabr.Enabled = False
        txtrenavam.Enabled = False
        txtchassi.Enabled = False
        ListBox1.Enabled = False

    End Sub
    Public Sub ativacampos()
        txtmodelo.Enabled = True
        txtCor.Enabled = True
        txttipocombus.Enabled = True
        lstCategoria.Enabled = True
        txtano.Enabled = True
        txtmarca.Enabled = True
        txtdatafabr.Enabled = True
        txtrenavam.Enabled = True
        txtchassi.Enabled = True
        ListBox1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub


    Private Sub txttipocombus_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttipocombus.LostFocus
        Select Case txttipocombus.SelectedIndex
            Case 0
                MessageBox.Show("Selecione o tipo do combustível!", "Dados faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case 1
                TipoCombus = 1
            Case 2
                TipoCombus = 2
            Case 3
                TipoCombus = 3
            Case 4
                TipoCombus = 4
            Case 5
                TipoCombus = 5
        End Select

    End Sub

    
    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If VarCons = True Then
            objCarro.ConsultaHistorico(txtcodcarro.Text)
            frmHistoricoCarro.Show()
        Else
            frmHistoricoCarro.Show()
        End If
    End Sub

    Private Sub txtplaca_LostFocus(sender As Object, e As System.EventArgs) Handles txtplaca.LostFocus
        If VarCons = True Then
            Call ConsultarCarro("Placa", txtplaca)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Arquivos de imagem|*.jpg; *.bmp; *.gif;|Todos os Arquivos|*.*"
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\fotos\"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            picCarro.Image = Image.FromFile(OpenFileDialog1.FileName)
            CaminhoFoto = OpenFileDialog1.FileName
            'testar = 2
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        VarAlter = True
        txtplaca.Enabled = False
        txtCor.Enabled = True
        lstCategoria.Enabled = True
        groupSitu.Enabled = True

        GroupBox1.Enabled = True
    End Sub
    Sub atualizaCarro()
        Call DefineSitCarro()
        Call DefineStatusCarro()

        cn.FechaConexaoSejaAberta()
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "update TB_Carro set Cor = '" & txtCor.Text _
                                & "', cod_cat = " & lstCategoria.SelectedIndex + 1 _
                                & ", Cod_Situacao = " & SitCarro _
                                & ", Status_Carro = " & StatusCarro _
                                & ", Caminho_Foto = '" & CaminhoFoto & "' where Cod_Carro = " & txtcodcarro.Text
                .ExecuteNonQuery()
                MessageBox.Show("Alterado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
            ' Call InsereOsAcessoriosDoCarro()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub lstCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstCategoria.SelectedIndexChanged
        '   Call objCarro.CarregaAcessoriosDacategoria(lstCategoria.SelectedIndex + 1, False)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        varForm = False
        frmConsultaAcessoriosCategoria.Show()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class