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

namespace Lpp.Dns.General.Metadata.Views
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
    using Lpp.Dns.General.CriteriaGroup;
    using Lpp.Dns.General.CriteriaGroup.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    using Lpp.Utilities.Legacy;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DisplayOrgSearchResponse.cshtml")]
    public partial class DisplayOrgSearchResponse : System.Web.Mvc.WebViewPage<string>
    {
        public DisplayOrgSearchResponse()
        {
        }
        public override void Execute()
        {
WriteLiteral(@"<style>
    #orgResults
    #orgResults {
        width:100%;
    }
        #orgResults table {
            width:100%;
        }
        #orgResults .col-name {
            width:570px;
        }
        #orgResults .col-acronym {
            width:95px
        }
        #orgResults .col-parent {
            width:250px;
        }
        #orgResults .col-desc{            
        }
</style>
<div");

WriteLiteral(" class=\"ui-groupbox\"");

WriteLiteral(" id=\"orgResults\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" class=\"table table-bordered table-striped\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n            " +
"    <th>Acronym</th>\r\n                <th>Parent</th>\r\n                <th>Descr" +
"iption</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody");

WriteLiteral(" data-bind=\"foreach: Results\"");

WriteLiteral(">\r\n            <tr>\r\n                <td");

WriteLiteral(" class=\"col-name\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-bind=\"text: Name, attr: { href: \'/organizations/details?ID=\' + ID }\"");

WriteLiteral("></a></td>\r\n                <td");

WriteLiteral(" class=\"col-acronym\"");

WriteLiteral(" data-bind=\"text: Acronym\"");

WriteLiteral("></td>\r\n                <td");

WriteLiteral(" class=\"col-parent\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" data-bind=\"switch: ParentID\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" data-bind=\"case: 0\"");

WriteLiteral(">\r\n\r\n                        </div>\r\n                        <div");

WriteLiteral(" data-bind=\"case: $else\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-bind=\"text: ParentName, attr: { href: \'/organizations/details?ID=\' + Parent" +
"ID }\"");

WriteLiteral("></a>\r\n                        </div>\r\n                    </div>\r\n              " +
"  </td>\r\n                <td");

WriteLiteral(" class=\"col-desc\"");

WriteLiteral(" data-bind=\"text: Description\"");

WriteLiteral(@"></td>
            </tr>
        </tbody>
    </table>

</div>

<script>
    $(function () {
        //Load the data here from the json that is serialized in from the model.
        //Reuses the code from the edit and just changes the bindings
        var data = ");

            
            #line 57 "..\..\Views\DisplayOrgSearchResponse.cshtml"
              Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model == null ? "{}" : Model)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        data = { Results: JSON.parse(data) };\r\n        ko.applyBindings(data, " +
"$(\"#orgResults\")[0]);\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591
