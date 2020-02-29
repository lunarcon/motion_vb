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
        Me.sine_linear = New System.Windows.Forms.GroupBox()
        Me.movt_obj = New System.Windows.Forms.Button()
        Me.speed_bar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.circular = New System.Windows.Forms.GroupBox()
        Me.movt_obj2 = New System.Windows.Forms.Button()
        Me.sine_dual = New System.Windows.Forms.GroupBox()
        Me.movt_obj3 = New System.Windows.Forms.Button()
        Me.sine_linear.SuspendLayout()
        CType(Me.speed_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.circular.SuspendLayout()
        Me.sine_dual.SuspendLayout()
        Me.SuspendLayout()
        '
        'sine_linear
        '
        Me.sine_linear.Controls.Add(Me.movt_obj)
        Me.sine_linear.Location = New System.Drawing.Point(12, 12)
        Me.sine_linear.Name = "sine_linear"
        Me.sine_linear.Size = New System.Drawing.Size(261, 250)
        Me.sine_linear.TabIndex = 0
        Me.sine_linear.TabStop = False
        Me.sine_linear.Text = "SIne_Linear"
        '
        'movt_obj
        '
        Me.movt_obj.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.movt_obj.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.movt_obj.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.movt_obj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.movt_obj.Location = New System.Drawing.Point(120, 118)
        Me.movt_obj.Name = "movt_obj"
        Me.movt_obj.Size = New System.Drawing.Size(10, 10)
        Me.movt_obj.TabIndex = 0
        Me.movt_obj.UseVisualStyleBackColor = False
        '
        'speed_bar
        '
        Me.speed_bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.speed_bar.Location = New System.Drawing.Point(328, 389)
        Me.speed_bar.Maximum = 19
        Me.speed_bar.Name = "speed_bar"
        Me.speed_bar.Size = New System.Drawing.Size(207, 45)
        Me.speed_bar.TabIndex = 1
        Me.speed_bar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.speed_bar.Value = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Slower"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(488, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Faster"
        '
        'circular
        '
        Me.circular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.circular.Controls.Add(Me.movt_obj2)
        Me.circular.Location = New System.Drawing.Point(295, 12)
        Me.circular.Name = "circular"
        Me.circular.Size = New System.Drawing.Size(261, 250)
        Me.circular.TabIndex = 4
        Me.circular.TabStop = False
        Me.circular.Text = "Circular"
        '
        'movt_obj2
        '
        Me.movt_obj2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.movt_obj2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.movt_obj2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.movt_obj2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.movt_obj2.Location = New System.Drawing.Point(120, 118)
        Me.movt_obj2.Name = "movt_obj2"
        Me.movt_obj2.Size = New System.Drawing.Size(10, 10)
        Me.movt_obj2.TabIndex = 0
        Me.movt_obj2.UseVisualStyleBackColor = False
        '
        'sine_dual
        '
        Me.sine_dual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sine_dual.Controls.Add(Me.movt_obj3)
        Me.sine_dual.Location = New System.Drawing.Point(12, 287)
        Me.sine_dual.Name = "sine_dual"
        Me.sine_dual.Size = New System.Drawing.Size(261, 250)
        Me.sine_dual.TabIndex = 5
        Me.sine_dual.TabStop = False
        Me.sine_dual.Text = "Sine_Diagonal"
        '
        'movt_obj3
        '
        Me.movt_obj3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.movt_obj3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.movt_obj3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.movt_obj3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.movt_obj3.Location = New System.Drawing.Point(120, 118)
        Me.movt_obj3.Name = "movt_obj3"
        Me.movt_obj3.Size = New System.Drawing.Size(10, 10)
        Me.movt_obj3.TabIndex = 0
        Me.movt_obj3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 556)
        Me.Controls.Add(Me.sine_dual)
        Me.Controls.Add(Me.circular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.speed_bar)
        Me.Controls.Add(Me.sine_linear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(596, 595)
        Me.Name = "Form1"
        Me.Text = "MotionTests"
        Me.sine_linear.ResumeLayout(False)
        CType(Me.speed_bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.circular.ResumeLayout(False)
        Me.sine_dual.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sine_linear As GroupBox
    Friend WithEvents movt_obj As Button
    Friend WithEvents speed_bar As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents circular As GroupBox
    Friend WithEvents movt_obj2 As Button
    Friend WithEvents sine_dual As GroupBox
    Friend WithEvents movt_obj3 As Button
End Class
