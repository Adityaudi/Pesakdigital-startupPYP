Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GunaTextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub GunaImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaImageButton1.Click
        MsgBox("Yakin ingin keluar aplikasi?", MsgBoxStyle.YesNo)

        Me.Close()
        Form2.Close()
    End Sub


    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        If GunaTextBox1.Text = "" Or GunaTextBox2.Text = "" Then
            MsgBox("Periksa Nis Anda dan Password, Terimakasih", MsgBoxStyle.Critical, "Login gagal!!!")
        Else
            Call koneksi()
            cmd = New SqlCommand("SELECT * FROM TBL_LOGIN WHERE NIS = '" & GunaTextBox1.Text & "' AND PASSWORD = '" & GunaTextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If Not dr.HasRows Then
                GunaLabel2.Text = "Invalid Username & Password!!!"
                GunaTextBox2.Text = ""
                GunaWinCircleProgressIndicator1.Visible = True
            Else
                If dr("AKSES").ToString = "siswa" Then
                    GunaWinCircleProgressIndicator1.Visible = True
                    MsgBox("Login berhasil, Selamat datang kembali ;)", MsgBoxStyle.OkOnly, "Login Sukses")
                    Me.Close()
                    Form3.Show()

                End If
            End If
        End If
    End Sub
End Class
