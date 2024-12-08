<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addpatients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addpatients))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.checkboxdeleted = New System.Windows.Forms.CheckBox()
        Me.checkboxisnot = New System.Windows.Forms.CheckBox()
        Me.txtpatientid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbladd = New System.Windows.Forms.Label()
        Me.lbledit = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.checkboxactive = New System.Windows.Forms.CheckBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.checkBooking = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtguardian = New System.Windows.Forms.TextBox()
        Me.cmbsuffix = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbmunicip = New System.Windows.Forms.ComboBox()
        Me.cmbprovince = New System.Windows.Forms.ComboBox()
        Me.cmbbrgy = New System.Windows.Forms.ComboBox()
        Me.cmbregion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemergency = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtoccupation = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.checkboxdeleted)
        Me.Panel1.Controls.Add(Me.checkboxisnot)
        Me.Panel1.Controls.Add(Me.txtpatientid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbladd)
        Me.Panel1.Controls.Add(Me.lbledit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 53)
        Me.Panel1.TabIndex = 1
        Me.Panel1.TabStop = True
        '
        'checkboxdeleted
        '
        Me.checkboxdeleted.AutoSize = True
        Me.checkboxdeleted.Checked = True
        Me.checkboxdeleted.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxdeleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxdeleted.Location = New System.Drawing.Point(854, 3)
        Me.checkboxdeleted.Name = "checkboxdeleted"
        Me.checkboxdeleted.Size = New System.Drawing.Size(106, 24)
        Me.checkboxdeleted.TabIndex = 57
        Me.checkboxdeleted.TabStop = False
        Me.checkboxdeleted.Text = "IsDeleted?"
        Me.checkboxdeleted.UseVisualStyleBackColor = True
        Me.checkboxdeleted.Visible = False
        '
        'checkboxisnot
        '
        Me.checkboxisnot.AutoSize = True
        Me.checkboxisnot.Checked = True
        Me.checkboxisnot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxisnot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxisnot.Location = New System.Drawing.Point(854, 26)
        Me.checkboxisnot.Name = "checkboxisnot"
        Me.checkboxisnot.Size = New System.Drawing.Size(75, 24)
        Me.checkboxisnot.TabIndex = 83
        Me.checkboxisnot.TabStop = False
        Me.checkboxisnot.Text = "IsNot?"
        Me.checkboxisnot.UseVisualStyleBackColor = True
        Me.checkboxisnot.Visible = False
        '
        'txtpatientid
        '
        Me.txtpatientid.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtpatientid.Location = New System.Drawing.Point(1007, 9)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(70, 29)
        Me.txtpatientid.TabIndex = 81
        Me.txtpatientid.TabStop = False
        Me.txtpatientid.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(971, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 25)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "ID"
        Me.Label3.Visible = False
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbladd.Image = CType(resources.GetObject("lbladd.Image"), System.Drawing.Image)
        Me.lbladd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbladd.Location = New System.Drawing.Point(12, 15)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(209, 32)
        Me.lbladd.TabIndex = 0
        Me.lbladd.Text = "     ADD PATIENTS"
        '
        'lbledit
        '
        Me.lbledit.AutoSize = True
        Me.lbledit.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbledit.Image = CType(resources.GetObject("lbledit.Image"), System.Drawing.Image)
        Me.lbledit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbledit.Location = New System.Drawing.Point(12, 9)
        Me.lbledit.Name = "lbledit"
        Me.lbledit.Size = New System.Drawing.Size(208, 32)
        Me.lbledit.TabIndex = 41
        Me.lbledit.Text = "     EDIT PATIENTS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.btnedit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 627)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1207, 78)
        Me.Panel2.TabIndex = 0
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
        Me.btncancel.Location = New System.Drawing.Point(1070, 9)
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
        Me.btnsave.Location = New System.Drawing.Point(31, 9)
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
        Me.btnedit.Location = New System.Drawing.Point(31, 9)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Padding = New System.Windows.Forms.Padding(0, 0, 17, 0)
        Me.btnedit.Size = New System.Drawing.Size(110, 60)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "EDIT  "
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.pnl.Controls.Add(Me.btnsearch)
        Me.pnl.Controls.Add(Me.btn_search)
        Me.pnl.Controls.Add(Me.checkboxactive)
        Me.pnl.Controls.Add(Me.txtsearch)
        Me.pnl.Controls.Add(Me.checkBooking)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl.Location = New System.Drawing.Point(0, 53)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1207, 50)
        Me.pnl.TabIndex = 3
        Me.pnl.TabStop = True
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.FlatAppearance.BorderSize = 0
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(575, 11)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(79, 29)
        Me.btnsearch.TabIndex = 32
        Me.btnsearch.TabStop = False
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        Me.btnsearch.Visible = False
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
        'checkboxactive
        '
        Me.checkboxactive.AutoSize = True
        Me.checkboxactive.Checked = True
        Me.checkboxactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxactive.Location = New System.Drawing.Point(854, 3)
        Me.checkboxactive.Name = "checkboxactive"
        Me.checkboxactive.Size = New System.Drawing.Size(93, 24)
        Me.checkboxactive.TabIndex = 82
        Me.checkboxactive.TabStop = False
        Me.checkboxactive.Text = "IsActive?"
        Me.checkboxactive.UseVisualStyleBackColor = True
        Me.checkboxactive.Visible = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI Symbol", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(51, 10)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(516, 30)
        Me.txtsearch.TabIndex = 0
        Me.txtsearch.TabStop = False
        Me.txtsearch.Visible = False
        '
        'checkBooking
        '
        Me.checkBooking.AutoSize = True
        Me.checkBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBooking.Location = New System.Drawing.Point(854, 26)
        Me.checkBooking.Name = "checkBooking"
        Me.checkBooking.Size = New System.Drawing.Size(113, 24)
        Me.checkBooking.TabIndex = 78
        Me.checkBooking.TabStop = False
        Me.checkBooking.Text = "addBooking"
        Me.checkBooking.UseVisualStyleBackColor = True
        Me.checkBooking.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Guardian"
        '
        'txtguardian
        '
        Me.txtguardian.AcceptsTab = True
        Me.txtguardian.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtguardian.Location = New System.Drawing.Point(26, 405)
        Me.txtguardian.Name = "txtguardian"
        Me.txtguardian.Size = New System.Drawing.Size(270, 33)
        Me.txtguardian.TabIndex = 126
        '
        'cmbsuffix
        '
        Me.cmbsuffix.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbsuffix.FormattingEnabled = True
        Me.cmbsuffix.Items.AddRange(New Object() {"Jr.", "Sr.", "II.", "III.", "IV", "V"})
        Me.cmbsuffix.Location = New System.Drawing.Point(550, 178)
        Me.cmbsuffix.Name = "cmbsuffix"
        Me.cmbsuffix.Size = New System.Drawing.Size(56, 33)
        Me.cmbsuffix.TabIndex = 125
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(546, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 20)
        Me.Label17.TabIndex = 124
        Me.Label17.Text = "Suffix"
        '
        'txtage
        '
        Me.txtage.Enabled = False
        Me.txtage.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtage.Location = New System.Drawing.Point(227, 253)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(69, 33)
        Me.txtage.TabIndex = 100
        '
        'cmbgender
        '
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(302, 253)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(117, 33)
        Me.cmbgender.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(298, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 20)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Sex"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(222, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Age"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(662, 226)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Province"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(662, 377)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 20)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Barangay"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(662, 301)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 20)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Municipality"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(662, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Region"
        '
        'cmbmunicip
        '
        Me.cmbmunicip.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbmunicip.FormattingEnabled = True
        Me.cmbmunicip.Location = New System.Drawing.Point(666, 331)
        Me.cmbmunicip.Name = "cmbmunicip"
        Me.cmbmunicip.Size = New System.Drawing.Size(514, 33)
        Me.cmbmunicip.TabIndex = 107
        '
        'cmbprovince
        '
        Me.cmbprovince.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbprovince.FormattingEnabled = True
        Me.cmbprovince.Location = New System.Drawing.Point(666, 253)
        Me.cmbprovince.Name = "cmbprovince"
        Me.cmbprovince.Size = New System.Drawing.Size(514, 33)
        Me.cmbprovince.TabIndex = 106
        '
        'cmbbrgy
        '
        Me.cmbbrgy.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbbrgy.FormattingEnabled = True
        Me.cmbbrgy.Location = New System.Drawing.Point(666, 405)
        Me.cmbbrgy.Name = "cmbbrgy"
        Me.cmbbrgy.Size = New System.Drawing.Size(514, 33)
        Me.cmbbrgy.TabIndex = 108
        '
        'cmbregion
        '
        Me.cmbregion.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbregion.FormattingEnabled = True
        Me.cmbregion.Location = New System.Drawing.Point(666, 178)
        Me.cmbregion.Name = "cmbregion"
        Me.cmbregion.Size = New System.Drawing.Size(514, 33)
        Me.cmbregion.TabIndex = 105
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(298, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtemail.Location = New System.Drawing.Point(302, 331)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(304, 33)
        Me.txtemail.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(299, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Emergency Contact"
        '
        'txtemergency
        '
        Me.txtemergency.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtemergency.Location = New System.Drawing.Point(303, 405)
        Me.txtemergency.Name = "txtemergency"
        Me.txtemergency.Size = New System.Drawing.Size(303, 33)
        Me.txtemergency.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(421, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Mobile"
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtmobile.Location = New System.Drawing.Point(425, 253)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(181, 33)
        Me.txtmobile.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(22, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Date of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(26, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 33)
        Me.DateTimePicker1.TabIndex = 99
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(420, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 20)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "Middle Name"
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtmname.Location = New System.Drawing.Point(425, 178)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(119, 33)
        Me.txtmname.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(223, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 20)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "First Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(22, 465)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(246, 20)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Street Name, Building, House No."
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtaddress.Location = New System.Drawing.Point(29, 488)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(577, 90)
        Me.txtaddress.TabIndex = 109
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtfname.Location = New System.Drawing.Point(227, 178)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(192, 33)
        Me.txtfname.TabIndex = 97
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(22, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 20)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Last Name"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtlname.Location = New System.Drawing.Point(26, 178)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(195, 33)
        Me.txtlname.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(111, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 17)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(315, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 17)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(517, 150)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 17)
        Me.Label20.TabIndex = 130
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(333, 226)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 17)
        Me.Label21.TabIndex = 131
        Me.Label21.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(120, 225)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 17)
        Me.Label22.TabIndex = 132
        Me.Label22.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(482, 226)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 17)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(717, 154)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 17)
        Me.Label24.TabIndex = 134
        Me.Label24.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(725, 226)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 17)
        Me.Label25.TabIndex = 135
        Me.Label25.Text = "*"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(758, 304)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 17)
        Me.Label26.TabIndex = 136
        Me.Label26.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(745, 377)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 17)
        Me.Label27.TabIndex = 137
        Me.Label27.Text = "*"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(282, 465)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 17)
        Me.Label28.TabIndex = 138
        Me.Label28.Text = "*"
        '
        'txtoccupation
        '
        Me.txtoccupation.AcceptsTab = True
        Me.txtoccupation.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.txtoccupation.Location = New System.Drawing.Point(26, 331)
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.Size = New System.Drawing.Size(270, 33)
        Me.txtoccupation.TabIndex = 139
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label30.Location = New System.Drawing.Point(22, 301)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(90, 20)
        Me.Label30.TabIndex = 141
        Me.Label30.Text = "Occupation"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(118, 301)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 17)
        Me.Label29.TabIndex = 142
        Me.Label29.Text = "*"
        '
        'frm_addpatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1207, 705)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtoccupation)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtemergency)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtguardian)
        Me.Controls.Add(Me.cmbsuffix)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbmunicip)
        Me.Controls.Add(Me.cmbprovince)
        Me.Controls.Add(Me.cmbbrgy)
        Me.Controls.Add(Me.cmbregion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmobile)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frm_addpatients"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lbledit As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtpatientid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents checkboxdeleted As System.Windows.Forms.CheckBox
    Friend WithEvents checkBooking As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtguardian As System.Windows.Forms.TextBox
    Friend WithEvents cmbsuffix As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbmunicip As System.Windows.Forms.ComboBox
    Friend WithEvents cmbprovince As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbrgy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbregion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtemergency As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents checkboxactive As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxisnot As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtoccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
End Class
