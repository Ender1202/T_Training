<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="HandsOnDataBindControls.Demo1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="EmployeeId" DataSourceID="SqlDataSource1" PageSize="4">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeId" />
            <asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" SortExpression="EmployeeName" />
            <asp:BoundField DataField="ProjectCode" HeaderText="ProjectCode" SortExpression="ProjectCode" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PracticeDBConnectionString %>" DeleteCommand="DELETE FROM [Employee] WHERE [EmployeeId] = @EmployeeId" InsertCommand="INSERT INTO [Employee] ([EmployeeName], [ProjectCode]) VALUES (@EmployeeName, @ProjectCode)" ProviderName="<%$ ConnectionStrings:PracticeDBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Employee]" UpdateCommand="UPDATE [Employee] SET [EmployeeName] = @EmployeeName, [ProjectCode] = @ProjectCode WHERE [EmployeeId] = @EmployeeId">
        <DeleteParameters>
            <asp:Parameter Name="EmployeeId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="EmployeeName" Type="String" />
            <asp:Parameter Name="ProjectCode" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="EmployeeName" Type="String" />
            <asp:Parameter Name="ProjectCode" Type="String" />
            <asp:Parameter Name="EmployeeId" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
