Module Other
    Function getNumber(ByVal strFileName As String, ByVal strArgument As String) As String
        If My.Computer.FileSystem.FileExists(strFileName) Then
            Dim arrString() As String
            Using proc As New Process()
                proc.StartInfo.FileName = strFileName
                proc.StartInfo.Arguments = strArgument
                proc.StartInfo.CreateNoWindow = True

                ' Umleiten der Ausgabe:
                proc.StartInfo.UseShellExecute = False
                proc.StartInfo.RedirectStandardOutput = True

                ' Prozess starten:
                proc.Start()

                ' Ausgabe einlesen:
                Dim output As String = proc.StandardOutput.ReadToEnd()

                arrString = output.Split(New [Char]() {" "c})
                ' Ausgabe:
                If arrString(1).Length <> 33 Then
                    getNumber = "ERROR"
                Else
                    getNumber = output
                End If
            End Using
        Else
            getNumber = "ERROR"
        End If
    End Function

    Sub SubmitButton()
        frmCAcertCSR.webCAcert.Document.GetElementById("process").Focus()
        SendKeys.Send("{ENTER}")
    End Sub

    Sub DelFileOnExist(ByVal strFile As String)
        If My.Computer.FileSystem.FileExists(strFile) Then
            My.Computer.FileSystem.DeleteFile(strFile)
        End If
    End Sub

End Module
