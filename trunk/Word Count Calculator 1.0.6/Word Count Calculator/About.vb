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
' Description: This file shows the user that is running this software, information about
' the software such as the version installed, who it's licensed to, and other information.
' 
' Copyright © 1992-2012 Charlie M. McDonald. All rights reserved.

Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class About
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public Right As Integer
        Public left As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure

    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Margins As MARGINS = New MARGINS
        Margins.left = 1
        Margins.Right = 1
        Margins.Top = 80
        Margins.Bottom = 1
        Dim Hwnd As IntPtr = Handle
        Dim Result As Integer = DwmExtendFrameIntoClientArea(Hwnd, Margins)
        Me.BackColor = Color.Black

        Dim Regkey As RegistryKey
        Dim Ver As Decimal

        Dim ReadValue As String
        ReadValue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOwner", Nothing)
        lblLicensed.Text = "" & readValue

        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.lblApp.Text = "" & My.Application.Info.ProductName & vbCrLf & _
            "" & String.Format("Version {0}", My.Application.Info.Version.ToString) & vbCrLf & _
            "" & My.Application.Info.Copyright & vbCrLf & _
            "All rights reserved."
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
