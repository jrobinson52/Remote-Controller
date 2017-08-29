<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IECC
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
        Me.cbxTempFilesIE = New System.Windows.Forms.CheckBox()
        Me.cbxCookies = New System.Windows.Forms.CheckBox()
        Me.cbxHistory = New System.Windows.Forms.CheckBox()
        Me.cbxFormData = New System.Windows.Forms.CheckBox()
        Me.cbxPasswords = New System.Windows.Forms.CheckBox()
        Me.cbxAll = New System.Windows.Forms.CheckBox()
        Me.cbxAddOn = New System.Windows.Forms.CheckBox()
        Me.gboxCC = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gboxCC.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxTempFilesIE
        '
        Me.cbxTempFilesIE.AutoSize = True
        Me.cbxTempFilesIE.Checked = True
        Me.cbxTempFilesIE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxTempFilesIE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTempFilesIE.Location = New System.Drawing.Point(22, 32)
        Me.cbxTempFilesIE.Name = "cbxTempFilesIE"
        Me.cbxTempFilesIE.Size = New System.Drawing.Size(145, 20)
        Me.cbxTempFilesIE.TabIndex = 0
        Me.cbxTempFilesIE.Text = "Temp Files (Cache)"
        Me.cbxTempFilesIE.UseVisualStyleBackColor = True
        '
        'cbxCookies
        '
        Me.cbxCookies.AutoSize = True
        Me.cbxCookies.Checked = True
        Me.cbxCookies.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxCookies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCookies.Location = New System.Drawing.Point(22, 58)
        Me.cbxCookies.Name = "cbxCookies"
        Me.cbxCookies.Size = New System.Drawing.Size(77, 20)
        Me.cbxCookies.TabIndex = 0
        Me.cbxCookies.Text = "Cookies"
        Me.cbxCookies.UseVisualStyleBackColor = True
        '
        'cbxHistory
        '
        Me.cbxHistory.AutoSize = True
        Me.cbxHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxHistory.Location = New System.Drawing.Point(22, 84)
        Me.cbxHistory.Name = "cbxHistory"
        Me.cbxHistory.Size = New System.Drawing.Size(69, 20)
        Me.cbxHistory.TabIndex = 0
        Me.cbxHistory.Text = "History"
        Me.cbxHistory.UseVisualStyleBackColor = True
        '
        'cbxFormData
        '
        Me.cbxFormData.AutoSize = True
        Me.cbxFormData.Checked = True
        Me.cbxFormData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxFormData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFormData.Location = New System.Drawing.Point(22, 110)
        Me.cbxFormData.Name = "cbxFormData"
        Me.cbxFormData.Size = New System.Drawing.Size(90, 20)
        Me.cbxFormData.TabIndex = 0
        Me.cbxFormData.Text = "Form Data"
        Me.cbxFormData.UseVisualStyleBackColor = True
        '
        'cbxPasswords
        '
        Me.cbxPasswords.AutoSize = True
        Me.cbxPasswords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPasswords.Location = New System.Drawing.Point(22, 136)
        Me.cbxPasswords.Name = "cbxPasswords"
        Me.cbxPasswords.Size = New System.Drawing.Size(94, 20)
        Me.cbxPasswords.TabIndex = 0
        Me.cbxPasswords.Text = "Passwords"
        Me.cbxPasswords.UseVisualStyleBackColor = True
        '
        'cbxAll
        '
        Me.cbxAll.AutoSize = True
        Me.cbxAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAll.Location = New System.Drawing.Point(22, 162)
        Me.cbxAll.Name = "cbxAll"
        Me.cbxAll.Size = New System.Drawing.Size(42, 20)
        Me.cbxAll.TabIndex = 0
        Me.cbxAll.Text = "All"
        Me.cbxAll.UseVisualStyleBackColor = True
        '
        'cbxAddOn
        '
        Me.cbxAddOn.AutoSize = True
        Me.cbxAddOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddOn.Location = New System.Drawing.Point(22, 188)
        Me.cbxAddOn.Name = "cbxAddOn"
        Me.cbxAddOn.Size = New System.Drawing.Size(124, 20)
        Me.cbxAddOn.TabIndex = 0
        Me.cbxAddOn.Text = "Add-On Settings"
        Me.cbxAddOn.UseVisualStyleBackColor = True
        '
        'gboxCC
        '
        Me.gboxCC.Controls.Add(Me.cbxAddOn)
        Me.gboxCC.Controls.Add(Me.cbxAll)
        Me.gboxCC.Controls.Add(Me.cbxPasswords)
        Me.gboxCC.Controls.Add(Me.cbxFormData)
        Me.gboxCC.Controls.Add(Me.cbxHistory)
        Me.gboxCC.Controls.Add(Me.cbxCookies)
        Me.gboxCC.Controls.Add(Me.cbxTempFilesIE)
        Me.gboxCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxCC.Location = New System.Drawing.Point(87, 34)
        Me.gboxCC.Name = "gboxCC"
        Me.gboxCC.Size = New System.Drawing.Size(169, 228)
        Me.gboxCC.TabIndex = 1
        Me.gboxCC.TabStop = False
        Me.gboxCC.Text = "Items to delete"
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnCancel.FlatAppearance.BorderSize = 5
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(87, 269)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(169, 41)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(87, 316)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(169, 41)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'IECC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 401)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gboxCC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IECC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Internet Explorer Cache and Cookies"
        Me.gboxCC.ResumeLayout(False)
        Me.gboxCC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxTempFilesIE As CheckBox
    Friend WithEvents cbxCookies As CheckBox
    Friend WithEvents cbxHistory As CheckBox
    Friend WithEvents cbxFormData As CheckBox
    Friend WithEvents cbxPasswords As CheckBox
    Friend WithEvents cbxAll As CheckBox
    Friend WithEvents cbxAddOn As CheckBox
    Friend WithEvents gboxCC As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
End Class
