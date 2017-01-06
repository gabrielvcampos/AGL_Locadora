Imports System.Data.SqlClient
Public Class frmConsultaCategoria
    Dim cn As New conexaosql

    Public Sub CarregaCategorias() 'Carrega categorias disponíveis em listCategorias
        Dim mr As SqlDataReader

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select * from TB_Categoria"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) Then
                cn.cnn.Close()
                Exit Sub
            Else
                For Each DataRow In mr
                    ListCategorias.Items.Add(mr!Nome_Cat)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()

    End Sub

    Private Sub ListCategorias_DoubleClick(sender As Object, e As System.EventArgs) Handles ListCategorias.DoubleClick
        cn.FechaConexaoSejaAberta()
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select * from TB_Categoria where Cod_Cat = " & ListCategorias.SelectedIndex + 1
                .ExecuteNonQuery()
            End With

            Dim mr As SqlDataReader = cn.cmd.ExecuteReader
            mr.Read()

            frmCategoria.txtcodcat.Text = mr!Cod_Cat
            frmCategoria.txtnomecat.Text = mr!Nome_Cat
            'desabilita as masks dos campos de preço pra nao exibir de forma errada
            frmCategoria.txtprecodiaextra.Mask = ""
            frmCategoria.txtprecodiaextra.Mask = ""
            ' exibe os preços formatando o local do ponto
            frmCategoria.txtprecodiaria.Text = Format(CDbl(mr!Diaria), "##.##")
            frmCategoria.txtprecodiaextra.Text = Format(CDbl(mr!Dia_Extra), "##.##")
            frmCategoria.txtletra.Text = mr!Letra_Cat
            Call consultarAcessorios(mr!Cod_Cat)
            For Each controle As Control In frmCategoria.groupInfo.Controls
                If TypeOf controle Is TextBox Then
                    controle.Enabled = False
                End If
                If TypeOf controle Is MaskedTextBox Then
                    controle.Enabled = False

                End If
                If TypeOf controle Is ListBox Then
                    controle.Enabled = False

                End If
            Next
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()


    End Sub
    Sub consultarAcessorios(ByVal CodCat As Short)
        frmCategoria.ListBox1.Items.Clear()
        Try
            cn.FechaConexaoSejaAberta()
            cn.conexaoon()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Tb_Acessorios_Categoria.Cod_Acess,Tb_Acessorios.Descricao_Acess " _
                    & "from Tb_Acessorios_Categoria inner join Tb_Acessorios " _
                    & " on Tb_Acessorios_Categoria.Cod_Acess = Tb_Acessorios.Cod_Acess where Tb_Acessorios_Categoria.Cod_Cat = " & CodCat
                .ExecuteNonQuery()
            End With
            Dim mr As SqlDataReader = cn.cmd.ExecuteReader

            If IsDBNull(mr) = False Then
                While mr.Read
                    frmCategoria.ListBox1.Items.Add(mr!Descricao_Acess)
                    frmCategoria.Button1.Enabled = False
                    frmCategoria.Button3.Enabled = False
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmConsultaCategoria_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call CarregaCategorias()
    End Sub
End Class