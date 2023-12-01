<%@ Page Title="Offers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Offers.aspx.cs" Inherits="AspNetWebSite.Offers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Oferty pracy już aplikowane.</h3>
        <p></p>
    </main>
    <div style="display: flex; justify-content: space-between">

        <div>
            <asp:Button runat="server" ID="Bt1" Text="Odśwież" OnClick="Bt1_Click" />
            <br />
            <asp:Button runat="server" ID="Bt2" Text="Dodaj" OnClick="Bt2_Click" />
            <br />
            <asp:Button runat="server" ID="Bt3" Text="Usuń" OnClick="Bt3_Click" />
            <br />
            <asp:Button runat="server" ID="Bt4" Text="Edytuj" OnClick="Bt4_Click" />
        </div>
        <div>
            <asp:GridView ID="Tabela" runat="server" AutoGenerateColumns="false">
                <Columns>

                    <asp:BoundField DataField="OfferId" HeaderText="OfferId"   FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="Name" HeaderText="Name"  FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="path" HeaderText="path" FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="Answer" HeaderText="Answer" FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="Data" HeaderText="Data" FooterStyle-HorizontalAlign ="Center" />
                </Columns>

            </asp:GridView>

<%--            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ColumnName1" HeaderText="Column1" />
                    <asp:BoundField DataField="ColumnName2" HeaderText="Column2" />
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:LinkButton ID="EditButton" runat="server" Text="Edit" CommandName="Edit" />
                            <asp:LinkButton ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>--%>

        </div>
    </div>
</asp:Content>
