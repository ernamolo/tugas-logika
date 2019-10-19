Imports System.Console

Module Program
    Sub Main()
        KonversisuhudariFahrenheitkeCelcius()
        suhudariFahrenheitkeReamur()
        KonversisuhudariReamurkeFahrenheit()
        KonversisuhudariCelciuskeFahrenheit()
        Konversiyardkecm()
        Konversifeetkecm()
        Konversidarijamkemenit()
    End Sub
    Sub KonversisuhudariFahrenheitkeCelcius()
        Dim sngInpFahrenheit As Single
        Dim sngOutCelcius As Single
        WriteLine("* Konversi suhu dari Fahrenheit ke Celcius *")
        WriteLine("Input nilai suhu Fahrenheit:")
        sngInpFahrenheit = ReadLine()
        sngOutCelcius = 5 / 9 * (sngInpFahrenheit - 32)
        WriteLine("Hasil = " & sngOutCelcius & " Celcius.")
    End Sub
    Sub suhudariFahrenheitkeReamur()
        Dim sngInpReamur As Single
        Dim sngOutFahrenheit As Single
        WriteLine("* Konversi suhu dari Reamur ke Fahrenheit *")
        WriteLine("Input nilai suhu Reamur :")
        sngInpReamur = ReadLine()
        sngOutFahrenheit = 9 / 4 * sngInpReamur + 32
        WriteLine("Hasil = " & sngOutFahrenheit & "Fahrenheit")
    End Sub
    Sub KonversisuhudariReamurkeFahrenheit()
        Dim sngInpReamur As Single
        Dim sngOutFahrenheit As Single
        WriteLine("* Konversi suhu dari Reamur ke Fahrenheit *")
        WriteLine("Input nilai suhu Reamur :")
        sngInpReamur = ReadLine()
        sngOutFahrenheit = 9 / 4 * sngInpReamur + 32
        WriteLine("Hasil = " & sngOutFahrenheit & "Fahrenheit")
    End Sub
    Sub KonversisuhudariCelciuskeFahrenheit()
        Dim sngInpCelcius As Single
        Dim sngOutFahrenheit As Single
        WriteLine("= Konversi suhu dari Celcius ke Fahrenheit =")
        WriteLine("Input nilai suhu Celcius :")
        sngInpCelcius = ReadLine()
        sngOutFahrenheit = 9 / 5 * sngInpCelcius + 32
        WriteLine("Hasil = " & sngOutFahrenheit & "Fahrenheit")
    End Sub
    Sub Konversiyardkecm()
        Dim sngInpPanjang As Single
        Dim sngOutCM As Single
        WriteLine("* Konversi Bilangan Yard ke CM *")
        WriteLine("Input nilai Panjang: ")
        sngInpPanjang = ReadLine()
        sngOutCM = sngInpPanjang * 91.44
        WriteLine("Hasil = " & sngOutCM & " CM. ")
    End Sub

    Sub Konversifeetkecm()
        Dim sngInpPanjang As Single
        Dim sngOutCM As Single
        WriteLine("* Konversi Bilangan Feet ke CM *")
        WriteLine("Input nilai Panjang: ")
        sngInpPanjang = ReadLine()
        sngOutCM = sngInpPanjang * 30.48
        WriteLine("Hasil = " & sngOutCM & " CM. ")
    End Sub

    Sub Konversidarijamkemenit()
        Dim sngInpJam As Single
        Dim sngoutMenit As Single
        WriteLine("Konversi Waktu Jam ke Menit")
        WriteLine()
        WriteLine("Input Jam :")
        sngInpJam = ReadLine()
        sngoutMenit = sngInpJam * 60
        WriteLine("Hasil = " & sngoutMenit & "menit")

    End Sub
End Module