<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndex))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoCarroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarLoginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarNovaContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasAPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaixaDeEnrtradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCarro = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()

        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()

        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ContasToolStripMenuItem, Me.AjudaToolStripMenuItem, Me.EmailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1356, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoaToolStripMenuItem, Me.ToolStripMenuItem1, Me.FerramentasToolStripMenuItem, Me.ToolStripMenuItem3, Me.SairToolStripMenuItem, Me.LoginToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'NovoaToolStripMenuItem
        '
        Me.NovoaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NovoaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoCarroToolStripMenuItem, Me.NovoClienteToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.NovoFuncionárioToolStripMenuItem, Me.AluguelToolStripMenuItem})
        Me.NovoaToolStripMenuItem.Image = CType(resources.GetObject("NovoaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NovoaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoaToolStripMenuItem.Name = "NovoaToolStripMenuItem"
        Me.NovoaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NovoaToolStripMenuItem.Text = "Arquivo"
        Me.NovoaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NovoCarroToolStripMenuItem
        '
        Me.NovoCarroToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NovoCarroToolStripMenuItem.Image = CType(resources.GetObject("NovoCarroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoCarroToolStripMenuItem.Name = "NovoCarroToolStripMenuItem"
        Me.NovoCarroToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NovoCarroToolStripMenuItem.Text = "Carros"
        Me.NovoCarroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NovoClienteToolStripMenuItem
        '
        Me.NovoClienteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NovoClienteToolStripMenuItem.Image = CType(resources.GetObject("NovoClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoClienteToolStripMenuItem.Name = "NovoClienteToolStripMenuItem"
        Me.NovoClienteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NovoClienteToolStripMenuItem.Text = "Clientes"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CategoriasToolStripMenuItem.Image = Global.TCC.My.Resources.Resources._1352643452_Check
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'NovoFuncionárioToolStripMenuItem
        '
        Me.NovoFuncionárioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NovoFuncionárioToolStripMenuItem.Image = CType(resources.GetObject("NovoFuncionárioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoFuncionárioToolStripMenuItem.Name = "NovoFuncionárioToolStripMenuItem"
        Me.NovoFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NovoFuncionárioToolStripMenuItem.Text = "Funcionários"
        '
        'AluguelToolStripMenuItem
        '
        Me.AluguelToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AluguelToolStripMenuItem.Image = CType(resources.GetObject("AluguelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AluguelToolStripMenuItem.Name = "AluguelToolStripMenuItem"
        Me.AluguelToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AluguelToolStripMenuItem.Text = "Aluguel"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 6)
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarLoginsToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.BackupToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.FerramentasToolStripMenuItem.Image = CType(resources.GetObject("FerramentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.FerramentasToolStripMenuItem.Text = "Ferramentas"
        '
        'GerenciarLoginsToolStripMenuItem
        '
        Me.GerenciarLoginsToolStripMenuItem.Name = "GerenciarLoginsToolStripMenuItem"
        Me.GerenciarLoginsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.GerenciarLoginsToolStripMenuItem.Text = "Gerenciar Logins"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RelatórioToolStripMenuItem.Text = "Relatório"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Image = CType(resources.GetObject("BackupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.BackupToolStripMenuItem.Text = "Backup/Restore"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(162, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = Global.TCC.My.Resources.Resources.unlock
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FecharToolStripMenuItem.Image = CType(resources.GetObject("FecharToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.FecharToolStripMenuItem.Text = "Logoff"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarNovaContaToolStripMenuItem, Me.ContasAPagarToolStripMenuItem})
        Me.ContasToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContasToolStripMenuItem.Image = CType(resources.GetObject("ContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.ContasToolStripMenuItem.Text = "Contas"
        '
        'CadastrarNovaContaToolStripMenuItem
        '
        Me.CadastrarNovaContaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CadastrarNovaContaToolStripMenuItem.Image = CType(resources.GetObject("CadastrarNovaContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarNovaContaToolStripMenuItem.Name = "CadastrarNovaContaToolStripMenuItem"
        Me.CadastrarNovaContaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CadastrarNovaContaToolStripMenuItem.Text = "Contas"
        '
        'ContasAPagarToolStripMenuItem
        '
        Me.ContasAPagarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ContasAPagarToolStripMenuItem.Image = CType(resources.GetObject("ContasAPagarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContasAPagarToolStripMenuItem.Name = "ContasAPagarToolStripMenuItem"
        Me.ContasAPagarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ContasAPagarToolStripMenuItem.Text = "Listar contas"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem, Me.SuporteToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjudaToolStripMenuItem.Image = CType(resources.GetObject("AjudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'SuporteToolStripMenuItem
        '
        Me.SuporteToolStripMenuItem.Name = "SuporteToolStripMenuItem"
        Me.SuporteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuporteToolStripMenuItem.Text = "Suporte"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaixaDeEnrtradaToolStripMenuItem, Me.NovoEmailToolStripMenuItem})
        Me.EmailToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailToolStripMenuItem.Image = Global.TCC.My.Resources.Resources.email_ico
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(74, 22)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'CaixaDeEnrtradaToolStripMenuItem
        '
        Me.CaixaDeEnrtradaToolStripMenuItem.Name = "CaixaDeEnrtradaToolStripMenuItem"
        Me.CaixaDeEnrtradaToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CaixaDeEnrtradaToolStripMenuItem.Text = "Caixa de entrada"
        '
        'NovoEmailToolStripMenuItem
        '
        Me.NovoEmailToolStripMenuItem.Name = "NovoEmailToolStripMenuItem"
        Me.NovoEmailToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NovoEmailToolStripMenuItem.Text = "Novo Email"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbData})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1356, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbData
        '
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(34, 17)
        Me.lbData.Text = "00:00"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Image = Global.TCC.My.Resources.Resources.photo_add
        Me.Button1.Location = New System.Drawing.Point(12, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 90)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.TCC.My.Resources.Resources.business_users_add
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(13, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 90)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Funcionários"
        '
        'btnCarro
        '
        Me.btnCarro.BackColor = System.Drawing.Color.Transparent
        Me.btnCarro.Image = Global.TCC.My.Resources.Resources.car1
        Me.btnCarro.Location = New System.Drawing.Point(17, 577)
        Me.btnCarro.Name = "btnCarro"
        Me.btnCarro.Size = New System.Drawing.Size(90, 90)
        Me.btnCarro.TabIndex = 12
        Me.btnCarro.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Image = Global.TCC.My.Resources.Resources._272_64x64
        Me.Button4.Location = New System.Drawing.Point(13, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 90)
        Me.Button4.TabIndex = 14
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Aluguel"
        '
        'Button5
        '
        Me.Button5.Image = Global.TCC.My.Resources.Resources.accept_page
        Me.Button5.Location = New System.Drawing.Point(17, 437)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 90)
        Me.Button5.TabIndex = 18
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Finalizar Aluguel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 558)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Carros"

        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1356, 741)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnCarro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmIndex"
        Me.Text = "Locadora de automóveis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()

        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FerramentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarNovaContaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContasAPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AluguelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCarro As System.Windows.Forms.Button
    Friend WithEvents lbData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GerenciarLoginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RelatórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CaixaDeEnrtradaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoCarroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoFuncionárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem



End Class
