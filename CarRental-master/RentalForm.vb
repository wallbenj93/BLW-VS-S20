'Ben Wallace
'RCET0265
'Spring 2020
'Car Rental Program

Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Dim numCustomers As Integer
    Dim totalMiles As Decimal
    Dim totalCharges As Decimal

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SummaryButton.Enabled = False
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim dataValidated As Boolean = False
        Dim userMessage As String = ""
        Dim beginOdo As Decimal
        Dim endOdo As Decimal
        Dim daysNum As Integer
        Dim begOdoGood As Boolean = False
        Dim endOdoGood As Boolean = False
        Dim daysNumGood As Boolean = False
        'validate data first:
        'text: no field blank
        'odomoter readings: beginning must be less than end. both valid integers
        'number of days between 0 and 45

        'check for blanks
        If NameTextBox.Text = "" Then
            userMessage = "Please enter a name." & vbNewLine
        End If
        If AddressTextBox.Text = "" Then
            userMessage &= "Please enter the address." & vbNewLine
        End If
        If CityTextBox.Text = "" Then
            userMessage &= "Please enter the city." & vbNewLine
        End If
        If StateTextBox.Text = "" Then
            userMessage &= "Please enter the state." & vbNewLine
        End If
        If ZipCodeTextBox.Text = "" Then
            userMessage &= "Please enter the zip code." & vbNewLine
        End If
        If BeginOdometerTextBox.Text = "" Then
            userMessage &= "Please enter the beginning odometer reading." & vbNewLine
        End If
        If EndOdometerTextBox.Text = "" Then
            userMessage &= "Please enter the end odometer reading." & vbNewLine
        End If
        If DaysTextBox.Text = "" Then
            userMessage &= "Please enter the number of days." & vbNewLine
        End If

        'if any of the last 3 are not blank, check to see if they are valid integers
        If BeginOdometerTextBox.Text <> "" Or EndOdometerTextBox.Text <> "" Or
            DaysTextBox.Text <> "" Then
            Try
                beginOdo = CDec(BeginOdometerTextBox.Text)
                begOdoGood = True
                'this line means the odometer input successfully converted to dec
            Catch ex As Exception
                'did not convert to dec
                userMessage &= "Please enter a valid beginning odometer reading" & vbNewLine
            End Try
            Try
                endOdo = CDec(EndOdometerTextBox.Text)
                endOdoGood = True
            Catch ex As Exception
                userMessage &= "Please enter a valid ending odometer reading" & vbNewLine
            End Try
            If begOdoGood = True And endOdoGood = True Then
                'as long as both values converted to dec, compare them
                If beginOdo < endOdo Then
                    'do nothing. Beg is less than end
                Else
                    userMessage &= "The ending odometer reading must be greater than the 
                    starting odometer reading. Please fix this to continue." & vbNewLine _
                    & vbNewLine
                End If
            End If
            Try
                daysNum = CInt(DaysTextBox.Text)
                If daysNum > 0 And daysNum <= 45 Then
                    'days is ok
                    daysNumGood = True
                Else
                    'if this line is entered, days input is a number but not in range
                    userMessage &= "The number of days must be between 0 and 45." & vbNewLine
                End If
            Catch ex As Exception
                userMessage &= "Please enter a valid number for the amount of days." _
                    & vbNewLine
            End Try
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
            'following 3 ifs clears bad data
            If begOdoGood = False Then
                BeginOdometerTextBox.Text = ""
            End If
            If endOdoGood = False Then
                EndOdometerTextBox.Text = ""
            End If
            If daysNumGood = False Then
                DaysTextBox.Text = ""
            End If

            'Following ifs determines which bad data to select (last instance is selected)
            'if statements for each text box, from name to days. 
            'If bad, Then NameTextBox.Select()
            If daysNumGood = False Then
                    DaysTextBox.Select()
                End If
                If endOdoGood = False Then
                    'endOdoGood corresponds to validation of end odo text
                    EndOdometerTextBox.Select()
                End If
                If begOdoGood = False Then
                    'begOdoGood corresponds to validation of begin odo text
                    BeginOdometerTextBox.Select()
                End If
                If ZipCodeTextBox.Text = "" Then
                    ZipCodeTextBox.Select()
                End If
                If StateTextBox.Text = "" Then
                    StateTextBox.Select()
                End If
                If CityTextBox.Text = "" Then
                    CityTextBox.Select()
                End If
                If AddressTextBox.Text = "" Then
                    AddressTextBox.Select()
                End If
                If NameTextBox.Text = "" Then
                    NameTextBox.Select()
                End If
            Else
                'no error message, validation is confirmed
                dataValidated = True
        End If

        If dataValidated = True Then
            'validation checks out. do math here
            Dim milesDriven As Decimal = 0
            Dim dayCharge As Integer = 0
            Dim mileCharge As Decimal = 0
            Dim totalOwed As Decimal = 0

            If MilesradioButton.Checked = True Then
                milesDriven = endOdo - beginOdo
            Else
                'if miles is not checked, km is checked. convert to miles.
                milesDriven = (endOdo - beginOdo) * 0.62D
            End If
            DistanceDriven.Text = Math.Round(milesDriven, 2).ToString("N")

            'daily charge =  days * $15
            dayCharge = daysNum * 15
            DayChargeDisplay.Text = dayCharge.ToString("C")

            'mileage charge:
            '     first 200 miles free
            '     miles 201 to 500: .12 cents per mile
            '     miles 501 and up: .10 cents per mile
            'do calcs in miles.
            '    if in km, convert to miles: 1 km = .62 mile
            '    convert to mile for calcs and output display, dont change input
            Const RATE_REGULAR = 0.12D
            Const RATE_LOW = 0.1D
            Const RATE_FREE = 0D

            'use select to calculate the mileage charge depending on the number of miles
            Select Case milesDriven
                Case <= 200
                    mileCharge = milesDriven * RATE_FREE
                Case > 500
                    mileCharge = 300 * RATE_REGULAR
                    mileCharge += (milesDriven - 500) * RATE_LOW
                Case Else
                    mileCharge = (milesDriven - 200) * RATE_REGULAR
            End Select
            MileageChargeDisplay.Text = mileCharge.ToString("c")

            Const AAARATE = 0.05D
            Const SENIORRATE = 0.03D
            Dim totalDiscount As Decimal = 0

            Dim subTotal As Decimal
            subTotal = mileCharge + dayCharge

            'discounts:
            '    AAA: 5%
            '    SC: 3% (can get both)
            If AAAcheckbox.Checked = True Then
                totalDiscount += subTotal * AAARATE
            End If
            If Seniorcheckbox.Checked = True Then
                totalDiscount += subTotal * SENIORRATE
            End If
            DiscountDisplay.Text = totalDiscount.ToString("c")

            totalOwed = mileCharge + dayCharge - totalDiscount
            TotalChargeDisplay.Text = totalOwed.ToString("c")

            'Add to the number of customers, and total charges and miles
            numCustomers += 1
            totalMiles += milesDriven
            totalCharges += totalOwed
            SummaryButton.Enabled = True
            ClearData()
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearData()
        'clear all output boxes
        DistanceDriven.Text = ""
        MileageChargeDisplay.Text = ""
        DayChargeDisplay.Text = ""
        DiscountDisplay.Text = ""
        TotalChargeDisplay.Text = ""
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'show summary

        ' "Detailed Summary"
        ' Total Customers:     4
        ' Total Miles Driven: 1,430.00 mi
        ' Total Charges:      $1,903.14
        Dim totalSummary As String = ""
        totalSummary = "Total Customers:       " & numCustomers.ToString & vbNewLine
        totalSummary &= "Total Miles Driven:    " & totalMiles.ToString("n") & " mi" & vbNewLine
        totalSummary &= "Total charges:           " & totalCharges.ToString("c") & vbNewLine
        MessageBox.Show(totalSummary, "Detailed Summary")
        ClearData()
        'clear all output boxes
        DistanceDriven.Text = ""
        MileageChargeDisplay.Text = ""
        DayChargeDisplay.Text = ""
        DiscountDisplay.Text = ""
        TotalChargeDisplay.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?",
         "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
         MessageBoxDefaultButton.Button2)
        If result = vbYes Then
            Me.Close()
        End If

        'other way of doing it is this:
        'dim result as msgboxstyle
        'result = CType(MsgBox("Are you sure you want to exit? All information will be _ 
        'lost!!!", vbYesNo), MsgBoxStyle)
    End Sub

    Sub ClearData()
        'do not clear summary

        'Clear User input
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        'select miles radio button
        MilesradioButton.Select()
        'uncheck discount boxes
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False

    End Sub

End Class