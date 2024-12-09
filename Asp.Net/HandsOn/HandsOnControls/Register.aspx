<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HandsOnControls.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 59%;
            height: 517px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td>Name *</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage=" Pls Enter Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Age between 18 to 40" MaximumValue="40" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>MobileNo</td>
                    <td>
                        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtMobile" ErrorMessage="Enter Valid Mobile No" ValidationExpression="[6-9][0-9]{9}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Country</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                            <asp:ListItem>China</asp:ListItem>
                            <asp:ListItem>Japan</asp:ListItem>
                            <asp:ListItem>Russia</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Enter Login Credentials</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>UserName *</td>
                    <td>
                        <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUname" ErrorMessage="Please Enter Username"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password *</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPwd" ErrorMessage="  Please Enter Password" Text="*"> </asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtPwd" ErrorMessage="Password allow only 6 alpha numerics" ValidationExpression="[a-zA-Z0-9]{6}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password</td>
                    <td>
                        <asp:TextBox ID="txtCPwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtCPwd" ErrorMessage="Password Mismatch"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="SaveUser" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
