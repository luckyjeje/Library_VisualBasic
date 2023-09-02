<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        PetugasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        AnggotaToolStripMenuItem = New ToolStripMenuItem()
        BukuToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        PeminjamanToolStripMenuItem = New ToolStripMenuItem()
        PengembalianToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        UtilityToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        STLabel1 = New ToolStripStatusLabel()
        STLabel2 = New ToolStripStatusLabel()
        STLabel3 = New ToolStripStatusLabel()
        STLabel4 = New ToolStripStatusLabel()
        STLabel5 = New ToolStripStatusLabel()
        STLabel6 = New ToolStripStatusLabel()
        STLabel7 = New ToolStripStatusLabel()
        STLabel8 = New ToolStripStatusLabel()
        STLabel9 = New ToolStripStatusLabel()
        STLabel10 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, UtilityToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem, LogoutToolStripMenuItem, ToolStripMenuItem1, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(112, 22)
        LoginToolStripMenuItem.Text = "Login"' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(112, 22)
        LogoutToolStripMenuItem.Text = "Logout"' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(109, 6)
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(112, 22)
        KeluarToolStripMenuItem.Text = "Keluar"' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PetugasToolStripMenuItem, ToolStripMenuItem2, AnggotaToolStripMenuItem, BukuToolStripMenuItem})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(55, 20)
        MasterToolStripMenuItem.Text = "Master"' 
        ' PetugasToolStripMenuItem
        ' 
        PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        PetugasToolStripMenuItem.Size = New Size(120, 22)
        PetugasToolStripMenuItem.Text = "Petugas"' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(117, 6)
        ' 
        ' AnggotaToolStripMenuItem
        ' 
        AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        AnggotaToolStripMenuItem.Size = New Size(120, 22)
        AnggotaToolStripMenuItem.Text = "Anggota"' 
        ' BukuToolStripMenuItem
        ' 
        BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        BukuToolStripMenuItem.Size = New Size(120, 22)
        BukuToolStripMenuItem.Text = "Buku"' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PeminjamanToolStripMenuItem, PengembalianToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(66, 20)
        TransaksiToolStripMenuItem.Text = "Transaksi"' 
        ' PeminjamanToolStripMenuItem
        ' 
        PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        PeminjamanToolStripMenuItem.Size = New Size(150, 22)
        PeminjamanToolStripMenuItem.Text = "Peminjaman"' 
        ' PengembalianToolStripMenuItem
        ' 
        PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        PengembalianToolStripMenuItem.Size = New Size(150, 22)
        PengembalianToolStripMenuItem.Text = "Pengembalian"' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(62, 20)
        LaporanToolStripMenuItem.Text = "Laporan"' 
        ' UtilityToolStripMenuItem
        ' 
        UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        UtilityToolStripMenuItem.Size = New Size(50, 20)
        UtilityToolStripMenuItem.Text = "Utility"' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {STLabel1, STLabel2, STLabel3, STLabel4, STLabel5, STLabel6, STLabel7, STLabel8, STLabel9, STLabel10})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"' 
        ' STLabel1
        ' 
        STLabel1.Name = "STLabel1"
        STLabel1.Size = New Size(42, 17)
        STLabel1.Text = "KODE :"' 
        ' STLabel2
        ' 
        STLabel2.Name = "STLabel2"
        STLabel2.Size = New Size(0, 17)
        ' 
        ' STLabel3
        ' 
        STLabel3.Name = "STLabel3"
        STLabel3.Size = New Size(49, 17)
        STLabel3.Text = "NAMA :"' 
        ' STLabel4
        ' 
        STLabel4.Name = "STLabel4"
        STLabel4.Size = New Size(0, 17)
        ' 
        ' STLabel5
        ' 
        STLabel5.Name = "STLabel5"
        STLabel5.Size = New Size(44, 17)
        STLabel5.Text = "LEVEL :"' 
        ' STLabel6
        ' 
        STLabel6.Name = "STLabel6"
        STLabel6.Size = New Size(0, 17)
        ' 
        ' STLabel7
        ' 
        STLabel7.Name = "STLabel7"
        STLabel7.Size = New Size(36, 17)
        STLabel7.Text = "JAM :"' 
        ' STLabel8
        ' 
        STLabel8.Name = "STLabel8"
        STLabel8.Size = New Size(0, 17)
        ' 
        ' STLabel9
        ' 
        STLabel9.Name = "STLabel9"
        STLabel9.Size = New Size(65, 17)
        STLabel9.Text = "TANGGAL :"' 
        ' STLabel10
        ' 
        STLabel10.Name = "STLabel10"
        STLabel10.Size = New Size(0, 17)
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Untitled
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form Menu Utama Aplikasi Perpustakaan"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents STLabel1 As ToolStripStatusLabel
    Friend WithEvents STLabel2 As ToolStripStatusLabel
    Friend WithEvents STLabel3 As ToolStripStatusLabel
    Friend WithEvents STLabel4 As ToolStripStatusLabel
    Friend WithEvents STLabel5 As ToolStripStatusLabel
    Friend WithEvents STLabel6 As ToolStripStatusLabel
    Friend WithEvents STLabel7 As ToolStripStatusLabel
    Friend WithEvents STLabel8 As ToolStripStatusLabel
    Friend WithEvents STLabel9 As ToolStripStatusLabel
    Friend WithEvents STLabel10 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
