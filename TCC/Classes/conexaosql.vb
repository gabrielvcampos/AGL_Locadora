Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.DataTable

Public Class conexaosql

    Public cnn As New SqlConnection("Server=ZAPW10093\SQLEXPRESS;Database=DB_Locadora;Trusted_Connection=True;")
    Public cmd As New sqlcommand
    Function conexaoon() As Boolean
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        If cnn.State = ConnectionState.Open Then
            conexaoon = True
        Else
            conexaoon = False
        End If
        Return conexaoon
    End Function
    Function conexaooff() As Boolean
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        If cnn.State = ConnectionState.Open Then
            conexaooff = True
        Else
            conexaooff = False
        End If
        Return conexaooff
    End Function

    Public Sub ExecutarQuery(ByVal sql As String)
        Dim query As SqlCommand = Nothing
        Call cnn.Open()
        query.ExecuteNonQuery()
        Call cnn.Close()
    End Sub
    Public Sub FechaConexaoSejaAberta()
        If cnn.State = ConnectionState.Open Then

            cnn.Close()
        End If
    End Sub
    Function UsarMaster()
        Try
            cnn.Open()
            With cmd
                .Connection = cnn
                .CommandText = "use master"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return False
    End Function
    Dim conexaoSQLServer As String = ("Server=ZAPW10093\SQLEXPRESS;Database=DB_Locadora;Trusted_Connection=True;")
    Function BackupDatabase(ByVal connString As String, ByVal nomeDB As String, ByVal backupFile As String)
        frmBackup.ProgressBar1.Value = 0
        Dim cn As New SqlConnection(connString)

        Try
            frmBackup.Timer1.Start()
            ' comando para fazer o backup do Banco de dados
            Dim cmdBackup As New SqlCommand("BACKUP DATABASE [" & nomeDB & "] TO DISK = 'D:\DBTESTE.BAK' WITH INIT", cn)
            cn.Open()
            cmdBackup.ExecuteNonQuery()
        Finally
            cn.Close()

        End Try
        Return False
    End Function

    Function RestauraDatabase(ByVal connString As String, ByVal nomeDB As String, ByVal backupFile As String)
        frmBackup.ProgressBar1.Value = 0
        Dim cn As New SqlConnection(connString)
        Try
            'comando para restaurar o banco de dados
            frmBackup.Timer1.Start()
            Dim cmdBackup As New SqlCommand("EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'DB_Locadora' USE [master] ALTER DATABASE  [DB_Locadora] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE USE [master] DROP DATABASE [DB_Locadora]" & vbCrLf _
                     & "RESTORE DATABASE [DB_Locadora] " & vbCrLf _
                    & "from disk = '" & backupFile & "'" & vbCrLf _
                    & "with REPLACE, STATS = 10")
            cn.Open()
            cmdBackup.Connection = cn
            cmdBackup.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()

        End Try
        Return False
    End Function
    


    Function ObtemBancoDeDadosSQLSever(ByVal ConnString As String) As String()

        Dim cn As New SqlConnection(ConnString)

        Dim dbLista As New ArrayList
        ' retorn o nome de todos os banco de dados da tabela sysdatabases em MASTER
        Dim cmd As New SqlCommand("SELECT [name] FROM sysdatabases where [name] like '%Locadora%'", cn)
        Dim reader As SqlDataReader
        cn.Open()
        Try
            reader = cmd.ExecuteReader()
            While reader.Read()
                ' inclui o nome no arraylist
                dbLista.Add(reader("name"))
            End While
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        ' retorna o array de strings 
        Return dbLista.ToArray(GetType(String))
    End Function

    ' RETORNA VALOR ATUAL DO CAMPO CHAVE DE UMA TABELA
    Function getIdentCurrent(ByVal table As String)
        FechaConexaoSejaAberta()
        Dim resultado As Short
        Try
            cnn.Open()
            With cmd
                .Connection = cnn
                .CommandText = "SELECT IDENT_CURRENT('" & table & "') as 'UltCod'"
                .ExecuteNonQuery()
            End With
            Dim mr As SqlDataReader = cmd.ExecuteReader
            mr.Read()
            If IsDBNull(mr!UltCod) Then
                resultado = 1
                Return resultado
            Else
                resultado = mr!UltCod
                Return resultado
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message())
        End Try
        cnn.Close()
    End Function
End Class
