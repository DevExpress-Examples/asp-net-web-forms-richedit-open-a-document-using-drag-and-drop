<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545443/16.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T438419)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxRichEdit - How to open a document using drag-and-drop


In some scenarios, it is necessary to load a document stored on a user's hard disk to the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.class">ASPxRichEdit</a> control. The <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.class">ASPxRichEdit</a> does not support this feature, but you can use a workaround described in this example. Note, that in this example the open document is not saved to the <strong>Working Directory</strong>. If you need to save the open document to the <strong>Working Directory</strong> see <a href="https://www.devexpress.com/Support/Center/Example/Details/T437842/aspxrichedit-how-to-upload-a-document-in-the-working-directory-using-drag-and-drop">this</a> example.<br><br>The <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxUploadControl.class">ASPxUploadControl</a> is developed to save client files to the server via a browser. This control includes the <a href="https://documentation.devexpress.com/AspNet/9886/ASP-NET-WebForms-Controls/File-Management/File-Upload/Concepts/Upload-Modes">Advanced mode</a> that allows users to load documents using drag-and-drop. The <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxUploadControl.class">ASPxUploadControl's</a> <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.UploadAdvancedModeSettings.ExternalDropZoneID.property">ExternalDropZoneID</a> property defines which HTML element is used to release files dragged from the client's hardware. Using this property, you can invoke document loading by dragging it to the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.class">ASPxRichEdit</a> control. When the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxUploadControl.class">ASPxUploadControl</a> finishes loading the document, it is saved as a stream via the <a href="https://documentation.devexpress.com/DocumentServer/17488/Rich-Edit-Document-Server">RichEditDocumentServer</a> and opened in the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.class">ASPxRichEdit</a> control.

<br/>


