

Imports System.IO

Module Module1



    Sub Main()


        Dim myReader As StreamReader = New StreamReader("Value.txt")
        Dim line As String = ""

        While Not IsNothing(line)
            line = myReader.ReadLine()
            If Not IsNothing(line) Then
                Console.WriteLine(line)
            End If
        End While

        myReader.Close()
        Console.ReadLine()



        Console.WriteLine()
    End Sub

End Module
