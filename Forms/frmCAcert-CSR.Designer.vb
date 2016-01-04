<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAcertCSR
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCAcertCSR))
        Me.lblName = New System.Windows.Forms.Label()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcCert = New System.Windows.Forms.TabControl()
        Me.tpCreate = New System.Windows.Forms.TabPage()
        Me.cbCCA = New System.Windows.Forms.CheckBox()
        Me.gbArt = New System.Windows.Forms.GroupBox()
        Me.rbServer = New System.Windows.Forms.RadioButton()
        Me.rbClient = New System.Windows.Forms.RadioButton()
        Me.gbTyp = New System.Windows.Forms.GroupBox()
        Me.rbOrg = New System.Windows.Forms.RadioButton()
        Me.rbPrivat = New System.Windows.Forms.RadioButton()
        Me.btnCAcertFin = New System.Windows.Forms.Button()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.rbClass3 = New System.Windows.Forms.RadioButton()
        Me.rbClass1 = New System.Windows.Forms.RadioButton()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCACertSave = New System.Windows.Forms.Button()
        Me.btnCAcertSig = New System.Windows.Forms.Button()
        Me.txtCSR = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.lblNamen = New System.Windows.Forms.Label()
        Me.lstNamen = New System.Windows.Forms.ListBox()
        Me.txtCommon = New System.Windows.Forms.TextBox()
        Me.lblCommon = New System.Windows.Forms.Label()
        Me.txtPem = New System.Windows.Forms.TextBox()
        Me.webCAcert = New System.Windows.Forms.WebBrowser()
        Me.ofdDatei = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SpracheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeutschToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglischToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcCert.SuspendLayout()
        Me.tpCreate.SuspendLayout()
        Me.gbArt.SuspendLayout()
        Me.gbTyp.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        resources.ApplyResources(Me.DateiToolStripMenuItem, "DateiToolStripMenuItem")
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        resources.ApplyResources(Me.BeendenToolStripMenuItem, "BeendenToolStripMenuItem")
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem})
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        resources.ApplyResources(Me.OptionenToolStripMenuItem, "OptionenToolStripMenuItem")
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        resources.ApplyResources(Me.EinstellungenToolStripMenuItem, "EinstellungenToolStripMenuItem")
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        resources.ApplyResources(Me.HilfeToolStripMenuItem, "HilfeToolStripMenuItem")
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        resources.ApplyResources(Me.InfoToolStripMenuItem, "InfoToolStripMenuItem")
        '
        'tcCert
        '
        Me.tcCert.Controls.Add(Me.tpCreate)
        resources.ApplyResources(Me.tcCert, "tcCert")
        Me.tcCert.HotTrack = True
        Me.tcCert.Name = "tcCert"
        Me.tcCert.SelectedIndex = 0
        '
        'tpCreate
        '
        Me.tpCreate.Controls.Add(Me.cbCCA)
        Me.tpCreate.Controls.Add(Me.gbArt)
        Me.tpCreate.Controls.Add(Me.gbTyp)
        Me.tpCreate.Controls.Add(Me.btnCAcertFin)
        Me.tpCreate.Controls.Add(Me.lblClass)
        Me.tpCreate.Controls.Add(Me.rbClass3)
        Me.tpCreate.Controls.Add(Me.rbClass1)
        Me.tpCreate.Controls.Add(Me.btnAll)
        Me.tpCreate.Controls.Add(Me.btnClear)
        Me.tpCreate.Controls.Add(Me.btnCACertSave)
        Me.tpCreate.Controls.Add(Me.btnCAcertSig)
        Me.tpCreate.Controls.Add(Me.txtCSR)
        Me.tpCreate.Controls.Add(Me.btnGenerate)
        Me.tpCreate.Controls.Add(Me.btnMinus)
        Me.tpCreate.Controls.Add(Me.btnPlus)
        Me.tpCreate.Controls.Add(Me.lblNamen)
        Me.tpCreate.Controls.Add(Me.lstNamen)
        Me.tpCreate.Controls.Add(Me.txtCommon)
        Me.tpCreate.Controls.Add(Me.lblCommon)
        Me.tpCreate.Controls.Add(Me.txtPem)
        Me.tpCreate.Controls.Add(Me.webCAcert)
        resources.ApplyResources(Me.tpCreate, "tpCreate")
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.UseVisualStyleBackColor = True
        '
        'cbCCA
        '
        resources.ApplyResources(Me.cbCCA, "cbCCA")
        Me.cbCCA.Name = "cbCCA"
        Me.cbCCA.UseVisualStyleBackColor = True
        '
        'gbArt
        '
        Me.gbArt.Controls.Add(Me.rbServer)
        Me.gbArt.Controls.Add(Me.rbClient)
        resources.ApplyResources(Me.gbArt, "gbArt")
        Me.gbArt.Name = "gbArt"
        Me.gbArt.TabStop = False
        '
        'rbServer
        '
        resources.ApplyResources(Me.rbServer, "rbServer")
        Me.rbServer.Name = "rbServer"
        Me.rbServer.TabStop = True
        Me.rbServer.UseVisualStyleBackColor = True
        '
        'rbClient
        '
        resources.ApplyResources(Me.rbClient, "rbClient")
        Me.rbClient.Name = "rbClient"
        Me.rbClient.TabStop = True
        Me.rbClient.UseVisualStyleBackColor = True
        '
        'gbTyp
        '
        Me.gbTyp.Controls.Add(Me.rbOrg)
        Me.gbTyp.Controls.Add(Me.rbPrivat)
        resources.ApplyResources(Me.gbTyp, "gbTyp")
        Me.gbTyp.Name = "gbTyp"
        Me.gbTyp.TabStop = False
        '
        'rbOrg
        '
        resources.ApplyResources(Me.rbOrg, "rbOrg")
        Me.rbOrg.Name = "rbOrg"
        Me.rbOrg.TabStop = True
        Me.rbOrg.UseVisualStyleBackColor = True
        '
        'rbPrivat
        '
        resources.ApplyResources(Me.rbPrivat, "rbPrivat")
        Me.rbPrivat.Name = "rbPrivat"
        Me.rbPrivat.TabStop = True
        Me.rbPrivat.UseVisualStyleBackColor = True
        '
        'btnCAcertFin
        '
        Me.btnCAcertFin.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.btnCAcertFin, "btnCAcertFin")
        Me.btnCAcertFin.Name = "btnCAcertFin"
        Me.btnCAcertFin.UseVisualStyleBackColor = False
        '
        'lblClass
        '
        resources.ApplyResources(Me.lblClass, "lblClass")
        Me.lblClass.Name = "lblClass"
        '
        'rbClass3
        '
        resources.ApplyResources(Me.rbClass3, "rbClass3")
        Me.rbClass3.Checked = True
        Me.rbClass3.Name = "rbClass3"
        Me.rbClass3.TabStop = True
        Me.rbClass3.Tag = "2"
        Me.rbClass3.UseVisualStyleBackColor = True
        '
        'rbClass1
        '
        resources.ApplyResources(Me.rbClass1, "rbClass1")
        Me.rbClass1.Name = "rbClass1"
        Me.rbClass1.Tag = "1"
        Me.rbClass1.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        resources.ApplyResources(Me.btnAll, "btnAll")
        Me.btnAll.Name = "btnAll"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCACertSave
        '
        Me.btnCACertSave.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.btnCACertSave, "btnCACertSave")
        Me.btnCACertSave.Name = "btnCACertSave"
        Me.btnCACertSave.UseVisualStyleBackColor = False
        '
        'btnCAcertSig
        '
        Me.btnCAcertSig.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.btnCAcertSig, "btnCAcertSig")
        Me.btnCAcertSig.Name = "btnCAcertSig"
        Me.btnCAcertSig.UseVisualStyleBackColor = False
        '
        'txtCSR
        '
        resources.ApplyResources(Me.txtCSR, "txtCSR")
        Me.txtCSR.Name = "txtCSR"
        Me.txtCSR.ReadOnly = True
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.btnGenerate, "btnGenerate")
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        resources.ApplyResources(Me.btnMinus, "btnMinus")
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        resources.ApplyResources(Me.btnPlus, "btnPlus")
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'lblNamen
        '
        resources.ApplyResources(Me.lblNamen, "lblNamen")
        Me.lblNamen.Name = "lblNamen"
        '
        'lstNamen
        '
        resources.ApplyResources(Me.lstNamen, "lstNamen")
        Me.lstNamen.FormattingEnabled = True
        Me.lstNamen.Name = "lstNamen"
        '
        'txtCommon
        '
        resources.ApplyResources(Me.txtCommon, "txtCommon")
        Me.txtCommon.Name = "txtCommon"
        '
        'lblCommon
        '
        resources.ApplyResources(Me.lblCommon, "lblCommon")
        Me.lblCommon.Name = "lblCommon"
        '
        'txtPem
        '
        resources.ApplyResources(Me.txtPem, "txtPem")
        Me.txtPem.Name = "txtPem"
        Me.txtPem.ReadOnly = True
        '
        'webCAcert
        '
        resources.ApplyResources(Me.webCAcert, "webCAcert")
        Me.webCAcert.Name = "webCAcert"
        Me.webCAcert.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem1, Me.OptionToolStripMenuItem, Me.HilfeToolStripMenuItem1})
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.Name = "MenuStrip"
        '
        'DateiToolStripMenuItem1
        '
        Me.DateiToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem1})
        Me.DateiToolStripMenuItem1.Name = "DateiToolStripMenuItem1"
        resources.ApplyResources(Me.DateiToolStripMenuItem1, "DateiToolStripMenuItem1")
        '
        'BeendenToolStripMenuItem1
        '
        Me.BeendenToolStripMenuItem1.Name = "BeendenToolStripMenuItem1"
        resources.ApplyResources(Me.BeendenToolStripMenuItem1, "BeendenToolStripMenuItem1")
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem1, Me.SpracheToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        resources.ApplyResources(Me.OptionToolStripMenuItem, "OptionToolStripMenuItem")
        '
        'EinstellungenToolStripMenuItem1
        '
        Me.EinstellungenToolStripMenuItem1.Name = "EinstellungenToolStripMenuItem1"
        resources.ApplyResources(Me.EinstellungenToolStripMenuItem1, "EinstellungenToolStripMenuItem1")
        '
        'HilfeToolStripMenuItem1
        '
        Me.HilfeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem1})
        Me.HilfeToolStripMenuItem1.Name = "HilfeToolStripMenuItem1"
        resources.ApplyResources(Me.HilfeToolStripMenuItem1, "HilfeToolStripMenuItem1")
        '
        'InfoToolStripMenuItem1
        '
        Me.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1"
        resources.ApplyResources(Me.InfoToolStripMenuItem1, "InfoToolStripMenuItem1")
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'SpracheToolStripMenuItem
        '
        Me.SpracheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeutschToolStripMenuItem, Me.EnglischToolStripMenuItem})
        Me.SpracheToolStripMenuItem.Name = "SpracheToolStripMenuItem"
        resources.ApplyResources(Me.SpracheToolStripMenuItem, "SpracheToolStripMenuItem")
        '
        'DeutschToolStripMenuItem
        '
        Me.DeutschToolStripMenuItem.Name = "DeutschToolStripMenuItem"
        resources.ApplyResources(Me.DeutschToolStripMenuItem, "DeutschToolStripMenuItem")
        '
        'EnglischToolStripMenuItem
        '
        Me.EnglischToolStripMenuItem.Name = "EnglischToolStripMenuItem"
        resources.ApplyResources(Me.EnglischToolStripMenuItem, "EnglischToolStripMenuItem")
        '
        'frmCAcertCSR
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcCert)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip)
        Me.MaximizeBox = False
        Me.Name = "frmCAcertCSR"
        Me.tcCert.ResumeLayout(False)
        Me.tpCreate.ResumeLayout(False)
        Me.tpCreate.PerformLayout()
        Me.gbArt.ResumeLayout(False)
        Me.gbArt.PerformLayout()
        Me.gbTyp.ResumeLayout(False)
        Me.gbTyp.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcCert As System.Windows.Forms.TabControl
    Friend WithEvents tpCreate As System.Windows.Forms.TabPage
    Friend WithEvents btnCAcertFin As System.Windows.Forms.Button
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents rbClass3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbClass1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCACertSave As System.Windows.Forms.Button
    Friend WithEvents btnCAcertSig As System.Windows.Forms.Button
    Friend WithEvents txtCSR As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents lblNamen As System.Windows.Forms.Label
    Friend WithEvents lstNamen As System.Windows.Forms.ListBox
    Friend WithEvents txtCommon As System.Windows.Forms.TextBox
    Friend WithEvents lblCommon As System.Windows.Forms.Label
    Friend WithEvents txtPem As System.Windows.Forms.TextBox
    Friend WithEvents webCAcert As System.Windows.Forms.WebBrowser
    Friend WithEvents ofdDatei As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbArt As System.Windows.Forms.GroupBox
    Friend WithEvents rbServer As System.Windows.Forms.RadioButton
    Friend WithEvents rbClient As System.Windows.Forms.RadioButton
    Friend WithEvents gbTyp As System.Windows.Forms.GroupBox
    Friend WithEvents rbOrg As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrivat As System.Windows.Forms.RadioButton
    Friend WithEvents cbCCA As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SpracheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeutschToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglischToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
