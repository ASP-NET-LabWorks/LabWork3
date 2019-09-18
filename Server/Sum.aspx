<%@ Page Async="true" Title="Sum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sum.aspx.cs" Inherits="Server.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="jumbotron">
    <h1>Сложение чисел</h1>
    <div class="input-group">
        <asp:TextBox CssClass="form-control" ID="TextBoxA" runat="server" TextMode="Number"></asp:TextBox>

        <span class="input-group-text text-center font-weight-bold col-1">+</span>        

        <asp:TextBox CssClass="form-control" ID="TextBoxB" runat="server" TextMode="Number"></asp:TextBox>

        <asp:Button CssClass="btn btn-primary font-weight-bold" ID="ButtonEquals" runat="server" Text="=" OnClick="ButtonEquals_Click" />
    
        <asp:Label CssClass="form-control input-group-text" ID="LabelResult" runat="server" Text=""></asp:Label>        
    </div>
</div>

</asp:Content>