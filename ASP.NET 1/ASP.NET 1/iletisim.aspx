<%@ Page Title="İletişim" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="ASP.NET_1.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
        body{
            background-color:hotpink;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="img_sections">
        <img src="IMG/images.jpg" alt="iletişim göster" style="height:150px; float:left"/>
    </section>
    
    <input id="ad" type="text" style="display:block" placeholder="Ad Soyad"/>
    <input id="email" type="email" style="display:block" placeholder="Email"/>
    <textarea id="mesaj" style="display:block">Mesajınız Giriniz</textarea>
    <button type="submit" style="display:block">Gönder</button>
    
</asp:Content>
