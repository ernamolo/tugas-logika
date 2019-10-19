Imports System.Console

Module Program
    Sub Main()
        OutputTulisan()
        LuasPersegiPanjang()
        KelilingPersegiPanjang()
        LuasSegitiga()
        KelilingSegitiga()
        LuasBalok()
        VolumeBalok()
        LuasLingkaran()
        LuasTabung()
        LuasTrapesium()
        CekBilanganGanjilGenap()
        CekBilanganNegatifPositif()

    End Sub
    Sub OutputTulisan()
        Dim Nama As String
        Dim Umur As Byte
        WriteLine("Output Tulisan")
        Nama = "Bernadetha"
        Umur = 24
        WriteLine("Nama :" & Nama)
        WriteLine("Umur :" & Umur)
        WriteLine()
    End Sub
    Sub LuasPersegiPanjang()
        Dim P, L, luas As Integer
        WriteLine("Rumus Persegi Panjang")
        WriteLine("Masukkan P =")
        P = ReadLine()
        WriteLine("Masukkan L =")
        L = ReadLine()

        luas = P * L
        WriteLine("Luas =" & luas)

    End Sub
    Sub KelilingPersegiPanjang()
        Dim P, L, Keliling As Integer
        WriteLine("Rumus keliling persegi panjang")
        WriteLine("Masukkan P =")
        P = ReadLine()
        WriteLine("Masukkan L =")
        L = ReadLine()

        Keliling = 2 * (P + L)
        WriteLine("Keliling =" & Keliling)
    End Sub
    Sub LuasSegitiga()
        Dim A, T, Luas As Integer

        WriteLine("Luas Segitiga")
        WriteLine("Masukkan A =")
        A = ReadLine()
        WriteLine("Masukkan T =")
        T = ReadLine()

        Luas = 1 / 2 * A * T

        WriteLine("Luas =" & Luas)
    End Sub
    Sub KelilingSegitiga()
        Dim A, B, C, Keliling As Integer
        WriteLine("Keliling Segitiga")
        WriteLine("Masukkan A =")
        A = ReadLine()
        WriteLine("Masukkan B =")
        B = ReadLine()
        WriteLine("Masukkan C =")
        C = ReadLine()

        Keliling = A + B + C
        WriteLine("Keliling =" & Keliling)
    End Sub
    Sub LuasBalok()
        Dim P, L, T, Luas As Integer
        WriteLine("Luas Balok")
        WriteLine("Masukkan P =")
        P = ReadLine()
        WriteLine("Masukkan L =")
        L = ReadLine()
        WriteLine("Masukkan T =")
        T = ReadLine()

        Luas = 2 * (P * L + P * T + L * T)
        WriteLine("Luas =" & Luas)
    End Sub
    Sub VolumeBalok()
        Dim P, L, T, Volume As Integer
        WriteLine("Volume Balok")
        WriteLine("Masukkan P =")
        P = ReadLine()
        WriteLine("Masukkan L =")
        L = ReadLine()
        WriteLine("Masukkan T =")
        T = ReadLine()

        Volume = P * L * T
        WriteLine("Volume =" & Volume)
    End Sub
    Sub LuasLingkaran()
        Dim R, Luas As Single
        WriteLine("Luas Lingkaran")
        WriteLine("Masukkan R =")
        R = ReadLine()

        Luas = 22 / 7 * R * R

        WriteLine("Luas =" & Luas)

    End Sub
    Sub LuasTabung()
        Dim R, T, Luas As Single
        WriteLine("Luas Tabung")
        WriteLine("Masukkan R =")
        R = ReadLine()
        WriteLine("Masukkan T")
        T = ReadLine()

        Luas = (22 / 7 * R * R) * T

        WriteLine("Luas =" & Luas)

    End Sub
    Sub LuasTrapesium()
        Dim a, b, T, Luas As Integer
        WriteLine("Luas Trapesium")
        WriteLine("Masukkan a =")
        a = ReadLine()
        WriteLine("Masukkan b =")
        b = ReadLine()
        WriteLine("Masukkan T =")
        T = ReadLine()

        Luas = 1 / 2 * (a + b) * T
        WriteLine("Luas =" & Luas)
    End Sub
    Sub CekBilanganGanjilGenap()
        WriteLine("Bilangan Ganjil & Genap")
        Dim Bilangan As Single
        Dim hasil As String
        WriteLine("Apakah bilangan Ganjil atau Genap")
        WriteLine("Masukkan Bilangan")
        Bilangan = ReadLine()
        If Bilangan Mod 2 = 0 Then
            hasil = Bilangan & "Adalah Bilangan Genap"
        Else
            hasil = Bilangan & "Adalah Bilangan Ganjil"
        End If
        WriteLine("Hasil =" & hasil)
    End Sub
    Sub CekBilanganNegatifPositif()
        WriteLine("Bilangan Positif & Negatif")
        Dim Bilangan As Single
        Dim Hasil As String

        WriteLine("Apakah Bilangan Positif atau Negatif")
        WriteLine("Masukkan Bilangan :")
        Bilangan = ReadLine()

        If Bilangan >= 0 Then
            Hasil = Bilangan & " Adalah Bilangan Positif"
        End If
        If Bilangan <= 0 Then
            Hasil = Bilangan & "Adalah Bilangan Negatif"
        End If
        WriteLine("Hasil =" & Hasil)
    End Sub
End Module
