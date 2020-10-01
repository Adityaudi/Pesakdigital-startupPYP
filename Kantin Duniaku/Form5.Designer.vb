<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Violet
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GunaGroupBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.LimeGreen
        Me.GunaGroupBox1.Location = New System.Drawing.Point(4, 5)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(294, 110)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "My Saldo Account"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        Me.GunaGroupBox1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.Snow
        Me.GunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(8, 70)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(89, 23)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Poin Duniaku"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.Snow
        Me.GunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(120, 70)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(153, 23)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "56000 poin"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.Snow
        Me.GunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(120, 40)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(153, 23)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "Rp.200.000"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.Snow
        Me.GunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(8, 40)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(89, 23)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Tabungan"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(294, 110)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 11)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(293, 23)
        Me.RectangleShape1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(303, 121)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 3
        Me.LineShape1.X2 = 622
        Me.LineShape1.Y1 = 67
        Me.LineShape1.Y2 = 83
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(303, 121)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
