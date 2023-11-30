<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AspNetWebSite.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your contact page.</h3>
        <address>
            One Microsoft Way<br />
            Redmond, WA 98052-6399<br />
            <abbr title="Phone">P:</abbr>
            425.555.0100
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
            <asp:Button runat="server" ID="Btn1" Text="przycisk1" OnClick="Btn1_Click"/>
            <asp:Label runat="server" ID="Lb1" >Superduper</asp:Label>
            <asp:Button runat="server" ID="Btn2" Text="przycisk2" OnClick="Btn2_Click"/>
            <asp:Label runat="server" ID="Lb2" >Superduper</asp:Label>
            <asp:TextBox runat="server" ID="Tx1" />
        </address>
    </main>
</asp:Content>
