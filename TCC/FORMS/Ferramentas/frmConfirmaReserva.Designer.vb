<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmaReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmaReserva))
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReserva = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMensagem
        '
        Me.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensagem.Enabled = False
        Me.txtMensagem.Location = New System.Drawing.Point(89, 57)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(323, 105)
        Me.txtMensagem.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(89, 31)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(323, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(89, 5)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(323, 20)
        Me.txtNome.TabIndex = 2
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblemail.Location = New System.Drawing.Point(36, 32)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(47, 16)
        Me.lblemail.TabIndex = 3
        Me.lblemail.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(33, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(0, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mensagem:"
        '
        'btnReserva
        '
        Me.btnReserva.BackColor = System.Drawing.Color.LightGray
        Me.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserva.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnReserva.Location = New System.Drawing.Point(277, 168)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(135, 23)
        Me.btnReserva.TabIndex = 6
        Me.btnReserva.Text = "Confirmar Reserva"
        Me.btnReserva.UseVisualStyleBackColor = False
        '
        'frmConfirmaReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(417, 192)
        Me.Controls.Add(Me.btnReserva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtMensagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfirmaReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReserva As System.Windows.Forms.Button
End Class
