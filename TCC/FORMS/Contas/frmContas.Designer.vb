<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContas))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbNaoPaga = New System.Windows.Forms.RadioButton()
        Me.rbPaga = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblnomeConta = New System.Windows.Forms.Label()
        Me.DTVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTPagamento = New System.Windows.Forms.DateTimePicker()
        Me.lbErro = New System.Windows.Forms.Label()
        Me.txtValorPAgo = New System.Windows.Forms.MaskedTextBox()
        Me.txtvalorConta = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.picNPaga = New System.Windows.Forms.PictureBox()
        Me.picPaga = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picNPaga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(232, 55)
        Me.ToolStrip1.TabIndex = 8
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
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(59, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 16)
        Me.Label15.TabIndex = 214
        Me.Label15.Text = "Vencimento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "Status:"
        '
        'rbNaoPaga
        '
        Me.rbNaoPaga.AutoSize = True
        Me.rbNaoPaga.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNaoPaga.Location = New System.Drawing.Point(103, 155)
        Me.rbNaoPaga.Name = "rbNaoPaga"
        Me.rbNaoPaga.Size = New System.Drawing.Size(88, 20)
        Me.rbNaoPaga.TabIndex = 7
        Me.rbNaoPaga.TabStop = True
        Me.rbNaoPaga.Text = "Não Paga"
        Me.rbNaoPaga.UseVisualStyleBackColor = True
        '
        'rbPaga
        '
        Me.rbPaga.AutoSize = True
        Me.rbPaga.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPaga.Location = New System.Drawing.Point(197, 155)
        Me.rbPaga.Name = "rbPaga"
        Me.rbPaga.Size = New System.Drawing.Size(58, 20)
        Me.rbPaga.TabIndex = 8
        Me.rbPaga.TabStop = True
        Me.rbPaga.Text = "Paga"
        Me.rbPaga.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "Data de Pag.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "Valor Pago (R$):"
        '
        'lblnomeConta
        '
        Me.lblnomeConta.AutoSize = True
        Me.lblnomeConta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeConta.Location = New System.Drawing.Point(59, 24)
        Me.lblnomeConta.Name = "lblnomeConta"
        Me.lblnomeConta.Size = New System.Drawing.Size(42, 16)
        Me.lblnomeConta.TabIndex = 220
        Me.lblnomeConta.Text = "Tipo:"
        '
        'DTVencimento
        '
        Me.DTVencimento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTVencimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTVencimento.Location = New System.Drawing.Point(154, 88)
        Me.DTVencimento.Name = "DTVencimento"
        Me.DTVencimento.Size = New System.Drawing.Size(101, 23)
        Me.DTVencimento.TabIndex = 5
        Me.DTVencimento.Value = New Date(2012, 7, 23, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(-68, -14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(-58, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 16)
        Me.Label11.TabIndex = 224
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(-28, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 16)
        Me.Label12.TabIndex = 225
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(-36, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(-70, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 16)
        Me.Label14.TabIndex = 228
        Me.Label14.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DTPagamento)
        Me.GroupBox1.Controls.Add(Me.lbErro)
        Me.GroupBox1.Controls.Add(Me.txtValorPAgo)
        Me.GroupBox1.Controls.Add(Me.txtvalorConta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbMes)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.picNPaga)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.picPaga)
        Me.GroupBox1.Controls.Add(Me.DTVencimento)
        Me.GroupBox1.Controls.Add(Me.lblnomeConta)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbPaga)
        Me.GroupBox1.Controls.Add(Me.rbNaoPaga)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 281)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'DTPagamento
        '
        Me.DTPagamento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPagamento.Location = New System.Drawing.Point(154, 122)
        Me.DTPagamento.Name = "DTPagamento"
        Me.DTPagamento.Size = New System.Drawing.Size(101, 23)
        Me.DTPagamento.TabIndex = 234
        Me.DTPagamento.Value = New Date(2012, 7, 23, 0, 0, 0, 0)
        '
        'lbErro
        '
        Me.lbErro.AutoSize = True
        Me.lbErro.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lbErro.Location = New System.Drawing.Point(6, 253)
        Me.lbErro.Name = "lbErro"
        Me.lbErro.Size = New System.Drawing.Size(12, 12)
        Me.lbErro.TabIndex = 233
        Me.lbErro.Text = "*"
        '
        'txtValorPAgo
        '
        Me.txtValorPAgo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorPAgo.Location = New System.Drawing.Point(176, 221)
        Me.txtValorPAgo.Name = "txtValorPAgo"
        Me.txtValorPAgo.Size = New System.Drawing.Size(79, 23)
        Me.txtValorPAgo.TabIndex = 10
        '
        'txtvalorConta
        '
        Me.txtvalorConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorConta.ForeColor = System.Drawing.Color.Green
        Me.txtvalorConta.HidePromptOnLeave = True
        Me.txtvalorConta.Location = New System.Drawing.Point(176, 192)
        Me.txtvalorConta.Name = "txtvalorConta"
        Me.txtvalorConta.Size = New System.Drawing.Size(79, 23)
        Me.txtvalorConta.TabIndex = 9
        Me.txtvalorConta.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 16)
        Me.Label9.TabIndex = 232
        Me.Label9.Text = "Valor da Conta(R$):"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"Selecione...", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.cbMes.Location = New System.Drawing.Point(115, 56)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(183, 24)
        Me.cbMes.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 230
        Me.Label7.Text = "Mês:"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(114, 21)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(183, 24)
        Me.cbTipo.TabIndex = 2
        '
        'picNPaga
        '
        Me.picNPaga.Image = CType(resources.GetObject("picNPaga.Image"), System.Drawing.Image)
        Me.picNPaga.Location = New System.Drawing.Point(258, 148)
        Me.picNPaga.Name = "picNPaga"
        Me.picNPaga.Size = New System.Drawing.Size(38, 38)
        Me.picNPaga.TabIndex = 227
        Me.picNPaga.TabStop = False
        Me.picNPaga.Visible = False
        '
        'picPaga
        '
        Me.picPaga.Image = CType(resources.GetObject("picPaga.Image"), System.Drawing.Image)
        Me.picPaga.Location = New System.Drawing.Point(258, 148)
        Me.picPaga.Name = "picPaga"
        Me.picPaga.Size = New System.Drawing.Size(38, 38)
        Me.picPaga.TabIndex = 222
        Me.picPaga.TabStop = False
        Me.picPaga.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cod. Func"
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Location = New System.Drawing.Point(274, 32)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(45, 20)
        Me.txtCodFunc.TabIndex = 1
        '
        'frmContas
        '
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(366, 354)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtCodFunc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picNPaga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbNaoPaga As System.Windows.Forms.RadioButton
    Friend WithEvents rbPaga As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblnomeConta As System.Windows.Forms.Label
    Friend WithEvents DTVencimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents picPaga As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picNPaga As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtvalorConta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtValorPAgo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbErro As System.Windows.Forms.Label
    Friend WithEvents DTPagamento As System.Windows.Forms.DateTimePicker
End Class
