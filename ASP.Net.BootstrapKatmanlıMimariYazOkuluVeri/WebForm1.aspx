<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.Net.BootstrapKatmanlıMimariYazOkuluVeri.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="TextAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TextAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <strong>
                <asp:Label for="TextSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TextSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

               <div>
                   <strong>
                <asp:Label for="TextNumara" runat="server" Text="Öğrenci Numara:"></asp:Label>
                   </strong>
                <asp:TextBox ID="TextNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

               <div>
                   <strong>
                <asp:Label for="TextSifre" runat="server" Text="Öğrenci Şifre"></asp:Label>
                   </strong>
                <asp:TextBox ID="TextSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
                         <div>
                   <strong>
                <asp:Label for="TextFoto" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
                   </strong>
                <asp:TextBox ID="TextFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <strong>

        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" style="font-weight: bold" />

        </strong>

    </form>
</asp:Content>
