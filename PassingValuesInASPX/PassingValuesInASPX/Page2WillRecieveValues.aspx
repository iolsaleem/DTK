<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2WillRecieveValues.aspx.cs" Inherits="PassingValuesInASPX.Page2WillRecieveValues" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblResponseRedirect" runat="server" Text="LblResponseRedirect"></asp:Label>

        <br />
        <asp:Label ID="LabelCookies" runat="server" Text="LabelCookies"></asp:Label>
        
        <br />

        <asp:Label ID="LabelSession" runat="server" Text="LabelSession"></asp:Label>
                <br />

        <asp:Label ID="LabelApplication" runat="server" Text="LabelApplication"></asp:Label>


                        <br />

        <asp:Label ID="LabelHttpContext" runat="server" Text="LabelHttpContext"></asp:Label>


    </div>
    </form>
</body>
</html>
