<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BankTransferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranferBCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranferBRIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranferMandiriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferBNIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatalkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bca2 = New Guna.UI.WinForms.GunaLabel()
        Me.bca1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BankTransferToolStripMenuItem, Me.BatalkanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(293, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BankTransferToolStripMenuItem
        '
        Me.BankTransferToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TranferBCAToolStripMenuItem, Me.TranferBRIToolStripMenuItem, Me.TranferMandiriToolStripMenuItem, Me.TransferBNIToolStripMenuItem})
        Me.BankTransferToolStripMenuItem.Image = CType(resources.GetObject("BankTransferToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BankTransferToolStripMenuItem.Name = "BankTransferToolStripMenuItem"
        Me.BankTransferToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.BankTransferToolStripMenuItem.Text = "Bank Transfer"
        '
        'TranferBCAToolStripMenuItem
        '
        Me.TranferBCAToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.TranferBCAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TranferBCAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TranferBCAToolStripMenuItem.Image = CType(resources.GetObject("TranferBCAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TranferBCAToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TranferBCAToolStripMenuItem.Name = "TranferBCAToolStripMenuItem"
        Me.TranferBCAToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.TranferBCAToolStripMenuItem.Text = "Transfer BCA"
        '
        'TranferBRIToolStripMenuItem
        '
        Me.TranferBRIToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.TranferBRIToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TranferBRIToolStripMenuItem.Image = CType(resources.GetObject("TranferBRIToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TranferBRIToolStripMenuItem.Name = "TranferBRIToolStripMenuItem"
        Me.TranferBRIToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.TranferBRIToolStripMenuItem.Text = "Transfer BRI"
        '
        'TranferMandiriToolStripMenuItem
        '
        Me.TranferMandiriToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.TranferMandiriToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TranferMandiriToolStripMenuItem.Image = CType(resources.GetObject("TranferMandiriToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TranferMandiriToolStripMenuItem.Name = "TranferMandiriToolStripMenuItem"
        Me.TranferMandiriToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.TranferMandiriToolStripMenuItem.Text = "Transfer Mandiri"
        '
        'TransferBNIToolStripMenuItem
        '
        Me.TransferBNIToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.TransferBNIToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TransferBNIToolStripMenuItem.Image = CType(resources.GetObject("TransferBNIToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransferBNIToolStripMenuItem.Name = "TransferBNIToolStripMenuItem"
        Me.TransferBNIToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.TransferBNIToolStripMenuItem.Text = "Transfer BNI"
        '
        'BatalkanToolStripMenuItem
        '
        Me.BatalkanToolStripMenuItem.Image = CType(resources.GetObject("BatalkanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BatalkanToolStripMenuItem.Name = "BatalkanToolStripMenuItem"
        Me.BatalkanToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.BatalkanToolStripMenuItem.Text = "Batalkan"
        '
        'bca2
        '
        Me.bca2.AutoSize = True
        Me.bca2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bca2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.bca2.Location = New System.Drawing.Point(3, 32)
        Me.bca2.Name = "bca2"
        Me.bca2.Size = New System.Drawing.Size(246, 19)
        Me.bca2.TabIndex = 1
        Me.bca2.Text = "Cara Pembayaraan melalui Tranfer BCA"
        Me.bca2.Visible = False
        '
        'bca1
        '
        Me.bca1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bca1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bca1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bca1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bca1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bca1.Location = New System.Drawing.Point(8, 63)
        Me.bca1.Name = "bca1"
        Me.bca1.Size = New System.Drawing.Size(276, 180)
        Me.bca1.TabIndex = 2
        Me.bca1.Text = resources.GetString("bca1.Text")
        Me.bca1.Visible = False
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackColor = System.Drawing.Color.Linen
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.bca1)
        Me.GunaGradientPanel1.Controls.Add(Me.bca2)
        Me.GunaGradientPanel1.Controls.Add(Me.MenuStrip1)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(11, 11)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(293, 252)
        Me.GunaGradientPanel1.TabIndex = 0
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.Snow
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaButton1.Location = New System.Drawing.Point(102, 269)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.LimeGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(190, 26)
        Me.GunaButton1.TabIndex = 1
        Me.GunaButton1.Text = "Selesaikan Pesanan"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(316, 300)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BankTransferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TranferBCAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TranferBRIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TranferMandiriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferBNIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BatalkanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bca2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents bca1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
