<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title></title>
</head>
<body>
    <div>
        <form action="Customer/DisplayCustomer" method="post">
Enter customer Name :- <input type="text" name="Custname" /> <br />
Enter customer code :- <input type="text" name="CustomerCode" /><br />
Enter customer Amount :-<input type="text" name="Amount" /><br />
<input type="submit" value="Submit customer data" />
</form>
    </div>
</body>
</html>
