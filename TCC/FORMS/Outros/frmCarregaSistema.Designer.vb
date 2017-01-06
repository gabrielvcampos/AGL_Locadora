<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarregaSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarregaSistema))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pgb_Splash = New System.Windows.Forms.ProgressBar()
        Me.lbl_Carregando = New System.Windows.Forms.Label()
        Me.Timer_Splash = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TCC.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(597, 302)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'pgb_Splash
        '
        Me.pgb_Splash.Location = New System.Drawing.Point(-1, 340)
        Me.pgb_Splash.Name = "pgb_Splash"
        Me.pgb_Splash.Size = New System.Drawing.Size(623, 17)
        Me.pgb_Splash.TabIndex = 1
        Me.pgb_Splash.UseWaitCursor = True
        '
        'lbl_Carregando
        '
        Me.lbl_Carregando.AutoSize = True
        Me.lbl_Carregando.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Carregando.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Carregando.Location = New System.Drawing.Point(68, 315)
        Me.lbl_Carregando.Name = "lbl_Carregando"
        Me.lbl_Carregando.Size = New System.Drawing.Size(15, 22)
        Me.lbl_Carregando.TabIndex = 2
        Me.lbl_Carregando.Text = "."
        Me.lbl_Carregando.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_Carregando.UseWaitCursor = True
        '
        'Timer_Splash
        '
        Me.Timer_Splash.Interval = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(101, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "AGL Locações de automóveis® Todos os Direitos Reservados"
        Me.Label1.UseWaitCursor = True
        '
        'frmCarregaSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(621, 384)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Carregando)
        Me.Controls.Add(Me.pgb_Splash)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCarregaSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCarregaSistema"
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pgb_Splash As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Carregando As System.Windows.Forms.Label
    Friend WithEvents Timer_Splash As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
