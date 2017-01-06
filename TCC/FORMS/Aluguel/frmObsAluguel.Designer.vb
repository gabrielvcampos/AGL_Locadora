<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObsAluguel
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
        Me.txtobscarro = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtobscarro
        '
        Me.txtobscarro.Enabled = False
        Me.txtobscarro.Location = New System.Drawing.Point(1, -1)
        Me.txtobscarro.Name = "txtobscarro"
        Me.txtobscarro.Size = New System.Drawing.Size(394, 100)
        Me.txtobscarro.TabIndex = 0
        Me.txtobscarro.Text = ""
        '
        'frmObsAluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 101)
        Me.Controls.Add(Me.txtobscarro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmObsAluguel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observações"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtobscarro As System.Windows.Forms.RichTextBox
End Class
