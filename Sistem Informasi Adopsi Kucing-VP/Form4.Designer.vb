<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAdopsi = New System.Windows.Forms.Button()
        Me.btnRegis = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.CausesValidation = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(52, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(825, 566)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Itim", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(44, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Kucing"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_18
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(864, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 44)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_17
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(927, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_122
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(890, 263)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(80, 80)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.UseVisualStyleBackColor = True
        Me.btnLogout.Visible = False
        '
        'btnAdopsi
        '
        Me.btnAdopsi.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_142
        Me.btnAdopsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdopsi.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdopsi.FlatAppearance.BorderSize = 0
        Me.btnAdopsi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnAdopsi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdopsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdopsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdopsi.Location = New System.Drawing.Point(890, 577)
        Me.btnAdopsi.Name = "btnAdopsi"
        Me.btnAdopsi.Size = New System.Drawing.Size(80, 80)
        Me.btnAdopsi.TabIndex = 4
        Me.btnAdopsi.UseVisualStyleBackColor = True
        '
        'btnRegis
        '
        Me.btnRegis.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_132
        Me.btnRegis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegis.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegis.FlatAppearance.BorderSize = 0
        Me.btnRegis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnRegis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegis.Location = New System.Drawing.Point(890, 177)
        Me.btnRegis.Name = "btnRegis"
        Me.btnRegis.Size = New System.Drawing.Size(80, 80)
        Me.btnRegis.TabIndex = 3
        Me.btnRegis.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = Global.Sistem_Informasi_Adopsi_Kucing.My.Resources.Resources.Group_112
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Itim", 10.0!)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Location = New System.Drawing.Point(890, 91)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(80, 80)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(995, 701)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAdopsi)
        Me.Controls.Add(Me.btnRegis)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegis As Button
    Friend WithEvents btnAdopsi As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
