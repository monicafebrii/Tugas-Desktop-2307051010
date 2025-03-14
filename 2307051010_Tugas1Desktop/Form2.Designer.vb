<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.lblGRADE = New System.Windows.Forms.Label()
        Me.lblUAS = New System.Windows.Forms.Label()
        Me.lblUTS = New System.Windows.Forms.Label()
        Me.lblTugas = New System.Windows.Forms.Label()
        Me.btnNilai = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.cbJurusan = New System.Windows.Forms.ComboBox()
        Me.cbFakultas = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(475, 325)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(62, 26)
        Me.txtUAS.TabIndex = 39
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(342, 325)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(62, 26)
        Me.txtUTS.TabIndex = 38
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(203, 325)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(61, 26)
        Me.txtTugas.TabIndex = 37
        '
        'lblGRADE
        '
        Me.lblGRADE.AutoSize = True
        Me.lblGRADE.Location = New System.Drawing.Point(561, 328)
        Me.lblGRADE.Name = "lblGRADE"
        Me.lblGRADE.Size = New System.Drawing.Size(86, 20)
        Me.lblGRADE.TabIndex = 36
        Me.lblGRADE.Text = "- GRADE -"
        '
        'lblUAS
        '
        Me.lblUAS.AutoSize = True
        Me.lblUAS.Location = New System.Drawing.Point(426, 328)
        Me.lblUAS.Name = "lblUAS"
        Me.lblUAS.Size = New System.Drawing.Size(43, 20)
        Me.lblUAS.TabIndex = 35
        Me.lblUAS.Text = "UAS"
        '
        'lblUTS
        '
        Me.lblUTS.AutoSize = True
        Me.lblUTS.Location = New System.Drawing.Point(286, 328)
        Me.lblUTS.Name = "lblUTS"
        Me.lblUTS.Size = New System.Drawing.Size(41, 20)
        Me.lblUTS.TabIndex = 34
        Me.lblUTS.Text = "UTS"
        '
        'lblTugas
        '
        Me.lblTugas.AutoSize = True
        Me.lblTugas.Location = New System.Drawing.Point(140, 328)
        Me.lblTugas.Name = "lblTugas"
        Me.lblTugas.Size = New System.Drawing.Size(53, 20)
        Me.lblTugas.TabIndex = 33
        Me.lblTugas.Text = "Tugas"
        '
        'btnNilai
        '
        Me.btnNilai.AutoSize = True
        Me.btnNilai.Location = New System.Drawing.Point(20, 328)
        Me.btnNilai.Name = "btnNilai"
        Me.btnNilai.Size = New System.Drawing.Size(38, 20)
        Me.btnNilai.TabIndex = 32
        Me.btnNilai.Text = "Nilai"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(14, 407)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(112, 31)
        Me.btnProses.TabIndex = 31
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Location = New System.Drawing.Point(20, 140)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(106, 20)
        Me.lblJenisKelamin.TabIndex = 30
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(277, 136)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(116, 24)
        Me.rbP.TabIndex = 29
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(144, 136)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(97, 24)
        Me.rbL.TabIndex = 28
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'cbJurusan
        '
        Me.cbJurusan.FormattingEnabled = True
        Me.cbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cbJurusan.Location = New System.Drawing.Point(144, 257)
        Me.cbJurusan.Name = "cbJurusan"
        Me.cbJurusan.Size = New System.Drawing.Size(425, 28)
        Me.cbJurusan.TabIndex = 27
        '
        'cbFakultas
        '
        Me.cbFakultas.FormattingEnabled = True
        Me.cbFakultas.Items.AddRange(New Object() {"FMIPA", "FEB", "FKIP"})
        Me.cbFakultas.Location = New System.Drawing.Point(144, 191)
        Me.cbFakultas.Name = "cbFakultas"
        Me.cbFakultas.Size = New System.Drawing.Size(425, 28)
        Me.cbFakultas.TabIndex = 26
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(144, 78)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(425, 26)
        Me.txtNama.TabIndex = 25
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(144, 21)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(425, 26)
        Me.txtNIP.TabIndex = 24
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(20, 257)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(66, 20)
        Me.lblJurusan.TabIndex = 23
        Me.lblJurusan.Text = "Jurusan"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(20, 199)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(70, 20)
        Me.lblFakultas.TabIndex = 22
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(20, 84)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(51, 20)
        Me.lblNama.TabIndex = 21
        Me.lblNama.Text = "Nama"
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.Location = New System.Drawing.Point(20, 24)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(35, 20)
        Me.lblNIP.TabIndex = 20
        Me.lblNIP.Text = "NIP"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 458)
        Me.Controls.Add(Me.txtUAS)
        Me.Controls.Add(Me.txtUTS)
        Me.Controls.Add(Me.txtTugas)
        Me.Controls.Add(Me.lblGRADE)
        Me.Controls.Add(Me.lblUAS)
        Me.Controls.Add(Me.lblUTS)
        Me.Controls.Add(Me.lblTugas)
        Me.Controls.Add(Me.btnNilai)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.lblJenisKelamin)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.cbJurusan)
        Me.Controls.Add(Me.cbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblFakultas)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNIP)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents lblGRADE As System.Windows.Forms.Label
    Friend WithEvents lblUAS As System.Windows.Forms.Label
    Friend WithEvents lblUTS As System.Windows.Forms.Label
    Friend WithEvents lblTugas As System.Windows.Forms.Label
    Friend WithEvents btnNilai As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents lblJenisKelamin As System.Windows.Forms.Label
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents cbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents lblFakultas As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblNIP As System.Windows.Forms.Label
End Class
