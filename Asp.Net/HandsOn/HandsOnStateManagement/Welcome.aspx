<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="HandsOnStateManagement.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome,<asp:Label ID="Label1" runat="server" Text="Guest"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Transaction.aspx">Show Transactions</asp:HyperLink>
        </div>
    </form>
</body>
</html>
