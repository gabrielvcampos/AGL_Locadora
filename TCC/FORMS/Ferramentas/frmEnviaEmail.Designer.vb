<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnviaEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnviaEmail))
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtcc = New System.Windows.Forms.TextBox()
        Me.lblcc = New System.Windows.Forms.Label()
        Me.picAGL = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMensagem
        '
        Me.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensagem.Location = New System.Drawing.Point(15, 196)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(445, 263)
        Me.txtMensagem.TabIndex = 13
        '
        'txtAssunto
        '
        Me.txtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAssunto.Location = New System.Drawing.Point(96, 145)
        Me.txtAssunto.Multiline = True
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(364, 19)
        Me.txtAssunto.TabIndex = 12
        '
        'txtPara
        '
        Me.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPara.Location = New System.Drawing.Point(96, 98)
        Me.txtPara.Multiline = True
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(364, 19)
        Me.txtPara.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Assunto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Para:"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Green
        Me.btnEnviar.Image = Global.TCC.My.Resources.Resources._1362339684_Forward
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(360, 465)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 34)
        Me.btnEnviar.TabIndex = 8
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnFechar.Image = Global.TCC.My.Resources.Resources._1362339990_Delete
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(254, 465)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(100, 34)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'txtcc
        '
        Me.txtcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcc.Location = New System.Drawing.Point(96, 122)
        Me.txtcc.Multiline = True
        Me.txtcc.Name = "txtcc"
        Me.txtcc.Size = New System.Drawing.Size(364, 19)
        Me.txtcc.TabIndex = 14
        '
        'lblcc
        '
        Me.lblcc.AutoSize = True
        Me.lblcc.BackColor = System.Drawing.Color.Transparent
        Me.lblcc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcc.Location = New System.Drawing.Point(51, 120)
        Me.lblcc.Name = "lblcc"
        Me.lblcc.Size = New System.Drawing.Size(39, 19)
        Me.lblcc.TabIndex = 15
        Me.lblcc.Text = "CC:"
        '
        'picAGL
        '
        Me.picAGL.BackColor = System.Drawing.Color.Transparent
        Me.picAGL.Image = Global.TCC.My.Resources.Resources.bannersite
        Me.picAGL.Location = New System.Drawing.Point(254, 10)
        Me.picAGL.Name = "picAGL"
        Me.picAGL.Size = New System.Drawing.Size(203, 82)
        Me.picAGL.TabIndex = 78
        Me.picAGL.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 44)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Envia Email"
        '
        'FrmEnviaEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(477, 504)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picAGL)
        Me.Controls.Add(Me.lblcc)
        Me.Controls.Add(Me.txtcc)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.txtAssunto)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnFechar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEnviaEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-mail"
        CType(Me.picAGL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents txtAssunto As System.Windows.Forms.TextBox
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtcc As System.Windows.Forms.TextBox
    Friend WithEvents lblcc As System.Windows.Forms.Label
    Friend WithEvents picAGL As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
