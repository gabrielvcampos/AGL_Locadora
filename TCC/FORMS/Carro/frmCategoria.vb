Imports System.Data.SqlClient

Public Class frmCategoria
    Dim ObjControle As New ClsComando
    Dim objCarro As New ClsCarro
    Dim cn As New conexaosql
    Dim Cod_Acess As Short
    Dim varalter As Boolean = False
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        ' verifica se a função é para alterar ou salvar. Se for alterar, sera o preço, o nome e a letra
        If varalter = False Then
            Call inserir()
        ElseIf varalter = True Then
            Call Alterar()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        frmConsultaCategoria.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        ObjControle.Limpar_tela(groupInfo)
        ObjControle.Limpar_tela(groupAcess)
        txtcodcat.Text = CShort(cn.getIdentCurrent("TB_Categoria")) + 1


        For Each controle As Control In Me.groupInfo.Controls
            If TypeOf controle Is TextBox Then
                controle.Enabled = True
            End If
            If TypeOf controle Is MaskedTextBox Then
                controle.Enabled = True
            End If
            If TypeOf controle Is ListBox Then
                controle.Enabled = True
            End If
            If TypeOf controle Is Button Then
                controle.Enabled = True
            End If
        Next
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        varalter = True
        For Each controle As Control In Me.groupInfo.Controls
            If TypeOf controle Is TextBox Then
                controle.Enabled = True
            End If
            If TypeOf controle Is MaskedTextBox Then
                controle.Enabled = True
            End If
            If TypeOf controle Is ListBox Then
                controle.Enabled = True
            End If
        Next
    End Sub
    Sub Alterar()
        cn.FechaConexaoSejaAberta()
        cn.conexaoon()
        Try
            With cn.cmd

                .Connection = cn.cnn
                .CommandText = "update  Tb_Categoria set Nome_cat = '" & txtnomecat.Text _
                    & "',  Diaria = " & txtprecodiaria.Text _
                    & ", Dia_extra = " & txtprecodiaextra.Text & " where Cod_Cat = " & txtcodcat.Text
                .ExecuteNonQuery()
            End With
            'Call AlterarAcessorios(txtcodcat.Text)
            MsgBox("Alterado com sucesso.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.conexaooff()
    End Sub
    
    Private Sub InsereOsAcessoriosDaCategoria()
        Dim x As Integer
        Dim s As String = ""
        For x = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(x).ToString = "Ar Condicionado" Then
                objCarro.InserirAcessoriosCategoria(1)
            End If

            If ListBox1.Items(x).ToString = "Ar Condicionado" Then
                objCarro.InserirAcessoriosCategoria(1)
            ElseIf ListBox1.Items(x).ToString = "Roda Liga Leve" Then
                objCarro.InserirAcessoriosCategoria(2)
            ElseIf ListBox1.Items(x).ToString = "Basico" Then
                objCarro.InserirAcessoriosCategoria(3)
            ElseIf ListBox1.Items(x).ToString = "Teto Solar" Then
                objCarro.InserirAcessoriosCategoria(4)
            ElseIf ListBox1.Items(x).ToString = "Tração 4x4" Then
                objCarro.InserirAcessoriosCategoria(5)
            ElseIf ListBox1.Items(x).ToString = "Banco de Couro" Then
                objCarro.InserirAcessoriosCategoria(6)
            ElseIf ListBox1.Items(x).ToString = "CD Player" Then
                objCarro.InserirAcessoriosCategoria(7)
            ElseIf ListBox1.Items(x).ToString = "DVD Player" Then
                objCarro.InserirAcessoriosCategoria(8)
            ElseIf ListBox1.Items(x).ToString = "Som adicional" Then
                objCarro.InserirAcessoriosCategoria(9)
            ElseIf ListBox1.Items(x).ToString = "Freio ABS" Then
                objCarro.InserirAcessoriosCategoria(10)
            ElseIf ListBox1.Items(x).ToString = "GPS" Then
                objCarro.InserirAcessoriosCategoria(11)
            ElseIf ListBox1.Items(x).ToString = "AirBags" Then
                objCarro.InserirAcessoriosCategoria(12)
            End If
        Next x
    End Sub
    Sub inserir()
        cn.FechaConexaoSejaAberta()
        cn.conexaoon()
        Try
            With cn.cmd

                .Connection = cn.cnn
                .CommandText = "insert into Tb_Categoria(Nome_cat,Diaria,Dia_extra,Letra_Cat) values ('" & txtnomecat.Text _
                    & "', " & txtprecodiaria.Text _
                    & ", " & txtprecodiaextra.Text _
                    & ", '" & txtletra.Text & "')"
                .ExecuteNonQuery()
            End With
            InsereOsAcessoriosDaCategoria()
            MsgBox("Inserido com sucesso.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.conexaooff()
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtcodcat.Text = CShort(cn.getIdentCurrent("TB_Categoria")) + 1
        txtcodcat.Enabled = False
        txtletra.Text = ""
    End Sub


    Private Sub txtcodcat_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcodcat.TextChanged
        '  objCarro.CarregaAcessoriosDacategoria(txtcodcat.Text, True)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmConsultaAcessoriosCategoria.Show()
        varForm = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
    Sub DefineCOdAcess(ByVal DescAcess As String)
        Select Case DescAcess
            Case "Ar condicionado"
                Cod_Acess = 1
            Case "Roda Liga Leve"
                Cod_Acess = 2
            Case "Basico"
                Cod_Acess = 3
            Case "Teto Solar"
                Cod_Acess = 4
            Case "Tração 4x4"
                Cod_Acess = 5
            Case "Banco de Couro"
                Cod_Acess = 6
            Case "CD Player"
                Cod_Acess = 7
            Case "DVD Player"
                Cod_Acess = 8
            Case "Som adicional"
                Cod_Acess = 9
            Case "Freio ABS"
                Cod_Acess = 10
            Case "GPS"
                Cod_Acess = 11
            Case "AirBags"
                Cod_Acess = 12

        End Select
    End Sub











    'Sub AlterarAcessorios(ByVal codcat As Short)

    '    Call VerificaExclusaoDeAcessorios(codcat)
    '    Try
    '        cn.FechaConexaoSejaAberta()
    '        cn.conexaoon()
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandText = " select TB_Acessorios_Categoria.Cod_Acess,Tb_Acessorios.Descricao_Acess from Tb_Acessorios_Categoria " _
    '                & "inner join Tb_Acessorios on Tb_Acessorios_Categoria.Cod_Acess = Tb_Acessorios.Cod_Acess" _
    '                & " where Tb_Acessorios_Categoria.Cod_Cat = " & codcat
    '            .ExecuteNonQuery()
    '        End With
    '        Dim da As New SqlDataAdapter
    '        Dim dt As New DataTable
    '        da.SelectCommand = cn.cmd
    '        da.Fill(dt)
    '        da.Dispose()
    '        If IsDBNull(dt) = False Then
    '            For x = 0 To ListBox1.Items.Count - 1
    '                For Each row As DataRow In dt.Rows
    '                    If ListBox1.Items(x).ToString = dt.Rows(x)("Descricao_Acess").ToString() Then
    '                    Else
    '                        DefineCOdAcess(dt.Rows(x)("Descricao_Acess").ToString())
    '                        objCarro.InserirAcessoriosCategoria(Cod_Acess)
    '                    End If
    '                Next
    '            Next x
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    cn.conexaooff()
    'End Sub
    'Sub VerificaExclusaoDeAcessorios(ByVal CodCat As Short)
    '    Try
    '        cn.FechaConexaoSejaAberta()
    '        cn.conexaoon()
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandText = " select TB_Acessorios_Categoria.Cod_Acess,Tb_Acessorios.Descricao_Acess from Tb_Acessorios_Categoria " _
    '                & "inner join Tb_Acessorios on Tb_Acessorios_Categoria.Cod_Acess = Tb_Acessorios.Cod_Acess" _
    '                & " where Tb_Acessorios_Categoria.Cod_Cat = " & CodCat
    '            .ExecuteNonQuery()
    '        End With

    '        Dim da As New SqlDataAdapter
    '        Dim dt As New DataTable
    '        da.SelectCommand = cn.cmd
    '        da.Fill(dt)
    '        da.Dispose()

    '        If IsDBNull(dt) = False Then
    '            For x = 0 To ListBox1.Items.Count - 1
    '                If ListBox1.Items(x).ToString = dt.Rows(x)("Descricao_Acess").ToString() Then
    '                Else
    '                    Call ExcluiAcessorio(dt.Rows(x)("Descricao_Acess").ToString(), CodCat)
    '                End If
    '            Next x
    '        End If

    '    Catch ex As SqlException
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub
    'Sub ExcluiAcessorio(ByVal DescAcess As String, ByVal Codcat As Short)

    '    Call DefineCOdAcess(DescAcess)

    '    cn.FechaConexaoSejaAberta()
    '    cn.conexaoon()
    '    Try
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandText = " delete from Tb_Acessorios_Categoria where Cod_Acess = " & Cod_Acess & " and Cod_cat = " & Codcat
    '            .ExecuteNonQuery()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

   
End Class