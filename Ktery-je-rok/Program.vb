Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zkus�me si zjistit, jak� st�tn� z��zen� se nach�zelo v t�chto kon�in�ch v dan�m roce...")
        Console.Write("Zadej, kter� je rok: ")
        Dim Rok = Console.ReadLine()

        If Rok < 1004 Then
            Console.WriteLine("Rok {0} je moc d�vno na to, abychom si to pamatovali." & vbCrLf, Rok)
        ElseIf Rok >= 1004 And Rok <= 1803 Then
            Console.WriteLine("V roce {0} byla na �zem� dne�n� �R v dan�m roce Svat� ��e ��msk�." & vbCrLf, Rok)
        ElseIf Rok >= 1804 And Rok <= 1866 Then
            Console.WriteLine("V roce {0} bylo na �zem� dne�n� �R v dan�m roce Rakousk� c�sa�stv�." & vbCrLf, Rok)
        ElseIf Rok >= 1867 And Rok <= 1917 Then
            Console.WriteLine("V roce {0} bylo na �zem� dne�n� �R v dan�m roce Rakousko-Uhersko." & vbCrLf, Rok)
        ElseIf Rok >= 1918 And Rok <= 1937 Then
            Console.WriteLine("V roce {0} bylo na �zem� dne�n� �R �eskoslovensko." & vbCrLf, Rok)
        ElseIf Rok >= 1938 And Rok <= 1944 Then
            Console.WriteLine("V roce {0} byl na �zem� dne�n� �R Protektor�t �echy a Morava." & vbCrLf, Rok)
        ElseIf Rok >= 1945 And Rok <= 1992 Then
            Console.WriteLine("V roce {0} bylo na �zem� dne�n� �R �eskoslovensko." & vbCrLf, Rok)
        Else
            Console.WriteLine("V�tej v �esk� republice!" & vbCrLf, Rok)

        End If

        Main()

    End Sub
End Module
