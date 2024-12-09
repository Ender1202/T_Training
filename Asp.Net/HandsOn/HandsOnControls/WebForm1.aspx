<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HandsOnControls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Select Name
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="GreetUser" Text="Greet" />
            <br />
            <asp:Label ID="lblMsg" runat="server" Text="Hello Guest!!!"></asp:Label>

        </div>
    </form>
</body>
</html>
