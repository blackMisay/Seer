<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_services
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_services))
        Me.pnlTopCat = New System.Windows.Forms.Panel()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblNewCategory = New System.Windows.Forms.Label()
        Me.txtservices = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlData.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopCat
        '
        Me.pnlTopCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.pnlTopCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopCat.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopCat.Name = "pnlTopCat"
        Me.pnlTopCat.Size = New System.Drawing.Size(369, 40)
        Me.pnlTopCat.TabIndex = 14
        '
        'pnlData
        '
        Me.pnlData.BackColor = System.Drawing.Color.White
        Me.pnlData.Controls.Add(Me.Panel4)
        Me.pnlData.Controls.Add(Me.lblNewCategory)
        Me.pnlData.Controls.Add(Me.txtservices)
        Me.pnlData.Controls.Add(Me.btnSave)
        Me.pnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlData.Location = New System.Drawing.Point(0, 40)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(369, 164)
        Me.pnlData.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(22, 80)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(323, 1)
        Me.Panel4.TabIndex = 19
        '
        'lblNewCategory
        '
        Me.lblNewCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNewCategory.AutoSize = True
        Me.lblNewCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewCategory.Image = CType(resources.GetObject("lblNewCategory.Image"), System.Drawing.Image)
        Me.lblNewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNewCategory.Location = New System.Drawing.Point(18, 17)
        Me.lblNewCategory.Name = "lblNewCategory"
        Me.lblNewCategory.Size = New System.Drawing.Size(94, 20)
        Me.lblNewCategory.TabIndex = 12
        Me.lblNewCategory.Text = "Services    "
        '
        'txtservices
        '
        Me.txtservices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtservices.BackColor = System.Drawing.Color.White
        Me.txtservices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtservices.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservices.Location = New System.Drawing.Point(22, 52)
        Me.txtservices.Name = "txtservices"
        Me.txtservices.Size = New System.Drawing.Size(323, 26)
        Me.txtservices.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(22, 102)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(323, 41)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frm_services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.pnlTopCat)
        Me.Name = "frm_services"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTopCat As System.Windows.Forms.Panel
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblNewCategory As System.Windows.Forms.Label
    Friend WithEvents txtservices As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
