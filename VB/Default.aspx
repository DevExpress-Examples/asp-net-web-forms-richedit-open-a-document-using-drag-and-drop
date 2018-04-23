<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function onUploadControlFileUploadComplete(s, e) {
            if(e.isValid)
                RichEdit.PerformCallback(e.callbackData);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxRichEdit ID="RichEdit" runat="server" OnCallback="RichEdit_Callback">
        </dx:ASPxRichEdit>

        <dx:ASPxUploadControl ID="UploadControl" runat="server" UploadMode="Auto" AutoStartUpload="True" ClientVisible="false" UploadStorage="FileSystem"
            OnFileUploadComplete="UploadControl_FileUploadComplete">
            <AdvancedModeSettings EnableDragAndDrop="True" EnableFileList="False" EnableMultiSelect="False" ExternalDropZoneID="RichEdit" />
            <FileSystemSettings UploadFolder="~\App_Data\Uploads" />
            <ClientSideEvents FileUploadComplete="onUploadControlFileUploadComplete" />
            <ValidationSettings AllowedFileExtensions=".doc,.docx,.rtf,.txt" MaxFileSize="4194304" />
        </dx:ASPxUploadControl>
    </div>
    </form>
</body>
</html>