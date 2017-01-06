<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionario))
        Me.groupInfo = New System.Windows.Forms.GroupBox()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.txtsexofunc = New System.Windows.Forms.ComboBox()
        Me.txtdata = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtcargo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUploadFoto = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PicFotoFunc = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.txtNomeFunc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupEnd = New System.Windows.Forms.GroupBox()
        Me.txtCepFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txtestado = New System.Windows.Forms.ComboBox()
        Me.txtcidade = New System.Windows.Forms.TextBox()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.txtcompl = New System.Windows.Forms.TextBox()
        Me.txtnumcasa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtlograFunc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.groupConFunc = New System.Windows.Forms.GroupBox()
        Me.listTel = New System.Windows.Forms.ListView()
        Me.Numero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnumtel2 = New System.Windows.Forms.MaskedTextBox()
        Me.txttipotel2 = New System.Windows.Forms.ComboBox()
        Me.txtnumtel = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txttipotel = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.picAGL = New System.Windows.Forms.PictureBox()
        Me.txtrg = New System.Windows.Forms.MaskedTextBox()
        Me.groupInfo.SuspendLayout()
        CType(Me.PicFotoFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.groupEnd.SuspendLayout()
        Me.groupConFunc.SuspendLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupInfo
        '
        Me.groupInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupInfo.BackColor = System.Drawing.Color.Transparent
        Me.groupInfo.Controls.Add(Me.txtrg)
        Me.groupInfo.Controls.Add(Me.txtcpf)
        Me.groupInfo.Controls.Add(Me.txtsexofunc)
        Me.groupInfo.Controls.Add(Me.txtdata)
        Me.groupInfo.Controls.Add(Me.Label22)
        Me.groupInfo.Controls.Add(Me.txtcargo)
        Me.groupInfo.Controls.Add(Me.Button1)
        Me.groupInfo.Controls.Add(Me.btnUploadFoto)
        Me.groupInfo.Controls.Add(Me.Label11)
        Me.groupInfo.Controls.Add(Me.PicFotoFunc)
        Me.groupInfo.Controls.Add(Me.Label10)
        Me.groupInfo.Controls.Add(Me.Label25)
        Me.groupInfo.Controls.Add(Me.Label12)
        Me.groupInfo.Controls.Add(Me.Label6)
        Me.groupInfo.Controls.Add(Me.Label2)
        Me.groupInfo.Controls.Add(Me.txtCodFunc)
        Me.groupInfo.Controls.Add(Me.txtNomeFunc)
        Me.groupInfo.Controls.Add(Me.Label3)
        Me.groupInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.groupInfo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupInfo.Location = New System.Drawing.Point(12, 76)
        Me.groupInfo.Name = "groupInfo"
        Me.groupInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupInfo.Size = New System.Drawing.Size(704, 218)
        Me.groupInfo.TabIndex = 67
        Me.groupInfo.TabStop = False
        Me.groupInfo.Text = "Informações"
        '
        'txtcpf
        '
        Me.txtcpf.BackColor = System.Drawing.Color.White
        Me.txtcpf.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtcpf.Location = New System.Drawing.Point(6, 92)
        Me.txtcpf.MaxLength = 14
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcpf.Size = New System.Drawing.Size(118, 23)
        Me.txtcpf.TabIndex = 72
        Me.txtcpf.Tag = "CPF"
        '
        'txtsexofunc
        '
        Me.txtsexofunc.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtsexofunc.FormattingEnabled = True
        Me.txtsexofunc.Items.AddRange(New Object() {"Selecione...", "Masculino", "Feminino"})
        Me.txtsexofunc.Location = New System.Drawing.Point(245, 89)
        Me.txtsexofunc.Name = "txtsexofunc"
        Me.txtsexofunc.Size = New System.Drawing.Size(121, 24)
        Me.txtsexofunc.TabIndex = 71
        Me.txtsexofunc.Tag = "sexo"
        Me.txtsexofunc.Text = "Selecione..."
        '
        'txtdata
        '
        Me.txtdata.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtdata.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdata.Location = New System.Drawing.Point(3, 137)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(131, 23)
        Me.txtdata.TabIndex = 70
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 16)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Cód."
        '
        'txtcargo
        '
        Me.txtcargo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtcargo.FormattingEnabled = True
        Me.txtcargo.Location = New System.Drawing.Point(141, 136)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(137, 24)
        Me.txtcargo.TabIndex = 68
        Me.txtcargo.Tag = "cargo"
        Me.txtcargo.Text = "Selecione..."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(569, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 32)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Tirar foto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnUploadFoto
        '
        Me.btnUploadFoto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUploadFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadFoto.ForeColor = System.Drawing.Color.Blue
        Me.btnUploadFoto.Location = New System.Drawing.Point(569, 109)
        Me.btnUploadFoto.Name = "btnUploadFoto"
        Me.btnUploadFoto.Size = New System.Drawing.Size(108, 32)
        Me.btnUploadFoto.TabIndex = 63
        Me.btnUploadFoto.Text = "upload"
        Me.btnUploadFoto.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(508, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Foto"
        '
        'PicFotoFunc
        '
        Me.PicFotoFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicFotoFunc.Location = New System.Drawing.Point(372, 44)
        Me.PicFotoFunc.Name = "PicFotoFunc"
        Me.PicFotoFunc.Size = New System.Drawing.Size(168, 160)
        Me.PicFotoFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFotoFunc.TabIndex = 64
        Me.PicFotoFunc.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(242, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Sexo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(138, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(46, 16)
        Me.Label25.TabIndex = 54
        Me.Label25.Text = "Cargo"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 118)
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
        'txtCodFunc
        '
        Me.txtCodFunc.Enabled = False
        Me.txtCodFunc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodFunc.Location = New System.Drawing.Point(6, 45)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(48, 23)
        Me.txtCodFunc.TabIndex = 26
        '
        'txtNomeFunc
        '
        Me.txtNomeFunc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFunc.Location = New System.Drawing.Point(63, 45)
        Me.txtNomeFunc.Name = "txtNomeFunc"
        Me.txtNomeFunc.Size = New System.Drawing.Size(278, 23)
        Me.txtNomeFunc.TabIndex = 28
        Me.txtNomeFunc.TabStop = False
        Me.txtNomeFunc.Tag = "nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "RG"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(730, 55)
        Me.ToolStrip1.TabIndex = 70
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton5.Text = "btnNovo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton3.Text = "brnalterar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton1.Text = "btnIncluir"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton4.Text = "btnPesquisar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'groupEnd
        '
        Me.groupEnd.BackColor = System.Drawing.Color.Transparent
        Me.groupEnd.Controls.Add(Me.txtCepFunc)
        Me.groupEnd.Controls.Add(Me.txtestado)
        Me.groupEnd.Controls.Add(Me.txtcidade)
        Me.groupEnd.Controls.Add(Me.txtbairro)
        Me.groupEnd.Controls.Add(Me.txtcompl)
        Me.groupEnd.Controls.Add(Me.txtnumcasa)
        Me.groupEnd.Controls.Add(Me.Label8)
        Me.groupEnd.Controls.Add(Me.Label9)
        Me.groupEnd.Controls.Add(Me.Label13)
        Me.groupEnd.Controls.Add(Me.Label14)
        Me.groupEnd.Controls.Add(Me.Label15)
        Me.groupEnd.Controls.Add(Me.Label17)
        Me.groupEnd.Controls.Add(Me.txtlograFunc)
        Me.groupEnd.Controls.Add(Me.Label18)
        Me.groupEnd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupEnd.Location = New System.Drawing.Point(12, 296)
        Me.groupEnd.Name = "groupEnd"
        Me.groupEnd.Size = New System.Drawing.Size(344, 193)
        Me.groupEnd.TabIndex = 72
        Me.groupEnd.TabStop = False
        Me.groupEnd.Text = "Endereço"
        '
        'txtCepFunc
        '
        Me.txtCepFunc.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtCepFunc.Location = New System.Drawing.Point(136, 87)
        Me.txtCepFunc.Mask = "00000-000"
        Me.txtCepFunc.Name = "txtCepFunc"
        Me.txtCepFunc.Size = New System.Drawing.Size(86, 23)
        Me.txtCepFunc.TabIndex = 55
        '
        'txtestado
        '
        Me.txtestado.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtestado.FormattingEnabled = True
        Me.txtestado.Items.AddRange(New Object() {"...", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtestado.Location = New System.Drawing.Point(136, 128)
        Me.txtestado.MaxLength = 2
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(48, 24)
        Me.txtestado.TabIndex = 54
        Me.txtestado.Text = "---"
        '
        'txtcidade
        '
        Me.txtcidade.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcidade.Location = New System.Drawing.Point(13, 128)
        Me.txtcidade.Name = "txtcidade"
        Me.txtcidade.Size = New System.Drawing.Size(113, 23)
        Me.txtcidade.TabIndex = 15
        Me.txtcidade.Tag = "cidade"
        '
        'txtbairro
        '
        Me.txtbairro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbairro.Location = New System.Drawing.Point(236, 87)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(93, 23)
        Me.txtbairro.TabIndex = 14
        Me.txtbairro.Tag = "bairro"
        '
        'txtcompl
        '
        Me.txtcompl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompl.Location = New System.Drawing.Point(13, 86)
        Me.txtcompl.Name = "txtcompl"
        Me.txtcompl.Size = New System.Drawing.Size(118, 23)
        Me.txtcompl.TabIndex = 12
        Me.txtcompl.Tag = "complemento"
        '
        'txtnumcasa
        '
        Me.txtnumcasa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumcasa.Location = New System.Drawing.Point(268, 41)
        Me.txtnumcasa.Name = "txtnumcasa"
        Me.txtnumcasa.Size = New System.Drawing.Size(58, 23)
        Me.txtnumcasa.TabIndex = 11
        Me.txtnumcasa.Tag = "número"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Cidade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(271, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Número"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(131, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Estado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(233, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Bairro"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(136, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 16)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "CEP"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 16)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Logradouro"
        '
        'txtlograFunc
        '
        Me.txtlograFunc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlograFunc.Location = New System.Drawing.Point(10, 41)
        Me.txtlograFunc.Name = "txtlograFunc"
        Me.txtlograFunc.Size = New System.Drawing.Size(250, 23)
        Me.txtlograFunc.TabIndex = 10
        Me.txtlograFunc.Tag = "logradouro"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Complemento"
        '
        'groupConFunc
        '
        Me.groupConFunc.BackColor = System.Drawing.Color.Transparent
        Me.groupConFunc.Controls.Add(Me.listTel)
        Me.groupConFunc.Controls.Add(Me.txtemail)
        Me.groupConFunc.Controls.Add(Me.txtnumtel2)
        Me.groupConFunc.Controls.Add(Me.txttipotel2)
        Me.groupConFunc.Controls.Add(Me.txtnumtel)
        Me.groupConFunc.Controls.Add(Me.Label23)
        Me.groupConFunc.Controls.Add(Me.Label19)
        Me.groupConFunc.Controls.Add(Me.txttipotel)
        Me.groupConFunc.Controls.Add(Me.Label16)
        Me.groupConFunc.Controls.Add(Me.Label20)
        Me.groupConFunc.Controls.Add(Me.Label21)
        Me.groupConFunc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.groupConFunc.Location = New System.Drawing.Point(362, 296)
        Me.groupConFunc.Name = "groupConFunc"
        Me.groupConFunc.Size = New System.Drawing.Size(340, 193)
        Me.groupConFunc.TabIndex = 73
        Me.groupConFunc.TabStop = False
        Me.groupConFunc.Text = "Contato"
        '
        'listTel
        '
        Me.listTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listTel.CheckBoxes = True
        Me.listTel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Numero, Me.Tipo})
        Me.listTel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTel.GridLines = True
        Me.listTel.LabelEdit = True
        Me.listTel.Location = New System.Drawing.Point(6, 24)
        Me.listTel.Name = "listTel"
        Me.listTel.Size = New System.Drawing.Size(305, 91)
        Me.listTel.TabIndex = 74
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
        'txtemail
        '
        Me.txtemail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtemail.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtemail.Location = New System.Drawing.Point(56, 148)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(205, 23)
        Me.txtemail.TabIndex = 64
        Me.txtemail.Tag = "e-mail"
        '
        'txtnumtel2
        '
        Me.txtnumtel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnumtel2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtnumtel2.Location = New System.Drawing.Point(162, 92)
        Me.txtnumtel2.Mask = "(00)0000-0000"
        Me.txtnumtel2.Name = "txtnumtel2"
        Me.txtnumtel2.Size = New System.Drawing.Size(122, 23)
        Me.txtnumtel2.TabIndex = 63
        Me.txtnumtel2.Tag = "número"
        '
        'txttipotel2
        '
        Me.txttipotel2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txttipotel2.FormattingEnabled = True
        Me.txttipotel2.Items.AddRange(New Object() {"Selecione...", "Residencial", "Celular", "Comercial", "Outro"})
        Me.txttipotel2.Location = New System.Drawing.Point(11, 91)
        Me.txttipotel2.Name = "txttipotel2"
        Me.txttipotel2.Size = New System.Drawing.Size(121, 24)
        Me.txttipotel2.TabIndex = 64
        Me.txttipotel2.Tag = "tipo de telefone"
        Me.txttipotel2.Text = "Selecione..."
        '
        'txtnumtel
        '
        Me.txtnumtel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnumtel.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtnumtel.Location = New System.Drawing.Point(161, 45)
        Me.txtnumtel.Mask = "(00)0000-0000"
        Me.txtnumtel.Name = "txtnumtel"
        Me.txtnumtel.Size = New System.Drawing.Size(123, 23)
        Me.txtnumtel.TabIndex = 17
        Me.txtnumtel.Tag = "número"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(127, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 16)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "E-mail"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(6, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 16)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Tipo"
        '
        'txttipotel
        '
        Me.txttipotel.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txttipotel.FormattingEnabled = True
        Me.txttipotel.Items.AddRange(New Object() {"Selecione...", "Residencial", "Celular", "Comercial", "Outro"})
        Me.txttipotel.Location = New System.Drawing.Point(11, 45)
        Me.txttipotel.Name = "txttipotel"
        Me.txttipotel.Size = New System.Drawing.Size(121, 24)
        Me.txttipotel.TabIndex = 18
        Me.txttipotel.Tag = "tipo de telefone"
        Me.txttipotel.Text = "Selecione..."
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(159, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "2º Número"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(6, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 16)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Tipo"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(162, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 16)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Número"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'picAGL
        '
        Me.picAGL.BackColor = System.Drawing.Color.Transparent
        Me.picAGL.Image = Global.TCC.My.Resources.Resources.bannersite
        Me.picAGL.Location = New System.Drawing.Point(527, -2)
        Me.picAGL.Name = "picAGL"
        Me.picAGL.Size = New System.Drawing.Size(203, 82)
        Me.picAGL.TabIndex = 80
        Me.picAGL.TabStop = False
        '
        'txtrg
        '
        Me.txtrg.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtrg.Location = New System.Drawing.Point(130, 92)
        Me.txtrg.Mask = "00,000,000-C"
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(109, 23)
        Me.txtrg.TabIndex = 73
        '
        'frmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(730, 498)
        Me.Controls.Add(Me.picAGL)
        Me.Controls.Add(Me.groupConFunc)
        Me.Controls.Add(Me.groupEnd)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.groupInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionários"
        Me.groupInfo.ResumeLayout(False)
        Me.groupInfo.PerformLayout()
        CType(Me.PicFotoFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupEnd.ResumeLayout(False)
        Me.groupEnd.PerformLayout()
        Me.groupConFunc.ResumeLayout(False)
        Me.groupConFunc.PerformLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFunc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUploadFoto As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PicFotoFunc As System.Windows.Forms.PictureBox
    Friend WithEvents groupEnd As System.Windows.Forms.GroupBox
    Friend WithEvents txtcidade As System.Windows.Forms.TextBox
    Friend WithEvents txtbairro As System.Windows.Forms.TextBox
    Friend WithEvents txtcompl As System.Windows.Forms.TextBox
    Friend WithEvents txtnumcasa As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtlograFunc As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtcargo As System.Windows.Forms.ComboBox
    Friend WithEvents groupConFunc As System.Windows.Forms.GroupBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnumtel2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttipotel2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtnumtel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txttipotel As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsexofunc As System.Windows.Forms.ComboBox
    Friend WithEvents txtcpf As System.Windows.Forms.TextBox
    Friend WithEvents txtestado As System.Windows.Forms.ComboBox
    Friend WithEvents listTel As System.Windows.Forms.ListView
    Friend WithEvents Numero As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtCepFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents picAGL As System.Windows.Forms.PictureBox
    Friend WithEvents txtrg As System.Windows.Forms.MaskedTextBox
End Class
