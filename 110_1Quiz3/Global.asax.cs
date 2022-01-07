using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace _110_1Quiz3
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
    }
    <%@ Page Language = "C#" AutoEventWireup="true" CodeBehind="ch7-3_1.aspx.cs" Inherits="_110_1Quiz3.session" %>

<!DOCTYPE html>

<html xmlns = "http://www.w3.org/1999/xhtml" >
< head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id = "form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>