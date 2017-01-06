<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarro))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodcarro = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtrenavam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtano = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttipocombus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtchassi = New System.Windows.Forms.TextBox()
        Me.groupInfo = New System.Windows.Forms.GroupBox()
        Me.lstCategoria = New System.Windows.Forms.ComboBox()
        Me.txtdatafabr = New System.Windows.Forms.DateTimePicker()
        Me.txtCor = New System.Windows.Forms.ComboBox()
        Me.groupAcess = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.picCarro = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupSitu = New System.Windows.Forms.GroupBox()
        Me.rbReserv = New System.Windows.Forms.RadioButton()
        Me.rbVend = New System.Windows.Forms.RadioButton()
        Me.rbAVenda = New System.Windows.Forms.RadioButton()
        Me.rbRoubado = New System.Windows.Forms.RadioButton()
        Me.rbManu = New System.Windows.Forms.RadioButton()
        Me.rbAlugado = New System.Windows.Forms.RadioButton()
        Me.rbPrep = New System.Windows.Forms.RadioButton()
        Me.rbDisp = New System.Windows.Forms.RadioButton()
        Me.rbBloqueado = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbInativo = New System.Windows.Forms.RadioButton()
        Me.rbAtivo = New System.Windows.Forms.RadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.picAGL = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.groupInfo.SuspendLayout()
        Me.groupAcess.SuspendLayout()
        CType(Me.picCarro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSitu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 55)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.TCC.My.Resources.Resources.add
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.TCC.My.Resources.Resources.refresh
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.TCC.My.Resources.Resources.accept_page
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.TCC.My.Resources.Resources.search_page
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cód."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Placa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Renavam"
        '
        'txtcodcarro
        '
        Me.txtcodcarro.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcarro.Location = New System.Drawing.Point(5, 40)
        Me.txtcodcarro.Name = "txtcodcarro"
        Me.txtcodcarro.Size = New System.Drawing.Size(36, 22)
        Me.txtcodcarro.TabIndex = 34
        '
        'txtplaca
        '
        Me.txtplaca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplaca.Location = New System.Drawing.Point(48, 40)
        Me.txtplaca.MaxLength = 8
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(78, 22)
        Me.txtplaca.TabIndex = 35
        '
        'txtmodelo
        '
        Me.txtmodelo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelo.Location = New System.Drawing.Point(132, 41)
        Me.txtmodelo.MaxLength = 100
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(132, 22)
        Me.txtmodelo.TabIndex = 36
        Me.txtmodelo.Tag = "modelo"
        '
        'txtrenavam
        '
        Me.txtrenavam.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrenavam.Location = New System.Drawing.Point(9, 170)
        Me.txtrenavam.MaxLength = 11
        Me.txtrenavam.Name = "txtrenavam"
        Me.txtrenavam.Size = New System.Drawing.Size(98, 22)
        Me.txtrenavam.TabIndex = 37
        Me.txtrenavam.Tag = "Renavam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Ano "
        '
        'txtmarca
        '
        Me.txtmarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(61, 128)
        Me.txtmarca.MaxLength = 45
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(131, 22)
        Me.txtmarca.TabIndex = 39
        Me.txtmarca.Tag = "marca"
        '
        'txtano
        '
        Me.txtano.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtano.Location = New System.Drawing.Point(9, 127)
        Me.txtano.MaxLength = 4
        Me.txtano.Name = "txtano"
        Me.txtano.Size = New System.Drawing.Size(47, 22)
        Me.txtano.TabIndex = 40
        Me.txtano.Tag = "ano"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(229, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Data  Fabr."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Cor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Marca"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(119, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Tipo de Combs."
        '
        'txttipocombus
        '
        Me.txttipocombus.BackColor = System.Drawing.Color.White
        Me.txttipocombus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipocombus.FormattingEnabled = True
        Me.txttipocombus.Items.AddRange(New Object() {"<SELECIONE>", "Diesel", "Etanol", "Flex", "Gasolina", "DNV"})
        Me.txttipocombus.Location = New System.Drawing.Point(122, 83)
        Me.txttipocombus.Name = "txttipocombus"
        Me.txttipocombus.Size = New System.Drawing.Size(104, 22)
        Me.txttipocombus.TabIndex = 47
        Me.txttipocombus.Tag = "combustível"
        Me.txttipocombus.Text = "<SELECIONE>"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(198, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 16)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Categoria"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(107, 151)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 16)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "Chassi"
        '
        'txtchassi
        '
        Me.txtchassi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchassi.Location = New System.Drawing.Point(110, 170)
        Me.txtchassi.MaxLength = 17
        Me.txtchassi.Name = "txtchassi"
        Me.txtchassi.Size = New System.Drawing.Size(179, 22)
        Me.txtchassi.TabIndex = 53
        Me.txtchassi.Tag = "chassi"
        '
        'groupInfo
        '
        Me.groupInfo.BackColor = System.Drawing.Color.Transparent
        Me.groupInfo.Controls.Add(Me.lstCategoria)
        Me.groupInfo.Controls.Add(Me.txtdatafabr)
        Me.groupInfo.Controls.Add(Me.txtCor)
        Me.groupInfo.Controls.Add(Me.txtchassi)
        Me.groupInfo.Controls.Add(Me.Label23)
        Me.groupInfo.Controls.Add(Me.Label12)
        Me.groupInfo.Controls.Add(Me.txttipocombus)
        Me.groupInfo.Controls.Add(Me.Label10)
        Me.groupInfo.Controls.Add(Me.Label9)
        Me.groupInfo.Controls.Add(Me.Label7)
        Me.groupInfo.Controls.Add(Me.Label6)
        Me.groupInfo.Controls.Add(Me.txtano)
        Me.groupInfo.Controls.Add(Me.txtmarca)
        Me.groupInfo.Controls.Add(Me.Label5)
        Me.groupInfo.Controls.Add(Me.txtrenavam)
        Me.groupInfo.Controls.Add(Me.txtmodelo)
        Me.groupInfo.Controls.Add(Me.txtplaca)
        Me.groupInfo.Controls.Add(Me.txtcodcarro)
        Me.groupInfo.Controls.Add(Me.Label4)
        Me.groupInfo.Controls.Add(Me.Label3)
        Me.groupInfo.Controls.Add(Me.Label2)
        Me.groupInfo.Controls.Add(Me.Label1)
        Me.groupInfo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupInfo.Location = New System.Drawing.Point(12, 68)
        Me.groupInfo.Name = "groupInfo"
        Me.groupInfo.Size = New System.Drawing.Size(352, 202)
        Me.groupInfo.TabIndex = 7
        Me.groupInfo.TabStop = False
        Me.groupInfo.Text = "Informações"
        '
        'lstCategoria
        '
        Me.lstCategoria.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCategoria.FormattingEnabled = True
        Me.lstCategoria.Location = New System.Drawing.Point(201, 129)
        Me.lstCategoria.Name = "lstCategoria"
        Me.lstCategoria.Size = New System.Drawing.Size(135, 22)
        Me.lstCategoria.TabIndex = 56
        '
        'txtdatafabr
        '
        Me.txtdatafabr.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatafabr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdatafabr.Location = New System.Drawing.Point(232, 83)
        Me.txtdatafabr.Name = "txtdatafabr"
        Me.txtdatafabr.Size = New System.Drawing.Size(104, 22)
        Me.txtdatafabr.TabIndex = 55
        Me.txtdatafabr.Tag = "data"
        '
        'txtCor
        '
        Me.txtCor.BackColor = System.Drawing.Color.White
        Me.txtCor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCor.FormattingEnabled = True
        Me.txtCor.Items.AddRange(New Object() {"Selecione...", "Azul", "Verm.", "Verde", "Preto", "Marrom", "Vinho", "Prata", "Amarelo"})
        Me.txtCor.Location = New System.Drawing.Point(7, 82)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(110, 22)
        Me.txtCor.TabIndex = 54
        Me.txtCor.Tag = "cor"
        '
        'groupAcess
        '
        Me.groupAcess.BackColor = System.Drawing.Color.Transparent
        Me.groupAcess.Controls.Add(Me.Button3)
        Me.groupAcess.Controls.Add(Me.Button2)
        Me.groupAcess.Controls.Add(Me.ListBox1)
        Me.groupAcess.Controls.Add(Me.picCarro)
        Me.groupAcess.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupAcess.Location = New System.Drawing.Point(370, 68)
        Me.groupAcess.Name = "groupAcess"
        Me.groupAcess.Size = New System.Drawing.Size(342, 202)
        Me.groupAcess.TabIndex = 54
        Me.groupAcess.TabStop = False
        Me.groupAcess.Text = "Acessórios"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 26)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(157, 116)
        Me.ListBox1.TabIndex = 10
        '
        'picCarro
        '
        Me.picCarro.BackColor = System.Drawing.Color.White
        Me.picCarro.BackgroundImage = Global.TCC.My.Resources.Resources.car
        Me.picCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCarro.Location = New System.Drawing.Point(179, 26)
        Me.picCarro.Name = "picCarro"
        Me.picCarro.Size = New System.Drawing.Size(147, 157)
        Me.picCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarro.TabIndex = 9
        Me.picCarro.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(571, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 34)
        Me.Button1.TabIndex = 55
        Me.Button1.Tag = "Fazer upload de fotos"
        Me.Button1.Text = "Carregar Foto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'groupSitu
        '
        Me.groupSitu.BackColor = System.Drawing.Color.Transparent
        Me.groupSitu.Controls.Add(Me.rbReserv)
        Me.groupSitu.Controls.Add(Me.rbVend)
        Me.groupSitu.Controls.Add(Me.rbAVenda)
        Me.groupSitu.Controls.Add(Me.rbRoubado)
        Me.groupSitu.Controls.Add(Me.rbManu)
        Me.groupSitu.Controls.Add(Me.rbAlugado)
        Me.groupSitu.Controls.Add(Me.rbPrep)
        Me.groupSitu.Controls.Add(Me.rbDisp)
        Me.groupSitu.Controls.Add(Me.rbBloqueado)
        Me.groupSitu.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupSitu.Location = New System.Drawing.Point(12, 276)
        Me.groupSitu.Name = "groupSitu"
        Me.groupSitu.Size = New System.Drawing.Size(377, 104)
        Me.groupSitu.TabIndex = 56
        Me.groupSitu.TabStop = False
        Me.groupSitu.Text = "Situação"
        '
        'rbReserv
        '
        Me.rbReserv.AutoSize = True
        Me.rbReserv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbReserv.Location = New System.Drawing.Point(242, 77)
        Me.rbReserv.Name = "rbReserv"
        Me.rbReserv.Size = New System.Drawing.Size(94, 20)
        Me.rbReserv.TabIndex = 17
        Me.rbReserv.Text = "Reservado"
        Me.rbReserv.UseVisualStyleBackColor = True
        '
        'rbVend
        '
        Me.rbVend.AutoSize = True
        Me.rbVend.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVend.Location = New System.Drawing.Point(104, 77)
        Me.rbVend.Name = "rbVend"
        Me.rbVend.Size = New System.Drawing.Size(77, 20)
        Me.rbVend.TabIndex = 16
        Me.rbVend.Text = "Vendido"
        Me.rbVend.UseVisualStyleBackColor = True
        '
        'rbAVenda
        '
        Me.rbAVenda.AutoSize = True
        Me.rbAVenda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAVenda.Location = New System.Drawing.Point(15, 77)
        Me.rbAVenda.Name = "rbAVenda"
        Me.rbAVenda.Size = New System.Drawing.Size(80, 20)
        Me.rbAVenda.TabIndex = 15
        Me.rbAVenda.Text = "Á venda"
        Me.rbAVenda.UseVisualStyleBackColor = True
        '
        'rbRoubado
        '
        Me.rbRoubado.AutoSize = True
        Me.rbRoubado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRoubado.Location = New System.Drawing.Point(242, 51)
        Me.rbRoubado.Name = "rbRoubado"
        Me.rbRoubado.Size = New System.Drawing.Size(82, 20)
        Me.rbRoubado.TabIndex = 14
        Me.rbRoubado.Text = "Roubado"
        Me.rbRoubado.UseVisualStyleBackColor = True
        '
        'rbManu
        '
        Me.rbManu.AutoSize = True
        Me.rbManu.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbManu.Location = New System.Drawing.Point(104, 24)
        Me.rbManu.Name = "rbManu"
        Me.rbManu.Size = New System.Drawing.Size(131, 20)
        Me.rbManu.TabIndex = 13
        Me.rbManu.Text = "Em manutenção"
        Me.rbManu.UseVisualStyleBackColor = True
        '
        'rbAlugado
        '
        Me.rbAlugado.AutoSize = True
        Me.rbAlugado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlugado.Location = New System.Drawing.Point(16, 51)
        Me.rbAlugado.Name = "rbAlugado"
        Me.rbAlugado.Size = New System.Drawing.Size(78, 20)
        Me.rbAlugado.TabIndex = 12
        Me.rbAlugado.Text = "Alugado"
        Me.rbAlugado.UseVisualStyleBackColor = True
        '
        'rbPrep
        '
        Me.rbPrep.AutoSize = True
        Me.rbPrep.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrep.Location = New System.Drawing.Point(241, 24)
        Me.rbPrep.Name = "rbPrep"
        Me.rbPrep.Size = New System.Drawing.Size(124, 20)
        Me.rbPrep.TabIndex = 10
        Me.rbPrep.Text = "Em preparação"
        Me.rbPrep.UseVisualStyleBackColor = True
        '
        'rbDisp
        '
        Me.rbDisp.AutoSize = True
        Me.rbDisp.Checked = True
        Me.rbDisp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDisp.Location = New System.Drawing.Point(15, 24)
        Me.rbDisp.Name = "rbDisp"
        Me.rbDisp.Size = New System.Drawing.Size(91, 20)
        Me.rbDisp.TabIndex = 9
        Me.rbDisp.TabStop = True
        Me.rbDisp.Text = "Dispónível"
        Me.rbDisp.UseVisualStyleBackColor = True
        '
        'rbBloqueado
        '
        Me.rbBloqueado.AutoSize = True
        Me.rbBloqueado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBloqueado.Location = New System.Drawing.Point(104, 51)
        Me.rbBloqueado.Name = "rbBloqueado"
        Me.rbBloqueado.Size = New System.Drawing.Size(93, 20)
        Me.rbBloqueado.TabIndex = 11
        Me.rbBloqueado.Text = "Bloqueado"
        Me.rbBloqueado.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbInativo)
        Me.GroupBox1.Controls.Add(Me.rbAtivo)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(395, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 57)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'rbInativo
        '
        Me.rbInativo.AutoSize = True
        Me.rbInativo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInativo.Location = New System.Drawing.Point(92, 26)
        Me.rbInativo.Name = "rbInativo"
        Me.rbInativo.Size = New System.Drawing.Size(72, 20)
        Me.rbInativo.TabIndex = 3
        Me.rbInativo.Text = "Inativo"
        Me.rbInativo.UseVisualStyleBackColor = True
        '
        'rbAtivo
        '
        Me.rbAtivo.AutoSize = True
        Me.rbAtivo.Checked = True
        Me.rbAtivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAtivo.Location = New System.Drawing.Point(16, 26)
        Me.rbAtivo.Name = "rbAtivo"
        Me.rbAtivo.Size = New System.Drawing.Size(60, 20)
        Me.rbAtivo.TabIndex = 2
        Me.rbAtivo.TabStop = True
        Me.rbAtivo.Text = "Ativo"
        Me.rbAtivo.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(395, 364)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 16)
        Me.LinkLabel1.TabIndex = 57
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Histórico"
        '
        'picAGL
        '
        Me.picAGL.BackColor = System.Drawing.Color.Transparent
        Me.picAGL.Image = Global.TCC.My.Resources.Resources.bannersite
        Me.picAGL.Location = New System.Drawing.Point(527, -4)
        Me.picAGL.Name = "picAGL"
        Me.picAGL.Size = New System.Drawing.Size(205, 80)
        Me.picAGL.TabIndex = 79
        Me.picAGL.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 36)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(84, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 36)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmCarro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 394)
        Me.Controls.Add(Me.picAGL)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupSitu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.groupAcess)
        Me.Controls.Add(Me.groupInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmCarro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carros"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupInfo.ResumeLayout(False)
        Me.groupInfo.PerformLayout()
        Me.groupAcess.ResumeLayout(False)
        CType(Me.picCarro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSitu.ResumeLayout(False)
        Me.groupSitu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcodcarro As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents txtrenavam As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents txtano As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttipocombus As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtchassi As System.Windows.Forms.TextBox
    Friend WithEvents groupInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtCor As System.Windows.Forms.ComboBox
    Friend WithEvents groupAcess As System.Windows.Forms.GroupBox
    Friend WithEvents picCarro As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents groupSitu As System.Windows.Forms.GroupBox
    Friend WithEvents rbReserv As System.Windows.Forms.RadioButton
    Friend WithEvents rbVend As System.Windows.Forms.RadioButton
    Friend WithEvents rbAVenda As System.Windows.Forms.RadioButton
    Friend WithEvents rbRoubado As System.Windows.Forms.RadioButton
    Friend WithEvents rbManu As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlugado As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrep As System.Windows.Forms.RadioButton
    Friend WithEvents rbDisp As System.Windows.Forms.RadioButton
    Friend WithEvents rbBloqueado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbInativo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAtivo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdatafabr As System.Windows.Forms.DateTimePicker
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lstCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents picAGL As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
