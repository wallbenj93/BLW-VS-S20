'Ben Wallace
'RCET0265
'Spring 2020
'Dice w list box
'https://github.com/wallbenj93/BLW-VS-S20

Public Class Form1
    Private Sub rerollButton_Click(sender As Object, e As EventArgs) Handles rerollButton.Click
        Dim MyArray(10, 1) As Decimal
        Dim sum As Integer
        Dim rollNum As Integer = 1000
        Dim totalPercent As Decimal
        For i = 1 To rollNum
            Randomize()
            sum = Int((6 * Rnd()) + 1) + Int((6 * Rnd()) + 1)
            'add a count to the corresponding sum
            MyArray(sum - 2, 0) += 1
            'myArray(row, column)
            For j = 2 To 12
                'calculate chance of roll
                MyArray(j - 2, 1) = Decimal.Round(MyArray(j - 2, 0) / rollNum * 100, 1)
            Next
        Next
        For i = 2 To 12
            totalPercent += MyArray(i - 2, 1)
        Next
        ListBox1.Items.Add("Roll of the dice".PadLeft(70))
        Dim row1 As String = ""
        Dim row2 As String = ""
        Dim row3 As String = ""
        For j = 2 To 12
            row1 &= Str(j).PadLeft(7) & "|"
        Next
        For j = 2 To 12
            row2 &= Str(MyArray(j - 2, 0)).PadLeft(7) & "|"
        Next
        For j = 2 To 12
            row3 &= Str(MyArray(j - 2, 1)).PadLeft(7) & "|"
        Next
        'condense code for row 1 by erasing for loop in line 25 and making it one long string
        'line, erase row 1 variable and dim and insert into next line
        ListBox1.Items.Add("Total of Roll: " & row1)
        ListBox1.Items.Add("Times Rolled:  " & row2)
        ListBox1.Items.Add(" % of rolls:   " & row3)
        ListBox1.Items.Add("Total % = " & totalPercent)
        ListBox1.Items.Add("")
        rerollButton.Text = "&Reroll"
        'ListBox1.SetSelected(ListBox1.Items.Count - 1, True)
        'ListBox1.SetSelected(ListBox1.Items.Count - 1, False)
        'ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        ListBox1.TopIndex = ListBox1.Items.Count - 1
    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Me.Text = Len(ListBox1.SelectedIndex.ToString)
    End Sub
End Class

'StrDup(55, "-")
'for i = Lound(array) to Ubound(array)
'Console.Write(CStr(arrayofNum(i)).PadLeft(4) & "|")
'Space(19)
'for i = Lbound(array) to Ubound(array)
'console.write(Cstr(i + 2).Padleft(4) & "|")
'Next
'Console.WriteLine(totalPercent.ToString().PadLeft(47) & "|")
'Console.ReadLine()