Public Class Form1

    Dim totalButter, totalSugar, totalFlour, smallFlourPack, mediumFlourPack, largeFlourPack, smallSugarPack, mediumSugarPack, largeSugarPack, smallButterPack, mediumButterPack, largeButterPack As Integer

    '(c) Josh Harries 2015 - GitHub: https://github.com/JoshHarries/CompSci_BettysBestEverBakery - WJEC Computer Science 2016 Entry

    Sub ingredQtys()

        totalFlour = drizzleCakeAmount.Value * 240 + cupCakeAmount.Value * 12
        totalSugar = drizzleCakeAmount.Value * 300 + cupCakeAmount.Value * 14
        totalButter = drizzleCakeAmount.Value * 240 + cupCakeAmount.Value * 4

    End Sub

    Sub displayIngredients()

        plainFlourAmount.Text = totalFlour
        sugarAmount.Text = totalSugar
        butterAmount.Text = totalButter

    End Sub

    Sub calculateFlour()

        smallFlourPack = 0
        mediumFlourPack = 0
        largeFlourPack = 0
        smallFlourPack = Math.Floor(totalFlour / 250)

        If totalFlour Mod 250 <> 0 Then
            smallFlourPack += 1
        End If

        While smallFlourPack > 2
            smallFlourPack -= 3
            largeFlourPack += 1
        End While

        While smallFlourPack > 1
            smallFlourPack -= 2
            mediumFlourPack += 1
        End While

    End Sub

    Sub calculateSugar()
        smallSugarPack = 0
        mediumSugarPack = 0
        largeSugarPack = 0
        smallSugarPack = Math.Floor(totalSugar / 200)
        If totalSugar Mod 200 <> 0 Then
            smallSugarPack += 1
        End If

        While smallSugarPack > 2
            smallSugarPack -= 3
            largeSugarPack += 1
        End While

        While smallSugarPack > 1
            smallSugarPack -= 2
            mediumSugarPack += 1
        End While

    End Sub

    Sub calculateButter()
        smallButterPack = 0
        mediumButterPack = 0
        largeButterPack = 0

        smallButterPack = Math.Floor(totalButter / 125)

        If totalButter Mod 125 <> 0 Then
            smallButterPack += 1
        End If

        While smallButterPack > 3
            smallButterPack -= 4
            largeButterPack += 1
        End While

        While smallButterPack > 1
            smallButterPack -= 2
            mediumButterPack += 1
        End While

    End Sub

    Sub displayPackaging()

        smallPlainFlourBox.Text = smallFlourPack
        mediumFlourBox.Text = mediumFlourPack
        largeFlourBox.Text = largeFlourPack
        smallSugarBox.Text = smallSugarPack
        mediumSugarBox.Text = mediumSugarPack
        largeSugarBox.Text = largeSugarPack
        smallButterBox.Text = smallButterPack
        mediumButterBox.Text = mediumButterPack
        largeButterBox.Text = largeButterPack

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ingredQtys()
        displayIngredients()
        calculateButter()
        calculateFlour()
        calculateSugar()
        displayPackaging()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        drizzleCakeAmount.Value = 0
        cupCakeAmount.Value = 0
        Button1_Click(sender, New System.EventArgs())
    End Sub


End Class
