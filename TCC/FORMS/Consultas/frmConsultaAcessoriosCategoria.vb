Imports System.Data.SqlClient
Public Class frmConsultaAcessoriosCategoria
    Dim cn As New conexaosql
    Public Sub CarregaAcessorios() 'Carrega Acessorios disponíveis em listAcessorios
        Dim mr As SqlDataReader
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select * from Tb_Acessorios"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) Then
                cn.cnn.Close()
                Exit Sub
            Else
                For Each DataRow In mr
                    ListAcessorios.Items.Add(mr!Descricao_Acess)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
    Sub CarregaAcessoriosDisponiveisPorCategoria(ByVal codCat As Short)
        Dim mr As SqlDataReader
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = " select TB_Acessorios_Categoria.Cod_Acess,Tb_Acessorios.Descricao_Acess from Tb_Acessorios_Categoria " _
                    & "inner join Tb_Acessorios on Tb_Acessorios_Categoria.Cod_Acess = Tb_Acessorios.Cod_Acess" _
                    & " where Tb_Acessorios_Categoria.Cod_Cat = " & codCat
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) Then
                cn.cnn.Close()
                Exit Sub
            Else
                For Each DataRow In mr

                    ListAcessorios.Items.Add(mr!Descricao_Acess)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
    Private Sub frmConsultaAcessoriosCategoria_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If varForm = False Then
            Call CarregaAcessoriosDisponiveisPorCategoria(frmCarro.lstCategoria.SelectedIndex + 1)
        Else
            Call CarregaAcessorios()
        End If

    End Sub

    Private Sub ListAcessorios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListAcessorios.SelectedIndexChanged
        If varForm = False Then
            'Valida se o acessorio ja foi selecionado
            If frmCarro.ListBox1.Items.Count > 0 Then
                For i = 0 To frmCarro.ListBox1.Items.Count - 1
                    frmCarro.ListBox1.SelectedIndex = i
                    If frmCarro.ListBox1.SelectedItem.ToString = ListAcessorios.SelectedItem Then
                        i = i + 1

                    Else
                        frmCarro.ListBox1.Items.Add(ListAcessorios.SelectedItem)
                    End If
                Next
            Else : frmCarro.ListBox1.Items.Add(ListAcessorios.SelectedItem)
            End If
        Else
            If frmCategoria.ListBox1.Items.Count > 0 Then
                For i = 0 To frmCategoria.ListBox1.Items.Count - 1
                    frmCategoria.ListBox1.SelectedIndex = i
                    If frmCategoria.ListBox1.SelectedItem.ToString = ListAcessorios.SelectedItem Then
                        i = i + 1
                    Else
                        frmCategoria.ListBox1.Items.Add(ListAcessorios.SelectedItem)
                    End If
                Next
            Else : frmCategoria.ListBox1.Items.Add(ListAcessorios.SelectedItem)
            End If
        End If
            Me.Close()
    End Sub
End Class