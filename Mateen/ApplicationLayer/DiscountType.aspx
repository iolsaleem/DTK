<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiscountType.aspx.cs" Inherits="ApplicationLayer.DiscountType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Rptr" runat="server" OnItemDataBound="Rptr_ItemDataBound">
            <ItemTemplate>
        <asp:Label ID="lblDiscountType" runat="server" Text="DiscountType"></asp:Label>
                </ItemTemplate>
            </asp:Repeater>
    </div>
    </form>
</body>
</html>
