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
        Me.DepartmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.CoffeeBarRadioButton = New System.Windows.Forms.RadioButton()
        Me.PeriodicalsRadioButton = New System.Windows.Forms.RadioButton()
        Me.MusicRadioButton = New System.Windows.Forms.RadioButton()
        Me.BooksRadioButton = New System.Windows.Forms.RadioButton()
        Me.CheckInGroupBox = New System.Windows.Forms.GroupBox()
        Me.MemberIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WelcomeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DepartmentPictureBox = New System.Windows.Forms.PictureBox()
        Me.PromotionTextBox = New System.Windows.Forms.TextBox()
        Me.ImageVisibleCheckBox = New System.Windows.Forms.CheckBox()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.DepartmentGroupBox.SuspendLayout()
        Me.CheckInGroupBox.SuspendLayout()
        CType(Me.DepartmentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentGroupBox
        '
        Me.DepartmentGroupBox.Controls.Add(Me.CoffeeBarRadioButton)
        Me.DepartmentGroupBox.Controls.Add(Me.PeriodicalsRadioButton)
        Me.DepartmentGroupBox.Controls.Add(Me.MusicRadioButton)
        Me.DepartmentGroupBox.Controls.Add(Me.BooksRadioButton)
        Me.DepartmentGroupBox.Enabled = False
        Me.DepartmentGroupBox.Location = New System.Drawing.Point(98, 142)
        Me.DepartmentGroupBox.Name = "DepartmentGroupBox"
        Me.DepartmentGroupBox.Size = New System.Drawing.Size(359, 322)
        Me.DepartmentGroupBox.TabIndex = 0
        Me.DepartmentGroupBox.TabStop = False
        Me.DepartmentGroupBox.Text = "Department"
        '
        'CoffeeBarRadioButton
        '
        Me.CoffeeBarRadioButton.AutoSize = True
        Me.CoffeeBarRadioButton.Location = New System.Drawing.Point(28, 237)
        Me.CoffeeBarRadioButton.Name = "CoffeeBarRadioButton"
        Me.CoffeeBarRadioButton.Size = New System.Drawing.Size(119, 29)
        Me.CoffeeBarRadioButton.TabIndex = 6
        Me.CoffeeBarRadioButton.TabStop = True
        Me.CoffeeBarRadioButton.Text = "Coffee Bar"
        Me.CoffeeBarRadioButton.UseVisualStyleBackColor = True
        '
        'PeriodicalsRadioButton
        '
        Me.PeriodicalsRadioButton.AutoSize = True
        Me.PeriodicalsRadioButton.Location = New System.Drawing.Point(28, 180)
        Me.PeriodicalsRadioButton.Name = "PeriodicalsRadioButton"
        Me.PeriodicalsRadioButton.Size = New System.Drawing.Size(120, 29)
        Me.PeriodicalsRadioButton.TabIndex = 2
        Me.PeriodicalsRadioButton.TabStop = True
        Me.PeriodicalsRadioButton.Text = "Periodicals"
        Me.PeriodicalsRadioButton.UseVisualStyleBackColor = True
        '
        'MusicRadioButton
        '
        Me.MusicRadioButton.AutoSize = True
        Me.MusicRadioButton.Location = New System.Drawing.Point(28, 112)
        Me.MusicRadioButton.Name = "MusicRadioButton"
        Me.MusicRadioButton.Size = New System.Drawing.Size(83, 29)
        Me.MusicRadioButton.TabIndex = 1
        Me.MusicRadioButton.TabStop = True
        Me.MusicRadioButton.Text = "Music"
        Me.MusicRadioButton.UseVisualStyleBackColor = True
        '
        'BooksRadioButton
        '
        Me.BooksRadioButton.AutoSize = True
        Me.BooksRadioButton.Location = New System.Drawing.Point(28, 55)
        Me.BooksRadioButton.Name = "BooksRadioButton"
        Me.BooksRadioButton.Size = New System.Drawing.Size(86, 29)
        Me.BooksRadioButton.TabIndex = 0
        Me.BooksRadioButton.TabStop = True
        Me.BooksRadioButton.Text = "Books"
        Me.BooksRadioButton.UseVisualStyleBackColor = True
        '
        'CheckInGroupBox
        '
        Me.CheckInGroupBox.Controls.Add(Me.MemberIDMaskedTextBox)
        Me.CheckInGroupBox.Controls.Add(Me.NameTextBox)
        Me.CheckInGroupBox.Controls.Add(Me.Label2)
        Me.CheckInGroupBox.Controls.Add(Me.Label1)
        Me.CheckInGroupBox.Location = New System.Drawing.Point(515, 156)
        Me.CheckInGroupBox.Name = "CheckInGroupBox"
        Me.CheckInGroupBox.Size = New System.Drawing.Size(390, 150)
        Me.CheckInGroupBox.TabIndex = 1
        Me.CheckInGroupBox.TabStop = False
        Me.CheckInGroupBox.Text = "Elite Member Check In"
        '
        'MemberIDMaskedTextBox
        '
        Me.MemberIDMaskedTextBox.Location = New System.Drawing.Point(143, 100)
        Me.MemberIDMaskedTextBox.Mask = "0000"
        Me.MemberIDMaskedTextBox.Name = "MemberIDMaskedTextBox"
        Me.MemberIDMaskedTextBox.Size = New System.Drawing.Size(91, 31)
        Me.MemberIDMaskedTextBox.TabIndex = 13
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(143, 45)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(185, 31)
        Me.NameTextBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Member ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'WelcomeRichTextBox
        '
        Me.WelcomeRichTextBox.Location = New System.Drawing.Point(515, 349)
        Me.WelcomeRichTextBox.Name = "WelcomeRichTextBox"
        Me.WelcomeRichTextBox.Size = New System.Drawing.Size(390, 144)
        Me.WelcomeRichTextBox.TabIndex = 2
        Me.WelcomeRichTextBox.Text = ""
        Me.WelcomeRichTextBox.Visible = False
        '
        'DepartmentPictureBox
        '
        Me.DepartmentPictureBox.Location = New System.Drawing.Point(98, 501)
        Me.DepartmentPictureBox.Name = "DepartmentPictureBox"
        Me.DepartmentPictureBox.Size = New System.Drawing.Size(353, 240)
        Me.DepartmentPictureBox.TabIndex = 3
        Me.DepartmentPictureBox.TabStop = False
        Me.DepartmentPictureBox.Visible = False
        '
        'PromotionTextBox
        '
        Me.PromotionTextBox.Location = New System.Drawing.Point(98, 787)
        Me.PromotionTextBox.Name = "PromotionTextBox"
        Me.PromotionTextBox.Size = New System.Drawing.Size(446, 31)
        Me.PromotionTextBox.TabIndex = 4
        Me.PromotionTextBox.Visible = False
        '
        'ImageVisibleCheckBox
        '
        Me.ImageVisibleCheckBox.AutoSize = True
        Me.ImageVisibleCheckBox.Location = New System.Drawing.Point(550, 686)
        Me.ImageVisibleCheckBox.Name = "ImageVisibleCheckBox"
        Me.ImageVisibleCheckBox.Size = New System.Drawing.Size(144, 29)
        Me.ImageVisibleCheckBox.TabIndex = 5
        Me.ImageVisibleCheckBox.Text = "Image Visible"
        Me.ImageVisibleCheckBox.UseVisualStyleBackColor = True
        Me.ImageVisibleCheckBox.Visible = False
        '
        'SignInButton
        '
        Me.SignInButton.Location = New System.Drawing.Point(870, 635)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(141, 49)
        Me.SignInButton.TabIndex = 6
        Me.SignInButton.Text = "Sign In"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(870, 737)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(141, 41)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(870, 838)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(172, 25)
        Me.Label0.TabIndex = 8
        Me.Label0.Text = "by KeShaun Pearson"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 919)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.ImageVisibleCheckBox)
        Me.Controls.Add(Me.PromotionTextBox)
        Me.Controls.Add(Me.DepartmentPictureBox)
        Me.Controls.Add(Me.WelcomeRichTextBox)
        Me.Controls.Add(Me.CheckInGroupBox)
        Me.Controls.Add(Me.DepartmentGroupBox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Membership Promotions for R 'n R"
        Me.DepartmentGroupBox.ResumeLayout(False)
        Me.DepartmentGroupBox.PerformLayout()
        Me.CheckInGroupBox.ResumeLayout(False)
        Me.CheckInGroupBox.PerformLayout()
        CType(Me.DepartmentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DepartmentGroupBox As GroupBox
    Friend WithEvents CoffeeBarRadioButton As RadioButton
    Friend WithEvents PeriodicalsRadioButton As RadioButton
    Friend WithEvents MusicRadioButton As RadioButton
    Friend WithEvents BooksRadioButton As RadioButton
    Friend WithEvents CheckInGroupBox As GroupBox
    Friend WithEvents WelcomeRichTextBox As RichTextBox
    Friend WithEvents DepartmentPictureBox As PictureBox
    Friend WithEvents PromotionTextBox As TextBox
    Friend WithEvents ImageVisibleCheckBox As CheckBox
    Friend WithEvents SignInButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label0 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MemberIDMaskedTextBox As MaskedTextBox
End Class
