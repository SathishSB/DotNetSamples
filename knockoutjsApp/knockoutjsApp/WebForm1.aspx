<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="knockoutjsApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type='text/javascript' src='~/Scripts/knockout-3.2.0.js'></script>
    <script>
        // This is a simple *viewmodel* - JavaScript that defines the data and behavior of your UI
        function AppViewModel()
        {
            this.firstName = ko.observable("jfsdfsf");
            this.lastName = ko.observable("sjdfjksfhs");
        }

        // Activates knockout.js
        ko.applyBindings(new AppViewModel());

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>First name: <span data-bind="text: firstName"></span></p>
    <p>Last name: <span data-bind="text: lastName"></span></p>

     <p>First name: <input data-bind="value: firstName" /></p>
     <p>Last name: <input data-bind="value: lastName" /></p>
    </div>
    </form>
</body>
</html>
