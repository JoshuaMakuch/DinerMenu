<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenuForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FishButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(743, 441)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(116, 64)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit Button")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(256, 441)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(116, 64)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "Fish"
        Me.ToolTip1.SetToolTip(Me.FishButton, "Fresh fish for the day")
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(134, 441)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(116, 64)
        Me.SaladButton.TabIndex = 2
        Me.SaladButton.Text = "Salad"
        Me.ToolTip1.SetToolTip(Me.SaladButton, "Chef's Special")
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(12, 441)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(116, 64)
        Me.SoupButton.TabIndex = 1
        Me.SoupButton.Text = "Soup"
        Me.ToolTip1.SetToolTip(Me.SoupButton, "Soup of the day")
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Sylfaen", 48.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.DinerNameLabel.Location = New System.Drawing.Point(160, 9)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(494, 105)
        Me.DinerNameLabel.TabIndex = 5
        Me.DinerNameLabel.Text = "Lurio's Diner"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.AutoSize = True
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(236, 140)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(293, 34)
        Me.DisplaySpecialLabel.TabIndex = 6
        Me.DisplaySpecialLabel.Text = "Welcome to our diner!"
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 517)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "DinerMenuForm"
        Me.Text = "DinerMenuForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FishButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents SoupButton As Button
    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents DisplaySpecialLabel As Label
End Class
