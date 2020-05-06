'Ben Wallace
'RCET0265
'Spring 2020
'Etch /a Sketch assignment Assignment
'https://github.com/wallbenj93/BLW-VS-S20

Option Explicit On
Option Strict On

Public Class EtchASketch


    Dim myPen As New Pen(Color.Black)
    Dim penColor As Color
    Dim graph As Graphics
    Dim shakeCount As Integer = 0
    Dim oldX As Integer
    Dim oldY As Integer

    Private Sub EtchASketch_Load(sender As Object, e As EventArgs) Handles Me.Load
        graph = PictureBox1.CreateGraphics
    End Sub

    Private Sub EtchASketch_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        Me.Text = "x: " & e.X & " y: " & (e.Y - 0) * 1 & " Mouse Button: " &
            e.Button.ToString
        XYCoordinates.Text = "X = " & (e.X - 500) & vbNewLine & "Y = " & (e.Y - 200) * -1
        'Me.Text = Me.Location.ToString
        'create graphics object
        'graph = Me.CreateGraphics
        graph = PictureBox1.CreateGraphics


        'constructor for pen object
        If penColor.IsEmpty = True Then
            penColor = Color.Black
        End If

        myPen.Color = penColor



        If e.Button.ToString <> "None" Then
            'draw the line
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
        End If

        'store position
        oldX = e.X
        oldY = e.Y

        'free up resources
        'myPen.Dispose() code breaks if this is uncommented???
        'graph.Dispose()
    End Sub


    Private Sub ColorChangeButton_Click(sender As Object, e As EventArgs) Handles ColorChangeButton.Click, ChangeColorToolStripMenuItem.Click
        'use color pallet to change color
        ColorDialog1.ShowDialog()
        penColor = ColorDialog1.Color
        myPen.Color = penColor
    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click, EraseToolStripMenuItem.Click
        'shake form and erase

        'starting y value of location of program at time of button click
        Dim oldTop As Integer = Me.Top

        'make it do line 64 and line 66 multiple times as a way to make it take 
        'longer between moving up and moving back down
        'NOTE: not an efficient method since this wont always take exactly the  
        'same amount of time to run, especially from one pc to the next
        Dim waitX As Integer = 9000000
        For j = 1 To 3
            For i = 1 To waitX
                If i < CInt(waitX / 2) Then
                    'move up
                    Me.Top = oldTop - 20
                Else
                    'move back to previous position
                    Me.Top = oldTop
                End If

                'Me.Top += 20
                'Threading.Thread.Sleep(2000)
            Next
        Next
        graph.Clear(BackColor)
        XYCoordinates.Hide()
        KeyLabel.Hide()
        'ShakeSub()
    End Sub

    'Sub ShakeSub()
    '    If shakeCount = 3 Then
    '        graph.Clear(BackColor)
    '        shakeCount = 0
    '    Else
    '        Me.Top -= 100
    '        Timer1.Start()
    '        Threading.Thread.Sleep(500)
    '    End If
    'End Sub
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    '    Timer1.Stop()
    '    Me.Top += 100
    '    shakeCount += 1
    '    ShakeSub()
    'End Sub

    Private Sub DrawWaveformButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformButton.Click, DrawWaveformsToolStripMenuItem.Click
        'erase pic box
        graph.Clear(BackColor)


        'draw 10x10 scope graticule
        Dim x As Decimal
        Dim y As Decimal
        myPen.Color = Color.Black
        'loops for vertical lines (same x, change y, for each vertical line)
        For xValue = 100 To 900 Step 100
            For yValue = 5 To 400 Step 10
                graph.DrawLine(myPen, xValue, yValue, xValue, yValue + 5)
            Next
        Next

        'loops for horizontal lines (same y, change x, for each horizontal line)
        For yValue = 40 To 360 Step 40
            For xValue = 5 To 1000 Step 10
                graph.DrawLine(myPen, xValue, yValue, xValue + 5, yValue)
            Next
        Next

        'draw sine wave
        Dim oldY2 As Decimal = 200
        Dim oldX2 As Decimal
        myPen.Color = Color.Green
        For r = 1 To 2000
            'dim frequency as integer
            'Vi = Vp * sin(360 * f * t)
            'y = 200 - (125 * Math.Sin(2 * Math.PI * frequency * (1 / frequency) * (r / 1000)))
            x = CInt(r / 2)
            'x = r
            y = CDec(200 - 78 * Math.Sin(r / 1000 * 2 * Math.PI))
            graph.DrawLine(myPen, oldX2, oldY2, x, y)
            oldX2 = x
            oldY2 = y
        Next

        'draw cosine wave
        'reset starting position
        oldY2 = 200 - 78
        oldX2 = 0
        myPen.Color = Color.Blue
        For r = 1 To 2000
            'y = 200 - (125 * Math.Cos(2 * Math.PI * frequency * (1 / frequency) * (r / 1000)))
            x = CInt(r / 2)
            'x = r
            y = CDec(200 - (78 * Math.Cos(r / 1000 * 2 * Math.PI)))
            graph.DrawLine(myPen, oldX2, oldY2, x, y)
            oldX2 = x
            oldY2 = y
        Next

        'draw tangent waves
        'reset starting position
        oldY2 = 200
        oldX2 = 0
        myPen.Color = Color.Brown
        For r = 1 To 1000
            'y = 200 - (125 * Math.Tan(2 * Math.PI * frequency * (1 / frequency) * (r / 1000)))
            'x = 2 * Math.PI / 1000 * r
            'y = Math.Tan(x) + 200
            'x = x * 500 * Math.PI
            x = r
            y = CDec(200 - 78 * Math.Tan(r / 500 * 2 * Math.PI))
            If y < -200 Then
                y = -200
            ElseIf y > 600 Then
                y = 600
            End If
            If (x > 120 And x < 130) Or (x > 370 And x < 380) Or
                (x > 620 And x < 630) Or (x > 870 And x < 880) Then
                'don't draw vertical undefined lines for tan
            Else
                graph.DrawLine(myPen, oldX2, oldY2, x, y)
            End If

            oldX2 = x
            oldY2 = y
        Next

        KeyLabel.Text = "Key: " & vbNewLine & "Green = Sin, Blue = Cos,  Brown = Tan"
        KeyLabel.Show()
        XYCoordinates.Show()
    End Sub


End Class



'todo (not finished due to time)
'fix "global variables"
'related to global: free up resources? 
'cleanup code(with more subs?)
'add scaling in case form is re-sized by user or moved off screen or minimized
'add ability to do just one waveform in menu button?