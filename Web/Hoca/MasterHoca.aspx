<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="MasterHoca.aspx.cs" Inherits="Web.Hoca.MasterHoca" %>

<%@ Register Src="~/UserKontroller/UserMenu.ascx" TagPrefix="uc1" TagName="UserMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">     
    <uc1:UserMenu runat="server" id="UserMenu" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <section class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1>Profil</h1>
          </div>
          <div class="col-sm-6">
            <ol class="breadcrumb float-sm-right">
              <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
              <li class="breadcrumb-item active">Kullanıcı Profili</li>
            </ol>
          </div>
        </div>
      </div><!-- /.container-fluid --></section>
            <!-- Main content -->
    <section class="content">
      <div class="container-fluid">
        <div class="row">
          <div class="col-md-3">
            <!-- Profile Image -->
            <div class="card card-primary card-outline">
              <div class="card-body box-profile">
                <div class="text-center">
                  <img class="profile-user-img img-fluid img-circle"
                       src="/Template/dist/img/user4-128x128.jpg"
                       alt="User profile picture">
                </div>
                <asp:Label runat="server" ID="lbl_adsoyad" CssClass="profile-username text-center"><h3 class="profile-username text-center"></h3></asp:Label>
                <asp:Label runat="server" ID="lbl_ders" CssClass="text-muted text-center"></asp:Label>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->
           </div>
            <div class="col-md-9">
            <div class="card">
              <div class="card-header p-2">
                <ul class="nav nav-pills">         
                  <li class="nav-item">Profil Güncelle</li>
                </ul>
              </div><!-- /.card-header -->
              <div class="card-body">
                <div class="tab-content">
                  <div class="active tab-pane" id="activity">
                  <div class="tab-pane" id="settings">      
                      <div class="form-group row">
                        <label for="txt_hocaisim" class="col-sm-2 col-form-label">İSİM</label>
                        <div class="col-sm-10">
                          <asp:TextBox runat="server" ID="txt_hocaisim" CssClass="form-control"></asp:TextBox>           
                        </div>
                      </div>
                      <div class="form-group row">
                        <label for="txt_hocasoyad" class="col-sm-2 col-form-label">Soyad</label>
                        <div class="col-sm-10">
                          <asp:TextBox runat="server" ID="txt_hocasoyad" CssClass="form-control"></asp:TextBox>        
                        </div>
                      </div>
                        <div class="form-group row">
                        <label for="txt_hocasoyad" class="col-sm-2 col-form-label">Mail Adresi</label>
                        <div class="col-sm-10">
                          <asp:TextBox runat="server" ID="txt_hocamail" CssClass="form-control"></asp:TextBox>        
                        </div>
                      </div>
                      <div class="form-group row">
                        <label for="txt_hocaders" class="col-sm-2 col-form-label">Branş/Ders</label>
                        <div class="col-sm-10">
                          <asp:TextBox runat="server" ID="txt_hocaders" CssClass="form-control"></asp:TextBox>        
                        </div>
                      </div>
                      <div class="form-group row">
                        <label for="txt_hocaderece" class="col-sm-2 col-form-label">Derece</label>
                        <div class="col-sm-10">
                          <asp:TextBox runat="server" ID="txt_hocaderece" CssClass="form-control"></asp:TextBox>        
                        </div>
                      </div>                     
                      <div class="form-group row">
                        <div class="offset-sm-2 col-sm-10">
                          <div class="checkbox">
                            <label>
                              <asp:CheckBox ID="chk_onay" runat="server" Text="Onaylıyorum"/>
                            </label>
                          </div>
                        </div>
                      </div>
                      <div class="form-group row">
                        <div class="offset-sm-2 col-sm-10">
                            <asp:Button runat="server" ID="btn_guncelle" CssClass="btn btn-danger" Text="Güncelle" OnClick="btn_guncelle_Click"/>
                        </div>
                      </div>
                   </div>
                 </div>
                  <!-- /.tab-pane -->
               </div>
                <!-- /.tab-content -->
             </div><!-- /.card-body -->
           </div>
            <!-- /.card -->
         </div>
        </div>
       </div>
       </section>
</asp:Content>
