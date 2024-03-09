Imports System.IO

Module Module1
    Sub Main()
        Dim filePath As String = "your_file_path.txt"

        Try
            ' Open the text file using a StreamReader
            Using reader As New StreamReader(filePath)
                ' Read the entire file and print its content to the console
                Console.WriteLine(reader.ReadToEnd())
            End Using
        Catch ex As Exception
            ' Handle any errors that occur during file reading
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try

        ' Wait for user input before closing the console window
        Console.ReadLine()
    End Sub
End Module
