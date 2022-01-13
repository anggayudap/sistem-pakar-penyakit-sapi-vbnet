<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SymptomForm
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DB_AplikasiaccdbDataSet = New ProjectApp.DB_AplikasiaccdbDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_SYMPTOMTableAdapter = New ProjectApp.DB_AplikasiaccdbDataSetTableAdapters.TB_SYMPTOMTableAdapter()
        Me.SymptomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SymptomidDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.DataSource = Me.BindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(12, 399)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(760, 150)
        Me.DataGridView2.TabIndex = 0
        '
        'DB_AplikasiaccdbDataSet
        '
        Me.DB_AplikasiaccdbDataSet.DataSetName = "DB_AplikasiaccdbDataSet"
        Me.DB_AplikasiaccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "TB_SYMPTOM"
        Me.BindingSource1.DataSource = Me.DB_AplikasiaccdbDataSet
        '
        'TB_SYMPTOMTableAdapter
        '
        Me.TB_SYMPTOMTableAdapter.ClearBeforeFill = True
        '
        'SymptomidDataGridViewTextBoxColumn
        '
        Me.SymptomidDataGridViewTextBoxColumn.DataPropertyName = "symptom_id"
        Me.SymptomidDataGridViewTextBoxColumn.HeaderText = "symptom_id"
        Me.SymptomidDataGridViewTextBoxColumn.Name = "SymptomidDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "symptom_code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "symptom_code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "symptom_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "symptom_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SymptomForm
        '
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "SymptomForm"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DBAplikasiaccdbDataSetBindingSource As BindingSource
    Friend WithEvents TBDISEASEBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBSYMPTOMBindingSource As BindingSource
    Friend WithEvents SymptomcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SymptomnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DB_AplikasiaccdbDataSet As DB_AplikasiaccdbDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TB_SYMPTOMTableAdapter As DB_AplikasiaccdbDataSetTableAdapters.TB_SYMPTOMTableAdapter
    Friend WithEvents SymptomidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
