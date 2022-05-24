<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<title>DÖVÜŞ SANATLARI</title>
<!-- Google Font: Source Sans Pro -->
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"/>
<!-- Font Awesome -->
<link rel="stylesheet" href="~/Template/plugins/fontawesome-free/css/all.min.css"/>
<!-- icheck bootstrap -->
<link rel="stylesheet" href="~/Template/plugins/icheck-bootstrap/icheck-bootstrap.min.css"/>
<!-- Theme style -->
<link rel="stylesheet" href="~/Template/dist/css/adminlte.min.css"/>    
<style>
    .arkaplan{
        background-image: url("Template/medium.jpg");
        background-repeat: no-repeat;
        background-size: cover;
        background-position:center;
    }
</style>
</head>
<body class="hold-transition login-page arkaplan">
<form runat="server">
<%--<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem>Seçiniz</asp:ListItem>
    <asp:ListItem>1</asp:ListItem>
    <asp:ListItem>2</asp:ListItem>
    <asp:ListItem>3</asp:ListItem>
    </asp:DropDownList>
<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True"></asp:DropDownList>--%>
<div class="login-box">
  <!-- /.login-logo -->
  <div class="card card-outline card-secondary">
    <div class="card-header text-center">
      <asp:Label CssClass="h1" runat="server">DÖVÜŞ SANATLARI</asp:Label>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Oturumunuzu Açın</p>
        <form action="~/Template/index3.html" method="post">
        <div class="input-group mb-3">
          <asp:TextBox ID="txt_mail" CssClass="form-control" placeholder="E-mailinizi girin" runat="server"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
          <asp:TextBox ID="txt_sifre" CssClass="form-control" placeholder="Şifrenizi girin" runat="server"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <div class="row">
          
           <div class="col-6">
            <div class="icheck-secondary">              
              <asp:DropDownList ID="drp_yetki" runat="server" AutoPostBack="True">
                  <asp:ListItem>Seçiniz</asp:ListItem>
                  <asp:ListItem>Hoca</asp:ListItem>
                  <asp:ListItem>Ogrenci</asp:ListItem>
                </asp:DropDownList>
            </div>             
            </div>
          <!-- /.col -->
          <div class="col-6">
            <asp:Button ID="Button1" class="btn btn-secondary btn-block" runat="server" Text="Giriş Yap" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Dene"></asp:Label>
              <br />
          </div>
          <!-- /.col -->
        </div>
      </form>
      <p class="mb-1 accent-dark">
        <a href="/SifremiUnuttum">Şifremi Unuttum</a>
      </p>
      <p class="mb-0 accent-dark">
        <a href="/KayitOl" class="text-center">Kayıt Ol</a>
      </p>
    </div>
    <!-- /.card-body -->
  </div>
  <!-- /.card -->
</div>
-
<!-- /.login-box -->
<!-- jQuery -->
<script src="~/Template/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="~/Template/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="~/Template/dist/js/adminlte.min.js"></script>
</form>
</body>
</html>