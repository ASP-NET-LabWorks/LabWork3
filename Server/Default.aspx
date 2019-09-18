<%@ Page Async="true" Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Server._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="jumbotron">
    <h1>HTTP-обработчики</h1>
    <div class="form-group">
        <asp:Label ID="LabelA" runat="server" Text="Параметр A"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="TextBoxA" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="LabelB" runat="server" Text="Параметр B"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="TextBoxB" runat="server"></asp:TextBox>
    </div>

    <div class="btn-group">
        <asp:Button CssClass="btn btn-primary" ID="ButtonGet" runat="server" Text="GET" OnClick="ButtonGet_Click" />
        <asp:Button CssClass="btn btn-primary" ID="ButtonPost" runat="server" Text="POST" OnClick="ButtonPost_Click" />
        <asp:Button CssClass="btn btn-primary" ID="ButtonPut" runat="server" Text="PUT" OnClick="ButtonPut_Click" />
        <asp:Button CssClass="btn btn-danger" ID="Button404" runat="server" Text="404" OnClick="Button404_Click" />        
    </div>
    
    <div class="my-3">
        <asp:Label ID="LabelResult" runat="server" Text="Ожидание запроса..."></asp:Label>
    </div>
</div>

</asp:Content>