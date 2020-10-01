Public Class Form5

    Private Sub GunaGroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaGroupBox1.Click

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'RectangleShape1.Width += 1
        'If RectangleShape1.Width >= 300 Then
        '        Timer1.Stop()
        '    Me.Close()
        'End If
    End Sub

    Private Sub GunaLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel4.Click

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub
End Class