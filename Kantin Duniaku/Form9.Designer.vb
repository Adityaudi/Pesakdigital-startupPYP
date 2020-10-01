<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.utama = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Snow
        Me.GunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPanel2.Location = New System.Drawing.Point(804, 51)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(0, 0)
        Me.GunaPanel2.TabIndex = 1
        '
        'utama
        '
        Me.utama.AnimationHoverSpeed = 0.07!
        Me.utama.AnimationSpeed = 0.03!
        Me.utama.BaseColor = System.Drawing.Color.LimeGreen
        Me.utama.BorderColor = System.Drawing.Color.Black
        Me.utama.BorderSize = 1
        Me.utama.CheckedBaseColor = System.Drawing.Color.Gray
        Me.utama.CheckedBorderColor = System.Drawing.Color.Black
        Me.utama.CheckedForeColor = System.Drawing.Color.White
        Me.utama.CheckedImage = CType(resources.GetObject("utama.CheckedImage"), System.Drawing.Image)
        Me.utama.CheckedLineColor = System.Drawing.Color.DimGray
        Me.utama.DialogResult = System.Windows.Forms.DialogResult.None
        Me.utama.FocusedColor = System.Drawing.Color.Empty
        Me.utama.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.utama.ForeColor = System.Drawing.Color.White
        Me.utama.Image = CType(resources.GetObject("utama.Image"), System.Drawing.Image)
        Me.utama.ImageSize = New System.Drawing.Size(60, 60)
        Me.utama.LineColor = System.Drawing.Color.Black
        Me.utama.Location = New System.Drawing.Point(297, -15)
        Me.utama.Name = "utama"
        Me.utama.OnHoverBaseColor = System.Drawing.Color.MediumSeaGreen
        Me.utama.OnHoverBorderColor = System.Drawing.Color.Black
        Me.utama.OnHoverForeColor = System.Drawing.Color.White
        Me.utama.OnHoverImage = Nothing
        Me.utama.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.utama.OnPressedColor = System.Drawing.Color.Black
        Me.utama.Size = New System.Drawing.Size(652, 496)
        Me.utama.TabIndex = 21
        Me.utama.Text = "Welcome to Kantin Duniaku"
        Me.utama.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 467)
        Me.Controls.Add(Me.utama)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents utama As Guna.UI.WinForms.GunaAdvenceButton
End Class
