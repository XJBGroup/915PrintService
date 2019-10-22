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
        Me.clientListBox = New System.Windows.Forms.ListBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.port = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.RichTextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'clientListBox
        '
        Me.clientListBox.FormattingEnabled = True
        Me.clientListBox.ItemHeight = 12
        Me.clientListBox.Location = New System.Drawing.Point(5, 7)
        Me.clientListBox.Name = "clientListBox"
        Me.clientListBox.Size = New System.Drawing.Size(149, 316)
        Me.clientListBox.TabIndex = 0
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(173, 285)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 38)
        Me.startButton.TabIndex = 2
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(233, 253)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(143, 21)
        Me.port.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Port"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(173, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(231, 136)
        Me.ListBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Local IP"
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(173, 178)
        Me.output.Name = "output"
        Me.output.ReadOnly = True
        Me.output.Size = New System.Drawing.Size(226, 69)
        Me.output.TabIndex = 9
        Me.output.Text = ""
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 337)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.clientListBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clientListBox As ListBox
    Friend WithEvents startButton As Button
    Friend WithEvents port As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents output As RichTextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
