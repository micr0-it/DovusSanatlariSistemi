<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="DersProgrami.aspx.cs" Inherits="Web.Hoca.DersProgrami" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <li>
                        <asp:HyperLink runat="server" 
                            NavigateUrl='<%#Eval("ds_menu_nav_url")%>'
                            Text='<%#Eval("ds_menu_ad")%>'>
                        </asp:HyperLink></li>
                </ItemTemplate>
                <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <div>
       <asp:Button ID="btn_goster" runat="server" Text="Ders Programını Göster" OnClick="btn_goster_Click" />
           
       <asp:Repeater ID="Repeater2" runat="server">
           <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <li>
                        '<%#Eval("ds_dersprog_tarih")%>'
                </ItemTemplate>
                <FooterTemplate></ul></FooterTemplate>
       </asp:Repeater>
   </div>   
</asp:Content>
