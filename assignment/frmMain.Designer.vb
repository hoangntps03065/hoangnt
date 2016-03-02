<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.KhácHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChỉnhSữaKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemKhácHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KhácHàngToolStripMenuItem
        '
        Me.KhácHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChỉnhSữaKHToolStripMenuItem, Me.XemKhácHàngToolStripMenuItem})
        Me.KhácHàngToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KhácHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.KhácHàngToolStripMenuItem.Name = "KhácHàngToolStripMenuItem"
        Me.KhácHàngToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.KhácHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'ChỉnhSữaKHToolStripMenuItem
        '
        Me.ChỉnhSữaKHToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChỉnhSữaKHToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ChỉnhSữaKHToolStripMenuItem.Name = "ChỉnhSữaKHToolStripMenuItem"
        Me.ChỉnhSữaKHToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ChỉnhSữaKHToolStripMenuItem.Text = "Cập nhật KH"
        '
        'XemKhácHàngToolStripMenuItem
        '
        Me.XemKhácHàngToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XemKhácHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.XemKhácHàngToolStripMenuItem.Name = "XemKhácHàngToolStripMenuItem"
        Me.XemKhácHàngToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.XemKhácHàngToolStripMenuItem.Text = "Xem khác hàng"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSảnPhẩmToolStripMenuItem, Me.XemSảnPhẩmToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(98, 25)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'ThêmSảnPhẩmToolStripMenuItem
        '
        Me.ThêmSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ThêmSảnPhẩmToolStripMenuItem.Name = "ThêmSảnPhẩmToolStripMenuItem"
        Me.ThêmSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.ThêmSảnPhẩmToolStripMenuItem.Text = "Cập nhật SP"
        '
        'XemSảnPhẩmToolStripMenuItem
        '
        Me.XemSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.XemSảnPhẩmToolStripMenuItem.Name = "XemSảnPhẩmToolStripMenuItem"
        Me.XemSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.XemSảnPhẩmToolStripMenuItem.Text = "Xem sản phẩm"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhácHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.NhânViênToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(570, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NhânViênToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(103, 25)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 359)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Điện toán đám mây"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KhácHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChỉnhSữaKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemKhácHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
