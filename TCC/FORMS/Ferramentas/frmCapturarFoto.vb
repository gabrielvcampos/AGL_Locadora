Imports System.Runtime.InteropServices
Public Class frmCapturarFoto



    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents picCaptura As System.Windows.Forms.PictureBox
    Friend WithEvents lstDispositivos As System.Windows.Forms.ListBox
    Friend WithEvents lblDevice As System.Windows.Forms.Label
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnParar As System.Windows.Forms.Button
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapturarFoto))
        Me.picCaptura = New System.Windows.Forms.PictureBox()
        Me.lstDispositivos = New System.Windows.Forms.ListBox()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCaptura
        '
        Me.picCaptura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picCaptura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCaptura.InitialImage = Nothing
        Me.picCaptura.Location = New System.Drawing.Point(119, 5)
        Me.picCaptura.Name = "picCaptura"
        Me.picCaptura.Size = New System.Drawing.Size(289, 205)
        Me.picCaptura.TabIndex = 0
        Me.picCaptura.TabStop = False
        '
        'lstDispositivos
        '
        Me.lstDispositivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstDispositivos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDispositivos.ItemHeight = 14
        Me.lstDispositivos.Location = New System.Drawing.Point(2, 26)
        Me.lstDispositivos.Name = "lstDispositivos"
        Me.lstDispositivos.Size = New System.Drawing.Size(111, 74)
        Me.lstDispositivos.TabIndex = 1
        '
        'lblDevice
        '
        Me.lblDevice.BackColor = System.Drawing.Color.Transparent
        Me.lblDevice.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevice.Location = New System.Drawing.Point(2, 5)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(111, 18)
        Me.lblDevice.TabIndex = 2
        Me.lblDevice.Text = "Dispositivos encontrados"
        Me.lblDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Verdana", 7.75!, System.Drawing.FontStyle.Bold)
        Me.btnIniciar.Image = Global.TCC.My.Resources.Resources._1362336449_applets_screenshooter
        Me.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIniciar.Location = New System.Drawing.Point(12, 231)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(121, 56)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 7.75!, System.Drawing.FontStyle.Bold)
        Me.btnSalvar.Image = Global.TCC.My.Resources.Resources._1362336579_Save
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(291, 231)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(117, 56)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnParar
        '
        Me.btnParar.BackColor = System.Drawing.Color.MistyRose
        Me.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParar.Font = New System.Drawing.Font("Verdana", 7.75!, System.Drawing.FontStyle.Bold)
        Me.btnParar.Image = Global.TCC.My.Resources.Resources._1362337215_player_stop
        Me.btnParar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParar.Location = New System.Drawing.Point(154, 231)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(121, 56)
        Me.btnParar.TabIndex = 5
        Me.btnParar.Text = "Parar"
        Me.btnParar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnParar.UseVisualStyleBackColor = False
        '
        'sfdImage
        '
        Me.sfdImage.FileName = "Webcam1"
        Me.sfdImage.Filter = "Bitmap|*.bmp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "F1 - Iniciar    |    F2 - Parar  |    F3 - Salvar"
        '
        'frmCapturarFoto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.FundoForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(420, 332)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnParar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblDevice)
        Me.Controls.Add(Me.lstDispositivos)
        Me.Controls.Add(Me.picCaptura)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCapturarFoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Vídeo"
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'constantes usadas na DLL
    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As String ' ID do dispositivo atual
    Dim hHwnd As Integer ' manipulador da janela do visualizador

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    'A função DestroyWindow destroi a janela especificada.
    'Envia as mensagens WM_DESTROY e WM_NCDESTROY para a 
    'janela para destivá-la e remove o foco do teclado da mesma
    'Library - User32
    'Parametros -  hWnd - (identica a janela a ser destruida)
    'Retorna um valor diferente de zero se for executada com sucesso,
    'caso contrario retorna zero
    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    'função para abrir a conexao com a camera utilizando a dll 
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer
    ' funcao para retornar o nome da camera instalado no computador que sera exibida na lista
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean




    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'verifica e carrega os dispositivos
        carregaDispositivos()

        If lstDispositivos.Items.Count > 0 Then
            btnIniciar.Enabled = True
            lstDispositivos.SelectedIndex = 0
            btnIniciar.Enabled = True
        Else
            lstDispositivos.Items.Add("Não dispositivo de captura instalado.")
            btnIniciar.Enabled = False
        End If

        btnParar.Enabled = False
        btnSalvar.Enabled = False
        picCaptura.SizeMode = PictureBoxSizeMode.StretchImage
        lstDispositivos.SelectedIndex = 0
    End Sub

    Public Sub carregaDispositivos()
        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorna As Boolean
        Dim x As Integer = 0

        ' 
        ' Carrega os dispositivos em lstDevices
        Do
            '
            '   Obtem o nome e a versão Driver
            bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100)

            '
            ' se existir um dispositivo inclui o nome da lista
            If bRetorna Then lstDispositivos.Items.Add(strNome.Trim)
            x += 1
        Loop Until bRetorna = False
    End Sub

    Public Sub abreJanelaVisualizacao()
        Dim iHeight As Integer = picCaptura.Height
        Dim iWidth As Integer = picCaptura.Width

        '
        ' Abre a janela de visualização no picturebox
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
            480, picCaptura.Handle.ToInt32, 0)

        '
        ' Conecta com o drive
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Define a escala de previsão
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            '
            'Define a taxa de visualização em milisegundos
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            '
            'Iniciar a visualização da imagem a partir da camara
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            '
            ' Redimensiona a janela para se ajustar no picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picCaptura.Width, picCaptura.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)

            btnSalvar.Enabled = True
            btnParar.Enabled = True
            btnIniciar.Enabled = False
        Else
            '
            ' Erro de conexão fecha a janela de dispostivos
            DestroyWindow(hHwnd)

            btnSalvar.Enabled = False
        End If
    End Sub

    Public Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        'define dispositivo para viauslização
        iDevice = lstDispositivos.SelectedIndex
        'validação de dispositivo, para ver se foi selecionado
        If iDevice <> -1 Then
            abreJanelaVisualizacao()
        Else
            MsgBox("Selecione um dispositivo de video...")
        End If
    End Sub

    Private Sub fechaJanelaVisualizacao()
        ' Desconecta do dispositivo
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        ' fecha a chama a janela
        DestroyWindow(hHwnd)
    End Sub

    Private Sub btnParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParar.Click
        fechaJanelaVisualizacao()
        btnSalvar.Enabled = False
        btnIniciar.Enabled = True
        btnParar.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim dados As IDataObject
        Dim bmap As Image

        ' Copia a imagem para o clipboard
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        ' Copia a imagem para o clipboard
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Obtem a imagem do clipboard e converte para bitmap
        dados = Clipboard.GetDataObject()

        If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
            picCaptura.Image = bmap
            fechaJanelaVisualizacao()
            btnSalvar.Enabled = False
            btnParar.Enabled = False
            btnIniciar.Enabled = True
            sfdImage.FileName = CodFoto
            'verifica se a web cam esta nsendo utilizada no formulario de cliente ou de funcionario
            If form = "frmCliente" Then
                sfdImage.InitialDirectory = "C:\Fotos\Cliente"
            ElseIf form = "frmFuncionario" Then
                sfdImage.InitialDirectory = "C:\Fotos\Funcionario"
            End If
            'If sfdImage.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ' salva o caminho da foto e ja carrega diretamente no form
            sfdImage.FileName = sfdImage.InitialDirectory & "\" & CodFoto & ".jpg"
            bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Jpeg)
            Caminho = sfdImage.FileName.ToString
            'End If
            Me.Close()
        End If
    End Sub
    Private Sub frmCapturarFoto_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'evento ao fechar o form
        If btnParar.Enabled Then
            fechaJanelaVisualizacao()
        End If
        'se for cliente, carrega imagem do cliente. Se for funcionario, idem
        If form = "frmCliente" Then
            frmCliente.PictureBox1.ImageLocation = Caminho
        ElseIf form = "frmFuncionario" Then
            frmFuncionario.PicFotoFunc.ImageLocation = Caminho
        End If
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label



    Private Sub lstDispositivos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lstDispositivos.KeyDown
        'teclas de atalho para visualização e salvar foto
        Select Case e.KeyCode
            Case Keys.F1
                'exibe imagem
                iDevice = lstDispositivos.SelectedIndex
                If iDevice <> -1 Then
                    abreJanelaVisualizacao()
                Else
                    MsgBox("Selecione um dispositivo de video...")
                End If
            Case Keys.F2
                'para a imagem
                fechaJanelaVisualizacao()
                btnSalvar.Enabled = False
                btnIniciar.Enabled = True
                btnParar.Enabled = False
            Case Keys.F3
                'salva a imagem
                Dim dados As IDataObject
                Dim bmap As Image

                ' Copia a imagem para o clipboard
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
                ' Copia a imagem para o clipboard
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

                ' Obtem a imagem do clipboard e converte para bitmap
                dados = Clipboard.GetDataObject()

                If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                    bmap = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
                    picCaptura.Image = bmap
                    fechaJanelaVisualizacao()
                    btnSalvar.Enabled = False
                    btnParar.Enabled = False
                    btnIniciar.Enabled = True
                    sfdImage.FileName = CodFoto
                    If form = "frmCliente" Then
                        sfdImage.InitialDirectory = "C:\Fotos\Cliente"
                    ElseIf form = "frmFuncionario" Then
                        sfdImage.InitialDirectory = "C:\Fotos\Funcionario"
                    End If
                    'If sfdImage.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    sfdImage.FileName = sfdImage.InitialDirectory & "\" & CodFoto & ".jpg"
                    bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Jpeg)
                    Caminho = sfdImage.FileName.ToString
                    'End If
                    Me.Close()
                End If
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class

