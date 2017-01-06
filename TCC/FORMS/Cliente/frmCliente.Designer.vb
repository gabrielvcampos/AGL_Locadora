<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAltera = New System.Windows.Forms.ToolStripButton()
        Me.btngrava = New System.Windows.Forms.ToolStripButton()
        Me.btnPesquisa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupInfo = New System.Windows.Forms.GroupBox()
        Me.txtcpfcli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnaccli = New System.Windows.Forms.ComboBox()
        Me.btnTirar = New System.Windows.Forms.Button()
        Me.txthabcli = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtsexocli = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcathabcli = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.txtnomecli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.groupEnd = New System.Windows.Forms.GroupBox()
        Me.txtestado = New System.Windows.Forms.ComboBox()
        Me.txtcidade = New System.Windows.Forms.TextBox()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.txtcepcli = New System.Windows.Forms.MaskedTextBox()
        Me.txtcompl = New System.Windows.Forms.TextBox()
        Me.txtnumcasa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtlogracli = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtnumtel = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttipotel2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnumtel2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txttipotel = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.groupConCli = New System.Windows.Forms.GroupBox()
        Me.listTel = New System.Windows.Forms.ListView()
        Me.Numero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtformatrat = New System.Windows.Forms.ComboBox()
        Me.picAGL = New System.Windows.Forms.PictureBox()
        Me.txtrgcli = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.groupInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupEnd.SuspendLayout()
        Me.groupConCli.SuspendLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.ToolStripSeparator1, Me.btnAltera, Me.btngrava, Me.btnPesquisa, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(232, 55)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNovo
        '
        Me.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(52, 52)
        Me.btnNovo.Text = "ToolStripButton5"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'btnAltera
        '
        Me.btnAltera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAltera.Image = CType(resources.GetObject("btnAltera.Image"), System.Drawing.Image)
        Me.btnAltera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAltera.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAltera.Name = "btnAltera"
        Me.btnAltera.Size = New System.Drawing.Size(52, 52)
        Me.btnAltera.Text = "ToolStripButton3"
        '
        'btngrava
        '
        Me.btngrava.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btngrava.Image = CType(resources.GetObject("btngrava.Image"), System.Drawing.Image)
        Me.btngrava.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btngrava.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btngrava.Name = "btngrava"
        Me.btngrava.Size = New System.Drawing.Size(52, 52)
        Me.btngrava.Text = "ToolStripButton1"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), System.Drawing.Image)
        Me.btnPesquisa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(52, 52)
        Me.btnPesquisa.Text = "ToolStripButton4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'groupInfo
        '
        Me.groupInfo.BackColor = System.Drawing.Color.Transparent
        Me.groupInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupInfo.Controls.Add(Me.txtrgcli)
        Me.groupInfo.Controls.Add(Me.txtcpfcli)
        Me.groupInfo.Controls.Add(Me.Label4)
        Me.groupInfo.Controls.Add(Me.txtnaccli)
        Me.groupInfo.Controls.Add(Me.btnTirar)
        Me.groupInfo.Controls.Add(Me.txthabcli)
        Me.groupInfo.Controls.Add(Me.DateTimePicker1)
        Me.groupInfo.Controls.Add(Me.btnUpload)
        Me.groupInfo.Controls.Add(Me.PictureBox1)
        Me.groupInfo.Controls.Add(Me.Label24)
        Me.groupInfo.Controls.Add(Me.txtsexocli)
        Me.groupInfo.Controls.Add(Me.Label5)
        Me.groupInfo.Controls.Add(Me.Label12)
        Me.groupInfo.Controls.Add(Me.txtcathabcli)
        Me.groupInfo.Controls.Add(Me.Label7)
        Me.groupInfo.Controls.Add(Me.Label6)
        Me.groupInfo.Controls.Add(Me.Label2)
        Me.groupInfo.Controls.Add(Me.Label1)
        Me.groupInfo.Controls.Add(Me.txtcodcli)
        Me.groupInfo.Controls.Add(Me.txtnomecli)
        Me.groupInfo.Controls.Add(Me.Label3)
        Me.groupInfo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupInfo.Location = New System.Drawing.Point(12, 74)
        Me.groupInfo.Name = "groupInfo"
        Me.groupInfo.Size = New System.Drawing.Size(696, 194)
        Me.groupInfo.TabIndex = 62
        Me.groupInfo.TabStop = False
        Me.groupInfo.Text = "Informações"
        '
        'txtcpfcli
        '
        Me.txtcpfcli.BackColor = System.Drawing.Color.White
        Me.txtcpfcli.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtcpfcli.Location = New System.Drawing.Point(6, 90)
        Me.txtcpfcli.MaxLength = 14
        Me.txtcpfcli.Name = "txtcpfcli"
        Me.txtcpfcli.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcpfcli.Size = New System.Drawing.Size(118, 23)
        Me.txtcpfcli.TabIndex = 60
        Me.txtcpfcli.Tag = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(250, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Nacionalidade"
        '
        'txtnaccli
        '
        Me.txtnaccli.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtnaccli.FormattingEnabled = True
        Me.txtnaccli.Items.AddRange(New Object() {"Selecione...", "Afegão(a)", "albanês", "alemão (a)", "americano(a)", "angolano(a)", "argelino(a)", "argentino(a)", "australiano(a)", "Belga(a)", "brasileiro(a)", "búlgaro(a)", "cabo-verdiano(a)", "canadiano(a)", "chileno(a)", "chinês(a)", "cipriota", "colombiano(a)", "croata", "cubano(a)", "dinamarquês(a)", "eslovaco(a)", "esloveno(a)", "espanhol(a)", "finlandês(a)", "francês(a)", "grego(a)", "guineense", "holandês(a)", "húngaro(a)", "indiano(a)", "indoneso(a)", "inglês(a)", "iraniano(a)", "iraquiano(a)", "irlandês(a)", "islandês(a)", "israelita(a)", "italiano(a)", "japonês(a)", "jordano(a)", "kosovar", "libanês(a)", "líbio(a)", "lituano(a)", "luxemburguês(a)", "marroquino(a)", "mexicano(a)", "moçambicano(a)", "montenegrino(a)", "neozelandês(a)", "nigeriano(a)", "norte-coreano(a)", "norueguês(a)", "paquistanês(a)", "polaco(a)", "português(a)", "queniano(a)", "romenos(a)", "ruandês(a)", "russo(a)", "santomense(a)", "senegalês(a)", "sírio(a)", "somali", "sudanês(a)", "sueco(a)", "suíço(a)", "sul-africano(a)", "sul-coreano(a)", "tailandês(a)", "timorense(a)", "tunisino(a)", "turco(a)", "ucraniano(a)", "venezuelano(a)", "vietnamita(a)"})
        Me.txtnaccli.Location = New System.Drawing.Point(253, 89)
        Me.txtnaccli.Name = "txtnaccli"
        Me.txtnaccli.Size = New System.Drawing.Size(121, 24)
        Me.txtnaccli.TabIndex = 58
        Me.txtnaccli.Tag = "nacionalidade"
        Me.txtnaccli.Text = "Selecione..."
        '
        'btnTirar
        '
        Me.btnTirar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTirar.ForeColor = System.Drawing.Color.Blue
        Me.btnTirar.Location = New System.Drawing.Point(576, 25)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(110, 32)
        Me.btnTirar.TabIndex = 57
        Me.btnTirar.Tag = "Fazer upload de fotos"
        Me.btnTirar.Text = "Tirar "
        Me.btnTirar.UseVisualStyleBackColor = False
        '
        'txthabcli
        '
        Me.txthabcli.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txthabcli.Location = New System.Drawing.Point(9, 134)
        Me.txthabcli.Mask = "00000000000"
        Me.txthabcli.Name = "txthabcli"
        Me.txthabcli.Size = New System.Drawing.Size(127, 23)
        Me.txthabcli.TabIndex = 7
        Me.txthabcli.Tag = "habilitação"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 134)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 23)
        Me.DateTimePicker1.TabIndex = 6
        Me.DateTimePicker1.Tag = "data"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.ForeColor = System.Drawing.Color.Blue
        Me.btnUpload.Location = New System.Drawing.Point(576, 62)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(110, 32)
        Me.btnUpload.TabIndex = 21
        Me.btnUpload.Tag = "Fazer upload de fotos"
        Me.btnUpload.Text = "upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(380, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(275, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 16)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Sexo"
        '
        'txtsexocli
        '
        Me.txtsexocli.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtsexocli.FormattingEnabled = True
        Me.txtsexocli.Items.AddRange(New Object() {"Selecione...", "Masculino", "Feminino"})
        Me.txtsexocli.Location = New System.Drawing.Point(278, 44)
        Me.txtsexocli.Name = "txtsexocli"
        Me.txtsexocli.Size = New System.Drawing.Size(95, 24)
        Me.txtsexocli.TabIndex = 5
        Me.txtsexocli.Tag = "sexo"
        Me.txtsexocli.Text = "Selecione..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Categoria"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "CPF"
        '
        'txtcathabcli
        '
        Me.txtcathabcli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcathabcli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcathabcli.FormattingEnabled = True
        Me.txtcathabcli.Items.AddRange(New Object() {"A", "AB", "ABC", "B", "C", "D", "E"})
        Me.txtcathabcli.Location = New System.Drawing.Point(257, 133)
        Me.txtcathabcli.Name = "txtcathabcli"
        Me.txtcathabcli.Size = New System.Drawing.Size(117, 24)
        Me.txtcathabcli.TabIndex = 8
        Me.txtcathabcli.Tag = "categoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Habilitação"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Nascimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Código"
        '
        'txtcodcli
        '
        Me.txtcodcli.Enabled = False
        Me.txtcodcli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcli.Location = New System.Drawing.Point(6, 45)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.Size = New System.Drawing.Size(48, 23)
        Me.txtcodcli.TabIndex = 26
        '
        'txtnomecli
        '
        Me.txtnomecli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomecli.Location = New System.Drawing.Point(63, 45)
        Me.txtnomecli.Name = "txtnomecli"
        Me.txtnomecli.Size = New System.Drawing.Size(209, 23)
        Me.txtnomecli.TabIndex = 1
        Me.txtnomecli.Tag = "nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "RG"
        '
        'groupEnd
        '
        Me.groupEnd.BackColor = System.Drawing.Color.Transparent
        Me.groupEnd.Controls.Add(Me.txtestado)
        Me.groupEnd.Controls.Add(Me.txtcidade)
        Me.groupEnd.Controls.Add(Me.txtbairro)
        Me.groupEnd.Controls.Add(Me.txtcepcli)
        Me.groupEnd.Controls.Add(Me.txtcompl)
        Me.groupEnd.Controls.Add(Me.txtnumcasa)
        Me.groupEnd.Controls.Add(Me.Label8)
        Me.groupEnd.Controls.Add(Me.Label9)
        Me.groupEnd.Controls.Add(Me.Label13)
        Me.groupEnd.Controls.Add(Me.Label14)
        Me.groupEnd.Controls.Add(Me.Label15)
        Me.groupEnd.Controls.Add(Me.Label17)
        Me.groupEnd.Controls.Add(Me.txtlogracli)
        Me.groupEnd.Controls.Add(Me.Label18)
        Me.groupEnd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupEnd.Location = New System.Drawing.Point(12, 277)
        Me.groupEnd.Name = "groupEnd"
        Me.groupEnd.Size = New System.Drawing.Size(372, 186)
        Me.groupEnd.TabIndex = 63
        Me.groupEnd.TabStop = False
        Me.groupEnd.Text = "Endereço"
        '
        'txtestado
        '
        Me.txtestado.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtestado.FormattingEnabled = True
        Me.txtestado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtestado.Location = New System.Drawing.Point(202, 134)
        Me.txtestado.MaxLength = 2
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(48, 24)
        Me.txtestado.TabIndex = 53
        Me.txtestado.Text = "---"
        '
        'txtcidade
        '
        Me.txtcidade.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcidade.Location = New System.Drawing.Point(9, 137)
        Me.txtcidade.Name = "txtcidade"
        Me.txtcidade.Size = New System.Drawing.Size(185, 23)
        Me.txtcidade.TabIndex = 15
        Me.txtcidade.Tag = "cidade"
        '
        'txtbairro
        '
        Me.txtbairro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbairro.Location = New System.Drawing.Point(200, 90)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(166, 23)
        Me.txtbairro.TabIndex = 14
        Me.txtbairro.Tag = "bairro"
        '
        'txtcepcli
        '
        Me.txtcepcli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcepcli.Location = New System.Drawing.Point(277, 42)
        Me.txtcepcli.Mask = "00000-000"
        Me.txtcepcli.Name = "txtcepcli"
        Me.txtcepcli.Size = New System.Drawing.Size(89, 23)
        Me.txtcepcli.TabIndex = 13
        Me.txtcepcli.Tag = "CEP"
        '
        'txtcompl
        '
        Me.txtcompl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompl.Location = New System.Drawing.Point(9, 91)
        Me.txtcompl.Name = "txtcompl"
        Me.txtcompl.Size = New System.Drawing.Size(185, 23)
        Me.txtcompl.TabIndex = 12
        Me.txtcompl.Tag = "complemento"
        '
        'txtnumcasa
        '
        Me.txtnumcasa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumcasa.Location = New System.Drawing.Point(229, 42)
        Me.txtnumcasa.Name = "txtnumcasa"
        Me.txtnumcasa.Size = New System.Drawing.Size(40, 23)
        Me.txtnumcasa.TabIndex = 11
        Me.txtnumcasa.Tag = "número"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Cidade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(226, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Núm"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(197, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Estado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(197, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Bairro"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(282, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 16)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "CEP"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 16)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Logradouro"
        '
        'txtlogracli
        '
        Me.txtlogracli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlogracli.Location = New System.Drawing.Point(7, 42)
        Me.txtlogracli.Name = "txtlogracli"
        Me.txtlogracli.Size = New System.Drawing.Size(216, 23)
        Me.txtlogracli.TabIndex = 10
        Me.txtlogracli.Tag = "logradouro"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Complemento"
        '
        'txtemail
        '
        Me.txtemail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtemail.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtemail.Location = New System.Drawing.Point(118, 148)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(194, 23)
        Me.txtemail.TabIndex = 64
        Me.txtemail.Tag = "e-mail"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(180, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 16)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "E-mail"
        '
        'txtnumtel
        '
        Me.txtnumtel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnumtel.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtnumtel.Location = New System.Drawing.Point(183, 42)
        Me.txtnumtel.Mask = "(00)0000-0000"
        Me.txtnumtel.Name = "txtnumtel"
        Me.txtnumtel.Size = New System.Drawing.Size(125, 23)
        Me.txtnumtel.TabIndex = 17
        Me.txtnumtel.Tag = "número de telefone"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(181, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Número"
        '
        'txttipotel2
        '
        Me.txttipotel2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txttipotel2.FormattingEnabled = True
        Me.txttipotel2.Items.AddRange(New Object() {"Selecione...", "Residencial", "Celular", "Comercial", "Outro"})
        Me.txttipotel2.Location = New System.Drawing.Point(8, 89)
        Me.txttipotel2.Name = "txttipotel2"
        Me.txttipotel2.Size = New System.Drawing.Size(121, 24)
        Me.txttipotel2.TabIndex = 64
        Me.txttipotel2.Tag = "tipo de telefone"
        Me.txttipotel2.Text = "Selecione..."
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(181, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "2º Número"
        '
        'txtnumtel2
        '
        Me.txtnumtel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnumtel2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtnumtel2.Location = New System.Drawing.Point(184, 89)
        Me.txtnumtel2.Mask = "(00)0000-0000"
        Me.txtnumtel2.Name = "txtnumtel2"
        Me.txtnumtel2.Size = New System.Drawing.Size(124, 23)
        Me.txtnumtel2.TabIndex = 63
        Me.txtnumtel2.Tag = "número de telefone"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(3, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 16)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Tipo"
        '
        'txttipotel
        '
        Me.txttipotel.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txttipotel.FormattingEnabled = True
        Me.txttipotel.Items.AddRange(New Object() {"Selecione...", "Residencial", "Celular", "Comercial", "Outro"})
        Me.txttipotel.Location = New System.Drawing.Point(8, 43)
        Me.txttipotel.Name = "txttipotel"
        Me.txttipotel.Size = New System.Drawing.Size(121, 24)
        Me.txttipotel.TabIndex = 18
        Me.txttipotel.Tag = "tipo de telefone"
        Me.txttipotel.Text = "Selecione..."
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(6, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 16)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Tipo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'groupConCli
        '
        Me.groupConCli.BackColor = System.Drawing.Color.Transparent
        Me.groupConCli.Controls.Add(Me.listTel)
        Me.groupConCli.Controls.Add(Me.txtemail)
        Me.groupConCli.Controls.Add(Me.txtnumtel2)
        Me.groupConCli.Controls.Add(Me.txttipotel2)
        Me.groupConCli.Controls.Add(Me.txtnumtel)
        Me.groupConCli.Controls.Add(Me.Label22)
        Me.groupConCli.Controls.Add(Me.Label23)
        Me.groupConCli.Controls.Add(Me.Label19)
        Me.groupConCli.Controls.Add(Me.txttipotel)
        Me.groupConCli.Controls.Add(Me.Label16)
        Me.groupConCli.Controls.Add(Me.Label20)
        Me.groupConCli.Controls.Add(Me.Label11)
        Me.groupConCli.Controls.Add(Me.txtformatrat)
        Me.groupConCli.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.groupConCli.Location = New System.Drawing.Point(390, 277)
        Me.groupConCli.Name = "groupConCli"
        Me.groupConCli.Size = New System.Drawing.Size(318, 186)
        Me.groupConCli.TabIndex = 64
        Me.groupConCli.TabStop = False
        Me.groupConCli.Text = "Contato"
        '
        'listTel
        '
        Me.listTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listTel.CheckBoxes = True
        Me.listTel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Numero, Me.Tipo})
        Me.listTel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTel.GridLines = True
        Me.listTel.LabelEdit = True
        Me.listTel.Location = New System.Drawing.Point(6, 25)
        Me.listTel.Name = "listTel"
        Me.listTel.Size = New System.Drawing.Size(305, 91)
        Me.listTel.TabIndex = 67
        Me.listTel.UseCompatibleStateImageBehavior = False
        Me.listTel.View = System.Windows.Forms.View.Details
        '
        'Numero
        '
        Me.Numero.Text = "Número"
        Me.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Numero.Width = 150
        '
        'Tipo
        '
        Me.Tipo.Text = "Tipo"
        Me.Tipo.Width = 150
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(6, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 16)
        Me.Label22.TabIndex = 62
        Me.Label22.Text = "Forma de Trat."
        '
        'txtformatrat
        '
        Me.txtformatrat.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtformatrat.FormattingEnabled = True
        Me.txtformatrat.Items.AddRange(New Object() {"Selecione...", "Sr.", "Sra."})
        Me.txtformatrat.Location = New System.Drawing.Point(9, 147)
        Me.txtformatrat.Name = "txtformatrat"
        Me.txtformatrat.Size = New System.Drawing.Size(103, 24)
        Me.txtformatrat.TabIndex = 65
        Me.txtformatrat.Tag = "forma de tratamento"
        Me.txtformatrat.Text = "Selecione..."
        '
        'picAGL
        '
        Me.picAGL.BackColor = System.Drawing.Color.Transparent
        Me.picAGL.Image = Global.TCC.My.Resources.Resources.bannersite
        Me.picAGL.Location = New System.Drawing.Point(525, 0)
        Me.picAGL.Name = "picAGL"
        Me.picAGL.Size = New System.Drawing.Size(203, 82)
        Me.picAGL.TabIndex = 79
        Me.picAGL.TabStop = False
        '
        'txtrgcli
        '
        Me.txtrgcli.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtrgcli.Location = New System.Drawing.Point(130, 89)
        Me.txtrgcli.Mask = "00,000,000-C"
        Me.txtrgcli.Name = "txtrgcli"
        Me.txtrgcli.Size = New System.Drawing.Size(109, 23)
        Me.txtrgcli.TabIndex = 74
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 470)
        Me.Controls.Add(Me.picAGL)
        Me.Controls.Add(Me.groupConCli)
        Me.Controls.Add(Me.groupEnd)
        Me.Controls.Add(Me.groupInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupInfo.ResumeLayout(False)
        Me.groupInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupEnd.ResumeLayout(False)
        Me.groupEnd.PerformLayout()
        Me.groupConCli.ResumeLayout(False)
        Me.groupConCli.PerformLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAltera As System.Windows.Forms.ToolStripButton
    Friend WithEvents btngrava As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPesquisa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents groupInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcathabcli As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupEnd As System.Windows.Forms.GroupBox
    Friend WithEvents txtbairro As System.Windows.Forms.TextBox
    Friend WithEvents txtcepcli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcompl As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtlogracli As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcidade As System.Windows.Forms.TextBox
    Friend WithEvents txtnumtel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtsexocli As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txttipotel As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txthabcli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtnumtel2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txttipotel2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnTirar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnaccli As System.Windows.Forms.ComboBox
    Public WithEvents txtnomecli As System.Windows.Forms.TextBox
    Friend WithEvents txtnumcasa As System.Windows.Forms.TextBox
    Friend WithEvents groupConCli As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtformatrat As System.Windows.Forms.ComboBox
    Public WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcpfcli As System.Windows.Forms.TextBox
    Friend WithEvents txtestado As System.Windows.Forms.ComboBox
    Friend WithEvents listTel As System.Windows.Forms.ListView
    Friend WithEvents Numero As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents picAGL As System.Windows.Forms.PictureBox
    Friend WithEvents txtrgcli As System.Windows.Forms.MaskedTextBox
End Class
