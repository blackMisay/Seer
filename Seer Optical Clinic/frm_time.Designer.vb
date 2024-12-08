<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_time
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_time))
        Me.pnlTopCat = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblNewCategory = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlTopCat.SuspendLayout()
        Me.pnlData.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopCat
        '
        Me.pnlTopCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.pnlTopCat.Controls.Add(Me.btnExit)
        Me.pnlTopCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopCat.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopCat.Name = "pnlTopCat"
        Me.pnlTopCat.Size = New System.Drawing.Size(369, 40)
        Me.pnlTopCat.TabIndex = 14
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(279, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.btnExit.Size = New System.Drawing.Size(87, 36)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "[ CLOSE ]"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlData
        '
        Me.pnlData.BackColor = System.Drawing.Color.White
        Me.pnlData.Controls.Add(Me.Panel4)
        Me.pnlData.Controls.Add(Me.lblNewCategory)
        Me.pnlData.Controls.Add(Me.txttime)
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
        Me.lblNewCategory.Size = New System.Drawing.Size(66, 20)
        Me.lblNewCategory.TabIndex = 12
        Me.lblNewCategory.Text = "Time    "
        '
        'txttime
        '
        Me.txttime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttime.BackColor = System.Drawing.Color.White
        Me.txttime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttime.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(22, 52)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(323, 26)
        Me.txttime.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer))
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
        'frm_time
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.pnlTopCat)
        Me.Name = "frm_time"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTopCat.ResumeLayout(False)
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTopCat As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblNewCategory As System.Windows.Forms.Label
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
