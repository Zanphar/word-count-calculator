' Word Count Calculator
' 
' Information: This source code, once compiled, allows an individual to count out the words
' as they type them. The purpose of this software is to save you time if you are in college
' or high school, or anywhere that requires you to have a specific amount of words typed.
' 
' Source Code: Visual Basic .NET 2010 (Visual Studio 2010)
' 
' Platform OS: Microsoft Windows XP; Windows Vista; Windows 7; Windows Server 2003;
' Windows Server 2008; Windows Server 2008 R2
' 
' Copyright © 1992-2012 Charlie M. McDonald. All rights reserved.

Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.IO
Imports Microsoft.WindowsAPICodePack
Imports Microsoft.WindowsAPICodePack.Taskbar
Imports Microsoft.WindowsAPICodePack.Shell

Public Class Main

    Private WithEvents docToPrint As New Printing.PrintDocument
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public Right As Integer
        Public left As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure

    <DllImport("dwmapi.dll")> _
    Private Shared Function DwmIsCompositionEnabled(ByRef enabled As Boolean) As Integer
    End Function

    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

    Public Function AeroEnabled() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then Return False
        Dim Enabled As Boolean
        DwmIsCompositionEnabled(Enabled)
        Return Enabled
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        botStTD.Text = "" & System.DateTime.Now
        timeTime.Enabled = True
        Try
            Dim Margins As MARGINS = New MARGINS
            Margins.left = 1
            Margins.Right = 1
            Margins.Top = 80
            Margins.Bottom = 1
            Dim Hwnd As IntPtr = Handle
            Dim Result As Integer = DwmExtendFrameIntoClientArea(Hwnd, Margins)
            Me.BackColor = Color.Black
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
        End Try
        Try
            Dim JList As JumpList
            JList = JumpList.CreateJumpListForIndividualWindow(0, Handle)
            JList.ClearAllUserTasks()
            'Add 2 Links to the Usertasks with a Separator
            Dim Link0 As New JumpListLink("cmd.exe", "Command Prompt") With {.IconReference =
                New IconReference("cmd.exe", 0)}
            Dim Link1 As New JumpListLink("Notepad.exe", "Microsoft Notepad") With {.IconReference =
                New IconReference("Notepad.exe", 0)}
            JList.AddUserTasks(Link0)
            JList.AddUserTasks(New JumpListSeparator())
            JList.AddUserTasks(Link1)
            'Create a Custom Category and Add an Item to it 
            Dim Link2 As New JumpListLink("Calc.exe", "Microsoft Calculator") With {.IconReference =
                New IconReference("Calc.exe", 0)}
            Dim Category As New JumpListCustomCategory("WCC Command Center")
            Category.AddJumpListItems(Link2)
            JList.AddCustomCategories(Category)
            'Add another Item to the Category But separete with a separator
            Dim Link3 As New JumpListLink("psr.exe", "Problem Steps Recorder") With {.IconReference =
                New IconReference("mspaint.exe", 0)}
            Category.AddJumpListItems(Link3)
            'to control which category Recent/Frequent is displayed 
            JList.KnownCategoryToDisplay = JumpListKnownCategoryType.Frequent
            JList.Refresh()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If the user's forcing it closed via task manager, or windows is shutting down: do not prompt
        If e.CloseReason <> CloseReason.TaskManagerClosing AndAlso e.CloseReason <> CloseReason.WindowsShutDown Then
            'Cancel only if the user selects No, otherwise it doesn't matter, the form's closing
            'No need for Application.Exit... ever
            e.Cancel = MessageBox.Show("Any information that has not been saved will be lost. " & _
                                       "Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        AppClose()
    End Sub

    Private Sub AppClose()
        'Application.Exit()
        Me.Close()
    End Sub

    Private Sub btnEmpty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpty.Click
        'On Error Resume Next
        Clipboard.Clear()
        'MsgBox("The contents of the Microsoft Windows Clipboard have been emptied completely.", MsgBoxStyle.Information)
        'NoClip:
        'MsgBox("The contents of the Microsoft Windows Clipboard could not properly be empited.", MsgBoxStyle.Critical)
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        docCount.Text = Clipboard.GetText
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Clipboard.SetDataObject(docCount.Text)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        docCount.Clear()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        docCount.Clear()
    End Sub

    Private Sub timeTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeTime.Tick
        If AeroEnabled() = True Then
            appPB.Image = My.Resources.art14758187
        Else
            appPB.Image = My.Resources.art14758188
        End If
        Dim Words As String() = docCount.Text.Split(New String() {" "}, StringSplitOptions.RemoveEmptyEntries)
        lblCount.Text = "Total Words: " & CStr(Words.Length.ToString)
        botGoTD.Text = "" & System.DateTime.Now
    End Sub

    Private Sub clkHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkHelp.Click
        If File.Exists(Application.StartupPath & "\wcc.chm") Then
            System.Diagnostics.Process.Start(Application.StartupPath & "\wcc.chm")
        Else
            MsgBox("The requested operation could not be completed due to the help file missing or an unknown error has occured. " & vbCrLf & vbCrLf & _
                   "The help file may be corrupted, damaged or has been removed. You may try installing this software again, " & _
                   "install the help file separately, optionally, you may try to contact the vendor for an update if one is available.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub clkAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub clkExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkExit.Click
        AppClose()
    End Sub

    Private Sub clkSysInf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkSysInf.Click
        SysInf.ShowDialog()
    End Sub

    Private Sub clkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkAll.Click
        docCount.SelectAll()
    End Sub

    Private Sub clkCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkCopy.Click
        Clipboard.SetDataObject(docCount.Text)
    End Sub

    Private Sub clkDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkDelete.Click
        docCount.Clear()
    End Sub

    Private Sub clkPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkPaste.Click
        docCount.Text = Clipboard.GetText
    End Sub

    Private Sub clkEmpty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkEmpty.Click
        docCount.Clear()
        Clipboard.Clear()
    End Sub

    Private Sub clkWWrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkWWrap.Click
        Me.docCount.WordWrap = Not Me.docCount.WordWrap
    End Sub

    Private Sub clkSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkSaveAs.Click
        Me.SaveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|HTML Documents (*.html)|*.html|Batch Files (*.bat)|*.bat|All Files (*.*)|*.*"
        Me.SaveFileDialog1.FilterIndex = 1
        Me.SaveFileDialog1.RestoreDirectory = True
        Me.SaveFileDialog1.Title = "Save Document As"
        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.docCount.Text, False)
        End If
    End Sub

    Private Sub clkTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkTD.Click
        Me.docCount.SelectedText = System.DateTime.Now.ToString
    End Sub

    Private Sub clkPPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkPPreview.Click
        Me.clkPPreview.Text = Me.clkPPreview.Text
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub clkOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkOpenFile.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.OpenFileDialog1.RestoreDirectory = True
            Me.OpenFileDialog1.Filter = "Text Documents (*.txt)|*.txt|HTML Documents (*.html)|*.html|Batch Files (*.bat)|*.bat|All Files (*.*)|*.*"
            Me.docCount.Text = My.Computer.FileSystem.ReadAllText(Me.OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub clkPageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkPageSetup.Click
        If Me.PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub clkPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkPrint.Click
        Try
            PrintDialog1.AllowSomePages = True
            PrintDialog1.Document = docToPrint
            Dim result As DialogResult = PrintDialog1.ShowDialog()
            If (result = DialogResult.OK) Then
                docToPrint.Print()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub Document_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docToPrint.PrintPage
        Dim PrintFont As New System.Drawing.Font("Courier", 12, System.Drawing.FontStyle.Regular, Me.docCount.WordWrap = Not Me.docCount.WordWrap)
        Dim Text As String = "This was created using Word Count Calculator by Charlie M. McDonald."
        e.Graphics.DrawString(Text + docCount.Text, PrintFont, System.Drawing.Brushes.Black, 10, 10)
    End Sub

    Private Sub authURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles authURL.LinkClicked
        Try
            System.Diagnostics.Process.Start("http://code.google.com/p/word-count-calculator/")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' This is intentionally hidden by default as it is not really needed by anyone, but was added only
    ' for testing purposes of the compiled version of this source code.
    ' This disables the Windows Aero® effect for Microsoft Windows Vista; 7; Server 2008; Server 2008 R2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles debugAeroStop.Click
        Try
            System.Diagnostics.Process.Start("net stop UxSms")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' This is intentionally hidden by default as it is not really needed by anyone, but was added only
    ' for testing purposes of the compiled version of this source code.
    ' This enables the Windows Aero® effect for Microsoft Windows Vista; 7; Server 2008; Server 2008 R2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles debugAeroStart.Click
        Try
            System.Diagnostics.Process.Start("net start UxSms")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WordCountCalculatorWebSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkWCCWS.Click
        Try
            System.Diagnostics.Process.Start("http://code.google.com/p/word-count-calculator/")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UniversityOfPheonixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkUoP.Click
        Try
            System.Diagnostics.Process.Start("http://www.phoenix.edu/")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub appPB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appPB.Click
        Try
            System.Diagnostics.Process.Start("http://code.google.com/p/word-count-calculator/")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub clkPSR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clkPSR.Click
        MsgBox("An application called Problem Steps Recorder (PSR) will now be started. This is only available in " & _
               "Microsoft Windows 7 and modern versions of Microsoft Windows." & vbCrLf & vbCrLf & _
               "If this is not your platform, a error message will be shown.", MsgBoxStyle.Information)
        Try
            System.Diagnostics.Process.Start("PSR.EXE")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDirectory.Click
        System.Diagnostics.Process.Start("EXPLORER.EXE")
    End Sub
End Class
