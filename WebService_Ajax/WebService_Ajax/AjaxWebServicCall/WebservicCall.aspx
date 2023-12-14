<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebservicCall.aspx.cs" Inherits="WebService_Ajax.AjaxWebServicCall.WebservicCall" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Assets/JavaScript/bootstrap.min.js"></script>
    <link href="../Assets/Css/bootstrap.min.css" rel="stylesheet" />
    <script src="../Assets/JavaScript/jquery.min.js"></script>
</head>
    <script type="text/javascript">
        $(document).ready(function () {
            
        });

        function search() {
            $.ajax({
                type: "POST",
                url: "WebService1.asmx/HelloWorld",
                data: "{'myUserName':'" + document.getElementById('txt1').value + "'}",
                contentType: "application/json",
                datatype: "json",
                success: function (responseFromServer) {
                    alert(responseFromServer.d)
                }
            });
        }
</script>  
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnl1" runat="server" style="background-color: #cfdf75;">
            <div class="panel-heading" runat="server">
                 <div class="row">
                <div class="col-sm-10" style="text-align: left">
                    <%--                        <span class="glyphicon glyphicon-menu-hamburger" style="color: Orange;"></span>&nbsp;commennted by ajay sawant 25/4/2018--%>
                    <asp:Label ID="Label2" Text="Search Action" Font-Size="19px" runat="server" />
                </div>
                <div class="col-sm-2">
                    <span id="SrchImg" class="glyphicon glyphicon-menu-hamburger" style="float: right; color: #034ea2; padding: 1px 10px ! important; font-size: 18px;"></span><%--added by ajay sawant 24/4/2018--%>
                </div>
            
            </div>
                 <div class="col-sm-2">
              <div class="glyphicon"></div>
            </div>
            </div>
           <div class="panel-body">
             <div class="row">
     
            <div class="col-sm-3">
               <asp:Label ID="lblmame" runat="server">Enter Your Name :</asp:Label>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-6">
                <asp:button ID="btnsearch" CssClass="btn btn-sample"  OnClientClick="search();" Text="Search" runat="server" />
                <%-- <asp:LinkButton ID="btnSave" runat="server"  OnClientClick="search();" CssClass="btn btn-sample" TabIndex="17">
                                            <span class="glyphicon glyphicon-floppy-disk" style="color:White"></span> Search
                    </asp:LinkButton>--%>
            </div>
                </div>

              
           </div>
            </asp:Panel>
    
    </div>
    </form>
</body>
</html>
