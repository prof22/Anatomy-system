<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiagnosisSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiagnosisSystem))
        Me.CmbHeadache = New System.Windows.Forms.ComboBox()
        Me.CmbSoreThroat = New System.Windows.Forms.ComboBox()
        Me.CmbLossAppetite = New System.Windows.Forms.ComboBox()
        Me.CmbJoinPain = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbAbdominalP = New System.Windows.Forms.ComboBox()
        Me.CmbNausea = New System.Windows.Forms.ComboBox()
        Me.CmbVomiting = New System.Windows.Forms.ComboBox()
        Me.CmbDizzy = New System.Windows.Forms.ComboBox()
        Me.CmbBodyWeak = New System.Windows.Forms.ComboBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtEnterPID = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbTemperature = New System.Windows.Forms.ComboBox()
        Me.LblCure = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbHeadache
        '
        Me.CmbHeadache.BackColor = System.Drawing.Color.White
        Me.CmbHeadache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHeadache.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbHeadache.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHeadache.FormattingEnabled = True
        Me.CmbHeadache.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbHeadache.Location = New System.Drawing.Point(155, 83)
        Me.CmbHeadache.Name = "CmbHeadache"
        Me.CmbHeadache.Size = New System.Drawing.Size(158, 27)
        Me.CmbHeadache.TabIndex = 1
        '
        'CmbSoreThroat
        '
        Me.CmbSoreThroat.BackColor = System.Drawing.Color.White
        Me.CmbSoreThroat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSoreThroat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbSoreThroat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSoreThroat.FormattingEnabled = True
        Me.CmbSoreThroat.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbSoreThroat.Location = New System.Drawing.Point(155, 129)
        Me.CmbSoreThroat.Name = "CmbSoreThroat"
        Me.CmbSoreThroat.Size = New System.Drawing.Size(158, 27)
        Me.CmbSoreThroat.TabIndex = 2
        '
        'CmbLossAppetite
        '
        Me.CmbLossAppetite.BackColor = System.Drawing.Color.White
        Me.CmbLossAppetite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLossAppetite.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbLossAppetite.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLossAppetite.FormattingEnabled = True
        Me.CmbLossAppetite.Items.AddRange(New Object() {"Yes ", "No"})
        Me.CmbLossAppetite.Location = New System.Drawing.Point(155, 169)
        Me.CmbLossAppetite.Name = "CmbLossAppetite"
        Me.CmbLossAppetite.Size = New System.Drawing.Size(158, 27)
        Me.CmbLossAppetite.TabIndex = 3
        '
        'CmbJoinPain
        '
        Me.CmbJoinPain.BackColor = System.Drawing.Color.White
        Me.CmbJoinPain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJoinPain.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbJoinPain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbJoinPain.FormattingEnabled = True
        Me.CmbJoinPain.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbJoinPain.Location = New System.Drawing.Point(155, 214)
        Me.CmbJoinPain.Name = "CmbJoinPain"
        Me.CmbJoinPain.Size = New System.Drawing.Size(158, 27)
        Me.CmbJoinPain.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Headache"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sore throat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Loss Of Appetite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Joint Pain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Abdominal Pain"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nausea"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Vomiting"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Dizziness"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(21, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Body Weakness"
        '
        'CmbAbdominalP
        '
        Me.CmbAbdominalP.BackColor = System.Drawing.Color.White
        Me.CmbAbdominalP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAbdominalP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbAbdominalP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAbdominalP.FormattingEnabled = True
        Me.CmbAbdominalP.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbAbdominalP.Location = New System.Drawing.Point(155, 439)
        Me.CmbAbdominalP.Name = "CmbAbdominalP"
        Me.CmbAbdominalP.Size = New System.Drawing.Size(158, 27)
        Me.CmbAbdominalP.TabIndex = 14
        '
        'CmbNausea
        '
        Me.CmbNausea.BackColor = System.Drawing.Color.White
        Me.CmbNausea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNausea.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbNausea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbNausea.FormattingEnabled = True
        Me.CmbNausea.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbNausea.Location = New System.Drawing.Point(155, 394)
        Me.CmbNausea.Name = "CmbNausea"
        Me.CmbNausea.Size = New System.Drawing.Size(158, 27)
        Me.CmbNausea.TabIndex = 13
        '
        'CmbVomiting
        '
        Me.CmbVomiting.BackColor = System.Drawing.Color.White
        Me.CmbVomiting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVomiting.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbVomiting.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbVomiting.FormattingEnabled = True
        Me.CmbVomiting.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbVomiting.Location = New System.Drawing.Point(155, 354)
        Me.CmbVomiting.Name = "CmbVomiting"
        Me.CmbVomiting.Size = New System.Drawing.Size(158, 27)
        Me.CmbVomiting.TabIndex = 12
        '
        'CmbDizzy
        '
        Me.CmbDizzy.BackColor = System.Drawing.Color.White
        Me.CmbDizzy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDizzy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbDizzy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDizzy.FormattingEnabled = True
        Me.CmbDizzy.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbDizzy.Location = New System.Drawing.Point(155, 308)
        Me.CmbDizzy.Name = "CmbDizzy"
        Me.CmbDizzy.Size = New System.Drawing.Size(158, 27)
        Me.CmbDizzy.TabIndex = 11
        '
        'CmbBodyWeak
        '
        Me.CmbBodyWeak.BackColor = System.Drawing.Color.White
        Me.CmbBodyWeak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBodyWeak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbBodyWeak.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBodyWeak.FormattingEnabled = True
        Me.CmbBodyWeak.Items.AddRange(New Object() {"Yes", "No"})
        Me.CmbBodyWeak.Location = New System.Drawing.Point(155, 256)
        Me.CmbBodyWeak.Name = "CmbBodyWeak"
        Me.CmbBodyWeak.Size = New System.Drawing.Size(158, 27)
        Me.CmbBodyWeak.TabIndex = 10
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.DarkRed
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(989, 105)
        Me.Splitter1.TabIndex = 20
        Me.Splitter1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(49, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 19)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Age"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TxtEnterPID)
        Me.GroupBox1.Controls.Add(Me.LblName)
        Me.GroupBox1.Location = New System.Drawing.Point(528, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 133)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.White
        Me.TxtAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(22, 98)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(100, 26)
        Me.TxtAge.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(180, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 19)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Patient Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(31, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 19)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Enter PID"
        '
        'TxtEnterPID
        '
        Me.TxtEnterPID.BackColor = System.Drawing.Color.White
        Me.TxtEnterPID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnterPID.Location = New System.Drawing.Point(22, 44)
        Me.TxtEnterPID.Name = "TxtEnterPID"
        Me.TxtEnterPID.Size = New System.Drawing.Size(100, 26)
        Me.TxtEnterPID.TabIndex = 0
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.Black
        Me.LblName.Location = New System.Drawing.Point(174, 45)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(0, 19)
        Me.LblName.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Temperature"
        '
        'CmbTemperature
        '
        Me.CmbTemperature.BackColor = System.Drawing.Color.White
        Me.CmbTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTemperature.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTemperature.FormattingEnabled = True
        Me.CmbTemperature.Items.AddRange(New Object() {"High", "Normal", "Low"})
        Me.CmbTemperature.Location = New System.Drawing.Point(155, 39)
        Me.CmbTemperature.Name = "CmbTemperature"
        Me.CmbTemperature.Size = New System.Drawing.Size(158, 27)
        Me.CmbTemperature.TabIndex = 28
        '
        'LblCure
        '
        Me.LblCure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCure.ForeColor = System.Drawing.Color.Black
        Me.LblCure.Location = New System.Drawing.Point(487, 401)
        Me.LblCure.Name = "LblCure"
        Me.LblCure.Size = New System.Drawing.Size(476, 186)
        Me.LblCure.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(578, 352)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(334, 44)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Please Follow The Prescription Of Drugs " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instruction Given Below Carefully......" & _
            "....."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkRed
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(334, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(492, 65)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Diagnosis System"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CmbTemperature)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.CmbAbdominalP)
        Me.GroupBox3.Controls.Add(Me.CmbNausea)
        Me.GroupBox3.Controls.Add(Me.CmbVomiting)
        Me.GroupBox3.Controls.Add(Me.CmbDizzy)
        Me.GroupBox3.Controls.Add(Me.CmbBodyWeak)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.CmbJoinPain)
        Me.GroupBox3.Controls.Add(Me.CmbLossAppetite)
        Me.GroupBox3.Controls.Add(Me.CmbSoreThroat)
        Me.GroupBox3.Controls.Add(Me.CmbHeadache)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox3.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 484)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Please Select Yes/No For The Symptoms You Feel"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(658, 653)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(272, 26)
        Me.DateTimePicker1.TabIndex = 40
        '
        'LblCategory
        '
        Me.LblCategory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.ForeColor = System.Drawing.Color.Black
        Me.LblCategory.Location = New System.Drawing.Point(615, 312)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(234, 28)
        Me.LblCategory.TabIndex = 41
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.PDS.My.Resources.Resources.videos_4_background
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 701)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 29)
        Me.ToolStrip1.TabIndex = 42
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(106, 26)
        Me.ToolStripButton1.Text = "&Diagnose"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(69, 26)
        Me.ToolStripButton2.Text = "&Save"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(73, 26)
        Me.ToolStripButton3.Text = "&Back"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(76, 26)
        Me.ToolStripButton4.Text = "&Close"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.PDS.My.Resources.Resources.img3
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(209, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'FrmDiagnosisSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(989, 730)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LblCure)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDiagnosisSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbHeadache As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSoreThroat As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLossAppetite As System.Windows.Forms.ComboBox
    Friend WithEvents CmbJoinPain As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CmbAbdominalP As System.Windows.Forms.ComboBox
    Friend WithEvents CmbNausea As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVomiting As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDizzy As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBodyWeak As System.Windows.Forms.ComboBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbTemperature As System.Windows.Forms.ComboBox
    Friend WithEvents LblCure As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents TxtEnterPID As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
End Class
