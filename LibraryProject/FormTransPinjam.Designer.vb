<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransPinjam
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LBLNoPinjam = New Label()
        ComboBox1 = New ComboBox()
        LBLNama = New Label()
        LBLAlamat = New Label()
        LBLTelepon = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        LBLTanggal = New Label()
        LBLJam = New Label()
        LBLNamaPetugas = New Label()
        Label9 = New Label()
        TextBox1 = New TextBox()
        Label10 = New Label()
        LBLJudul = New Label()
        Label11 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Timer1 = New Timer(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(41, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "No Pinjam"' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(41, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 1
        Label2.Text = "Kode Anggota"' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(41, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 2
        Label3.Text = "Nama"' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(41, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 3
        Label4.Text = "Alamat"' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(41, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 4
        Label5.Text = "Telepon"' 
        ' LBLNoPinjam
        ' 
        LBLNoPinjam.BorderStyle = BorderStyle.Fixed3D
        LBLNoPinjam.Location = New Point(147, 30)
        LBLNoPinjam.Name = "LBLNoPinjam"
        LBLNoPinjam.Size = New Size(121, 23)
        LBLNoPinjam.TabIndex = 5
        LBLNoPinjam.Text = "LBLNoPinjam"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(147, 69)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' LBLNama
        ' 
        LBLNama.BorderStyle = BorderStyle.Fixed3D
        LBLNama.Location = New Point(147, 109)
        LBLNama.Name = "LBLNama"
        LBLNama.Size = New Size(339, 23)
        LBLNama.TabIndex = 7
        LBLNama.Text = "LBLNama"' 
        ' LBLAlamat
        ' 
        LBLAlamat.BorderStyle = BorderStyle.Fixed3D
        LBLAlamat.Location = New Point(147, 148)
        LBLAlamat.Name = "LBLAlamat"
        LBLAlamat.Size = New Size(339, 23)
        LBLAlamat.TabIndex = 8
        LBLAlamat.Text = "LBLAlamat"' 
        ' LBLTelepon
        ' 
        LBLTelepon.BorderStyle = BorderStyle.Fixed3D
        LBLTelepon.Location = New Point(147, 183)
        LBLTelepon.Name = "LBLTelepon"
        LBLTelepon.Size = New Size(339, 23)
        LBLTelepon.TabIndex = 9
        LBLTelepon.Text = "LBLTelepon"' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Location = New Point(501, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 23)
        Label6.TabIndex = 10
        Label6.Text = "Tanggal"' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Location = New Point(501, 69)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 23)
        Label7.TabIndex = 11
        Label7.Text = "Jam"' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Location = New Point(501, 109)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 23)
        Label8.TabIndex = 12
        Label8.Text = "Petugas"' 
        ' LBLTanggal
        ' 
        LBLTanggal.BorderStyle = BorderStyle.Fixed3D
        LBLTanggal.Location = New Point(571, 30)
        LBLTanggal.Name = "LBLTanggal"
        LBLTanggal.Size = New Size(163, 23)
        LBLTanggal.TabIndex = 13
        LBLTanggal.Text = "LBLTanggal"' 
        ' LBLJam
        ' 
        LBLJam.BorderStyle = BorderStyle.Fixed3D
        LBLJam.Location = New Point(571, 69)
        LBLJam.Name = "LBLJam"
        LBLJam.Size = New Size(163, 23)
        LBLJam.TabIndex = 14
        LBLJam.Text = "LBLJam"' 
        ' LBLNamaPetugas
        ' 
        LBLNamaPetugas.BorderStyle = BorderStyle.Fixed3D
        LBLNamaPetugas.Location = New Point(571, 109)
        LBLNamaPetugas.Name = "LBLNamaPetugas"
        LBLNamaPetugas.Size = New Size(163, 23)
        LBLNamaPetugas.TabIndex = 15
        LBLNamaPetugas.Text = "LBLNamaPetugas"' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Location = New Point(41, 219)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 16
        Label9.Text = "Kode Buku"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(147, 219)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Location = New Point(253, 221)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 23)
        Label10.TabIndex = 18
        Label10.Text = "Judul"' 
        ' LBLJudul
        ' 
        LBLJudul.BorderStyle = BorderStyle.Fixed3D
        LBLJudul.Location = New Point(307, 221)
        LBLJudul.Name = "LBLJudul"
        LBLJudul.Size = New Size(258, 23)
        LBLJudul.TabIndex = 19
        LBLJudul.Text = "LBLJudul"' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Location = New Point(571, 221)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 23)
        Label11.TabIndex = 20
        Label11.Text = "Jml"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(609, 221)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(47, 23)
        TextBox2.TabIndex = 21
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(662, 221)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 22
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(41, 264)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(696, 203)
        DataGridView1.TabIndex = 23
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(501, 494)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 24
        Button2.Text = "SIMPAN"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(581, 494)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 25
        Button3.Text = "BATAL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(662, 494)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 26
        Button4.Text = "TUTUP"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' FormTransPinjam
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(835, 546)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label11)
        Controls.Add(LBLJudul)
        Controls.Add(Label10)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(LBLNamaPetugas)
        Controls.Add(LBLJam)
        Controls.Add(LBLTanggal)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(LBLTelepon)
        Controls.Add(LBLAlamat)
        Controls.Add(LBLNama)
        Controls.Add(ComboBox1)
        Controls.Add(LBLNoPinjam)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormTransPinjam"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Peminjaman Buku"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLNoPinjam As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LBLNama As Label
    Friend WithEvents LBLAlamat As Label
    Friend WithEvents LBLTelepon As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBLTanggal As Label
    Friend WithEvents LBLJam As Label
    Friend WithEvents LBLNamaPetugas As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLJudul As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
End Class
