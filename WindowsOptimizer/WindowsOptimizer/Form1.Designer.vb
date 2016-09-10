<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowsOptimizerForm
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
        Me.BasicControlsLabel = New System.Windows.Forms.Label()
        Me.RunAllButton = New System.Windows.Forms.Button()
        Me.AddRemoveProgramsButton = New System.Windows.Forms.Button()
        Me.PowerOptionsButton = New System.Windows.Forms.Button()
        Me.DiskDefragmentButton = New System.Windows.Forms.Button()
        Me.DiskCleanupButton = New System.Windows.Forms.Button()
        Me.PerformanceOptionsButton = New System.Windows.Forms.Button()
        Me.AdvancedControlsLabel = New System.Windows.Forms.Label()
        Me.OpenGodmodeButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BasicControlsLabel
        '
        Me.BasicControlsLabel.AutoSize = True
        Me.BasicControlsLabel.Location = New System.Drawing.Point(13, 13)
        Me.BasicControlsLabel.Name = "BasicControlsLabel"
        Me.BasicControlsLabel.Size = New System.Drawing.Size(74, 13)
        Me.BasicControlsLabel.TabIndex = 0
        Me.BasicControlsLabel.Text = "Basic Controls"
        '
        'RunAllButton
        '
        Me.RunAllButton.Location = New System.Drawing.Point(13, 30)
        Me.RunAllButton.Name = "RunAllButton"
        Me.RunAllButton.Size = New System.Drawing.Size(126, 23)
        Me.RunAllButton.TabIndex = 1
        Me.RunAllButton.Text = "Run All"
        Me.RunAllButton.UseVisualStyleBackColor = True
        '
        'AddRemoveProgramsButton
        '
        Me.AddRemoveProgramsButton.Location = New System.Drawing.Point(13, 90)
        Me.AddRemoveProgramsButton.Name = "AddRemoveProgramsButton"
        Me.AddRemoveProgramsButton.Size = New System.Drawing.Size(126, 23)
        Me.AddRemoveProgramsButton.TabIndex = 3
        Me.AddRemoveProgramsButton.Text = "Add/Remove Programs"
        Me.AddRemoveProgramsButton.UseVisualStyleBackColor = True
        '
        'PowerOptionsButton
        '
        Me.PowerOptionsButton.Location = New System.Drawing.Point(13, 208)
        Me.PowerOptionsButton.Name = "PowerOptionsButton"
        Me.PowerOptionsButton.Size = New System.Drawing.Size(126, 23)
        Me.PowerOptionsButton.TabIndex = 4
        Me.PowerOptionsButton.Text = "Power Options"
        Me.PowerOptionsButton.UseVisualStyleBackColor = True
        '
        'DiskDefragmentButton
        '
        Me.DiskDefragmentButton.Location = New System.Drawing.Point(13, 149)
        Me.DiskDefragmentButton.Name = "DiskDefragmentButton"
        Me.DiskDefragmentButton.Size = New System.Drawing.Size(126, 23)
        Me.DiskDefragmentButton.TabIndex = 5
        Me.DiskDefragmentButton.Text = "Disk Defragmenter"
        Me.DiskDefragmentButton.UseVisualStyleBackColor = True
        '
        'DiskCleanupButton
        '
        Me.DiskCleanupButton.Location = New System.Drawing.Point(13, 120)
        Me.DiskCleanupButton.Name = "DiskCleanupButton"
        Me.DiskCleanupButton.Size = New System.Drawing.Size(126, 23)
        Me.DiskCleanupButton.TabIndex = 6
        Me.DiskCleanupButton.Text = "Disk Cleanup"
        Me.DiskCleanupButton.UseVisualStyleBackColor = True
        '
        'PerformanceOptionsButton
        '
        Me.PerformanceOptionsButton.Location = New System.Drawing.Point(13, 179)
        Me.PerformanceOptionsButton.Name = "PerformanceOptionsButton"
        Me.PerformanceOptionsButton.Size = New System.Drawing.Size(126, 23)
        Me.PerformanceOptionsButton.TabIndex = 7
        Me.PerformanceOptionsButton.Text = "Performance Options"
        Me.PerformanceOptionsButton.UseVisualStyleBackColor = True
        '
        'AdvancedControlsLabel
        '
        Me.AdvancedControlsLabel.AutoSize = True
        Me.AdvancedControlsLabel.Location = New System.Drawing.Point(146, 13)
        Me.AdvancedControlsLabel.Name = "AdvancedControlsLabel"
        Me.AdvancedControlsLabel.Size = New System.Drawing.Size(97, 13)
        Me.AdvancedControlsLabel.TabIndex = 8
        Me.AdvancedControlsLabel.Text = "Advanced Controls"
        '
        'OpenGodmodeButton
        '
        Me.OpenGodmodeButton.Location = New System.Drawing.Point(149, 30)
        Me.OpenGodmodeButton.Name = "OpenGodmodeButton"
        Me.OpenGodmodeButton.Size = New System.Drawing.Size(126, 23)
        Me.OpenGodmodeButton.TabIndex = 9
        Me.OpenGodmodeButton.Text = "Open Godmode"
        Me.OpenGodmodeButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(149, 207)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(126, 23)
        Me.AboutButton.TabIndex = 10
        Me.AboutButton.Text = "About Me"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'WindowsOptimizerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 245)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.OpenGodmodeButton)
        Me.Controls.Add(Me.AdvancedControlsLabel)
        Me.Controls.Add(Me.PerformanceOptionsButton)
        Me.Controls.Add(Me.DiskCleanupButton)
        Me.Controls.Add(Me.DiskDefragmentButton)
        Me.Controls.Add(Me.PowerOptionsButton)
        Me.Controls.Add(Me.AddRemoveProgramsButton)
        Me.Controls.Add(Me.RunAllButton)
        Me.Controls.Add(Me.BasicControlsLabel)
        Me.Name = "WindowsOptimizerForm"
        Me.Text = "Windows Optimizer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BasicControlsLabel As Label
    Friend WithEvents RunAllButton As Button
    Friend WithEvents AddRemoveProgramsButton As Button
    Friend WithEvents PowerOptionsButton As Button
    Friend WithEvents DiskDefragmentButton As Button
    Friend WithEvents DiskCleanupButton As Button
    Friend WithEvents PerformanceOptionsButton As Button
    Friend WithEvents AdvancedControlsLabel As Label
    Friend WithEvents OpenGodmodeButton As Button
    Friend WithEvents AboutButton As Button
End Class
