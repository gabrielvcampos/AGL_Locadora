Imports System.Data.SqlClient
Public Class frmConsultaAluguel
    Dim cn As New conexaosql
    Dim mr As SqlDataReader
    Dim CodCarro As Short
    'STRING QUE SELECIONA ALUGUEL EM PROGRESSO REFERENTE AO NOME DO CLIENTE INFORMADO


    Public Sub CarregaDados()
        Dim QueryAluguelEmProgresso As String = "SELECT Tb_cliente.Cod_Cli,TB_Cliente.NomeCompleto_Cli,TB_Cliente.RG_Cli,TB_Cliente.DataNasc_Cli, TB_Cliente.Habilitacao,TB_Cliente.Cat_CNH," _
& " TB_Aluguel.Cod_Carro,TB_Aluguel.Condutor_Principal,TB_Aluguel.Cod_Aluguel,TB_Aluguel.Data_Retirada,TB_Aluguel.Cod_seguro,TB_Aluguel.Data_Entrega,TB_Aluguel.HoraRetirada,TB_Aluguel.HoraEntrega,TB_Aluguel.condicao_Entrega," _
& " TB_Aluguel.Preco_Final,TB_Aluguel.Status_Aluguel,TB_Carro.Placa,TB_Carro.Modelo,TB_Carro.Ano,TB_Carro.Marca,TB_Categoria.Nome_Cat, " _
& " TB_Historico_Carro.Hodometro_inicial,TB_Historico_Carro.Hodometro_final,TB_Carro.Cod_Cat, TB_Historico_Carro.Qtde_Combus_Atual,TB_Historico_Carro.Observacoes from " _
& "TB_Cliente,TB_Aluguel,TB_Carro,TB_Historico_Carro,TB_Categoria" _
& " where " _
& " Tb_Cliente.Cod_Cli = TB_Aluguel.Cod_Cli" _
& " and" _
& " TB_Carro.Cod_Carro = TB_Aluguel.Cod_Carro" _
& " and" _
& " TB_Carro.Cod_Carro = TB_Historico_Carro.Cod_Carro" _
& " and" _
& " TB_Carro.Cod_Cat = TB_Categoria.Cod_Cat" _
& "  and" _
& "  TB_Aluguel.Cod_Aluguel = " & DataGridAluguel.CurrentRow.Cells(0).Value & ""

        cn.FechaConexaoSejaAberta()
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = QueryAluguelEmProgresso
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr) = True Then
                MsgBox("Valor não encontrado")
                Exit Sub
            End If
            If mr.HasRows = True Then
                With frmFinalizaAluguel
                    .txtcod.Text = mr!Cod_Cli
                    .txtnomecli.Text = mr!NomeCompleto_Cli
                    .txtcondutor.Text = mr!Condutor_Principal
                    .txtrg.Text = mr!RG_Cli
                    .txtdatanasc.Text = mr!DataNasc_Cli
                    .txthab.Text = mr!Habilitacao
                    .txtcathab.Text = mr!Cat_CNH

                    'conversão de datas
                    .DateTimePicker1.Text = mr!Data_Retirada
                    .DateTimePicker2.Text = mr!Data_Entrega
                    DataEntrega = mr!Data_Entrega


                    .mskHoraEntrega.Text = mr!HoraEntrega
                    .mskHoraRetirada.Text = mr!HoraRetirada
                    HoraEntrega = mr!HoraEntrega

                    .txtcodcarro.Text = mr!Cod_Carro
                    CodCarro = mr!Cod_Carro
                    CodCategoria = mr!Cod_Cat
                    .txtplacacarro.Text = mr!Placa
                    .txtcategoria.Text = mr!Nome_Cat
                    .txtmodelo.Text = mr!Modelo
                    .txtanocarro.Text = mr!Ano
                    .txtMarca.Text = mr!Marca
                    .txthodretirada.Text = mr!Hodometro_Final
                    .lblPreco.Text = Format(mr!Preco_Final, "00.00")
                    PrecoPrevisto = Format(mr!Preco_Final, "00.00")
                    .lblCod.Text = mr!Cod_Aluguel
                    If mr!Cod_seguro = "1" Then
                        .cbSeguro.Checked = True
                    End If
                    Select Case mr!Status_Aluguel
                        Case "PENDENTE"
                            .rbPendente.Checked = True
                        Case "EM PROGRESSO"
                            .rbProgresso.Checked = True
                        Case "FECHADO"
                            .rbFechado.Checked = True
                    End Select
                    .txtobs.Text = mr!Observacoes
                    Call DefineValorTanque(mr!Qtde_Combus_Atual)
                    Select Case .ProgressBar1.Value
                        Case 0
                            frmFinalizaAluguel.lbltanque.Text = 0
                        Case 25
                            frmFinalizaAluguel.lbltanque.Text = "1/4"
                        Case 50
                            frmFinalizaAluguel.lbltanque.Text = "1/2"
                        Case 75
                            frmFinalizaAluguel.lbltanque.Text = "3/4"
                        Case 100
                            frmFinalizaAluguel.lbltanque.Text = "1/1"
                    End Select
                    For Each Control As Control In .Controls
                        If TypeOf Control Is TextBox Then
                            Control.Enabled = False
                        End If
                        If TypeOf Control Is CheckBox Then
                            Control.Enabled = False
                        End If
                        If TypeOf Control Is DateTimePicker Then
                            Control.Enabled = False
                        End If
                        If TypeOf Control Is Label Then
                        End If
                    Next

                    .txtnomecli.Enabled = True
                    .DateTimePicker2.Enabled = True
                    .mskHoraEntrega.Enabled = True
                    .txthodatual.Enabled = True
                    .txtobs.Enabled = True
                    .DateTimePicker1.Enabled = False
                    .mskHoraRetirada.Enabled = False
                    .cbSeguro.Enabled = False
                End With
            End If
            Call CarregaAcessorios()

            
          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        Me.Close()
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
                    frmFinalizaAluguel.ProgressBar1.Value = CInt(mr!Valor)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridAluguel_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAluguel.CellDoubleClick
        Call CarregaDados()
    End Sub

    Public Sub CarregaAcessorios()
        frmFinalizaAluguel.listAcessorios.Items.Clear()
        cn.FechaConexaoSejaAberta()
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
                frmFinalizaAluguel.listAcessorios.Items.Add(mr!Descricao_Acess)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub
End Class