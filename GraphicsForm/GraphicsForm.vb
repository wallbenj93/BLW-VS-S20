Public Class GraphicsForm



    Sub drawLine()

        'create graphics object
        Dim graph As Graphics
        graph = Me.CreateGraphics

        'constructor for pen object
        Dim myPen As New Pen(Color.Black)

        'draw the line
        graph.DrawLine(myPen, 10, 10, 200, 200)

        'free up resources
        myPen.Dispose()
        graph.Dispose()

    End Sub

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'drawLine()
    End Sub

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Me.MouseClick

        Me.Text = "x: " & e.X & " y: " & e.Y & " Mouse Button: " & e.Button.ToString

        'create graphics object
        Dim graph As Graphics
        graph = Me.CreateGraphics

        Static penColor As Color

        'constructor for pen object
        'If penColor Is null Then  ' TODO fix
        Dim myPen As New Pen(penColor)
        'End If

        Static oldX As Integer
        Static oldY As Integer

        If penColor.IsEmpty = True Then
            'MsgBox("yay I figured it out")
            penColor = Color.Black 'or by default make a pop to choose color at startup?
        End If

        If e.Button.ToString = "Left" Then
            'draw the line
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            graph.Clear(Color.FromArgb(0, 0, 0))
        ElseIf e.Button.ToString = "Middle" Then
            ColorDialog1.ShowDialog()
            penColor = ColorDialog1.Color
            myPen.Color = penColor
        End If

        'store position
        oldX = e.X
        oldY = e.Y

        'free up resources
        myPen.Dispose()
        graph.Dispose()

    End Sub

    Private Sub GraphicsForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'If e.Button.ToString = "Middle" Then
        '    ColorDialog1.ShowDialog()
        '    penColor = ColorDialog1.Color
        '    myPen.Color = penColor
        'End If
    End Sub

    Sub DrawEllipse()
        Dim graph As Graphics = Me.CreateGraphics
        Dim myPen As New Pen(Color.FromArgb(255, 0, 0, 0))

        graph.DrawEllipse(myPen, New Rectangle(50, 50, 100, 100))

        myPen.Dispose()
        graph.Dispose()
    End Sub

    Sub drawRectangle()
        Dim graph As Graphics = Me.CreateGraphics
        Dim myPen As New Pen(Color.FromArgb(255, 0, 0, 0))

        graph.DrawRectangle(myPen, New Rectangle(50, 50, 100, 100))

        myPen.Dispose()
        graph.Dispose()
    End Sub
End Class