<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysInf
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shwTotalMem = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.shwFreeMem = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.shwFreeVMem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shwTotalVMem = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.shwOS1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.shwOS2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.shwOS3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.appPB = New System.Windows.Forms.PictureBox()
        CType(Me.appPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(97, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Physical Memory:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'shwTotalMem
        '
        Me.shwTotalMem.BackColor = System.Drawing.Color.Transparent
        Me.shwTotalMem.ForeColor = System.Drawing.Color.Lime
        Me.shwTotalMem.Location = New System.Drawing.Point(300, 170)
        Me.shwTotalMem.Name = "shwTotalMem"
        Me.shwTotalMem.Size = New System.Drawing.Size(257, 13)
        Me.shwTotalMem.TabIndex = 1
        Me.shwTotalMem.Text = "Information could not be retrieved."
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(290, 245)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'shwFreeMem
        '
        Me.shwFreeMem.BackColor = System.Drawing.Color.Transparent
        Me.shwFreeMem.ForeColor = System.Drawing.Color.Lime
        Me.shwFreeMem.Location = New System.Drawing.Point(300, 183)
        Me.shwFreeMem.Name = "shwFreeMem"
        Me.shwFreeMem.Size = New System.Drawing.Size(257, 20)
        Me.shwFreeMem.TabIndex = 4
        Me.shwFreeMem.Text = "Information could not be retrieved."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(97, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Available Physical Memory:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'shwFreeVMem
        '
        Me.shwFreeVMem.BackColor = System.Drawing.Color.Transparent
        Me.shwFreeVMem.ForeColor = System.Drawing.Color.Lime
        Me.shwFreeVMem.Location = New System.Drawing.Point(300, 209)
        Me.shwFreeVMem.Name = "shwFreeVMem"
        Me.shwFreeVMem.Size = New System.Drawing.Size(257, 20)
        Me.shwFreeVMem.TabIndex = 8
        Me.shwFreeVMem.Text = "Information could not be retrieved."
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(97, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Available Virtual Memory:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'shwTotalVMem
        '
        Me.shwTotalVMem.BackColor = System.Drawing.Color.Transparent
        Me.shwTotalVMem.ForeColor = System.Drawing.Color.Lime
        Me.shwTotalVMem.Location = New System.Drawing.Point(300, 196)
        Me.shwTotalVMem.Name = "shwTotalVMem"
        Me.shwTotalVMem.Size = New System.Drawing.Size(257, 20)
        Me.shwTotalVMem.TabIndex = 6
        Me.shwTotalVMem.Text = "Information could not be retrieved."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(97, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Virtual Memory:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'shwOS1
        '
        Me.shwOS1.BackColor = System.Drawing.Color.Transparent
        Me.shwOS1.ForeColor = System.Drawing.Color.Lime
        Me.shwOS1.Location = New System.Drawing.Point(300, 131)
        Me.shwOS1.Name = "shwOS1"
        Me.shwOS1.Size = New System.Drawing.Size(257, 13)
        Me.shwOS1.TabIndex = 10
        Me.shwOS1.Text = "Information could not be retrieved."
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(97, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Microsoft Windows® Platform Installed:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'shwOS2
        '
        Me.shwOS2.BackColor = System.Drawing.Color.Transparent
        Me.shwOS2.ForeColor = System.Drawing.Color.Lime
        Me.shwOS2.Location = New System.Drawing.Point(300, 157)
        Me.shwOS2.Name = "shwOS2"
        Me.shwOS2.Size = New System.Drawing.Size(257, 13)
        Me.shwOS2.TabIndex = 12
        Me.shwOS2.Text = "Information could not be retrieved."
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(97, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Microsoft Windows® Platform Type:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'shwOS3
        '
        Me.shwOS3.BackColor = System.Drawing.Color.Transparent
        Me.shwOS3.ForeColor = System.Drawing.Color.Lime
        Me.shwOS3.Location = New System.Drawing.Point(300, 144)
        Me.shwOS3.Name = "shwOS3"
        Me.shwOS3.Size = New System.Drawing.Size(257, 13)
        Me.shwOS3.TabIndex = 14
        Me.shwOS3.Text = "Information could not be retrieved."
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(97, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Microsoft Windows® Platform Version:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'appPB
        '
        Me.appPB.BackColor = System.Drawing.Color.Transparent
        Me.appPB.Image = Global.Word_Count_Calculator.My.Resources.Resources.art147581871
        Me.appPB.Location = New System.Drawing.Point(172, 12)
        Me.appPB.Name = "appPB"
        Me.appPB.Size = New System.Drawing.Size(311, 37)
        Me.appPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.appPB.TabIndex = 15
        Me.appPB.TabStop = False
        '
        'SysInf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(654, 280)
        Me.Controls.Add(Me.appPB)
        Me.Controls.Add(Me.shwOS3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.shwOS2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.shwOS1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.shwFreeVMem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.shwTotalVMem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.shwFreeMem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.shwTotalMem)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SysInf"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Information"
        CType(Me.appPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents shwTotalMem As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents shwFreeMem As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents shwFreeVMem As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents shwTotalVMem As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents shwOS1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents shwOS2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents shwOS3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents appPB As System.Windows.Forms.PictureBox

End Class
