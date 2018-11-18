Public Class Form2
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.options = True
        My.Settings.optionsMot = (ComboBox1.Text)
        My.Settings.optionsFic = (TextBox1.Text)
        My.Settings.Save()
        Form1.WebBrowser1.Navigate(My.Settings.optionsMot)
        Form1.WebBrowser2.Navigate(My.Settings.optionsFic)
        Me.Hide()
    End Sub
End Class