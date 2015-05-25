<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ToolTip1 As System.Windows.Forms.ToolTip
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cakeQty = New System.Windows.Forms.NumericUpDown()
        Me.cupcakeQty = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.smallFlour = New System.Windows.Forms.Label()
        Me.smallSugar = New System.Windows.Forms.Label()
        Me.smallButter = New System.Windows.Forms.Label()
        Me.mediumFlour = New System.Windows.Forms.Label()
        Me.mediumButter = New System.Windows.Forms.Label()
        Me.mediumSugar = New System.Windows.Forms.Label()
        Me.largeSugar = New System.Windows.Forms.Label()
        Me.largeFlour = New System.Windows.Forms.Label()
        Me.largeButter = New System.Windows.Forms.Label()
        Me.flourQty = New System.Windows.Forms.Label()
        Me.sugarQty = New System.Windows.Forms.Label()
        Me.butterQty = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.eggQty = New System.Windows.Forms.Label()
        Me.largeEggs = New System.Windows.Forms.Label()
        Me.mediumEggs = New System.Windows.Forms.Label()
        Me.smallEggs = New System.Windows.Forms.Label()
        ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.cakeQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cupcakeQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        ToolTip1.IsBalloon = True
        '
        'cakeQty
        '
        Me.cakeQty.Cursor = System.Windows.Forms.Cursors.Cross
        Me.cakeQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cakeQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.cakeQty.Location = New System.Drawing.Point(228, 252)
        Me.cakeQty.Name = "cakeQty"
        Me.cakeQty.Size = New System.Drawing.Size(120, 22)
        Me.cakeQty.TabIndex = 0
        ToolTip1.SetToolTip(Me.cakeQty, "Please Enter Or Select The Amount Of Cakes You Would Like")
        '
        'cupcakeQty
        '
        Me.cupcakeQty.Cursor = System.Windows.Forms.Cursors.Cross
        Me.cupcakeQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupcakeQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.cupcakeQty.Location = New System.Drawing.Point(228, 214)
        Me.cupcakeQty.Name = "cupcakeQty"
        Me.cupcakeQty.Size = New System.Drawing.Size(120, 22)
        Me.cupcakeQty.TabIndex = 1
        ToolTip1.SetToolTip(Me.cupcakeQty, "Please Enter Or Select The Amount Of CupCakes You Would Like")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(367, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Calculate"
        ToolTip1.SetToolTip(Me.Button1, "Press (Or key [ENTER]) To Activate The Program")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(12, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Reset"
        ToolTip1.SetToolTip(Me.Button2, "Press (Or Key [ESC]) To Reset The Program")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'smallFlour
        '
        Me.smallFlour.AutoSize = True
        Me.smallFlour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallFlour.ForeColor = System.Drawing.Color.Fuchsia
        Me.smallFlour.Location = New System.Drawing.Point(156, 509)
        Me.smallFlour.Name = "smallFlour"
        Me.smallFlour.Size = New System.Drawing.Size(17, 17)
        Me.smallFlour.TabIndex = 2
        Me.smallFlour.Text = "0"
        '
        'smallSugar
        '
        Me.smallSugar.AutoSize = True
        Me.smallSugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallSugar.ForeColor = System.Drawing.Color.Fuchsia
        Me.smallSugar.Location = New System.Drawing.Point(156, 603)
        Me.smallSugar.Name = "smallSugar"
        Me.smallSugar.Size = New System.Drawing.Size(17, 17)
        Me.smallSugar.TabIndex = 3
        Me.smallSugar.Text = "0"
        '
        'smallButter
        '
        Me.smallButter.AutoSize = True
        Me.smallButter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallButter.ForeColor = System.Drawing.Color.Fuchsia
        Me.smallButter.Location = New System.Drawing.Point(156, 568)
        Me.smallButter.Name = "smallButter"
        Me.smallButter.Size = New System.Drawing.Size(17, 17)
        Me.smallButter.TabIndex = 4
        Me.smallButter.Text = "0"
        '
        'mediumFlour
        '
        Me.mediumFlour.AutoSize = True
        Me.mediumFlour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumFlour.ForeColor = System.Drawing.Color.Fuchsia
        Me.mediumFlour.Location = New System.Drawing.Point(238, 509)
        Me.mediumFlour.Name = "mediumFlour"
        Me.mediumFlour.Size = New System.Drawing.Size(17, 17)
        Me.mediumFlour.TabIndex = 5
        Me.mediumFlour.Text = "0"
        '
        'mediumButter
        '
        Me.mediumButter.AutoSize = True
        Me.mediumButter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumButter.ForeColor = System.Drawing.Color.Fuchsia
        Me.mediumButter.Location = New System.Drawing.Point(238, 568)
        Me.mediumButter.Name = "mediumButter"
        Me.mediumButter.Size = New System.Drawing.Size(17, 17)
        Me.mediumButter.TabIndex = 6
        Me.mediumButter.Text = "0"
        '
        'mediumSugar
        '
        Me.mediumSugar.AutoSize = True
        Me.mediumSugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumSugar.ForeColor = System.Drawing.Color.Fuchsia
        Me.mediumSugar.Location = New System.Drawing.Point(238, 603)
        Me.mediumSugar.Name = "mediumSugar"
        Me.mediumSugar.Size = New System.Drawing.Size(17, 17)
        Me.mediumSugar.TabIndex = 7
        Me.mediumSugar.Text = "0"
        '
        'largeSugar
        '
        Me.largeSugar.AutoSize = True
        Me.largeSugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeSugar.ForeColor = System.Drawing.Color.Fuchsia
        Me.largeSugar.Location = New System.Drawing.Point(321, 603)
        Me.largeSugar.Name = "largeSugar"
        Me.largeSugar.Size = New System.Drawing.Size(17, 17)
        Me.largeSugar.TabIndex = 8
        Me.largeSugar.Text = "0"
        '
        'largeFlour
        '
        Me.largeFlour.AutoSize = True
        Me.largeFlour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeFlour.ForeColor = System.Drawing.Color.Fuchsia
        Me.largeFlour.Location = New System.Drawing.Point(321, 509)
        Me.largeFlour.Name = "largeFlour"
        Me.largeFlour.Size = New System.Drawing.Size(17, 17)
        Me.largeFlour.TabIndex = 9
        Me.largeFlour.Text = "0"
        '
        'largeButter
        '
        Me.largeButter.AutoSize = True
        Me.largeButter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeButter.ForeColor = System.Drawing.Color.Fuchsia
        Me.largeButter.Location = New System.Drawing.Point(321, 568)
        Me.largeButter.Name = "largeButter"
        Me.largeButter.Size = New System.Drawing.Size(17, 17)
        Me.largeButter.TabIndex = 10
        Me.largeButter.Text = "0"
        '
        'flourQty
        '
        Me.flourQty.AutoSize = True
        Me.flourQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flourQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.flourQty.Location = New System.Drawing.Point(208, 332)
        Me.flourQty.Name = "flourQty"
        Me.flourQty.Size = New System.Drawing.Size(17, 17)
        Me.flourQty.TabIndex = 13
        Me.flourQty.Text = "0"
        '
        'sugarQty
        '
        Me.sugarQty.AutoSize = True
        Me.sugarQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sugarQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.sugarQty.Location = New System.Drawing.Point(208, 428)
        Me.sugarQty.Name = "sugarQty"
        Me.sugarQty.Size = New System.Drawing.Size(17, 17)
        Me.sugarQty.TabIndex = 14
        Me.sugarQty.Text = "0"
        '
        'butterQty
        '
        Me.butterQty.AutoSize = True
        Me.butterQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butterQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.butterQty.Location = New System.Drawing.Point(208, 395)
        Me.butterQty.Name = "butterQty"
        Me.butterQty.Size = New System.Drawing.Size(17, 17)
        Me.butterQty.TabIndex = 15
        Me.butterQty.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(217, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Medium"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(306, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Large"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(141, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Small"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Bettys.My.Resources.Resources.jhlogo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(352, 605)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 36)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'eggQty
        '
        Me.eggQty.AutoSize = True
        Me.eggQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eggQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.eggQty.Location = New System.Drawing.Point(208, 362)
        Me.eggQty.Name = "eggQty"
        Me.eggQty.Size = New System.Drawing.Size(17, 17)
        Me.eggQty.TabIndex = 23
        Me.eggQty.Text = "0"
        '
        'largeEggs
        '
        Me.largeEggs.AutoSize = True
        Me.largeEggs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeEggs.ForeColor = System.Drawing.Color.Fuchsia
        Me.largeEggs.Location = New System.Drawing.Point(321, 536)
        Me.largeEggs.Name = "largeEggs"
        Me.largeEggs.Size = New System.Drawing.Size(17, 17)
        Me.largeEggs.TabIndex = 26
        Me.largeEggs.Text = "0"
        '
        'mediumEggs
        '
        Me.mediumEggs.AutoSize = True
        Me.mediumEggs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumEggs.ForeColor = System.Drawing.Color.Fuchsia
        Me.mediumEggs.Location = New System.Drawing.Point(238, 536)
        Me.mediumEggs.Name = "mediumEggs"
        Me.mediumEggs.Size = New System.Drawing.Size(17, 17)
        Me.mediumEggs.TabIndex = 25
        Me.mediumEggs.Text = "0"
        '
        'smallEggs
        '
        Me.smallEggs.AutoSize = True
        Me.smallEggs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallEggs.ForeColor = System.Drawing.Color.Fuchsia
        Me.smallEggs.Location = New System.Drawing.Point(156, 536)
        Me.smallEggs.Name = "smallEggs"
        Me.smallEggs.Size = New System.Drawing.Size(17, 17)
        Me.smallEggs.TabIndex = 24
        Me.smallEggs.Text = "0"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(461, 653)
        Me.Controls.Add(Me.largeEggs)
        Me.Controls.Add(Me.mediumEggs)
        Me.Controls.Add(Me.smallEggs)
        Me.Controls.Add(Me.eggQty)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.butterQty)
        Me.Controls.Add(Me.sugarQty)
        Me.Controls.Add(Me.flourQty)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.largeButter)
        Me.Controls.Add(Me.largeFlour)
        Me.Controls.Add(Me.largeSugar)
        Me.Controls.Add(Me.mediumSugar)
        Me.Controls.Add(Me.mediumButter)
        Me.Controls.Add(Me.mediumFlour)
        Me.Controls.Add(Me.smallButter)
        Me.Controls.Add(Me.smallSugar)
        Me.Controls.Add(Me.smallFlour)
        Me.Controls.Add(Me.cupcakeQty)
        Me.Controls.Add(Me.cakeQty)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bettys Best Ever Bakery - v1 Test"
        Me.TopMost = True
        CType(Me.cakeQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cupcakeQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cakeQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents cupcakeQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents smallFlour As System.Windows.Forms.Label
    Friend WithEvents smallSugar As System.Windows.Forms.Label
    Friend WithEvents smallButter As System.Windows.Forms.Label
    Friend WithEvents mediumFlour As System.Windows.Forms.Label
    Friend WithEvents mediumButter As System.Windows.Forms.Label
    Friend WithEvents mediumSugar As System.Windows.Forms.Label
    Friend WithEvents largeSugar As System.Windows.Forms.Label
    Friend WithEvents largeFlour As System.Windows.Forms.Label
    Friend WithEvents largeButter As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents flourQty As System.Windows.Forms.Label
    Friend WithEvents sugarQty As System.Windows.Forms.Label
    Friend WithEvents butterQty As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents eggQty As System.Windows.Forms.Label
    Friend WithEvents largeEggs As System.Windows.Forms.Label
    Friend WithEvents mediumEggs As System.Windows.Forms.Label
    Friend WithEvents smallEggs As System.Windows.Forms.Label

End Class
