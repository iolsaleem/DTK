<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceDescriptionDetails.aspx.cs" Inherits="ApplicationLayer.ServiceDescriptionDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1><center>Service Description Details</center></h1>
    </div>
 <hr />
    <div>
        <asp:Button ID="btnAddLangDesc" runat="server" Text="Add" /> &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModifyLangDesc" runat="server" Text="Modify" /> &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDeleteLangDesc" runat="server" Text="Delete" />
    </div>
 <hr /> 
     <div>
         <asp:Repeater ID="Rptr_ServiceDescriptiondetails" runat="server">
             <HeaderTemplate>
                 <asp:Label ID="lblSelect" runat="server" Text="Select"></asp:Label>
                 <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                 <asp:Label ID="lblLanguageName" runat="server" Text="Language Name"></asp:Label>
                 <asp:Label ID="lblBookingFromDate" runat="server" Text="Booking From Date"></asp:Label>
                 <asp:Label ID="lblBookingToDate" runat="server" Text="Booking To Date"></asp:Label>
                 <asp:Label ID="lblTravelFromDate" runat="server" Text="Travel From Date"></asp:Label>
                 <asp:Label ID="lbltravelToDate" runat="server" Text="Travel To Date"></asp:Label>
                 <asp:Label ID="lblSourcefrm" runat="server" Text="Source From"></asp:Label>
                 <asp:Label ID="lblModifiedBy" runat="server" Text="Modified By"></asp:Label>
                 <asp:Label ID="lblModifiedOn" runat="server" Text="Modified On"></asp:Label>
             </HeaderTemplate>
             <ItemTemplate>
                 <asp:HiddenField ID="HiddenField1" runat="server" />
                 <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
                 <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                 <asp:Label ID="lblLanguageName" runat="server" Text="Language Name"></asp:Label>
                 <asp:Label ID="lblBookingFromDate" runat="server" Text="Booking From Date"></asp:Label>
                 <asp:Label ID="lblBookingToDate" runat="server" Text="Booking To Date"></asp:Label>
                 <asp:Label ID="lblTravelFromDate" runat="server" Text="Travel From Date"></asp:Label>
                 <asp:Label ID="lbltravelToDate" runat="server" Text="Travel To Date"></asp:Label>
                 <asp:Label ID="lblSourcefrm" runat="server" Text="Source From"></asp:Label>
                 <asp:Label ID="lblModifiedBy" runat="server" Text="Modified By"></asp:Label>
                 <asp:Label ID="lblModifiedOn" runat="server" Text="Modified On"></asp:Label>
             </ItemTemplate>
         </asp:Repeater>
    </div>
    </form>
</body>
</html>
