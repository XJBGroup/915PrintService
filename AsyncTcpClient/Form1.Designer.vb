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
        Me.connectButton = New System.Windows.Forms.Button()
        Me.inputTextBox = New System.Windows.Forms.RichTextBox()
        Me.sendButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ip = New System.Windows.Forms.TextBox()
        Me.port = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'connectButton
        '
        Me.connectButton.Location = New System.Drawing.Point(45, 295)
        Me.connectButton.Name = "connectButton"
        Me.connectButton.Size = New System.Drawing.Size(91, 39)
        Me.connectButton.TabIndex = 0
        Me.connectButton.Text = "Connect"
        Me.connectButton.UseVisualStyleBackColor = True
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(18, 12)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(316, 210)
        Me.inputTextBox.TabIndex = 1
        Me.inputTextBox.Text = ""
        '
        'sendButton
        '
        Me.sendButton.Location = New System.Drawing.Point(186, 295)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(91, 39)
        Me.sendButton.TabIndex = 2
        Me.sendButton.Text = "Send"
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bind IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bind Port"
        '
        'ip
        '
        Me.ip.Location = New System.Drawing.Point(124, 228)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(134, 21)
        Me.ip.TabIndex = 5
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(124, 267)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(134, 21)
        Me.port.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 361)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.connectButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents connectButton As Button
    Friend WithEvents inputTextBox As RichTextBox
    Friend WithEvents sendButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ip As TextBox
    Friend WithEvents port As TextBox
End Class
