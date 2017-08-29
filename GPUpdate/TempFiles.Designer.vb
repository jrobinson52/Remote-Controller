<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempFiles
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
        Me.cboxWindowsTemp = New System.Windows.Forms.CheckBox()
        Me.cboxCCM = New System.Windows.Forms.CheckBox()
        Me.cboxTemp = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboxWindowsTemp
        '
        Me.cboxWindowsTemp.AutoSize = True
        Me.cboxWindowsTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxWindowsTemp.Location = New System.Drawing.Point(5, 39)
        Me.cboxWindowsTemp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxWindowsTemp.Name = "cboxWindowsTemp"
        Me.cboxWindowsTemp.Size = New System.Drawing.Size(187, 24)
        Me.cboxWindowsTemp.TabIndex = 0
        Me.cboxWindowsTemp.Text = "Windows Temp Files"
        Me.cboxWindowsTemp.UseVisualStyleBackColor = True
        '
        'cboxCCM
        '
        Me.cboxCCM.AutoSize = True
        Me.cboxCCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCCM.Location = New System.Drawing.Point(5, 85)
        Me.cboxCCM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxCCM.Name = "cboxCCM"
        Me.cboxCCM.Size = New System.Drawing.Size(122, 24)
        Me.cboxCCM.TabIndex = 0
        Me.cboxCCM.Text = "CCM Cache"
        Me.cboxCCM.UseVisualStyleBackColor = True
        '
        'cboxTemp
        '
        Me.cboxTemp.AutoSize = True
        Me.cboxTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTemp.Location = New System.Drawing.Point(5, 135)
        Me.cboxTemp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxTemp.Name = "cboxTemp"
        Me.cboxTemp.Size = New System.Drawing.Size(205, 24)
        Me.cboxTemp.TabIndex = 0
        Me.cboxTemp.Text = "%Temp% (not working)"
        Me.cboxTemp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboxTemp)
        Me.GroupBox1.Controls.Add(Me.cboxWindowsTemp)
        Me.GroupBox1.Controls.Add(Me.cboxCCM)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(272, 186)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Files to Delete"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(51, 262)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(272, 58)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE FILES"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(51, 341)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(272, 65)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TempFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 468)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TempFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TempFiles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboxWindowsTemp As CheckBox
    Friend WithEvents cboxCCM As CheckBox
    Friend WithEvents cboxTemp As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
End Class
