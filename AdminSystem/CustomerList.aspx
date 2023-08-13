<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 42px;
            left: 10px;
            z-index: 1;
            width: 501px;
            height: 387px;
            bottom: 309px;
        }
        .auto-style2 {
            position: absolute;
            top: 457px;
            left: 11px;
            z-index: 1;
            height: 35px;
            right: 1732px;
        }
        .auto-style3 {
            position: absolute;
            top: 456px;
            left: 73px;
            z-index: 1;
            height: 33px;
        }
        .auto-style4 {
            position: absolute;
            top: 643px;
            left: 10px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 455px;
            left: 135px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 519px;
            left: 183px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 570px;
            left: 99px;
            z-index: 1;
            height: 35px;
        }
        .auto-style12 {
            position: absolute;
            top: 571px;
            left: 10px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 519px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body style="height: 18px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style5" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnClear" runat="server" CssClass="auto-style11" OnClick="btnClear_Click" Text="Clear" />
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style4"></asp:Label>

        <asp:TextBox ID="txtFilter" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style12" OnClick="btnApply_Click" Text="Apply" />
        <asp:ListBox ID="lstCustomerList" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblEnterapostcode" runat="server" CssClass="auto-style13" Text="Enter a postcode"></asp:Label>
    </form>
</body>
</html>
