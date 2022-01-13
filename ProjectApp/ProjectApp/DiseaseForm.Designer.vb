<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiseaseForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DB_AplikasiaccdbDataSet = New ProjectApp.DB_AplikasiaccdbDataSet()
        Me.TBDISEASEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_DISEASETableAdapter = New ProjectApp.DB_AplikasiaccdbDataSetTableAdapters.TB_DISEASETableAdapter()
        Me.DiaseidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasesolutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasedescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBDISEASEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiaseidDataGridViewTextBoxColumn, Me.DiasenameDataGridViewTextBoxColumn, Me.DiasesolutionDataGridViewTextBoxColumn, Me.DiasecodeDataGridViewTextBoxColumn, Me.DiasedescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBDISEASEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(760, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DB_AplikasiaccdbDataSet
        '
        Me.DB_AplikasiaccdbDataSet.DataSetName = "DB_AplikasiaccdbDataSet"
        Me.DB_AplikasiaccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBDISEASEBindingSource
        '
        Me.TBDISEASEBindingSource.DataMember = "TB_DISEASE"
        Me.TBDISEASEBindingSource.DataSource = Me.DB_AplikasiaccdbDataSet
        '
        'TB_DISEASETableAdapter
        '
        Me.TB_DISEASETableAdapter.ClearBeforeFill = True
        '
        'DiaseidDataGridViewTextBoxColumn
        '
        Me.DiaseidDataGridViewTextBoxColumn.DataPropertyName = "diase_id"
        Me.DiaseidDataGridViewTextBoxColumn.HeaderText = "diase_id"
        Me.DiaseidDataGridViewTextBoxColumn.Name = "DiaseidDataGridViewTextBoxColumn"
        '
        'DiasenameDataGridViewTextBoxColumn
        '
        Me.DiasenameDataGridViewTextBoxColumn.DataPropertyName = "diase_name"
        Me.DiasenameDataGridViewTextBoxColumn.HeaderText = "diase_name"
        Me.DiasenameDataGridViewTextBoxColumn.Name = "DiasenameDataGridViewTextBoxColumn"
        '
        'DiasesolutionDataGridViewTextBoxColumn
        '
        Me.DiasesolutionDataGridViewTextBoxColumn.DataPropertyName = "diase_solution"
        Me.DiasesolutionDataGridViewTextBoxColumn.HeaderText = "diase_solution"
        Me.DiasesolutionDataGridViewTextBoxColumn.Name = "DiasesolutionDataGridViewTextBoxColumn"
        '
        'DiasecodeDataGridViewTextBoxColumn
        '
        Me.DiasecodeDataGridViewTextBoxColumn.DataPropertyName = "diase_code"
        Me.DiasecodeDataGridViewTextBoxColumn.HeaderText = "diase_code"
        Me.DiasecodeDataGridViewTextBoxColumn.Name = "DiasecodeDataGridViewTextBoxColumn"
        '
        'DiasedescriptionDataGridViewTextBoxColumn
        '
        Me.DiasedescriptionDataGridViewTextBoxColumn.DataPropertyName = "diase_description"
        Me.DiasedescriptionDataGridViewTextBoxColumn.HeaderText = "diase_description"
        Me.DiasedescriptionDataGridViewTextBoxColumn.Name = "DiasedescriptionDataGridViewTextBoxColumn"
        '
        'DiseaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DiseaseForm"
        Me.Text = "Form Disease - Cows Disease Expert System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBDISEASEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_AplikasiaccdbDataSet As DB_AplikasiaccdbDataSet
    Friend WithEvents TBDISEASEBindingSource As BindingSource
    Friend WithEvents TB_DISEASETableAdapter As DB_AplikasiaccdbDataSetTableAdapters.TB_DISEASETableAdapter
    Friend WithEvents DiaseidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasesolutionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasedescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
