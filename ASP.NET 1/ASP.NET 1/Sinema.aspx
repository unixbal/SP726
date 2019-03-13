<%@ Page Title="Sinema" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sinema.aspx.cs" Inherits="ASP.NET_1.Sinema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section style="filmler_section" >
    <asp:DataList id="DataList_Filmler" runat="server">
    <HeaderTemplate><table border="1"></HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%# Eval("FilmID") %></td>
            <td><%# Eval("FilmAdi") %></td>
            <td><%# Eval("FilmKisaBilgi") %></td>
            <td><%# Eval("FilmFragmanLink") %></td>
        </tr>
    </ItemTemplate>
        <FooterTemplate></table></FooterTemplate>    
    </asp:DataList>
</section>
    <section class="film_kadet_section">

        <asp:TextBox ID="txt_FilmAd" runat="server" placeholder="Film Adı"></asp:TextBox>
        <asp:TextBox ID="txt_FilmFragman" runat="server" placeholder="Film Fragmanı"></asp:TextBox>
        <asp:TextBox ID="txt_FilmKisaBilgi" runat="server" placeholder="Film Özeti"></asp:TextBox>
        <asp:Button ID="btn_FilmKaydet" runat="server" Text="Film Kaydet" OnClick="btn_FilmKaydet_Click" />

    </section>
</asp:Content>
