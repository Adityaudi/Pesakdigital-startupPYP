'Imports System.Data.SqlClient
'Public Class Form3

'    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click



'    End Sub

'    Private Sub GunaButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton3.Click
'        minuman.Visible = True
'        panelminuman.Visible = True
'        GunaPanel1.Visible = True
'        GunaWinCircleProgressIndicator4.Visible = False
'        GunaGradientPanel1.Visible = False
'        GunaGroupBox2.Visible = False

'        profil.Visible = False
'        pulsa1.Visible = False
'        keranjang.Visible = False
'        keranjang1.Visible = False
'    End Sub

'    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'        Timer1.Start()



'        dgv.Columns.Add("NO", "NO")
'        dgv.Columns.Add("Menu", "Menu")
'        dgv.Columns.Add("Harga", "Harga")
'        dgv.Columns.Add("Qty", "Qty")
'        dgv.Columns.Add("coba", "coba")

'        dgv.Columns(0).Width = "50"
'        dgv.Columns(1).Width = "180"
'        dgv.Columns(2).Width = "150"
'        dgv.Columns(3).Width = "100"
'        dgv.Columns(4).Width = "10"
'    End Sub

'    Private Sub GunaImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaImageButton1.Click
'        Me.Close()
'    End Sub

'    Private Sub GunaPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

'    End Sub

'    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

'    End Sub

'    Private Sub baru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaLinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

'    End Sub

'    Private Sub nama1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nama1.TextChanged
'        Call koneksi()
'        cmd = New SqlCommand("SELECT NIS,NAMA,PHOTO FROM TBL_LOGIN WHERE NIS = '" & Form1.GunaTextBox1.Text & "'", conn)
'        dr = cmd.ExecuteReader
'        If dr.Read Then
'            nama1.Text = dr.Item("NAMA")
'            Label1.Text = dr.Item("PHOTO")
'            pic2.ImageLocation = Label1.Text
'        End If

'    End Sub

'    Private Sub nama1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nama1.Click

'    End Sub

'    Private Sub nama2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub nama2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub Label2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

'    End Sub
'    Private Sub GunaLabel4_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaLinePanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GunaLinePanel1.Paint

'    End Sub

'    'Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click

'    'End Sub

'    Private Sub loading1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaCirclePictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaDataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

'    End Sub

'    Private Sub GunaButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton4.Click
'        'GunaGradientPanel1.Visible = False
'        'GunaGroupBox2.Visible = False
'        'utama.Visible = False
'        'panelpulsa.Visible = False
'        'profil.Visible = False
'        'pulsa1.Visible = False

'        'pulsa.Visible = False
'        'pulsa1.Visible = False
'        'panelminuman.Visible = False
'        'minuman.Visible = False
'        'keranjang.Visible = True
'        'keranjang1.Visible = True
'    End Sub

'    Private Sub total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaCirclePictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub


'    Sub hitung()
'        Dim hitung As Integer = 0
'        For i As Integer = 0 To dgv.Rows.Count - 1
'            hitung = hitung + dgv.Rows(i).Cells(4).Value
'            total.Text = hitung
'            total.Text = FormatCurrency(total.Text, 0)
'        Next
'    End Sub


'    Private Sub baru_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

'    End Sub

'    Private Sub GunaLinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
'        Form4.ShowDialog()
'    End Sub

'    Private Sub GunaButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


'    End Sub

'    Private Sub nama2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub nama2_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaCirclePictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim result As DialogResult = MessageBox.Show("Produk ini seharga Rp.12.000. Apakah anda ingin membelinya?", _
'                            "Konfirmasi Pesanan", _
'                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
'        If (result = DialogResult.Yes) Then
'            For baris As Integer = 0 To dgv.RowCount - 1
'                If dgv.Rows(baris).Cells(1).Value = GunaLabel16.Text Then
'                    dgv.Rows(baris).Cells(3).Value = Val(dgv.Rows(baris).Cells(3).Value) + Val(GunaLabel17.Text)
'                    dgv.Rows(baris).Cells(4).Value = Val(dgv.Rows(baris).Cells(3).Value) * Val(dgv.Rows(baris).Cells(2).Value)
'                    MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'                    Call hitung()
'                    Exit Sub
'                End If
'            Next
'            dgv.Rows.Add(New String() {"1", GunaLabel16.Text, GunaLabel18.Text, GunaLabel17.Text, Val(GunaLabel17.Text) * Val(GunaLabel18.Text)})
'            Call hitung()
'            MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'        End If

'    End Sub

'    Private Sub GunaCirclePictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub



'    Private Sub GunaCirclePictureBox7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim result As DialogResult = MessageBox.Show("Produk ini seharga Rp.4.000. Apakah anda ingin membelinya?", _
'                            "Konfirmasi Pesanan", _
'                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
'        If (result = DialogResult.Yes) Then
'            For baris As Integer = 0 To dgv.RowCount - 1
'                If dgv.Rows(baris).Cells(1).Value = Menu10.Text Then
'                    dgv.Rows(baris).Cells(3).Value = Val(dgv.Rows(baris).Cells(3).Value) + Val(GunaLabel17.Text)
'                    dgv.Rows(baris).Cells(4).Value = Val(dgv.Rows(baris).Cells(3).Value) * Val(dgv.Rows(baris).Cells(2).Value)
'                    MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'                    Call hitung()
'                    Exit Sub
'                End If
'            Next
'            dgv.Rows.Add(New String() {"3", Menu10.Text, GunaLabel25.Text, GunaLabel17.Text, Val(GunaLabel25.Text) * Val(GunaLabel17.Text)})
'            Call hitung()
'            MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'        End If
'    End Sub

'    Private Sub GunaCirclePictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim result As DialogResult = MessageBox.Show("Produk ini seharga Rp.15.000. Apakah anda ingin membelinya?", _
'                            "Konfirmasi Pesanan", _
'                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
'        If (result = DialogResult.Yes) Then
'            For baris As Integer = 0 To dgv.RowCount - 1
'                If dgv.Rows(baris).Cells(1).Value = GunaLabel5.Text Then
'                    dgv.Rows(baris).Cells(3).Value = Val(dgv.Rows(baris).Cells(3).Value) + Val(GunaLabel17.Text)
'                    dgv.Rows(baris).Cells(4).Value = Val(dgv.Rows(baris).Cells(3).Value) * Val(dgv.Rows(baris).Cells(2).Value)
'                    MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'                    Call hitung()
'                    Exit Sub
'                End If
'            Next
'            dgv.Rows.Add(New String() {"2", GunaLabel5.Text, GunaLabel19.Text, GunaLabel17.Text, Val(GunaLabel17.Text) * Val(GunaLabel19.Text)})
'            Call hitung()
'            MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'        End If
'    End Sub


'    Private Sub GunaLabel12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaLabel12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
'        Call koneksi()
'        cmd = New SqlCommand("SELECT * FROM TBL_LOGIN WHERE NIS = '" & Form1.GunaTextBox1.Text & "'", conn)
'        dr = cmd.ExecuteReader
'        If dr.Read Then
'            GunaLabel12.Text = Form1.GunaTextBox1.Text
'            GunaTextBox1.Text = dr.Item("NO_HP")
'            GunaTextBox2.Text = dr.Item("EMAIL")
'            GunaTextBox3.Text = dr.Item("PASSWORD")
'            Label2.Text = dr.Item("PHOTO")
'            pic3.ImageLocation = Label2.Text
'        End If
'    End Sub

'    Private Sub GunaButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub nama2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub nama2_TextChanged2(ByVal sender As Object, ByVal e As System.EventArgs)
'        nama2.Text = nama1.Text
'    End Sub

'    Private Sub GunaLinkLabel1_LinkClicked_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
'        Form4.ShowDialog()
'    End Sub

'    Private Sub baru_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        OpenFileDialog1.ShowDialog()

'        Label1.Text = OpenFileDialog1.FileName
'        pic3.ImageLocation = Label1.Text
'        pic2.ImageLocation = Label1.Text
'        Try
'            Call koneksi()
'            cmd = New SqlCommand("UPDATE TBL_LOGIN SET PHOTO = '" & Label1.Text & "' WHERE NIS = '" & GunaLabel4.Text & "'", conn)
'            cmd.ExecuteNonQuery()
'            MsgBox("Photo Profile kamu berhasil diganti.", MsgBoxStyle.Information)

'        Catch
'            MsgBox("Foto ini tidak bisa digunakan, Alias rusak.!!!", MsgBoxStyle.Exclamation)
'        End Try
'    End Sub

'    'Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
'    '    If dgv.RowCount >= 0 Then
'    '        Dim baris As Integer = 0
'    '        With dgv
'    '            baris = .CurrentRow.Index
'    '            batal.Visible = True
'    '        End With
'    '    End If
'    'End Sub

'    Private Sub GunaButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Form6.Show()
'    End Sub

'    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        On Error Resume Next
'        Dim hapus = dgv.CurrentCell.RowIndex
'        dgv.Rows.RemoveAt(hapus)
'    End Sub



'    Private Sub nama2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub nama2_TextChanged3(ByVal sender As Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaLabel12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaPictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton7.Click
'        GunaLinePanel7.Visible = True
'        pulsa.Visible = True
'        pulsa1.Visible = True
'    End Sub

'    Private Sub GunaCirclePictureBox1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaCirclePictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        GunaGradientPanel1.Visible = True
'        GunaGroupBox2.Visible = True
'        'utama.Visible = False
'        'panelpulsa.Visible = False
'        profil.Visible = False
'        pulsa.Visible = False
'        pulsa1.Visible = False
'        panelminuman.Visible = False
'        minuman.Visible = False
'        keranjang.Visible = False
'        keranjang1.Visible = False
'    End Sub

'    Private Sub GunaButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        GunaGradientPanel1.Visible = False
'        GunaGroupBox2.Visible = False
'        'utama.Visible = False
'        'panelpulsa.Visible = False
'        profil.Visible = False
'        pulsa1.Visible = False

'        pulsa.Visible = True
'        pulsa1.Visible = True
'        panelminuman.Visible = False
'        minuman.Visible = False
'        keranjang.Visible = False
'        keranjang1.Visible = False
'    End Sub

'    Private Sub GunaButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        For baris As Integer = 0 To dgv.RowCount - 1
'            If dgv.Rows(baris).Cells(1).Value = xl.Text Then
'                dgv.Rows(baris).Cells(3).Value = Val(dgv.Rows(baris).Cells(3).Value) + Val(GunaLabel4.Text)
'                dgv.Rows(baris).Cells(4).Value = Val(dgv.Rows(baris).Cells(3).Value) * Val(dgv.Rows(baris).Cells(2).Value)
'                MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'                Call hitung()
'                Exit Sub
'            End If
'        Next
'        dgv.Rows.Add(New String() {"5", xl.Text, GunaComboBox1.Text, GunaLabel4.Text, Val(GunaLabel4.Text) * Val(GunaComboBox1.Text)})
'        Call hitung()
'        MsgBox("Produk Berhasil ditambahkan", MsgBoxStyle.Information)
'    End Sub

'    Private Sub GunaCirclePictureBox1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaCirclePictureBox5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Form5.Show()
'    End Sub

'    Private Sub baru_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub nama2_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub nama2_TextChanged4(ByVal sender As Object, ByVal e As System.EventArgs)
'        nama2.Text = nama1.Text
'    End Sub

'    Private Sub GunaLabel12_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaLinkLabel1_LinkClicked_3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked

'    End Sub

'    Private Sub GunaCirclePictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    End Sub

'    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
'        GunaGradientPanel1.Visible = False
'        GunaGroupBox2.Visible = False
'        profil.Visible = True
'        pulsa.Visible = False
'        pulsa1.Visible = False
'        panelminuman.Visible = False
'        minuman.Visible = False
'        keranjang.Visible = False
'        keranjang1.Visible = False
'    End Sub
'End Class