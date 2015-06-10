Public Class Form1

    Dim numberOfFlour As Integer
    Dim smallFlourPacks As Integer
    Dim largeFlourPacks As Integer
    Dim mediumFlourPacks As Integer
    Dim smallSugarPacks As Integer
    Dim mediumSugarPacks As Integer
    Dim largeSugarPacks As Integer
    Dim smallButterPacks As Integer
    Dim mediumButterPacks As Integer
    Dim largeButterPacks As Integer
    Dim numberOfButter As Integer
    Dim numberOfSugar As Integer
    Dim drizzleCakeFlour, cupCakeFlour, drizzleCakeSugar, cupCakeButter, drizzleCakeButter, cupCakeSugar, getCakes As Integer
    Dim completeFlour As Integer
    Dim drizzleCakeEgg, cupCakeEgg, totalEgg As Decimal
    Dim smallEggBoxes, mediumEggBoxes, largeEggBoxes, completeSugar, completeButter As Integer


    Sub ammountOfFlour()

        drizzleCakeFlour = drizzleCakeAmmount.Value * 240
        cupCakeFlour = cupCakeAmmount.Value * 12
        completeFlour = cupCakeFlour + drizzleCakeFlour
    End Sub

    Sub ammountOfSugar()

        drizzleCakeSugar = drizzleCakeAmmount.Value * 300
        cupCakeSugar = cupCakeAmmount.Value * 14
        completeSugar = cupCakeSugar + drizzleCakeSugar
    End Sub

    Sub ammountOfButter()

        drizzleCakeButter = drizzleCakeAmmount.Value * 240
        cupCakeButter = cupCakeAmmount.Value * 4
        completeButter = cupCakeButter + drizzleCakeButter
    End Sub

    Sub ammountOfEggs()

        drizzleCakeEgg = drizzleCakeAmmount.Value * 4.5
        cupCakeEgg = cupCakeAmmount.Value * 0.1
        totalEgg = cupCakeEgg + drizzleCakeEgg

    End Sub

    Sub displayCustomerTotals()

        totalFlour.Text = completeFlour
        totalSugar.Text = completeSugar
        totalButter.Text = completeButter
        totalEggs.Text = totalEgg
    End Sub


    Sub calculateFlour()

        smallFlourPacks = Math.Floor(completeFlour / 250)

        If completeFlour Mod 250 <> 0 Then
            smallFlourPacks += 1
        End If

        While smallFlourPacks > 2
            smallFlourPacks -= 3
            largeFlourPacks += 1
        End While

        While smallFlourPacks > 1
            smallFlourPacks -= 2
            mediumFlourPacks += 1
        End While

    End Sub

    Sub calculateSugar()

        smallSugarPacks = Math.Floor(completeSugar / 200)

        If numberOfSugar Mod 200 <> 0 Then
            smallSugarPacks += 1
        End If

        While smallSugarPacks > 2
            smallSugarPacks -= 3
            largeSugarPacks += 1
        End While

        While smallSugarPacks > 1
            smallSugarPacks -= 2
            mediumSugarPacks += 1
        End While

    End Sub

    Sub calculateButter()

        numberOfButter = Console.ReadLine()
        smallButterPacks = Math.Floor(completeButter / 125)

        If numberOfButter Mod 125 <> 0 Then
            smallButterPacks += 1
        End If

        While smallButterPacks > 3
            smallButterPacks -= 4
            largeButterPacks += 1
        End While

        While smallButterPacks > 1
            smallButterPacks -= 2
            mediumButterPacks += 1
        End While

    End Sub

    Sub calculateEgg()

        largeEggBoxes = 0
        mediumEggBoxes = 0
        smallEggBoxes = 0
        Dim six, ten As Integer
        While totalEgg > 5

            six = 6
            ten = 10

            While totalEgg > six
                six += 6
            End While

            While totalEgg > ten
                ten += 10
            End While

            six -= totalEgg
            ten -= totalEgg
            If six <= ten Then
                smallEggBoxes += 1
                totalEgg -= 6

            Else
                mediumEggBoxes += 1
                totalEgg -= 10
            End If
        End While



        If totalEgg > 0 And totalEgg < 7 Then
            smallEggBoxes += 1

        ElseIf totalEgg > 6 Then
            mediumEggBoxes += 1
        End If

        While smallEggBoxes > 1
            largeEggBoxes += 1
            smallEggBoxes -= 2

        End While

    End Sub

    Sub roundEggs()

        Math.Ceiling(totalEgg)

    End Sub

    Sub displayTotal()

        smallFlourPack.Text = smallFlourPacks
        mediumFlourPack.Text = mediumFlourPacks
        largeFlourPack.Text = largeFlourPacks
        smallSugarPack.Text = smallSugarPacks
        mediumSugarPack.Text = mediumSugarPacks
        largeSugarPack.Text = largeSugarPacks
        smallButterPack.Text = smallButterPacks
        mediumButterPack.Text = mediumButterPacks
        largeButterPack.Text = largeButterPacks
        smallEggBox.Text = smallEggBoxes
        mediumEggBox.Text = mediumEggBoxes
        largeEggBox.Text = largeEggBoxes

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ammountOfButter()
        ammountOfFlour()
        ammountOfSugar()
        ammountOfEggs()
        displayTotal()
        displayCustomerTotals()
        roundEggs()
        calculateButter()
        calculateFlour()
        calculateSugar()
        calculateEgg()
        displayTotal()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        drizzleCakeAmmount.Value = 0
        cupCakeAmmount.Value = 0
        Button1_Click(sender, New System.EventArgs())
    End Sub

End Class













   
  
