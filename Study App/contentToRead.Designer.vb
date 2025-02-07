<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class contentToRead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.minBtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.closeBtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.openBtn = New Guna.UI.WinForms.GunaButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaPanel3.Controls.Add(Me.minBtn)
        Me.GunaPanel3.Controls.Add(Me.closeBtn)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(991, 31)
        Me.GunaPanel3.TabIndex = 11
        '
        'minBtn
        '
        Me.minBtn.BaseColor = System.Drawing.Color.White
        Me.minBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minBtn.Image = Global.Study_App.My.Resources.Resources.minimize
        Me.minBtn.Location = New System.Drawing.Point(940, 5)
        Me.minBtn.Name = "minBtn"
        Me.minBtn.Size = New System.Drawing.Size(20, 20)
        Me.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minBtn.TabIndex = 13
        Me.minBtn.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BaseColor = System.Drawing.Color.White
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.Image = Global.Study_App.My.Resources.Resources.remove
        Me.closeBtn.Location = New System.Drawing.Point(966, 5)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(20, 20)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 12
        Me.closeBtn.TabStop = False
        '
        'openBtn
        '
        Me.openBtn.AnimationHoverSpeed = 0.07!
        Me.openBtn.AnimationSpeed = 0.03!
        Me.openBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.openBtn.BorderColor = System.Drawing.Color.Black
        Me.openBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.openBtn.FocusedColor = System.Drawing.Color.Empty
        Me.openBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openBtn.ForeColor = System.Drawing.Color.White
        Me.openBtn.Image = Global.Study_App.My.Resources.Resources.open_folder__1_
        Me.openBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.openBtn.Location = New System.Drawing.Point(822, 636)
        Me.openBtn.Name = "openBtn"
        Me.openBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.openBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.openBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.openBtn.OnHoverImage = Nothing
        Me.openBtn.OnPressedColor = System.Drawing.Color.Black
        Me.openBtn.Size = New System.Drawing.Size(160, 42)
        Me.openBtn.TabIndex = 13
        Me.openBtn.Text = "Open pdf file"
        Me.openBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(9, 37)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(973, 579)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(973, 579)
        Me.WebBrowser1.TabIndex = 14
        Me.WebBrowser1.Url = New System.Uri("file:///C:/mar/Crop%20prediction%20report.pdf", System.UriKind.Absolute)
        '
        'contentToRead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 695)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.openBtn)
        Me.Controls.Add(Me.GunaPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "contentToRead"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "contentToRead"
        Me.GunaPanel3.ResumeLayout(False)
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents minBtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents closeBtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents openBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
