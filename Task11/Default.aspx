<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task11._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>Math Operations</h1>
        <table class="table table-bordered">
            <tr class="table-bordered">
                <td>
                    <asp:Label ID="lblDigit1" runat="server" Text="Number 1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDigit1" TextMode="Number" runat="server" placeholder="Enter the 1st number"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-bordered">
                <td>
                    <asp:Label ID="lblDigit2" runat="server" Text="Number 2"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDigit2" TextMode="Number" runat="server" placeholder="Enter the 2nd number"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-bordered">
                <td>
                    <asp:Label ID="lblOperation" runat="server" Text="Select Operation"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOperation" runat="server">
                        <asp:ListItem Value="0" Text="--Select--" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="table-bordered">
                <td>
                    <asp:Label ID="lblResult" runat="server"><b>Result</b></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtResult" ReadOnly="true" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnResult" CssClass="btn-primary" runat="server" Text="Get Result" OnClick="btnResult_Click" />
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
