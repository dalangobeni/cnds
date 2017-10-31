﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.Portal.Views.Request
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    using Lpp.Dns;
    using Lpp.Dns.Data;
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Controllers;
    using Lpp.Dns.Portal.Models;
    using Lpp.Dns.Portal.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    #line 1 "..\..\Views\Request\History.cshtml"
    using Lpp.Utilities.Legacy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Request/History.cshtml")]
    public partial class History : System.Web.Mvc.WebViewPage<IEnumerable<RequestDataMart>>
    {

#line 32 "..\..\Views\Request\History.cshtml"
public System.Web.WebPages.HelperResult Row( string action, DateTime time, User user, string message, string url )
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\Views\Request\History.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Row\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Time\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 35 "..\..\Views\Request\History.cshtml"
WriteTo(__razor_helper_writer, time.ToString( "dd/MM/yyyy hh:mm tt" ));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Action\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 36 "..\..\Views\Request\History.cshtml"
WriteTo(__razor_helper_writer, action);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Text\"");

WriteLiteralTo(__razor_helper_writer, ">by</div>\r\n        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"User\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 38 "..\..\Views\Request\History.cshtml"
WriteTo(__razor_helper_writer, user.UserName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 39 "..\..\Views\Request\History.cshtml"
        

#line default
#line hidden

#line 39 "..\..\Views\Request\History.cshtml"
         if ( !message.NullOrEmpty() )
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Text\"");

WriteLiteralTo(__razor_helper_writer, ">, </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Message\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 42 "..\..\Views\Request\History.cshtml"
   WriteTo(__razor_helper_writer, message);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 43 "..\..\Views\Request\History.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");


#line 44 "..\..\Views\Request\History.cshtml"
         if ( !url.NullOrEmpty() )
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1709), Tuple.Create("\"", 1720)

#line 46 "..\..\Views\Request\History.cshtml"
, Tuple.Create(Tuple.Create("", 1716), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 1716), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"Link\"");

WriteLiteralTo(__razor_helper_writer, ">[view response]</a>\r\n");


#line 47 "..\..\Views\Request\History.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 49 "..\..\Views\Request\History.cshtml"


#line default
#line hidden
});

#line 49 "..\..\Views\Request\History.cshtml"
}
#line default
#line hidden

        public History()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Request\History.cshtml"
   
    Layout = null;
    var moreThanOne = Model.Skip( 1 ).Any();

            
            #line default
            #line hidden
WriteLiteral(" \r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
