<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addAppointment))
        Me.pnl = New System.Windows.Forms.Panel()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.cmbfullname = New System.Windows.Forms.ComboBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtpatientid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbladd = New System.Windows.Forms.Label()
        Me.lbledit = New System.Windows.Forms.Label()
        Me.btnaddtime = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnAddAppointment = New System.Windows.Forms.Button()
        Me.txtassisted = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnaddservices = New System.Windows.Forms.Button()
        Me.cmbservices = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbtime = New System.Windows.Forms.DateTimePicker()
        Me.cmboptomet = New System.Windows.Forms.ComboBox()
        Me.checkboxactive = New System.Windows.Forms.CheckBox()
        Me.checkboxnot = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmboras = New System.Windows.Forms.ComboBox()
        Me.dateofapp = New System.Windows.Forms.DateTimePicker()
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.pnl.Controls.Add(Me.btn_search)
        Me.pnl.Controls.Add(Me.cmbfullname)
        Me.pnl.Controls.Add(Me.txtfullname)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl.Location = New System.Drawing.Point(0, 53)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(583, 50)
        Me.pnl.TabIndex = 5
        Me.pnl.TabStop = True
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btn_search.BackgroundImage = CType(resources.GetObject("btn_search.BackgroundImage"), System.Drawing.Image)
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search.Location = New System.Drawing.Point(11, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(33, 40)
        Me.btn_search.TabIndex = 30
        Me.btn_search.TabStop = False
        Me.btn_search.UseVisualStyleBackColor = False
        Me.btn_search.Visible = False
        '
        'cmbfullname
        '
        Me.cmbfullname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbfullname.FormattingEnabled = True
        Me.cmbfullname.Location = New System.Drawing.Point(52, 8)
        Me.cmbfullname.Name = "cmbfullname"
        Me.cmbfullname.Size = New System.Drawing.Size(501, 33)
        Me.cmbfullname.TabIndex = 130
        '
        'txtfullname
        '
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtfullname.Location = New System.Drawing.Point(52, 8)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(501, 33)
        Me.txtfullname.TabIndex = 163
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.txtpatientid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbladd)
        Me.Panel1.Controls.Add(Me.lbledit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 53)
        Me.Panel1.TabIndex = 4
        Me.Panel1.TabStop = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(487, 8)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 162
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(487, 31)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox1.TabIndex = 161
        Me.CheckBox1.Text = "isDeleted"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'txtpatientid
        '
        Me.txtpatientid.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtpatientid.Location = New System.Drawing.Point(335, 28)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(70, 29)
        Me.txtpatientid.TabIndex = 39
        Me.txtpatientid.TabStop = False
        Me.txtpatientid.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(330, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID"
        Me.Label3.Visible = False
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbladd.Image = CType(resources.GetObject("lbladd.Image"), System.Drawing.Image)
        Me.lbladd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbladd.Location = New System.Drawing.Point(12, 15)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(272, 32)
        Me.lbladd.TabIndex = 0
        Me.lbladd.Text = "     ADD APPOINTMENT"
        '
        'lbledit
        '
        Me.lbledit.AutoSize = True
        Me.lbledit.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbledit.Image = CType(resources.GetObject("lbledit.Image"), System.Drawing.Image)
        Me.lbledit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbledit.Location = New System.Drawing.Point(12, 15)
        Me.lbledit.Name = "lbledit"
        Me.lbledit.Size = New System.Drawing.Size(208, 32)
        Me.lbledit.TabIndex = 41
        Me.lbledit.Text = "EDIT PATIENTS     "
        '
        'btnaddtime
        '
        Me.btnaddtime.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnaddtime.FlatAppearance.BorderSize = 0
        Me.btnaddtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddtime.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddtime.ForeColor = System.Drawing.Color.White
        Me.btnaddtime.Location = New System.Drawing.Point(513, 288)
        Me.btnaddtime.Name = "btnaddtime"
        Me.btnaddtime.Size = New System.Drawing.Size(40, 33)
        Me.btnaddtime.TabIndex = 93
        Me.btnaddtime.Text = "+"
        Me.btnaddtime.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.btnedit)
        Me.Panel2.Controls.Add(Me.btnAddAppointment)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 392)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(583, 78)
        Me.Panel2.TabIndex = 57
        Me.Panel2.TabStop = True
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.Location = New System.Drawing.Point(443, 10)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btncancel.Size = New System.Drawing.Size(110, 60)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "CANCEL      "
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.Location = New System.Drawing.Point(37, 10)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnsave.Size = New System.Drawing.Size(110, 60)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "SAVE    "
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.Location = New System.Drawing.Point(37, 10)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Padding = New System.Windows.Forms.Padding(0, 0, 17, 0)
        Me.btnedit.Size = New System.Drawing.Size(110, 60)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "EDIT  "
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnAddAppointment.FlatAppearance.BorderSize = 0
        Me.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAppointment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddAppointment.ForeColor = System.Drawing.Color.White
        Me.btnAddAppointment.Image = CType(resources.GetObject("btnAddAppointment.Image"), System.Drawing.Image)
        Me.btnAddAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddAppointment.Location = New System.Drawing.Point(37, 10)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAddAppointment.Size = New System.Drawing.Size(110, 60)
        Me.btnAddAppointment.TabIndex = 18
        Me.btnAddAppointment.Text = "SAVE    "
        Me.btnAddAppointment.UseVisualStyleBackColor = False
        '
        'txtassisted
        '
        Me.txtassisted.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtassisted.Location = New System.Drawing.Point(237, 239)
        Me.txtassisted.Name = "txtassisted"
        Me.txtassisted.Size = New System.Drawing.Size(316, 33)
        Me.txtassisted.TabIndex = 154
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(32, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 25)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Services :"
        '
        'btnaddservices
        '
        Me.btnaddservices.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnaddservices.FlatAppearance.BorderSize = 0
        Me.btnaddservices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddservices.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddservices.ForeColor = System.Drawing.Color.White
        Me.btnaddservices.Location = New System.Drawing.Point(513, 335)
        Me.btnaddservices.Name = "btnaddservices"
        Me.btnaddservices.Size = New System.Drawing.Size(40, 33)
        Me.btnaddservices.TabIndex = 151
        Me.btnaddservices.Text = "+"
        Me.btnaddservices.UseVisualStyleBackColor = False
        '
        'cmbservices
        '
        Me.cmbservices.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbservices.FormattingEnabled = True
        Me.cmbservices.Location = New System.Drawing.Point(237, 335)
        Me.cmbservices.Name = "cmbservices"
        Me.cmbservices.Size = New System.Drawing.Size(270, 33)
        Me.cmbservices.TabIndex = 150
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(32, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 25)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Optometrist :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(32, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Assisted By :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(32, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 25)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "Appointment Time :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(32, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 25)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Date of Appointment :"
        '
        'cmbtime
        '
        Me.cmbtime.CustomFormat = "hh-mm"
        Me.cmbtime.Font = New System.Drawing.Font("Segoe UI Symbol", 12.75!)
        Me.cmbtime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.cmbtime.Location = New System.Drawing.Point(237, 185)
        Me.cmbtime.Name = "cmbtime"
        Me.cmbtime.ShowUpDown = True
        Me.cmbtime.Size = New System.Drawing.Size(316, 30)
        Me.cmbtime.TabIndex = 161
        '
        'cmboptomet
        '
        Me.cmboptomet.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmboptomet.FormattingEnabled = True
        Me.cmboptomet.Location = New System.Drawing.Point(237, 288)
        Me.cmboptomet.Name = "cmboptomet"
        Me.cmboptomet.Size = New System.Drawing.Size(270, 33)
        Me.cmboptomet.TabIndex = 162
        '
        'checkboxactive
        '
        Me.checkboxactive.AutoSize = True
        Me.checkboxactive.Checked = True
        Me.checkboxactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxactive.Location = New System.Drawing.Point(460, 100)
        Me.checkboxactive.Name = "checkboxactive"
        Me.checkboxactive.Size = New System.Drawing.Size(93, 24)
        Me.checkboxactive.TabIndex = 163
        Me.checkboxactive.TabStop = False
        Me.checkboxactive.Text = "IsActive?"
        Me.checkboxactive.UseVisualStyleBackColor = True
        Me.checkboxactive.Visible = False
        '
        'checkboxnot
        '
        Me.checkboxnot.AutoSize = True
        Me.checkboxnot.Checked = True
        Me.checkboxnot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxnot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxnot.Location = New System.Drawing.Point(338, 100)
        Me.checkboxnot.Name = "checkboxnot"
        Me.checkboxnot.Size = New System.Drawing.Size(75, 24)
        Me.checkboxnot.TabIndex = 164
        Me.checkboxnot.TabStop = False
        Me.checkboxnot.Text = "IsNot?"
        Me.checkboxnot.UseVisualStyleBackColor = True
        Me.checkboxnot.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.cmboras)
        Me.Panel3.Controls.Add(Me.checkboxnot)
        Me.Panel3.Controls.Add(Me.dateofapp)
        Me.Panel3.Controls.Add(Me.checkboxactive)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(583, 470)
        Me.Panel3.TabIndex = 165
        '
        'cmboras
        '
        Me.cmboras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmboras.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmboras.FormattingEnabled = True
        Me.cmboras.Items.AddRange(New Object() {"7:00 AM", "7:30 AM", "8:00 AM", "7:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM", "4:30 PM"})
        Me.cmboras.Location = New System.Drawing.Point(237, 186)
        Me.cmboras.Name = "cmboras"
        Me.cmboras.Size = New System.Drawing.Size(316, 33)
        Me.cmboras.TabIndex = 166
        '
        'dateofapp
        '
        Me.dateofapp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dateofapp.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.dateofapp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateofapp.Location = New System.Drawing.Point(237, 129)
        Me.dateofapp.Name = "dateofapp"
        Me.dateofapp.Size = New System.Drawing.Size(316, 33)
        Me.dateofapp.TabIndex = 100
        '
        'frm_addAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(583, 470)
        Me.Controls.Add(Me.cmboptomet)
        Me.Controls.Add(Me.btnaddtime)
        Me.Controls.Add(Me.txtassisted)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnaddservices)
        Me.Controls.Add(Me.cmbservices)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cmbtime)
        Me.Name = "frm_addAppointment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtpatientid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents lbledit As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnaddtime As System.Windows.Forms.Button
    Friend WithEvents cmbfullname As System.Windows.Forms.ComboBox
    Friend WithEvents txtassisted As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnaddservices As System.Windows.Forms.Button
    Friend WithEvents cmbservices As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmboptomet As System.Windows.Forms.ComboBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents checkboxactive As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxnot As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dateofapp As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmboras As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddAppointment As System.Windows.Forms.Button
End Class
