<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task14._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    <div class="jumbotron">
        <h1>Task 14</h1>
        <div class="text-center table table-bordered">
            <div class="table-bordered">
                <asp:Label Text="Username" runat="server" />
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>

            <br />
            <div class="table-bordered">
                <asp:Label Text="Address" runat="server" />
                <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>

            <br />
            <div class="table-bordered">
                <asp:Label Text="Date" runat="server" />
                <asp:TextBox ID="txtDate" TextMode="Date" runat="server"></asp:TextBox>
            </div>

            <br />
            <div class="table-bordered">
                <asp:Label Text="Nationality" runat="server" />
                <asp:TextBox ID="txtNationality" runat="server"></asp:TextBox>
            </div>

            <br />
            <div class="table-bordered">
                <asp:Label Text="Country" runat="server" />
                <asp:DropDownList ID="ddlCountry" runat="server"></asp:DropDownList>
            </div>

            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-primary" />
        </div>
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
