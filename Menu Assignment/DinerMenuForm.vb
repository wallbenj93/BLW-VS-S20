'Ben Wallace
'RCET0265
'Spring 2020
'Diner Menu Program

Public Class DinerMenuForm
    'Define values for each option of text for the text label
    Private ReadOnly soup1 As String = "Your choice of one homemade soup:" & vbNewLine & vbNewLine & "Chicken & Gnocchi - A creamy soup made with roasted chicken, tradition italian dumplings and spinach." & vbNewLine & vbNewLine & "Pasta e Fagioli - White and red beans, ground beef, fresh tomatoes and tubetti pasta in a savory broth."
    Private ReadOnly soup2 As String = "Your choice of one homemade soup:" & vbNewLine & vbNewLine & "Minestrone - Fresh vegetables, beans and pasta in a light tomato broth - a vegan classic." & vbNewLine & vbNewLine & "Zuppa Toscana - Spicy Italian sausage, fresh kale and russet potatoes in a creamy broth. Made with gluten-free ingredients."
    Private ReadOnly salad2 As String = "Famous House Salad without croutons" & vbNewLine & vbNewLine & "Our famous house salad prepared without croutons for a gluten free alternative." & vbNewLine & vbNewLine & "Only 110 calories!"
    Private ReadOnly salad1 As String = "Our Famous House Salad" & vbNewLine & vbNewLine & "Our Famous House Salad served with our signature Italian dressing(served on the side). 290 calories." & vbNewLine & vbNewLine & "Customize your dressing from one of the following options:" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine 'Italian Dressing, LowFat Italian, or Oil & vinegar"
    Private ReadOnly fish1 As String = "Salmon Picacata" & vbNewLine & vbNewLine & "Coho filet grilled to perfection, topped with a lemon garlic butter sauce, sun-dried tomatoes and capers. Served with parmesan-crusted zucchini," & vbNewLine & vbNewLine & "Choose your side:" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine  'Broccoli, Mashed Potatoes, Spaghetti w/Marinara, or French Fries."
    Private ReadOnly fish2 As String = "Chicken and Shrimp Carbonara" & vbNewLine & vbNewLine & "Sauteed seasoned chicken, shrimp and spaghetti tossed in a creamy sauce with bacon and roasted red peppers."

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'click here to close the program
        Me.Close()
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        'check to see if the previous value of the text box was a soup1. If yes, display soup 2
        If DisplaySpecialLabel.Text = soup1 Then
            DisplaySpecialLabel.Text = soup2
        Else
            DisplaySpecialLabel.Text = soup1
            CheckBox1.Visible = False
            DressingOptions.Visible = False
            SideOptions.Visible = False
            'hide all option boxes
        End If
        'change to picture of soup
        PictureBox1.Image = My.Resources.soups
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        If DisplaySpecialLabel.Text = salad1 Then
            DisplaySpecialLabel.Text = salad2
            DressingOptions.Visible = False
        Else
            DisplaySpecialLabel.Text = salad1
            CheckBox1.Visible = False
            DressingOptions.Visible = True
            SideOptions.Visible = False
            'only show dressing options
        End If
        'change picture to salad
        PictureBox1.Image = My.Resources.salad
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        'choose picture based on fish selected
        If DisplaySpecialLabel.Text = fish1 Then
            DisplaySpecialLabel.Text = fish2
            PictureBox1.Image = My.Resources.chicken_shrimp
            CheckBox1.Visible = True
            SideOptions.Visible = False
            'only show remove peppers checkbox
        Else
            DisplaySpecialLabel.Text = fish1
            PictureBox1.Image = My.Resources.salmon_p
            CheckBox1.Visible = False
            DressingOptions.Visible = False
            SideOptions.Visible = True
            'only show side options radio buttons
        End If
    End Sub
End Class
