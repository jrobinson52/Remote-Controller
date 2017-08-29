Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Define variables for login
        ' Dim strUID As String
        ' Dim strPassword As String

        ' store login info
        strUID = txtUID.Text
        strPassword = txtPassword.Text

        ' reference main form for launch
        Dim frmMain As New MainForm

        ' launch main form
        frmMain.Show()

        ' hide login form
        Me.Hide()
    End Sub


End Class