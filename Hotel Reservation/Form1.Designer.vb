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
        GroupBox1 = New GroupBox()
        txtBiaya = New TextBox()
        txtLama = New TextBox()
        txtHarga = New TextBox()
        cbJenis = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        txtAlamat = New TextBox()
        txtTelp = New TextBox()
        txtNama = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        btnClose = New Button()
        btnNew = New Button()
        GroupBox4 = New GroupBox()
        txtKembali = New TextBox()
        txtJumlah = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Label13 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveBorder
        GroupBox1.Controls.Add(txtBiaya)
        GroupBox1.Controls.Add(txtLama)
        GroupBox1.Controls.Add(txtHarga)
        GroupBox1.Controls.Add(cbJenis)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(483, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(349, 242)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Booking Price"
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(138, 169)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(183, 23)
        txtBiaya.TabIndex = 7
        ' 
        ' txtLama
        ' 
        txtLama.Location = New Point(138, 119)
        txtLama.Name = "txtLama"
        txtLama.Size = New Size(183, 23)
        txtLama.TabIndex = 6
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(138, 75)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(183, 23)
        txtHarga.TabIndex = 5
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Items.AddRange(New Object() {"VIP", "Kelas I", "Kelas II", "Kelas III"})
        cbJenis.Location = New Point(138, 32)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(183, 23)
        cbJenis.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 172)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 15)
        Label9.TabIndex = 3
        Label9.Text = "Biaya Sewa"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 15)
        Label8.TabIndex = 2
        Label8.Text = "Lama Menginap"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 15)
        Label7.TabIndex = 1
        Label7.Text = "Harga Sewa Perhari"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 15)
        Label6.TabIndex = 0
        Label6.Text = "Jenis Kamar"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ScrollBar
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(txtAlamat)
        GroupBox2.Controls.Add(txtTelp)
        GroupBox2.Controls.Add(txtNama)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(27, 74)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(432, 242)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Pemesan"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(140, 203)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(157, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(22, 140)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(350, 47)
        txtAlamat.TabIndex = 7
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(22, 96)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(350, 23)
        txtTelp.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(22, 54)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(350, 23)
        txtNama.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 4
        Label5.Text = "Tanggal Booking"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 3
        Label4.Text = "Alamat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nomor Telepon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama Pemesan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ActiveBorder
        GroupBox3.Controls.Add(btnClose)
        GroupBox3.Controls.Add(btnNew)
        GroupBox3.Location = New Point(27, 416)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(432, 76)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Navigasi"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = SystemColors.ActiveCaption
        btnClose.Location = New Point(252, 17)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(106, 48)
        btnClose.TabIndex = 1
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = SystemColors.ActiveCaption
        btnNew.Location = New Point(69, 17)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(103, 48)
        btnNew.TabIndex = 0
        btnNew.Text = "NEW"
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.ActiveBorder
        GroupBox4.Controls.Add(txtKembali)
        GroupBox4.Controls.Add(txtJumlah)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Location = New Point(483, 341)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(349, 151)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Pembayaran"
        ' 
        ' txtKembali
        ' 
        txtKembali.Location = New Point(138, 92)
        txtKembali.Name = "txtKembali"
        txtKembali.Size = New Size(183, 23)
        txtKembali.TabIndex = 10
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(138, 48)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(183, 23)
        txtJumlah.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(16, 95)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 15)
        Label11.TabIndex = 9
        Label11.Text = "Kembalian"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(16, 51)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 15)
        Label10.TabIndex = 8
        Label10.Text = "Jumlah Bayar"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label12.Location = New Point(315, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(273, 37)
        Label12.TabIndex = 8
        Label12.Text = "MOONLIGHT HOTEL"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(30, 341)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(294, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(337, 341)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 24)
        Button1.TabIndex = 10
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(96, 378)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 24)
        Button2.TabIndex = 11
        Button2.Text = "Upload Selected File"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(27, 323)
        Label13.Name = "Label13"
        Label13.Size = New Size(123, 15)
        Label13.TabIndex = 12
        Label13.Text = "*upload KTP pemesan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(847, 516)
        Controls.Add(Label13)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label12)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotel Reservation"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents txtLama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label13 As Label
End Class
