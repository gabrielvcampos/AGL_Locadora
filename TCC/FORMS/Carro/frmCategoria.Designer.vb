<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoria))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupAcess = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupInfo = New System.Windows.Forms.GroupBox()
        Me.txtprecodiaextra = New System.Windows.Forms.MaskedTextBox()
        Me.txtprecodiaria = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtletra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnomecat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodcat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.groupAcess.SuspendLayout()
        Me.groupInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(468, 55)
        Me.ToolStrip1.TabIndex = 6
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
        'groupAcess
        '
        Me.groupAcess.BackColor = System.Drawing.Color.Transparent
        Me.groupAcess.Controls.Add(Me.Button3)
        Me.groupAcess.Controls.Add(Me.ListBox1)
        Me.groupAcess.Controls.Add(Me.Button1)
        Me.groupAcess.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupAcess.Location = New System.Drawing.Point(269, 76)
        Me.groupAcess.Name = "groupAcess"
        Me.groupAcess.Size = New System.Drawing.Size(183, 209)
        Me.groupAcess.TabIndex = 56
        Me.groupAcess.TabStop = False
        Me.groupAcess.Text = "Acessórios"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(95, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 35)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(167, 148)
        Me.ListBox1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'groupInfo
        '
        Me.groupInfo.BackColor = System.Drawing.Color.Transparent
        Me.groupInfo.Controls.Add(Me.txtprecodiaextra)
        Me.groupInfo.Controls.Add(Me.txtprecodiaria)
        Me.groupInfo.Controls.Add(Me.Label3)
        Me.groupInfo.Controls.Add(Me.txtletra)
        Me.groupInfo.Controls.Add(Me.Label2)
        Me.groupInfo.Controls.Add(Me.txtnomecat)
        Me.groupInfo.Controls.Add(Me.Label9)
        Me.groupInfo.Controls.Add(Me.Label5)
        Me.groupInfo.Controls.Add(Me.txtcodcat)
        Me.groupInfo.Controls.Add(Me.Label1)
        Me.groupInfo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupInfo.Location = New System.Drawing.Point(12, 76)
        Me.groupInfo.Name = "groupInfo"
        Me.groupInfo.Size = New System.Drawing.Size(239, 209)
        Me.groupInfo.TabIndex = 55
        Me.groupInfo.TabStop = False
        Me.groupInfo.Text = "Informações"
        '
        'txtprecodiaextra
        '
        Me.txtprecodiaextra.Location = New System.Drawing.Point(110, 126)
        Me.txtprecodiaextra.Name = "txtprecodiaextra"
        Me.txtprecodiaextra.Size = New System.Drawing.Size(80, 27)
        Me.txtprecodiaextra.TabIndex = 59
        '
        'txtprecodiaria
        '
        Me.txtprecodiaria.Location = New System.Drawing.Point(3, 126)
        Me.txtprecodiaria.Name = "txtprecodiaria"
        Me.txtprecodiaria.Size = New System.Drawing.Size(80, 27)
        Me.txtprecodiaria.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Letra"
        '
        'txtletra
        '
        Me.txtletra.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtletra.Location = New System.Drawing.Point(48, 26)
        Me.txtletra.MaxLength = 45
        Me.txtletra.Name = "txtletra"
        Me.txtletra.Size = New System.Drawing.Size(35, 22)
        Me.txtletra.TabIndex = 56
        Me.txtletra.Tag = "marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nome"
        '
        'txtnomecat
        '
        Me.txtnomecat.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomecat.Location = New System.Drawing.Point(8, 69)
        Me.txtnomecat.MaxLength = 45
        Me.txtnomecat.Name = "txtnomecat"
        Me.txtnomecat.Size = New System.Drawing.Size(214, 22)
        Me.txtnomecat.TabIndex = 54
        Me.txtnomecat.Tag = "marca"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(89, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Preço Dia Extra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Preço Diaria"
        '
        'txtcodcat
        '
        Me.txtcodcat.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcat.Location = New System.Drawing.Point(130, 26)
        Me.txtcodcat.Name = "txtcodcat"
        Me.txtcodcat.Size = New System.Drawing.Size(36, 22)
        Me.txtcodcat.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cód."
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(468, 295)
        Me.Controls.Add(Me.groupAcess)
        Me.Controls.Add(Me.groupInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoria"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupAcess.ResumeLayout(False)
        Me.groupInfo.ResumeLayout(False)
        Me.groupInfo.PerformLayout()
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
    Friend WithEvents groupAcess As System.Windows.Forms.GroupBox
    Friend WithEvents groupInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnomecat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcodcat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtletra As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtprecodiaextra As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtprecodiaria As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
