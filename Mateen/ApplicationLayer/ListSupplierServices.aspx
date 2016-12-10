<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListSupplierServices.aspx.cs" Inherits="ApplicationLayer.ListSupplierServices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <h1><center>Supplier Service List</center></h1>
        </div>
        <hr />
        <div>
            <asp:LinkButton ID="lnkPrevious" runat="server" OnClick="lnkPrevious_Click" >Prev Page</asp:LinkButton>
            <asp:LinkButton ID="lnkNext" runat="server" OnClick="lnkNext_Click"  >Next Page</asp:LinkButton>
        </div>
        <hr />
        <asp:Repeater ID="Rptr_ListSupplierServices" runat="server" OnItemDataBound="Rptr_ListSupplierServices_ItemDataBound">
            <HeaderTemplate>
            <div style="background:red">
                <span style="width:45px"><asp:Label ID="hdrServiceType" runat="server" Text="ServiceType"></asp:Label></span>
                <span style="width:45px"><asp:Label ID="hdrServiceName" runat="server" Text="ServiceName"></asp:Label></span>
                <span style="width:45px"><asp:Label ID="hdrStatus" runat="server" Text="Status"></asp:Label></span>
                <span style="width:45px"><asp:Label ID="hdrSupplierName" runat="server" Text="SupplierName"></asp:Label></span>
                <span style="width:45px"><asp:Label ID="hdrCountry" runat="server" Text="Country"></asp:Label></span>
                <span style="width:45px"><asp:Label ID="hdrCity" runat="server" Text="City"></asp:Label></span>
                <span style="width:45px"><asp:Label ID="hdrContract" runat="server" Text="Contract"></asp:Label></span>
                <span style="width:45px"><asp:Label ID="hdrDetails" runat="server" Text="Details"></asp:Label></span>
            </div>
            </HeaderTemplate>
            <ItemTemplate>
               <div>
               <asp:HiddenField ID="hndPid" runat="server" />
               <span style="width:45px">  <asp:Label ID="lblServiceType" runat="server" Text="ServiceType"></asp:Label></span>
               <span style="width:45px"> <asp:Label ID="lblServiceName" runat="server" Text="ServiceName"></asp:Label></span>
               <span style="width:45px"> <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label></span>
               <span style="width:45px"><asp:Label ID="lblSupplierName" runat="server" Text="SupplierName"></asp:Label></span>
               <span style="width:45px"><asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label></span>
               <span style="width:45px"><asp:Label ID="lblCity" runat="server" Text="City"></asp:Label></span>
               <span style="width:45px"><asp:HyperLink ID="hypContract" runat="server">Contract</asp:HyperLink></span>
               <span style="width:45px"><asp:HyperLink ID="hypDetails" runat="server">Details</asp:HyperLink></span>
               </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
