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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.picEye = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Itim", 36.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(106, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 72)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CatDopt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Itim", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(620, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 44)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sign Up"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Itim", 20.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(154, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 41)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hi! adopter"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe Fluent Icons", 16.2!)
        Me.TextBox1.Location = New System.Drawing.Point(551, 253)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 27)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe Fluent Icons", 16.2!)
        Me.TextBox2.Location = New System.Drawing.Point(551, 404)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(304, 27)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Itim", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(559, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 36)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Itim", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(559, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 36)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'picEye
        '
        Me.picEye.Image = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.eye_closed
        Me.picEye.Location = New System.Drawing.Point(810, 399)
        Me.picEye.Name = "picEye"
        Me.picEye.Size = New System.Drawing.Size(46, 40)
        Me.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEye.TabIndex = 21
        Me.picEye.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.PictureBox5.Image = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.catgif13
        Me.PictureBox5.Location = New System.Drawing.Point(22, 277)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(434, 274)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Rectangle_4
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Itim", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnRegister.Location = New System.Drawing.Point(516, 510)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(368, 65)
        Me.btnRegister.TabIndex = 17
        Me.btnRegister.Text = " Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.FlowLayoutPanel1.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_91
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(79, 156)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(310, 263)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Rectangle_111
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(451, 586)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Rectangle_2
        Me.PictureBox3.Location = New System.Drawing.Point(516, 387)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(368, 65)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Rectangle_2
        Me.PictureBox2.Location = New System.Drawing.Point(516, 236)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(368, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Button2.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_22
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(41, 557)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 44)
        Me.Button2.TabIndex = 70
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 621)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.picEye)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents picEye As PictureBox
    Friend WithEvents Button2 As Button
End Class
