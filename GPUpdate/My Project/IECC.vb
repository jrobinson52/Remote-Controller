Imports System.Security

Public Class IECC
    Private Sub IECC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Import computername
        'Dim strComputer As String
        strComputer = MainForm.txtComputer.Text()

        ' import login form to pull login info
        ' Dim frmLogin As New Login

        ' Define login password
        Dim str = strPassword ' frmLogin.txtPassword.Text() ' password
        Dim sc = New SecureString()
        For Each c As Char In str
            sc.AppendChar(c)
        Next

        ' Display infomational message
        MessageBox.Show("This may take a moment to take affect on client computer." & vbNewLine & "This window will close automatically.")

        ' Clear cache and cookies on remote computer
        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As New System.Diagnostics.ProcessStartInfo()
        Dim path As String = Directory.GetCurrentDirectory()
        processStartInfo.FileName = "CMD"
        processStartInfo.Verb = "runas"

        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        processStartInfo.UseShellExecute = False
        processStartInfo.UserName = strUID  ' frmLogin.txtUID.Text() ' UID 
        processStartInfo.Password = sc ' password
        processStartInfo.Domain = "TMM"

        'Doesn't work
        ' processStartInfo.Arguments = $"/k .\PsExec.exe \\{strComputer} del C:\Users\*\AppData\Local\Microsoft\Windows\Temporary Internet Files\*"

        ' begin delete files based on checked boxes --------------------------------------------------------------------------------
        ' only one can be selected at a time in this configuration
        ' this clears the temp files from user account of person running the program not the logged on user
        If cbxTempFilesIE.Checked = True Then
            'processStartInfo.Arguments = "/k .\PsExec.exe -i \\" + strComputer + " -l c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 8" ' <<-- THIS DEFINES WHAT HAPPENS
            processStartInfo.Arguments = "/k .\PsExec.exe -i -s \\" + strComputer + " -r C:\Windows\System32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 8"
        ElseIf cbxCookies.Checked = True Then
            ' processStartInfo.Arguments = "/k .\PsExec.exe -i \\" + strComputer + " -l c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 2"
            processStartInfo.Arguments = "/k .\PsExec.exe -i -s \\" + strComputer + " -r c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 2"
        ElseIf cbxHistory.Checked = True Then
            ' processStartInfo.Arguments = "/k .\PsExec.exe -i \\" + strComputer + " -l c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 1"
            processStartInfo.Arguments = "/k .\PsExec.exe -i -s \\" + strComputer + " -r c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 1"
        ElseIf cbxFormData.Checked = True Then
            ' processStartInfo.Arguments = "/k .\PsExec.exe -i \\" + strComputer + " -l c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 16"
            processStartInfo.Arguments = "/k .\PsExec.exe -i -s \\" + strComputer + " -r c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 16"
        ElseIf cbxPasswords.Checked = True Then
            ' processStartInfo.Arguments = "/k .\PsExec.exe -i \\" + strComputer + " -l c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 32"
            processStartInfo.Arguments = "/k .\PsExec.exe -i -s \\" + strComputer + " -r c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 32"
        ElseIf cbxAll.Checked = True Then
            ' processStartInfo.Arguments = "/k .\PsExec.exe -i \\" + strComputer + " -l c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 255"
            processStartInfo.Arguments = "/k .\PsExec.exe -i -s \\" + strComputer + " -r c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 255"
        ElseIf cbxAddOn.Checked = True Then
            ' processStartInfo.Arguments = "/k .\PsExec.exe -i \\" + strComputer + " -l c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 4351"
            processStartInfo.Arguments = "/k .\PsExec.exe -i -s \\" + strComputer + " -r c:\windows\system32\RunDll32.exe InetCpl.cpl, ClearMyTracksByProcess 4351"
        Else
            MessageBox.Show("Sorry, an error has occured.")


            Try
                process = System.Diagnostics.Process.Start(processStartInfo)
                process.WaitForExit()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not (process Is Nothing) Then
                    process.Dispose()
                End If
            End Try
        End If
        ' --------------------------------------------------------------------------------------------------------------------------

        ' --------------------------------------------------------------------------------------------------------------------------
        ' other option using https://pradeep1210.wordpress.com/2010/02/04/launching-and-controlling-external-applications-from-vb-net-application/

        ' located in form test


        ' --------------------------------------------------------------------------------------------------------------------------
        Me.Close()

    End Sub
End Class