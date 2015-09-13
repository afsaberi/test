<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainform
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Clock = New System.Windows.Forms.TabPage()
        Me.Time = New System.Windows.Forms.Label()
        Me.Alarm1 = New System.Windows.Forms.TabPage()
        Me.Alarm2 = New System.Windows.Forms.TabPage()
        Me.Alarm3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Clock.SuspendLayout()
        Me.Alarm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Clock)
        Me.TabControl1.Controls.Add(Me.Alarm1)
        Me.TabControl1.Controls.Add(Me.Alarm2)
        Me.TabControl1.Controls.Add(Me.Alarm3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(846, 498)
        Me.TabControl1.TabIndex = 1
        '
        'Clock
        '
        Me.Clock.Controls.Add(Me.Time)
        Me.Clock.Location = New System.Drawing.Point(4, 22)
        Me.Clock.Name = "Clock"
        Me.Clock.Padding = New System.Windows.Forms.Padding(3)
        Me.Clock.Size = New System.Drawing.Size(838, 472)
        Me.Clock.TabIndex = 0
        Me.Clock.Text = "Clock"
        Me.Clock.UseVisualStyleBackColor = True
        '
        'Time
        '
        Me.Time.BackColor = System.Drawing.Color.Transparent
        Me.Time.Cursor = System.Windows.Forms.Cursors.No
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.Time.Location = New System.Drawing.Point(80, 138)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(632, 208)
        Me.Time.TabIndex = 0
        '
        'Alarm1
        '
        Me.Alarm1.Controls.Add(Me.Button1)
        Me.Alarm1.Location = New System.Drawing.Point(4, 22)
        Me.Alarm1.Name = "Alarm1"
        Me.Alarm1.Padding = New System.Windows.Forms.Padding(3)
        Me.Alarm1.Size = New System.Drawing.Size(838, 472)
        Me.Alarm1.TabIndex = 1
        Me.Alarm1.Text = "Alarm 1"
        Me.Alarm1.UseVisualStyleBackColor = True
        '
        'Alarm2
        '
        Me.Alarm2.Location = New System.Drawing.Point(4, 22)
        Me.Alarm2.Name = "Alarm2"
        Me.Alarm2.Size = New System.Drawing.Size(838, 472)
        Me.Alarm2.TabIndex = 2
        Me.Alarm2.Text = "Alarm 2"
        Me.Alarm2.UseVisualStyleBackColor = True
        '
        'Alarm3
        '
        Me.Alarm3.Location = New System.Drawing.Point(4, 22)
        Me.Alarm3.Name = "Alarm3"
        Me.Alarm3.Size = New System.Drawing.Size(838, 472)
        Me.Alarm3.TabIndex = 3
        Me.Alarm3.Text = "Alarm 3"
        Me.Alarm3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 544)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Clock.ResumeLayout(False)
        Me.Alarm1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Clock As TabPage
    Friend WithEvents Alarm1 As TabPage
    Friend WithEvents Alarm2 As TabPage
    Friend WithEvents Alarm3 As TabPage
    Friend WithEvents Time As Label
    Friend WithEvents Button1 As Button
End Class
