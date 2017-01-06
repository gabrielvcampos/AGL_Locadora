<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckprog = New System.Windows.Forms.CheckBox()
        Me.ckfechados = New System.Windows.Forms.CheckBox()
        Me.btnGerar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbSemana = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.txtdata2 = New System.Windows.Forms.MaskedTextBox()
        Me.rbAno = New System.Windows.Forms.RadioButton()
        Me.txtdata1 = New System.Windows.Forms.MaskedTextBox()
        Me.rbCustom = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carro"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 72)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exibir atualizações"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ckprog)
        Me.GroupBox2.Controls.Add(Me.ckfechados)
        Me.GroupBox2.Location = New System.Drawing.Point(283, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(289, 139)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opções"
        '
        'ckprog
        '
        Me.ckprog.AutoSize = True
        Me.ckprog.Location = New System.Drawing.Point(8, 63)
        Me.ckprog.Margin = New System.Windows.Forms.Padding(4)
        Me.ckprog.Name = "ckprog"
        Me.ckprog.Size = New System.Drawing.Size(277, 18)
        Me.ckprog.TabIndex = 13
        Me.ckprog.Text = "Exibir somente aluguéis em progresso"
        Me.ckprog.UseVisualStyleBackColor = True
        '
        'ckfechados
        '
        Me.ckfechados.AutoSize = True
        Me.ckfechados.Location = New System.Drawing.Point(8, 30)
        Me.ckfechados.Margin = New System.Windows.Forms.Padding(4)
        Me.ckfechados.Name = "ckfechados"
        Me.ckfechados.Size = New System.Drawing.Size(246, 18)
        Me.ckfechados.TabIndex = 12
        Me.ckfechados.Text = "Exibir somente aluguéis fechados"
        Me.ckfechados.UseVisualStyleBackColor = True
        '
        'btnGerar
        '
        Me.btnGerar.Location = New System.Drawing.Point(283, 189)
        Me.btnGerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(132, 52)
        Me.btnGerar.TabIndex = 15
        Me.btnGerar.Text = "Gerar relatório"
        Me.btnGerar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnGerar)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.rbSemana)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rbMes)
        Me.GroupBox3.Controls.Add(Me.txtdata2)
        Me.GroupBox3.Controls.Add(Me.rbAno)
        Me.GroupBox3.Controls.Add(Me.txtdata1)
        Me.GroupBox3.Controls.Add(Me.rbCustom)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(580, 297)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aluguéis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Exibir aluguéis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Até"
        '
        'rbSemana
        '
        Me.rbSemana.AutoSize = True
        Me.rbSemana.BackColor = System.Drawing.Color.Transparent
        Me.rbSemana.Location = New System.Drawing.Point(12, 64)
        Me.rbSemana.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSemana.Name = "rbSemana"
        Me.rbSemana.Size = New System.Drawing.Size(118, 18)
        Me.rbSemana.TabIndex = 2
        Me.rbSemana.TabStop = True
        Me.rbSemana.Text = "Desta semana"
        Me.rbSemana.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 228)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "De"
        '
        'rbMes
        '
        Me.rbMes.AutoSize = True
        Me.rbMes.BackColor = System.Drawing.Color.Transparent
        Me.rbMes.Location = New System.Drawing.Point(12, 105)
        Me.rbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(94, 18)
        Me.rbMes.TabIndex = 3
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Deste mês"
        Me.rbMes.UseVisualStyleBackColor = False
        '
        'txtdata2
        '
        Me.txtdata2.Location = New System.Drawing.Point(68, 251)
        Me.txtdata2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdata2.Mask = "00/00/0000"
        Me.txtdata2.Name = "txtdata2"
        Me.txtdata2.Size = New System.Drawing.Size(132, 22)
        Me.txtdata2.TabIndex = 7
        Me.txtdata2.ValidatingType = GetType(Date)
        '
        'rbAno
        '
        Me.rbAno.AutoSize = True
        Me.rbAno.BackColor = System.Drawing.Color.Transparent
        Me.rbAno.Location = New System.Drawing.Point(12, 151)
        Me.rbAno.Margin = New System.Windows.Forms.Padding(4)
        Me.rbAno.Name = "rbAno"
        Me.rbAno.Size = New System.Drawing.Size(91, 18)
        Me.rbAno.TabIndex = 4
        Me.rbAno.TabStop = True
        Me.rbAno.Text = "Deste ano"
        Me.rbAno.UseVisualStyleBackColor = False
        '
        'txtdata1
        '
        Me.txtdata1.Location = New System.Drawing.Point(68, 219)
        Me.txtdata1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdata1.Mask = "00/00/0000"
        Me.txtdata1.Name = "txtdata1"
        Me.txtdata1.Size = New System.Drawing.Size(132, 22)
        Me.txtdata1.TabIndex = 6
        Me.txtdata1.ValidatingType = GetType(Date)
        '
        'rbCustom
        '
        Me.rbCustom.AutoSize = True
        Me.rbCustom.BackColor = System.Drawing.Color.Transparent
        Me.rbCustom.Location = New System.Drawing.Point(12, 191)
        Me.rbCustom.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCustom.Name = "rbCustom"
        Me.rbCustom.Size = New System.Drawing.Size(183, 18)
        Me.rbCustom.TabIndex = 5
        Me.rbCustom.TabStop = True
        Me.rbCustom.Text = "De uma data específica:"
        Me.rbCustom.UseVisualStyleBackColor = False
        '
        'frmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(606, 433)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmRelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatorios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckprog As System.Windows.Forms.CheckBox
    Friend WithEvents ckfechados As System.Windows.Forms.CheckBox
    Friend WithEvents btnGerar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbSemana As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents txtdata2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbAno As System.Windows.Forms.RadioButton
    Friend WithEvents txtdata1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbCustom As System.Windows.Forms.RadioButton
End Class
