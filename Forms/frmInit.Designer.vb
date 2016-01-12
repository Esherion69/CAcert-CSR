<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInit
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInit))
        Me.lblSSL = New System.Windows.Forms.Label()
        Me.txtSSL = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.fbdSettings = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblOrg = New System.Windows.Forms.Label()
        Me.lblDep = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtOrg = New System.Windows.Forms.TextBox()
        Me.txtDep = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblAdr1 = New System.Windows.Forms.Label()
        Me.lblAdr2 = New System.Windows.Forms.Label()
        Me.lblAdr3 = New System.Windows.Forms.Label()
        Me.lblPlz = New System.Windows.Forms.Label()
        Me.txtAdr1 = New System.Windows.Forms.TextBox()
        Me.txtAdr2 = New System.Windows.Forms.TextBox()
        Me.txtAdr3 = New System.Windows.Forms.TextBox()
        Me.txtPlz = New System.Windows.Forms.TextBox()
        Me.gbServer = New System.Windows.Forms.GroupBox()
        Me.rbTest = New System.Windows.Forms.RadioButton()
        Me.rbProd = New System.Windows.Forms.RadioButton()
        Me.gbAddress = New System.Windows.Forms.GroupBox()
        Me.gbOpenSSL = New System.Windows.Forms.GroupBox()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.btnExtend = New System.Windows.Forms.Button()
        Me.gbCertificate = New System.Windows.Forms.GroupBox()
        Me.txtCertPass = New System.Windows.Forms.TextBox()
        Me.lblCertPass = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.gbServer.SuspendLayout()
        Me.gbAddress.SuspendLayout()
        Me.gbOpenSSL.SuspendLayout()
        Me.gbUser.SuspendLayout()
        Me.gbCertificate.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSSL
        '
        Me.lblSSL.AutoSize = True
        Me.lblSSL.Location = New System.Drawing.Point(7, 20)
        Me.lblSSL.Name = "lblSSL"
        Me.lblSSL.Size = New System.Drawing.Size(78, 13)
        Me.lblSSL.TabIndex = 0
        Me.lblSSL.Text = "OpenSSL Pfad"
        '
        'txtSSL
        '
        Me.txtSSL.Location = New System.Drawing.Point(116, 17)
        Me.txtSSL.Name = "txtSSL"
        Me.txtSSL.Size = New System.Drawing.Size(342, 20)
        Me.txtSSL.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(487, 539)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 26
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(487, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(83, 23)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Durchsuchen"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'fbdSettings
        '
        Me.fbdSettings.SelectedPath = "c:\"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(7, 228)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(61, 13)
        Me.lblCountry.TabIndex = 18
        Me.lblCountry.Text = "Land/Staat"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(116, 225)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(342, 20)
        Me.txtCountry.TabIndex = 19
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(7, 202)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(97, 13)
        Me.lblState.TabIndex = 16
        Me.lblState.Text = "Bundesland/Bezirk"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(116, 199)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(342, 20)
        Me.txtState.TabIndex = 17
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(7, 176)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(21, 13)
        Me.lblCity.TabIndex = 14
        Me.lblCity.Text = "Ort"
        '
        'lblOrg
        '
        Me.lblOrg.AutoSize = True
        Me.lblOrg.Location = New System.Drawing.Point(7, 20)
        Me.lblOrg.Name = "lblOrg"
        Me.lblOrg.Size = New System.Drawing.Size(66, 13)
        Me.lblOrg.TabIndex = 2
        Me.lblOrg.Text = "Organisation"
        '
        'lblDep
        '
        Me.lblDep.AutoSize = True
        Me.lblDep.Location = New System.Drawing.Point(7, 46)
        Me.lblDep.Name = "lblDep"
        Me.lblDep.Size = New System.Drawing.Size(51, 13)
        Me.lblDep.TabIndex = 4
        Me.lblDep.Text = "Abteilung"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(116, 173)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(342, 20)
        Me.txtCity.TabIndex = 15
        '
        'txtOrg
        '
        Me.txtOrg.Location = New System.Drawing.Point(116, 17)
        Me.txtOrg.Name = "txtOrg"
        Me.txtOrg.Size = New System.Drawing.Size(342, 20)
        Me.txtOrg.TabIndex = 3
        '
        'txtDep
        '
        Me.txtDep.Location = New System.Drawing.Point(116, 43)
        Me.txtDep.Name = "txtDep"
        Me.txtDep.Size = New System.Drawing.Size(342, 20)
        Me.txtDep.TabIndex = 5
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(10, 25)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(36, 13)
        Me.lblMail.TabIndex = 20
        Me.lblMail.Text = "E-Mail"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(119, 22)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(342, 20)
        Me.txtMail.TabIndex = 21
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(10, 50)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(50, 13)
        Me.lblPass.TabIndex = 22
        Me.lblPass.Text = "Passwort"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(119, 47)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(342, 20)
        Me.txtPass.TabIndex = 23
        Me.txtPass.Text = "6"
        Me.txtPass.UseSystemPasswordChar = True
        '
        'lblAdr1
        '
        Me.lblAdr1.AutoSize = True
        Me.lblAdr1.Location = New System.Drawing.Point(7, 72)
        Me.lblAdr1.Name = "lblAdr1"
        Me.lblAdr1.Size = New System.Drawing.Size(51, 13)
        Me.lblAdr1.TabIndex = 6
        Me.lblAdr1.Text = "Adresse1"
        '
        'lblAdr2
        '
        Me.lblAdr2.AutoSize = True
        Me.lblAdr2.Location = New System.Drawing.Point(7, 98)
        Me.lblAdr2.Name = "lblAdr2"
        Me.lblAdr2.Size = New System.Drawing.Size(51, 13)
        Me.lblAdr2.TabIndex = 8
        Me.lblAdr2.Text = "Adresse2"
        '
        'lblAdr3
        '
        Me.lblAdr3.AutoSize = True
        Me.lblAdr3.Location = New System.Drawing.Point(7, 124)
        Me.lblAdr3.Name = "lblAdr3"
        Me.lblAdr3.Size = New System.Drawing.Size(51, 13)
        Me.lblAdr3.TabIndex = 10
        Me.lblAdr3.Text = "Adresse3"
        '
        'lblPlz
        '
        Me.lblPlz.AutoSize = True
        Me.lblPlz.Location = New System.Drawing.Point(7, 150)
        Me.lblPlz.Name = "lblPlz"
        Me.lblPlz.Size = New System.Drawing.Size(60, 13)
        Me.lblPlz.TabIndex = 12
        Me.lblPlz.Text = "Postleitzahl"
        '
        'txtAdr1
        '
        Me.txtAdr1.Location = New System.Drawing.Point(116, 69)
        Me.txtAdr1.Name = "txtAdr1"
        Me.txtAdr1.Size = New System.Drawing.Size(342, 20)
        Me.txtAdr1.TabIndex = 7
        '
        'txtAdr2
        '
        Me.txtAdr2.Location = New System.Drawing.Point(116, 95)
        Me.txtAdr2.Name = "txtAdr2"
        Me.txtAdr2.Size = New System.Drawing.Size(342, 20)
        Me.txtAdr2.TabIndex = 9
        '
        'txtAdr3
        '
        Me.txtAdr3.Location = New System.Drawing.Point(116, 121)
        Me.txtAdr3.Name = "txtAdr3"
        Me.txtAdr3.Size = New System.Drawing.Size(342, 20)
        Me.txtAdr3.TabIndex = 11
        '
        'txtPlz
        '
        Me.txtPlz.Location = New System.Drawing.Point(116, 147)
        Me.txtPlz.Name = "txtPlz"
        Me.txtPlz.Size = New System.Drawing.Size(342, 20)
        Me.txtPlz.TabIndex = 13
        '
        'gbServer
        '
        Me.gbServer.BackColor = System.Drawing.Color.Lime
        Me.gbServer.Controls.Add(Me.rbTest)
        Me.gbServer.Controls.Add(Me.rbProd)
        Me.gbServer.Location = New System.Drawing.Point(12, 354)
        Me.gbServer.Name = "gbServer"
        Me.gbServer.Size = New System.Drawing.Size(469, 48)
        Me.gbServer.TabIndex = 27
        Me.gbServer.TabStop = False
        Me.gbServer.Text = "Server Umgebung"
        '
        'rbTest
        '
        Me.rbTest.AutoSize = True
        Me.rbTest.Location = New System.Drawing.Point(116, 22)
        Me.rbTest.Name = "rbTest"
        Me.rbTest.Size = New System.Drawing.Size(46, 17)
        Me.rbTest.TabIndex = 1
        Me.rbTest.Text = "Test"
        Me.rbTest.UseVisualStyleBackColor = True
        '
        'rbProd
        '
        Me.rbProd.AutoSize = True
        Me.rbProd.Location = New System.Drawing.Point(6, 22)
        Me.rbProd.Name = "rbProd"
        Me.rbProd.Size = New System.Drawing.Size(70, 17)
        Me.rbProd.TabIndex = 0
        Me.rbProd.Text = "Produktiv"
        Me.rbProd.UseVisualStyleBackColor = True
        '
        'gbAddress
        '
        Me.gbAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbAddress.Controls.Add(Me.lblInfo)
        Me.gbAddress.Controls.Add(Me.txtPlz)
        Me.gbAddress.Controls.Add(Me.txtAdr3)
        Me.gbAddress.Controls.Add(Me.txtAdr2)
        Me.gbAddress.Controls.Add(Me.txtAdr1)
        Me.gbAddress.Controls.Add(Me.lblPlz)
        Me.gbAddress.Controls.Add(Me.lblAdr3)
        Me.gbAddress.Controls.Add(Me.lblAdr2)
        Me.gbAddress.Controls.Add(Me.lblAdr1)
        Me.gbAddress.Controls.Add(Me.txtDep)
        Me.gbAddress.Controls.Add(Me.txtOrg)
        Me.gbAddress.Controls.Add(Me.txtCity)
        Me.gbAddress.Controls.Add(Me.lblDep)
        Me.gbAddress.Controls.Add(Me.lblOrg)
        Me.gbAddress.Controls.Add(Me.lblCity)
        Me.gbAddress.Controls.Add(Me.txtState)
        Me.gbAddress.Controls.Add(Me.lblState)
        Me.gbAddress.Controls.Add(Me.txtCountry)
        Me.gbAddress.Controls.Add(Me.lblCountry)
        Me.gbAddress.Location = New System.Drawing.Point(12, 66)
        Me.gbAddress.Name = "gbAddress"
        Me.gbAddress.Size = New System.Drawing.Size(469, 282)
        Me.gbAddress.TabIndex = 28
        Me.gbAddress.TabStop = False
        Me.gbAddress.Text = "Adresse"
        '
        'gbOpenSSL
        '
        Me.gbOpenSSL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbOpenSSL.Controls.Add(Me.txtSSL)
        Me.gbOpenSSL.Controls.Add(Me.lblSSL)
        Me.gbOpenSSL.Location = New System.Drawing.Point(12, 12)
        Me.gbOpenSSL.Name = "gbOpenSSL"
        Me.gbOpenSSL.Size = New System.Drawing.Size(469, 48)
        Me.gbOpenSSL.TabIndex = 29
        Me.gbOpenSSL.TabStop = False
        Me.gbOpenSSL.Text = "openSSL"
        '
        'gbUser
        '
        Me.gbUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbUser.Controls.Add(Me.txtPass)
        Me.gbUser.Controls.Add(Me.lblPass)
        Me.gbUser.Controls.Add(Me.txtMail)
        Me.gbUser.Controls.Add(Me.lblMail)
        Me.gbUser.Location = New System.Drawing.Point(12, 417)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(469, 88)
        Me.gbUser.TabIndex = 30
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "Benutzer"
        '
        'btnExtend
        '
        Me.btnExtend.BackColor = System.Drawing.Color.Lime
        Me.btnExtend.Location = New System.Drawing.Point(487, 354)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(83, 23)
        Me.btnExtend.TabIndex = 31
        Me.btnExtend.Text = "Erweitert"
        Me.btnExtend.UseVisualStyleBackColor = False
        '
        'gbCertificate
        '
        Me.gbCertificate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbCertificate.Controls.Add(Me.txtCertPass)
        Me.gbCertificate.Controls.Add(Me.lblCertPass)
        Me.gbCertificate.Location = New System.Drawing.Point(12, 512)
        Me.gbCertificate.Name = "gbCertificate"
        Me.gbCertificate.Size = New System.Drawing.Size(469, 50)
        Me.gbCertificate.TabIndex = 32
        Me.gbCertificate.TabStop = False
        Me.gbCertificate.Text = "Zertfikat"
        '
        'txtCertPass
        '
        Me.txtCertPass.Location = New System.Drawing.Point(119, 19)
        Me.txtCertPass.Name = "txtCertPass"
        Me.txtCertPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCertPass.Size = New System.Drawing.Size(342, 20)
        Me.txtCertPass.TabIndex = 25
        Me.txtCertPass.Text = "6"
        Me.txtCertPass.UseSystemPasswordChar = True
        '
        'lblCertPass
        '
        Me.lblCertPass.AutoSize = True
        Me.lblCertPass.Location = New System.Drawing.Point(7, 22)
        Me.lblCertPass.Name = "lblCertPass"
        Me.lblCertPass.Size = New System.Drawing.Size(90, 13)
        Me.lblCertPass.TabIndex = 24
        Me.lblCertPass.Text = "Passwort (testpw)"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(116, 252)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(39, 13)
        Me.lblInfo.TabIndex = 20
        Me.lblInfo.Text = "Label1"
        '
        'frmInit
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 564)
        Me.Controls.Add(Me.gbCertificate)
        Me.Controls.Add(Me.btnExtend)
        Me.Controls.Add(Me.gbUser)
        Me.Controls.Add(Me.gbOpenSSL)
        Me.Controls.Add(Me.gbAddress)
        Me.Controls.Add(Me.gbServer)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInit"
        Me.Text = "Einstellungen"
        Me.gbServer.ResumeLayout(False)
        Me.gbServer.PerformLayout()
        Me.gbAddress.ResumeLayout(False)
        Me.gbAddress.PerformLayout()
        Me.gbOpenSSL.ResumeLayout(False)
        Me.gbOpenSSL.PerformLayout()
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        Me.gbCertificate.ResumeLayout(False)
        Me.gbCertificate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSSL As System.Windows.Forms.Label
    Friend WithEvents txtSSL As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents fbdSettings As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblOrg As System.Windows.Forms.Label
    Friend WithEvents lblDep As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtOrg As System.Windows.Forms.TextBox
    Friend WithEvents txtDep As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblAdr1 As System.Windows.Forms.Label
    Friend WithEvents lblAdr2 As System.Windows.Forms.Label
    Friend WithEvents lblAdr3 As System.Windows.Forms.Label
    Friend WithEvents lblPlz As System.Windows.Forms.Label
    Friend WithEvents txtAdr1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlz As System.Windows.Forms.TextBox
    Friend WithEvents gbServer As System.Windows.Forms.GroupBox
    Friend WithEvents rbTest As System.Windows.Forms.RadioButton
    Friend WithEvents rbProd As System.Windows.Forms.RadioButton
    Friend WithEvents gbAddress As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpenSSL As System.Windows.Forms.GroupBox
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents btnExtend As System.Windows.Forms.Button
    Friend WithEvents gbCertificate As GroupBox
    Friend WithEvents txtCertPass As TextBox
    Friend WithEvents lblCertPass As Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
End Class
