using DevExpress.Web.Office;
using DevExpress.XtraRichEdit;
using System.IO;

public partial class _Default : System.Web.UI.Page {
    string uploadedDocId = "uploadedDocId";

    protected void UploadControl_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        if(e.UploadedFile.IsValid)
            e.CallbackData = e.UploadedFile.FileNameInStorage;
    }

    protected void RichEdit_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        string path = MapPath(UploadControl.FileSystemSettings.UploadFolder) + "\\" + e.Parameter;
        using(MemoryStream stream = new MemoryStream()) {
            using(RichEditDocumentServer server = new RichEditDocumentServer()) {
                server.LoadDocument(path);
                server.SaveDocument(stream, DocumentFormat.OpenXml);
                stream.Position = 0;
                DocumentManager.CloseDocument(uploadedDocId);
                RichEdit.Open(uploadedDocId, DocumentFormat.OpenXml, () => stream);
            }
        }
        File.Delete(path);
    }
}