'**************************
'* Title: Matches         *
'* Version: 1.1           *
'* Last updated: 14/05/15 *
'* Author: J Mineur       *
'**************************

Public Class Form1

    '*************************************
    '* Declare the global form variables *
    '*************************************

    Dim matches As Decimal
    Dim largeMatchBox, mediumMatchBox, smallMatchBox As Integer

    '---------------------------------------------------------------------------------------

    '*****************************************
    '* Calculate the total number of matches *
    '*****************************************

    Sub calculateTotals()

        '***************************************
        '* Ensure match quantities are integer *
        '***************************************

        matchQty.Value = CInt(matchQty.Value)
        matches = matchQty.Value * 1

    End Sub

    '---------------------------------------------------------------------------------------

    '****************************
    '* Display the match totals *
    '****************************

    Sub displayTotals()

        matchTotal.Text = matches

    End Sub

    '---------------------------------------------------------------------------------------

    '**********************************
    '* Calculate match boxes required *
    '**********************************

    Sub calculateMatches()

        largeMatchBox = 0
        smallMatchBox = 0
        mediumMatchBox = 0

        Dim twelve, twenty As Integer

        '******************************************************
        '* Try fitting the number of matches into size 12     *
        '* boxes and then size 10 boxes.                      *
        '******************************************************

        While matches > 10
            twelve = 12
            twenty = 20

            While matches > twelve
                twelve += 12
            End While

            While matches > twenty
                twenty += 20
            End While

            '***************************************************
            '* If size 12 is a better or the same fit as size  *
            '* 20, then take 12 from the match total and add 1 *
            '* onto the small match box total. Otherwise take  *
            '* 20 from the match total and add 1 onto the      *
            '* medium match box total.                         *
            '***************************************************

            twelve -= matches
            twenty -= matches

            If twelve <= twenty Then
                smallMatchBox += 1
                matches -= 12
            Else
                mediumMatchBox += 1
                matches -= 20
            End If

        End While

        '*****************************************************
        '* Any matches left over after filling the 12 and 20 *
        '* match boxes are put into a box. If there are 12   *
        '* or less thay go into a small box, otherwise they  *
        '* go into a medium box.                             *
        '*****************************************************

        If matches > 0 And matches < 13 Then
            smallMatchBox += 1
        ElseIf matches > 12 Then
            mediumMatchBox += 1
        End If

        '****************************************************
        '* For every two small match boxes you have, change *
        '* them into one large match box.                   *
        '****************************************************

        While smallMatchBox > 1
            largeMatchBox += 1
            smallMatchBox -= 2
        End While

    End Sub

    

    ''---------------------------------------------------------------------------------------

    ''***********************************************
    ''* Display the match totals and boxes required *
    ''***********************************************

    Sub displayMatches()

        largeMatchQty.Text = largeMatchBox
        largeMatchAmount.Text = largeMatchBox * 24
        mediumMatchQty.Text = mediumMatchBox
        mediumMatchAmount.Text = mediumMatchBox * 20
        smallMatchQty.Text = smallMatchBox
        smallMatchAmount.Text = smallMatchBox * 12

    End Sub

    '---------------------------------------------------------------------------------------

    '*********************************************
    '* Update the form when the calculate button *
    '* is clicked                                *
    '*********************************************

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        calculateTotals()
        displayTotals()
        calculateMatches()
        displayMatches()

    End Sub

    '---------------------------------------------------------------------------------------

    '*********************************************
    '* Reset form when the reset button is       *
    '* clicked                                   *
    '*********************************************

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        matchQty.Value = 0

        calculateButton_Click(sender, New System.EventArgs())

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class