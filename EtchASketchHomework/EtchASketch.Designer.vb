<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchASketch
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorChangeButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DrawWaveformButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EraseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.XYCoordinates = New System.Windows.Forms.Label()
        Me.TopMenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorChangeButton
        '
        Me.ColorChangeButton.Location = New System.Drawing.Point(39, 186)
        Me.ColorChangeButton.Name = "ColorChangeButton"
        Me.ColorChangeButton.Size = New System.Drawing.Size(125, 39)
        Me.ColorChangeButton.TabIndex = 0
        Me.ColorChangeButton.Text = "Change Color"
        Me.ColorChangeButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EraseButton.Location = New System.Drawing.Point(39, 248)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(125, 39)
        Me.EraseButton.TabIndex = 1
        Me.EraseButton.Text = "Erase"
        Me.ToolTip1.SetToolTip(Me.EraseButton, "Click here to clear the Etch-A-Sketch")
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformButton
        '
        Me.DrawWaveformButton.Location = New System.Drawing.Point(39, 303)
        Me.DrawWaveformButton.Name = "DrawWaveformButton"
        Me.DrawWaveformButton.Size = New System.Drawing.Size(125, 39)
        Me.DrawWaveformButton.TabIndex = 2
        Me.DrawWaveformButton.Text = "Draw Waveforms"
        Me.ToolTip1.SetToolTip(Me.DrawWaveformButton, "Click here to draw some waveforms")
        Me.DrawWaveformButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1334, 24)
        Me.TopMenuStrip.TabIndex = 5
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeColorToolStripMenuItem, Me.EraseToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChangeColorToolStripMenuItem.Text = "Change color"
        '
        'EraseToolStripMenuItem
        '
        Me.EraseToolStripMenuItem.Name = "EraseToolStripMenuItem"
        Me.EraseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EraseToolStripMenuItem.Text = "Erase"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpTopMenuItem.Text = "&Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutTopMenuItem.Text = "About"
        '
        'KeyLabel
        '
        Me.KeyLabel.BackColor = System.Drawing.SystemColors.Control
        Me.KeyLabel.Location = New System.Drawing.Point(65, 355)
        Me.KeyLabel.Name = "KeyLabel"
        Me.KeyLabel.Size = New System.Drawing.Size(75, 56)
        Me.KeyLabel.TabIndex = 6
        Me.KeyLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(170, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 400)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'XYCoordinates
        '
        Me.XYCoordinates.BackColor = System.Drawing.SystemColors.Control
        Me.XYCoordinates.Location = New System.Drawing.Point(65, 119)
        Me.XYCoordinates.Name = "XYCoordinates"
        Me.XYCoordinates.Size = New System.Drawing.Size(51, 28)
        Me.XYCoordinates.TabIndex = 7
        Me.XYCoordinates.Visible = False
        '
        'EtchASketch
        '
        Me.AcceptButton = Me.ColorChangeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EtchASketchHomework.My.Resources.Resources.etch_a_sketch
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.EraseButton
        Me.ClientSize = New System.Drawing.Size(1334, 611)
        Me.Controls.Add(Me.XYCoordinates)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.KeyLabel)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.DrawWaveformButton)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.ColorChangeButton)
        Me.Name = "EtchASketch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EtchASketch"
        Me.ToolTip1.SetToolTip(Me, "Click here to choose a new color")
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorChangeButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DrawWaveformButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EraseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents KeyLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents XYCoordinates As Label
End Class
