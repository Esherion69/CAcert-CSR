Imports System
Imports System.IO
Imports System.Text
Imports System.Globalization

Public Class frmCAcertCSR
    Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
    Public blnssl As Boolean = True

    Public strKey As String
    Public strCsr As String
    Public strCrt As String
    Public strmd5 As String

    Public strWo As String = My.Resources.CAcert_CSR_UI.csr_strWoStart

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init()
        If My.Settings.firstRun Then
            My.Settings.firstRun = False
            My.Settings.Save()
            frmInit.ShowDialog()
        End If
        If Not FileIO.FileSystem.FileExists(My.Settings.ssl & "\bin\openssl.exe") Then
            MessageBox.Show(String.Format(My.Resources.CAcert_CSR_UI.csr_msgOpenSSL, My.Settings.ssl))
            Application.Exit()
        End If

        If FileIO.FileSystem.FileExists(Environ("USERPROFILE") & "\27F550A2-5559-4C99-8DF0-C563A9574C03") Then
            Me.Width = 1090
            Me.Height = 650
        Else
            Me.Width = 340
            Me.Height = 458
        End If
    End Sub

    Private Sub btnPlusClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        Dim ret As String
        ret = InputBox(My.Resources.CAcert_CSR_UI.csr_inputBoxPrompt, My.Resources.CAcert_CSR_UI.csr_inputBoxTitle, "")

        If ret <> "" And ret <> txtCommon.Text Then
            lstNamen.Items.Add(ret)
        End If
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        If lstNamen.SelectedIndex <> -1 Then
            lstNamen.Items.RemoveAt(lstNamen.SelectedIndex)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstNamen.Items.Clear()
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        txtCommon.Text = ""
        lstNamen.Items.Clear()
        txtCSR.Text = ""
        txtPem.Text = ""
    End Sub

    Private Sub txtCommon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCommon.TextChanged
        If txtCommon.Text <> "" Then
            rbPrivat.Enabled = True
            rbOrg.Enabled = True
        Else
            btnGenerate.BackColor = Color.Red
            btnGenerate.Enabled = False

            rbPrivat.Enabled = False
            rbPrivat.Checked = False
            rbOrg.Enabled = False
            rbOrg.Checked = False

            rbClient.Enabled = False
            rbClient.Checked = False
            rbServer.Enabled = False
            rbServer.Checked = False

            btnClearAll.Enabled = False
            btnClear.Enabled = False
            btnPlus.Enabled = False
            btnMinus.Enabled = False
            lstNamen.Enabled = False
            rbClass1.Enabled = False
            rbClass3.Enabled = False
            cbCCA.Enabled = False
        End If
    End Sub

    Function strAdd(ByRef strText As String, ByRef strParameter As String, ByVal strOption As String) As Boolean
        If strOption <> "" Then
            strText = strText & strParameter & strOption & vbCrLf
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim filePath As String

        If txtCommon.Text <> "" Then
            btnCAcertSig.BackColor = Color.Yellow
            Application.DoEvents() 'Zeigt die Farbe auch an

            'Löschen aller vorhanden Zertifikatsdateien

            DelFileOnExist(Environ("LOCALAPPDATA") & My.Settings.DataDir & "\openssl.cfg")
            DelFileOnExist(Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.key")
            DelFileOnExist(Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.csr")
            DelFileOnExist(Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.crt")

            Dim ascii As Encoding = Encoding.ASCII
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(Environ("LOCALAPPDATA") & My.Settings.DataDir & "\openssl.cfg", False, ascii)
            Dim strText As String = ""
            strText = "[ req ]" & vbCrLf &
                    "prompt = no" & vbCrLf &
                    "default_bits = 2048" & vbCrLf &
                    "default_keyfile = cacert.key" & vbCrLf &
                    "distinguished_name = req_distinguished_name" & vbCrLf &
                    "attributes = req_attributes" & vbCrLf &
                    "x509_extensions = v3_ca" & vbCrLf &
                    "" & vbCrLf &
                    "[ req_distinguished_name ]" & vbCrLf

            strAdd(strText, "CN = ", txtCommon.Text)
            strAdd(strText, "O = ", My.Settings.Org)
            strAdd(strText, "OU = ", My.Settings.Dep)
            strAdd(strText, "streetAddress = ", My.Settings.Street1)
            strAdd(strText, "streetAddress = ", My.Settings.Street2)
            strAdd(strText, "streetAddress = ", My.Settings.Street3)
            strAdd(strText, "postalCode = ", My.Settings.Postal)
            strAdd(strText, "L = ", My.Settings.City)
            strAdd(strText, "ST = ", My.Settings.State)
            strAdd(strText, "C = ", My.Settings.Country)
            strAdd(strText, "emailAddress = ", My.Settings.Mail)

            strText = strText & "" & vbCrLf &
                    "[ req_attributes ]" & vbCrLf &
                    "challengePassword = " & My.Settings.certPass & vbCrLf &
                    "" & vbCrLf &
                    "[ v3_ca ]" & vbCrLf &
                    "subjectKeyIdentifier = hash" & vbCrLf &
                    "authorityKeyIdentifier = keyid : always, issuer : always()" & vbCrLf &
                    IIf(gbArt.Tag.ToString = "Client", "basicConstraints = CA:false", "basicConstraints = CA:true").ToString & vbCrLf &
                    "" & vbCrLf &
                    "subjectAltName	= @alt_names" & vbCrLf &
                    "" & vbCrLf &
                    "[alt_names]" & vbCrLf &
                    "DNS.1							= " & txtCommon.Text

            file.WriteLine(strText)

            Dim counter As Int32 = 2
            For Each i In lstNamen.Items
                file.WriteLine(
                    "DNS." & counter & "							= " & i.ToString
                )
                counter = counter + 1
            Next
            file.Close()

            filePath = My.Settings.ssl & "\bin\openssl.exe genrsa -out " & Chr(34) & Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.key" & Chr(34) & " 2048 -config " & Chr(34) & Environ("LOCALAPPDATA") & My.Settings.DataDir & "\openssl.cfg" & Chr(34)
            Shell(filePath, AppWinStyle.Hide, True, 6000)

            filePath = My.Settings.ssl & "\bin\openssl.exe req -new -out " & Chr(34) & Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.csr" & Chr(34) & " -key " & Chr(34) & Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.key" & Chr(34) & " -config " & Chr(34) & Environ("LOCALAPPDATA") & My.Settings.DataDir + "\openssl.cfg" & Chr(34)
            Shell(filePath, AppWinStyle.Hide, True, -1)

            DelFileOnExist(Environ("LOCALAPPDATA") & My.Settings.DataDir & "\openssl.cfg")

            Dim fileReader As String
            filePath = Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.csr"
            fileReader = My.Computer.FileSystem.ReadAllText(filePath)
            txtCSR.Text = fileReader
            btnCAcertSig.BackColor = Color.Green
            btnCAcertSig.Enabled = True
            Me.AcceptButton = btnCAcertSig

            My.Settings.actServer = My.Settings.accServer & My.Settings.accTyp & gbArt.Tag.ToString

            Select Case gbTyp.Tag.ToString
                Case "rbPrivat"
                    Select Case gbArt.Tag.ToString
                        Case "Client"
                            My.Settings.actPage = My.Settings.usrClient
                        Case "Server"
                            My.Settings.actPage = My.Settings.usrServer
                    End Select
                Case "rbOrg"
                    Select Case gbArt.Tag.ToString
                        Case "Client"
                            My.Settings.actPage = My.Settings.orgClient
                        Case "Server"
                            My.Settings.actPage = My.Settings.orgServer
                    End Select
            End Select
        End If
    End Sub

    Private Sub btnCAcertSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAcertSig.Click
        If cbCCA.Checked Then
            btnCAcertFin.BackColor = Color.Yellow
            webCAcert.Navigate(My.Settings.actServer & My.Settings.accLogin)
            If My.Settings.accTyp = "Pass" Then
                strWo = My.Resources.CAcert_CSR_UI.csr_strWoLogin
                webCAcert.Navigate(My.Settings(My.Settings.accServer & My.Settings.accTyp & "Server").ToString & My.Settings.accLogin)
            Else
                strWo = My.Resources.CAcert_CSR_UI.csr_strWoCSR
                webCAcert.Navigate(My.Settings.actServer & My.Settings.actPage)
            End If
        Else
            MessageBox.Show(My.Resources.CAcert_CSR_UI.csr_msgCCA)
        End If
    End Sub

    Private Sub btnCAcertFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAcertFin.Click
        btnCACertSave.BackColor = Color.Yellow
        strWo = My.Resources.CAcert_CSR_UI.csr_strWoSig
        SubmitButton()
    End Sub

    Private Sub btnCACertSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCACertSave.Click
        Dim sHtmlText As String = webCAcert.Document.Body.InnerHtml

        Dim starttag_startindex As Integer = sHtmlText.IndexOf("<PRE>")
        Dim starttag_endindex As Integer = starttag_startindex + CStr("<PRE>").Length - 1
        Dim endtag_startindex As Integer = sHtmlText.Substring(starttag_endindex, sHtmlText.Length - starttag_endindex).IndexOf("</PRE>") + starttag_startindex - 1

        Dim sSpanText As String = sHtmlText.Substring(starttag_endindex + 1, endtag_startindex - starttag_endindex)

        txtPem.Text = sSpanText

        Dim ascii As Encoding = Encoding.ASCII
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Environ("LOCALAPPDATA") & My.Settings.DataDir & "\cacert.crt", False, ascii)
        file.Write(txtPem.Text)
        file.Write("--")
        file.Close()

        strWo = My.Resources.CAcert_CSR_UI.csr_strWoLogout
        webCAcert.Navigate(My.Settings(My.Settings.accServer & My.Settings.accTyp & "Server").ToString & My.Settings.accLogout)
        txtCSR.Text = ""
        txtPem.Text = ""
        webCAcert.Navigate("about: blank")
    End Sub

    Private Sub webCAcert_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webCAcert.DocumentCompleted
        If (sender Is webCAcert) Then
            Dim myForm As New WebBrowserForm(webCAcert)
            Select Case strWo
                Case My.Resources.CAcert_CSR_UI.csr_strWoStart
                    Exit Select
                Case My.Resources.CAcert_CSR_UI.csr_strWoLogin
                    Debug.Print("Dokument: " & strWo & " komplett geladen.")
                    myForm.InnerText("email", My.Settings.Mail)
                    myForm.InnerText("pword", My.Settings.Password)
                    SubmitButton()
                    Timer1.Start()
                    Exit Select
                Case My.Resources.CAcert_CSR_UI.csr_strWoCSR
                    Debug.Print("Dokument: " & strWo & " komplett geladen.")

                    myForm.Radiobox("rootcert", IIf(rbClass1.Checked, rbClass1.Tag.ToString, rbClass3.Tag.ToString).ToString)
                    If gbArt.Tag.ToString = "Client" Then
                        myForm.Checkbox("expertbox", True)
                        myForm.InnerText("optionalCSR", txtCSR.Text)
                    Else
                        myForm.InnerText("CSR", txtCSR.Text)
                    End If
                    myForm.Checkbox("CCA", True)
                    strWo = My.Resources.CAcert_CSR_UI.csr_strWoConfirmation
                    SubmitButton()
                    Exit Select
                Case My.Resources.CAcert_CSR_UI.csr_strWoConfirmation
                    btnCAcertFin.BackColor = Color.Green
                    btnCAcertFin.Enabled = True
                    Me.AcceptButton = btnCAcertFin
                    Application.DoEvents()
                    Exit Select
                Case My.Resources.CAcert_CSR_UI.csr_strWoSig
                    'Die Domain ist nicht bestätigt.
                    btnCACertSave.BackColor = Color.Green
                    btnCACertSave.Enabled = True
                    Me.AcceptButton = btnCACertSave
                    Exit Select
                Case My.Resources.CAcert_CSR_UI.csr_strWoLogout
                    txtCommon.Text = ""
                    btnGenerate.Enabled = False
                    btnGenerate.BackColor = Color.Red
                    btnCAcertSig.Enabled = False
                    btnCAcertSig.BackColor = Color.Red
                    btnCAcertFin.Enabled = False
                    btnCAcertFin.BackColor = Color.Red
                    btnCACertSave.Enabled = False
                    btnCACertSave.BackColor = Color.Red
                    Me.AcceptButton = btnGenerate
                    txtCommon.Focus()
                    Shell("explorer " & Chr(34) & Environ("LOCALAPPDATA") & My.Settings.DataDir & Chr(34), AppWinStyle.NormalFocus, False)
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub InfoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem1.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub EinstellungenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem1.Click
        frmInit.ShowDialog()
    End Sub

    Private Sub BeendenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub Typ_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrivat.CheckedChanged, rbOrg.CheckedChanged
        If rbOrg.Checked Then
            MessageBox.Show(My.Resources.CAcert_CSR_UI.csr_msgNotAvailable & vbNewLine & My.Resources.CAcert_CSR_UI.csr_msgTurnPrivate)
            rbPrivat.Checked = True
            Exit Sub
        End If
        If rbPrivat.Checked Or rbOrg.Checked Then
            rbClient.Enabled = True
            rbClient.Checked = False
            rbServer.Enabled = True
            rbServer.Checked = False
        Else
            rbClient.Enabled = False
            rbClient.Checked = False
            rbServer.Enabled = False
            rbServer.Checked = False
        End If
    End Sub

    Private Sub rbPrivat_Click(sender As Object, e As EventArgs) Handles rbPrivat.Click
        gbTyp.Tag = "usr"
    End Sub

    Private Sub rbOrg_Click(sender As Object, e As EventArgs) Handles rbOrg.Click
        gbTyp.Tag = "org"
    End Sub

    Private Sub rbClient_Click(sender As Object, e As EventArgs) Handles rbClient.Click
        gbArt.Tag = "Client"
    End Sub

    Private Sub rbServer_Click(sender As Object, e As EventArgs) Handles rbServer.Click
        gbArt.Tag = "Server"
    End Sub

    Private Sub Art_CheckedChanged(sender As Object, e As EventArgs) Handles rbClient.CheckedChanged, rbServer.CheckedChanged
        'If rbClient.Checked Then
        '    MsgBox("Wurde noch nicht umgesetzt." & vbCrLf & "Stelle auf Server um.")
        '    rbServer.Checked = True
        '    Exit Sub
        'End If
        If rbClient.Checked Or rbServer.Checked Then
            btnClearAll.Enabled = True
            btnClear.Enabled = True
            btnPlus.Enabled = True
            btnMinus.Enabled = True
            lstNamen.Enabled = True
            lstNamen.Items.Clear()
            rbClass1.Enabled = True
            rbClass3.Enabled = True
            cbCCA.Enabled = True
            btnGenerate.Enabled = True
            btnGenerate.BackColor = Color.Green
        Else
            btnClearAll.Enabled = False
            btnClear.Enabled = False
            btnPlus.Enabled = False
            btnMinus.Enabled = False
            lstNamen.Enabled = False
            lstNamen.Items.Clear()
            rbClass1.Enabled = False
            rbClass3.Enabled = False
            cbCCA.Enabled = False
            btnGenerate.Enabled = False
            btnGenerate.BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        strWo = My.Resources.CAcert_CSR_UI.csr_strWoCSR
        webCAcert.Navigate(My.Settings(My.Settings.accServer & My.Settings.accTyp & "Server").ToString.Replace("http://", "https://") & My.Settings(gbTyp.Tag.ToString & gbArt.Tag.ToString).ToString)
    End Sub

    Private Sub DeutschToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeutschToolStripMenuItem.Click
        My.Settings.Language = "de"
        Init()
    End Sub

    Private Sub EnglischToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglischToolStripMenuItem.Click
        My.Settings.Language = "en"
        Init()
    End Sub

    Private Sub Init()
        System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(My.Settings.Language)

        Me.DateiToolStripMenuItem1.Text = My.Resources.CAcert_CSR_UI.mnuFile
        Me.BeendenToolStripMenuItem1.Text = My.Resources.CAcert_CSR_UI.mnuQuit

        Me.OptionToolStripMenuItem.Text = My.Resources.CAcert_CSR_UI.mnuTools
        Me.EinstellungenToolStripMenuItem1.Text = My.Resources.CAcert_CSR_UI.mnuSettings
        Me.SpracheToolStripMenuItem.Text = My.Resources.CAcert_CSR_UI.mnuLanguage
        Me.DeutschToolStripMenuItem.Text = My.Resources.CAcert_CSR_UI.Language_DE
        Me.EnglischToolStripMenuItem.Text = My.Resources.CAcert_CSR_UI.Language_EN

        Select Case My.Settings.Language
            Case "en"
                Me.EnglischToolStripMenuItem.Checked = True
                Me.DeutschToolStripMenuItem.Checked = False
            Case "de"
                Me.EnglischToolStripMenuItem.Checked = False
                Me.DeutschToolStripMenuItem.Checked = True
        End Select

        Me.HilfeToolStripMenuItem1.Text = My.Resources.CAcert_CSR_UI.mnuHelp
        Me.InfoToolStripMenuItem1.Text = My.Resources.CAcert_CSR_UI.mnuInfo

        Me.tpCreate.Text = My.Resources.CAcert_CSR_UI.csr_tpCreate
        Me.lblCommon.Text = My.Resources.CAcert_CSR_UI.csr_lblCommon

        Me.gbTyp.Text = My.Resources.CAcert_CSR_UI.csr_gbTyp
        Me.rbPrivat.Text = My.Resources.CAcert_CSR_UI.csr_rbPrivate
        Me.rbOrg.Text = My.Resources.CAcert_CSR_UI.csr_rbOrganisation

        Me.gbArt.Text = My.Resources.CAcert_CSR_UI.csr_gbArt
        Me.rbClient.Text = My.Resources.CAcert_CSR_UI.csr_rbClient
        Me.rbServer.Text = My.Resources.CAcert_CSR_UI.csr_rbServer

        Me.lblNamen.Text = My.Resources.CAcert_CSR_UI.csr_lblNamen
        Me.btnClear.Text = My.Resources.CAcert_CSR_UI.btnClear
        Me.btnClearAll.Text = My.Resources.CAcert_CSR_UI.btnClearAll
        Me.lblClass.Text = My.Resources.CAcert_CSR_UI.csr_lblClass

        Me.btnGenerate.Text = My.Resources.CAcert_CSR_UI.csr_btnGenerate
        Me.btnCAcertSig.Text = My.Resources.CAcert_CSR_UI.csr_btnCAcertSig
        Me.btnCAcertFin.Text = My.Resources.CAcert_CSR_UI.csr_btnCAcertFin
        Me.btnCACertSave.Text = My.Resources.CAcert_CSR_UI.csr_btnCAcertSave
    End Sub
End Class
