Imports System.Data.SqlClient

Public Class ClsCliente
    'properties para garantir a integridade dos dados do cliente
    Dim cn As New conexaosql
    Dim InsertQuery As String
    Dim cli_nom As String 'Nome do cliente
    Dim cli_sex As String 'sexo do cliente
    Dim cli_nas As String 'Date ' data de nascimento
    Dim cli_cpf As String 'cpf do cliente
    Dim cli_rg As String 'rg do cliente
    Dim cli_cnh As String 'cnh do cliente
    Dim cli_cat_cnh As String
    Dim cli_nac As String
    Dim cli_logra As String 'logradouro do cliente
    Dim cli_numcasa As String 'numcasa do cliente
    Dim cli_compl As String 'complemento do cliente
    Dim cli_bairro As String 'Bairro do cliente
    Dim cli_cid As String 'cidade do cliente
    Dim cli_uf As String 'estado do cliente
    Dim cli_cep As String 'CEP do cliente
    Dim cli_foto As String 'Caminho da foto do cliente
    Dim cli_codtel As String 'telefone do cliente
    Dim PrevCodTel As String 'Ultimo Cod_Tel
    Dim NextCodTel As Short 'Proximo Cod_Tel
    Dim NextCodCli_Tel As Short 'Proximo Cod_Cli - Cod_Tel
    Dim PrevCodCli_Tel As Short 'Ultimo Cod_Cli - Cod_Tel
    Dim NextCodCli As Short 'Proximo Cod_Cli
    Dim PrevCodCLi As String 'Ultimo Cod_Cli inserido
    Dim cli_codtipotel2 As Short ' Codigo do tipo do segundo telefone
    Dim cli_codtipotel As Short 'Codigo do tipo de telefone
    Dim cli_formatrat As String 'Forma de tratamento do cliente
    Dim cli_formatrat2 As String ' segunda forma de tratamento do cliente
    Dim cli_ema As String 'email do cliente
    Dim cli_telefone1 As String 'telefone do cliente
    Dim cli_telefone2 As String ' segundo telefone do cliente
    Dim cli_cod As String ' Código do cliente para inserir na tb tel
    Dim cli_CaminhoFoto As String 'Caminho da foto do cliente no DB
    Public Property Nome_cli() As String
        Get
            Return cli_nom
        End Get
        Set(ByVal value As String)
            cli_nom = value
        End Set
    End Property
    Public Property Sexo_Cli() As String
        Get
            Return cli_sex
        End Get
        Set(ByVal value As String)
            cli_sex = value
        End Set
    End Property
    Public Property DataNasc_Cli() As String 'Date
        Get
            Return cli_nas
        End Get
        Set(ByVal value As String)
            cli_nas = value
        End Set
    End Property
    Public Property CPF_cli() As String
        Get
            Return cli_cpf
        End Get
        Set(ByVal value As String)
            cli_cpf = value
        End Set
    End Property
    Public Property RG_cli() As String
        Get
            Return cli_rg
        End Get
        Set(ByVal value As String)
            cli_rg = value
        End Set
    End Property
    Public Property CNH_Cli() As String
        Get
            Return cli_cnh
        End Get
        Set(ByVal value As String)
            cli_cnh = value
        End Set
    End Property
    Public Property Cat_CNH_Cli() As String
        Get
            Return cli_cat_cnh
        End Get
        Set(ByVal value As String)
            cli_cat_cnh = value
        End Set
    End Property
    Public Property Nac_Cli() As String
        Get
            Return cli_nac
        End Get
        Set(ByVal value As String)
            cli_nac = value
        End Set
    End Property
    Public Property Logra_Cli() As String
        Get
            Return cli_logra
        End Get
        Set(ByVal value As String)
            cli_logra = value
        End Set
    End Property
    Public Property NumCasa_Cli() As String
        Get
            Return cli_numcasa
        End Get
        Set(ByVal value As String)
            cli_numcasa = value
        End Set
    End Property
    Public Property Compl_Cli() As String
        Get
            Return cli_compl
        End Get
        Set(ByVal value As String)
            cli_compl = value
        End Set
    End Property
    Public Property Bairro_Cli() As String
        Get
            Return cli_bairro
        End Get
        Set(ByVal value As String)
            cli_bairro = value
        End Set
    End Property
    Public Property Cidade_Cli() As String
        Get
            Return cli_cid
        End Get
        Set(ByVal value As String)
            cli_cid = value
        End Set
    End Property
    Public Property Estado_cli() As String
        Get
            Return cli_uf
        End Get
        Set(ByVal value As String)
            cli_uf = value
        End Set
    End Property
    Public Property CEP_Cli() As String
        Get
            Return cli_cep
        End Get
        Set(ByVal value As String)
            cli_cep = value
        End Set
    End Property
    Public Property Foto_cli() As String
        Get
            Return cli_foto
        End Get
        Set(ByVal value As String)
            cli_foto = value
        End Set
    End Property
    Public Property Email_Cli() As String
        Get
            Return cli_ema
        End Get
        Set(ByVal value As String)
            cli_ema = value
        End Set
    End Property
    Public Property CodTel_Cli() As String
        Get
            Return cli_codtel
        End Get
        Set(ByVal value As String)
            cli_codtel = value
        End Set
    End Property
    Public Property CaminhoFotoCli() As String
        Get
            Return cli_CaminhoFoto
        End Get
        Set(ByVal value As String)
            cli_CaminhoFoto = value
        End Set
    End Property

    Public Sub InserirCliente()
        '(@NomeCompleto_Cli,@Sexo_Cli,@DataNasc_Cli,@CPF_Cli,@RG_Cli,@Habilitacao,@OrgEmissor_Habi,@NumCasa_Cli,
        '@Complemento_Cli,@Bairro_Cli ,@Cidade_Cli ,@Estado_Cli,@CEP_Cli,@codtelcli )

        'sub que executa a procedure de inserção do cliente
        InsertQuery = "exec sp_cadcli" _
            & " @NomeCompleto_Cli = '" & cli_nom _
            & "', @Sexo_Cli = '" & cli_sex _
            & "', @DataNasc_Cli = '" & cli_nas _
            & "', @CPF_Cli = '" & cli_cpf _
            & "', @RG_Cli = '" & cli_rg _
            & "', @Habilitacao = '" & cli_cnh _
            & "', @Cat_CNH = '" & cli_cat_cnh _
            & "', @Nacionalidade_Cli = '" & cli_nac _
            & "', @logradouro_Cli = '" & cli_logra _
            & "', @NumCasa_Cli = '" & cli_numcasa _
            & "', @Complemento_Cli = '" & cli_compl _
            & "', @Bairro_Cli = '" & cli_bairro _
            & "', @Cidade_Cli = '" & cli_cid _
            & "', @Estado_Cli = '" & cli_uf _
            & "', @CEP_Cli = '" & cli_cep _
            & "', @Email = '" & cli_ema _
            & "', @CaminhoFotoCli = '" & cli_CaminhoFoto & "'"
        cn.FechaConexaoSejaAberta()

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = InsertQuery
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    Public Property Cod_Cli() As String
        Get
            Return cli_cod
        End Get
        Set(ByVal value As String)
            cli_cod = value
        End Set
    End Property

    Public Property Telefone1_Cli() As String
        Get
            Return cli_telefone1
        End Get
        Set(ByVal value As String)
            cli_telefone1 = value
        End Set
    End Property

    Public Property Telefone2_Cli() As String
        Get
            Return cli_telefone2

        End Get
        Set(ByVal value As String)
            cli_telefone2 = value

        End Set
    End Property

    Public Property Email() As String
        Get
            Return cli_ema
        End Get
        Set(ByVal value As String)
            cli_ema = value
        End Set
    End Property

    Public Property FormaTrat_cli As String
        Get
            Return cli_formatrat
        End Get
        Set(ByVal value As String)
            cli_formatrat = value
        End Set
    End Property

    Public Property FormaTrat2_cli As String
        Get
            Return cli_formatrat2
        End Get
        Set(ByVal value As String)
            cli_formatrat2 = value
        End Set
    End Property

    Public Property CodTipoTel_Cli() As Short
        Get
            Return cli_codtipotel
        End Get
        Set(value As Short)
            cli_codtipotel = value
        End Set
    End Property

    Public Property CodTipoTel2_Cli() As Short
        Get
            Return cli_codtipotel2
        End Get
        Set(ByVal value As Short)
            cli_codtipotel2 = value
        End Set
    End Property


    Public Sub CarregaCodCli()
        ' sub que carrega automaticamente o codigo do cliente do form 
        Dim mr As System.Data.SqlClient.SqlDataReader
        cn.FechaConexaoSejaAberta()

        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandType = CommandType.Text
                .CommandText = "select MAX(Cod_Cli) as 'UltCod' from Tb_Cliente"
                .ExecuteNonQuery()
            End With
            mr = cn.cmd.ExecuteReader
            mr.Read()

            If IsDBNull(mr!UltCod) Then
                NextCodCli = 1
            Else
                PrevCodCLi = mr!UltCod
                NextCodCli = CInt(PrevCodCLi) + 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
    End Sub

    'Public Sub CarregaCodTEl()

    '    Dim mr As System.Data.SqlClient.SqlDataReader

    '    Try
    '        cn.cnn.Open()
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandType = CommandType.Text
    '            .CommandText = "select MAX(Cod_Tel_Cli) as 'UltCod' from Tb_TelCli"
    '            .ExecuteNonQuery()
    '        End With
    '        mr = cn.cmd.ExecuteReader
    '        mr.Read()

    '        If IsDBNull(mr!UltCod) Then
    '            NextCodTel = 1

    '        Else
    '            'NextCodTel = 1
    '            PrevCodTel = mr!UltCod
    '            NextCodTel = CInt(PrevCodTel)
    '            NextCodTel = NextCodTel + 1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    cn.cnn.Close()
    'End Sub
    'Public Sub CarregaCodCli_Tel()

    '    Dim mr As System.Data.SqlClient.SqlDataReader
    '    cn.FechaConexaoSejaAberta()

    '    Try
    '        cn.cnn.Open()
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandType = CommandType.Text
    '            .CommandText = "select MAX(Cod_Cli) as 'UltCod' from Tb_Cliente"
    '            .ExecuteNonQuery()
    '        End With
    '        mr = cn.cmd.ExecuteReader
    '        mr.Read()

    '        If IsDBNull(mr!UltCod) Then
    '            NextCodCli_Tel = 1
    '        Else
    '            NextCodCli_Tel = mr!UltCod

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    cn.cnn.Close()
    'End Sub
    Public Sub InserirTelefone()
        'SUb que insere o primeiro telefone do cliente que  esta sendo inserido 
        'Call CarregaCodCli_Tel()
        Dim query As String
        query = "exec sp_CadTelCli @Cod_Cli = '" & cn.getIdentCurrent("Tb_Cliente") _
        & "', @Telefone = '" & cli_telefone1 _
        & "', @Forma_Tratamento = '" & cli_formatrat _
        & "', @Cod_Tipo_Tel = '" & cli_codtipotel & "'"
        cn.FechaConexaoSejaAberta()

        Try
            cn.FechaConexaoSejaAberta()
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = query
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.cnn.Close()
        'Se nao houver nada na propriedade de segundo telefone, não será inserido segundo telefone.
        If IsNothing(cli_telefone2) Then
            Exit Sub
        Else ' se houver segundo telefone, processa inserção do segudo telefone da mesma forma que esta sub
            Call InsereSegundoTelefoneCli()
        End If
    End Sub

    Public Sub InsereSegundoTelefoneCli()
        If cli_telefone1 = cli_telefone2 Then
            MessageBox.Show("Telefones duplicados.", "Erro inserir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            frmCliente.txtnumtel2.Clear()
            frmCliente.txtnumtel2.Focus()
        End If
        'Call CarregaCodCli_Tel()
        Dim query As String
        '(@Cod_Cli,@Telefone,@Email,@Forma_Tratamento,@Cod_Tipo_Tel)
        query = "exec sp_CadTelCli @Cod_Cli = '" & cn.getIdentCurrent("Tb_Cliente") _
        & "', @Telefone = '" & cli_telefone2 _
        & "', @Forma_Tratamento = '" & cli_formatrat _
        & "', @Cod_Tipo_Tel = '" & CodTipoTel2_Cli & "'"
        If IsNothing(cli_telefone2) Then
            Exit Sub
        Else
            cn.FechaConexaoSejaAberta()

            Try
                cn.cnn.Open()
                With cn.cmd
                    .Connection = cn.cnn
                    .CommandText = query
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        cn.cnn.Close()
    End Sub

End Class
