Public Class frmInit

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
        If txtCertPass.Text = "" Then
            MsgBox("Leeres Passwort nicht erlaubt", MsgBoxStyle.Critical, "Fehler")
            txtCertPass.Focus()
        End If
    End Sub

End Class