'Ben Wallace
'RCET0265
'Spring 2020
'Stans Grocery Assignment
'https://github.com/wallbenj93/BLW-VS-S20

Option Strict On
Option Explicit On

Public Class StansGroceryForm
    'create array with 15 total items (3 aisles, 5 items per aisle)
    Dim itemArray(2, 4) As String

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'create and load file
        'TODO
        Dim file As String = "..\..\Grocery.txt"

        'open file to be read into array
        FileOpen(1, file, OpenMode.Input)

        'use a loop to continually add items from the file to array until the end is reached
        'keep track of asile count and item count to know where to put next item
        Dim aisleNumber As Integer = 0
        Dim itemNumber As Integer = 0

        Do While Not EOF(1)
            'loop starts with aisle = 0, item = 0
            itemArray(aisleNumber, itemNumber) = LineInput(1)
            ComboBox1.Items.Add(itemArray(aisleNumber, itemNumber))
            DisplayListBox.Items.Add(itemArray(aisleNumber, itemNumber))
            If itemNumber < 4 Then
                itemNumber += 1
            ElseIf itemNumber = 4 Then
                itemNumber = 0
                aisleNumber += 1
            End If

        Loop
        FileClose(1)

        DisplayLabel.Text = "Please select an item from the list or the drop" &
            " menu to see its location, or search for an item."
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        'deselect previously selected item if something in the list box is selected
        ComboBox1.SelectedIndex = -1
        'without this next if, this sub, and all its instructions, would be entered if
        'line x was carried out from the next sub
        If DisplayListBox.SelectedIndex <> -1 Then
            Dim aisleNumber2 As Integer = 0
            Dim itemNumber2 As Integer = 0
            Select Case DisplayListBox.SelectedIndex
                'determine the aisle number & item number based on the index #
                Case <= 4
                    'first 5 index numbers are aisle 1
                    aisleNumber2 = 1
                    'item number counts by 1, up to 5
                    itemNumber2 = DisplayListBox.SelectedIndex + 1
                Case >= 10
                    'last 5 index numbers are aisle 3
                    aisleNumber2 = 3
                    itemNumber2 = DisplayListBox.SelectedIndex - 9
                Case Else
                    'all other items are aisle 2
                    aisleNumber2 = 2
                    itemNumber2 = DisplayListBox.SelectedIndex - 4
            End Select
            If aisleNumber2 = 3 Then
                'add the word game to items in aisle 3
                DisplayLabel.Text = "The " & DisplayListBox.SelectedItem.ToString &
                " game can be found on aisle " & aisleNumber2 & " and is " &
                "item number " & itemNumber2 & "."
            Else
                DisplayLabel.Text = "The " & DisplayListBox.SelectedItem.ToString &
                " can be found on aisle " & aisleNumber2 & " and is " &
                "item number " & itemNumber2 & "."
            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'deselect previously selected item if something in the combo box is selected
        DisplayListBox.SelectedIndex = -1
        If ComboBox1.SelectedIndex <> -1 Then
            Dim aisleNumber2 As Integer = 0
            Dim itemNumber2 As Integer = 0
            Select Case ComboBox1.SelectedIndex
                Case <= 4
                    aisleNumber2 = 1
                    itemNumber2 = ComboBox1.SelectedIndex + 1
                Case >= 10
                    aisleNumber2 = 3
                    itemNumber2 = ComboBox1.SelectedIndex - 9
                Case Else
                    aisleNumber2 = 2
                    itemNumber2 = ComboBox1.SelectedIndex - 4
            End Select
            If aisleNumber2 = 3 Then
                DisplayLabel.Text = "The " & ComboBox1.SelectedItem.ToString &
                " game can be found on aisle " & aisleNumber2 & " and is " &
                "item number " & itemNumber2 & "."
            Else
                DisplayLabel.Text = "The " & ComboBox1.SelectedItem.ToString &
                " can be found on aisle " & aisleNumber2 & " and is " &
                "item number " & itemNumber2 & "."
            End If
        End If

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click
        'deselect all items in combo box and list box
        DisplayListBox.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        If SearchTextBox.Text = "" Then
            'if blank, alert user
            MsgBox("Please enter something to search for.")
        ElseIf SearchTextBox.Text = "zzz" Or SearchTextBox.Text = "ZZZ" Then
            'secret code to close program
            Me.Close()
        ElseIf SearchTextBox.Text.Length < 3 Then
            'must enter at least 3 characters when searching to increase
            'accuracy when searching for an item
            MsgBox("Please enter at least 3 characters in the search box.")
        Else
            'search items here
            Dim itemFound As Boolean = False
            'use nested for loop to search each cell of the array
            For i = 0 To 2 'aisle number
                For j = 0 To 4 'item number
                    'check if the search text is part of the string in the cell
                    If (itemArray(i, j).ToLower).Contains(SearchTextBox.Text.ToLower) Then
                        'if found, display item and location
                        If i = 2 Then
                            'for aisle 3 items, add the word "game"
                            DisplayLabel.Text = "The " & itemArray(i, j) & " game can" &
                            " be found on aisle #" & (i + 1).ToString & " And " &
                            "Is item #" & (j + 1).ToString & "."
                        Else
                            DisplayLabel.Text = "The " & itemArray(i, j) & " can" &
                            " be found on aisle " & (i + 1).ToString & " And " &
                            "Is item #" & (j + 1).ToString & "."
                        End If
                        'since item is found, assign i and j to final values to
                        'avoid wasting time checking other cells
                        i = 2
                        j = 4
                        itemFound = True

                    End If
                Next
            Next
            If itemFound = False Then
                'notify user the item wasn't found
                MsgBox("We don't have that item in our store. Check our website " &
                "for more options or try searching a different name.")
            End If
        End If
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        'user msg for info about program
        MsgBox("This interface was designed by Tim Rossiter" & vbNewLine _
            & "                Code written by Ben Wallace" & vbNewLine &
            "                            Version 1")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'close program with menu click
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'exit button is hidden from user. only exists to be assigned for cancel button
        Me.Close()
    End Sub
End Class
