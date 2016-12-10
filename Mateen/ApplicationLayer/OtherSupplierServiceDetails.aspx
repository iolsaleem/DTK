<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherSupplierServiceDetails.aspx.cs" Inherits="ApplicationLayer.OtherSupplierServiceDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <span><center>Supplier Service Other Details</center></span><br/>

        <asp:Label ID="lblForServiceDisplay" runat="server" Text="ForService"></asp:Label>
        <asp:Label ID="lblForServiceValue" runat="server"   Text =""></asp:Label>
        <hr/>
    </div>
        <div id="Menu">
            <ul>
      <li>
           
          <span><asp:HyperLink ID="HypServDesc" runat="server" NavigateUrl="~/ServiceDescriptionDetails.aspx">Service Description Details</asp:HyperLink> </span>
           &nbsp;&nbsp;&nbsp;<br />
      </li>
     <li> 
           <span><asp:LinkButton ID="LnkAllocationDtl" runat="server">Allocation Details</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
     </li>      
      <li>    
           <span><asp:LinkButton ID="LnkChargeType" runat="server">Charge Type</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
        </li>
            <li>        
                 <span><asp:LinkButton ID="LnkPicture" runat="server">Picture</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
            </li>
                <li>
                <span><asp:LinkButton ID="LnkMessage" runat="server">Message</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
            </li>
                <li>
                <span><asp:LinkButton ID="LnkOpenClose" runat="server">Open Close</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
          </li>
                <li>
                  <span><asp:LinkButton ID="LnkLanguage" runat="server">Language </asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
           </li>
                <li>
                 <span><asp:LinkButton ID="LnkServiceTime" runat="server">Service Time</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
            </li>
                <li>
                <span><asp:LinkButton ID="LnkPickUpPoints" runat="server">Pick Up Points</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
            </li>
                <li>
                <span><asp:LinkButton ID="LnkAttribute" runat="server">Attribute</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
            </li>
                <li>
                <span><asp:LinkButton ID="LnkVehicletypes" runat="server">Vehicle Types</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
            </li>
                <li>
                <span><asp:LinkButton ID="LnkChildServices" runat="server">Child Services</asp:LinkButton></span>
            &nbsp;&nbsp;&nbsp;<br />
            </li>
                <li>
                <span><asp:LinkButton ID="LnkContract" runat="server"> Go To Contract</asp:LinkButton></span>
                    </li>
        </ul>
      </div>
    </form>
</body>
</html>
