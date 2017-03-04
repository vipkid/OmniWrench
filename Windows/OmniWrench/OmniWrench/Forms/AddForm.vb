Public Class AddForm

    Private Sub chkPasswd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPasswd.CheckedChanged
        If chkPasswd.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If


    End Sub
End Class