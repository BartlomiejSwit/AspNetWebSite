<%@ Page Title="Offers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Offers.aspx.cs" Inherits="AspNetWebSite.Offers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Oferty pracy już aplikowane.</h3>
        <p></p>
    </main>
    <div>

        <div style="display: flex; justify-content: space-between">
            <div>
                <asp:Button runat="server" ID="Bt1" Text="Odśwież" OnClick="Bt1_Click" Width="100" />
                <br />
                <asp:Button runat="server" ID="Bt2" Text="Dodaj" OnClick="Bt2_Click" Width="100" />
                <br />
                <asp:Button runat="server" ID="Bt3" Text="Usuń" OnClick="Bt3_Click" Width="100" />
                <br />
                <asp:Button runat="server" ID="Bt4" Text="Edytuj" OnClick="Bt4_Click" Width="100" />
                <br />
                <asp:TextBox runat="server" ID="TxDelete" />
            </div>
            <div>
                <asp:Label runat="server" ID="Lab1" Text="Oferta" />
                <br />
                <asp:TextBox runat="server" ID="txNewOffer1" />
                <br />
                <asp:Label runat="server" ID="Lab2" Text="URL adres" />
                <br />
                <asp:TextBox runat="server" ID="TxOfferPath" />
                <br />
                <asp:Label runat="server" ID="Lab3" Text="Odpowiedź" />
                <br />
                <asp:TextBox runat="server" ID="TxAnsver" />
                <br />
                <asp:Label runat="server" ID="Lab4" Text="Data" />
                <br />
                <asp:TextBox runat="server" ID="TxDate" />
            </div>
        </div>
    </div>
    <br />
    <div>
        <asp:GridView 
            ID="Tabela"
            runat="server" 
            AutoGenerateColumns="false"
            SelectedIndex="0" 
            OnSelectedIndexChanging="Tabela_SelectedIndexChanging"
            DataKeyNames="OfferId" 
            ClientIDMode="AutoID"
            OnSelectedIndexChanged="Tabela_SelectedIndexChanged"
            AutoGenerateSelectButton="True">
            <SelectedRowStyle BackColor="lightblue" />
            <Columns>

                <asp:BoundField DataField="OfferId" HeaderText="OfferId" FooterStyle-HorizontalAlign="Center" ItemStyle-Width="50" />
                <asp:BoundField DataField="Name" HeaderText="Name" FooterStyle-HorizontalAlign="Center" ItemStyle-Width="200" />
                <asp:BoundField DataField="path" HeaderText="path" FooterStyle-HorizontalAlign="Center" ItemStyle-Width="300" />
                <asp:BoundField DataField="Answer" HeaderText="Answer" FooterStyle-HorizontalAlign="Center" ItemStyle-Width="100" />
                <asp:BoundField DataField="Data" HeaderText="Data" FooterStyle-HorizontalAlign="Center" ItemStyle-Width="80" />

            </Columns>

        </asp:GridView>
    </div>
    <%--ID="Tabela" runat="server" AutoGenerateColumns="false" SelectedIndex="0" OnSelectedIndexChanged="Tabela_SelectedIndexChanged" DataKeyNames="OfferId">--%>
    <%--ID="Tabela" runat="server" AutoGenerateColumns="false" SelectedIndex="0" OnSelectedIndexChanging="Tabela_SelectedIndexChanging" DataKeyNames="OfferId" ClientIDMode="AutoID">--%>

    <%--                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:LinkButton ID="EditButton" runat="server" Text="Edit" CommandName="Edit" />
                            <asp:LinkButton ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>--%>
</asp:Content>
