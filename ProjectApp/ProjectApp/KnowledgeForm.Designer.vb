<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KnowledgeForm
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
        Me.TBKNOWLEDGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_KNOWLEDGETableAdapter = New ProjectApp.DB_AplikasiaccdbDataSetTableAdapters.TB_KNOWLEDGETableAdapter()
        Me.KnowledgeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymptomcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBKNOWLEDGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KnowledgeidDataGridViewTextBoxColumn, Me.DiasecodeDataGridViewTextBoxColumn, Me.SymptomcodeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBKNOWLEDGEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(760, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DB_AplikasiaccdbDataSet
        '
        Me.DB_AplikasiaccdbDataSet.DataSetName = "DB_AplikasiaccdbDataSet"
        Me.DB_AplikasiaccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBKNOWLEDGEBindingSource
        '
        Me.TBKNOWLEDGEBindingSource.DataMember = "TB_KNOWLEDGE"
        Me.TBKNOWLEDGEBindingSource.DataSource = Me.DB_AplikasiaccdbDataSet
        '
        'TB_KNOWLEDGETableAdapter
        '
        Me.TB_KNOWLEDGETableAdapter.ClearBeforeFill = True
        '
        'KnowledgeidDataGridViewTextBoxColumn
        '
        Me.KnowledgeidDataGridViewTextBoxColumn.DataPropertyName = "knowledge_id"
        Me.KnowledgeidDataGridViewTextBoxColumn.HeaderText = "knowledge_id"
        Me.KnowledgeidDataGridViewTextBoxColumn.Name = "KnowledgeidDataGridViewTextBoxColumn"
        '
        'DiasecodeDataGridViewTextBoxColumn
        '
        Me.DiasecodeDataGridViewTextBoxColumn.DataPropertyName = "diase_code"
        Me.DiasecodeDataGridViewTextBoxColumn.HeaderText = "diase_code"
        Me.DiasecodeDataGridViewTextBoxColumn.Name = "DiasecodeDataGridViewTextBoxColumn"
        '
        'SymptomcodeDataGridViewTextBoxColumn
        '
        Me.SymptomcodeDataGridViewTextBoxColumn.DataPropertyName = "symptom_code"
        Me.SymptomcodeDataGridViewTextBoxColumn.HeaderText = "symptom_code"
        Me.SymptomcodeDataGridViewTextBoxColumn.Name = "SymptomcodeDataGridViewTextBoxColumn"
        '
        'KnowledgeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "KnowledgeForm"
        Me.Text = "Knowledge Form  - Cows Disease Expert System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBKNOWLEDGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_AplikasiaccdbDataSet As DB_AplikasiaccdbDataSet
    Friend WithEvents TBKNOWLEDGEBindingSource As BindingSource
    Friend WithEvents TB_KNOWLEDGETableAdapter As DB_AplikasiaccdbDataSetTableAdapters.TB_KNOWLEDGETableAdapter
    Friend WithEvents KnowledgeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SymptomcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
