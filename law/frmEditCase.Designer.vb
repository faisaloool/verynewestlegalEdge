<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCase))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtLawyerID = New System.Windows.Forms.TextBox()
        Me.comboCaseType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.comboStatement = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRemainingCost = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPaidCost = New System.Windows.Forms.TextBox()
        Me.btnDownloadDoc = New System.Windows.Forms.Button()
        Me.btnuploadDoc = New System.Windows.Forms.Button()
        Me.btnAddSession = New System.Windows.Forms.Button()
        Me.txtDecision = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtSelectedFilePath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(462, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Edit Case" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Case Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Statement:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(494, 252)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Lawyer ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 210)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Starting Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(29, 252)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ending Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(29, 291)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Decision:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(29, 396)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Case Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(494, 210)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Title"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(173, 75)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(523, 74)
        Me.txtDescription.TabIndex = 16
        Me.txtDescription.Text = "meow"
        '
        'txtStartDate
        '
        Me.txtStartDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStartDate.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartDate.ForeColor = System.Drawing.Color.White
        Me.txtStartDate.Location = New System.Drawing.Point(170, 210)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(295, 17)
        Me.txtStartDate.TabIndex = 18
        Me.txtStartDate.Text = "18/1/2000"
        '
        'txtEndDate
        '
        Me.txtEndDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEndDate.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndDate.ForeColor = System.Drawing.Color.White
        Me.txtEndDate.Location = New System.Drawing.Point(170, 251)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(295, 17)
        Me.txtEndDate.TabIndex = 19
        Me.txtEndDate.Text = "18/2/2000"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(647, 210)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(295, 17)
        Me.txtTitle.TabIndex = 21
        Me.txtTitle.Text = "murder"
        '
        'txtLawyerID
        '
        Me.txtLawyerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtLawyerID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLawyerID.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLawyerID.ForeColor = System.Drawing.Color.White
        Me.txtLawyerID.Location = New System.Drawing.Point(647, 251)
        Me.txtLawyerID.Name = "txtLawyerID"
        Me.txtLawyerID.Size = New System.Drawing.Size(295, 17)
        Me.txtLawyerID.TabIndex = 22
        Me.txtLawyerID.Text = "1"
        '
        'comboCaseType
        '
        Me.comboCaseType.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.comboCaseType.ForeColor = System.Drawing.Color.Black
        Me.comboCaseType.FormattingEnabled = True
        Me.comboCaseType.Items.AddRange(New Object() {"Environmental"})
        Me.comboCaseType.Location = New System.Drawing.Point(170, 393)
        Me.comboCaseType.Name = "comboCaseType"
        Me.comboCaseType.Size = New System.Drawing.Size(316, 24)
        Me.comboCaseType.TabIndex = 23
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(341, 446)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(339, 51)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 32)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "LegalEdge " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Associates"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(538, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 16)
        Me.Label11.TabIndex = 25
        '
        'comboStatement
        '
        Me.comboStatement.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.comboStatement.ForeColor = System.Drawing.Color.Black
        Me.comboStatement.FormattingEnabled = True
        Me.comboStatement.Items.AddRange(New Object() {"Environmental"})
        Me.comboStatement.Location = New System.Drawing.Point(170, 166)
        Me.comboStatement.Name = "comboStatement"
        Me.comboStatement.Size = New System.Drawing.Size(295, 24)
        Me.comboStatement.TabIndex = 29
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(647, 169)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(295, 17)
        Me.txtEmail.TabIndex = 31
        Me.txtEmail.Text = "albabafaisal81@gmail.com"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(494, 171)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Email:"
        '
        'txtRemainingCost
        '
        Me.txtRemainingCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRemainingCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemainingCost.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemainingCost.ForeColor = System.Drawing.Color.White
        Me.txtRemainingCost.Location = New System.Drawing.Point(841, 75)
        Me.txtRemainingCost.Name = "txtRemainingCost"
        Me.txtRemainingCost.Size = New System.Drawing.Size(101, 17)
        Me.txtRemainingCost.TabIndex = 33
        Me.txtRemainingCost.Text = "1000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(706, 75)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Remaining Cost:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(706, 109)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Paid Cost:"
        '
        'txtPaidCost
        '
        Me.txtPaidCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPaidCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaidCost.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidCost.ForeColor = System.Drawing.Color.White
        Me.txtPaidCost.Location = New System.Drawing.Point(841, 109)
        Me.txtPaidCost.Name = "txtPaidCost"
        Me.txtPaidCost.Size = New System.Drawing.Size(101, 17)
        Me.txtPaidCost.TabIndex = 35
        Me.txtPaidCost.Text = "100"
        '
        'btnDownloadDoc
        '
        Me.btnDownloadDoc.BackColor = System.Drawing.Color.Black
        Me.btnDownloadDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDownloadDoc.Location = New System.Drawing.Point(834, 513)
        Me.btnDownloadDoc.Name = "btnDownloadDoc"
        Me.btnDownloadDoc.Size = New System.Drawing.Size(108, 51)
        Me.btnDownloadDoc.TabIndex = 36
        Me.btnDownloadDoc.Text = "Download Docs"
        Me.btnDownloadDoc.UseVisualStyleBackColor = False
        '
        'btnuploadDoc
        '
        Me.btnuploadDoc.BackColor = System.Drawing.Color.Black
        Me.btnuploadDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnuploadDoc.Location = New System.Drawing.Point(834, 449)
        Me.btnuploadDoc.Name = "btnuploadDoc"
        Me.btnuploadDoc.Size = New System.Drawing.Size(108, 51)
        Me.btnuploadDoc.TabIndex = 37
        Me.btnuploadDoc.Text = "Upload Docs"
        Me.btnuploadDoc.UseVisualStyleBackColor = False
        '
        'btnAddSession
        '
        Me.btnAddSession.BackColor = System.Drawing.Color.Black
        Me.btnAddSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddSession.Location = New System.Drawing.Point(834, 385)
        Me.btnAddSession.Name = "btnAddSession"
        Me.btnAddSession.Size = New System.Drawing.Size(108, 51)
        Me.btnAddSession.TabIndex = 38
        Me.btnAddSession.Text = "add session"
        Me.btnAddSession.UseVisualStyleBackColor = False
        '
        'txtDecision
        '
        Me.txtDecision.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDecision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDecision.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecision.ForeColor = System.Drawing.Color.White
        Me.txtDecision.Location = New System.Drawing.Point(170, 291)
        Me.txtDecision.Multiline = True
        Me.txtDecision.Name = "txtDecision"
        Me.txtDecision.Size = New System.Drawing.Size(772, 74)
        Me.txtDecision.TabIndex = 39
        Me.txtDecision.Text = "meow judge"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(341, 513)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(339, 51)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(124, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(58, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'txtSelectedFilePath
        '
        Me.txtSelectedFilePath.Location = New System.Drawing.Point(12, 527)
        Me.txtSelectedFilePath.Name = "txtSelectedFilePath"
        Me.txtSelectedFilePath.Size = New System.Drawing.Size(320, 24)
        Me.txtSelectedFilePath.TabIndex = 41
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtClientID
        '
        Me.txtClientID.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtClientID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClientID.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientID.ForeColor = System.Drawing.Color.White
        Me.txtClientID.Location = New System.Drawing.Point(598, 397)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(82, 17)
        Me.txtClientID.TabIndex = 43
        Me.txtClientID.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(504, 397)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Client ID"
        '
        'frmEditCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(985, 578)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSelectedFilePath)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtDecision)
        Me.Controls.Add(Me.btnAddSession)
        Me.Controls.Add(Me.btnuploadDoc)
        Me.Controls.Add(Me.btnDownloadDoc)
        Me.Controls.Add(Me.txtPaidCost)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtRemainingCost)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.comboStatement)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.comboCaseType)
        Me.Controls.Add(Me.txtLawyerID)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEditCase"
        Me.Text = "edit case"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtLawyerID As TextBox
    Friend WithEvents comboCaseType As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents comboStatement As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRemainingCost As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPaidCost As TextBox
    Friend WithEvents btnDownloadDoc As Button
    Friend WithEvents btnuploadDoc As Button
    Friend WithEvents btnAddSession As Button
    Friend WithEvents txtDecision As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents txtSelectedFilePath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents Label15 As Label
End Class
