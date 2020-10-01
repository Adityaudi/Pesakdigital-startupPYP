<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.txt1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.pic3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.nama1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton7 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.profil = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.baru = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.nama2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.pic2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLinePanel1.SuspendLayout()
        Me.GunaLinePanel2.SuspendLayout()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.profil.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.LimeGreen
        Me.GunaLinePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLinePanel1.Controls.Add(Me.txt1)
        Me.GunaLinePanel1.Controls.Add(Me.txt3)
        Me.GunaLinePanel1.Controls.Add(Me.GunaImageButton1)
        Me.GunaLinePanel1.LineBottom = 5
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 1)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(927, 79)
        Me.GunaLinePanel1.TabIndex = 0
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt1.Font = New System.Drawing.Font("Comic Sans MS", 22.0!, System.Drawing.FontStyle.Bold)
        Me.txt1.Location = New System.Drawing.Point(58, 10)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(321, 45)
        Me.txt1.TabIndex = 9
        Me.txt1.Text = "Kantin Duniaku"
        Me.txt1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt3.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txt3.Location = New System.Drawing.Point(379, 27)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(303, 27)
        Me.txt3.TabIndex = 8
        Me.txt3.Text = "SMK Negeri 1 Rangkasbitung"
        Me.txt3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = CType(resources.GetObject("GunaImageButton1.Image"), System.Drawing.Image)
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(60, 60)
        Me.GunaImageButton1.Location = New System.Drawing.Point(869, 3)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(49, 41)
        Me.GunaImageButton1.TabIndex = 5
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.LimeGreen
        Me.GunaLinePanel2.Controls.Add(Me.pic3)
        Me.GunaLinePanel2.Controls.Add(Me.nama1)
        Me.GunaLinePanel2.Controls.Add(Me.GunaButton4)
        Me.GunaLinePanel2.Controls.Add(Me.GunaButton7)
        Me.GunaLinePanel2.Controls.Add(Me.GunaButton3)
        Me.GunaLinePanel2.Controls.Add(Me.GunaButton2)
        Me.GunaLinePanel2.Controls.Add(Me.GunaButton1)
        Me.GunaLinePanel2.LineBottom = 2
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineLeft = 2
        Me.GunaLinePanel2.LineRight = 2
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(10, 82)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(242, 514)
        Me.GunaLinePanel2.TabIndex = 1
        '
        'pic3
        '
        Me.pic3.BackColor = System.Drawing.Color.Snow
        Me.pic3.BaseColor = System.Drawing.Color.White
        Me.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic3.ErrorImage = Nothing
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(39, 18)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(161, 107)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 7
        Me.pic3.TabStop = False
        '
        'nama1
        '
        Me.nama1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nama1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama1.Location = New System.Drawing.Point(7, 140)
        Me.nama1.Name = "nama1"
        Me.nama1.Size = New System.Drawing.Size(228, 35)
        Me.nama1.TabIndex = 3
        Me.nama1.Text = "Aditya Udi Anggoro"
        Me.nama1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BaseColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.White
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = CType(resources.GetObject("GunaButton4.Image"), System.Drawing.Image)
        Me.GunaButton4.ImageOffsetX = 2
        Me.GunaButton4.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton4.Location = New System.Drawing.Point(19, 443)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(202, 51)
        Me.GunaButton4.TabIndex = 2
        Me.GunaButton4.Text = "Keranjang"
        '
        'GunaButton7
        '
        Me.GunaButton7.AnimationHoverSpeed = 0.07!
        Me.GunaButton7.AnimationSpeed = 0.03!
        Me.GunaButton7.BaseColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton7.FocusedColor = System.Drawing.Color.White
        Me.GunaButton7.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton7.ForeColor = System.Drawing.Color.White
        Me.GunaButton7.Image = CType(resources.GetObject("GunaButton7.Image"), System.Drawing.Image)
        Me.GunaButton7.ImageOffsetX = 2
        Me.GunaButton7.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton7.Location = New System.Drawing.Point(19, 359)
        Me.GunaButton7.Name = "GunaButton7"
        Me.GunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverImage = Nothing
        Me.GunaButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton7.Size = New System.Drawing.Size(202, 43)
        Me.GunaButton7.TabIndex = 2
        Me.GunaButton7.Text = "Pulsa All Operator"
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.White
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = CType(resources.GetObject("GunaButton3.Image"), System.Drawing.Image)
        Me.GunaButton3.ImageOffsetX = 2
        Me.GunaButton3.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton3.Location = New System.Drawing.Point(19, 302)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(202, 44)
        Me.GunaButton3.TabIndex = 2
        Me.GunaButton3.Text = "Menu Minuman"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.White
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageOffsetX = 2
        Me.GunaButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton2.Location = New System.Drawing.Point(19, 246)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(202, 43)
        Me.GunaButton2.TabIndex = 2
        Me.GunaButton2.Text = "Menu Makanan"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.White
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageOffsetX = 2
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(19, 189)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(202, 42)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "Profile "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'profil
        '
        Me.profil.BackColor = System.Drawing.Color.Black
        Me.profil.BaseColor = System.Drawing.Color.BlanchedAlmond
        Me.profil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profil.Controls.Add(Me.GunaPanel3)
        Me.profil.Location = New System.Drawing.Point(280, 100)
        Me.profil.Name = "profil"
        Me.profil.Size = New System.Drawing.Size(472, 462)
        Me.profil.TabIndex = 23
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.LimeGreen
        Me.GunaPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPanel3.Controls.Add(Me.GunaButton6)
        Me.GunaPanel3.Controls.Add(Me.Label2)
        Me.GunaPanel3.Controls.Add(Me.Label1)
        Me.GunaPanel3.Controls.Add(Me.baru)
        Me.GunaPanel3.Controls.Add(Me.GunaGroupBox1)
        Me.GunaPanel3.Controls.Add(Me.nama2)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel13)
        Me.GunaPanel3.Controls.Add(Me.pic2)
        Me.GunaPanel3.Location = New System.Drawing.Point(9, 7)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(454, 444)
        Me.GunaPanel3.TabIndex = 2
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BaseColor = System.Drawing.Color.LimeGreen
        Me.GunaButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton6.ForeColor = System.Drawing.Color.White
        Me.GunaButton6.Image = CType(resources.GetObject("GunaButton6.Image"), System.Drawing.Image)
        Me.GunaButton6.ImageOffsetX = -8
        Me.GunaButton6.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton6.Location = New System.Drawing.Point(326, 24)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.Size = New System.Drawing.Size(117, 27)
        Me.GunaButton6.TabIndex = 7
        Me.GunaButton6.Text = "My Wallet"
        Me.GunaButton6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(264, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(-4, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'baru
        '
        Me.baru.Animated = True
        Me.baru.AnimationHoverSpeed = 0.07!
        Me.baru.AnimationSpeed = 0.03!
        Me.baru.BaseColor1 = System.Drawing.Color.Snow
        Me.baru.BaseColor2 = System.Drawing.Color.Snow
        Me.baru.BorderColor = System.Drawing.Color.Black
        Me.baru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.baru.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.baru.FocusedColor = System.Drawing.Color.Empty
        Me.baru.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.baru.ForeColor = System.Drawing.Color.White
        Me.baru.Image = CType(resources.GetObject("baru.Image"), System.Drawing.Image)
        Me.baru.ImageSize = New System.Drawing.Size(20, 20)
        Me.baru.Location = New System.Drawing.Point(279, 120)
        Me.baru.Name = "baru"
        Me.baru.OnHoverBaseColor1 = System.Drawing.Color.LimeGreen
        Me.baru.OnHoverBaseColor2 = System.Drawing.Color.LimeGreen
        Me.baru.OnHoverBorderColor = System.Drawing.Color.Black
        Me.baru.OnHoverForeColor = System.Drawing.Color.White
        Me.baru.OnHoverImage = Nothing
        Me.baru.OnPressedColor = System.Drawing.Color.Black
        Me.baru.Size = New System.Drawing.Size(39, 36)
        Me.baru.TabIndex = 4
        Me.baru.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaLinkLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel10)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel11)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel12)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Sitka Small", 11.0!)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(23, 214)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(400, 209)
        Me.GunaGroupBox1.TabIndex = 3
        Me.GunaGroupBox1.Text = "My Profile"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(339, 166)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(40, 17)
        Me.GunaLinkLabel1.TabIndex = 15
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Ubah"
        '
        'GunaTextBox3
        '
        Me.GunaTextBox3.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox3.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox3.Cursor = System.Windows.Forms.Cursors.No
        Me.GunaTextBox3.Enabled = False
        Me.GunaTextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox3.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox3.Location = New System.Drawing.Point(143, 154)
        Me.GunaTextBox3.MaxLength = 100
        Me.GunaTextBox3.Name = "GunaTextBox3"
        Me.GunaTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.GunaTextBox3.Size = New System.Drawing.Size(193, 31)
        Me.GunaTextBox3.TabIndex = 12
        Me.GunaTextBox3.Text = "328shduiskhsf"
        Me.GunaTextBox3.UseSystemPasswordChar = True
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.Location = New System.Drawing.Point(143, 117)
        Me.GunaTextBox2.MaxLength = 100
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Size = New System.Drawing.Size(236, 31)
        Me.GunaTextBox2.TabIndex = 13
        Me.GunaTextBox2.Text = "adityaudi@gmail.com"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.Location = New System.Drawing.Point(143, 80)
        Me.GunaTextBox1.MaxLength = 100
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(236, 31)
        Me.GunaTextBox1.TabIndex = 14
        Me.GunaTextBox1.Text = "0812338658332"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(11, 158)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(115, 25)
        Me.GunaLabel8.TabIndex = 11
        Me.GunaLabel8.Text = "Password"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(11, 117)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(115, 25)
        Me.GunaLabel7.TabIndex = 8
        Me.GunaLabel7.Text = "Email"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(11, 80)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(115, 25)
        Me.GunaLabel10.TabIndex = 9
        Me.GunaLabel10.Text = "No Telpon"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0!)
        Me.GunaLabel11.Location = New System.Drawing.Point(11, 42)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(115, 25)
        Me.GunaLabel11.TabIndex = 10
        Me.GunaLabel11.Text = "NIS"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.GunaLabel12.Location = New System.Drawing.Point(143, 41)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(236, 26)
        Me.GunaLabel12.TabIndex = 7
        Me.GunaLabel12.Text = "17181932943"
        '
        'nama2
        '
        Me.nama2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nama2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nama2.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.nama2.Location = New System.Drawing.Point(91, 165)
        Me.nama2.Name = "nama2"
        Me.nama2.Size = New System.Drawing.Size(266, 26)
        Me.nama2.TabIndex = 2
        Me.nama2.Text = "Aditya Udi Anggoro"
        Me.nama2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaLabel13
        '
        Me.GunaLabel13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.GunaLabel13.Location = New System.Drawing.Point(8, 165)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(74, 25)
        Me.GunaLabel13.TabIndex = 2
        Me.GunaLabel13.Text = "Hallo, "
        '
        'pic2
        '
        Me.pic2.BackColor = System.Drawing.Color.Snow
        Me.pic2.BaseColor = System.Drawing.Color.White
        Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic2.ErrorImage = CType(resources.GetObject("pic2.ErrorImage"), System.Drawing.Image)
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(128, 14)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(190, 142)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 0
        Me.pic2.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(923, 596)
        Me.Controls.Add(Me.profil)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel2.ResumeLayout(False)
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.profil.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents txt3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents nama1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pic3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents profil As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents baru As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaTextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents nama2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pic2 As Guna.UI.WinForms.GunaPictureBox

    Private Sub GunaButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton6.Click
        Form5.Show()
    End Sub
End Class
