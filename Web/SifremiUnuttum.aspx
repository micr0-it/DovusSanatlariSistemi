<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="Web.SifremiUnuttum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1"/>
  <title>DÖVÜŞ SANATLARI | Şifremi Unuttum</title>
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
<div class="login-box">
  <div class="card card-outline card-secondary">
    <div class="card-header text-center">
      <label class="h2">Dövüş Sanatları | Şifremi Unuttum</label>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Şifrenizimi unuttunuz. Kolayca eski şifrenizi değiştirebilirsiniz.</p>
      <form action="recover-password.html" method="post">
        <div class="input-group mb-3">                   
          <asp:TextBox ID="txt_mail" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-12">
            <asp:Button runat="server" ID="txt_btn" class="btn btn-secondary btn-block" Text="Yeni şifreni edin."/>
          </div>
          <!-- /.col -->
        </div>
      </form>
      <p class="mt-3 mb-1">
        <a href="Default.html">Giriş sayfasına dön</a>
      </p>
    </div>
    <!-- /.login-card-body -->
  </div>
</div>
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
