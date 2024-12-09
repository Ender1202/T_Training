<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Demo3.aspx.cs" Inherits="HandsOnDataBindControls.Demo3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="PId" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="PIdLabel" runat="server" Text='<%# Eval("PId") %>' />
                </td>
                <td>
                    <asp:Label ID="PnameLabel" runat="server" Text='<%# Eval("Pname") %>' />
                </td>
                <td>
                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                </td>
                <td>
                    <asp:Label ID="StockLabel" runat="server" Text='<%# Eval("Stock") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:Label ID="PIdLabel1" runat="server" Text='<%# Eval("PId") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PnameTextBox" runat="server" Text='<%# Bind("Pname") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StockTextBox" runat="server" Text='<%# Bind("Stock") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="PIdTextBox" runat="server" Text='<%# Bind("PId") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PnameTextBox" runat="server" Text='<%# Bind("Pname") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StockTextBox" runat="server" Text='<%# Bind("Stock") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="PIdLabel" runat="server" Text='<%# Eval("PId") %>' />
                </td>
                <td>
                    <asp:Label ID="PnameLabel" runat="server" Text='<%# Eval("Pname") %>' />
                </td>
                <td>
                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                </td>
                <td>
                    <asp:Label ID="StockLabel" runat="server" Text='<%# Eval("Stock") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server"></th>
                                <th runat="server">PId</th>
                                <th runat="server">Pname</th>
                                <th runat="server">Price</th>
                                <th runat="server">Stock</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="PIdLabel" runat="server" Text='<%# Eval("PId") %>' />
                </td>
                <td>
                    <asp:Label ID="PnameLabel" runat="server" Text='<%# Eval("Pname") %>' />
                </td>
                <td>
                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                </td>
                <td>
                    <asp:Label ID="StockLabel" runat="server" Text='<%# Eval("Stock") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
</asp:ListView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PracticeDBConnectionString2 %>" SelectCommand="SELECT * FROM [Product]" DeleteCommand="DELETE FROM [Product] WHERE [PId] = @PId" InsertCommand="INSERT INTO [Product] ([PId], [Pname], [Price], [Stock]) VALUES (@PId, @Pname, @Price, @Stock)" UpdateCommand="UPDATE [Product] SET [Pname] = @Pname, [Price] = @Price, [Stock] = @Stock WHERE [PId] = @PId">
    <DeleteParameters>
        <asp:Parameter Name="PId" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="PId" Type="Int32" />
        <asp:Parameter Name="Pname" Type="String" />
        <asp:Parameter Name="Price" Type="Int32" />
        <asp:Parameter Name="Stock" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Pname" Type="String" />
        <asp:Parameter Name="Price" Type="Int32" />
        <asp:Parameter Name="Stock" Type="Int32" />
        <asp:Parameter Name="PId" Type="Int32" />
    </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
