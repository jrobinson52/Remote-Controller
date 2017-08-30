Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Define variables for login
        ' Dim strUID As String
        ' Dim strPassword As String


        ' store login info for next launch
        If cboxRememberID.Checked = True Then
            My.Settings.UID = txtUID.Text
            My.Settings.Password = txtPassword.Text
        ElseIf cboxRememberID.Checked = False Then
            My.Settings.UID = String.Empty
            My.Settings.Password = String.Empty
        End If

        ' store login for use in program
        strUID = txtUID.Text
        strPassword = txtPassword.Text

        ' reference main form for launch
        Dim frmMain As New MainForm

        ' launch main form
        frmMain.Show()

        ' hide login form
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' load stored user ID and password
        txtUID.Text = My.Settings.UID
        txtPassword.Text = My.Settings.Password
    End Sub
End Class