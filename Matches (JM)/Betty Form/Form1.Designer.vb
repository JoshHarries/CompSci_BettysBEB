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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.matchQty = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.matchTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.largeMatchQty = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.largeMatchAmount = New System.Windows.Forms.Label()
        Me.mediumMatchAmount = New System.Windows.Forms.Label()
        Me.mediumMatchQty = New System.Windows.Forms.Label()
        Me.smallMatchAmount = New System.Windows.Forms.Label()
        Me.smallMatchQty = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.matchQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'matchQty
        '
        Me.matchQty.BackColor = System.Drawing.SystemColors.ControlLight
        Me.matchQty.Location = New System.Drawing.Point(185, 42)
        Me.matchQty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.matchQty.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.matchQty.Name = "matchQty"
        Me.matchQty.Size = New System.Drawing.Size(58, 20)
        Me.matchQty.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.MinimumSize = New System.Drawing.Size(400, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 2)
        Me.Label3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Matches"
        '
        'matchTotal
        '
        Me.matchTotal.AutoSize = True
        Me.matchTotal.BackColor = System.Drawing.Color.White
        Me.matchTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.matchTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matchTotal.Location = New System.Drawing.Point(127, 119)
        Me.matchTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.matchTotal.MinimumSize = New System.Drawing.Size(81, 2)
        Me.matchTotal.Name = "matchTotal"
        Me.matchTotal.Size = New System.Drawing.Size(81, 19)
        Me.matchTotal.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 162)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.MinimumSize = New System.Drawing.Size(400, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(400, 2)
        Me.Label12.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(249, 110)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(169, 33)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Match Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(325, 27)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 33)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Order"
        '
        'largeMatchQty
        '
        Me.largeMatchQty.AutoSize = True
        Me.largeMatchQty.BackColor = System.Drawing.Color.Khaki
        Me.largeMatchQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.largeMatchQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeMatchQty.Location = New System.Drawing.Point(55, 253)
        Me.largeMatchQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.largeMatchQty.MinimumSize = New System.Drawing.Size(41, 2)
        Me.largeMatchQty.Name = "largeMatchQty"
        Me.largeMatchQty.Size = New System.Drawing.Size(41, 19)
        Me.largeMatchQty.TabIndex = 27
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(4, 253)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 18)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Boxes"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(83, 231)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 17)
        Me.Label34.TabIndex = 39
        Me.Label34.Text = "Large"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(204, 231)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(57, 17)
        Me.Label35.TabIndex = 40
        Me.Label35.Text = "Medium"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(336, 231)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(42, 17)
        Me.Label36.TabIndex = 41
        Me.Label36.Text = "Small"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.DimGray
        Me.Label37.Location = New System.Drawing.Point(95, 187)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(261, 33)
        Me.Label37.TabIndex = 42
        Me.Label37.Text = "Packaging Options"
        '
        'calculateButton
        '
        Me.calculateButton.BackColor = System.Drawing.Color.LightGray
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(127, 293)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(80, 38)
        Me.calculateButton.TabIndex = 43
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'largeMatchAmount
        '
        Me.largeMatchAmount.AutoSize = True
        Me.largeMatchAmount.BackColor = System.Drawing.Color.White
        Me.largeMatchAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.largeMatchAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeMatchAmount.Location = New System.Drawing.Point(99, 253)
        Me.largeMatchAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.largeMatchAmount.MinimumSize = New System.Drawing.Size(54, 2)
        Me.largeMatchAmount.Name = "largeMatchAmount"
        Me.largeMatchAmount.Size = New System.Drawing.Size(54, 19)
        Me.largeMatchAmount.TabIndex = 45
        '
        'mediumMatchAmount
        '
        Me.mediumMatchAmount.AutoSize = True
        Me.mediumMatchAmount.BackColor = System.Drawing.Color.White
        Me.mediumMatchAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mediumMatchAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumMatchAmount.Location = New System.Drawing.Point(227, 253)
        Me.mediumMatchAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mediumMatchAmount.MinimumSize = New System.Drawing.Size(54, 2)
        Me.mediumMatchAmount.Name = "mediumMatchAmount"
        Me.mediumMatchAmount.Size = New System.Drawing.Size(54, 19)
        Me.mediumMatchAmount.TabIndex = 53
        '
        'mediumMatchQty
        '
        Me.mediumMatchQty.AutoSize = True
        Me.mediumMatchQty.BackColor = System.Drawing.Color.Khaki
        Me.mediumMatchQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mediumMatchQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumMatchQty.Location = New System.Drawing.Point(183, 253)
        Me.mediumMatchQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mediumMatchQty.MinimumSize = New System.Drawing.Size(41, 2)
        Me.mediumMatchQty.Name = "mediumMatchQty"
        Me.mediumMatchQty.Size = New System.Drawing.Size(41, 19)
        Me.mediumMatchQty.TabIndex = 52
        '
        'smallMatchAmount
        '
        Me.smallMatchAmount.AutoSize = True
        Me.smallMatchAmount.BackColor = System.Drawing.Color.White
        Me.smallMatchAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.smallMatchAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallMatchAmount.Location = New System.Drawing.Point(353, 253)
        Me.smallMatchAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.smallMatchAmount.MinimumSize = New System.Drawing.Size(54, 2)
        Me.smallMatchAmount.Name = "smallMatchAmount"
        Me.smallMatchAmount.Size = New System.Drawing.Size(54, 19)
        Me.smallMatchAmount.TabIndex = 61
        '
        'smallMatchQty
        '
        Me.smallMatchQty.AutoSize = True
        Me.smallMatchQty.BackColor = System.Drawing.Color.Khaki
        Me.smallMatchQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.smallMatchQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallMatchQty.Location = New System.Drawing.Point(309, 253)
        Me.smallMatchQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.smallMatchQty.MinimumSize = New System.Drawing.Size(41, 2)
        Me.smallMatchQty.Name = "smallMatchQty"
        Me.smallMatchQty.Size = New System.Drawing.Size(41, 19)
        Me.smallMatchQty.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(85, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 22)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Matches bundles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(229, 293)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 38)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click here to reset form.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 355)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.smallMatchAmount)
        Me.Controls.Add(Me.smallMatchQty)
        Me.Controls.Add(Me.mediumMatchAmount)
        Me.Controls.Add(Me.mediumMatchQty)
        Me.Controls.Add(Me.largeMatchAmount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.largeMatchQty)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.matchTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.matchQty)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "The Match Factory"
        CType(Me.matchQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents matchQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents matchTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents largeMatchQty As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mediumMatchAmount As System.Windows.Forms.Label
    Friend WithEvents mediumMatchQty As System.Windows.Forms.Label
    Friend WithEvents smallMatchAmount As System.Windows.Forms.Label
    Friend WithEvents smallMatchQty As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents largeMatchAmount As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
