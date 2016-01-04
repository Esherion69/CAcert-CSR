Imports System.Collections.Specialized

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
            MsgBox("Bitte eine Auswahl bei ""Anmelden mit"" machen",, "Fehler")
        End If
    End Sub

End Class