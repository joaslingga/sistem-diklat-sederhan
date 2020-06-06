<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CEKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CEKOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAFTARPENGUNJUNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAFYARPEGAWAIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MYPROFILToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAFTARADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.MYPROFILToolStripMenuItem, Me.DAFTARADMINToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1095, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CEKINToolStripMenuItem, Me.CEKOUTToolStripMenuItem, Me.DAFTARPENGUNJUNGToolStripMenuItem, Me.DAFYARPEGAWAIToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'CEKINToolStripMenuItem
        '
        Me.CEKINToolStripMenuItem.Name = "CEKINToolStripMenuItem"
        Me.CEKINToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CEKINToolStripMenuItem.Text = "CEK_ IN"
        '
        'CEKOUTToolStripMenuItem
        '
        Me.CEKOUTToolStripMenuItem.Name = "CEKOUTToolStripMenuItem"
        Me.CEKOUTToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CEKOUTToolStripMenuItem.Text = "CEK_OUT"
        '
        'DAFTARPENGUNJUNGToolStripMenuItem
        '
        Me.DAFTARPENGUNJUNGToolStripMenuItem.Name = "DAFTARPENGUNJUNGToolStripMenuItem"
        Me.DAFTARPENGUNJUNGToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.DAFTARPENGUNJUNGToolStripMenuItem.Text = "DAFTAR_PENGUNJUNG"
        '
        'DAFYARPEGAWAIToolStripMenuItem
        '
        Me.DAFYARPEGAWAIToolStripMenuItem.Name = "DAFYARPEGAWAIToolStripMenuItem"
        Me.DAFYARPEGAWAIToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.DAFYARPEGAWAIToolStripMenuItem.Text = "DAFTAR_PEGAWAI"
        '
        'MYPROFILToolStripMenuItem
        '
        Me.MYPROFILToolStripMenuItem.Name = "MYPROFILToolStripMenuItem"
        Me.MYPROFILToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MYPROFILToolStripMenuItem.Text = "My_Profil"
        '
        'DAFTARADMINToolStripMenuItem
        '
        Me.DAFTARADMINToolStripMenuItem.Name = "DAFTARADMINToolStripMenuItem"
        Me.DAFTARADMINToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DAFTARADMINToolStripMenuItem.Text = "Daftar_admin"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(278, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(718, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat Datang Di Asrma P4TK BBL Medan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Frm_MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 540)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CEKINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CEKOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DAFTARPENGUNJUNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DAFYARPEGAWAIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MYPROFILToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DAFTARADMINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
