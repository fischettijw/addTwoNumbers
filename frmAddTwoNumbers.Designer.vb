<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTwoNumbers
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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(176, 43)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 29)
        Me.txtFirst.TabIndex = 0
        Me.txtFirst.Text = "0"
        Me.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(176, 108)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(100, 29)
        Me.txtSecond.TabIndex = 1
        Me.txtSecond.Text = "0"
        Me.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(175, 178)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 34)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "0"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmAddTwoNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 334)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "frmAddTwoNumbers"
        Me.Text = "Add Two Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents btnAdd As Button
End Class
