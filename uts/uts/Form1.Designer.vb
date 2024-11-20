<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenjualan
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
        Me.txtNofaktur = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHJual = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.dtpTglJual = New System.Windows.Forms.DateTimePicker()
        Me.cboKodebrg = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Db_barangDataSet = New WindowsApplication1.db_barangDataSet()
        Me.JUALBRGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JUALBRGTableAdapter = New WindowsApplication1.db_barangDataSetTableAdapters.JUALBRGTableAdapter()
        Me.NOFAKTURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGLJUALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodebrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HJUALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Db_barangDataSet1 = New WindowsApplication1.db_barangDataSet1()
        Me.StokBRGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StokBRGTableAdapter = New WindowsApplication1.db_barangDataSet1TableAdapters.StokBRGTableAdapter()
        Me.KodebrgDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisastokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_barangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JUALBRGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_barangDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StokBRGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNofaktur
        '
        Me.txtNofaktur.Location = New System.Drawing.Point(157, 30)
        Me.txtNofaktur.Name = "txtNofaktur"
        Me.txtNofaktur.Size = New System.Drawing.Size(100, 22)
        Me.txtNofaktur.TabIndex = 0
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(157, 134)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 22)
        Me.txtJumlah.TabIndex = 1
        '
        'txtHJual
        '
        Me.txtHJual.Location = New System.Drawing.Point(157, 167)
        Me.txtHJual.Name = "txtHJual"
        Me.txtHJual.Size = New System.Drawing.Size(100, 22)
        Me.txtHJual.TabIndex = 2
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(157, 207)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 22)
        Me.txtSubtotal.TabIndex = 3
        '
        'dtpTglJual
        '
        Me.dtpTglJual.Location = New System.Drawing.Point(157, 65)
        Me.dtpTglJual.Name = "dtpTglJual"
        Me.dtpTglJual.Size = New System.Drawing.Size(200, 22)
        Me.dtpTglJual.TabIndex = 4
        '
        'cboKodebrg
        '
        Me.cboKodebrg.FormattingEnabled = True
        Me.cboKodebrg.Location = New System.Drawing.Point(157, 99)
        Me.cboKodebrg.Name = "cboKodebrg"
        Me.cboKodebrg.Size = New System.Drawing.Size(121, 24)
        Me.cboKodebrg.TabIndex = 5
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(48, 252)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Save"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "No Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tanggal Jual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Subtotal"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOFAKTURDataGridViewTextBoxColumn, Me.TGLJUALDataGridViewTextBoxColumn, Me.KodebrgDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.HJUALDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JUALBRGBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(37, 442)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1211, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'Db_barangDataSet
        '
        Me.Db_barangDataSet.DataSetName = "db_barangDataSet"
        Me.Db_barangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JUALBRGBindingSource
        '
        Me.JUALBRGBindingSource.DataMember = "JUALBRG"
        Me.JUALBRGBindingSource.DataSource = Me.Db_barangDataSet
        '
        'JUALBRGTableAdapter
        '
        Me.JUALBRGTableAdapter.ClearBeforeFill = True
        '
        'NOFAKTURDataGridViewTextBoxColumn
        '
        Me.NOFAKTURDataGridViewTextBoxColumn.DataPropertyName = "NOFAKTUR"
        Me.NOFAKTURDataGridViewTextBoxColumn.HeaderText = "NOFAKTUR"
        Me.NOFAKTURDataGridViewTextBoxColumn.Name = "NOFAKTURDataGridViewTextBoxColumn"
        '
        'TGLJUALDataGridViewTextBoxColumn
        '
        Me.TGLJUALDataGridViewTextBoxColumn.DataPropertyName = "TGLJUAL"
        Me.TGLJUALDataGridViewTextBoxColumn.HeaderText = "TGLJUAL"
        Me.TGLJUALDataGridViewTextBoxColumn.Name = "TGLJUALDataGridViewTextBoxColumn"
        '
        'KodebrgDataGridViewTextBoxColumn
        '
        Me.KodebrgDataGridViewTextBoxColumn.DataPropertyName = "Kodebrg"
        Me.KodebrgDataGridViewTextBoxColumn.HeaderText = "Kodebrg"
        Me.KodebrgDataGridViewTextBoxColumn.Name = "KodebrgDataGridViewTextBoxColumn"
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        '
        'HJUALDataGridViewTextBoxColumn
        '
        Me.HJUALDataGridViewTextBoxColumn.DataPropertyName = "HJUAL"
        Me.HJUALDataGridViewTextBoxColumn.HeaderText = "HJUAL"
        Me.HJUALDataGridViewTextBoxColumn.Name = "HJUALDataGridViewTextBoxColumn"
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebrgDataGridViewTextBoxColumn1, Me.NamabrgDataGridViewTextBoxColumn, Me.SisastokDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.StokBRGBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(37, 286)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1211, 150)
        Me.DataGridView2.TabIndex = 14
        '
        'Db_barangDataSet1
        '
        Me.Db_barangDataSet1.DataSetName = "db_barangDataSet1"
        Me.Db_barangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StokBRGBindingSource
        '
        Me.StokBRGBindingSource.DataMember = "StokBRG"
        Me.StokBRGBindingSource.DataSource = Me.Db_barangDataSet1
        '
        'StokBRGTableAdapter
        '
        Me.StokBRGTableAdapter.ClearBeforeFill = True
        '
        'KodebrgDataGridViewTextBoxColumn1
        '
        Me.KodebrgDataGridViewTextBoxColumn1.DataPropertyName = "Kodebrg"
        Me.KodebrgDataGridViewTextBoxColumn1.HeaderText = "Kodebrg"
        Me.KodebrgDataGridViewTextBoxColumn1.Name = "KodebrgDataGridViewTextBoxColumn1"
        '
        'NamabrgDataGridViewTextBoxColumn
        '
        Me.NamabrgDataGridViewTextBoxColumn.DataPropertyName = "Namabrg"
        Me.NamabrgDataGridViewTextBoxColumn.HeaderText = "Namabrg"
        Me.NamabrgDataGridViewTextBoxColumn.Name = "NamabrgDataGridViewTextBoxColumn"
        '
        'SisastokDataGridViewTextBoxColumn
        '
        Me.SisastokDataGridViewTextBoxColumn.DataPropertyName = "Sisastok"
        Me.SisastokDataGridViewTextBoxColumn.HeaderText = "Sisastok"
        Me.SisastokDataGridViewTextBoxColumn.Name = "SisastokDataGridViewTextBoxColumn"
        '
        'frmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 617)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cboKodebrg)
        Me.Controls.Add(Me.dtpTglJual)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtHJual)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtNofaktur)
        Me.Name = "frmPenjualan"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_barangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JUALBRGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_barangDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StokBRGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNofaktur As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtHJual As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents dtpTglJual As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboKodebrg As System.Windows.Forms.ComboBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Db_barangDataSet As WindowsApplication1.db_barangDataSet
    Friend WithEvents JUALBRGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JUALBRGTableAdapter As WindowsApplication1.db_barangDataSetTableAdapters.JUALBRGTableAdapter
    Friend WithEvents NOFAKTURDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGLJUALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodebrgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HJUALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Db_barangDataSet1 As WindowsApplication1.db_barangDataSet1
    Friend WithEvents StokBRGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StokBRGTableAdapter As WindowsApplication1.db_barangDataSet1TableAdapters.StokBRGTableAdapter
    Friend WithEvents KodebrgDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamabrgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisastokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
