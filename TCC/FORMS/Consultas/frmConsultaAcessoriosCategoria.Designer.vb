<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAcessoriosCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAcessoriosCategoria))
        Me.ListAcessorios = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListAcessorios
        '
        Me.ListAcessorios.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.ListAcessorios.FormattingEnabled = True
        Me.ListAcessorios.ItemHeight = 16
        Me.ListAcessorios.Location = New System.Drawing.Point(16, 24)
        Me.ListAcessorios.Name = "ListAcessorios"
        Me.ListAcessorios.Size = New System.Drawing.Size(205, 132)
        Me.ListAcessorios.TabIndex = 4
        '
        'frmConsultaAcessoriosCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(237, 181)
        Me.Controls.Add(Me.ListAcessorios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaAcessoriosCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acessórios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListAcessorios As System.Windows.Forms.ListBox
End Class
