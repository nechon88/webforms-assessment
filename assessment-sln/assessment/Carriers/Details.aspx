<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="assessment.Carriers.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="CarrierDetail" 
        runat="server" 
        ItemType="assessment.Models.Carrier" 
        SelectMethod="CarrierDetail_GetItem" 
        UpdateMethod="CarrierDetail_UpdateItem"
        DeleteMethod="CarrierDetail_DeleteItem"
        RenderOuterTable="false"
        DataKeyNames="CarrierID">
        <ItemTemplate>
            <h1>Details</h1>
            <div class="row">
                <p class="col-sm-2"><b>Carrier ID</b></p>
                <p class="col-sm-10"><%#:Item.CarrierID %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Name</b></p>
                <p class="col-sm-10"><%#:Item.CarrierName %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Address</b></p>
                <p class="col-sm-10"><%#:Item.Address %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Address 2</b></p>
                <p class="col-sm-10"><%#:Item.Address2 %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>City</b></p>
                <p class="col-sm-10"><%#:Item.City %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>State</b></p>
                <p class="col-sm-10"><%#:Item.State %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Zip</b></p>
                <p class="col-sm-10"><%#:Item.Zip %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Contact</b></p>
                <p class="col-sm-10"><%#:Item.Contact %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Phone</b></p>
                <p class="col-sm-10"><%#:Item.Phone %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Fax</b></p>
                <p class="col-sm-10"><%#:Item.Fax %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Email</b></p>
                <p class="col-sm-10"><%#:Item.Email %></p>
            </div>
            <asp:LinkButton CssClass="btn btn-primary" runat="server" ID="editButton" Text="Edit" CommandName="Edit" />
            <asp:LinkButton CssClass="btn btn-danger" runat="server" ID="deleteButton" Text="Delete" CommandName="Delete" />
        </ItemTemplate>
        <EditItemTemplate>
            <h1>Edit</h1>
            <div class="row">
                <p class="col-sm-2"><b>Carrier ID</b></p>
                <p class="col-sm-10"><%#:Item.CarrierID %></p>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Name</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox1" Text='<%# Bind("CarrierName") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Address</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox2" Text='<%# Bind("Address") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Address 2</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox3" Text='<%# Bind("Address2") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>City</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox4" Text='<%# Bind("City") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>State</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox5" Text='<%# Bind("State") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Zip</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox6" Text='<%# Bind("Zip") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Contact</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox7" Text='<%# Bind("Contact") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Phone</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox8" Text='<%# Bind("Phone") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Fax</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox9" Text='<%# Bind("Fax") %>'></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p class="col-sm-2"><b>Email</b></p>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="TextBox10" Text='<%# Bind("Email") %>'></asp:TextBox>
                </div>
            </div>
            <asp:ValidationSummary ID="validationSummary" runat="server" ShowSummary="true" DisplayMode="BulletList"/>
            <asp:Button CssClass="btn btn-primary" runat="server" ID="saveButton" Text="Save" CommandName="Update"/>
        </EditItemTemplate>
    </asp:FormView>
</asp:Content>
