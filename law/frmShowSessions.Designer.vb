<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowSessions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowSessions))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCaseID = New System.Windows.Forms.TextBox()
        Me.txtEmailStatus = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtSessionID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(103, 402)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 46)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(366, 119)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(296, 206)
        Me.DataGridView1.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(259, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 21)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Show sessions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 34)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "LeglEdge " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Associates"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(94, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'txtCaseID
        '
        Me.txtCaseID.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCaseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseID.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseID.Location = New System.Drawing.Point(146, 165)
        Me.txtCaseID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCaseID.Name = "txtCaseID"
        Me.txtCaseID.Size = New System.Drawing.Size(185, 24)
        Me.txtCaseID.TabIndex = 59
        Me.txtCaseID.Text = "case id"
        Me.txtCaseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmailStatus
        '
        Me.txtEmailStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtEmailStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailStatus.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailStatus.Location = New System.Drawing.Point(146, 292)
        Me.txtEmailStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailStatus.Name = "txtEmailStatus"
        Me.txtEmailStatus.Size = New System.Drawing.Size(185, 24)
        Me.txtEmailStatus.TabIndex = 58
        Me.txtEmailStatus.Text = "email status"
        Me.txtEmailStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(146, 250)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(185, 24)
        Me.txtTime.TabIndex = 57
        Me.txtTime.Text = "Time"
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(146, 209)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(185, 24)
        Me.txtDate.TabIndex = 56
        Me.txtDate.Text = "Date"
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSessionID
        '
        Me.txtSessionID.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSessionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSessionID.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSessionID.Location = New System.Drawing.Point(146, 120)
        Me.txtSessionID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSessionID.Name = "txtSessionID"
        Me.txtSessionID.Size = New System.Drawing.Size(185, 24)
        Me.txtSessionID.TabIndex = 55
        Me.txtSessionID.Text = "ID"
        Me.txtSessionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Session ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Case ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(22, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(22, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Email Status "
        '
        'frmShowSessions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(694, 483)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCaseID)
        Me.Controls.Add(Me.txtEmailStatus)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtSessionID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmShowSessions"
        Me.Text = "Show Sessions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCaseID As TextBox
    Friend WithEvents txtEmailStatus As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtSessionID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
