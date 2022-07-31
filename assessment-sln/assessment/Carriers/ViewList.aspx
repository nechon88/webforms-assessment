﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewList.aspx.cs" Inherits="assessment.Carriers.ViewList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Carriers</h1>
    <div class="row">
        <asp:ListView runat="server" ID="CarrierListView" DataKeyNames="CarrierID" 
            ItemType="assessment.Models.Carrier" SelectMethod="CarrierListView_GetData">
            <LayoutTemplate>
                <div runat="server" class="table-responsive">
                    <table class="table" id="CarrierTable" runat="server">
                        <tr runat="server">
                            <th>Name</th>
                            <th>Address</th>
                            <th>Address2</th>
                            <th>City</th>
                            <th>State</th>
                            <th>Zip</th>
                            <th>Contact</th>
                            <th>Phone</th>
                            <th>Fax</th>
                            <th>Email</th>
                            <th>Details</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder" />
                    </table>
                 </div>
            </LayoutTemplate>
            <ItemTemplate>
                <tr runat="server">
                    <td><%#:Item.CarrierName %></td>
                    <td><%#:Item.Address %></td>
                    <td><%#:Item.Address2 %></td>
                    <td><%#:Item.City %></td>
                    <td><%#:Item.State %></td>
                    <td><%#:Item.Zip %></td>
                    <td><%#:Item.Contact %></td>
                    <td><%#:Item.Phone %></td>
                    <td><%#:Item.Fax %></td>
                    <td><%#:Item.Email %></td>
                    <td>
                        <a class="btn btn-primary btn-sm" href="/Carriers/Details.aspx?id=<%#:Item.CarrierID %>">Details</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <a class="btn btn-primary" href="/Carriers/Details.aspx?mode=insert">Add New</a>
    </div>
</asp:Content>
