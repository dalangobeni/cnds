﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.HealthCare.ESPQueryBuilder.Views.ESPQueryBuilder.Terms
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
    using Lpp.Dns.HealthCare.Controllers;
    using Lpp.Dns.HealthCare.ESPQueryBuilder;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Models;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ESPQueryBuilder/Terms/DiseaseSelector.cshtml")]
    public partial class DiseaseSelector : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.ESPQueryBuilder.Models.ESPQueryBuilderModel>
    {
        public DiseaseSelector()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\ESPQueryBuilder\Terms\DiseaseSelector.cshtml"
  
    Layout = null;
    var id = Html.UniqueId();
    var defaultCondition = Model.DiseaseSelections.Select(s => s.Name).First();
    if (Model.Disease == null)
    {
        Model.Disease = defaultCondition;
    }
    var viewModel = new {
        Selected = Model.Disease,
        Options = Model.DiseaseSelections.Select(s => new { s.Display, Value = s.Name })
    };
    
            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"DiseaseSelectorTerm Term panel panel-default\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" name=\"TermName\"");

WriteLiteral(" value=");

WriteLiteral(" \"DiseaseSelector\" hidden=\"hidden\" style=\"display:none\" />\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui-button-remove\"");

WriteLiteral("></div>\r\n        Condition<img");

WriteLiteral(" id=\"conditionTooltip\"");

WriteLiteral(" src=\"/Content/img/icons/help16.gif\"");

WriteLiteral(" data-toggle=\"tooltip\"");

WriteLiteral(" class=\"helptip\"");

WriteLiteral(" title=\"The Conditions listed may differ by network.\"");

WriteLiteral(" />\r\n    </div>\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\"", 890), Tuple.Create("\"", 898)
            
            #line 21 "..\..\Views\ESPQueryBuilder\Terms\DiseaseSelector.cshtml"
, Tuple.Create(Tuple.Create("", 895), Tuple.Create<System.Object, System.Int32>(id
            
            #line default
            #line hidden
, 895), false)
);

WriteLiteral(" class=\"DiseaseSelector panel-body\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" name=\"Disease\"");

WriteLiteral(" data-bind=\"kendoDropDownList:{ dataTextField:\'Display\', dataValueField:\'Value\', " +
"value:Selected, data:Options }\"");

WriteLiteral(" style=\"width:300px;\"");

WriteLiteral(" />\r\n        <script>\r\n            $(function () {\r\n        var bindingContainer " +
"= $(\'#");

            
            #line 25 "..\..\Views\ESPQueryBuilder\Terms\DiseaseSelector.cshtml"
                              Write(id);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n        var m = ");

            
            #line 26 "..\..\Views\ESPQueryBuilder\Terms\DiseaseSelector.cshtml"
           Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(viewModel)));

            
            #line default
            #line hidden
WriteLiteral(@";
        ko.applyBindings({
        Selected: ko.observable(m.Selected),
                    Options: ko.observableArray(m.Options)
                }, bindingContainer[0]);
                $('#conditionTooltip').tooltip({placement : 'bottom', trigger: 'click'});
    })
        </script>
        <style>
            #conditionTooltip + .tooltip > .tooltip-inner{
                min-width:30px;
            }
        </style>
    </div>
</div>

");

        }
    }
}
#pragma warning restore 1591