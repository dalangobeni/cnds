﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Mvc.Controls.Views.Grid {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using Lpp;
    using Lpp.Mvc;
    using Lpp.Mvc.Controls;
    using WebMatrix.Data;
    using WebMatrix.WebData;
    
    
    public partial class GridClientSortColumnTitle : System.Web.Mvc.WebViewPage<GridClientSortColumnModel> {
        
#line hidden

        
        public GridClientSortColumnTitle() {
        }
        
        protected System.Web.HttpApplication ApplicationInstance {
            get {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {


            
            #line 2 "C:\work\DNS\trunk\Lpp.Mvc.Composition\Lpp.Mvc.Controls\Views\Grid\GridClientSortColumnTitle.cshtml"
  
    Layout = null;
    var id = Html.UniqueId();


            
            #line default
            #line hidden
WriteLiteral("<span id=\"");


            
            #line 6 "C:\work\DNS\trunk\Lpp.Mvc.Composition\Lpp.Mvc.Controls\Views\Grid\GridClientSortColumnTitle.cshtml"
     Write(id);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 6 "C:\work\DNS\trunk\Lpp.Mvc.Composition\Lpp.Mvc.Controls\Views\Grid\GridClientSortColumnTitle.cshtml"
          Write(Model.InnerTitle);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n<script type=\"text/javascript\">\r\n    //");


WriteLiteral("@ sourceURL=http://lpp/GridClientSortColumnTitle.cshtml\r\n    require([\'jQuery\', \'" +
"");


            
            #line 9 "C:\work\DNS\trunk\Lpp.Mvc.Composition\Lpp.Mvc.Controls\Views\Grid\GridClientSortColumnTitle.cshtml"
                   Write(this.Resource("gridClientSortColumn.js"));

            
            #line default
            #line hidden
WriteLiteral("\'], function($, clientSortColumn) { \r\n        $(\"#");


            
            #line 10 "C:\work\DNS\trunk\Lpp.Mvc.Composition\Lpp.Mvc.Controls\Views\Grid\GridClientSortColumnTitle.cshtml"
        Write(id);

            
            #line default
            #line hidden
WriteLiteral("\").closest(\"td, th\")\r\n            .gridClientSideSortColumn( \r\n                cl" +
"ientSortColumn.defaultComparer(\"sort-value\"), \r\n                ");


            
            #line 13 "C:\work\DNS\trunk\Lpp.Mvc.Composition\Lpp.Mvc.Controls\Views\Grid\GridClientSortColumnTitle.cshtml"
            Write( Model.AscendingByDefault ? "true" : "false" );

            
            #line default
            #line hidden
WriteLiteral(" ); \r\n    });\r\n</script>");


        }
    }
}
