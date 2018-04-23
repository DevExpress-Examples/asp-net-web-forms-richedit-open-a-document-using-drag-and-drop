Imports DevExpress.Web.Office
Imports DevExpress.XtraRichEdit
Imports System.IO

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private uploadedDocId As String = "uploadedDocId"

    Protected Sub UploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
        If e.UploadedFile.IsValid Then
            e.CallbackData = e.UploadedFile.FileNameInStorage
        End If
    End Sub

    Protected Sub RichEdit_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
        Dim path As String = MapPath(UploadControl.FileSystemSettings.UploadFolder) & "\" & e.Parameter
        Using stream As New MemoryStream()
            Using server As New RichEditDocumentServer()
                server.LoadDocument(path)
                server.SaveDocument(stream, DocumentFormat.OpenXml)
                stream.Position = 0
                DocumentManager.CloseDocument(uploadedDocId)
                RichEdit.Open(uploadedDocId, DocumentFormat.OpenXml, Function() stream)
            End Using
        End Using
        File.Delete(path)
    End Sub
End Class