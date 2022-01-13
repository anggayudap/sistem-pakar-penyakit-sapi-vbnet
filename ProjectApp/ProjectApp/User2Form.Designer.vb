<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User2Form
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
        Me.TBUSERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_AplikasiaccdbDataSet = New ProjectApp.DB_AplikasiaccdbDataSet()
        Me.DBAplikasiaccdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_USERTableAdapter = New ProjectApp.DB_AplikasiaccdbDataSetTableAdapters.TB_USERTableAdapter()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminlevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBUSERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBAplikasiaccdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseridDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.AdminlevelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBUSERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 399)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(760, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'TBUSERBindingSource
        '
        Me.TBUSERBindingSource.DataMember = "TB_USER"
        Me.TBUSERBindingSource.DataSource = Me.DB_AplikasiaccdbDataSet
        '
        'DB_AplikasiaccdbDataSet
        '
        Me.DB_AplikasiaccdbDataSet.DataSetName = "DB_AplikasiaccdbDataSet"
        Me.DB_AplikasiaccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBAplikasiaccdbDataSetBindingSource
        '
        Me.DBAplikasiaccdbDataSetBindingSource.DataSource = Me.DB_AplikasiaccdbDataSet
        Me.DBAplikasiaccdbDataSetBindingSource.Position = 0
        '
        'TB_USERTableAdapter
        '
        Me.TB_USERTableAdapter.ClearBeforeFill = True
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'AdminlevelDataGridViewTextBoxColumn
        '
        Me.AdminlevelDataGridViewTextBoxColumn.DataPropertyName = "admin_level"
        Me.AdminlevelDataGridViewTextBoxColumn.HeaderText = "Admin Level"
        Me.AdminlevelDataGridViewTextBoxColumn.Name = "AdminlevelDataGridViewTextBoxColumn"
        '
        'User2Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "User2Form"
        Me.Text = "User Form - Cows Disease Expert System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBUSERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_AplikasiaccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBAplikasiaccdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBAplikasiaccdbDataSetBindingSource As BindingSource
    Friend WithEvents DB_AplikasiaccdbDataSet As DB_AplikasiaccdbDataSet
    Friend WithEvents TBUSERBindingSource As BindingSource
    Friend WithEvents TB_USERTableAdapter As DB_AplikasiaccdbDataSetTableAdapters.TB_USERTableAdapter
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminlevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
