<%@ Page Title="Sum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sum.aspx.cs" Inherits="Server.Sum" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<script>
    function request() {
        $.post("http://localhost/LabWork3/xxx.sum", {
            x: $("#x").val(),
            y: $("#y").val()
        }, success)
    }

    function success(result) {
        $("#result").text(result)
    }
</script>

<div class="jumbotron">
    <h1>Сложение чисел</h1>
    <hr />
    <div class="input-group">
        <input type="number" class="form-control" id="x" />

        <span class="input-group-text text-center font-weight-bold">+</span>

        <input type="number" class="form-control" id="y" />

        <input type="button" class="btn btn-primary font-weight-bold" value="=" onclick="request()" />
    
        <label class="form-control input-group-text" id="result"></label>
    </div>
</div>

</asp:Content>