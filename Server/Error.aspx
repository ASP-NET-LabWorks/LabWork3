<%@ Page Async="true" Title="Error" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Server.Error" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="jumbotron">
    <h1>Сложение чисел</h1>
    <p>Время последней перезагрузки страницы: <%: DateTime.Now.ToLongTimeString() %></p>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="input-group">
                <asp:TextBox CssClass="form-control" ID="TextBoxX" runat="server" TextMode="Number"></asp:TextBox>

                <span class="input-group-text text-center font-weight-bold">+</span>        

                <asp:TextBox CssClass="form-control" ID="TextBoxY" runat="server" TextMode="Number"></asp:TextBox>

                <asp:Button CssClass="btn btn-primary font-weight-bold" ID="ButtonEquals" runat="server" Text="=" OnClick="ButtonEquals_Click" />
    
                <asp:Label CssClass="form-control input-group-text" ID="LabelResult" runat="server" Text=""></asp:Label>        
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>

</asp:Content>