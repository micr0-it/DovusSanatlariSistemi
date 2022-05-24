<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="Web.KayitOl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<title>DÖVÜŞ SANATLARI | Kayıt Olma Sayfası </title>

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
<body class="hold-transition register-page arkaplan">
<form runat="server">
<div class="register-box">
  <div class="card card-outline card-secondary">
    <div class="card-header text-center">
      <asp:Label runat="server" CssClass="h2">Dövüş Sanatları Kayıt Olma</asp:Label>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Yeni bir üyelik oluşturun</p>

      <form action="~/Template/index.html" method="post">
        <div class="input-group mb-3">
          <asp:TextBox ID="txt_ad" class="form-control" placeholder="Ad" runat="server"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
         <div class="input-group mb-3">
          <asp:TextBox ID="txt_soyad" class="form-control" placeholder="Soyad" runat="server"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
          <asp:TextBox ID="txt_mail" class="form-control" placeholder="E-mail" runat="server"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
          <asp:TextBox ID="txt_sifre" class="form-control" placeholder="Şifre" runat="server"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-8">
            <div class="icheck-secondary">
              <asp:CheckBox ID="chk_ogr" runat="server" />
              <label for="chk_ogr">
               Öğrenci
              </label>
            </div>
          </div>
          <div class="col-8">
            <div class="icheck-secondary">
              <asp:CheckBox ID="chk_hoca" runat="server" />
              <label for="chk_hoca">
                Hoca
              </label>
            </div>
          </div>
          <!-- /.col -->
          <div class="col-8">
            <asp:Button runat="server" class="btn btn-secondary btn-block" ID="btn_kayit" Text="Kayıt Ol" OnClick="btn_kayit_Click" />
            <asp:Label ID="lbl" runat="server"></asp:Label>
          </div>
          <!-- /.col -->
        </div>
      </form>
      <a href="Default.aspx" class="text-center">Zaten üyeliğin var mı ?</a>
    </div>
    <!-- /.form-box -->
  </div><!-- /.card -->
</div>
<!-- /.register-box -->

<!-- jQuery -->
<script src="~/Template/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="~/Template/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="~/Template/dist/js/adminlte.min.js"></script>
</form>
</body>
</html>

