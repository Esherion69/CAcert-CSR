Public Class WebBrowserForm
    Private myBrowser As WebBrowser
    Private LastHtmlElement As HtmlElement

    Public Sub New(ByVal WebBrowser As WebBrowser)
        myBrowser = WebBrowser
    End Sub

    Public Sub InnerText(ByVal TextboxName As String, ByVal Value As String)
        myBrowser.Document.GetElementById(TextboxName).InnerText = Value

        LastHtmlElement = myBrowser.Document.GetElementById(TextboxName)
    End Sub

    Public Sub Checkbox(ByVal CheckboxName As String, ByVal Checked As Boolean)
        Dim sCheckState As String = ""
        If Checked Then sCheckState = "checked"
        myBrowser.Document.GetElementById(CheckboxName).SetAttribute("checked", sCheckState)
        LastHtmlElement = myBrowser.Document.GetElementById(CheckboxName)
    End Sub

    Public Sub Radiobox(ByVal RadioboxName As String, ByVal Value As String, Optional ByVal Checked As Boolean = True)
        Dim sCheckState As String = ""
        If Checked Then sCheckState = "checked"
        For Each oElement As HtmlElement In myBrowser.Document.GetElementsByTagName("INPUT")
            If oElement.Name = RadioboxName And oElement.GetAttribute("value") = Value Then
                oElement.SetAttribute("checked", sCheckState)
                LastHtmlElement = oElement
                Exit For
            End If
        Next
    End Sub

    Public Sub SelectListItem(ByVal ListboxName As String, ByVal Index As Integer)
        myBrowser.Document.GetElementById(ListboxName).Children(Index).SetAttribute("selected", "selected")
        LastHtmlElement = myBrowser.Document.GetElementById(ListboxName)
    End Sub

    Public Sub Submit()
        Dim FormElement As HtmlElement = GetForm(LastHtmlElement)
        FormElement.InvokeMember("submit")
    End Sub

    Private Function GetForm(ByVal CurrentHtmlElement As HtmlElement) As HtmlElement
        Try
            If CurrentHtmlElement.TagName.ToLower() = "form" Then
                Return CurrentHtmlElement
            Else
                Return GetForm(CurrentHtmlElement.Parent)
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class