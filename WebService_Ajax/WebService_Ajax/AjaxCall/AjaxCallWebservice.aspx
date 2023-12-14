<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxCallWebservice.aspx.cs" Inherits="WebService_Ajax.AjaxCall.AjaxCallWebservice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title>AutoComplete Text Box using jQuery in ASP.NET</title>  
   <%-- <link href="jquery-ui.css" rel="stylesheet" type="text/css" />  --%>

    <link href="../Assets/Css/jquery-ui.css" rel="stylesheet" />
   <%-- <script src="jquery.min.js" type="text/javascript"></script> --%>
   
    <script type="text/javascript" src="../Assets/JavaScript/jquery.min.js"></script>
    <script type="text/javascript"  src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <%--  <script src="jquery-ui.min.js" type="text/javascript"></script> --%> 
    <script type="text/javascript"  src="../../../Scripts/JQuery/jquery-ui.min.js"></script>
    <script type="text/javascript">
        //$(document).ready(function () {
        //    SearchText();
        //});
        function SearchText() {
            debugger;
          
                    $.ajax({
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        url: "AjaxCallWebservice.aspx/GetEmployeeName",
                        data: "{'empName':'" + document.getElementById('txtEmpName').value + "'}",
                        dataType: "json",
                        success: function (data) {
                            debugger;
                            alert(data.d);
                            response(data.d);
                           
                        },
                        error: function (result) {
                            alert("No Match");
                        }
                    });
                }
         
    </script>  
  
</head>  
<body>  
    <form id="form1" runat="server">  
    <table cellpadding="10" cellspacing="10" style="border: solid 15px Green; background-color: SkyBlue;"  
        width="50%" align="center">  
        <tr>  
            <td>  
                <span style="color: Red; font-weight: bold; font-size: 18pt;">Enter Employee Name:</span>   
                <asp:TextBox ID="txtEmpName" runat="server" Width="160px" />  
            </td>  
            <td>  
              <asp:LinkButton ID="btnsearch" runat="server" OnClientClick=" SearchText();"> Search</asp:LinkButton>
            </td> 
        </tr>  
    </table>  
    </form>  
</body>  
</html>  



