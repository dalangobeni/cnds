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

namespace Lpp.Dns.RedirectBridge.Views.Plugins
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
    using Lpp.Dns.RedirectBridge;
    using Lpp.Dns.RedirectBridge.Controllers;
    using Lpp.Dns.RedirectBridge.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Plugins/UploadError.cshtml")]
    public partial class UploadError : System.Web.Mvc.WebViewPage<UploadConfirmModel>
    {
        public UploadError()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"ui-section ui-has-header\"");

WriteLiteral(" title-text=\"Error\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ConfigurationError\"");

WriteLiteral(">\r\n        There was an error during configuration upload.<br />\r\n        Please " +
"make sure you are uploading the correct file and the file is not malformed.<br /" +
">\r\n        <br />\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\Plugins\UploadError.cshtml"
   Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..\Views\Plugins\UploadError.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Plugins\UploadError.cshtml"
         if ( Model.Configuration != null )
        {
            
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Plugins\UploadError.cshtml"
        Write(Html.Partial<ModelConfigurationView>().WithModel( Model.Configuration ));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Plugins\UploadError.cshtml"
                                                                                      
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <br />\r\n        <button");

WriteLiteral(" class=\"ui-standard-button\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 555), Tuple.Create("\"", 660)
, Tuple.Create(Tuple.Create("", 565), Tuple.Create("window.nav.navigate(", 565), true)
, Tuple.Create(Tuple.Create(" ", 585), Tuple.Create("\'", 586), true)
            
            #line 16 "..\..\Views\Plugins\UploadError.cshtml"
, Tuple.Create(Tuple.Create("", 587), Tuple.Create<System.Object, System.Int32>(Url.Action<PluginsController>( c => c.List( new ListGetModel() ) )
            
            #line default
            #line hidden
, 587), false)
, Tuple.Create(Tuple.Create("", 656), Tuple.Create("\'", 656), true)
, Tuple.Create(Tuple.Create(" ", 657), Tuple.Create(");", 658), true)
);

WriteLiteral(">Back</button>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
