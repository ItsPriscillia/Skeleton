<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 15px;
            left: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 11px;
            z-index: 1;
            left: 172px;
        }
        .auto-style3 {
            position: absolute;
            top: 108px;
            left: 12px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 61px;
            left: 14px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 154px;
            left: 10px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 201px;
            left: 10px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 249px;
            left: 10px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 296px;
            left: 10px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 347px;
            left: 10px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 59px;
            left: 171px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 115px;
            left: 169px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 164px;
            left: 169px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 210px;
            left: 168px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 259px;
            left: 169px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 418px;
            left: 10px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 417px;
            left: 82px;
            z-index: 1;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerNo" runat="server" CssClass="auto-style1" style="z-index: 1" Text="CustomerID" width="84px"></asp:Label>
        <div>
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="lblFirstname" runat="server" CssClass="auto-style4" height="27px" Text="Firstname" width="84px"></asp:Label>
        <asp:Label ID="lblLastname" runat="server" CssClass="auto-style3" height="27px" Text="Lastname" width="84px"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" CssClass="auto-style5" height="27px" Text="Email" width="84px"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" CssClass="auto-style6" height="27px" Text="Postcode" width="84px"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" CssClass="auto-style7" height="27px" Text="DOB" width="84px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style8" Text="Active" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style9"></asp:Label>
        <asp:TextBox ID="txtLastname" runat="server" CssClass="auto-style11" height="29px" width="188px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style12" height="29px" width="188px"></asp:TextBox>
            <asp:TextBox ID="txtFirstname" runat="server" CssClass="auto-style10" height="29px" width="188px"></asp:TextBox>
            <asp:TextBox ID="txtPostcode" runat="server" CssClass="auto-style13" height="29px" width="188px"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style14" height="29px" width="188px"></asp:TextBox>
        </p>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style15" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style16" Text="Cancel" />
    </form>
</body>
</html>
