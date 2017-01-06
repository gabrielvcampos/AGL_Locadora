Imports System.Data.SqlClient
Public Class FrmConsultaCliente

    Dim cn As New conexaosql
    Dim mr As SqlDataReader
    Dim TipoTelefone As String = Nothing
    Dim str As String
    Public Sub CarregaTelefoneCliente()
        For Each lvItem As ListViewItem In frmCliente.listTel.Items
            lvItem.Remove()
        Next
        frmCliente.txttipotel.Visible = False
        frmCliente.txttipotel2.Visible = False
        frmCliente.txtnumtel.Visible = False
        frmCliente.txtnumtel2.Visible = False
        frmCliente.listTel.Visible = True
        str = "exec sp_consultatelcliente @Cod_Cli = " & DataGrid.CurrentRow.Cells(0).Value & ""
        cn.FechaConexaoSejaAberta()

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = str
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If
            frmCliente.listTel.CheckBoxes = False
            frmCliente.listTel.FullRowSelect = True
            Dim listagem As New ListViewItem
            While mr.Read
                If mr!Cod_Tipo_Tel = "1" Then
                    TipoTelefone = "Residencial"
                ElseIf mr!Cod_Tipo_Tel = "2" Then
                    TipoTelefone = "Celular"
                ElseIf mr!Cod_Tipo_Tel = "3" Then
                    TipoTelefone = "Comercial"
                ElseIf mr!Cod_Tipo_Tel = "4" Then
                    TipoTelefone = "Outro"
                End If
                listagem = frmCliente.listTel.Items.Add(mr!Telefone)
                listagem.SubItems.Add(TipoTelefone)
                frmCliente.txtformatrat.Text = mr!Forma_Tratamento
            End While
            cn.cnn.Close()
            Call ArmazenaTelefones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cn.cnn.Close()
        End Try
        'mr.Close()

    End Sub
    Public Sub ArmazenaTelefones()
        Dim contador As Integer = 0
        cn.FechaConexaoSejaAberta()

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = str
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If

            While mr.Read
                contador = contador + 1
                If mr!Cod_Tipo_Tel = "1" Then
                    TipoTelefone = "Residencial"
                ElseIf mr!Cod_Tipo_Tel = "2" Then
                    TipoTelefone = "Celular"
                ElseIf mr!Cod_Tipo_Tel = "3" Then
                    TipoTelefone = "Comercial"
                ElseIf mr!Cod_Tipo_Tel = "4" Then
                    TipoTelefone = "Outro"
                End If
                Telefones(contador - 1) = mr!Telefone
                Tipo_Telefones(contador - 1) = TipoTelefone
                CodTelefoneCli(contador) = mr!Cod_Tel_Cli
            End While

            cn.cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cn.cnn.Close()
        End Try
        'MsgBox("Valor 1: " & Telefones(0) & "     Valor2: " & Telefones(1))
        cn.cnn.Close()
    End Sub
    Public Sub CarregaDadosCliente()

        Dim str As String = "exec sp_ConsultaCliente @Cod_Cli = " & DataGrid.CurrentRow.Cells(0).Value & ""
        cn.FechaConexaoSejaAberta()

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = str
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If
            If mr.HasRows = True Then
                frmCliente.txtcodcli.Text = mr!Cod_Cli
                frmCliente.txtnomecli.Text = mr!NomeCompleto_Cli
                If mr!Sexo_Cli = "M" Then
                    frmCliente.txtsexocli.Text = "Masculino"
                ElseIf mr!Sexo_Cli = "F" Then
                    frmCliente.txtsexocli.Text = "Feminino"
                End If
                frmCliente.DateTimePicker1.Text = mr!DataNasc_Cli
                frmCliente.txtcpfcli.Text = mr!CPF_Cli
                frmCliente.txtrgcli.Text = mr!RG_Cli
                frmCliente.txthabcli.Text = mr!Habilitacao
                frmCliente.txtcathabcli.Text = mr!Cat_CNH
                frmCliente.txtnaccli.Text = mr!Nacionalidade_Cli
                frmCliente.txtlogracli.Text = mr!Logradouro_Cli
                frmCliente.txtnumcasa.Text = mr!NumCasa_Cli
                frmCliente.txtcompl.Text = mr!Complemento_Cli
                frmCliente.txtbairro.Text = mr!Bairro_Cli
                frmCliente.txtcidade.Text = mr!Cidade_Cli
                frmCliente.txtestado.Text = mr!Estado_Cli
                frmCliente.txtcepcli.Text = mr!CEP_Cli
                frmCliente.txtemail.Text = mr!Email
                frmCliente.PictureBox1.ImageLocation = mr!CaminhoFotoCli
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        Call CarregaTelefoneCliente()
        Me.Close()
    End Sub
    Public Sub CarregaDadosClienteAluguel()
        Dim str As String = "exec sp_ConsultaCliente @Cod_Cli = " & DataGrid.CurrentRow.Cells(0).Value & ""
        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = str
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If
            If mr.HasRows = True Then
                frmNovoAluguel.txtcod.Text = mr!Cod_Cli
                frmNovoAluguel.txtnomecli.Text = mr!NomeCompleto_Cli
                frmNovoAluguel.txtrg.Text = mr!RG_Cli
                frmNovoAluguel.txthab.Text = mr!Habilitacao
                frmNovoAluguel.txtcathab.Text = mr!Cat_CNH
                frmNovoAluguel.txtcondutor.Text = mr!NomeCompleto_Cli
                frmNovoAluguel.txtdatanasc.Text = mr!DataNasc_Cli
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        Call CarregaTelefoneCliente()
        Me.Close()
    End Sub


    Private Sub DataGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick

        If FormAberto = False Then
            Call CarregaDadosCliente()
        ElseIf FormAberto = True Then
            Call CarregaDadosClienteAluguel()
        End If

    End Sub

    Private Sub FrmConsultaCliente_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Application.OpenForms.OfType(Of frmCliente)().Count() > 0 Then
            VarConsulta_Aluguel = False
        End If
    End Sub
End Class