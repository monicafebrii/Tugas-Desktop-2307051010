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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
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
        Me.Panel2.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvdata)
        Me.Panel2.Location = New System.Drawing.Point(42, 541)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(972, 178)
        Me.Panel2.TabIndex = 105
        '
        'dgvdata
        '
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(10, 3)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(956, 165)
        Me.dgvdata.TabIndex = 4
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "NIP"
        Me.dgnip.Name = "dgnip"
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "Nama"
        Me.dgnama.Name = "dgnama"
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "GRADE"
        Me.dggrade.Name = "dggrade"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.btnnew)
        Me.Panel3.Location = New System.Drawing.Point(39, 450)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(969, 74)
        Me.Panel3.TabIndex = 104
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.LightCoral
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(520, 17)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(418, 37)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(272, 20)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(224, 37)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(134, 20)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(130, 37)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(3, 20)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(123, 37)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(494, 333)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(62, 26)
        Me.txtUAS.TabIndex = 103
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(360, 333)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(62, 26)
        Me.txtUTS.TabIndex = 102
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(220, 333)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(61, 26)
        Me.txtTugas.TabIndex = 101
        '
        'lblGRADE
        '
        Me.lblGRADE.AutoSize = True
        Me.lblGRADE.Location = New System.Drawing.Point(579, 336)
        Me.lblGRADE.Name = "lblGRADE"
        Me.lblGRADE.Size = New System.Drawing.Size(86, 20)
        Me.lblGRADE.TabIndex = 100
        Me.lblGRADE.Text = "- GRADE -"
        '
        'lblUAS
        '
        Me.lblUAS.AutoSize = True
        Me.lblUAS.Location = New System.Drawing.Point(444, 336)
        Me.lblUAS.Name = "lblUAS"
        Me.lblUAS.Size = New System.Drawing.Size(43, 20)
        Me.lblUAS.TabIndex = 99
        Me.lblUAS.Text = "UAS"
        '
        'lblUTS
        '
        Me.lblUTS.AutoSize = True
        Me.lblUTS.Location = New System.Drawing.Point(304, 336)
        Me.lblUTS.Name = "lblUTS"
        Me.lblUTS.Size = New System.Drawing.Size(41, 20)
        Me.lblUTS.TabIndex = 98
        Me.lblUTS.Text = "UTS"
        '
        'lblTugas
        '
        Me.lblTugas.AutoSize = True
        Me.lblTugas.Location = New System.Drawing.Point(158, 336)
        Me.lblTugas.Name = "lblTugas"
        Me.lblTugas.Size = New System.Drawing.Size(53, 20)
        Me.lblTugas.TabIndex = 97
        Me.lblTugas.Text = "Tugas"
        '
        'btnNilai
        '
        Me.btnNilai.AutoSize = True
        Me.btnNilai.Location = New System.Drawing.Point(38, 336)
        Me.btnNilai.Name = "btnNilai"
        Me.btnNilai.Size = New System.Drawing.Size(38, 20)
        Me.btnNilai.TabIndex = 96
        Me.btnNilai.Text = "Nilai"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(69, 393)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(182, 32)
        Me.btnProses.TabIndex = 95
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Location = New System.Drawing.Point(38, 149)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(106, 20)
        Me.lblJenisKelamin.TabIndex = 94
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(296, 144)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(116, 24)
        Me.rbP.TabIndex = 93
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(162, 144)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(97, 24)
        Me.rbL.TabIndex = 92
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'cbJurusan
        '
        Me.cbJurusan.FormattingEnabled = True
        Me.cbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cbJurusan.Location = New System.Drawing.Point(162, 266)
        Me.cbJurusan.Name = "cbJurusan"
        Me.cbJurusan.Size = New System.Drawing.Size(426, 28)
        Me.cbJurusan.TabIndex = 91
        '
        'cbFakultas
        '
        Me.cbFakultas.FormattingEnabled = True
        Me.cbFakultas.Location = New System.Drawing.Point(162, 199)
        Me.cbFakultas.Name = "cbFakultas"
        Me.cbFakultas.Size = New System.Drawing.Size(426, 28)
        Me.cbFakultas.TabIndex = 90
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(162, 87)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(426, 26)
        Me.txtNama.TabIndex = 89
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(162, 30)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(426, 26)
        Me.txtNIP.TabIndex = 88
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(38, 266)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(66, 20)
        Me.lblJurusan.TabIndex = 87
        Me.lblJurusan.Text = "Jurusan"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(38, 207)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(70, 20)
        Me.lblFakultas.TabIndex = 86
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(38, 93)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(51, 20)
        Me.lblNama.TabIndex = 85
        Me.lblNama.Text = "Nama"
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.Location = New System.Drawing.Point(38, 33)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(35, 20)
        Me.lblNIP.TabIndex = 84
        Me.lblNIP.Text = "NIP"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 761)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
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
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
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
