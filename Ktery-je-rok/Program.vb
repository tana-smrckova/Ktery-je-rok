Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zkusíme si zjistit, jaké státní zøízení se nacházelo v tìchto konèinách v daném roce...")
        Console.Write("Zadej, který je rok: ")
        Dim Rok = Console.ReadLine()

        If Rok < 1004 Then
            Console.WriteLine("Rok {0} je moc dávno na to, abychom si to pamatovali." & vbCrLf, Rok)
        ElseIf Rok >= 1004 And Rok <= 1803 Then
            Console.WriteLine("V roce {0} byla na území dnešní ÈR v daném roce Svatá øíše øímská." & vbCrLf, Rok)
        ElseIf Rok >= 1804 And Rok <= 1866 Then
            Console.WriteLine("V roce {0} bylo na území dnešní ÈR v daném roce Rakouské císaøství." & vbCrLf, Rok)
        ElseIf Rok >= 1867 And Rok <= 1917 Then
            Console.WriteLine("V roce {0} bylo na území dnešní ÈR v daném roce Rakousko-Uhersko." & vbCrLf, Rok)
        ElseIf Rok >= 1918 And Rok <= 1937 Then
            Console.WriteLine("V roce {0} bylo na území dnešní ÈR Èeskoslovensko." & vbCrLf, Rok)
        ElseIf Rok >= 1938 And Rok <= 1944 Then
            Console.WriteLine("V roce {0} byl na území dnešní ÈR Protektorát Èechy a Morava." & vbCrLf, Rok)
        ElseIf Rok >= 1945 And Rok <= 1992 Then
            Console.WriteLine("V roce {0} bylo na území dnešní ÈR Èeskoslovensko." & vbCrLf, Rok)
        Else
            Console.WriteLine("Vítej v Èeské republice!" & vbCrLf, Rok)

        End If

        Main()

    End Sub
End Module
