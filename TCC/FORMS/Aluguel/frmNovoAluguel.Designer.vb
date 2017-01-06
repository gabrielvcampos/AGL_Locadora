<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovoAluguel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovoAluguel))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mskHoraRetirada = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mskDataRetirada = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcathab = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txthab = New System.Windows.Forms.TextBox()
        Me.txtdatanasc = New System.Windows.Forms.MaskedTextBox()
        Me.txtcondutor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtnomecli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrg = New System.Windows.Forms.MaskedTextBox()
        Me.cbSeguro = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbdias = New System.Windows.Forms.Label()
        Me.mskHoraEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.mskDataEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbltanque = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtkmatual = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.listAcessorios = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtplacacarro = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtanocarro = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcodcarro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCarros = New System.Windows.Forms.LinkLabel()
        Me.lbErro = New System.Windows.Forms.Label()
        Me.picAGL = New System.Windows.Forms.PictureBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.mskHoraRetirada)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.mskDataRetirada)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(250, 243)
        Me.GroupBox4.TabIndex = 60
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Retirada"
        '
        'mskHoraRetirada
        '
        Me.mskHoraRetirada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHoraRetirada.Location = New System.Drawing.Point(94, 212)
        Me.mskHoraRetirada.Mask = "00:00:00"
        Me.mskHoraRetirada.Name = "mskHoraRetirada"
        Me.mskHoraRetirada.Size = New System.Drawing.Size(71, 23)
        Me.mskHoraRetirada.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(91, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Hora"
        '
        'mskDataRetirada
        '
        Me.mskDataRetirada.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.mskDataRetirada.Location = New System.Drawing.Point(14, 212)
        Me.mskDataRetirada.Mask = "00/00/0000"
        Me.mskDataRetirada.Name = "mskDataRetirada"
        Me.mskDataRetirada.Size = New System.Drawing.Size(74, 20)
        Me.mskDataRetirada.TabIndex = 2
        Me.mskDataRetirada.ValidatingType = GetType(Date)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Data"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 25)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtcathab)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txthab)
        Me.GroupBox1.Controls.Add(Me.txtdatanasc)
        Me.GroupBox1.Controls.Add(Me.txtcondutor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcod)
        Me.GroupBox1.Controls.Add(Me.txtnomecli)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtrg)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 178)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'txtcathab
        '
        Me.txtcathab.Enabled = False
        Me.txtcathab.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtcathab.Location = New System.Drawing.Point(124, 146)
        Me.txtcathab.Name = "txtcathab"
        Me.txtcathab.Size = New System.Drawing.Size(41, 23)
        Me.txtcathab.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(122, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Categoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Habilitação"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Nascimento"
        '
        'txthab
        '
        Me.txthab.Enabled = False
        Me.txthab.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthab.Location = New System.Drawing.Point(9, 146)
        Me.txthab.Name = "txthab"
        Me.txthab.Size = New System.Drawing.Size(95, 23)
        Me.txthab.TabIndex = 40
        '
        'txtdatanasc
        '
        Me.txtdatanasc.Enabled = False
        Me.txtdatanasc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatanasc.Location = New System.Drawing.Point(292, 98)
        Me.txtdatanasc.Mask = "00/00/0000"
        Me.txtdatanasc.Name = "txtdatanasc"
        Me.txtdatanasc.Size = New System.Drawing.Size(94, 23)
        Me.txtdatanasc.TabIndex = 17
        Me.txtdatanasc.ValidatingType = GetType(Date)
        '
        'txtcondutor
        '
        Me.txtcondutor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcondutor.Location = New System.Drawing.Point(8, 98)
        Me.txtcondutor.Name = "txtcondutor"
        Me.txtcondutor.Size = New System.Drawing.Size(152, 23)
        Me.txtcondutor.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Condutor Principal"
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
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(6, 45)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(48, 23)
        Me.txtcod.TabIndex = 26
        '
        'txtnomecli
        '
        Me.txtnomecli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomecli.Location = New System.Drawing.Point(63, 45)
        Me.txtnomecli.Name = "txtnomecli"
        Me.txtnomecli.Size = New System.Drawing.Size(414, 23)
        Me.txtnomecli.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Identidade"
        '
        'txtrg
        '
        Me.txtrg.Enabled = False
        Me.txtrg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrg.Location = New System.Drawing.Point(166, 98)
        Me.txtrg.Mask = "00,000,000-0"
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(112, 23)
        Me.txtrg.TabIndex = 30
        '
        'cbSeguro
        '
        Me.cbSeguro.AutoSize = True
        Me.cbSeguro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSeguro.Location = New System.Drawing.Point(153, 341)
        Me.cbSeguro.Name = "cbSeguro"
        Me.cbSeguro.Size = New System.Drawing.Size(73, 20)
        Me.cbSeguro.TabIndex = 49
        Me.cbSeguro.Text = "Seguro"
        Me.cbSeguro.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbdias)
        Me.GroupBox3.Controls.Add(Me.mskHoraEntrega)
        Me.GroupBox3.Controls.Add(Me.MonthCalendar2)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.mskDataEntrega)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(268, 257)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(252, 243)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entrega"
        '
        'lbdias
        '
        Me.lbdias.AutoSize = True
        Me.lbdias.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lbdias.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbdias.Location = New System.Drawing.Point(169, 211)
        Me.lbdias.Name = "lbdias"
        Me.lbdias.Size = New System.Drawing.Size(30, 12)
        Me.lbdias.TabIndex = 69
        Me.lbdias.Text = "Dias"
        '
        'mskHoraEntrega
        '
        Me.mskHoraEntrega.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHoraEntrega.Location = New System.Drawing.Point(93, 212)
        Me.mskHoraEntrega.Mask = "00:00:00"
        Me.mskHoraEntrega.Name = "mskHoraEntrega"
        Me.mskHoraEntrega.Size = New System.Drawing.Size(70, 23)
        Me.mskHoraEntrega.TabIndex = 13
        Me.mskHoraEntrega.ValidatingType = GetType(Date)
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(13, 25)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 196)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Data"
        '
        'mskDataEntrega
        '
        Me.mskDataEntrega.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.mskDataEntrega.Location = New System.Drawing.Point(13, 212)
        Me.mskDataEntrega.Mask = "00/00/0000"
        Me.mskDataEntrega.Name = "mskDataEntrega"
        Me.mskDataEntrega.Size = New System.Drawing.Size(74, 20)
        Me.mskDataEntrega.TabIndex = 8
        Me.mskDataEntrega.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(90, 196)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Hora"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblPreco)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 506)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 67)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preço final previsto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 26)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(150, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "R$"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.ForeColor = System.Drawing.Color.Green
        Me.lblPreco.Location = New System.Drawing.Point(189, 35)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(97, 18)
        Me.lblPreco.TabIndex = 0
        Me.lblPreco.Text = "00.000,00"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(844, 55)
        Me.ToolStrip1.TabIndex = 64
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.TCC.My.Resources.Resources._1362336579_Save
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(737, 555)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 18)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "Nº"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.Location = New System.Drawing.Point(776, 555)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(56, 18)
        Me.lblCod.TabIndex = 66
        Me.lblCod.Text = "------"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.lbltanque)
        Me.GroupBox5.Controls.Add(Me.cbSeguro)
        Me.GroupBox5.Controls.Add(Me.LinkLabel1)
        Me.GroupBox5.Controls.Add(Me.ProgressBar1)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.txtkmatual)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.listAcessorios)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.txtMarca)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtplacacarro)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtanocarro)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.txtmodelo)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtcategoria)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtcodcarro)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.lblCarros)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.Location = New System.Drawing.Point(542, 73)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(290, 427)
        Me.GroupBox5.TabIndex = 67
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Carro"
        '
        'lbltanque
        '
        Me.lbltanque.AutoSize = True
        Me.lbltanque.Location = New System.Drawing.Point(195, 299)
        Me.lbltanque.Name = "lbltanque"
        Me.lbltanque.Size = New System.Drawing.Size(38, 18)
        Me.lbltanque.TabIndex = 20
        Me.lbltanque.Text = "???"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LinkLabel1.Location = New System.Drawing.Point(195, 397)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 16)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Obervações"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(153, 273)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(131, 23)
        Me.ProgressBar1.Step = 5
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 18
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label26.Location = New System.Drawing.Point(150, 230)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 16)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Combustível"
        '
        'txtkmatual
        '
        Me.txtkmatual.Enabled = False
        Me.txtkmatual.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtkmatual.Location = New System.Drawing.Point(198, 184)
        Me.txtkmatual.Name = "txtkmatual"
        Me.txtkmatual.Size = New System.Drawing.Size(67, 23)
        Me.txtkmatual.TabIndex = 16
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label25.Location = New System.Drawing.Point(195, 165)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 16)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "KM Atual"
        '
        'listAcessorios
        '
        Me.listAcessorios.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.listAcessorios.FormattingEnabled = True
        Me.listAcessorios.ItemHeight = 16
        Me.listAcessorios.Location = New System.Drawing.Point(11, 246)
        Me.listAcessorios.Name = "listAcessorios"
        Me.listAcessorios.Size = New System.Drawing.Size(120, 164)
        Me.listAcessorios.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label24.Location = New System.Drawing.Point(8, 219)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 16)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "Acessórios"
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtMarca.Location = New System.Drawing.Point(11, 184)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(169, 23)
        Me.txtMarca.TabIndex = 12
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label23.Location = New System.Drawing.Point(8, 165)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 16)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Marca"
        '
        'txtplacacarro
        '
        Me.txtplacacarro.Enabled = False
        Me.txtplacacarro.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtplacacarro.Location = New System.Drawing.Point(179, 52)
        Me.txtplacacarro.Name = "txtplacacarro"
        Me.txtplacacarro.Size = New System.Drawing.Size(86, 23)
        Me.txtplacacarro.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label22.Location = New System.Drawing.Point(137, 57)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 16)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Placa"
        '
        'txtanocarro
        '
        Me.txtanocarro.Enabled = False
        Me.txtanocarro.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtanocarro.Location = New System.Drawing.Point(198, 136)
        Me.txtanocarro.Name = "txtanocarro"
        Me.txtanocarro.Size = New System.Drawing.Size(67, 23)
        Me.txtanocarro.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label21.Location = New System.Drawing.Point(195, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 16)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Ano"
        '
        'txtmodelo
        '
        Me.txtmodelo.Enabled = False
        Me.txtmodelo.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtmodelo.Location = New System.Drawing.Point(11, 136)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(169, 23)
        Me.txtmodelo.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label20.Location = New System.Drawing.Point(8, 117)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Modelo"
        '
        'txtcategoria
        '
        Me.txtcategoria.Enabled = False
        Me.txtcategoria.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtcategoria.Location = New System.Drawing.Point(85, 85)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(180, 23)
        Me.txtcategoria.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label8.Location = New System.Drawing.Point(8, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Categoria"
        '
        'txtcodcarro
        '
        Me.txtcodcarro.Enabled = False
        Me.txtcodcarro.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtcodcarro.Location = New System.Drawing.Point(85, 54)
        Me.txtcodcarro.Name = "txtcodcarro"
        Me.txtcodcarro.Size = New System.Drawing.Size(46, 23)
        Me.txtcodcarro.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.Label4.Location = New System.Drawing.Point(6, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cód.Carro"
        '
        'lblCarros
        '
        Me.lblCarros.AutoSize = True
        Me.lblCarros.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblCarros.Location = New System.Drawing.Point(6, 26)
        Me.lblCarros.Name = "lblCarros"
        Me.lblCarros.Size = New System.Drawing.Size(98, 16)
        Me.lblCarros.TabIndex = 0
        Me.lblCarros.TabStop = True
        Me.lblCarros.Text = "Ir para carros"
        '
        'lbErro
        '
        Me.lbErro.AutoSize = True
        Me.lbErro.BackColor = System.Drawing.Color.Transparent
        Me.lbErro.ForeColor = System.Drawing.Color.Red
        Me.lbErro.Location = New System.Drawing.Point(539, 517)
        Me.lbErro.Name = "lbErro"
        Me.lbErro.Size = New System.Drawing.Size(29, 13)
        Me.lbErro.TabIndex = 68
        Me.lbErro.Text = " Erro"
        '
        'picAGL
        '
        Me.picAGL.BackColor = System.Drawing.Color.Transparent
        Me.picAGL.Image = Global.TCC.My.Resources.Resources.bannersite
        Me.picAGL.Location = New System.Drawing.Point(641, 0)
        Me.picAGL.Name = "picAGL"
        Me.picAGL.Size = New System.Drawing.Size(203, 82)
        Me.picAGL.TabIndex = 78
        Me.picAGL.TabStop = False
        '
        'frmNovoAluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(844, 593)
        Me.Controls.Add(Me.picAGL)
        Me.Controls.Add(Me.lbErro)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNovoAluguel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novo Aluguel"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents mskHoraRetirada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mskDataRetirada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSeguro As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txthab As System.Windows.Forms.TextBox
    Friend WithEvents txtdatanasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcondutor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents txtnomecli As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtrg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents mskDataEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPreco As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents txtcathab As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcodcarro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCarros As System.Windows.Forms.LinkLabel
    Friend WithEvents txtanocarro As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtplacacarro As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents listAcessorios As System.Windows.Forms.ListBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtkmatual As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbltanque As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbErro As System.Windows.Forms.Label
    Friend WithEvents mskHoraEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbdias As System.Windows.Forms.Label
    Friend WithEvents picAGL As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
