<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.createLink = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.p3 = New Guna.UI.WinForms.GunaPanel()
        Me.BunifuMaterialTextbox6 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaCheckBox2 = New Guna.UI.WinForms.GunaCheckBox()
        Me.BunifuMaterialTextbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.animation = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.goBack = New Guna.UI.WinForms.GunaPictureBox()
        Me.createBtn = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox5 = New Guna.UI.WinForms.GunaPictureBox()
        Me.minBtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.closeBtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.loginBtn = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.p3.SuspendLayout()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.Label4)
        Me.p1.Controls.Add(Me.GunaPictureBox1)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Controls.Add(Me.Label2)
        Me.p1.Controls.Add(Me.Label1)
        Me.animation.SetDecoration(Me.p1, Guna.UI.Animation.DecorationType.None)
        Me.p1.Location = New System.Drawing.Point(42, 26)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(326, 461)
        Me.p1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.animation.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(92, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Study App"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.animation.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(135, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Number and Centre Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.animation.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(135, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marshal Wakurawarebgwa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.animation.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(71, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Created by"
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p2.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.p2.Controls.Add(Me.createLink)
        Me.p2.Controls.Add(Me.GunaCheckBox1)
        Me.p2.Controls.Add(Me.loginBtn)
        Me.p2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.p2.Controls.Add(Me.GunaPictureBox2)
        Me.animation.SetDecoration(Me.p2, Guna.UI.Animation.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(372, 26)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(326, 461)
        Me.p2.TabIndex = 1
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animation.SetDecoration(Me.BunifuMaterialTextbox2, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox2.HintText = "Password"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(17, 231)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(283, 44)
        Me.BunifuMaterialTextbox2.TabIndex = 10
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'createLink
        '
        Me.createLink.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.createLink.AutoSize = True
        Me.animation.SetDecoration(Me.createLink, Guna.UI.Animation.DecorationType.None)
        Me.createLink.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.createLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.createLink.LinkColor = System.Drawing.Color.Silver
        Me.createLink.Location = New System.Drawing.Point(117, 413)
        Me.createLink.Name = "createLink"
        Me.createLink.Size = New System.Drawing.Size(89, 15)
        Me.createLink.TabIndex = 9
        Me.createLink.TabStop = True
        Me.createLink.Text = "Create Account"
        Me.createLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.animation.SetDecoration(Me.GunaCheckBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox1.Location = New System.Drawing.Point(17, 282)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox1.TabIndex = 8
        Me.GunaCheckBox1.Text = "Show Password"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animation.SetDecoration(Me.BunifuMaterialTextbox1, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.HintText = "Username"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(17, 179)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(283, 44)
        Me.BunifuMaterialTextbox1.TabIndex = 5
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'p3
        '
        Me.p3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p3.Controls.Add(Me.goBack)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox6)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox5)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox3)
        Me.p3.Controls.Add(Me.GunaCheckBox2)
        Me.p3.Controls.Add(Me.createBtn)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox4)
        Me.p3.Controls.Add(Me.GunaPictureBox5)
        Me.animation.SetDecoration(Me.p3, Guna.UI.Animation.DecorationType.None)
        Me.p3.Location = New System.Drawing.Point(372, 26)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(326, 461)
        Me.p3.TabIndex = 11
        Me.p3.Visible = False
        '
        'BunifuMaterialTextbox6
        '
        Me.BunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animation.SetDecoration(Me.BunifuMaterialTextbox6, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox6.HintText = "Password"
        Me.BunifuMaterialTextbox6.isPassword = True
        Me.BunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox6.LineThickness = 3
        Me.BunifuMaterialTextbox6.Location = New System.Drawing.Point(17, 263)
        Me.BunifuMaterialTextbox6.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox6.Name = "BunifuMaterialTextbox6"
        Me.BunifuMaterialTextbox6.Size = New System.Drawing.Size(283, 44)
        Me.BunifuMaterialTextbox6.TabIndex = 12
        Me.BunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox5
        '
        Me.BunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animation.SetDecoration(Me.BunifuMaterialTextbox5, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.HintText = "Username"
        Me.BunifuMaterialTextbox5.isPassword = True
        Me.BunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.LineThickness = 3
        Me.BunifuMaterialTextbox5.Location = New System.Drawing.Point(17, 211)
        Me.BunifuMaterialTextbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox5.Name = "BunifuMaterialTextbox5"
        Me.BunifuMaterialTextbox5.Size = New System.Drawing.Size(283, 44)
        Me.BunifuMaterialTextbox5.TabIndex = 11
        Me.BunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox3
        '
        Me.BunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animation.SetDecoration(Me.BunifuMaterialTextbox3, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.HintText = "Surname"
        Me.BunifuMaterialTextbox3.isPassword = False
        Me.BunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.LineThickness = 3
        Me.BunifuMaterialTextbox3.Location = New System.Drawing.Point(17, 159)
        Me.BunifuMaterialTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox3.Name = "BunifuMaterialTextbox3"
        Me.BunifuMaterialTextbox3.Size = New System.Drawing.Size(283, 44)
        Me.BunifuMaterialTextbox3.TabIndex = 10
        Me.BunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaCheckBox2
        '
        Me.GunaCheckBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.animation.SetDecoration(Me.GunaCheckBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox2.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox2.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox2.Location = New System.Drawing.Point(17, 314)
        Me.GunaCheckBox2.Name = "GunaCheckBox2"
        Me.GunaCheckBox2.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox2.TabIndex = 8
        Me.GunaCheckBox2.Text = "Show Password"
        '
        'BunifuMaterialTextbox4
        '
        Me.BunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animation.SetDecoration(Me.BunifuMaterialTextbox4, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.HintText = "Name"
        Me.BunifuMaterialTextbox4.isPassword = False
        Me.BunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.LineThickness = 3
        Me.BunifuMaterialTextbox4.Location = New System.Drawing.Point(17, 107)
        Me.BunifuMaterialTextbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox4.Name = "BunifuMaterialTextbox4"
        Me.BunifuMaterialTextbox4.Size = New System.Drawing.Size(283, 44)
        Me.BunifuMaterialTextbox4.TabIndex = 5
        Me.BunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'animation
        '
        Me.animation.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.animation.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.animation.DefaultAnimation = Animation1
        '
        'goBack
        '
        Me.goBack.BaseColor = System.Drawing.Color.White
        Me.animation.SetDecoration(Me.goBack, Guna.UI.Animation.DecorationType.None)
        Me.goBack.Image = Global.Study_App.My.Resources.Resources.back_button
        Me.goBack.Location = New System.Drawing.Point(301, 6)
        Me.goBack.Name = "goBack"
        Me.goBack.Size = New System.Drawing.Size(20, 20)
        Me.goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.goBack.TabIndex = 12
        Me.goBack.TabStop = False
        '
        'createBtn
        '
        Me.createBtn.AnimationHoverSpeed = 0.07!
        Me.createBtn.AnimationSpeed = 0.03!
        Me.createBtn.BackColor = System.Drawing.Color.Transparent
        Me.createBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.createBtn.BorderColor = System.Drawing.Color.Black
        Me.animation.SetDecoration(Me.createBtn, Guna.UI.Animation.DecorationType.None)
        Me.createBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.createBtn.FocusedColor = System.Drawing.Color.Empty
        Me.createBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createBtn.ForeColor = System.Drawing.Color.White
        Me.createBtn.Image = Global.Study_App.My.Resources.Resources.add_user
        Me.createBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.createBtn.Location = New System.Drawing.Point(88, 389)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.createBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.createBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.createBtn.OnHoverImage = Nothing
        Me.createBtn.OnPressedColor = System.Drawing.Color.Black
        Me.createBtn.Radius = 3
        Me.createBtn.Size = New System.Drawing.Size(159, 42)
        Me.createBtn.TabIndex = 7
        Me.createBtn.Text = "Create"
        Me.createBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox5
        '
        Me.GunaPictureBox5.BaseColor = System.Drawing.Color.White
        Me.animation.SetDecoration(Me.GunaPictureBox5, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox5.Image = Global.Study_App.My.Resources.Resources.add_user
        Me.GunaPictureBox5.Location = New System.Drawing.Point(126, 6)
        Me.GunaPictureBox5.Name = "GunaPictureBox5"
        Me.GunaPictureBox5.Size = New System.Drawing.Size(79, 86)
        Me.GunaPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox5.TabIndex = 4
        Me.GunaPictureBox5.TabStop = False
        '
        'minBtn
        '
        Me.minBtn.BaseColor = System.Drawing.Color.White
        Me.minBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animation.SetDecoration(Me.minBtn, Guna.UI.Animation.DecorationType.None)
        Me.minBtn.Image = Global.Study_App.My.Resources.Resources.minimize
        Me.minBtn.Location = New System.Drawing.Point(691, 3)
        Me.minBtn.Name = "minBtn"
        Me.minBtn.Size = New System.Drawing.Size(20, 20)
        Me.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minBtn.TabIndex = 6
        Me.minBtn.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BaseColor = System.Drawing.Color.White
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animation.SetDecoration(Me.closeBtn, Guna.UI.Animation.DecorationType.None)
        Me.closeBtn.Image = Global.Study_App.My.Resources.Resources.remove
        Me.closeBtn.Location = New System.Drawing.Point(717, 3)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(20, 20)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 5
        Me.closeBtn.TabStop = False
        '
        'loginBtn
        '
        Me.loginBtn.AnimationHoverSpeed = 0.07!
        Me.loginBtn.AnimationSpeed = 0.03!
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginBtn.BorderColor = System.Drawing.Color.Black
        Me.animation.SetDecoration(Me.loginBtn, Guna.UI.Animation.DecorationType.None)
        Me.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginBtn.FocusedColor = System.Drawing.Color.Empty
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Image = Global.Study_App.My.Resources.Resources._next
        Me.loginBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.loginBtn.Location = New System.Drawing.Point(84, 329)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.loginBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.loginBtn.OnHoverImage = Nothing
        Me.loginBtn.OnPressedColor = System.Drawing.Color.Black
        Me.loginBtn.Radius = 3
        Me.loginBtn.Size = New System.Drawing.Size(159, 42)
        Me.loginBtn.TabIndex = 7
        Me.loginBtn.Text = "Login"
        Me.loginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.animation.SetDecoration(Me.GunaPictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox2.Image = Global.Study_App.My.Resources.Resources.user
        Me.GunaPictureBox2.Location = New System.Drawing.Point(98, 29)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(119, 120)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 4
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.animation.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox1.Image = Global.Study_App.My.Resources.Resources.education
        Me.GunaPictureBox1.Location = New System.Drawing.Point(74, 29)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(182, 192)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 3
        Me.GunaPictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 511)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.minBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p1)
        Me.animation.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.p3.ResumeLayout(False)
        Me.p3.PerformLayout()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents loginBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents createLink As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents closeBtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents minBtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents p3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents BunifuMaterialTextbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaCheckBox2 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents createBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuMaterialTextbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaPictureBox5 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BunifuMaterialTextbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents goBack As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BunifuMaterialTextbox6 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents animation As Guna.UI.WinForms.GunaTransition
End Class
