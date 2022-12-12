<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task13._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>Task 13</h1>
        <table class="table table-bordered">
            <tr class="table-bordered">
                <td>
                    <asp:Label ID="lblUsername" Text="Username" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter Username"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-bordered">
                <td>
                    <asp:Label ID="lblPaymentMode" runat="server" Text="Mode of Payment"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPaymentMode" runat="server" OnSelectedIndexChanged="ddlPaymentMode_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPaymentDtls" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPaymentDtls" runat="server"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="regPaymentValidate" ControlToValidate ="txtPaymentDtls" runat="server" style="color:red;" />
                </td>
            </tr>
        </table>
        <asp:Button ID="btnGetResult" CssClass="btn btn-primary" Text="Submit" OnClick="btnGetResult_Click" runat="server" />
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
