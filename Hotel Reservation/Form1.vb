Imports System.IO

Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub cbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        Select Case cbJenis.Text
            Case "VIP"
                txtHarga.Text = 750000
            Case "Kelas I"
                txtHarga.Text = 500000
            Case "Kelas II"
                txtHarga.Text = 350000
            Case "Kelas III"
                txtHarga.Text = 250000

        End Select
    End Sub

    Private Sub txtLama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtBiaya.Focus()

            Dim A, B, C As New Long
            A = Val(txtHarga.Text)
            B = Val(txtLama.Text)

            C = A * B
            txtBiaya.Text = C
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKembali.Focus()

            Dim D, C, F As New Long
            D = Val(txtJumlah.Text)
            C = Val(txtBiaya.Text)

            F = D - C
            txtKembali.Text = F
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLama.Focus()

        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNama.Focus()

        End If
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTelp.Focus()

        End If
    End Sub

    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtAlamat.Focus()

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.txtNama.Text = ""
        Me.txtTelp.Text = ""
        Me.txtAlamat.Text = ""
        Me.cbJenis.Text = ""
        Me.txtHarga.Text = ""
        Me.txtLama.Text = ""
        Me.txtBiaya.Text = ""
        Me.txtJumlah.Text = ""
        Me.txtKembali.Text = ""
        Me.txtNama.Focus()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Browse
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            ' Test result.
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'File upload
        Dim FilenameName As String()
        FilenameName = OpenFileDialog1.FileName.Split("\"c)
        File.Copy(OpenFileDialog1.FileName, "Upload\" + FilenameName(FilenameName.Length - 1))
        MessageBox.Show("File Uploaded")
    End Sub
End Class
