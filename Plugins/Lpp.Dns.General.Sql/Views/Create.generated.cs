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

namespace Lpp.Dns.General.SqlDistribution.Views
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
    using Lpp.Dns.General.SqlDistribution;
    using Lpp.Dns.General.SqlDistribution.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Create.cshtml")]
    public partial class Create : System.Web.Mvc.WebViewPage<Lpp.Dns.General.SqlDistribution.Models.SqlDistributionModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Create.cshtml"
   
    this.Stylesheet("SqlDistribution.css");
    var id = Html.UniqueId();

            
            #line default
            #line hidden
WriteLiteral("\r\n \r\n<div");

WriteLiteral(" class=\"SqlEditor\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n            Sql Query\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\'errorLocation\'");

WriteLiteral(" style=\"font-size: small; color: Gray;\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12 form-group\"");

WriteLiteral(">\r\n                    <label>Enter the query string to execute at the DataMarts<" +
"/label>\r\n                    <textarea");

WriteAttribute("id", Tuple.Create(" id=\"", 611), Tuple.Create("\"", 619)
            
            #line 17 "..\..\Views\Create.cshtml"
, Tuple.Create(Tuple.Create("", 616), Tuple.Create<System.Object, System.Int32>(id
            
            #line default
            #line hidden
, 616), false)
);

WriteLiteral(" name=\"SqlQuery\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" required>");

            
            #line 17 "..\..\Views\Create.cshtml"
                                                                                Write(Model.SqlQuery);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n                </div>\r\n            </div>            \r\n        </di" +
"v>\r\n    </div>\r\n    <script>\r\n        $(function () {\r\n            $(\'#");

            
            #line 24 "..\..\Views\Create.cshtml"
           Write(id);

            
            #line default
            #line hidden
WriteLiteral("\').keyup(function () {\r\n                var form = $(\"form.trackChanges\");\r\n     " +
"           if (form) {\r\n                    form.formChanged(true);\r\n           " +
"     }\r\n            });\r\n        });\r\n    </script>       \r\n</div>\r\n ");

        }
    }
}
#pragma warning restore 1591
