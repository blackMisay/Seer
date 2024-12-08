<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageDoctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManageDoctor))
        Me.pnlTopCat = New System.Windows.Forms.Panel()
        Me.lblNewCategory = New System.Windows.Forms.Label()
        Me.cmbsuffix = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlTopCat.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopCat
        '
        Me.pnlTopCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.pnlTopCat.Controls.Add(Me.lblNewCategory)
        Me.pnlTopCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopCat.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopCat.Name = "pnlTopCat"
        Me.pnlTopCat.Size = New System.Drawing.Size(533, 40)
        Me.pnlTopCat.TabIndex = 15
        '
        'lblNewCategory
        '
        Me.lblNewCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNewCategory.AutoSize = True
        Me.lblNewCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewCategory.Image = CType(resources.GetObject("lblNewCategory.Image"), System.Drawing.Image)
        Me.lblNewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNewCategory.Location = New System.Drawing.Point(18, 9)
        Me.lblNewCategory.Name = "lblNewCategory"
        Me.lblNewCategory.Size = New System.Drawing.Size(181, 20)
        Me.lblNewCategory.TabIndex = 13
        Me.lblNewCategory.Text = "Manage Optometrist    "
        '
        'cmbsuffix
        '
        Me.cmbsuffix.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmbsuffix.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!)
        Me.cmbsuffix.FormattingEnabled = True
        Me.cmbsuffix.Items.AddRange(New Object() {"Jr.", "Sr.", "II.", "III.", "IV", "V"})
        Me.cmbsuffix.Location = New System.Drawing.Point(133, 193)
        Me.cmbsuffix.Name = "cmbsuffix"
        Me.cmbsuffix.Size = New System.Drawing.Size(323, 33)
        Me.cmbsuffix.TabIndex = 152
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(28, 200)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 20)
        Me.Label17.TabIndex = 151
        Me.Label17.Text = "Suffix"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(28, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 20)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "Middle Name"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(28, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 20)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "First Name"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(28, 65)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 20)
        Me.Label19.TabIndex = 148
        Me.Label19.Text = "Last Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(133, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 1)
        Me.Panel2.TabIndex = 147
        '
        'txtlname
        '
        Me.txtlname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtlname.BackColor = System.Drawing.Color.White
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(133, 61)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(323, 26)
        Me.txtlname.TabIndex = 146
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(133, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 1)
        Me.Panel1.TabIndex = 145
        '
        'txtfname
        '
        Me.txtfname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfname.BackColor = System.Drawing.Color.White
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(133, 108)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(323, 26)
        Me.txtfname.TabIndex = 144
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(133, 179)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(323, 1)
        Me.Panel4.TabIndex = 143
        '
        'txtmname
        '
        Me.txtmname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmname.BackColor = System.Drawing.Color.White
        Me.txtmname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(133, 151)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(323, 26)
        Me.txtmname.TabIndex = 142
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(133, 245)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(323, 41)
        Me.btnSave.TabIndex = 141
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frm_ManageDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 296)
        Me.Controls.Add(Me.cmbsuffix)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlTopCat)
        Me.Name = "frm_ManageDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ManageDoctor"
        Me.pnlTopCat.ResumeLayout(False)
        Me.pnlTopCat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTopCat As System.Windows.Forms.Panel
    Friend WithEvents lblNewCategory As System.Windows.Forms.Label
    Friend WithEvents cmbsuffix As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
