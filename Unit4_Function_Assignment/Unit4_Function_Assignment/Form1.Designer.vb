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
        Me.Retailbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Costlbl = New System.Windows.Forms.Label()
        Me.Marklbl = New System.Windows.Forms.Label()
        Me.Retaillbl = New System.Windows.Forms.Label()
        Me.WholesaleCosttxt = New System.Windows.Forms.TextBox()
        Me.Marktxt = New System.Windows.Forms.TextBox()
        Me.Retailtxt = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Retailbtn
        '
        Me.Retailbtn.Location = New System.Drawing.Point(80, 299)
        Me.Retailbtn.Name = "Retailbtn"
        Me.Retailbtn.Size = New System.Drawing.Size(116, 45)
        Me.Retailbtn.TabIndex = 0
        Me.Retailbtn.Text = "Get Retail"
        Me.Retailbtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(227, 301)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(121, 42)
        Me.Exitbtn.TabIndex = 1
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Costlbl
        '
        Me.Costlbl.AutoSize = True
        Me.Costlbl.Location = New System.Drawing.Point(12, 30)
        Me.Costlbl.Name = "Costlbl"
        Me.Costlbl.Size = New System.Drawing.Size(155, 17)
        Me.Costlbl.TabIndex = 2
        Me.Costlbl.Text = "Wholesale Cost Of Item"
        '
        'Marklbl
        '
        Me.Marklbl.AutoSize = True
        Me.Marklbl.Location = New System.Drawing.Point(48, 94)
        Me.Marklbl.Name = "Marklbl"
        Me.Marklbl.Size = New System.Drawing.Size(71, 17)
        Me.Marklbl.TabIndex = 3
        Me.Marklbl.Text = "Markup %"
        '
        'Retaillbl
        '
        Me.Retaillbl.AutoSize = True
        Me.Retaillbl.Location = New System.Drawing.Point(46, 161)
        Me.Retaillbl.Name = "Retaillbl"
        Me.Retaillbl.Size = New System.Drawing.Size(80, 17)
        Me.Retaillbl.TabIndex = 4
        Me.Retaillbl.Text = "Retail Price"
        '
        'WholesaleCosttxt
        '
        Me.WholesaleCosttxt.Location = New System.Drawing.Point(214, 30)
        Me.WholesaleCosttxt.Name = "WholesaleCosttxt"
        Me.WholesaleCosttxt.Size = New System.Drawing.Size(121, 22)
        Me.WholesaleCosttxt.TabIndex = 5
        '
        'Marktxt
        '
        Me.Marktxt.Location = New System.Drawing.Point(214, 95)
        Me.Marktxt.Name = "Marktxt"
        Me.Marktxt.Size = New System.Drawing.Size(121, 22)
        Me.Marktxt.TabIndex = 6
        '
        'Retailtxt
        '
        Me.Retailtxt.Location = New System.Drawing.Point(214, 156)
        Me.Retailtxt.Name = "Retailtxt"
        Me.Retailtxt.ReadOnly = True
        Me.Retailtxt.Size = New System.Drawing.Size(121, 22)
        Me.Retailtxt.TabIndex = 7
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(33, 230)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(383, 30)
        Me.lblMessage.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 376)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Retailtxt)
        Me.Controls.Add(Me.Marktxt)
        Me.Controls.Add(Me.WholesaleCosttxt)
        Me.Controls.Add(Me.Retaillbl)
        Me.Controls.Add(Me.Marklbl)
        Me.Controls.Add(Me.Costlbl)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Retailbtn)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Retailbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents Costlbl As Label
    Friend WithEvents Marklbl As Label
    Friend WithEvents Retaillbl As Label
    Friend WithEvents WholesaleCosttxt As TextBox
    Friend WithEvents Marktxt As TextBox
    Friend WithEvents Retailtxt As TextBox
    Friend WithEvents lblMessage As Label
End Class
