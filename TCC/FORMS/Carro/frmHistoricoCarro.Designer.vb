<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoricoCarro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoricoCarro))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Altera = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcodaluguel = New System.Windows.Forms.TextBox()
        Me.txtcodcarro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtobservacoes = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtatualizacoes = New System.Windows.Forms.TextBox()
        Me.pbar1 = New System.Windows.Forms.ProgressBar()
        Me.pbar2 = New System.Windows.Forms.ProgressBar()
        Me.lblcombus1 = New System.Windows.Forms.Label()
        Me.lblCombus2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrupoHod = New System.Windows.Forms.GroupBox()
        Me.txthodometro2 = New System.Windows.Forms.MaskedTextBox()
        Me.txthodometro1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblnext = New System.Windows.Forms.Label()
        Me.picAGL = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrupoHod.SuspendLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripSeparator1, Me.Altera, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(174, 55)
        Me.ToolStrip1.TabIndex = 7
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
        'Altera
        '
        Me.Altera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Altera.Image = CType(resources.GetObject("Altera.Image"), System.Drawing.Image)
        Me.Altera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Altera.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Altera.Name = "Altera"
        Me.Altera.Size = New System.Drawing.Size(52, 52)
        Me.Altera.Text = "ToolStripButton3"
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(294, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Cód. Aluguel"
        '
        'txtcodaluguel
        '
        Me.txtcodaluguel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodaluguel.Location = New System.Drawing.Point(384, 6)
        Me.txtcodaluguel.Name = "txtcodaluguel"
        Me.txtcodaluguel.Size = New System.Drawing.Size(43, 21)
        Me.txtcodaluguel.TabIndex = 21
        '
        'txtcodcarro
        '
        Me.txtcodcarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcarro.Location = New System.Drawing.Point(384, 33)
        Me.txtcodcarro.Name = "txtcodcarro"
        Me.txtcodcarro.Size = New System.Drawing.Size(43, 21)
        Me.txtcodcarro.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(303, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Cód.  Carro"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtobservacoes)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(645, 131)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Observações"
        '
        'txtobservacoes
        '
        Me.txtobservacoes.Location = New System.Drawing.Point(109, 24)
        Me.txtobservacoes.MaxLength = 150
        Me.txtobservacoes.Name = "txtobservacoes"
        Me.txtobservacoes.Size = New System.Drawing.Size(505, 94)
        Me.txtobservacoes.TabIndex = 26
        Me.txtobservacoes.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Detalhes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Atualizações"
        '
        'txtatualizacoes
        '
        Me.txtatualizacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtatualizacoes.Location = New System.Drawing.Point(384, 60)
        Me.txtatualizacoes.Name = "txtatualizacoes"
        Me.txtatualizacoes.Size = New System.Drawing.Size(43, 21)
        Me.txtatualizacoes.TabIndex = 25
        '
        'pbar1
        '
        Me.pbar1.Location = New System.Drawing.Point(38, 44)
        Me.pbar1.Name = "pbar1"
        Me.pbar1.Size = New System.Drawing.Size(100, 23)
        Me.pbar1.TabIndex = 27
        '
        'pbar2
        '
        Me.pbar2.Location = New System.Drawing.Point(240, 44)
        Me.pbar2.Name = "pbar2"
        Me.pbar2.Size = New System.Drawing.Size(100, 23)
        Me.pbar2.TabIndex = 28
        '
        'lblcombus1
        '
        Me.lblcombus1.AutoSize = True
        Me.lblcombus1.BackColor = System.Drawing.Color.Transparent
        Me.lblcombus1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcombus1.Location = New System.Drawing.Point(68, 70)
        Me.lblcombus1.Name = "lblcombus1"
        Me.lblcombus1.Size = New System.Drawing.Size(22, 18)
        Me.lblcombus1.TabIndex = 29
        Me.lblcombus1.Text = "--"
        '
        'lblCombus2
        '
        Me.lblCombus2.AutoSize = True
        Me.lblCombus2.BackColor = System.Drawing.Color.Transparent
        Me.lblCombus2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombus2.Location = New System.Drawing.Point(261, 70)
        Me.lblCombus2.Name = "lblCombus2"
        Me.lblCombus2.Size = New System.Drawing.Size(22, 18)
        Me.lblCombus2.TabIndex = 30
        Me.lblCombus2.Text = "--"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.pbar1)
        Me.GroupBox2.Controls.Add(Me.lblCombus2)
        Me.GroupBox2.Controls.Add(Me.pbar2)
        Me.GroupBox2.Controls.Add(Me.lblcombus1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(280, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 94)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Combustível"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 44)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(22, 23)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(212, 44)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(22, 23)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(346, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(144, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(237, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Atual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(35, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Antigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "X"
        '
        'GrupoHod
        '
        Me.GrupoHod.BackColor = System.Drawing.Color.Transparent
        Me.GrupoHod.Controls.Add(Me.txthodometro2)
        Me.GrupoHod.Controls.Add(Me.txthodometro1)
        Me.GrupoHod.Controls.Add(Me.Label8)
        Me.GrupoHod.Controls.Add(Me.Label2)
        Me.GrupoHod.Controls.Add(Me.lblnext)
        Me.GrupoHod.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoHod.Location = New System.Drawing.Point(12, 93)
        Me.GrupoHod.Name = "GrupoHod"
        Me.GrupoHod.Size = New System.Drawing.Size(262, 94)
        Me.GrupoHod.TabIndex = 13
        Me.GrupoHod.TabStop = False
        Me.GrupoHod.Text = "Hodômetro"
        '
        'txthodometro2
        '
        Me.txthodometro2.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txthodometro2.Location = New System.Drawing.Point(153, 42)
        Me.txthodometro2.Mask = "000000000"
        Me.txthodometro2.Name = "txthodometro2"
        Me.txthodometro2.Size = New System.Drawing.Size(100, 23)
        Me.txthodometro2.TabIndex = 23
        '
        'txthodometro1
        '
        Me.txthodometro1.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txthodometro1.Location = New System.Drawing.Point(9, 42)
        Me.txthodometro1.Mask = "0000000000"
        Me.txthodometro1.Name = "txthodometro1"
        Me.txthodometro1.Size = New System.Drawing.Size(100, 23)
        Me.txthodometro1.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Anterior"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Atual"
        '
        'lblnext
        '
        Me.lblnext.AutoSize = True
        Me.lblnext.BackColor = System.Drawing.Color.Transparent
        Me.lblnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnext.Location = New System.Drawing.Point(118, 42)
        Me.lblnext.Name = "lblnext"
        Me.lblnext.Size = New System.Drawing.Size(29, 20)
        Me.lblnext.TabIndex = 10
        Me.lblnext.Text = ">>"
        '
        'picAGL
        '
        Me.picAGL.BackColor = System.Drawing.Color.Transparent
        Me.picAGL.Image = Global.TCC.My.Resources.Resources.bannersite
        Me.picAGL.Location = New System.Drawing.Point(461, -2)
        Me.picAGL.Name = "picAGL"
        Me.picAGL.Size = New System.Drawing.Size(203, 82)
        Me.picAGL.TabIndex = 79
        Me.picAGL.TabStop = False
        '
        'frmHistoricoCarro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(661, 330)
        Me.Controls.Add(Me.picAGL)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtatualizacoes)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GrupoHod)
        Me.Controls.Add(Me.txtcodaluguel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtcodcarro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmHistoricoCarro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Histórico"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrupoHod.ResumeLayout(False)
        Me.GrupoHod.PerformLayout()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Altera As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcodaluguel As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcarro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtobservacoes As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtatualizacoes As System.Windows.Forms.TextBox
    Friend WithEvents pbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblcombus1 As System.Windows.Forms.Label
    Friend WithEvents lblCombus2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GrupoHod As System.Windows.Forms.GroupBox
    Friend WithEvents txthodometro2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txthodometro1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblnext As System.Windows.Forms.Label
    Friend WithEvents picAGL As System.Windows.Forms.PictureBox
End Class
