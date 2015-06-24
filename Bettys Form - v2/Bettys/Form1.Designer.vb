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
        Me.eggQty = New System.Windows.Forms.Label()
        Me.largeEggs = New System.Windows.Forms.Label()
        Me.mediumEggs = New System.Windows.Forms.Label()
        Me.smallEggs = New System.Windows.Forms.Label()
        Me.printCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.cakeQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cupcakeQty, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cakeQty.Location = New System.Drawing.Point(115, 189)
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
        Me.cupcakeQty.Location = New System.Drawing.Point(115, 144)
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
        Me.Button1.Location = New System.Drawing.Point(256, 606)
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
        Me.Button2.Location = New System.Drawing.Point(13, 606)
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
        Me.smallFlour.Location = New System.Drawing.Point(133, 463)
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
        Me.smallSugar.Location = New System.Drawing.Point(133, 564)
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
        Me.smallButter.Location = New System.Drawing.Point(133, 530)
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
        Me.mediumFlour.Location = New System.Drawing.Point(193, 463)
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
        Me.mediumButter.Location = New System.Drawing.Point(193, 530)
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
        Me.mediumSugar.Location = New System.Drawing.Point(193, 564)
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
        Me.largeSugar.Location = New System.Drawing.Point(256, 564)
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
        Me.largeFlour.Location = New System.Drawing.Point(256, 463)
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
        Me.largeButter.Location = New System.Drawing.Point(256, 530)
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
        Me.flourQty.Location = New System.Drawing.Point(173, 264)
        Me.flourQty.Name = "flourQty"
        Me.flourQty.Size = New System.Drawing.Size(31, 17)
        Me.flourQty.TabIndex = 13
        Me.flourQty.Text = "0g."
        '
        'sugarQty
        '
        Me.sugarQty.AutoSize = True
        Me.sugarQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sugarQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.sugarQty.Location = New System.Drawing.Point(174, 332)
        Me.sugarQty.Name = "sugarQty"
        Me.sugarQty.Size = New System.Drawing.Size(31, 17)
        Me.sugarQty.TabIndex = 14
        Me.sugarQty.Text = "0g."
        '
        'butterQty
        '
        Me.butterQty.AutoSize = True
        Me.butterQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butterQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.butterQty.Location = New System.Drawing.Point(173, 298)
        Me.butterQty.Name = "butterQty"
        Me.butterQty.Size = New System.Drawing.Size(31, 17)
        Me.butterQty.TabIndex = 15
        Me.butterQty.Text = "0g."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(172, 444)
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
        Me.Label5.Location = New System.Drawing.Point(241, 444)
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
        Me.Label6.Location = New System.Drawing.Point(118, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Small"
        '
        'eggQty
        '
        Me.eggQty.AutoSize = True
        Me.eggQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eggQty.ForeColor = System.Drawing.Color.Fuchsia
        Me.eggQty.Location = New System.Drawing.Point(173, 366)
        Me.eggQty.Name = "eggQty"
        Me.eggQty.Size = New System.Drawing.Size(63, 17)
        Me.eggQty.TabIndex = 23
        Me.eggQty.Text = "0 Eggs."
        '
        'largeEggs
        '
        Me.largeEggs.AutoSize = True
        Me.largeEggs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeEggs.ForeColor = System.Drawing.Color.Fuchsia
        Me.largeEggs.Location = New System.Drawing.Point(256, 496)
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
        Me.mediumEggs.Location = New System.Drawing.Point(193, 496)
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
        Me.smallEggs.Location = New System.Drawing.Point(133, 496)
        Me.smallEggs.Name = "smallEggs"
        Me.smallEggs.Size = New System.Drawing.Size(17, 17)
        Me.smallEggs.TabIndex = 24
        Me.smallEggs.Text = "0"
        '
        'printCheck
        '
        Me.printCheck.AutoSize = True
        Me.printCheck.Checked = True
        Me.printCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.printCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printCheck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.printCheck.Location = New System.Drawing.Point(101, 617)
        Me.printCheck.Name = "printCheck"
        Me.printCheck.Size = New System.Drawing.Size(149, 17)
        Me.printCheck.TabIndex = 27
        Me.printCheck.Text = "Print Order Details To File."
        Me.printCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.printCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Flour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(60, 496)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Sugar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(60, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Butter"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(60, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Eggs"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Magenta
        Me.Label8.Location = New System.Drawing.Point(95, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 31)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Packaging:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(116, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Eggs"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(116, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Butter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(116, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Sugar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(116, 264)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Flour"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Magenta
        Me.Label13.Location = New System.Drawing.Point(91, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(169, 31)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Ingredients:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(149, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 17)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Cakes"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(133, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 17)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Cupcakes"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Magenta
        Me.Label16.Location = New System.Drawing.Point(56, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(239, 62)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Please Enter The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount Of:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(7, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(337, 31)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Betty's Best Ever Bakery"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(351, 653)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.printCheck)
        Me.Controls.Add(Me.largeEggs)
        Me.Controls.Add(Me.mediumEggs)
        Me.Controls.Add(Me.smallEggs)
        Me.Controls.Add(Me.eggQty)
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
        Me.Text = "Bettys Best Ever Bakery - V2"
        Me.TopMost = True
        CType(Me.cakeQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cupcakeQty, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents eggQty As System.Windows.Forms.Label
    Friend WithEvents largeEggs As System.Windows.Forms.Label
    Friend WithEvents mediumEggs As System.Windows.Forms.Label
    Friend WithEvents smallEggs As System.Windows.Forms.Label
    Friend WithEvents printCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
