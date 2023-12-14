<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlToPdf.aspx.cs" Inherits="GenrateHtmlToPdf.HtmlToPdf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th, td {
  border:1px solid black;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtname" runat="server" value="1234"></asp:TextBox>
            <asp:Button ID="btn_PDF" runat="server" Text="ConvertHtmlToPdf" OnClick="btn_PDF_Click" />

        </div>
        <div id="htmlbind" runat="server">
      <header class="clearfix">
    <h1>INVOICE</h1>
    <div id="company" class="clearfix">
        <div>Company Name</div>
        <div>
            455 John Tower,<br />
            AZ 85004, US
        </div>
        <div>(602) 519-0450</div>
        <div><a href="mailto:company@example.com">company@example.com</a></div>
    </div>
    <div id="project">
        <div><span>PROJECT</span> Website development</div>
        <div><span>CLIENT</span> John Doe</div>
        <div><span>ADDRESS</span> 796 Silver Harbour, TX 79273, US</div>
        <div><span>EMAIL</span> <a href="mailto:john@example.com">john@example.com</a></div>
        <div><span>DATE</span> April 13, 2016</div>
        <div><span>DUE DATE</span> May 13, 2016</div>
    </div>
</header>
<main>
    <table>
        <thead>
            <tr>
                <th class="service">SERVICE</th>
                <th class="desc" style="color: red;">DESCRIPTION</th>
                <th>PRICE</th>
                <th>QTY</th>
                <th>TOTAL</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class="service">Design</td>
                <td class="desc">Creating a recognizable design solution based on the company's existing visual identity</td>
                <td class="unit">$400.00</td>
                <td class="qty">2</td>
                <td class="total">$800.00</td>
            </tr>
            <tr>
                <td colspan="4">SUBTOTAL</td>
                <td class="total">$800.00</td>
            </tr>
            <tr>
                <td colspan="4">TAX 25%</td>
                <td class="total">$200.00</td>
            </tr>
            <tr>
                <td colspan="4" class="grand total">GRAND TOTAL</td>
                <td class="grand total">$1,000.00</td>
            </tr>
        </tbody>
    </table>
    <div id="notices">
        <div>NOTICE:</div>
        <div class="notice">A finance charge of 1.5% will be made on unpaid balances after 30 days.</div>
    </div>
</main>
<footer>Invoice was created on a computer and is valid without the signature and seal.</footer>


        </div>
    </form>
</body>
</html>
