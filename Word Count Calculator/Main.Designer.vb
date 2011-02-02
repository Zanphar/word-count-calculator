<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.docCount = New System.Windows.Forms.TextBox()
        Me.cmdMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkPPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.clkCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.clkEmpty = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.clkWWrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkTD = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.clkAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkSysInf = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkUoP = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkWCCWS = New System.Windows.Forms.ToolStripMenuItem()
        Me.clkPSR = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.topExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.authURL = New System.Windows.Forms.LinkLabel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnEmpty = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.botStrip = New System.Windows.Forms.StatusStrip()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.botStTD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.botGoTD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timeTime = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.debugAeroStop = New System.Windows.Forms.Button()
        Me.debugAeroStart = New System.Windows.Forms.Button()
        Me.appPB = New System.Windows.Forms.PictureBox()
        Me.btnDirectory = New System.Windows.Forms.Button()
        Me.cmdMenu.SuspendLayout()
        Me.botStrip.SuspendLayout()
        CType(Me.appPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'docCount
        '
        Me.docCount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.docCount.Location = New System.Drawing.Point(0, 104)
        Me.docCount.Multiline = True
        Me.docCount.Name = "docCount"
        Me.docCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.docCount.Size = New System.Drawing.Size(783, 435)
        Me.docCount.TabIndex = 1
        '
        'cmdMenu
        '
        Me.cmdMenu.BackColor = System.Drawing.Color.Transparent
        Me.cmdMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.CommandsToolStripMenuItem1, Me.HelpToolStripMenuItem2})
        Me.cmdMenu.Location = New System.Drawing.Point(0, 0)
        Me.cmdMenu.Name = "cmdMenu"
        Me.cmdMenu.Size = New System.Drawing.Size(784, 24)
        Me.cmdMenu.TabIndex = 2
        Me.cmdMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.clkOpenFile, Me.clkSaveAs, Me.clkPrint, Me.clkPageSetup, Me.clkPPreview, Me.clkExit})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Image = Global.Word_Count_Calculator.My.Resources.Resources.Open_folder_accept_256
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.NewToolStripMenuItem1.Text = "&New Document"
        '
        'clkOpenFile
        '
        Me.clkOpenFile.Image = Global.Word_Count_Calculator.My.Resources.Resources.Open_folder_add_256
        Me.clkOpenFile.Name = "clkOpenFile"
        Me.clkOpenFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.clkOpenFile.Size = New System.Drawing.Size(210, 22)
        Me.clkOpenFile.Text = "&Open Document"
        '
        'clkSaveAs
        '
        Me.clkSaveAs.Name = "clkSaveAs"
        Me.clkSaveAs.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.clkSaveAs.Size = New System.Drawing.Size(210, 22)
        Me.clkSaveAs.Text = "&Save Content"
        '
        'clkPrint
        '
        Me.clkPrint.Name = "clkPrint"
        Me.clkPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.clkPrint.Size = New System.Drawing.Size(210, 22)
        Me.clkPrint.Text = "&Print Content"
        '
        'clkPageSetup
        '
        Me.clkPageSetup.Name = "clkPageSetup"
        Me.clkPageSetup.Size = New System.Drawing.Size(210, 22)
        Me.clkPageSetup.Text = "Pri&nt Setup"
        '
        'clkPPreview
        '
        Me.clkPPreview.Name = "clkPPreview"
        Me.clkPPreview.Size = New System.Drawing.Size(210, 22)
        Me.clkPPreview.Text = "Print Prev&iew"
        '
        'clkExit
        '
        Me.clkExit.Name = "clkExit"
        Me.clkExit.Size = New System.Drawing.Size(210, 22)
        Me.clkExit.Text = "&Exit"
        '
        'CommandsToolStripMenuItem1
        '
        Me.CommandsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clkAll, Me.ToolStripSeparator2, Me.clkCopy, Me.clkDelete, Me.clkPaste, Me.ToolStripSeparator1, Me.clkEmpty, Me.ToolStripSeparator4, Me.clkWWrap, Me.clkTD})
        Me.CommandsToolStripMenuItem1.Name = "CommandsToolStripMenuItem1"
        Me.CommandsToolStripMenuItem1.Size = New System.Drawing.Size(80, 20)
        Me.CommandsToolStripMenuItem1.Text = "&Commands"
        '
        'clkAll
        '
        Me.clkAll.Name = "clkAll"
        Me.clkAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.clkAll.Size = New System.Drawing.Size(209, 22)
        Me.clkAll.Text = "Select &All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(206, 6)
        '
        'clkCopy
        '
        Me.clkCopy.Name = "clkCopy"
        Me.clkCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.clkCopy.Size = New System.Drawing.Size(209, 22)
        Me.clkCopy.Text = "&Copy Content"
        '
        'clkDelete
        '
        Me.clkDelete.Name = "clkDelete"
        Me.clkDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.clkDelete.Size = New System.Drawing.Size(209, 22)
        Me.clkDelete.Text = "&Delete Content"
        '
        'clkPaste
        '
        Me.clkPaste.Name = "clkPaste"
        Me.clkPaste.Size = New System.Drawing.Size(209, 22)
        Me.clkPaste.Text = "&Paste Content"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'clkEmpty
        '
        Me.clkEmpty.Name = "clkEmpty"
        Me.clkEmpty.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.clkEmpty.Size = New System.Drawing.Size(209, 22)
        Me.clkEmpty.Text = "&Empty Clipboard"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(206, 6)
        '
        'clkWWrap
        '
        Me.clkWWrap.Name = "clkWWrap"
        Me.clkWWrap.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.clkWWrap.Size = New System.Drawing.Size(209, 22)
        Me.clkWWrap.Text = "&Word Wrap"
        '
        'clkTD
        '
        Me.clkTD.Name = "clkTD"
        Me.clkTD.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.clkTD.Size = New System.Drawing.Size(209, 22)
        Me.clkTD.Text = "&Insert Date/Time"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clkHelp, Me.ToolStripSeparator3, Me.clkAbout, Me.clkSysInf, Me.clkUoP, Me.clkWCCWS, Me.clkPSR})
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem2.Text = "&Help"
        '
        'clkHelp
        '
        Me.clkHelp.Name = "clkHelp"
        Me.clkHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.clkHelp.Size = New System.Drawing.Size(300, 22)
        Me.clkHelp.Text = "&Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(297, 6)
        '
        'clkAbout
        '
        Me.clkAbout.Name = "clkAbout"
        Me.clkAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.clkAbout.Size = New System.Drawing.Size(300, 22)
        Me.clkAbout.Text = "&About"
        '
        'clkSysInf
        '
        Me.clkSysInf.Name = "clkSysInf"
        Me.clkSysInf.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.clkSysInf.Size = New System.Drawing.Size(300, 22)
        Me.clkSysInf.Text = "&System Information"
        '
        'clkUoP
        '
        Me.clkUoP.Image = Global.Word_Count_Calculator.My.Resources.Resources.Mozilla_Firefox
        Me.clkUoP.Name = "clkUoP"
        Me.clkUoP.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.clkUoP.Size = New System.Drawing.Size(300, 22)
        Me.clkUoP.Text = "&University of Pheonix"
        '
        'clkWCCWS
        '
        Me.clkWCCWS.Image = Global.Word_Count_Calculator.My.Resources.Resources.Mozilla_Firefox
        Me.clkWCCWS.Name = "clkWCCWS"
        Me.clkWCCWS.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.clkWCCWS.Size = New System.Drawing.Size(300, 22)
        Me.clkWCCWS.Text = "&Word Count Calculator Web Site"
        '
        'clkPSR
        '
        Me.clkPSR.Name = "clkPSR"
        Me.clkPSR.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.clkPSR.Size = New System.Drawing.Size(300, 22)
        Me.clkPSR.Text = "&Problem Steps Recorder"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.topExit, Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'topExit
        '
        Me.topExit.Name = "topExit"
        Me.topExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.topExit.Size = New System.Drawing.Size(146, 22)
        Me.topExit.Text = "E&xit"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'CommandsToolStripMenuItem
        '
        Me.CommandsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.CopyAllToolStripMenuItem, Me.PasteAllToolStripMenuItem, Me.RemoveAllToolStripMenuItem})
        Me.CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem"
        Me.CommandsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CommandsToolStripMenuItem.Text = "&Commands"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'CopyAllToolStripMenuItem
        '
        Me.CopyAllToolStripMenuItem.Name = "CopyAllToolStripMenuItem"
        Me.CopyAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyAllToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CopyAllToolStripMenuItem.Text = "C&opy All"
        '
        'PasteAllToolStripMenuItem
        '
        Me.PasteAllToolStripMenuItem.Name = "PasteAllToolStripMenuItem"
        Me.PasteAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteAllToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PasteAllToolStripMenuItem.Text = "&Paste All"
        '
        'RemoveAllToolStripMenuItem
        '
        Me.RemoveAllToolStripMenuItem.Name = "RemoveAllToolStripMenuItem"
        Me.RemoveAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.RemoveAllToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RemoveAllToolStripMenuItem.Text = "&Empty All"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'authURL
        '
        Me.authURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.authURL.AutoSize = True
        Me.authURL.BackColor = System.Drawing.Color.Transparent
        Me.authURL.LinkColor = System.Drawing.Color.White
        Me.authURL.Location = New System.Drawing.Point(461, 24)
        Me.authURL.Name = "authURL"
        Me.authURL.Size = New System.Drawing.Size(311, 13)
        Me.authURL.TabIndex = 4
        Me.authURL.TabStop = True
        Me.authURL.Text = "Copyright © 1992-2012 Charlie M. McDonald. All rights reserved."
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(517, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(436, 80)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCopy.BackColor = System.Drawing.Color.Transparent
        Me.btnCopy.ForeColor = System.Drawing.Color.Black
        Me.btnCopy.Location = New System.Drawing.Point(355, 80)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 8
        Me.btnCopy.Text = "C&opy"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnPaste
        '
        Me.btnPaste.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPaste.BackColor = System.Drawing.Color.Transparent
        Me.btnPaste.ForeColor = System.Drawing.Color.Black
        Me.btnPaste.Location = New System.Drawing.Point(274, 80)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(75, 23)
        Me.btnPaste.TabIndex = 9
        Me.btnPaste.Text = "&Paste"
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'btnEmpty
        '
        Me.btnEmpty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEmpty.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpty.ForeColor = System.Drawing.Color.Black
        Me.btnEmpty.Location = New System.Drawing.Point(193, 80)
        Me.btnEmpty.Name = "btnEmpty"
        Me.btnEmpty.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpty.TabIndex = 10
        Me.btnEmpty.Text = "&Empty"
        Me.btnEmpty.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(464, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "If you have any questions or need assistance, press F1 to obtain help for this so" & _
            "ftware."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'botStrip
        '
        Me.botStrip.BackColor = System.Drawing.SystemColors.Control
        Me.botStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1, Me.botStTD, Me.lblCount, Me.botGoTD})
        Me.botStrip.Location = New System.Drawing.Point(0, 540)
        Me.botStrip.Name = "botStrip"
        Me.botStrip.Size = New System.Drawing.Size(784, 22)
        Me.botStrip.TabIndex = 0
        Me.botStrip.Text = "botStrip"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'botStTD
        '
        Me.botStTD.ForeColor = System.Drawing.Color.Red
        Me.botStTD.Name = "botStTD"
        Me.botStTD.Size = New System.Drawing.Size(222, 17)
        Me.botStTD.Spring = True
        Me.botStTD.Text = "##/##/#### ##:##:##:##"
        '
        'lblCount
        '
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(222, 17)
        Me.lblCount.Spring = True
        Me.lblCount.Text = "Total Words: "
        '
        'botGoTD
        '
        Me.botGoTD.ActiveLinkColor = System.Drawing.Color.Red
        Me.botGoTD.ForeColor = System.Drawing.Color.Green
        Me.botGoTD.Name = "botGoTD"
        Me.botGoTD.Size = New System.Drawing.Size(222, 17)
        Me.botGoTD.Spring = True
        Me.botGoTD.Text = "##/##/#### ##:##:##:##"
        '
        'timeTime
        '
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|HTML Documents (*.html)|*.html|Batch Files (*.bat)|*" & _
            ".bat|All Files (*.*)|*.*"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text Documents (*.txt)|*.txt|HTML Documents (*.html)|*.html|Batch Files (*.bat)|*" & _
            ".bat|All Files (*.*)|*.*"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'debugAeroStop
        '
        Me.debugAeroStop.Enabled = False
        Me.debugAeroStop.Location = New System.Drawing.Point(31, 80)
        Me.debugAeroStop.Name = "debugAeroStop"
        Me.debugAeroStop.Size = New System.Drawing.Size(75, 23)
        Me.debugAeroStop.TabIndex = 13
        Me.debugAeroStop.Text = "Stop UxSms"
        Me.debugAeroStop.UseVisualStyleBackColor = True
        Me.debugAeroStop.Visible = False
        '
        'debugAeroStart
        '
        Me.debugAeroStart.Enabled = False
        Me.debugAeroStart.Location = New System.Drawing.Point(112, 80)
        Me.debugAeroStart.Name = "debugAeroStart"
        Me.debugAeroStart.Size = New System.Drawing.Size(75, 23)
        Me.debugAeroStart.TabIndex = 14
        Me.debugAeroStart.Text = "Start UxSms"
        Me.debugAeroStart.UseVisualStyleBackColor = True
        Me.debugAeroStart.Visible = False
        '
        'appPB
        '
        Me.appPB.BackColor = System.Drawing.Color.Transparent
        Me.appPB.Image = Global.Word_Count_Calculator.My.Resources.Resources.art147581871
        Me.appPB.Location = New System.Drawing.Point(12, 24)
        Me.appPB.Name = "appPB"
        Me.appPB.Size = New System.Drawing.Size(311, 37)
        Me.appPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appPB.TabIndex = 5
        Me.appPB.TabStop = False
        '
        'btnDirectory
        '
        Me.btnDirectory.Enabled = False
        Me.btnDirectory.Location = New System.Drawing.Point(598, 80)
        Me.btnDirectory.Name = "btnDirectory"
        Me.btnDirectory.Size = New System.Drawing.Size(75, 23)
        Me.btnDirectory.TabIndex = 15
        Me.btnDirectory.Text = "Directory"
        Me.btnDirectory.UseVisualStyleBackColor = True
        Me.btnDirectory.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnDirectory)
        Me.Controls.Add(Me.debugAeroStart)
        Me.Controls.Add(Me.debugAeroStop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEmpty)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.appPB)
        Me.Controls.Add(Me.authURL)
        Me.Controls.Add(Me.docCount)
        Me.Controls.Add(Me.botStrip)
        Me.Controls.Add(Me.cmdMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.cmdMenu
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Count Calculator"
        Me.cmdMenu.ResumeLayout(False)
        Me.cmdMenu.PerformLayout()
        Me.botStrip.ResumeLayout(False)
        Me.botStrip.PerformLayout()
        CType(Me.appPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents docCount As System.Windows.Forms.TextBox
    Friend WithEvents cmdMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents topExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents authURL As System.Windows.Forms.LinkLabel
    Friend WithEvents appPB As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnEmpty As System.Windows.Forms.Button
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents botStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents botStTD As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents botGoTD As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timeTime As System.Windows.Forms.Timer
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommandsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents clkCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents clkEmpty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents clkAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkSysInf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkPPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents clkWWrap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents clkTD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents debugAeroStop As System.Windows.Forms.Button
    Friend WithEvents debugAeroStart As System.Windows.Forms.Button
    Friend WithEvents clkUoP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkWCCWS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clkPSR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnDirectory As System.Windows.Forms.Button

End Class
