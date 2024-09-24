<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarGame
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
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.PlayerScoreLabel = New System.Windows.Forms.Label()
        Me.OpponentScoreLabel = New System.Windows.Forms.Label()
        Me.YourLabel = New System.Windows.Forms.Label()
        Me.OpponentLabel = New System.Windows.Forms.Label()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayListBox.BackColor = System.Drawing.Color.Black
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.ForeColor = System.Drawing.Color.Green
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 17
        Me.DisplayListBox.Location = New System.Drawing.Point(0, 0)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(700, 531)
        Me.DisplayListBox.TabIndex = 10
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.QuitButton.AutoSize = True
        Me.QuitButton.BackColor = System.Drawing.Color.Black
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.ForeColor = System.Drawing.Color.Green
        Me.QuitButton.Location = New System.Drawing.Point(526, 540)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(162, 41)
        Me.QuitButton.TabIndex = 2
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'PlayButton
        '
        Me.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PlayButton.AutoSize = True
        Me.PlayButton.BackColor = System.Drawing.Color.Black
        Me.PlayButton.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.ForeColor = System.Drawing.Color.Green
        Me.PlayButton.Location = New System.Drawing.Point(193, 540)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(162, 41)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'PlayerScoreLabel
        '
        Me.PlayerScoreLabel.AutoSize = True
        Me.PlayerScoreLabel.ForeColor = System.Drawing.Color.White
        Me.PlayerScoreLabel.Location = New System.Drawing.Point(137, 544)
        Me.PlayerScoreLabel.Name = "PlayerScoreLabel"
        Me.PlayerScoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.PlayerScoreLabel.TabIndex = 12
        Me.PlayerScoreLabel.Text = "0"
        '
        'OpponentScoreLabel
        '
        Me.OpponentScoreLabel.AutoSize = True
        Me.OpponentScoreLabel.ForeColor = System.Drawing.Color.White
        Me.OpponentScoreLabel.Location = New System.Drawing.Point(137, 560)
        Me.OpponentScoreLabel.Name = "OpponentScoreLabel"
        Me.OpponentScoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.OpponentScoreLabel.TabIndex = 13
        Me.OpponentScoreLabel.Text = "0"
        '
        'YourLabel
        '
        Me.YourLabel.AutoSize = True
        Me.YourLabel.ForeColor = System.Drawing.Color.White
        Me.YourLabel.Location = New System.Drawing.Point(34, 544)
        Me.YourLabel.Name = "YourLabel"
        Me.YourLabel.Size = New System.Drawing.Size(73, 13)
        Me.YourLabel.TabIndex = 14
        Me.YourLabel.Text = "Your Score:"
        '
        'OpponentLabel
        '
        Me.OpponentLabel.AutoSize = True
        Me.OpponentLabel.ForeColor = System.Drawing.Color.White
        Me.OpponentLabel.Location = New System.Drawing.Point(34, 560)
        Me.OpponentLabel.Name = "OpponentLabel"
        Me.OpponentLabel.Size = New System.Drawing.Size(97, 13)
        Me.OpponentLabel.TabIndex = 15
        Me.OpponentLabel.Text = "Opponent Score:"
        '
        'NewGameButton
        '
        Me.NewGameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NewGameButton.AutoSize = True
        Me.NewGameButton.BackColor = System.Drawing.Color.Black
        Me.NewGameButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewGameButton.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewGameButton.ForeColor = System.Drawing.Color.Green
        Me.NewGameButton.Location = New System.Drawing.Point(361, 540)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(162, 41)
        Me.NewGameButton.TabIndex = 1
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = False
        '
        'WarGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.QuitButton
        Me.ClientSize = New System.Drawing.Size(700, 593)
        Me.Controls.Add(Me.NewGameButton)
        Me.Controls.Add(Me.OpponentLabel)
        Me.Controls.Add(Me.YourLabel)
        Me.Controls.Add(Me.OpponentScoreLabel)
        Me.Controls.Add(Me.PlayerScoreLabel)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "WarGame"
        Me.Text = "WAR.exe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents PlayerScoreLabel As Label
    Friend WithEvents OpponentScoreLabel As Label
    Friend WithEvents YourLabel As Label
    Friend WithEvents OpponentLabel As Label
    Friend WithEvents NewGameButton As Button
End Class
