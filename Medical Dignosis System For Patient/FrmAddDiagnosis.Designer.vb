<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddDiagnosis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddDiagnosis))
        Me.CmbSymp1 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp2 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp3 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp4 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp5 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp6 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp7 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp8 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp9 = New System.Windows.Forms.ComboBox()
        Me.CmbSymp10 = New System.Windows.Forms.ComboBox()
        Me.RichTextBoxCure = New System.Windows.Forms.RichTextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.TxtCategory = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbSymp1
        '
        Me.CmbSymp1.BackColor = System.Drawing.Color.White
        Me.CmbSymp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp1.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp1.FormattingEnabled = True
        Me.CmbSymp1.Items.AddRange(New Object() {"Temperature"})
        Me.CmbSymp1.Location = New System.Drawing.Point(149, 85)
        Me.CmbSymp1.Name = "CmbSymp1"
        Me.CmbSymp1.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp1.TabIndex = 1
        '
        'CmbSymp2
        '
        Me.CmbSymp2.BackColor = System.Drawing.Color.White
        Me.CmbSymp2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp2.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp2.FormattingEnabled = True
        Me.CmbSymp2.Items.AddRange(New Object() {"Headache"})
        Me.CmbSymp2.Location = New System.Drawing.Point(149, 131)
        Me.CmbSymp2.Name = "CmbSymp2"
        Me.CmbSymp2.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp2.TabIndex = 2
        '
        'CmbSymp3
        '
        Me.CmbSymp3.BackColor = System.Drawing.Color.White
        Me.CmbSymp3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp3.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp3.FormattingEnabled = True
        Me.CmbSymp3.Items.AddRange(New Object() {"Sore Throat"})
        Me.CmbSymp3.Location = New System.Drawing.Point(149, 185)
        Me.CmbSymp3.Name = "CmbSymp3"
        Me.CmbSymp3.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp3.TabIndex = 3
        '
        'CmbSymp4
        '
        Me.CmbSymp4.BackColor = System.Drawing.Color.White
        Me.CmbSymp4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp4.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp4.FormattingEnabled = True
        Me.CmbSymp4.Items.AddRange(New Object() {"Loss Of Appetite"})
        Me.CmbSymp4.Location = New System.Drawing.Point(149, 240)
        Me.CmbSymp4.Name = "CmbSymp4"
        Me.CmbSymp4.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp4.TabIndex = 4
        '
        'CmbSymp5
        '
        Me.CmbSymp5.BackColor = System.Drawing.Color.White
        Me.CmbSymp5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp5.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp5.FormattingEnabled = True
        Me.CmbSymp5.Items.AddRange(New Object() {"Joint Pain"})
        Me.CmbSymp5.Location = New System.Drawing.Point(149, 293)
        Me.CmbSymp5.Name = "CmbSymp5"
        Me.CmbSymp5.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp5.TabIndex = 5
        '
        'CmbSymp6
        '
        Me.CmbSymp6.BackColor = System.Drawing.Color.White
        Me.CmbSymp6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp6.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp6.FormattingEnabled = True
        Me.CmbSymp6.Items.AddRange(New Object() {"Body Weakness"})
        Me.CmbSymp6.Location = New System.Drawing.Point(544, 34)
        Me.CmbSymp6.Name = "CmbSymp6"
        Me.CmbSymp6.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp6.TabIndex = 6
        '
        'CmbSymp7
        '
        Me.CmbSymp7.BackColor = System.Drawing.Color.White
        Me.CmbSymp7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp7.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp7.FormattingEnabled = True
        Me.CmbSymp7.Items.AddRange(New Object() {"Dizziness"})
        Me.CmbSymp7.Location = New System.Drawing.Point(544, 96)
        Me.CmbSymp7.Name = "CmbSymp7"
        Me.CmbSymp7.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp7.TabIndex = 7
        '
        'CmbSymp8
        '
        Me.CmbSymp8.BackColor = System.Drawing.Color.White
        Me.CmbSymp8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp8.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp8.FormattingEnabled = True
        Me.CmbSymp8.Items.AddRange(New Object() {"Vomitting"})
        Me.CmbSymp8.Location = New System.Drawing.Point(544, 152)
        Me.CmbSymp8.Name = "CmbSymp8"
        Me.CmbSymp8.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp8.TabIndex = 8
        '
        'CmbSymp9
        '
        Me.CmbSymp9.BackColor = System.Drawing.Color.White
        Me.CmbSymp9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp9.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp9.FormattingEnabled = True
        Me.CmbSymp9.Items.AddRange(New Object() {"Nausea"})
        Me.CmbSymp9.Location = New System.Drawing.Point(544, 212)
        Me.CmbSymp9.Name = "CmbSymp9"
        Me.CmbSymp9.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp9.TabIndex = 9
        '
        'CmbSymp10
        '
        Me.CmbSymp10.BackColor = System.Drawing.Color.White
        Me.CmbSymp10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSymp10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSymp10.ForeColor = System.Drawing.Color.Black
        Me.CmbSymp10.FormattingEnabled = True
        Me.CmbSymp10.Items.AddRange(New Object() {"Abdominal Pain"})
        Me.CmbSymp10.Location = New System.Drawing.Point(544, 277)
        Me.CmbSymp10.Name = "CmbSymp10"
        Me.CmbSymp10.Size = New System.Drawing.Size(260, 27)
        Me.CmbSymp10.TabIndex = 10
        '
        'RichTextBoxCure
        '
        Me.RichTextBoxCure.BackColor = System.Drawing.Color.White
        Me.RichTextBoxCure.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxCure.Location = New System.Drawing.Point(275, 481)
        Me.RichTextBoxCure.Name = "RichTextBoxCure"
        Me.RichTextBoxCure.Size = New System.Drawing.Size(438, 86)
        Me.RichTextBoxCure.TabIndex = 13
        Me.RichTextBoxCure.Text = ""
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.DarkRed
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(909, 106)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(844, 38)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "MEDICAL DIAGNOSIS SYSTEM FOR PATIENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Symptoms 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Symptoms 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Symptoms 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(42, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Symptoms 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(430, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Symptoms 9"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(430, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Symptoms 8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(430, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Symptoms 7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(430, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Symptoms 6"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(42, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Symptoms 5"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(430, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 19)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Symptoms 10"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(151, 461)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Age"
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.White
        Me.TxtAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(67, 482)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(202, 26)
        Me.TxtAge.TabIndex = 110
        '
        'TxtCategory
        '
        Me.TxtCategory.BackColor = System.Drawing.Color.White
        Me.TxtCategory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCategory.Location = New System.Drawing.Point(67, 542)
        Me.TxtCategory.Name = "TxtCategory"
        Me.TxtCategory.Size = New System.Drawing.Size(202, 26)
        Me.TxtCategory.TabIndex = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(12, 586)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(885, 147)
        Me.DataGridView1.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPID)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CmbSymp10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CmbSymp9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CmbSymp8)
        Me.GroupBox1.Controls.Add(Me.CmbSymp7)
        Me.GroupBox1.Controls.Add(Me.CmbSymp6)
        Me.GroupBox1.Controls.Add(Me.CmbSymp5)
        Me.GroupBox1.Controls.Add(Me.CmbSymp4)
        Me.GroupBox1.Controls.Add(Me.CmbSymp3)
        Me.GroupBox1.Controls.Add(Me.CmbSymp2)
        Me.GroupBox1.Controls.Add(Me.CmbSymp1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Symptoms"
        '
        'TxtPID
        '
        Me.TxtPID.BackColor = System.Drawing.Color.White
        Me.TxtPID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPID.Location = New System.Drawing.Point(148, 36)
        Me.TxtPID.Name = "TxtPID"
        Me.TxtPID.Size = New System.Drawing.Size(261, 26)
        Me.TxtPID.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(43, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 19)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Enter PID"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.PDS.My.Resources.Resources.videos_4_background
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 695)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(909, 29)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 26)
        Me.ToolStripButton1.Text = "&Save"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(88, 26)
        Me.ToolStripButton2.Text = "&Update"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(76, 26)
        Me.ToolStripButton3.Text = "&Close"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(132, 518)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 19)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Category"
        '
        'FrmAddDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 724)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.RichTextBoxCure)
        Me.Controls.Add(Me.TxtCategory)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddDiagnosis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbSymp1 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp2 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp3 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp4 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp5 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp6 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp7 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp8 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp9 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSymp10 As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBoxCure As System.Windows.Forms.RichTextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtCategory As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtPID As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
