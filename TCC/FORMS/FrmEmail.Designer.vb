<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmail
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
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Green
        Me.btnEnviar.Image = Global.TCC.My.Resources.Resources._1362339684_Forward
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(361, 424)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 34)
        Me.btnEnviar.TabIndex = 1
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
        Me.btnFechar.Location = New System.Drawing.Point(255, 424)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(100, 34)
        Me.btnFechar.TabIndex = 0
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Para:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Assunto:"
        '
        'txtPara
        '
        Me.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPara.Location = New System.Drawing.Point(97, 48)
        Me.txtPara.Multiline = True
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(364, 28)
        Me.txtPara.TabIndex = 4
        '
        'txtAssunto
        '
        Me.txtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAssunto.Location = New System.Drawing.Point(97, 106)
        Me.txtAssunto.Multiline = True
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(364, 28)
        Me.txtAssunto.TabIndex = 5
        '
        'txtMensagem
        '
        Me.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensagem.Location = New System.Drawing.Point(16, 155)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(445, 263)
        Me.txtMensagem.TabIndex = 6
        '
        'FrmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 475)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.txtAssunto)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnFechar)
        Me.Name = "FrmEmail"
        Me.Text = "FrmEmail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents txtAssunto As System.Windows.Forms.TextBox
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
End Class
