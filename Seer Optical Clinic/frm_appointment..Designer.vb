<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_appointment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnsuccess = New System.Windows.Forms.Button()
        Me.btn_addpres = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtqppointmentID = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnarchive = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.panelCon = New System.Windows.Forms.Panel()
        Me.dgv_app = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUpdate = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colTrash = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelCon.SuspendLayout()
        CType(Me.dgv_app, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnsuccess)
        Me.Panel3.Controls.Add(Me.btn_addpres)
        Me.Panel3.Controls.Add(Me.btnsearch)
        Me.Panel3.Controls.Add(Me.txtsearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1094, 50)
        Me.Panel3.TabIndex = 6
        '
        'btnsuccess
        '
        Me.btnsuccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnsuccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsuccess.FlatAppearance.BorderSize = 0
        Me.btnsuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsuccess.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnsuccess.ForeColor = System.Drawing.Color.Black
        Me.btnsuccess.Image = CType(resources.GetObject("btnsuccess.Image"), System.Drawing.Image)
        Me.btnsuccess.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnsuccess.Location = New System.Drawing.Point(635, 4)
        Me.btnsuccess.Margin = New System.Windows.Forms.Padding(0)
        Me.btnsuccess.Name = "btnsuccess"
        Me.btnsuccess.Size = New System.Drawing.Size(219, 43)
        Me.btnsuccess.TabIndex = 31
        Me.btnsuccess.Text = "Successful Appointment"
        Me.btnsuccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsuccess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnsuccess.UseVisualStyleBackColor = False
        '
        'btn_addpres
        '
        Me.btn_addpres.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_addpres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addpres.FlatAppearance.BorderSize = 0
        Me.btn_addpres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addpres.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_addpres.ForeColor = System.Drawing.Color.Black
        Me.btn_addpres.Image = CType(resources.GetObject("btn_addpres.Image"), System.Drawing.Image)
        Me.btn_addpres.Location = New System.Drawing.Point(865, 4)
        Me.btn_addpres.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_addpres.Name = "btn_addpres"
        Me.btn_addpres.Size = New System.Drawing.Size(219, 43)
        Me.btn_addpres.TabIndex = 9
        Me.btn_addpres.Text = "Add Prescription"
        Me.btn_addpres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addpres.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_addpres.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.FlatAppearance.BorderSize = 0
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.Location = New System.Drawing.Point(540, 10)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(79, 30)
        Me.btnsearch.TabIndex = 30
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI Symbol", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(10, 10)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(516, 30)
        Me.txtsearch.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtqppointmentID)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 38)
        Me.Panel1.TabIndex = 3
        '
        'txtqppointmentID
        '
        Me.txtqppointmentID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtqppointmentID.Location = New System.Drawing.Point(523, 6)
        Me.txtqppointmentID.Name = "txtqppointmentID"
        Me.txtqppointmentID.Size = New System.Drawing.Size(70, 29)
        Me.txtqppointmentID.TabIndex = 483
        Me.txtqppointmentID.TabStop = False
        Me.txtqppointmentID.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label29.Location = New System.Drawing.Point(487, 6)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 25)
        Me.Label29.TabIndex = 482
        Me.Label29.Text = "ID"
        Me.Label29.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "     APPOINTMENT SCHEDULE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnarchive)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 578)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1094, 78)
        Me.Panel2.TabIndex = 5
        '
        'btnarchive
        '
        Me.btnarchive.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnarchive.FlatAppearance.BorderSize = 0
        Me.btnarchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarchive.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnarchive.ForeColor = System.Drawing.Color.White
        Me.btnarchive.Image = CType(resources.GetObject("btnarchive.Image"), System.Drawing.Image)
        Me.btnarchive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnarchive.Location = New System.Drawing.Point(155, 9)
        Me.btnarchive.Name = "btnarchive"
        Me.btnarchive.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btnarchive.Size = New System.Drawing.Size(110, 60)
        Me.btnarchive.TabIndex = 18
        Me.btnarchive.Text = "ARCHIVE      "
        Me.btnarchive.UseVisualStyleBackColor = False
        Me.btnarchive.Visible = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.Location = New System.Drawing.Point(20, 9)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Padding = New System.Windows.Forms.Padding(0, 0, 19, 0)
        Me.btnadd.Size = New System.Drawing.Size(110, 60)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD  "
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.DataPropertyName = "colUpdate"
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 40
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.ToolTipText = "EDIT"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.DataPropertyName = "isdeleted"
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.MinimumWidth = 40
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.ToolTipText = "DELETE"
        '
        'panelCon
        '
        Me.panelCon.Controls.Add(Me.dgv_app)
        Me.panelCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCon.Location = New System.Drawing.Point(0, 88)
        Me.panelCon.Name = "panelCon"
        Me.panelCon.Size = New System.Drawing.Size(1094, 490)
        Me.panelCon.TabIndex = 7
        '
        'dgv_app
        '
        Me.dgv_app.AllowUserToAddRows = False
        Me.dgv_app.AllowUserToDeleteRows = False
        Me.dgv_app.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(137, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_app.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_app.ColumnHeadersHeight = 30
        Me.dgv_app.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_app.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10, Me.Column11, Me.colUpdate, Me.colTrash})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_app.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_app.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_app.EnableHeadersVisualStyles = False
        Me.dgv_app.GridColor = System.Drawing.Color.DarkGray
        Me.dgv_app.Location = New System.Drawing.Point(0, 0)
        Me.dgv_app.Name = "dgv_app"
        Me.dgv_app.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_app.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_app.RowHeadersVisible = False
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_app.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_app.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_app.Size = New System.Drawing.Size(1094, 490)
        Me.dgv_app.TabIndex = 9
        Me.dgv_app.Tag = ""
        '
        'ID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ID.HeaderText = "#"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "Appointmentid"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DataPropertyName = "patientid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Patient ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 95
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "fullname"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "Name of Patients"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "dateofapp"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle5.Format = "D"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Date of Appointment"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.DataPropertyName = "stime"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.Format = "t"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.HeaderText = "Start Time"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 97
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.DataPropertyName = "assisted"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column6.HeaderText = "Assisted By:"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 107
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DataPropertyName = "optomet"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column7.HeaderText = "Optometrist"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 108
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.DataPropertyName = "service"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column8.HeaderText = "Services"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 83
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.DataPropertyName = "status"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column10.HeaderText = "Status"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 71
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "isAvailable"
        Me.Column11.HeaderText = "isAvailable"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'colUpdate
        '
        Me.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUpdate.DataPropertyName = "colUpdate"
        Me.colUpdate.HeaderText = ""
        Me.colUpdate.Image = CType(resources.GetObject("colUpdate.Image"), System.Drawing.Image)
        Me.colUpdate.MinimumWidth = 40
        Me.colUpdate.Name = "colUpdate"
        Me.colUpdate.ReadOnly = True
        Me.colUpdate.ToolTipText = "EDIT"
        Me.colUpdate.Width = 40
        '
        'colTrash
        '
        Me.colTrash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTrash.DataPropertyName = "isdeleted"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        Me.colTrash.DefaultCellStyle = DataGridViewCellStyle11
        Me.colTrash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colTrash.HeaderText = ""
        Me.colTrash.MinimumWidth = 40
        Me.colTrash.Name = "colTrash"
        Me.colTrash.ReadOnly = True
        Me.colTrash.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colTrash.Text = "CANCEL"
        Me.colTrash.ToolTipText = "CANCEL"
        Me.colTrash.UseColumnTextForButtonValue = True
        Me.colTrash.Width = 40
        '
        'frm_appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 656)
        Me.Controls.Add(Me.panelCon)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "frm_appointment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.panelCon.ResumeLayout(False)
        CType(Me.dgv_app, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnarchive As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_addpres As System.Windows.Forms.Button
    Friend WithEvents txtqppointmentID As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btnsuccess As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents panelCon As System.Windows.Forms.Panel
    Friend WithEvents dgv_app As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUpdate As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colTrash As System.Windows.Forms.DataGridViewButtonColumn
End Class
