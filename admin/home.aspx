<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="admin_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section id="main-content" >
<section class="wrapper">
        <!--overview start-->
        <div class="row">
          <div class="col-lg-12">
            <h3 class="page-header"><i class="fa fa-laptop"></i> Dashboard</h3>
            <ol class="breadcrumb">
              <li><i class="fa fa-home"></i><a href="home.aspx">Home</a></li>
              <li><i class="fa fa-laptop"></i>Dashboard</li>
            </ol>
          </div>
        </div>

        <div class="row">
          <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
            <div class="info-box blue-bg">
              <i class="fa fa-suitcase"></i>
              <div class="count"><asp:Label ID="lblcomp" runat="server" Text=""></asp:Label></div>
              <div class="title">Company</div>
            </div>
            <!--/.info-box-->
          </div>
          <!--/.col-->

          <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
            <div class="info-box brown-bg">
              <i class="fa fa-car"></i>
              <div class="count"><asp:Label ID="lblmodel" runat="server" Text="Label"></asp:Label></div>
              <div class="title">Model</div>
            </div>
            <!--/.info-box-->
          </div>
          <!--/.col-->

          <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
            <div class="info-box dark-bg">
              <i class="fa fa-group"></i>
              <div class="count"><asp:Label ID="lbluser" runat="server" Text="Label"></asp:Label></div>
              <div class="title">Users</div>
            </div>
            <!--/.info-box-->
          </div>
          <!--/.col-->

          <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
            <div class="info-box green-bg">
              <i class="fa fa-user"></i>
              <div class="count"><asp:Label ID="lbldealer" runat="server" Text="Label"></asp:Label></div>
              <div class="title">Dealers</div>
            </div>
            <!--/.info-box-->
          </div>
          <!--/.col-->

        </div>
        <!--/.row-->


        


        <!-- Today status end -->



        <div class="row">

          <div class="col-lg-9 col-md-12">
            <div class="panel panel-default">
              <div class="panel-heading">
                <h2><i class="fa fa-flag-o red"></i><strong>Registered Users</strong></h2>
                <%--<div class="panel-actions">
                  <a class="btn-setting" href="index.html#"><i class="fa fa-rotate-right"></i></a>
                  <a class="btn-minimize" href="index.html#"><i class="fa fa-chevron-up"></i></a>
                  <a class="btn-close" href="index.html#"><i class="fa fa-times"></i></a>
                </div>--%>
              </div>
              <div class="panel-body">
                <table class="table bootstrap-datatable countries">
                  <thead>
                    <tr>
                      
<%--                      <th>City</th>--%>
                      <th>Users</th>
<%--                      <th>dealers</th>--%>
                    
                    </tr>
                  </thead>
               
                <asp:DataList ID="dluser" runat="server">
                    <ItemTemplate>
                       <tbody>
                    <tr>
                   
                      <td style="  padding: 8px; line-height: 1.4285;vertical-align: top; border-top: 1px solid #dddddd;"><asp:Label ID="lbluser" runat="server" Text='<%#Eval("name") %>'></asp:Label></td>
<%--                     <td style="  padding: 8px; line-height: 1.4285;vertical-align: top; border-top: 1px solid #dddddd;"><asp:Label ID="lbl_dealer" runat="server" Text='<%#Eval("email") %>'></asp:Label></td>--%>

                      
<%--                      <td style="  padding: 8px; line-height: 1.4285;vertical-align: top; border-top: 1px solid #dddddd;"><asp:Label ID="lbl_user" runat="server" Text="Label"></asp:Label></td>--%>
<%--                      <td style="  padding: 8px; line-height: 1.4285;vertical-align: top; border-top: 1px solid #dddddd;"><asp:Label ID="lbl_dealer" runat="server" Text='<%#Eval("Expr1") %>'></asp:Label></td>--%>
                      
                    </tr>
                    </tbody>
                    </ItemTemplate>
                    </asp:DataList>

                </table>
              </div>

            </div>

          </div>
          

        </div>



       
         

     
        <!-- project team & activity end -->

      </section>
      </section>
</asp:Content>

