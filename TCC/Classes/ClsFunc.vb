Imports System.Data.SqlClient
Public Class ClsFunc
    'declaração de properties
    Dim cn As New conexaosql 'String de conexão
    Dim InsertQuery As String 'Comandos SQL
    Dim func_nome As String
    Dim func_sexo As String
    Dim func_nasc As String
    Dim func_cpf As String
    Dim func_rg As String
    Dim func_habilitacao As String
    Dim func_org As String
    Dim func_cod As String
    Dim func_logradouro As String
    Dim func_numcasa As String
    Dim func_complemento As String
    Dim func_bairro As String
    Dim func_cidade As String
    Dim func_uf As String
    Dim func_cep As String
    Dim func_codcargo As String
    Dim func_foto As String
    Dim func_codtel As Short
    Dim func_CodTipoTel As Short
    Dim func_CodTipoTel2 As Short
    Dim func_telefone As String
    Dim func_telefone2 As String
    Dim func_Email As String
    Dim func_FormaTrat As String
    Dim func_cargo As Short
    Dim func_Salario As String
    Dim PrevCodTel As Short
    Dim NextCodFunc As Short
    Public Property Cod_Func() As String
        Get
            Return func_cod
        End Get
        Set(ByVal value As String)
            func_cod = value
        End Set
    End Property
    Public Property Nome_Func() As String
        Get
            Return func_nome
        End Get
        Set(ByVal value As String)
            func_nome = value
        End Set
    End Property
    Public Property Sexo_Func() As String
        Get
            Return func_sexo
        End Get
        Set(ByVal value As String)
            func_sexo = value
        End Set
    End Property
    Public Property DataNasc_Func() As String
        Get
            Return func_nasc

        End Get
        Set(ByVal value As String)
            func_nasc = value

        End Set
    End Property
    Public Property CPF_Func As String
        Get
            Return func_cpf

        End Get
        Set(ByVal value As String)
            func_cpf = value
        End Set
    End Property

    Public Property RG_Func As String
        Get
            Return func_rg

        End Get
        Set(ByVal value As String)
            func_rg = value

        End Set
    End Property

    Public Property Hab_Func As String
        Get
            Return func_habilitacao

        End Get
        Set(ByVal value As String)
            func_habilitacao = value

        End Set
    End Property

    Public Property OrgEmissor_Func As String
        Get
            Return func_org
        End Get
        Set(ByVal value As String)
            func_org = value
        End Set
    End Property

    Public Property Logradouro_Func As String
        Get
            Return func_logradouro

        End Get
        Set(ByVal value As String)
            func_logradouro = value

        End Set
    End Property
    Public Property NumCasa_Func As String
        Get
            Return func_numcasa
        End Get
        Set(ByVal value As String)
            func_numcasa = value
        End Set
    End Property
    Public Property Complemento_Func As String
        Get
            Return func_complemento
        End Get
        Set(ByVal value As String)
            func_complemento = value
        End Set
    End Property
    Public Property Bairro_Func As String
        Get
            Return func_bairro
        End Get
        Set(ByVal value As String)
            func_bairro = value
        End Set
    End Property
    Public Property Cidade_Func As String
        Get
            Return func_cidade
        End Get
        Set(ByVal value As String)
            func_cidade = value
        End Set
    End Property
    Public Property UF_func As String
        Get
            Return func_uf
        End Get
        Set(ByVal value As String)
            func_uf = value
        End Set
    End Property
    Public Property Cep_Func As String
        Get
            Return func_cep
        End Get
        Set(ByVal value As String)
            func_cep = value
        End Set
    End Property
    Public Property Foto_Func As String
        Get
            Return func_foto
        End Get
        Set(ByVal value As String)
            func_foto = value
        End Set
    End Property
    Public Property CodTel_Func As Short
        Get
            Return func_codtel
        End Get
        Set(ByVal value As Short)
            func_codtel = value
        End Set
    End Property
    Public Property Email_Func As String
        Get
            Return func_Email
        End Get
        Set(ByVal value As String)
            func_Email = value
        End Set
    End Property
    Public Property FormaTratamento_Func As String
        Get
            Return func_FormaTrat
        End Get
        Set(ByVal value As String)
            func_FormaTrat = value
        End Set
    End Property
    Public Property Cargo_Func As Short
        Get
            Return func_cargo
        End Get
        Set(ByVal value As Short)
            func_cargo = value
        End Set
    End Property
    Public Property Salario_Func As String
        Get
            Return func_Salario
        End Get
        Set(ByVal value As String)
            func_Salario = value
        End Set
    End Property
    Public Property CodTipoTel_Func As Short
        Get
            Return func_CodTipoTel
        End Get
        Set(ByVal value As Short)
            func_CodTipoTel = value
        End Set
    End Property
    Public Property CodTipoTel2_Func As Short
        Get
            Return func_CodTipoTel2
        End Get
        Set(ByVal value As Short)
            func_CodTipoTel2 = value
        End Set
    End Property
    Public Property Telefone1_Func As String
        Get
            Return func_telefone
        End Get
        Set(ByVal value As String)

            func_telefone = value

        End Set
    End Property
    Public Property Telefone2_Func As String
        Get
            Return func_telefone2

        End Get
        Set(ByVal value As String)

            func_telefone2 = value

        End Set
    End Property
    Public Property FormaTrat_Func As String
        Get
            Return func_FormaTrat


        End Get
        Set(ByVal value As String)

            func_FormaTrat = value

        End Set
    End Property
    'sub que insere o funcionário na tabela
    Public Sub IncluirFuncionario()
        '(Nome_Func,Sexo_Func,CPF_Func,DataNasc_Func,RG_Func,Logradouro_Func,NumCasa_Func,Complemento_Func,Bairro_Func,Cidade_Func,CEP_Func,Estado_Func,Email,Cod_Cargo)
        InsertQuery = "exec sp_CadFunc" _
            & " @Nome_Func = '" & func_nome _
            & "', @Sexo_Func = '" & func_sexo _
            & "', @CPF_Func = '" & func_cpf _
            & "', @DataNasc_Func = '" & func_nasc _
            & "', @RG_Func = '" & func_rg _
            & "', @Logradouro_Func = '" & func_logradouro _
            & "', @NumCasa_Func = '" & func_numcasa _
            & "', @Complemento_Func = '" & func_complemento _
            & "', @Bairro_Func = '" & func_bairro _
            & "', @Cidade_Func = '" & func_cidade _
            & "', @CEP_Func = '" & func_cep _
            & "', @Estado_Func = '" & func_uf _
            & "', @Email = '" & func_Email _
            & "', @CaminhoFoto_Func = '" & func_foto _
            & "', @Cod_Cargo = " & func_cargo & ""


        '& "', @codtelcli = null"
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
   
    'Public Sub CarregaCodFUnc_Tel()
    '    Dim mr As System.Data.SqlClient.SqlDataReader
    '    Try
    '        cn.cnn.Open()
    '        With cn.cmd
    '            .Connection = cn.cnn
    '            .CommandType = CommandType.Text
    '            .CommandText = "select MAX(Cod_Func) as 'UltCodTel' from TB_Funcionario"
    '            .ExecuteNonQuery()
    '        End With
    '        mr = cn.cmd.ExecuteReader
    '        mr.Read()

    '        If IsDBNull(mr!UltCodTel) Then
    '            NextCodFunc = 1
    '        Else
    '            NextCodFunc = mr!UltCodTel

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    cn.cnn.Close()
    'End Sub
    'insere primeiro telefone do funcionario
    Public Sub InsereTelefone()
        ' Call CarregaCodFUnc_Tel()

        ' (Cod_Func,Telefone,Forma_Tratamento,Cod_Tipo_Tel)

        InsertQuery = "exec sp_CadTelFunc" _
          & " @Cod_Func = '" & cn.getIdentCurrent("TB_Funcionario") _
          & "', @Telefone = '" & func_telefone _
          & "', @Cod_Tipo_Tel = '" & func_CodTipoTel & "'"

        Try
            cn.FechaConexaoSejaAberta()
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
    'insere segundo telefone do funcionario
    Public Sub InsereSegundoTelFUnc()


        'Call CarregaCodFUnc_Tel()
        Dim query As String
        '(@Cod_Cli,@Telefone,@Email,@Forma_Tratamento,@Cod_Tipo_Tel)
        query = "exec sp_CadTelFunc @Cod_Func = '" & cn.getIdentCurrent("TB_Funcionario") _
        & "', @Telefone = '" & func_telefone2 _
        & "', @Cod_Tipo_Tel = '" & CodTipoTel2_Func & "'"
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
    End Sub


End Class
