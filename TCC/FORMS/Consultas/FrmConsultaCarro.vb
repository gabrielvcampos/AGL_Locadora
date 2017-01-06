Imports System.Data.SqlClient
Public Class FrmConsultaCarro
    Dim cn As New conexaosql
    Dim objcarro As New ClsCarro
    Public Sub ConsultaCarro()
        Dim cn As New conexaosql
        Dim mr As SqlDataReader
        Dim str As String

        str = "select * from TB_Carro where Cod_Carro = '" & DataGridCarro.CurrentRow.Cells(0).Value() & "'"
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
                MsgBox("Nenhum valor encontrado!")
                Exit Sub
            End If

            If mr.HasRows = True Then
                frmCarro.txtcodcarro.Text = DataGridCarro.CurrentRow.Cells(0).Value()
            End If
            Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        frmCarro.lstCategoria.SelectedIndex = DataGridCarro.CurrentRow.Cells(1).Value() - 1
        frmCarro.txtplaca.Text = DataGridCarro.CurrentRow.Cells(2).Value()
        frmCarro.txtmodelo.Text = DataGridCarro.CurrentRow.Cells(3).Value()
        frmCarro.txtCor.Text = DataGridCarro.CurrentRow.Cells(4).Value()
        frmCarro.txtmarca.Text = DataGridCarro.CurrentRow.Cells(5).Value()
        frmCarro.txtdatafabr.Text = DataGridCarro.CurrentRow.Cells(6).Value()
        frmCarro.txttipocombus.Text = DataGridCarro.CurrentRow.Cells(7).Value()
        frmCarro.txtrenavam.Text = DataGridCarro.CurrentRow.Cells(8).Value()
        frmCarro.txtchassi.Text = DataGridCarro.CurrentRow.Cells(9).Value()
        frmCarro.txtano.Text = DataGridCarro.CurrentRow.Cells(10).Value()

        Select Case DataGridCarro.CurrentRow.Cells(11).Value()
            Case "1"
                frmCarro.rbDisp.Checked = True
            Case "2"
                frmCarro.rbAlugado.Checked = True
            Case "3"
                frmCarro.rbManu.Checked = True
            Case "4"
                frmCarro.rbBloqueado.Checked = True
            Case "5"
                frmCarro.rbPrep.Checked = True
            Case "6"
                frmCarro.rbRoubado.Checked = True
            Case "7"
                frmCarro.rbAVenda.Checked = True
            Case "8"
                frmCarro.rbVend.Checked = True
            Case "9"
                frmCarro.rbReserv.Checked = True
        End Select
        Select Case DataGridCarro.CurrentRow.Cells(12).Value()
            Case "0"
                frmCarro.rbAtivo.Checked = True
                frmCarro.rbInativo.Checked = False
            Case "1"
                frmCarro.rbAtivo.Checked = False
                frmCarro.rbInativo.Checked = True
        End Select
        If IsDBNull(DataGridCarro.CurrentRow.Cells(13).Value()) = False Then
            frmCarro.picCarro.ImageLocation = DataGridCarro.CurrentRow.Cells(13).Value()
        End If
        cn.cnn.Close()
        Call consultarAcessorios(DataGridCarro.CurrentRow.Cells(0).Value())

        Me.Close()
    End Sub

    Sub consultarAcessorios(ByVal CodCarro As Short)
        frmCarro.ListBox1.Items.Clear()
        Try
            cn.FechaConexaoSejaAberta()
            cn.conexaoon()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Tb_Acessorios_Carro.Cod_Acess,Tb_Acessorios.Descricao_Acess " _
                    & "from Tb_Acessorios_Carro inner join Tb_Acessorios " _
                    & " on Tb_Acessorios_Carro.Cod_Acess = Tb_Acessorios.Cod_Acess where Tb_Acessorios_Carro.Cod_Carro = " & CodCarro
                .ExecuteNonQuery()
            End With
            Dim mr As SqlDataReader = cn.cmd.ExecuteReader

            If IsDBNull(mr) = False Then
                While mr.Read
                    frmCarro.ListBox1.Items.Add(mr!Descricao_Acess)
                    frmCarro.ListBox1.Enabled = False
                    frmCarro.Button2.Enabled = False
                    frmCarro.Button3.Enabled = False
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub DataGridCarro_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridCarro.CellDoubleClick
        Call ConsultaCarro()
    End Sub

End Class