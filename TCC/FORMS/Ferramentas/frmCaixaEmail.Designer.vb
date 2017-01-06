<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixaEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaixaEmail))
        Me.lstReserva = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mensagem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnReserva = New System.Windows.Forms.Button()
        Me.btnContato = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstReserva
        '
        Me.lstReserva.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.nome, Me.email, Me.Mensagem})
        Me.lstReserva.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lstReserva.FullRowSelect = True
        Me.lstReserva.GridLines = True
        Me.lstReserva.Location = New System.Drawing.Point(12, 48)
        Me.lstReserva.Name = "lstReserva"
        Me.lstReserva.Size = New System.Drawing.Size(742, 231)
        Me.lstReserva.TabIndex = 0
        Me.lstReserva.UseCompatibleStateImageBehavior = False
        Me.lstReserva.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'nome
        '
        Me.nome.Text = "Nome"
        Me.nome.Width = 175
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.email.Width = 272
        '
        'Mensagem
        '
        Me.Mensagem.Text = "Mensagem"
        Me.Mensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensagem.Width = 220
        '
        'btnReserva
        '
        Me.btnReserva.BackColor = System.Drawing.Color.LightGray
        Me.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserva.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnReserva.Location = New System.Drawing.Point(619, 19)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(135, 23)
        Me.btnReserva.TabIndex = 7
        Me.btnReserva.Text = "Listar reservas"
        Me.btnReserva.UseVisualStyleBackColor = False
        '
        'btnContato
        '
        Me.btnContato.BackColor = System.Drawing.Color.LightGray
        Me.btnContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContato.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnContato.Location = New System.Drawing.Point(478, 19)
        Me.btnContato.Name = "btnContato"
        Me.btnContato.Size = New System.Drawing.Size(135, 23)
        Me.btnContato.TabIndex = 8
        Me.btnContato.Text = "Listar contatos"
        Me.btnContato.UseVisualStyleBackColor = False
        '
        'frmCaixaEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(766, 285)
        Me.Controls.Add(Me.btnContato)
        Me.Controls.Add(Me.btnReserva)
        Me.Controls.Add(Me.lstReserva)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCaixaEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caixa de entrada"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstReserva As System.Windows.Forms.ListView
    Friend WithEvents nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mensagem As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnReserva As System.Windows.Forms.Button
    Friend WithEvents btnContato As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
End Class
