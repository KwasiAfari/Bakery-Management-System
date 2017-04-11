<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="Bakery_Management_System.Comments" %>

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
          <h2>Personal Detail</h2>
                 <hr />
         
                <div class="form-group">
               
                    <asp:Label ID="comment" runat="server" Text="Comment" CssClass="col-md-1 control-label"></asp:Label>
                    <div class="col-md-3">
                       <textarea class="form-control" rows="5" placeholder="Enter your comment" id="txtcomment"></textarea>
                </div>
                
               <asp:Label ID="Suggestions" runat="server" CssClass="col-md-1 control-label" Text="Suggestions"></asp:Label>
                <div class="col-md-3">
                   <textarea class="form-control" rows="5" placeholder="Give us your sugesstions"></textarea>
                </div>
                 </div>
    </div>
         <div class="form-group">
               <div  align="center">
               <asp:Button ID="btnsubmit" runat="server" Text="Submit"  CssClass="btn btn-info" OnClick="btnsubmit_onclick"></asp:Button>
                   </div>
    </form>
      <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
