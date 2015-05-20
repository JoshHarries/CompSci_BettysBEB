Public Class Form1

    Dim totalEggs, totalButter, totalSugar, totalFlour, smallFlourQty, mediumFlourQty, largeFlourQty, smallSugarQty, mediumSugarQty, largeSugarQty, smallButterQty, mediumButterQty, largeButterQty, smallEggsQty, mediumEggsQty, largeEggsQty As Integer

    '(c) Josh Harries 1015 - GitHub: https://github.com/JoshHarries/CompSci_BettysBestEverBakery - WJEC Computer Science 1016 Entry

    Sub ingredientsQtys()

        totalFlour = cakeQty.Value * 240 + cupcakeQty.Value * 12
        totalSugar = cakeQty.Value * 300 + cupcakeQty.Value * 14
        totalButter = cakeQty.Value * 240 + cupcakeQty.Value * 4
        totalEggs = Math.Ceiling(cakeQty.Value * 4.5 + cupcakeQty.Value * 0.1)

    End Sub

    Sub displayIngredients()

        flourQty.Text = totalFlour & "g"
        sugarQty.Text = totalSugar & "g"
        butterQty.Text = totalButter & "g"
        eggQty.Text = totalEggs & " Eggs."

    End Sub

    Sub calculateFlour()

        smallFlourQty = 0
        mediumFlourQty = 0
        largeFlourQty = 0
        smallFlourQty = Math.Floor(totalFlour / 250)

        If totalFlour Mod 250 <> 0 Then
            smallFlourQty += 1
        End If

        While smallFlourQty > 2
            smallFlourQty -= 3
            largeFlourQty += 1
        End While

        While smallFlourQty > 1
            smallFlourQty -= 2
            mediumFlourQty += 1
        End While

    End Sub

    Sub calculateSugar()

        smallSugarQty = 0
        mediumSugarQty = 0
        largeSugarQty = 0
        smallSugarQty = Math.Floor(totalSugar / 100)
        If totalSugar Mod 100 <> 0 Then
            smallSugarQty += 1
        End If

        While smallSugarQty > 2
            smallSugarQty -= 3
            largeSugarQty += 1
        End While

        While smallSugarQty > 1
            smallSugarQty -= 2
            mediumSugarQty += 1
        End While

    End Sub

    Sub calculateButter()

        smallButterQty = 0
        mediumButterQty = 0
        largeButterQty = 0

        smallButterQty = Math.Floor(totalButter / 65)

        If totalButter Mod 65 <> 0 Then
            smallButterQty += 1
        End If

        While smallButterQty > 3
            smallButterQty -= 4
            largeButterQty += 1
        End While

        While smallButterQty > 1
            smallButterQty -= 2
            mediumButterQty += 1
        End While

    End Sub

    Sub calculateEggs()

        largeEggsQty = 0
        smallEggsQty = 0
        mediumEggsQty = 0

        Dim six, ten As Integer

        '******************************************************
        '* Try fitting the number of matches into size 12     *
        '* boxes and then size 10 boxes.                      *
        '******************************************************

        While totalEggs > 5
            six = 6
            ten = 10

            While totalEggs > six
                six += 6
            End While

            While totalEggs > ten
                ten += 10
            End While

            '***************************************************
            '* If size 12 is a better or the same fit as size  *
            '* 20, then take 12 from the match total and add 1 *
            '* onto the small match box total. Otherwise take  *
            '* 20 from the match total and add 1 onto the      *
            '* medium match box total.                         *
            '***************************************************

            six -= totalEggs
            ten -= totalEggs

            If six <= ten Then
                smallEggsQty += 1
                totalEggs -= 6
            Else
                mediumEggsQty += 1
                totalEggs -= 10
            End If

        End While

        '*****************************************************
        '* Any matches left over after filling the 12 and 20 *
        '* match boxes are put into a box. If there are 12   *
        '* or less thay go into a small box, otherwise they  *
        '* go into a medium box.                             *
        '*****************************************************

        If totalEggs > 0 And totalEggs < 7 Then
            smallEggsQty += 1
        ElseIf totalEggs > 6 Then
            mediumEggsQty += 1
        End If

        '****************************************************
        '* For every two small match boxes you have, change *
        '* them into one large match box.                   *
        '****************************************************

        While smallEggsQty > 1
            largeEggsQty += 1
            smallEggsQty -= 2
        End While

    End Sub

    Sub displayPackaging()

        smallFlour.Text = smallFlourQty
        mediumFlour.Text = mediumFlourQty
        largeFlour.Text = largeFlourQty

        smallSugar.Text = smallSugarQty
        mediumSugar.Text = mediumSugarQty
        largeSugar.Text = largeSugarQty

        smallButter.Text = smallButterQty
        mediumButter.Text = mediumButterQty
        largeButter.Text = largeButterQty

        smallEggs.Text = smallEggsQty
        mediumEggs.Text = mediumEggsQty
        largeEggs.Text = largeEggsQty

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ingredientsQtys()
        displayIngredients()
        calculateButter()
        calculateFlour()
        calculateSugar()
        calculateEggs()
        displayPackaging()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cakeQty.Value = 0
        cupcakeQty.Value = 0
        Button1_Click(sender, New System.EventArgs())
    End Sub


End Class
