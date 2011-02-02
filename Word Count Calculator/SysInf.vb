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
' the operating system, memory and other information about what is installed.
' 
' Copyright © 1992-2012 Charlie M. McDonald. All rights reserved.

Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class SysInf
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

    Private Sub SysInf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Margins As MARGINS = New MARGINS
        Margins.left = 1
        Margins.Right = 1
        Margins.Top = 100
        Margins.Bottom = 1
        Dim Hwnd As IntPtr = Handle
        Dim Result As Integer = DwmExtendFrameIntoClientArea(Hwnd, Margins)
        Me.BackColor = Color.Black
        shwOS1.Text = My.Computer.Info.OSFullName
        shwOS2.Text = My.Computer.Info.OSPlatform
        shwOS3.Text = My.Computer.Info.OSVersion
        shwTotalMem.Text = My.Computer.Info.TotalPhysicalMemory & " bytes total."
        shwFreeMem.Text = My.Computer.Info.AvailablePhysicalMemory & " bytes available."
        shwTotalVMem.Text = My.Computer.Info.TotalVirtualMemory & " bytes total."
        shwFreeVMem.Text = My.Computer.Info.AvailableVirtualMemory & " bytes available."


    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
