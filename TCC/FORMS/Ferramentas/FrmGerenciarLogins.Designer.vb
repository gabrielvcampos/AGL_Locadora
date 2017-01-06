<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGerenciarLogins
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGerenciarLogins))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAltera = New System.Windows.Forms.ToolStripButton()
        Me.btngrava = New System.Windows.Forms.ToolStripButton()
        Me.btnPesquisa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtnomefunc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lberro = New System.Windows.Forms.Label()
        Me.txtconfirmarsenha = New System.Windows.Forms.TextBox()
        Me.txtnovasenha = New System.Windows.Forms.TextBox()
        Me.txtsenhaatual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbadm = New System.Windows.Forms.RadioButton()
        Me.rbuser = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.btnAltera, Me.btngrava, Me.ToolStripButton2, Me.btnPesquisa, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(278, 55)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cod."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nome"
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(9, 95)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(26, 20)
        Me.txtcod.TabIndex = 10
        '
        'txtnomefunc
        '
        Me.txtnomefunc.Location = New System.Drawing.Point(56, 95)
        Me.txtnomefunc.Name = "txtnomefunc"
        Me.txtnomefunc.Size = New System.Drawing.Size(185, 20)
        Me.txtnomefunc.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lberro)
        Me.GroupBox1.Controls.Add(Me.txtconfirmarsenha)
        Me.GroupBox1.Controls.Add(Me.txtnovasenha)
        Me.GroupBox1.Controls.Add(Me.txtsenhaatual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 155)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Senha"
        '
        'lberro
        '
        Me.lberro.AutoSize = True
        Me.lberro.Font = New System.Drawing.Font("Verdana", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lberro.ForeColor = System.Drawing.Color.Red
        Me.lberro.Location = New System.Drawing.Point(6, 136)
        Me.lberro.Name = "lberro"
        Me.lberro.Size = New System.Drawing.Size(15, 13)
        Me.lberro.TabIndex = 15
        Me.lberro.Text = "x"
        '
        'txtconfirmarsenha
        '
        Me.txtconfirmarsenha.Location = New System.Drawing.Point(115, 81)
        Me.txtconfirmarsenha.Name = "txtconfirmarsenha"
        Me.txtconfirmarsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txtconfirmarsenha.Size = New System.Drawing.Size(100, 23)
        Me.txtconfirmarsenha.TabIndex = 14
        '
        'txtnovasenha
        '
        Me.txtnovasenha.Location = New System.Drawing.Point(115, 49)
        Me.txtnovasenha.Name = "txtnovasenha"
        Me.txtnovasenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txtnovasenha.Size = New System.Drawing.Size(100, 23)
        Me.txtnovasenha.TabIndex = 13
        '
        'txtsenhaatual
        '
        Me.txtsenhaatual.Location = New System.Drawing.Point(115, 14)
        Me.txtsenhaatual.Name = "txtsenhaatual"
        Me.txtsenhaatual.Size = New System.Drawing.Size(100, 23)
        Me.txtsenhaatual.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Confirmar senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(33, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nova Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(73, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Atual"
        '
        'rbadm
        '
        Me.rbadm.AutoSize = True
        Me.rbadm.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbadm.Location = New System.Drawing.Point(0, 21)
        Me.rbadm.Name = "rbadm"
        Me.rbadm.Size = New System.Drawing.Size(105, 17)
        Me.rbadm.TabIndex = 14
        Me.rbadm.TabStop = True
        Me.rbadm.Text = "Administrador"
        Me.rbadm.UseVisualStyleBackColor = True
        '
        'rbuser
        '
        Me.rbuser.AutoSize = True
        Me.rbuser.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbuser.Location = New System.Drawing.Point(115, 21)
        Me.rbuser.Name = "rbuser"
        Me.rbuser.Size = New System.Drawing.Size(68, 17)
        Me.rbuser.TabIndex = 15
        Me.rbuser.TabStop = True
        Me.rbuser.Text = "Usuário"
        Me.rbuser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbuser)
        Me.GroupBox2.Controls.Add(Me.rbadm)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 50)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de acesso"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.TCC.My.Resources.Resources.delete_page
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton2.Text = "ToolStripButton2"
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
        'FrmGerenciarLogins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(295, 342)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnomefunc)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmGerenciarLogins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciador de logins"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAltera As System.Windows.Forms.ToolStripButton
    Friend WithEvents btngrava As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPesquisa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents txtnomefunc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lberro As System.Windows.Forms.Label
    Friend WithEvents txtsenhaatual As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbadm As System.Windows.Forms.RadioButton
    Friend WithEvents rbuser As System.Windows.Forms.RadioButton
    Friend WithEvents txtconfirmarsenha As System.Windows.Forms.TextBox
    Friend WithEvents txtnovasenha As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
