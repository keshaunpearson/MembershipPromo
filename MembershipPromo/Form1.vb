'Project:     CH02HandON
'Programmer:  KeShaun Pearson
'Date:        7/24/2021
'Description: Allow the user to sign in and siplay the current sales promotion

Public Class Form1

    'Required Shared Class for projects
    Public Shared Sub Main()
    End Sub


    Private Sub BooksRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BooksRadioButton.CheckedChanged
        ' Display the image and promotion for the Book Department 
        DepartmentPictureBox.Image = My.Resources.Book

        PromotionTextBox.Text = "Buy two, get the second one for half price."

    End Sub

    Private Sub CoffeeBarRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CoffeeBarRadioButton.CheckedChanged
        'Display the image and promotion for the Coffee Bar 

        DepartmentPictureBox.Image = My.Resources.Coffee

        PromotionTextBox.Text = "Celebrate the searson with 20% off specialty drinks."
    End Sub

    Private Sub MusicRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MusicRadioButton.CheckedChanged
        'Display the image and promotion for the Music Department

        DepartmentPictureBox.Image = My.Resources.Music

        PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD."
    End Sub

    Private Sub PeriodicalsRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PeriodicalsRadioButton.CheckedChanged
        'Display the image and promotion for the Periodicals Department

        DepartmentPictureBox.Image = My.Resources.Periodicals

        PromotionTextBox.Text = "Elite Members recieve 10% off every purchase."
    End Sub

    Private Sub ImageVisibleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ImageVisibleCheckBox.CheckedChanged
        'Set the visibility of the department image

        DepartmentPictureBox.Visible = ImageVisibleCheckBox.Checked

    End Sub

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        'Set up the screen to display the deparment promotions and the welcome message. Hide the sign-in controls. 

        'Hide and disable the sign-in controls 
        CheckInGroupBox.Visible = False
        SignInButton.Enabled = False

        'Enable the group of radio buttons.
        DepartmentGroupBox.Enabled = True

        'Show the promotions controls.
        PromotionTextBox.Visible = True
        ImageVisibleCheckBox.Visible = True
        WelcomeRichTextBox.Visible = True


        'Display the welcome Message 
        WelcomeRichTextBox.Text = "Welcome Member #" & MemberIDMaskedTextBox.Text & Environment.NewLine & NameTextBox.Text
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'End the program

        Me.Close()

    End Sub
End Class
