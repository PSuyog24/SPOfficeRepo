<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task15._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script>
        function ImgChange() {
            var getValue = ddocument.querySelector('input[name="ctl00$MainContent$radiobtnList"]:checked').value;
            var img = document.getElementById('imgView');

            if (getValue == '1') {
                img.src = 'Images/rose.jpg';
            }
            else if (getValue == '2') {
                img.src = 'Images\marigold.jpg';
            }
            else if (getValue == '3') {
                img.src = 'Images/tulip.jpg';
            }
        }
        
    </script>

    <div class="jumbotron text-center">
        <h1>Task-15</h1>
        <p class="lead">
            <asp:RadioButtonList ID="radiobtnList" runat="server" ClientIDMode="Static">
                <asp:ListItem Text="Rose" Value="1"></asp:ListItem>
                <asp:ListItem Text="Marigold" Value="2"></asp:ListItem>
                <asp:ListItem Text="Tulip" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            <asp:Button ID="btnSubmit" CssClass="btn-primary" runat="server" Text="Submit" OnClientClick="ImgChange()" />
        </p>
        <P>
            <asp:Image ID="imgView" runat="server" ClientIDMode="Static"/>
        </P>
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
