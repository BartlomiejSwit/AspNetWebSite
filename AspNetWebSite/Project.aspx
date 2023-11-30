<%@ Page Title="Project" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="AspNetWebSite.Project" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Strona za testy projektów.</h3>
        <br />
        <div style="display: flex; justify-content: space-between">
            <div>
                <asp:Button Height="50" Width="200" runat="server" ID="Button1" Text="przycisk1" OnClick="Btn1_Click" Style="top: 200px; left: 300px;" />
                <asp:Label runat="server" ID="Label1">Superduper</asp:Label>
                <br />
                <asp:Button runat="server" ID="Button2" Text="przycisk2" OnClick="Btn2_Click" />
                <asp:Label runat="server" ID="Label2">Superduper</asp:Label>
            </div>

            <div style="display: flex; justify-content: space-between">

                <div>
                    <asp:TextBox runat="server" ID="TextBoxHidden1" />
                    <br />
                    <asp:TextBox runat="server" ID="TextBoxHidden2" />
                    <br />
                    <asp:TextBox runat="server" ID="TextBoxOperations" />
                </div>
                <div>
                    <h5>Kalkulator</h5>
                    <br />
                    <asp:TextBox runat="server" ID="TxEqual" />
                    <br />
                    <asp:Button runat="server" ID="CalBt1" Text="1" OnClick="CalBt1_Click" />
                    <asp:Button runat="server" ID="CalBt2" Text="2" OnClick="CalBt2_Click" />
                    <asp:Button runat="server" ID="CalBt3" Text="3" OnClick="CalBt3_Click" />
                    <asp:Button runat="server" ID="CalBtClear" Text="C" OnClick="CalBtClear_Click" />                    
                    <br />
                    <asp:Button runat="server" ID="CalBt4" Text="4" OnClick="CalBt4_Click" />
                    <asp:Button runat="server" ID="CalBt5" Text="5" OnClick="CalBt5_Click" />
                    <asp:Button runat="server" ID="CalBt6" Text="6" OnClick="CalBt6_Click" />
                    <asp:Button runat="server" ID="CalBtequal" Text="=" OnClick="CalBtequal_Click" />
                    <br />
                    <asp:Button runat="server" ID="CalBt7" Text="7" OnClick="CalBt7_Click" />
                    <asp:Button runat="server" ID="CalBt8" Text="8" OnClick="CalBt8_Click" />
                    <asp:Button runat="server" ID="CalBt9" Text="9" OnClick="CalBt9_Click" />
                    <br />
                    <asp:Button runat="server" ID="CalBt0" Text="0" OnClick="CalBt0_Click" />
                    <br />
                    <asp:Button runat="server" ID="CalBtPlus" Text="+" OnClick="CalBtPlus_Click" />
                    <asp:Button runat="server" ID="CalBtMinus" Text="-" OnClick="CalBtMinus_Click" />
                    <asp:Button runat="server" ID="CalBtDivision" Text="/" OnClick="CalBtDivision_Click" />
                    <asp:Button runat="server" ID="CalBtmultiplication" Text="*" OnClick="CalBtmultiplication_Click" />
                    
                </div>
            </div>

            <div>
                <asp:TextBox runat="server" ID="TextBox1" />
            </div>
        </div>
</asp:Content>
