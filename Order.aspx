<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Bakery_Management_System.Order" %>

<%@ Register Assembly="BasicFrame.WebControls.BasicDatePicker" Namespace="BasicFrame.WebControls" TagPrefix="DP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta  charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Order</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    </head>
<body>
    <form id="form1" runat="server">
    <div>
      <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/"> VALLEY VIEW BAKERY </a>
                </div>
                <div class="navbar-collapse collapse">
                   <ul class="nav navbar-nav navbar-right">
                    <li class="active"><a href ="Default.aspx">Back</a></li>
                       
                     </ul>
                  </div>
               </div>
             </div>
        <h2 align="center">
            Bread Menu
        </h2>
        <!-- repeater begins-->
         <div class="container center">
        <div class="row">
        <asp:Repeater ID="Repeater1" runat="server">
              <ItemTemplate>

                  </ItemTemplate>
        </asp:Repeater>
            </div>
             </div>
        <!-- repeater ends-->
        <!-- order form begin-->
         <div class="container">
        <div class="form-horizontal">
                                   <h2>Personal Detail</h2>
                 <hr />
         
                <div class="form-group">
               
                    <asp:Label ID="Pname" runat="server" Text="Name" CssClass="col-md-1 control-label"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtname" runat="server" CssClass ="form-control" placeholder="Enter your Fullname"></asp:TextBox> 
                </div>
                
               <asp:Label ID="Phone" runat="server" CssClass="col-md-1 control-label" Text="Phone"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtnumber" runat="server"  CssClass ="form-control" placeholder="Enter your number"></asp:TextBox>
                </div>
                 </div>
             <div class="form-group">
               
                    <asp:Label ID="Date" runat="server" Text="Delivery Date:" CssClass="col-md-1 control-label"></asp:Label>
                    <div class="auto-style3">
                        <DP:BasicDatePicker ID="bdt1" runat="server">
                        </DP:BasicDatePicker>
                    </div> 

                </div>
            <!-- new one begins-->
             <div class="container">
        <div class="form-horizontal">
            <h2>Orderlist</h2>
                 <hr />
           
                 <div class="form-group">
               
                    <asp:Label ID="Lblbutter" runat="server" Text="Butter Bread" CssClass="col-md-1 control-label"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtbutter" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:TextBox ID="txtbquantity" runat="server" CssClass="form-control" placeholder="Enter Quantity"></asp:TextBox>
                    </div> 
     
               
                    <asp:Label ID="Lblsugar" runat="server" Text="Sugar Bread" CssClass="col-md-1 control-label"></asp:Label>
                    <div class="col-md-3">
                         <asp:TextBox ID="txtsugar" runat="server" CssClass="form-control"></asp:TextBox>
                         <asp:TextBox ID="txtsquantity" runat="server" CssClass="form-control" placeholder="Enter Quantity"></asp:TextBox>
                </div>
                
             
               <asp:Label ID="lblwheat" runat="server" CssClass="col-md-1 control-label" Text="Wheat Bread"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtwheat" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:TextBox ID="txtwquantity" runat="server" CssClass="form-control" placeholder="Enter Quantity"></asp:TextBox>
                </div>
                                 
                       <asp:Label ID="Lblws" runat="server" CssClass="col-md-1 control-label" Text="Wheat soya"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtws" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Enter Quantity"></asp:TextBox>
                </div>
        
           
      </div>
                    </div>
           
        
                
           <br />
                   <div class="form-group">
               <div  align="center">
               <asp:Button ID="btnorder" runat="server" Text="Order"  CssClass="btn btn-info"></asp:Button>
                   </div>
           </div>
        <!-- ends here-->
    </div>
    </form>
     <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
