<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1WillSendValues.aspx.cs" Inherits="PassingValuesInASPX.Page1WillSendValues" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
              <asp:Button ID="BtnResponseRedirect" runat="server" Text="ResponseRedirect" OnClick="BtnResponseRedirect_Click" />
      <br />  <asp:Button ID="BtnSessionVariable" runat="server" Text="SessionVariable" OnClick="BtnSessionVariable_Click" />
      <br />   <asp:Button ID="BtnCookies" runat="server" Text="Cookies" OnClick="BtnCookies_Click" />
      <br />   <asp:Button ID="BtnApplicationState" runat="server" Text="ApplicationState" OnClick="BtnApplicationState_Click" />
      <br />   <asp:Button ID="BtnHTTPCONTEXT" runat="server" Text="HTTPCONTEXT" OnClick="BtnHTTPCONTEXT_Click"  />
    </div>
    </form>
</body>
</html>
