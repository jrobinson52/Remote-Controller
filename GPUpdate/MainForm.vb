Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Security

Public Class MainForm
    Private Sub btnCMD_Click(sender As Object, e As EventArgs) Handles btnCMD.Click
        ' Process.Start("cmd.exe")

        ' Create instance of CMD
        'Dim openCMD
        'openCMD = Process.Start("cmd.exe")



        ' Send text to CMD?
        'Dim strCMDcommand As String = "whoami"
        'SendKeys.Send(strCMDcommand)



        ' Define computername
        ' Dim strComputerName As String
        strComputer = txtComputer.Text()

        ' import login form to pull login info
        Dim frmLogin As New Login

        ' Define Login password
        Dim str = strPassword ' frmLogin.txtPassword.Text() ' Password
        Dim sc = New SecureString()
        For Each c As Char In str
            sc.AppendChar(c)
        Next



        ' Define string for location of psexec
        'Dim strPsExec As String 'C:\Users\421067\Documents\"Visual Studio 2017"\Projects\GPUpdate\GPUpdate\PsExec.exe
        'strPsExec = lblPsExecLocation.Text()

        ' Display infomational message
        MessageBox.Show("Please note that Error Code 0 is success.")

        ' Run CMD
        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As New System.Diagnostics.ProcessStartInfo()
        Dim path As String = Directory.GetCurrentDirectory()
        processStartInfo.FileName = "CMD"
        processStartInfo.Verb = "runas"

        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        processStartInfo.UseShellExecute = False
        processStartInfo.UserName = strUID ' frmLogin.txtUID.Text() ' Username
        processStartInfo.Password = sc
        processStartInfo.Domain = "TMM"

        processStartInfo.Arguments = "/k .\PsExec.exe \\" + strComputer + " cmd -nobanner -accepteula"  ' <<-- THIS DEFINES WHAT HAPPENS


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


        ' CODE COPIED FROM SERV DESK TOOL along with above (which has been modified)

        'If SetAdPassword.CheckBox2.Checked = True Then
        'processStartInfo = New System.Diagnostics.ProcessStartInfo()
        'processStartInfo.FileName = "CMD"
        'processStartInfo.Verb = "runas"
        'processStartInfo.Arguments = "/c EA /DOMAIN:TMM /SERVER:" + DRAServername + " USER " + samaccountholder + " UPDATE PASSWORDEXPIRED:Y"
        'processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        'processStartInfo.UseShellExecute = False
        'processStartInfo.UserName = frmLogin.TextBox4.Text
        'processStartInfo.Password = sc
        'processStartInfo.Domain = "TMM"
        'Try
        'process = System.Diagnostics.Process.Start(processStartInfo)
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '
        'If Not (process Is Nothing) Then
        'process.Dispose()
        'End If

        'End Try
        'End If
        'For i As Integer = 1 To 10
        'System.Threading.Thread.Sleep(1)
        'System.Windows.Forms.Application.DoEvents()
        'Next
        'If SetAdPassword.CheckBox2.Checked = True Then
        'MessageBox.Show("All done, do not close the DOS window it will close itself")
        'Else
        'MessageBox.Show("All done")
        'End If



    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Login.Close()
    End Sub

    Private Sub btnGPUpdate_Click(sender As Object, e As EventArgs) Handles btnGPUpdate.Click
        ' Define computername
        ' Dim strComputerName As String
        strComputer = txtComputer.Text()

        ' import login form to pull login info
        ' Dim frmLogin As New Login

        ' Define login password
        Dim str = strPassword ' frmLogin.txtPassword.Text() ' password
        Dim sc = New SecureString()
        For Each c As Char In str
            sc.AppendChar(c)
        Next

        ' Display infomational message
        MessageBox.Show("This will take a moment" + vbNewLine + "Please note that Error Code 0 Is success.")

        ' Run GPupdate on remote computer
        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As New System.Diagnostics.ProcessStartInfo()
        Dim path As String = Directory.GetCurrentDirectory()
        processStartInfo.FileName = "CMD"
        processStartInfo.Verb = "runas"

        processStartInfo.Arguments = "/k .\PsExec.exe \\" + strComputer + " -r gpupdate.exe cmd" ' <<-- THIS DEFINES WHAT HAPPENS

        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        processStartInfo.UseShellExecute = False
        processStartInfo.UserName = strUID ' frmLogin.txtUID.Text() ' UID
        processStartInfo.Password = sc
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



    End Sub

    Private Sub btnIECC_Click(sender As Object, e As EventArgs) Handles btnIECC.Click
        Dim frmCC As New IECC
        frmCC.Show()
    End Sub

    Private Sub btnTemp_Click(sender As Object, e As EventArgs) Handles btnTemp.Click
        Dim frmTemp As New TempFiles
        frmTemp.Show()
    End Sub
End Class
