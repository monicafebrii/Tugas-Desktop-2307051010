Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFakultas.Items.Add("FMIPA")
        cbFakultas.Items.Add("FKIP")
        cbFakultas.Items.Add("FEB")
    End Sub

    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim nip As Long
        If Not Long.TryParse(txtNIP.Text.Trim(), nip) Then
            Exit Sub
        End If
        Dim nama As String = txtNama.Text.Trim()
        Dim fakultas As String = cbFakultas.Text.Trim()
        Dim jurusan As String = cbJurusan.Text.Trim()
        Dim tugas As Double = Double.Parse(txtTugas.Text)
        Dim uts As Double = Double.Parse(txtUTS.Text)
        Dim uas As Double = Double.Parse(txtUAS.Text)

        Dim total As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        Dim grade As String
        Select Case total
            Case Is >= 78
                grade = "A"
            Case Is >= 65
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 40
                grade = "D"
            Case Else
                grade = "E"
        End Select

        Dim jenisKelamin As String = ""
        If rbL.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rbP.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan & vbCrLf &
                        "Nilai Akhir: " & total.ToString("F2") & vbCrLf &
                        "GRADE: " & grade,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub cbfakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFakultas.SelectedIndexChanged
        Dim fakultas As String = cbFakultas.SelectedItem
        cbJurusan.Items.Clear()
        Select Case (fakultas)
            Case "FMIPA"
                cbJurusan.Items.Add("Sistem Informasi")
                cbJurusan.Items.Add("Manajemen Informatika")
                cbJurusan.Items.Add("Ilmu Komputer")
            Case "FKIP"
                cbJurusan.Items.Add("Pendidikan Teknologi Informasi")
                cbJurusan.Items.Add("Pendidikan Kimia")
                cbJurusan.Items.Add("Pendidikan Ekonomi")

            Case "FEB"
                cbJurusan.Items.Add("Akuntansi")
                cbJurusan.Items.Add("Manajemen Bisnis")
                cbJurusan.Items.Add("Bisnis Digital")
        End Select
    End Sub

    Private Sub rbP_CheckedChanged(sender As Object, e As EventArgs) Handles rbP.CheckedChanged

    End Sub
End Class