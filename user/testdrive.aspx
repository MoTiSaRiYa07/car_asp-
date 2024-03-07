<%@ Page Title="" Language="C#" MasterPageFile="~/user/user1.master" AutoEventWireup="true" CodeFile="testdrive.aspx.cs" Inherits="user_testdrive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <form runat="server">
    <div class="service-breadcrumb">
				<div class="container">
					<div class="wthree_service_breadcrumb_left">
						<ul>
							<li><a href="home1.aspx">Home</a> <i>|</i></li>
							<li>Test Drive</li>
						</ul>
					</div>
					<div class="wthree_service_breadcrumb_right">
						<h3>Test Drive</h3>
					</div>
					<div class="clearfix"> </div>
				</div>
			</div>

   <div class="sell-car w3l">
   	<div class="container">
           <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
           <asp:Label ID="Label2" runat="server" Text="" Visible="false"></asp:Label>
			    <!--/sell-price-grids -->
					<div class="sell">

			<h3>Book test Drive</h3>
            


			<div class="year">
				
				<div>
					
                    <asp:TextBox ID="txtname" runat="server" required="" 
     style= "outline: none;color: #999;
    padding: 10px 10px 10px 30px;
    margin: 0;
    width: 100%;
    border: none;
    border-bottom: 2px solid #686464;
    -webkit-appearance: none;
    font-family: 'Open Sans', sans-serif;" placeholder="Your Name"></asp:TextBox>
					
					<div class="clearfix"></div>
				</div>
				<div class="clearfix"></div>
			</div>		
				 <div class="year">
				
				<div>   
					
   <asp:TextBox ID="txtlname" runat="server" required=""  placeholder="Last Name"
    style= "outline: none;color: #999;
    padding: 10px 10px 10px 30px;
    margin: 0;
    width: 100%;
    border: none;
    border-bottom: 2px solid #686464;
    -webkit-appearance: none;
    font-family: 'Open Sans', sans-serif;"
   ></asp:TextBox>
					
					
					<div class="clearfix"></div>
				</div>
				<div class="clearfix"></div>
			</div>
  

      <div class="city">
				
				<div>
						
                            <asp:TextBox ID="txtphoneno" runat="server" placeholder="Phone no"
                             style= "outline: none;color: #999;
    padding: 10px 10px 10px 30px;
    margin: 0;
    width: 100%;
    border: none;
    border-bottom: 2px solid #686464;
    -webkit-appearance: none;
    font-family: 'Open Sans', sans-serif;"
                            ></asp:TextBox>
									</div>
				<div class="clearfix"></div>
			</div>

     
			 <div class="city">
				
				<div>
						
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
        <asp:DropDownList ID="ddlcomp" runat="server"   AutoPostBack="True" 
                        DataSourceID="SqlDataSource1" DataTextField="compname" DataValueField="compid" 
                        style="padding: 10px 46px;
    width: 100%;
    font-weight: normal;
    
    border: none;
    color: #848484;
    outline: none;
    font-size: 14px;
    border-bottom: 2px solid #686464;
    margin-bottom: 30px;
    background: url(images/car.png) no-repeat 1% center #ffffff;" 
                            onselectedindexchanged="ddlcomp_SelectedIndexChanged">
                                           
                                       </asp:DropDownList>
                                      
                        	<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT * FROM [tbl_comp] WHERE ([status] = @status)">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="0" Name="status" Type="Int32" />
                                </SelectParameters>
                    </asp:SqlDataSource>
                                      
                        	</div>
				<div class="clearfix"></div>
			</div>

          

                        <div class="city">
				
				<div>
						
                          <asp:DropDownList ID="ddlmodel" runat="server" 
                             DataSourceID="SqlDataSource2" 
                              DataTextField="modelname" DataValueField="modelid" 
                              style="padding: 10px 46px;
    width: 100%;
    font-weight: normal;
    
    border: none;
    color: #848484;
    outline: none;
    font-size: 14px;
    border-bottom: 2px solid #686464;
    margin-bottom: 30px;
    background: url(images/car.png) no-repeat 1% center #ffffff;"
                              >
                                           
                                       </asp:DropDownList>
                                      
					      <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                              SelectCommand="SELECT * FROM [tbl_model] WHERE (([compid] = @compid) AND ([status] = @status))">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="ddlcomp" Name="compid" 
                                      PropertyName="SelectedValue" Type="Int32" />
                                  <asp:Parameter DefaultValue="0" Name="status" Type="Int32" />
                              </SelectParameters>
                          </asp:SqlDataSource>
                                      
					<div class="clearfix"></div>
				</div>
				<div class="clearfix"></div>
			</div>
            </ContentTemplate>
                    </asp:UpdatePanel>
		
			<div class="city">
				
				<div>
						
                            <asp:DropDownList ID="ddlcity" runat="server" 
                                onselectedindexchanged="ddlcity_SelectedIndexChanged"
                                style="padding: 10px 46px;
    width: 100%;
    font-weight: normal;
    
    border: none;
    color: #848484;
    outline: none;
    font-size: 14px;
    border-bottom: 2px solid #686464;
    margin-bottom: 30px;
    background: url(images/location.png) no-repeat 1% center #ffffff;" AutoPostBack="True"
                                >
                                 
                            </asp:DropDownList>
					       
				</div>
				<div class="clearfix"></div>
			</div>

         
            <div class="city">
				
				<div>
						
                                <asp:Calendar ID="Calendar1" runat="server" 
                                    onselectionchanged="Calendar1_SelectionChanged" BackColor="White" 
                                    BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                                    ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                                        VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                    <TodayDayStyle BackColor="#CCCCCC" />
                                </asp:Calendar>
                                <asp:TextBox ID="txtdate" runat="server" placeholder="date"
                                style= "outline: none;color: #999;
    padding: 10px 10px 10px 30px;
    margin: 0;
    width: 100%;
    border: none;
    border-bottom: 2px solid #686464;
    -webkit-appearance: none;
    font-family: 'Open Sans', sans-serif;" 
                                ></asp:TextBox>
                     
				</div>
				<div class="clearfix"></div>
			</div>
           	
            




			<div class="value-button">
				                <asp:Button ID="btnbook" runat="server" Text="Book" onclick="btnbook_Click" />
						
				
			</div>

			<div class="clearfix"></div>
			</div>

		</div>

			
			</div>
             <h3>Click on select to chhose Dealer</h3>
             </br>
             
           <asp:GridView ID="GridView1" runat="server" BackColor="White" Width="90%"  
                    BorderStyle="None"  BorderWidth="0px" CellPadding="4" DataKeyNames="dealerid" 
                    GridLines="Horizontal" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" >
               <Columns>
                   <asp:CommandField ShowSelectButton="True" ControlStyle-Font-Names="Arial"  ControlStyle-Font-Bold="true" ControlStyle-BorderColor="#343d3d" />
                   
               </Columns>
               <FooterStyle BackColor="White" Font-Names="Arial" ForeColor="#333333" />
               <HeaderStyle BackColor="#343d3d" Font-Bold="True" Font-Names="Arial" ForeColor="White" />
               <PagerStyle BackColor="#343d3d" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="White" ForeColor="#333333" Font-Names="Arial" />
               <SelectedRowStyle BackColor="#339966" Font-Bold="True" Font-Names="Arial" ForeColor="White" />
               <SortedAscendingCellStyle BackColor="#F7F7F7" />
               <SortedAscendingHeaderStyle BackColor="#487575" />
               <SortedDescendingCellStyle BackColor="#E5E5E5" />
               <SortedDescendingHeaderStyle BackColor="#275353" />
           </asp:GridView>
          </br>
          </br>


                          </form>
</asp:Content>

