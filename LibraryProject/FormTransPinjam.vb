Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormTransPinjam
    Sub KondisiAwal()
        Call NoOtomatis()
        Call MunculKodeAnggota()
        LBLNamaPetugas.Text = Form1.STLabel4.Text
        LBLNama.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLJudul.Text = ""
    End Sub
    Private Sub FormTransPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        LBLTanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_PINJAM where NoPinjam in (select max(NoPinjam) from TBL_PINJAM)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoPinjam.Text = UrutanKode
        'TextBox2.Focus()
    End Sub
    Sub MunculKodeAnggota()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New SqlCommand("Select * from tbl_anggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New SqlCommand("select * from tbl_anggota where  kodeanggota='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNama.Text = Rd!NamaAnggota
            LBLAlamat.Text = Rd!AlamatAnggota
            LBLTelepon.Text = Rd!TelpAnggota
        End If

    End Sub
End Class