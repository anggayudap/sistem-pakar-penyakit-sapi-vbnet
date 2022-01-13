<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiagnosisForm
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
        Me.checklist = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SymptomcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymptomnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBSYMPTOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_AplikasiaccdbDataSet = New ProjectApp.DB_AplikasiaccdbDataSet()
        Me.TB_SYMPTOMTableAdapter = New ProjectApp.DB_AplikasiaccdbDataSetTableAdapters.TB_SYMPTOMTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBSYMPTOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checklist, Me.SymptomcodeDataGridViewTextBoxColumn, Me.SymptomnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBSYMPTOMBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'checklist
        '
        Me.checklist.HeaderText = "Checklist"
        Me.checklist.Name = "checklist"
        '
        'SymptomcodeDataGridViewTextBoxColumn
        '
        Me.SymptomcodeDataGridViewTextBoxColumn.DataPropertyName = "symptom_code"
        Me.SymptomcodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.SymptomcodeDataGridViewTextBoxColumn.Name = "SymptomcodeDataGridViewTextBoxColumn"
        '
        'SymptomnameDataGridViewTextBoxColumn
        '
        Me.SymptomnameDataGridViewTextBoxColumn.DataPropertyName = "symptom_name"
        Me.SymptomnameDataGridViewTextBoxColumn.HeaderText = "Symptom Name"
        Me.SymptomnameDataGridViewTextBoxColumn.Name = "SymptomnameDataGridViewTextBoxColumn"
        Me.SymptomnameDataGridViewTextBoxColumn.Width = 500
        '
        'TBSYMPTOMBindingSource
        '
        Me.TBSYMPTOMBindingSource.DataMember = "TB_SYMPTOM"
        Me.TBSYMPTOMBindingSource.DataSource = Me.DB_AplikasiaccdbDataSet
        '
        'DB_AplikasiaccdbDataSet
        '
        Me.DB_AplikasiaccdbDataSet.DataSetName = "DB_AplikasiaccdbDataSet"
        Me.DB_AplikasiaccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TB_SYMPTOMTableAdapter
        '
        Me.TB_SYMPTOMTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select and Click Submit Button"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 58)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DiagnosisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DiagnosisForm"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBSYMPTOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_AplikasiaccdbDataSet As DB_AplikasiaccdbDataSet
    Friend WithEvents TBSYMPTOMBindingSource As BindingSource
    Friend WithEvents TB_SYMPTOMTableAdapter As DB_AplikasiaccdbDataSetTableAdapters.TB_SYMPTOMTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents checklist As DataGridViewCheckBoxColumn
    Friend WithEvents SymptomcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SymptomnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
