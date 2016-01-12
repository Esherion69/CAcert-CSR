Imports System.Globalization

Public Class frmInit
    Private blnError As Boolean = False
    Private blnFocus As Boolean = True

    Private Sub frmInit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSSL.Text = My.Settings.ssl

        txtOrg.Text = My.Settings.Org
        txtDep.Text = My.Settings.Dep
        txtAdr1.Text = My.Settings.Street1
        txtAdr2.Text = My.Settings.Street2
        txtAdr3.Text = My.Settings.Street3
        txtPlz.Text = My.Settings.Postal
        txtCity.Text = My.Settings.City
        txtState.Text = My.Settings.State
        txtCountry.Text = My.Settings.Country

        Select Case My.Settings.accServer
            Case "prod"
                rbProd.Checked = True
            Case "test"
                rbTest.Checked = True
        End Select

        txtMail.Text = My.Settings.Mail
        txtPass.Text = My.Settings.Password

        txtCertPass.Text = My.Settings.certPass

        'Translation
        System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(My.Settings.Language)

        Me.Text = My.Resources.CAcert_CSR_UI.set_Title

        Me.gbOpenSSL.Text = My.Resources.CAcert_CSR_UI.set_gbOpenSSL
        Me.lblSSL.Text = My.Resources.CAcert_CSR_UI.set_lblOpenSSL

        Me.gbAddress.Text = My.Resources.CAcert_CSR_UI.set_gbAddress
        Me.lblOrg.Text = My.Resources.CAcert_CSR_UI.set_lblOrganisation
        Me.lblDep.Text = My.Resources.CAcert_CSR_UI.set_lblOrgUnit
        Me.lblAdr1.Text = My.Resources.CAcert_CSR_UI.set_lblStreet1
        Me.lblAdr2.Text = My.Resources.CAcert_CSR_UI.set_lblStreet2
        Me.lblAdr3.Text = My.Resources.CAcert_CSR_UI.set_lblStreet3
        Me.lblPlz.Text = My.Resources.CAcert_CSR_UI.ste_lblZip
        Me.lblCity.Text = My.Resources.CAcert_CSR_UI.set_lblTown
        Me.lblState.Text = My.Resources.CAcert_CSR_UI.set_lblState
        Me.lblCountry.Text = My.Resources.CAcert_CSR_UI.set_lblCountry
        Me.lblInfo.Text = ""

        Me.gbServer.Text = My.Resources.CAcert_CSR_UI.set_gbEnvironment
        Me.rbProd.Text = My.Resources.CAcert_CSR_UI.set_rbProductive
        Me.rbTest.Text = My.Resources.CAcert_CSR_UI.set_rbTest

        Me.gbUser.Text = My.Resources.CAcert_CSR_UI.set_gbUser
        Me.lblMail.Text = My.Resources.CAcert_CSR_UI.set_lblEmail
        Me.lblPass.Text = My.Resources.CAcert_CSR_UI.set_lblPassword

        Me.gbCertificate.Text = My.Resources.CAcert_CSR_UI.ste_gbCertificate
        Me.lblCertPass.Text = My.Resources.CAcert_CSR_UI.set_lblCertPassword

        Me.btnSearch.Text = My.Resources.CAcert_CSR_UI.btnSearch
        Me.btnExtend.Text = My.Resources.CAcert_CSR_UI.btnExtend
        Me.btnOK.Text = My.Resources.CAcert_CSR_UI.btnOK

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        fbdSettings.ShowDialog()
        txtSSL.Text = fbdSettings.SelectedPath
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        My.Settings.ssl = txtSSL.Text

        My.Settings.Org = txtOrg.Text
        My.Settings.Dep = txtDep.Text
        My.Settings.Street1 = txtAdr1.Text
        My.Settings.Street2 = txtAdr2.Text
        My.Settings.Street3 = txtAdr3.Text
        My.Settings.Postal = txtPlz.Text
        My.Settings.City = txtCity.Text
        My.Settings.State = txtState.Text
        My.Settings.Country = txtCountry.Text

        If rbProd.Checked Then
            My.Settings.accServer = "prod"
        End If
        If rbTest.Checked Then
            My.Settings.accServer = "test"
        End If

        My.Settings.Mail = txtMail.Text
        My.Settings.Password = txtPass.Text

        My.Settings.certPass = txtCertPass.Text

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub btnExtend_Click(sender As Object, e As EventArgs) Handles btnExtend.Click
        frmInitExtend.ShowDialog()
    End Sub

    Private Sub txtCertPass_TextChanged(sender As Object, e As EventArgs) Handles txtCertPass.TextChanged
        If txtCertPass.Text.Trim = "" Then
            MessageBox.Show(My.Resources.CAcert_CSR_UI.set_msgBlankPassword, My.Resources.CAcert_CSR_UI.msgTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCertPass.Focus()
        End If
    End Sub

    Private Sub txtOrg_GotFocus(sender As Object, e As EventArgs) Handles txtOrg.GotFocus, txtOrg.TextChanged, _
        txtDep.GotFocus, txtDep.TextChanged, txtState.GotFocus, txtState.TextChanged, txtCountry.GotFocus, txtCountry.TextChanged, txtCity.GotFocus, txtCity.TextChanged
        Dim txt As TextBox = DirectCast(sender, TextBox)
        Dim strName As String = txt.Name
        Dim intLength As Integer = 0
        Dim strType As String = ""
        Dim strText As String = ""
        Select Case strName
            Case "txtOrg"
                intLength = 64
                strType = My.Resources.CAcert_CSR_UI.set_lblOrganisation & " (O)"
                strText = txt.Text
            Case "txtDep"
                intLength = 64
                strType = My.Resources.CAcert_CSR_UI.set_lblOrgUnit & " (OU)"
                strText = txt.Text
            Case "txtState"
                intLength = 128
                strType = My.Resources.CAcert_CSR_UI.set_lblState & " (ST)"
                strText = txt.Text
            Case "txtCountry"
                intLength = 2
                strType = My.Resources.CAcert_CSR_UI.set_lblCountry & " (C)"
                strText = txt.Text
            Case "txtCity"
                intLength = 128
                strType = My.Resources.CAcert_CSR_UI.set_lblTown & " (L)"
                strText = txt.Text
        End Select

        If intLength < strText.Length And blnError = False Then
            blnError = True
            blnFocus = False
            MessageBox.Show(String.Format(My.Resources.CAcert_CSR_UI.set_msgMaxChar, strType, intLength), My.Resources.CAcert_CSR_UI.msgTitleError)
            blnFocus = True
            txt.BackColor = Color.LightSalmon
        ElseIf intLength >= strText.Length And blnError = True Then
            blnError = False
            txt.BackColor = Color.White
        End If

        Me.lblInfo.Text = String.Format(My.Resources.CAcert_CSR_UI.set_maxChar, strType, intLength, strText.Length)

    End Sub

    Private Sub txtOrg_LostFocus(sender As Object, e As EventArgs) Handles txtOrg.LostFocus, txtDep.LostFocus, txtState.LostFocus, txtCountry.LostFocus, txtCity.LostFocus
        Dim txt As TextBox = DirectCast(sender, TextBox)
        Me.lblInfo.Text = ""
        If blnError = True And blnFocus = True Then
            MessageBox.Show(My.Resources.CAcert_CSR_UI.set_msgLostFocus)
            txt.Select()
        End If
    End Sub


End Class