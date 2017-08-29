<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCMD = New System.Windows.Forms.Button()
        Me.txtComputer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGPUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnIECC = New System.Windows.Forms.Button()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCMD
        '
        Me.btnCMD.Location = New System.Drawing.Point(276, 101)
        Me.btnCMD.Name = "btnCMD"
        Me.btnCMD.Size = New System.Drawing.Size(92, 67)
        Me.btnCMD.TabIndex = 0
        Me.btnCMD.Text = "Launch Remote Command Line " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(as local admin)"
        Me.btnCMD.UseVisualStyleBackColor = True
        '
        'txtComputer
        '
        Me.txtComputer.AllowDrop = True
        Me.txtComputer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComputer.Location = New System.Drawing.Point(29, 101)
        Me.txtComputer.Name = "txtComputer"
        Me.txtComputer.Size = New System.Drawing.Size(100, 20)
        Me.txtComputer.TabIndex = 2
        Me.txtComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Computer Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(unqualified)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGPUpdate
        '
        Me.btnGPUpdate.Location = New System.Drawing.Point(161, 101)
        Me.btnGPUpdate.Name = "btnGPUpdate"
        Me.btnGPUpdate.Size = New System.Drawing.Size(92, 67)
        Me.btnGPUpdate.TabIndex = 0
        Me.btnGPUpdate.Text = "GPUpdate"
        Me.btnGPUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "(Currently has limited use)"
        '
        'btnIECC
        '
        Me.btnIECC.Location = New System.Drawing.Point(276, 20)
        Me.btnIECC.Name = "btnIECC"
        Me.btnIECC.Size = New System.Drawing.Size(92, 67)
        Me.btnIECC.TabIndex = 0
        Me.btnIECC.Text = "IE Cache and Cookies"
        Me.btnIECC.UseVisualStyleBackColor = True
        '
        'btnTemp
        '
        Me.btnTemp.Location = New System.Drawing.Point(161, 20)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(92, 67)
        Me.btnTemp.TabIndex = 0
        Me.btnTemp.Text = "Clear Temp Files"
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 224)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtComputer)
        Me.Controls.Add(Me.btnTemp)
        Me.Controls.Add(Me.btnIECC)
        Me.Controls.Add(Me.btnGPUpdate)
        Me.Controls.Add(Me.btnCMD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Remote Commands"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCMD As Button
    Friend WithEvents txtComputer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGPUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIECC As Button
    Friend WithEvents btnTemp As Button
End Class
