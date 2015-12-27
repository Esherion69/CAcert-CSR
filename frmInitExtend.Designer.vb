<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInitExtend
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInitExtend))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.fbdSettings = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblProdPassServ = New System.Windows.Forms.Label()
        Me.lblTestPassServ = New System.Windows.Forms.Label()
        Me.txtProdPassServ = New System.Windows.Forms.TextBox()
        Me.txtTestPassServ = New System.Windows.Forms.TextBox()
        Me.lblUserClient = New System.Windows.Forms.Label()
        Me.lblOrgClient = New System.Windows.Forms.Label()
        Me.lblUserServer = New System.Windows.Forms.Label()
        Me.lblOrgServer = New System.Windows.Forms.Label()
        Me.txtUserClient = New System.Windows.Forms.TextBox()
        Me.txtOrgClient = New System.Windows.Forms.TextBox()
        Me.txtUserServ = New System.Windows.Forms.TextBox()
        Me.txtOrgServer = New System.Windows.Forms.TextBox()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.rbCertificate = New System.Windows.Forms.RadioButton()
        Me.rbPassword = New System.Windows.Forms.RadioButton()
        Me.txtProdCertServ = New System.Windows.Forms.TextBox()
        Me.lblProdCertServ = New System.Windows.Forms.Label()
        Me.txtTestCertServ = New System.Windows.Forms.TextBox()
        Me.lblTestCertServ = New System.Windows.Forms.Label()
        Me.txtAccLogout = New System.Windows.Forms.TextBox()
        Me.txtAccLogin = New System.Windows.Forms.TextBox()
        Me.lblAccLogout = New System.Windows.Forms.Label()
        Me.lblAccLogin = New System.Windows.Forms.Label()
        Me.gbLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(380, 277)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'fbdSettings
        '
        Me.fbdSettings.SelectedPath = "c:\"
        '
        'lblProdPassServ
        '
        Me.lblProdPassServ.AutoSize = True
        Me.lblProdPassServ.Location = New System.Drawing.Point(12, 9)
        Me.lblProdPassServ.Name = "lblProdPassServ"
        Me.lblProdPassServ.Size = New System.Drawing.Size(138, 13)
        Me.lblProdPassServ.TabIndex = 0
        Me.lblProdPassServ.Text = "Produktiv Server (Passwort)"
        '
        'lblTestPassServ
        '
        Me.lblTestPassServ.AutoSize = True
        Me.lblTestPassServ.Location = New System.Drawing.Point(12, 61)
        Me.lblTestPassServ.Name = "lblTestPassServ"
        Me.lblTestPassServ.Size = New System.Drawing.Size(114, 13)
        Me.lblTestPassServ.TabIndex = 2
        Me.lblTestPassServ.Text = "Test Server (Passwort)"
        '
        'txtProdPassServ
        '
        Me.txtProdPassServ.Location = New System.Drawing.Point(153, 6)
        Me.txtProdPassServ.Name = "txtProdPassServ"
        Me.txtProdPassServ.Size = New System.Drawing.Size(310, 20)
        Me.txtProdPassServ.TabIndex = 1
        '
        'txtTestPassServ
        '
        Me.txtTestPassServ.Location = New System.Drawing.Point(153, 58)
        Me.txtTestPassServ.Name = "txtTestPassServ"
        Me.txtTestPassServ.Size = New System.Drawing.Size(310, 20)
        Me.txtTestPassServ.TabIndex = 3
        '
        'lblUserClient
        '
        Me.lblUserClient.AutoSize = True
        Me.lblUserClient.Location = New System.Drawing.Point(12, 113)
        Me.lblUserClient.Name = "lblUserClient"
        Me.lblUserClient.Size = New System.Drawing.Size(78, 13)
        Me.lblUserClient.TabIndex = 4
        Me.lblUserClient.Text = "Benutzer Client"
        '
        'lblOrgClient
        '
        Me.lblOrgClient.AutoSize = True
        Me.lblOrgClient.Location = New System.Drawing.Point(12, 139)
        Me.lblOrgClient.Name = "lblOrgClient"
        Me.lblOrgClient.Size = New System.Drawing.Size(95, 13)
        Me.lblOrgClient.TabIndex = 6
        Me.lblOrgClient.Text = "Organisation Client"
        '
        'lblUserServer
        '
        Me.lblUserServer.AutoSize = True
        Me.lblUserServer.Location = New System.Drawing.Point(12, 165)
        Me.lblUserServer.Name = "lblUserServer"
        Me.lblUserServer.Size = New System.Drawing.Size(83, 13)
        Me.lblUserServer.TabIndex = 8
        Me.lblUserServer.Text = "Benutzer Server"
        '
        'lblOrgServer
        '
        Me.lblOrgServer.AutoSize = True
        Me.lblOrgServer.Location = New System.Drawing.Point(12, 191)
        Me.lblOrgServer.Name = "lblOrgServer"
        Me.lblOrgServer.Size = New System.Drawing.Size(100, 13)
        Me.lblOrgServer.TabIndex = 10
        Me.lblOrgServer.Text = "Organisation Server"
        '
        'txtUserClient
        '
        Me.txtUserClient.Location = New System.Drawing.Point(153, 110)
        Me.txtUserClient.Name = "txtUserClient"
        Me.txtUserClient.Size = New System.Drawing.Size(310, 20)
        Me.txtUserClient.TabIndex = 5
        '
        'txtOrgClient
        '
        Me.txtOrgClient.Location = New System.Drawing.Point(153, 136)
        Me.txtOrgClient.Name = "txtOrgClient"
        Me.txtOrgClient.Size = New System.Drawing.Size(310, 20)
        Me.txtOrgClient.TabIndex = 7
        '
        'txtUserServ
        '
        Me.txtUserServ.Location = New System.Drawing.Point(153, 162)
        Me.txtUserServ.Name = "txtUserServ"
        Me.txtUserServ.Size = New System.Drawing.Size(310, 20)
        Me.txtUserServ.TabIndex = 9
        '
        'txtOrgServer
        '
        Me.txtOrgServer.Location = New System.Drawing.Point(153, 188)
        Me.txtOrgServer.Name = "txtOrgServer"
        Me.txtOrgServer.Size = New System.Drawing.Size(310, 20)
        Me.txtOrgServer.TabIndex = 11
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.rbCertificate)
        Me.gbLogin.Controls.Add(Me.rbPassword)
        Me.gbLogin.Location = New System.Drawing.Point(153, 266)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(174, 44)
        Me.gbLogin.TabIndex = 12
        Me.gbLogin.TabStop = False
        Me.gbLogin.Text = "Anmelden mit"
        '
        'rbCertificate
        '
        Me.rbCertificate.AutoSize = True
        Me.rbCertificate.Location = New System.Drawing.Point(102, 19)
        Me.rbCertificate.Name = "rbCertificate"
        Me.rbCertificate.Size = New System.Drawing.Size(66, 17)
        Me.rbCertificate.TabIndex = 1
        Me.rbCertificate.TabStop = True
        Me.rbCertificate.Text = "Zertifikat"
        Me.rbCertificate.UseVisualStyleBackColor = True
        '
        'rbPassword
        '
        Me.rbPassword.AutoSize = True
        Me.rbPassword.Location = New System.Drawing.Point(6, 19)
        Me.rbPassword.Name = "rbPassword"
        Me.rbPassword.Size = New System.Drawing.Size(68, 17)
        Me.rbPassword.TabIndex = 0
        Me.rbPassword.TabStop = True
        Me.rbPassword.Text = "Passwort"
        Me.rbPassword.UseVisualStyleBackColor = True
        '
        'txtProdCertServ
        '
        Me.txtProdCertServ.Location = New System.Drawing.Point(153, 32)
        Me.txtProdCertServ.Name = "txtProdCertServ"
        Me.txtProdCertServ.Size = New System.Drawing.Size(310, 20)
        Me.txtProdCertServ.TabIndex = 15
        '
        'lblProdCertServ
        '
        Me.lblProdCertServ.AutoSize = True
        Me.lblProdCertServ.Location = New System.Drawing.Point(12, 35)
        Me.lblProdCertServ.Name = "lblProdCertServ"
        Me.lblProdCertServ.Size = New System.Drawing.Size(136, 13)
        Me.lblProdCertServ.TabIndex = 14
        Me.lblProdCertServ.Text = "Produktiv Server (Zertifikat)"
        '
        'txtTestCertServ
        '
        Me.txtTestCertServ.Location = New System.Drawing.Point(153, 84)
        Me.txtTestCertServ.Name = "txtTestCertServ"
        Me.txtTestCertServ.Size = New System.Drawing.Size(310, 20)
        Me.txtTestCertServ.TabIndex = 17
        '
        'lblTestCertServ
        '
        Me.lblTestCertServ.AutoSize = True
        Me.lblTestCertServ.Location = New System.Drawing.Point(12, 87)
        Me.lblTestCertServ.Name = "lblTestCertServ"
        Me.lblTestCertServ.Size = New System.Drawing.Size(112, 13)
        Me.lblTestCertServ.TabIndex = 16
        Me.lblTestCertServ.Text = "Test Server (Zertifikat)"
        '
        'txtAccLogout
        '
        Me.txtAccLogout.Location = New System.Drawing.Point(153, 240)
        Me.txtAccLogout.Name = "txtAccLogout"
        Me.txtAccLogout.Size = New System.Drawing.Size(310, 20)
        Me.txtAccLogout.TabIndex = 21
        '
        'txtAccLogin
        '
        Me.txtAccLogin.Location = New System.Drawing.Point(153, 214)
        Me.txtAccLogin.Name = "txtAccLogin"
        Me.txtAccLogin.Size = New System.Drawing.Size(310, 20)
        Me.txtAccLogin.TabIndex = 19
        '
        'lblAccLogout
        '
        Me.lblAccLogout.AutoSize = True
        Me.lblAccLogout.Location = New System.Drawing.Point(12, 243)
        Me.lblAccLogout.Name = "lblAccLogout"
        Me.lblAccLogout.Size = New System.Drawing.Size(40, 13)
        Me.lblAccLogout.TabIndex = 20
        Me.lblAccLogout.Text = "Logout"
        '
        'lblAccLogin
        '
        Me.lblAccLogin.AutoSize = True
        Me.lblAccLogin.Location = New System.Drawing.Point(12, 217)
        Me.lblAccLogin.Name = "lblAccLogin"
        Me.lblAccLogin.Size = New System.Drawing.Size(33, 13)
        Me.lblAccLogin.TabIndex = 18
        Me.lblAccLogin.Text = "Login"
        '
        'frmInitExtend
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 314)
        Me.Controls.Add(Me.txtAccLogout)
        Me.Controls.Add(Me.txtAccLogin)
        Me.Controls.Add(Me.lblAccLogout)
        Me.Controls.Add(Me.lblAccLogin)
        Me.Controls.Add(Me.txtTestCertServ)
        Me.Controls.Add(Me.lblTestCertServ)
        Me.Controls.Add(Me.txtProdCertServ)
        Me.Controls.Add(Me.lblProdCertServ)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.txtOrgServer)
        Me.Controls.Add(Me.txtUserServ)
        Me.Controls.Add(Me.txtOrgClient)
        Me.Controls.Add(Me.txtUserClient)
        Me.Controls.Add(Me.lblOrgServer)
        Me.Controls.Add(Me.lblUserServer)
        Me.Controls.Add(Me.lblOrgClient)
        Me.Controls.Add(Me.lblUserClient)
        Me.Controls.Add(Me.txtTestPassServ)
        Me.Controls.Add(Me.txtProdPassServ)
        Me.Controls.Add(Me.lblTestPassServ)
        Me.Controls.Add(Me.lblProdPassServ)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInitExtend"
        Me.Text = "frmInit"
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents fbdSettings As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblProdPassServ As System.Windows.Forms.Label
    Friend WithEvents lblTestPassServ As System.Windows.Forms.Label
    Friend WithEvents txtProdPassServ As System.Windows.Forms.TextBox
    Friend WithEvents txtTestPassServ As System.Windows.Forms.TextBox
    Friend WithEvents lblUserClient As System.Windows.Forms.Label
    Friend WithEvents lblOrgClient As System.Windows.Forms.Label
    Friend WithEvents lblUserServer As System.Windows.Forms.Label
    Friend WithEvents lblOrgServer As System.Windows.Forms.Label
    Friend WithEvents txtUserClient As System.Windows.Forms.TextBox
    Friend WithEvents txtOrgClient As System.Windows.Forms.TextBox
    Friend WithEvents txtUserServ As System.Windows.Forms.TextBox
    Friend WithEvents txtOrgServer As System.Windows.Forms.TextBox
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents rbCertificate As RadioButton
    Friend WithEvents rbPassword As RadioButton
    Friend WithEvents txtProdCertServ As TextBox
    Friend WithEvents lblProdCertServ As Label
    Friend WithEvents txtTestCertServ As TextBox
    Friend WithEvents lblTestCertServ As Label
    Friend WithEvents txtAccLogout As TextBox
    Friend WithEvents txtAccLogin As TextBox
    Friend WithEvents lblAccLogout As Label
    Friend WithEvents lblAccLogin As Label
End Class
