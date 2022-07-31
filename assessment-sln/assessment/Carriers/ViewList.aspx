<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewList.aspx.cs" Inherits="assessment.Carriers.ViewList" Debug="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Carriers</h1>
    <div class="row">
        <asp:ListView runat="server" ID="CarrierListView" DataKeyNames="CarrierID" 
            ItemType="assessment.Models.Carrier" SelectMethod="CarrierListView_GetData">
            <LayoutTemplate>
                <table class="table table-responsive" id="CarrierTable" runat="server">
                    <tr runat="server">
                        <th runat="server">Name</th>
                        <th runat="server">Address</th>
                        <th runat="server">Address2</th>
                        <th runat="server">City</th>
                        <th runat="server">State</th>
                        <th runat="server">Zip</th>
                        <th runat="server">Contact</th>
                        <th runat="server">Phone</th>
                        <th runat="server">Fax</th>
                        <th runat="server">Email</th>
                        <th runat="server">Actions</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder" />
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                
                <tr runat="server">
                    <td>
                        <asp:Label ID="CarrierNameLabel" runat="server"><%#:Item.CarrierName %></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Address2Label" runat="server" Text='<%# Eval("Address2") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("City") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("State") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Zip") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Contact") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Phone") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("Fax") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                    </td>
                    <td>
                        <a class="btn btn-primary btn-sm" href="/Carriers/Details.aspx?id=<%#:Item.CarrierID %>">Details</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
<%--        <asp:GridView runat="server" ID="CarriersGrid" DataKeyNames="CarrierID"
            ItemType="assessment.Models.Carrier" SelectMethod="CarrierListView_GetData"
            AutoGenerateColumns="false">
            <Columns>
                <asp:DynamicField DataField="CarrierName" />
                <asp:DynamicField DataField="Address" />
                <asp:DynamicField DataField="Address2" />
                <asp:DynamicField DataField="City" />
                <asp:DynamicField DataField="State" />
                <asp:DynamicField DataField="Zip" />
                <asp:DynamicField DataField="Contact" />
                <asp:DynamicField DataField="Phone" />
                <asp:DynamicField DataField="Fax" />
                <asp:DynamicField DataField="Email" />
            </Columns>

        </asp:GridView>--%>
    </div>
</asp:Content>
