<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchSupplierServices.aspx.cs" Inherits="ApplicationLayer.SearchSupplierServices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span><center>Search Supplier Services</center></span>   
    </div>
        <hr />
        
        <div>
        
        <span>
        <center>
                <asp:Label ID="lblServiceCode" runat="server" Text="Service Code"></asp:Label>
                <asp:TextBox ID="txtServiceCode" runat="server"></asp:TextBox>
                <br/>
        </center>
        </span>
        
        <span>
        <center>
                <asp:Label ID="lblServiceType" runat="server" Text="ServiceType"></asp:Label>
                <asp:DropDownList ID="ddlServiceType" runat="server"></asp:DropDownList>
                <br/>
        </center>
        </span>
        
        <span>
        <center>
                <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                    <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_IndexChanged"></asp:DropDownList>
               <br/>
        </center>
        </span> 
        
        <span>
        <center>
                    <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                        <asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList>
                    <br/>

        </center>
        </span>

        <span>
        <center>
                <asp:Label ID="lblServiceName" runat="server" Text="ServiceName"></asp:Label>
                <asp:TextBox ID="txtServiceName" runat="server"></asp:TextBox>
                <br/>
        </center>
        </span>
       
         <span>
        <center>
                <asp:Label ID="lblSupplier" runat="server" Text="Supplier"></asp:Label>
                <asp:DropDownList ID="ddlSupplier" runat="server"></asp:DropDownList>
                <br/>
        </center>
        </span>


        <span>
        <center>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" />
        </center>
        </span>
    </div>
    <asp:HiddenField ID="hdnCompanyxid" runat="server" value="" />
    </form>

</body>
</html>
