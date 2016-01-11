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
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'fbdSettings
        '
        resources.ApplyResources(Me.fbdSettings, "fbdSettings")
        '
        'lblProdPassServ
        '
        resources.ApplyResources(Me.lblProdPassServ, "lblProdPassServ")
        Me.lblProdPassServ.Name = "lblProdPassServ"
        '
        'lblTestPassServ
        '
        resources.ApplyResources(Me.lblTestPassServ, "lblTestPassServ")
        Me.lblTestPassServ.Name = "lblTestPassServ"
        '
        'txtProdPassServ
        '
        resources.ApplyResources(Me.txtProdPassServ, "txtProdPassServ")
        Me.txtProdPassServ.Name = "txtProdPassServ"
        '
        'txtTestPassServ
        '
        resources.ApplyResources(Me.txtTestPassServ, "txtTestPassServ")
        Me.txtTestPassServ.Name = "txtTestPassServ"
        '
        'lblUserClient
        '
        resources.ApplyResources(Me.lblUserClient, "lblUserClient")
        Me.lblUserClient.Name = "lblUserClient"
        '
        'lblOrgClient
        '
        resources.ApplyResources(Me.lblOrgClient, "lblOrgClient")
        Me.lblOrgClient.Name = "lblOrgClient"
        '
        'lblUserServer
        '
        resources.ApplyResources(Me.lblUserServer, "lblUserServer")
        Me.lblUserServer.Name = "lblUserServer"
        '
        'lblOrgServer
        '
        resources.ApplyResources(Me.lblOrgServer, "lblOrgServer")
        Me.lblOrgServer.Name = "lblOrgServer"
        '
        'txtUserClient
        '
        resources.ApplyResources(Me.txtUserClient, "txtUserClient")
        Me.txtUserClient.Name = "txtUserClient"
        '
        'txtOrgClient
        '
        resources.ApplyResources(Me.txtOrgClient, "txtOrgClient")
        Me.txtOrgClient.Name = "txtOrgClient"
        '
        'txtUserServ
        '
        resources.ApplyResources(Me.txtUserServ, "txtUserServ")
        Me.txtUserServ.Name = "txtUserServ"
        '
        'txtOrgServer
        '
        resources.ApplyResources(Me.txtOrgServer, "txtOrgServer")
        Me.txtOrgServer.Name = "txtOrgServer"
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.rbCertificate)
        Me.gbLogin.Controls.Add(Me.rbPassword)
        resources.ApplyResources(Me.gbLogin, "gbLogin")
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.TabStop = False
        '
        'rbCertificate
        '
        resources.ApplyResources(Me.rbCertificate, "rbCertificate")
        Me.rbCertificate.Name = "rbCertificate"
        Me.rbCertificate.TabStop = True
        Me.rbCertificate.UseVisualStyleBackColor = True
        '
        'rbPassword
        '
        resources.ApplyResources(Me.rbPassword, "rbPassword")
        Me.rbPassword.Name = "rbPassword"
        Me.rbPassword.TabStop = True
        Me.rbPassword.UseVisualStyleBackColor = True
        '
        'txtProdCertServ
        '
        resources.ApplyResources(Me.txtProdCertServ, "txtProdCertServ")
        Me.txtProdCertServ.Name = "txtProdCertServ"
        '
        'lblProdCertServ
        '
        resources.ApplyResources(Me.lblProdCertServ, "lblProdCertServ")
        Me.lblProdCertServ.Name = "lblProdCertServ"
        '
        'txtTestCertServ
        '
        resources.ApplyResources(Me.txtTestCertServ, "txtTestCertServ")
        Me.txtTestCertServ.Name = "txtTestCertServ"
        '
        'lblTestCertServ
        '
        resources.ApplyResources(Me.lblTestCertServ, "lblTestCertServ")
        Me.lblTestCertServ.Name = "lblTestCertServ"
        '
        'txtAccLogout
        '
        resources.ApplyResources(Me.txtAccLogout, "txtAccLogout")
        Me.txtAccLogout.Name = "txtAccLogout"
        '
        'txtAccLogin
        '
        resources.ApplyResources(Me.txtAccLogin, "txtAccLogin")
        Me.txtAccLogin.Name = "txtAccLogin"
        '
        'lblAccLogout
        '
        resources.ApplyResources(Me.lblAccLogout, "lblAccLogout")
        Me.lblAccLogout.Name = "lblAccLogout"
        '
        'lblAccLogin
        '
        resources.ApplyResources(Me.lblAccLogin, "lblAccLogin")
        Me.lblAccLogin.Name = "lblAccLogin"
        '
        'frmInitExtend
        '
        Me.AcceptButton = Me.btnOK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Name = "frmInitExtend"
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
