Imports System.Console

Module Program
    Sub Main()
        Mengecekkelulusan() '====>> Aplikasi 5 a
        Mengecekusia() '======>> aplikasi 5 b
        Menampilkannilai() '=====>> aplikasi 5 c
        Penilaianmahasiswa() '=====>> aplikasi 5 d
        '=====>> aplikasi 5 e

    End Sub
    Sub Mengecekkelulusan()
        'Mengecekkelulusan:jikanilaidiatas60makaLULUS,selainituTIDAKLULUS
        '1. Tentukan variabel
        Dim nilai As Byte
        Dim status As String

        '2. Masukkan Nilai
        WriteLine("APLIKASI CEK KELULUSAN")
        WriteLine("Masukkan Nilai")
        nilai = ReadLine()
        '3. Output
        If nilai > 60 Then
            status = "LULUS"
        Else
            status = "TDK LULUS"
        End If
        WriteLine("STATUS ANDA ADALAH " & status)
    End Sub
    Sub Mengecekusia()
        'jika umur 60 tahun ke atas maka statusnya Lansia
        'jika umur di antara 35 DAN 59 maka statusnya Dewasa
        'jika umur di antara 18 DAN 34 maka statusnya Pemuda
        'jika umur di antara 15 DAN 17 maka statusnya Remaja
        '1. tentukan Variabel
        Dim usia As Byte
        Dim status As String

        '2. Masukan usia
        WriteLine("APLIKASI CEK USIA")
        WriteLine("Masukan usia")
        usia = ReadLine()

        '3. ouput 
        If usia > 60 Then
            status = "LANSIA"
        End If
        If usia <= 35 And usia >= 59 Then
            status = "DEWASA"
        End If
        If usia <= 18 And usia >= 34 Then
            status = "PEMUDA"
        End If
        If usia <= 15 And usia >= 17 Then
            status = "REMAJA"
        End If
        WriteLine("STATUS ANDA ADALAH " & status)

    End Sub

    Sub Menampilkannilai()
        '>80 bernilai huruf BAIK SEKALI
        '>=65 bernilai huruf BAIK
        '>=55 bernilai huruf CUKUP
        '>=40 bernilai huruf KURANG
        '<40 bernilai huruf KURANG SEKALI
        '1. Tentukan variabel
        Dim nilai As Byte
        Dim status As String

        '2. Masukan nilai
        WriteLine("APLIKASI MENAMPILKAN NILAI HURUF")
        WriteLine("masukan nilai")
        nilai = ReadLine()

        '3. output
        If nilai > 80 Then
            status = "BAIK SEKALI"
        End If
        If nilai >= 65 Then
            status = "BAIK"
        End If
        If nilai >= 55 Then
            status = "CUKUP"
        End If
        If nilai >= 40 Then
            status = "KURANG"
        End If
        If nilai < 40 Then
            status = "KURANG SEKALI"
        End If
        WriteLine("STATUS ANDA ADALAH" & status)
    End Sub

    Sub Penilaianmahasiswa()
        'A jika nilai >=91 dan < 100
        'B jika nilai >=81 dan < 91
        'C jika nilai >=71 dan <81
        'D jika nilai <71
        '1. tampilkan variabel
        Dim nilai As Byte
        Dim status As String

        '2. masukan nilai
        WriteLine("APLIKASI PENILAIAN MAHASISWA")
        WriteLine("masukan nilai")
        nilai = ReadLine()

        '3. output
        If nilai >= 91 And nilai >= 100 Then
            status = "A"
        End If
        If nilai >= 81 And nilai >= 91 Then
            status = "B"
        End If
        If nilai >= 71 And nilai >= 81 Then
            status = "C"
        End If
        If nilai <= 71 Then
            status = "D"
        End If
        WriteLine("STATUS ANDA ADALAH" & status)
    End Sub
End Module