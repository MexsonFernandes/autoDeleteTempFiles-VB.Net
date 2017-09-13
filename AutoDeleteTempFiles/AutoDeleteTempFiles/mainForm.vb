Imports System.IO

Public Class mainForm
    Dim path = "C:\Users\" + Environment.UserName + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\cleantemp.bat"

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not File.Exists(path) Then
            Dim file As New IO.StreamWriter(path, True)
            file.WriteLine("rd %temp% /s /q")
            file.WriteLine("md %temp%")
            file.Close()
            MessageBox.Show("File created succesfully!!!", "SUCCESS")
        Else
            MessageBox.Show("File already exist!!!", "ERROR")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If File.Exists(path) Then
            File.Delete(path)
            MessageBox.Show("File deleted succesfully!!!", "SUCCESS")
        Else
            MessageBox.Show("File doesn't exist!!!", "ERROR")
        End If
    End Sub
End Class
