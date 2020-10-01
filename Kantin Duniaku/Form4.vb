Public Class Form4

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt3.Enabled = False
        txt2.Enabled = False
        txt1.Enabled = True
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        If txt2.Text <> txt3.Text Then
            MsgBox("Password Baru tidak Sama, Silahkan Ulagi")
        Else
            Call koneksi()
            cmd = New SqlClient.SqlCommand("UPDATE TBL_LOGIN SET PASSWORD = '" & txt2.Text & " ' WHERE NIS = '" & Form1.GunaTextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Password Baru Berhasil diganti, TerimaKasih", MsgBoxStyle.Information)
            txt1.Text = ""
            txt2.Text = ""
            txt3.Text = ""
            txt3.Enabled = False
            txt2.Enabled = False
            txt1.Enabled = True

        End If
    End Sub

    Private Sub txt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New SqlClient.SqlCommand("SELECT NIS, PASSWORD FROM TBL_LOGIN WHERE NIS = '" & Form1.GunaTextBox1.Text & "' AND PASSWORD = '" & txt1.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If Not dr.HasRows Then
                MsgBox("Password Lama anda salah!!!", MsgBoxStyle.Critical)
                txt1.Text = ""
            Else
                Dim result As DialogResult = MessageBox.Show("Confirm update?", _
                              "Title", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (result = DialogResult.Yes) Then
                    txt1.Enabled = True
                    txt2.Enabled = True
                    txt3.Enabled = True
                    txt2.Focus()
                Else
                    result = DialogResult.No
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged

  
    End Sub

    Private Sub GunaImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class