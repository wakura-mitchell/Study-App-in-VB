<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class levelSelect
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.selectPanel = New Guna.UI.WinForms.GunaPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.minBtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.closeBtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.selectPanel.SuspendLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'selectPanel
        '
        Me.selectPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.selectPanel.Controls.Add(Me.GunaPictureBox3)
        Me.selectPanel.Controls.Add(Me.GunaPictureBox2)
        Me.selectPanel.Controls.Add(Me.Label4)
        Me.selectPanel.Controls.Add(Me.GunaPictureBox1)
        Me.selectPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.selectPanel.Location = New System.Drawing.Point(12, 37)
        Me.selectPanel.Name = "selectPanel"
        Me.selectPanel.Size = New System.Drawing.Size(423, 321)
        Me.selectPanel.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(129, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Select Level"
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaPictureBox3.Image = Global.Study_App.My.Resources.Resources.letter_o__1_
        Me.GunaPictureBox3.Location = New System.Drawing.Point(285, 139)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox3.TabIndex = 7
        Me.GunaPictureBox3.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaPictureBox2.Image = Global.Study_App.My.Resources.Resources.letter_a
        Me.GunaPictureBox2.Location = New System.Drawing.Point(17, 139)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 6
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Study_App.My.Resources.Resources._select
        Me.GunaPictureBox1.Location = New System.Drawing.Point(185, 14)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(69, 52)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'minBtn
        '
        Me.minBtn.BaseColor = System.Drawing.Color.White
        Me.minBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minBtn.Image = Global.Study_App.My.Resources.Resources.minimize
        Me.minBtn.Location = New System.Drawing.Point(389, 8)
        Me.minBtn.Name = "minBtn"
        Me.minBtn.Size = New System.Drawing.Size(20, 20)
        Me.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minBtn.TabIndex = 8
        Me.minBtn.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BaseColor = System.Drawing.Color.White
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.Image = Global.Study_App.My.Resources.Resources.remove
        Me.closeBtn.Location = New System.Drawing.Point(415, 8)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(20, 20)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 7
        Me.closeBtn.TabStop = False
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 5
        Me.GunaElipse2.TargetControl = Me.selectPanel
        '
        'levelSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(447, 370)
        Me.Controls.Add(Me.selectPanel)
        Me.Controls.Add(Me.minBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "levelSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "levelSelect"
        Me.selectPanel.ResumeLayout(False)
        Me.selectPanel.PerformLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents minBtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents closeBtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents selectPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
End Class
