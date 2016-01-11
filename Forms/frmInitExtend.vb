Imports System.Collections.Specialized
Imports System.Globalization

Public Class frmInitExtend

    Private Sub frmInit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtProdPassServ.Text = My.Settings.prodPassServer
        txtProdCertServ.Text = My.Settings.prodCertServer
        txtTestPassServ.Text = My.Settings.testPassServer
        txtTestCertServ.Text = My.Settings.testCertServer
        txtUserClient.Text = My.Settings.usrClient
        txtOrgClient.Text = My.Settings.orgClient
        txtUserServ.Text = My.Settings.usrServer
        txtOrgServer.Text = My.Settings.orgServer
        txtAccLogin.Text = My.Settings.accLogin
        txtAccLogout.Text = My.Settings.accLogout
        Select Case My.Settings.accTyp
            Case "Pass"
                rbPassword.Checked = True
            Case "Cert"
                rbCertificate.Checked = True
        End Select

        'Translation
        System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(My.Settings.Language)

        Me.Text = My.Resources.CAcert_CSR_UI.ext_Title

        Me.lblProdPassServ.Text = My.Resources.CAcert_CSR_UI.ext_lblProdPassServ
        Me.lblProdCertServ.Text = My.Resources.CAcert_CSR_UI.ext_lblProdCertServ
        Me.lblTestPassServ.Text = My.Resources.CAcert_CSR_UI.ext_lblTestPassServer
        Me.lblTestCertServ.Text = My.Resources.CAcert_CSR_UI.ext_lblTestCertServer
        Me.lblUserClient.Text = My.Resources.CAcert_CSR_UI.ext_lblUserClient
        Me.lblOrgClient.Text = My.Resources.CAcert_CSR_UI.ext_lblOrgClient
        Me.lblUserServer.Text = My.Resources.CAcert_CSR_UI.ext_lblUserServer
        Me.lblOrgServer.Text = My.Resources.CAcert_CSR_UI.ext_lblOrgServer
        Me.lblAccLogin.Text = My.Resources.CAcert_CSR_UI.ext_lblAccLogin
        Me.lblAccLogout.Text = My.Resources.CAcert_CSR_UI.ext_lblAccLogout

        Me.gbLogin.Text = My.Resources.CAcert_CSR_UI.ext_gbLogin
        Me.rbPassword.Text = My.Resources.CAcert_CSR_UI.ext_rbPassword
        Me.rbCertificate.Text = My.Resources.CAcert_CSR_UI.ext_rbCertificate
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If rbPassword.Checked Or rbCertificate.Checked Then
            My.Settings.prodPassServer = txtProdPassServ.Text
            My.Settings.prodCertServer = txtProdCertServ.Text
            My.Settings.testPassServer = txtTestPassServ.Text
            My.Settings.testCertServer = txtTestCertServ.Text
            My.Settings.usrClient = txtUserClient.Text
            My.Settings.orgClient = txtOrgClient.Text
            My.Settings.usrServer = txtUserServ.Text
            My.Settings.orgServer = txtOrgServer.Text
            My.Settings.accLogin = txtAccLogin.Text
            My.Settings.accLogout = txtAccLogout.Text
            If rbPassword.Checked Then
                My.Settings.accTyp = "Pass"
            End If
            If rbCertificate.Checked Then
                My.Settings.accTyp = "Cert"
            End If
            My.Settings.Save()
            Me.Close()
        Else
            MessageBox.Show(My.Resources.CAcert_CSR_UI.ext_msgLogin, My.Resources.CAcert_CSR_UI.msgTitleError)
        End If
    End Sub

End Class