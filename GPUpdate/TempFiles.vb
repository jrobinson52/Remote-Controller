Imports System.Security

Public Class TempFiles
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Clear temp files based on checked boxes
        If cboxWindowsTemp.Checked = True Then
            ' Define computername
            strComputer = MainForm.txtComputer.Text()

            ' Define login password
            Dim str = strPassword ' password
            Dim sc = New SecureString()
            For Each c As Char In str
                sc.AppendChar(c)
            Next

            ' Display infomational message
            MessageBox.Show("This will take a moment" + vbNewLine + "Please note that Error Code 0 Is success.")

            ' Remove files on remote computer
            Dim process As System.Diagnostics.Process = Nothing
            Dim processStartInfo As New System.Diagnostics.ProcessStartInfo()
            Dim path As String = Directory.GetCurrentDirectory()
            processStartInfo.FileName = "CMD"
            processStartInfo.Verb = "runas"

            processStartInfo.Arguments = "/k .\PsExec.exe \\" + strComputer + " -r " ' <<-- THIS DEFINES WHAT HAPPENS

            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            processStartInfo.UseShellExecute = False
            processStartInfo.UserName = strUID ' UID
            processStartInfo.Password = sc ' Password
            processStartInfo.Domain = "TMM"
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
    End Sub
End Class