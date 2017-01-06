Imports System.Data.SqlClient
Public Class frmBuscarCarros
    Dim cn As New conexaosql
    Dim CodCarro As String
    Public Sub CarregaCategorias() 'Carrega categorias disponíveis em listCategorias
        Dim mr As SqlDataReader

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Cod_Cat,Nome_Cat from TB_Categoria"
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

    Private Sub frmBuscarCarros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CarregaCategorias()
        If frmNovoAluguel.txtcod.Text = "" Or frmNovoAluguel.txtnomecli.Text = Nothing Then
            MessageBox.Show("Selecione um cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub
    'Carrega Carros disponíveis por categoria
    Private Sub ListCategorias_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListCategorias.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "exec sp_ExibeCarrosDeCategoria @Cod_Cat = " & ListCategorias.SelectedIndex + 1
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cn.cmd
            da.Fill(dt)
            da.Dispose()       '  libera recursos ou melhora a performance  
            DataGridCarros.DataSource = dt        ' dt1 name do datagrid
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
    'Ao clicar, carrega dados do carro pro form de aluguel
    Private Sub DataGridCarros_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridCarros.CellDoubleClick
        Dim mr As SqlDataReader
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select dbo.Tb_carro.Cod_Carro,dbo.Tb_carro.Placa,dbo.TB_Carro.Modelo,dbo.TB_Carro.Marca,dbo.TB_Carro.Ano,dbo.TB_Categoria.Nome_Cat,dbo.TB_Carro.Cod_Cat,dbo.Tb_Tipo_Combustivel.Descricao as 'Combustivel' from Tb_Carro, Tb_Categoria,Tb_Tipo_Combustivel where" _
                                & " Tb_Carro.Cod_Cat = Tb_Categoria.Cod_Cat and Tb_Carro.Cod_Tipo_Combus = Tb_Tipo_Combustivel.Cod_Tipo_Combus and tb_Carro.Placa = '" & DataGridCarros.CurrentRow.Cells(0).Value & "'"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) Then
                cn.cnn.Close()
                Exit Sub
            End If
            frmNovoAluguel.txtcodcarro.Text = mr!Cod_Carro
            CodCarro = mr!Cod_Carro
            frmNovoAluguel.txtplacacarro.Text = mr!Placa
            frmNovoAluguel.txtcategoria.Text = mr!Nome_cat
            frmNovoAluguel.txtmodelo.Text = mr!Modelo
            frmNovoAluguel.txtanocarro.Text = mr!Ano
            frmNovoAluguel.txtMarca.Text = mr!Marca
            CodCategoria = mr!Cod_Cat
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        Call CarregaAcessorios()
        Call CarregaHistoricoCarro()
        Me.Close()
    End Sub
    'carrega acessorios na list de acessróiosdpkapodmamda do form aluguem
    Public Sub CarregaAcessorios()
        Dim mr As SqlDataReader
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "exec SelecionaAcessoriosCarros @Cod_Carro = " & CodCarro
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) Then
                cn.cnn.Close()
            End If
            While mr.Read
                frmNovoAluguel.listAcessorios.Items.Add(mr!Descricao_Acess)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
    'carrega os historicos pro form do aluguldlakw
    Public Sub CarregaHistoricoCarro()
        Dim mr As SqlDataReader = Nothing
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "SELECT [Hodometro_Final] " _
                & ",[Qtde_Combus_Atual]" _
                & ",[Observacoes]" _
                & "FROM [DB_Locadora].[dbo].[TB_Historico_Carro] where Cod_Carro = " & CodCarro
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If mr.HasRows = False Then
                MessageBox.Show("Carro não possui histórico cadastrado. Cadastre antes de continuar.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cn.cnn.Close()
                frmHistoricoCarro.txtcodcarro.Text = CodCarro
                frmHistoricoCarro.txtcodcarro.Enabled = False
                frmHistoricoCarro.txtcodaluguel.Text = frmNovoAluguel.lblCod.Text
                frmHistoricoCarro.txtcodaluguel.Enabled = False
                frmHistoricoCarro.Show()
                Exit Sub
            End If
            frmNovoAluguel.txtkmatual.Text = mr!Hodometro_Final
            frmNovoAluguel.lbltanque.Text = mr!Qtde_Combus_Atual
            ObsCarro = mr!Observacoes
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Call DefineValorTanque(mr!Qtde_Combus_Atual)
        cn.cnn.Close()
    End Sub

    Public Sub DefineValorTanque(ByVal FracaoTanque As String)
        Dim mr As SqlDataReader
        If cn.cnn.State = ConnectionState.Open Then
            cn.cnn.Close()
        End If
        cn.cnn.Open()
        Try
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select Valor from TB_ValoresCombustivel where Fracao = '" & FracaoTanque & "'"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            If IsDBNull(mr) Then
                Exit Sub
            Else
                For Each DataRow In mr
                    frmNovoAluguel.ProgressBar1.Value = CInt(mr!Valor)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class