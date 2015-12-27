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
        Me.tcCert.SuspendLayout()
        Me.tpCreate.SuspendLayout()
        Me.gbArt.SuspendLayout()
        Me.gbTyp.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(50, 6)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 0
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem})
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OptionenToolStripMenuItem.Text = "&Optionen"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EinstellungenToolStripMenuItem.Text = "&Einstellungen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'tcCert
        '
        Me.tcCert.Controls.Add(Me.tpCreate)
        Me.tcCert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCert.HotTrack = True
        Me.tcCert.Location = New System.Drawing.Point(0, 24)
        Me.tcCert.Name = "tcCert"
        Me.tcCert.SelectedIndex = 0
        Me.tcCert.Size = New System.Drawing.Size(324, 395)
        Me.tcCert.TabIndex = 0
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
        Me.tpCreate.Location = New System.Drawing.Point(4, 22)
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreate.Size = New System.Drawing.Size(316, 369)
        Me.tpCreate.TabIndex = 0
        Me.tpCreate.Text = "Erzeugen"
        Me.tpCreate.UseVisualStyleBackColor = True
        '
        'cbCCA
        '
        Me.cbCCA.AutoSize = True
        Me.cbCCA.Enabled = False
        Me.cbCCA.Location = New System.Drawing.Point(146, 225)
        Me.cbCCA.Name = "cbCCA"
        Me.cbCCA.Size = New System.Drawing.Size(47, 17)
        Me.cbCCA.TabIndex = 13
        Me.cbCCA.Text = "CCA"
        Me.cbCCA.UseVisualStyleBackColor = True
        '
        'gbArt
        '
        Me.gbArt.Controls.Add(Me.rbServer)
        Me.gbArt.Controls.Add(Me.rbClient)
        Me.gbArt.Location = New System.Drawing.Point(13, 82)
        Me.gbArt.Name = "gbArt"
        Me.gbArt.Size = New System.Drawing.Size(298, 45)
        Me.gbArt.TabIndex = 1
        Me.gbArt.TabStop = False
        Me.gbArt.Text = "Art"
        '
        'rbServer
        '
        Me.rbServer.AutoSize = True
        Me.rbServer.Enabled = False
        Me.rbServer.Location = New System.Drawing.Point(136, 20)
        Me.rbServer.Name = "rbServer"
        Me.rbServer.Size = New System.Drawing.Size(56, 17)
        Me.rbServer.TabIndex = 1
        Me.rbServer.TabStop = True
        Me.rbServer.Text = "Server"
        Me.rbServer.UseVisualStyleBackColor = True
        '
        'rbClient
        '
        Me.rbClient.AutoSize = True
        Me.rbClient.Enabled = False
        Me.rbClient.Location = New System.Drawing.Point(13, 20)
        Me.rbClient.Name = "rbClient"
        Me.rbClient.Size = New System.Drawing.Size(51, 17)
        Me.rbClient.TabIndex = 0
        Me.rbClient.TabStop = True
        Me.rbClient.Text = "Client"
        Me.rbClient.UseVisualStyleBackColor = True
        '
        'gbTyp
        '
        Me.gbTyp.Controls.Add(Me.rbOrg)
        Me.gbTyp.Controls.Add(Me.rbPrivat)
        Me.gbTyp.Location = New System.Drawing.Point(12, 31)
        Me.gbTyp.Name = "gbTyp"
        Me.gbTyp.Size = New System.Drawing.Size(299, 45)
        Me.gbTyp.TabIndex = 0
        Me.gbTyp.TabStop = False
        Me.gbTyp.Text = "Typ"
        '
        'rbOrg
        '
        Me.rbOrg.AutoSize = True
        Me.rbOrg.Enabled = False
        Me.rbOrg.Location = New System.Drawing.Point(136, 19)
        Me.rbOrg.Name = "rbOrg"
        Me.rbOrg.Size = New System.Drawing.Size(84, 17)
        Me.rbOrg.TabIndex = 1
        Me.rbOrg.TabStop = True
        Me.rbOrg.Text = "Organisation"
        Me.rbOrg.UseVisualStyleBackColor = True
        '
        'rbPrivat
        '
        Me.rbPrivat.AutoSize = True
        Me.rbPrivat.Enabled = False
        Me.rbPrivat.Location = New System.Drawing.Point(13, 19)
        Me.rbPrivat.Name = "rbPrivat"
        Me.rbPrivat.Size = New System.Drawing.Size(52, 17)
        Me.rbPrivat.TabIndex = 0
        Me.rbPrivat.TabStop = True
        Me.rbPrivat.Text = "Privat"
        Me.rbPrivat.UseVisualStyleBackColor = True
        '
        'btnCAcertFin
        '
        Me.btnCAcertFin.BackColor = System.Drawing.Color.Red
        Me.btnCAcertFin.Enabled = False
        Me.btnCAcertFin.Location = New System.Drawing.Point(8, 311)
        Me.btnCAcertFin.Name = "btnCAcertFin"
        Me.btnCAcertFin.Size = New System.Drawing.Size(300, 23)
        Me.btnCAcertFin.TabIndex = 18
        Me.btnCAcertFin.Text = "Mit CAcert fertigstellen"
        Me.btnCAcertFin.UseVisualStyleBackColor = False
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(13, 226)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(38, 13)
        Me.lblClass.TabIndex = 10
        Me.lblClass.Text = "Klasse"
        '
        'rbClass3
        '
        Me.rbClass3.AutoSize = True
        Me.rbClass3.Checked = True
        Me.rbClass3.Enabled = False
        Me.rbClass3.Location = New System.Drawing.Point(82, 224)
        Me.rbClass3.Name = "rbClass3"
        Me.rbClass3.Size = New System.Drawing.Size(31, 17)
        Me.rbClass3.TabIndex = 12
        Me.rbClass3.TabStop = True
        Me.rbClass3.Tag = "2"
        Me.rbClass3.Text = "3"
        Me.rbClass3.UseVisualStyleBackColor = True
        '
        'rbClass1
        '
        Me.rbClass1.AutoSize = True
        Me.rbClass1.Enabled = False
        Me.rbClass1.Location = New System.Drawing.Point(54, 224)
        Me.rbClass1.Name = "rbClass1"
        Me.rbClass1.Size = New System.Drawing.Size(31, 17)
        Me.rbClass1.TabIndex = 11
        Me.rbClass1.Tag = "1"
        Me.rbClass1.Text = "1"
        Me.rbClass1.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Enabled = False
        Me.btnAll.Location = New System.Drawing.Point(9, 195)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(85, 23)
        Me.btnAll.TabIndex = 8
        Me.btnAll.Text = "Alles Löschen"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(9, 166)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 22)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Löschen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCACertSave
        '
        Me.btnCACertSave.BackColor = System.Drawing.Color.Red
        Me.btnCACertSave.Enabled = False
        Me.btnCACertSave.Location = New System.Drawing.Point(9, 340)
        Me.btnCACertSave.Name = "btnCACertSave"
        Me.btnCACertSave.Size = New System.Drawing.Size(301, 23)
        Me.btnCACertSave.TabIndex = 0
        Me.btnCACertSave.Text = "Von CAcert in Datei speichern"
        Me.btnCACertSave.UseVisualStyleBackColor = False
        '
        'btnCAcertSig
        '
        Me.btnCAcertSig.BackColor = System.Drawing.Color.Red
        Me.btnCAcertSig.Enabled = False
        Me.btnCAcertSig.Location = New System.Drawing.Point(8, 282)
        Me.btnCAcertSig.Name = "btnCAcertSig"
        Me.btnCAcertSig.Size = New System.Drawing.Size(300, 23)
        Me.btnCAcertSig.TabIndex = 16
        Me.btnCAcertSig.Text = "Mit CAcert signieren"
        Me.btnCAcertSig.UseVisualStyleBackColor = False
        '
        'txtCSR
        '
        Me.txtCSR.Location = New System.Drawing.Point(316, 5)
        Me.txtCSR.Multiline = True
        Me.txtCSR.Name = "txtCSR"
        Me.txtCSR.ReadOnly = True
        Me.txtCSR.Size = New System.Drawing.Size(376, 358)
        Me.txtCSR.TabIndex = 27
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Red
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Location = New System.Drawing.Point(9, 253)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(300, 23)
        Me.btnGenerate.TabIndex = 18
        Me.btnGenerate.Text = "CSR erstellen"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.Enabled = False
        Me.btnMinus.Location = New System.Drawing.Point(100, 195)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(40, 23)
        Me.btnMinus.TabIndex = 6
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Enabled = False
        Me.btnPlus.Location = New System.Drawing.Point(100, 165)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 23)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'lblNamen
        '
        Me.lblNamen.AutoSize = True
        Me.lblNamen.Location = New System.Drawing.Point(5, 149)
        Me.lblNamen.Name = "lblNamen"
        Me.lblNamen.Size = New System.Drawing.Size(89, 13)
        Me.lblNamen.TabIndex = 4
        Me.lblNamen.Text = "Weitere Nammen"
        '
        'lstNamen
        '
        Me.lstNamen.Enabled = False
        Me.lstNamen.FormattingEnabled = True
        Me.lstNamen.Location = New System.Drawing.Point(146, 149)
        Me.lstNamen.Name = "lstNamen"
        Me.lstNamen.Size = New System.Drawing.Size(163, 69)
        Me.lstNamen.TabIndex = 9
        '
        'txtCommon
        '
        Me.txtCommon.Location = New System.Drawing.Point(102, 5)
        Me.txtCommon.Name = "txtCommon"
        Me.txtCommon.Size = New System.Drawing.Size(209, 20)
        Me.txtCommon.TabIndex = 3
        '
        'lblCommon
        '
        Me.lblCommon.AutoSize = True
        Me.lblCommon.Location = New System.Drawing.Point(8, 8)
        Me.lblCommon.Name = "lblCommon"
        Me.lblCommon.Size = New System.Drawing.Size(92, 13)
        Me.lblCommon.TabIndex = 2
        Me.lblCommon.Text = "Allgemeiner Name"
        '
        'txtPem
        '
        Me.txtPem.Location = New System.Drawing.Point(698, 6)
        Me.txtPem.Multiline = True
        Me.txtPem.Name = "txtPem"
        Me.txtPem.ReadOnly = True
        Me.txtPem.Size = New System.Drawing.Size(359, 357)
        Me.txtPem.TabIndex = 30
        '
        'webCAcert
        '
        Me.webCAcert.Location = New System.Drawing.Point(8, 369)
        Me.webCAcert.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webCAcert.Name = "webCAcert"
        Me.webCAcert.Size = New System.Drawing.Size(1051, 198)
        Me.webCAcert.TabIndex = 33
        Me.webCAcert.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Weitere Nammen"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem1, Me.OptionToolStripMenuItem, Me.HilfeToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip.TabIndex = 23
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem1
        '
        Me.DateiToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem1})
        Me.DateiToolStripMenuItem1.Name = "DateiToolStripMenuItem1"
        Me.DateiToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem1.Text = "&Datei"
        '
        'BeendenToolStripMenuItem1
        '
        Me.BeendenToolStripMenuItem1.Name = "BeendenToolStripMenuItem1"
        Me.BeendenToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem1.Text = "&Beenden"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem1})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "&Option"
        '
        'EinstellungenToolStripMenuItem1
        '
        Me.EinstellungenToolStripMenuItem1.Name = "EinstellungenToolStripMenuItem1"
        Me.EinstellungenToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.EinstellungenToolStripMenuItem1.Text = "&Einstellungen"
        '
        'HilfeToolStripMenuItem1
        '
        Me.HilfeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem1})
        Me.HilfeToolStripMenuItem1.Name = "HilfeToolStripMenuItem1"
        Me.HilfeToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem1.Text = "&Hilfe"
        '
        'InfoToolStripMenuItem1
        '
        Me.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1"
        Me.InfoToolStripMenuItem1.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem1.Text = "&Info"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'frmCAcertCSR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 419)
        Me.Controls.Add(Me.tcCert)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCAcertCSR"
        Me.Text = "CAcert - CSR"
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
End Class
