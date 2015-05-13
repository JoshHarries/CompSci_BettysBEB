Public Class Form1

    Dim totalEggs, totalButter, totalSugar, totalFlour, smallFlourQty, mediumFlourQty, largeFlourQty, smallSugarQty, mediumSugarQty, largeSugarQty, smallButterQty, mediumButterQty, largeButterQty As Integer

    '(c) Josh Harries 2015 - GitHub: https://github.com/JoshHarries/CompSci_BettysBestEverBakery - WJEC Computer Science 2016 Entry

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
        smallSugarQty = Math.Floor(totalSugar / 200)
        If totalSugar Mod 200 <> 0 Then
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

        smallButterQty = Math.Floor(totalButter / 125)

        If totalButter Mod 125 <> 0 Then
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

    Sub displayQtyaging()

        smallFlour.Text = smallFlourQty
        mediumFlour.Text = mediumFlourQty
        largeFlour.Text = largeFlourQty
        smallSugar.Text = smallSugarQty
        mediumSugar.Text = mediumSugarQty
        largeSugar.Text = largeSugarQty
        smallButter.Text = smallButterQty
        mediumButter.Text = mediumButterQty
        largeButter.Text = largeButterQty

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ingredientsQtys()
        displayIngredients()
        calculateButter()
        calculateFlour()
        calculateSugar()
        displayQtyaging()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cakeQty.Value = 0
        cupcakeQty.Value = 0
        Button1_Click(sender, New System.EventArgs())
    End Sub


End Class
