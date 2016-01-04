Module Other
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
