
Imports System.Data.SqlClient
Public Class clnValidaControles
    ' Define quais op��es de consistencia podem ser utilizadas
    Public Enum OpcaoConsiste
        VerNulo = 1
        VerNumerico = 2
        VerData = 3
        verCep = 4
        verCNPJ = 5
    End Enum

    Public Function gfConsisteCampos(ByVal Controle As System.Windows.Forms.Control, ByVal tipoOpcao As OpcaoConsiste, Optional ByVal intCaracterLen As Integer = 0) As Boolean
        '  condi��o que valida qual condi��o foi selecionada ao chamar esta fun��o.
        Select Case tipoOpcao
            'Faz o case se o op��o selecionada for a VerNulo
            Case OpcaoConsiste.VerNulo
                'Verifica se o controle � um TextBox
                If TypeOf Controle Is TextBox Then
                    'Verifica se valor do controle � Vazio
                    If Controle.Text = String.Empty Then
                        'Exibe uma mensagem
                        MsgBox("O Campo " & Controle.Tag & " deve ser Preenchido!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                        'Altera a cor de fundo para amarelo
                        Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                        Controle.Focus()
                        Return False
                        'Caso o valor n�o seje Vazio
                    Else
                        'Altera a cor de fundo para branco
                        Controle.BackColor = System.Drawing.Color.White
                        Return True
                    End If

                ElseIf TypeOf Controle Is MaskedTextBox Then
                    'Verifica se valor do controle � Vazio
                    If Controle.Text = String.Empty Then
                        'Exibe uma mensagem
                        MsgBox("O Campo " & Controle.Tag & " deve ser Preenchido!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                        'Altera a cor de fundo para amarelo
                        Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                        Controle.Focus()
                        Return False
                        'Caso o valor n�o seje Vazio
                    Else
                        'Altera a cor de fundo para branco
                        Controle.BackColor = System.Drawing.Color.White
                        Return True
                    End If
                    'Verifica se o controle � combobox
                ElseIf TypeOf Controle Is ComboBox Then

                    If Controle.Text = String.Empty Or Controle.Text = "(Selecione a Op��o Desejada)" Then
                        MsgBox("O Campo " & Controle.Tag & " deve ser Selecionado!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                        Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                        Controle.Focus()
                        Return False
                    Else
                        Controle.BackColor = System.Drawing.Color.White
                        Return True
                    End If
                    'Verifica se o controle � richtextbox
                ElseIf TypeOf Controle Is RichTextBox Then

                    If Controle.Text = String.Empty Then
                        MsgBox("O Campo " & Controle.Tag & " deve ser Selecionado!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                        Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                        Controle.Focus()
                        Return False
                    Else
                        Controle.BackColor = System.Drawing.Color.White
                        Return True
                    End If
                    'verifica se o controle � listbox

                ElseIf TypeOf Controle Is ListBox Then

                    If Controle.Text = String.Empty Then
                        MsgBox("O Campo " & Controle.Tag & " deve ser Selecionado!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                        Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                        Controle.Focus()
                        Return False
                    Else
                        Controle.BackColor = System.Drawing.Color.White
                        Return True
                    End If


                End If
                'Op��o de valida��o de caracteres numericos
            Case OpcaoConsiste.VerNumerico
                If Not IsNumeric(Controle.Text) Then
                    MsgBox("O Campo " & Controle.Tag & " deve ser Num�rico!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                    Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                    Controle.Focus()
                    Return False
                Else
                    Controle.BackColor = System.Drawing.Color.White
                    Return True
                End If
                'Valida��o de data
            Case OpcaoConsiste.VerData
                If Not IsDate(Controle.Text) Then
                    MsgBox("O Campo " & Controle.Tag & "!!! Formato Inv�lido!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                    Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                    Controle.Focus()
                    Return False
                Else
                    Controle.BackColor = System.Drawing.Color.White
                    Return True
                End If
                'Valida cep
            Case OpcaoConsiste.verCep
                If Not IsNumeric(Left(Controle.Text, 5)) Or Mid(Controle.Text, 6, 1) <> "-" Or Not IsNumeric(Right(Controle.Text, 2)) Then
                    MsgBox(Controle.Tag & " Inv�lido!!!", MsgBoxStyle.Information, "Dados faltantes ou inv�lidos")
                    Controle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
                    Controle.Focus()
                    Return False
                Else
                    Controle.BackColor = System.Drawing.Color.White
                    Return True
                End If

        End Select
        Return False
    End Function
    'Valida��o de e-mail
    Public Function ValidEMail(ByVal sEMail As String) As Boolean
        Dim nCharacter As Integer ' numero de caracteres a serem validados
        Dim Count As Integer ' variavel contador
        Dim sLetra As String
        'Verifica se o e-mail tem no M�NIMO 5
        'caracteres (a@b.c)
        If Len(sEMail) < 5 Then
            'O e-mail � inv�lido, pois tem menos
            'de 5 caracteres
            ValidEMail = False
            ' MsgBox("O e-mail digitado tem menos de 5 " & _
            '"caracteres!!!")
            Exit Function
            'Verificar a existencia de arrobas!!! Exit Function
        ElseIf InStr(sEMail, "@") = Len(sEMail) Then
            'O e-mail � inv�lido, pois termina
            'com uma @
            ValidEMail = False
            'MsgBox("O e-mail termina com uma arroba!!!")
            Exit Function
        End If
        nCharacter = 0
        Count = 0
        'Verificar a existencia de pontos (.) no e-mail
        For nCharacter = 1 To Len(sEMail)
            If Mid(sEMail, nCharacter, 1) = "." Then
                'OPA!!! Achou um ponto!!!
                'Soma 1 ao contador
                Count = Count + 1
            End If
        Next
        'Verifica o n�mero de pontos.
        'TEM que ter PELO MENOS UM ponto.
        If Count < 1 Then
            'O e-mail � inv�lido, pois n�o tem pontos.
            ValidEMail = False
            ' MsgBox("O e-mail � inv�lido, pois n�o cont�m " & _
            ' "pontos (.)!!!")
            Exit Function
        Else
            'O e-mail tem pelo menos 1 ponto.
            'Verificar a posi��o do ponto:
            If InStr(sEMail, ".") = 1 Then
                'O e-mail � inv�lido, pois come�a
                'com um ponto
                ValidEMail = False
                ' MsgBox("O e-mail foi iniciado com um ponto (.)!!!")
                Exit Function
            ElseIf InStr(sEMail, ".") = Len(sEMail) Then
                'O e-mail � inv�lido, pois termina
                'com um ponto.
                ValidEMail = False
                'MsgBox("O e-mail termina com um ponto (.)!!!")
                Exit Function
                'ElseIf InStr(InStr(sEMail, "@"), sEMail, ".") = 0 Then
                'O e-mail � inv�lido, pois termina
                'com um ponto.
                ValidEMail = False
                ' MsgBox("O e-mail n�o tem nenhum ponto (.) ap�s " & _
                ' "a arroba !!! ")
                Exit Function
            End If
        End If
        nCharacter = 0
        Count = 0
        'Verifica se o e-mail n�o tem pontos
        'consecutivos (..) ap�s a arroba !!! Exit Function
        'Verifica se o e-mail tem caracteres
        'inv�lidos
        For nCharacter = 1 To Len(sEMail)
            sLetra = Mid$(sEMail, nCharacter, 1)
            If Not (LCase(sLetra) Like "[a-z]" Or sLetra = _
            "@" Or sLetra = "." Or sLetra = "-" Or _
            sLetra = "_" Or IsNumeric(sLetra)) Then
                'O e-mail � inv�lido, pois tem
                'caracteres inv�lidos
                ValidEMail = False
                'MsgBox("Foi digitado um caracter inv�lido " & _
                '"no e-mail!!!")
                Exit Function
            End If
        Next
        nCharacter = 0
        'Bem, se a verifica��o chegou at� aqui
        '� porque o e-mail � v�lido, ent�o...
        ValidEMail = True
    End Function

    Dim cn As New conexaosql
    'Func��o que valida se o usu�rio possui permiss�o para executar certas fun��es. Ex: Gerenciar logins
    Public Function ValidaSeUsuarioTemAcesso()
        cn.FechaConexaoSejaAberta()
        'Busca logins dispon�veis
        Try
            cn.cnn.Open()
            With cn.cmd
                .Connection = cn.cnn
                .CommandText = "select tipo_login from Login where Cod_Func = " & CodUsuario & ""
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = cn.cmd.ExecuteReader
            mr.Read()
            'Se consulta n�o tiver linhas, ent�o.....
            If mr.HasRows = False Then
                MessageBox.Show("Acesso negado. Contate o suporte." & vbCrLf & " Mensagem de erro: N�o foi localizado nenhum registro referente ao usu�rio que est� logado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return True
                'Se tipo do login for diferente de 1 (Admin) entao...
            ElseIf mr!tipo_login <> 1 Then
                MessageBox.Show("Acesso negado. Contate o administrador do sistema." & vbCrLf & " Mesagem de erro: O usu�rio logado n�o possui acesso ao recurso selecionado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return True
            Else
                Return False
            End If
            'em caso de erro.
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
        cn.cnn.Close()
    End Function
End Class
