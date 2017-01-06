<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrLIstaContas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmrLIstaContas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAtualiza = New System.Windows.Forms.Button()
        Me.codfunc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MesReferencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data_Venc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ValorConta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status_Conta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listCOntas = New System.Windows.Forms.ListView()
        Me.Cod_Pagamento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contas cadastradas"
        '
        'BtnAtualiza
        '
        Me.BtnAtualiza.BackColor = System.Drawing.Color.LightGray
        Me.BtnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtualiza.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtualiza.Location = New System.Drawing.Point(447, 9)
        Me.BtnAtualiza.Name = "BtnAtualiza"
        Me.BtnAtualiza.Size = New System.Drawing.Size(141, 23)
        Me.BtnAtualiza.TabIndex = 2
        Me.BtnAtualiza.Text = "Exibir pendentes"
        Me.BtnAtualiza.UseVisualStyleBackColor = False
        '
        'codfunc
        '
        Me.codfunc.Text = "Cód. Func"
        Me.codfunc.Width = 86
        '
        'Descricao
        '
        Me.Descricao.Text = "Nome"
        Me.Descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Descricao.Width = 116
        '
        'MesReferencia
        '
        Me.MesReferencia.Text = "Mes"
        Me.MesReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MesReferencia.Width = 106
        '
        'Data_Venc
        '
        Me.Data_Venc.Text = "Vencimento"
        Me.Data_Venc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Data_Venc.Width = 131
        '
        'ValorConta
        '
        Me.ValorConta.Text = "Valor"
        Me.ValorConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorConta.Width = 102
        '
        'Status_Conta
        '
        Me.Status_Conta.Text = "Status"
        Me.Status_Conta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Status_Conta.Width = 90
        '
        'listCOntas
        '
        Me.listCOntas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listCOntas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Cod_Pagamento, Me.codfunc, Me.Descricao, Me.MesReferencia, Me.Data_Venc, Me.ValorConta, Me.Status_Conta})
        Me.listCOntas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listCOntas.FullRowSelect = True
        Me.listCOntas.GridLines = True
        Me.listCOntas.Location = New System.Drawing.Point(3, 47)
        Me.listCOntas.Name = "listCOntas"
        Me.listCOntas.Size = New System.Drawing.Size(732, 196)
        Me.listCOntas.TabIndex = 0
        Me.listCOntas.UseCompatibleStateImageBehavior = False
        Me.listCOntas.View = System.Windows.Forms.View.Details
        '
        'Cod_Pagamento
        '
        Me.Cod_Pagamento.Text = "Cód. Conta"
        Me.Cod_Pagamento.Width = 99
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(594, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exibir pagas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'fmrLIstaContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 246)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAtualiza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listCOntas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmrLIstaContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAtualiza As System.Windows.Forms.Button
    Friend WithEvents codfunc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Descricao As System.Windows.Forms.ColumnHeader
    Friend WithEvents MesReferencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Data_Venc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValorConta As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status_Conta As System.Windows.Forms.ColumnHeader
    Friend WithEvents listCOntas As System.Windows.Forms.ListView
    Friend WithEvents Cod_Pagamento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
