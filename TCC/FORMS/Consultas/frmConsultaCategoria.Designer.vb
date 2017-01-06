<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaCategoria))
        Me.ListCategorias = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListCategorias
        '
        Me.ListCategorias.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.ListCategorias.FormattingEnabled = True
        Me.ListCategorias.ItemHeight = 16
        Me.ListCategorias.Location = New System.Drawing.Point(15, 28)
        Me.ListCategorias.Name = "ListCategorias"
        Me.ListCategorias.Size = New System.Drawing.Size(205, 132)
        Me.ListCategorias.TabIndex = 3
        '
        'frmConsultaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(237, 181)
        Me.Controls.Add(Me.ListCategorias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaCategoria"
        Me.Text = "Categorias"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListCategorias As System.Windows.Forms.ListBox
End Class
