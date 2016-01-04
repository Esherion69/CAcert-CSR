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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExtend = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtCertPass = New System.Windows.Forms.TextBox()
        Me.lblCertPass = New System.Windows.Forms.Label()
        Me.gbServer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSSL
        '
        resources.ApplyResources(Me.lblSSL, "lblSSL")
        Me.lblSSL.Name = "lblSSL"
        '
        'txtSSL
        '
        resources.ApplyResources(Me.txtSSL, "txtSSL")
        Me.txtSSL.Name = "txtSSL"
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'fbdSettings
        '
        resources.ApplyResources(Me.fbdSettings, "fbdSettings")
        '
        'lblCountry
        '
        resources.ApplyResources(Me.lblCountry, "lblCountry")
        Me.lblCountry.Name = "lblCountry"
        '
        'txtCountry
        '
        resources.ApplyResources(Me.txtCountry, "txtCountry")
        Me.txtCountry.Name = "txtCountry"
        '
        'lblState
        '
        resources.ApplyResources(Me.lblState, "lblState")
        Me.lblState.Name = "lblState"
        '
        'txtState
        '
        resources.ApplyResources(Me.txtState, "txtState")
        Me.txtState.Name = "txtState"
        '
        'lblCity
        '
        resources.ApplyResources(Me.lblCity, "lblCity")
        Me.lblCity.Name = "lblCity"
        '
        'lblOrg
        '
        resources.ApplyResources(Me.lblOrg, "lblOrg")
        Me.lblOrg.Name = "lblOrg"
        '
        'lblDep
        '
        resources.ApplyResources(Me.lblDep, "lblDep")
        Me.lblDep.Name = "lblDep"
        '
        'txtCity
        '
        resources.ApplyResources(Me.txtCity, "txtCity")
        Me.txtCity.Name = "txtCity"
        '
        'txtOrg
        '
        resources.ApplyResources(Me.txtOrg, "txtOrg")
        Me.txtOrg.Name = "txtOrg"
        '
        'txtDep
        '
        resources.ApplyResources(Me.txtDep, "txtDep")
        Me.txtDep.Name = "txtDep"
        '
        'lblMail
        '
        resources.ApplyResources(Me.lblMail, "lblMail")
        Me.lblMail.Name = "lblMail"
        '
        'txtMail
        '
        resources.ApplyResources(Me.txtMail, "txtMail")
        Me.txtMail.Name = "txtMail"
        '
        'lblPass
        '
        resources.ApplyResources(Me.lblPass, "lblPass")
        Me.lblPass.Name = "lblPass"
        '
        'txtPass
        '
        resources.ApplyResources(Me.txtPass, "txtPass")
        Me.txtPass.Name = "txtPass"
        Me.txtPass.UseSystemPasswordChar = True
        '
        'lblAdr1
        '
        resources.ApplyResources(Me.lblAdr1, "lblAdr1")
        Me.lblAdr1.Name = "lblAdr1"
        '
        'lblAdr2
        '
        resources.ApplyResources(Me.lblAdr2, "lblAdr2")
        Me.lblAdr2.Name = "lblAdr2"
        '
        'lblAdr3
        '
        resources.ApplyResources(Me.lblAdr3, "lblAdr3")
        Me.lblAdr3.Name = "lblAdr3"
        '
        'lblPlz
        '
        resources.ApplyResources(Me.lblPlz, "lblPlz")
        Me.lblPlz.Name = "lblPlz"
        '
        'txtAdr1
        '
        resources.ApplyResources(Me.txtAdr1, "txtAdr1")
        Me.txtAdr1.Name = "txtAdr1"
        '
        'txtAdr2
        '
        resources.ApplyResources(Me.txtAdr2, "txtAdr2")
        Me.txtAdr2.Name = "txtAdr2"
        '
        'txtAdr3
        '
        resources.ApplyResources(Me.txtAdr3, "txtAdr3")
        Me.txtAdr3.Name = "txtAdr3"
        '
        'txtPlz
        '
        resources.ApplyResources(Me.txtPlz, "txtPlz")
        Me.txtPlz.Name = "txtPlz"
        '
        'gbServer
        '
        Me.gbServer.BackColor = System.Drawing.Color.Lime
        Me.gbServer.Controls.Add(Me.rbTest)
        Me.gbServer.Controls.Add(Me.rbProd)
        resources.ApplyResources(Me.gbServer, "gbServer")
        Me.gbServer.Name = "gbServer"
        Me.gbServer.TabStop = False
        '
        'rbTest
        '
        resources.ApplyResources(Me.rbTest, "rbTest")
        Me.rbTest.Name = "rbTest"
        Me.rbTest.UseVisualStyleBackColor = True
        '
        'rbProd
        '
        resources.ApplyResources(Me.rbProd, "rbProd")
        Me.rbProd.Name = "rbProd"
        Me.rbProd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtPlz)
        Me.GroupBox2.Controls.Add(Me.txtAdr3)
        Me.GroupBox2.Controls.Add(Me.txtAdr2)
        Me.GroupBox2.Controls.Add(Me.txtAdr1)
        Me.GroupBox2.Controls.Add(Me.lblPlz)
        Me.GroupBox2.Controls.Add(Me.lblAdr3)
        Me.GroupBox2.Controls.Add(Me.lblAdr2)
        Me.GroupBox2.Controls.Add(Me.lblAdr1)
        Me.GroupBox2.Controls.Add(Me.txtDep)
        Me.GroupBox2.Controls.Add(Me.txtOrg)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Controls.Add(Me.lblDep)
        Me.GroupBox2.Controls.Add(Me.lblOrg)
        Me.GroupBox2.Controls.Add(Me.lblCity)
        Me.GroupBox2.Controls.Add(Me.txtState)
        Me.GroupBox2.Controls.Add(Me.lblState)
        Me.GroupBox2.Controls.Add(Me.txtCountry)
        Me.GroupBox2.Controls.Add(Me.lblCountry)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtSSL)
        Me.GroupBox3.Controls.Add(Me.lblSSL)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtPass)
        Me.GroupBox4.Controls.Add(Me.lblPass)
        Me.GroupBox4.Controls.Add(Me.txtMail)
        Me.GroupBox4.Controls.Add(Me.lblMail)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'btnExtend
        '
        Me.btnExtend.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.btnExtend, "btnExtend")
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.txtCertPass)
        Me.GroupBox5.Controls.Add(Me.lblCertPass)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'txtCertPass
        '
        resources.ApplyResources(Me.txtCertPass, "txtCertPass")
        Me.txtCertPass.Name = "txtCertPass"
        Me.txtCertPass.UseSystemPasswordChar = True
        '
        'lblCertPass
        '
        resources.ApplyResources(Me.lblCertPass, "lblCertPass")
        Me.lblCertPass.Name = "lblCertPass"
        '
        'frmInit
        '
        Me.AcceptButton = Me.btnOK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnExtend)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbServer)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmInit"
        Me.gbServer.ResumeLayout(False)
        Me.gbServer.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExtend As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtCertPass As TextBox
    Friend WithEvents lblCertPass As Label
End Class
