Public Class frmMainGitTest

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        MsgBox("Hello man aaa")
    End Sub

    Private Sub btnPresentarse_Click(sender As Object, e As EventArgs) Handles btnPresentarse.Click
        MsgBox("My name is Git")
    End Sub

End Class
