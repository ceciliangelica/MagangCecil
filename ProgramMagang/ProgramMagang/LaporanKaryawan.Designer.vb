<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanKaryawan
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PegawaiTableAdapter1 = New ProgramMagang.DataSet1TableAdapters.PegawaiTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataSet1 = New ProgramMagang.DataSet1()
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomorPegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempatLahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalLahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorTeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalMasukDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1014, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomorPegawaiDataGridViewTextBoxColumn, Me.NamaPegawaiDataGridViewTextBoxColumn, Me.JenisKelaminDataGridViewTextBoxColumn, Me.TempatLahirDataGridViewTextBoxColumn, Me.TanggalLahirDataGridViewTextBoxColumn, Me.NomorTeleponDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn, Me.TanggalMasukDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PegawaiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(944, 255)
        Me.DataGridView1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PegawaiTableAdapter1
        '
        Me.PegawaiTableAdapter1.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(926, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "Pegawai"
        Me.PegawaiBindingSource.DataSource = Me.DataSet1
        '
        'NomorPegawaiDataGridViewTextBoxColumn
        '
        Me.NomorPegawaiDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Pegawai"
        Me.NomorPegawaiDataGridViewTextBoxColumn.HeaderText = "Nomor_Pegawai"
        Me.NomorPegawaiDataGridViewTextBoxColumn.Name = "NomorPegawaiDataGridViewTextBoxColumn"
        '
        'NamaPegawaiDataGridViewTextBoxColumn
        '
        Me.NamaPegawaiDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pegawai"
        Me.NamaPegawaiDataGridViewTextBoxColumn.HeaderText = "Nama_Pegawai"
        Me.NamaPegawaiDataGridViewTextBoxColumn.Name = "NamaPegawaiDataGridViewTextBoxColumn"
        '
        'JenisKelaminDataGridViewTextBoxColumn
        '
        Me.JenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.Name = "JenisKelaminDataGridViewTextBoxColumn"
        '
        'TempatLahirDataGridViewTextBoxColumn
        '
        Me.TempatLahirDataGridViewTextBoxColumn.DataPropertyName = "Tempat_Lahir"
        Me.TempatLahirDataGridViewTextBoxColumn.HeaderText = "Tempat_Lahir"
        Me.TempatLahirDataGridViewTextBoxColumn.Name = "TempatLahirDataGridViewTextBoxColumn"
        '
        'TanggalLahirDataGridViewTextBoxColumn
        '
        Me.TanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir"
        Me.TanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_Lahir"
        Me.TanggalLahirDataGridViewTextBoxColumn.Name = "TanggalLahirDataGridViewTextBoxColumn"
        '
        'NomorTeleponDataGridViewTextBoxColumn
        '
        Me.NomorTeleponDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Telepon"
        Me.NomorTeleponDataGridViewTextBoxColumn.HeaderText = "Nomor_Telepon"
        Me.NomorTeleponDataGridViewTextBoxColumn.Name = "NomorTeleponDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'JabatanDataGridViewTextBoxColumn
        '
        Me.JabatanDataGridViewTextBoxColumn.DataPropertyName = "Jabatan"
        Me.JabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan"
        Me.JabatanDataGridViewTextBoxColumn.Name = "JabatanDataGridViewTextBoxColumn"
        '
        'TanggalMasukDataGridViewTextBoxColumn
        '
        Me.TanggalMasukDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Masuk"
        Me.TanggalMasukDataGridViewTextBoxColumn.HeaderText = "Tanggal_Masuk"
        Me.TanggalMasukDataGridViewTextBoxColumn.Name = "TanggalMasukDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reset All"
        '
        'LaporanKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1197, 504)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LaporanKaryawan"
        Me.Text = "LaporanKaryawan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PegawaiTableAdapter1 As DataSet1TableAdapters.PegawaiTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents NomorPegawaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPegawaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisKelaminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempatLahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalLahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomorTeleponDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalMasukDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PegawaiBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Label1 As Label
End Class
