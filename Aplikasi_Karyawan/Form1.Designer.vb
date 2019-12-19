<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BtnINSERT = New System.Windows.Forms.Button
        Me.BTNCLOSE = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Maroon
        Me.DataGridView1.Size = New System.Drawing.Size(699, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnINSERT
        '
        Me.BtnINSERT.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnINSERT.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnINSERT.Image = CType(resources.GetObject("BtnINSERT.Image"), System.Drawing.Image)
        Me.BtnINSERT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnINSERT.Location = New System.Drawing.Point(12, 12)
        Me.BtnINSERT.Name = "BtnINSERT"
        Me.BtnINSERT.Size = New System.Drawing.Size(242, 105)
        Me.BtnINSERT.TabIndex = 1
        Me.BtnINSERT.Text = "INSERT"
        Me.BtnINSERT.UseVisualStyleBackColor = True
        '
        'BTNCLOSE
        '
        Me.BTNCLOSE.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLOSE.ForeColor = System.Drawing.Color.DarkRed
        Me.BTNCLOSE.Image = CType(resources.GetObject("BTNCLOSE.Image"), System.Drawing.Image)
        Me.BTNCLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLOSE.Location = New System.Drawing.Point(311, 64)
        Me.BTNCLOSE.Name = "BTNCLOSE"
        Me.BTNCLOSE.Size = New System.Drawing.Size(154, 84)
        Me.BTNCLOSE.TabIndex = 3
        Me.BTNCLOSE.Text = "CLOSE"
        Me.BTNCLOSE.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(107, 26)
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.Menu1ToolStripMenuItem.Text = "delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(749, 500)
        Me.Controls.Add(Me.BTNCLOSE)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnINSERT)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnINSERT As System.Windows.Forms.Button
    Friend WithEvents BTNCLOSE As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Menu1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
