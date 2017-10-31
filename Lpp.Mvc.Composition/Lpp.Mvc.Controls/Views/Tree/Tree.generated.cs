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

namespace Lpp.Mvc.Views.Tree
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
    using Lpp.Mvc;
    using Lpp.Mvc.Controls;
    
    #line 1 "..\..\Views\Tree\Tree.cshtml"
    using Lpp.Utilities.Legacy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tree/Tree.cshtml")]
    public partial class Tree : System.Web.Mvc.WebViewPage<TreeModel>
    {

#line 33 "..\..\Views\Tree\Tree.cshtml"
public System.Web.WebPages.HelperResult Nodes( IEnumerable<TreeNodeModel> nodes )
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 34 "..\..\Views\Tree\Tree.cshtml"
 
    foreach ( var n in nodes )
    {
        var nodeClass = (n.Attributes == null ? null : n.Attributes.ValueOrDefault( "class" )) ?? "Node";


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1456), Tuple.Create("\"", 1540)

#line 38 "..\..\Views\Tree\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 1464), Tuple.Create<System.Object, System.Int32>(nodeClass

#line default
#line hidden
, 1464), false)

#line 38 "..\..\Views\Tree\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 1476), Tuple.Create<System.Object, System.Int32>( n.Expanded && n.PreloadedChildren != null ? " Expanded" : ""

#line default
#line hidden
, 1476), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 1541), Tuple.Create("\"", 1551)

#line 38 "..\..\Views\Tree\Tree.cshtml"
                      , Tuple.Create(Tuple.Create("", 1546), Tuple.Create<System.Object, System.Int32>(n.Id

#line default
#line hidden
, 1546), false)
);


#line 38 "..\..\Views\Tree\Tree.cshtml"
                                                                              WriteTo(__razor_helper_writer, Attributes( n.Attributes, "id", "class" ));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Expand\"");

WriteLiteralTo(__razor_helper_writer, ">&nbsp;</div>\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Text\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 40 "..\..\Views\Tree\Tree.cshtml"
WriteTo(__razor_helper_writer, n.Text);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 41 "..\..\Views\Tree\Tree.cshtml"
            

#line default
#line hidden

#line 41 "..\..\Views\Tree\Tree.cshtml"
               if ( n.PreloadedChildren != null )
               {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " <div");

WriteLiteralTo(__razor_helper_writer, " class=\"Children\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 42 "..\..\Views\Tree\Tree.cshtml"
         WriteTo(__razor_helper_writer, Nodes( n.PreloadedChildren ));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div> ");


#line 42 "..\..\Views\Tree\Tree.cshtml"
                                                                           } 

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </div>\r\n");


#line 44 "..\..\Views\Tree\Tree.cshtml"
    }


#line default
#line hidden
});

#line 45 "..\..\Views\Tree\Tree.cshtml"
}
#line default
#line hidden

#line 47 "..\..\Views\Tree\Tree.cshtml"
public System.Web.WebPages.HelperResult Attributes( IEnumerable<KeyValuePair<string, string>> attrs, params string[] except )
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 48 "..\..\Views\Tree\Tree.cshtml"
 
    foreach ( var a in attrs.EmptyIfNull() )
    {
        if ( except == null || except.Length == 0 || !except.Contains( a.Key ) )
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, " ");


#line 53 "..\..\Views\Tree\Tree.cshtml"
WriteTo(__razor_helper_writer, a.Key);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "=\"");


#line 53 "..\..\Views\Tree\Tree.cshtml"
WriteTo(__razor_helper_writer, a.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 54 "..\..\Views\Tree\Tree.cshtml"
        }
    }


#line default
#line hidden
});

#line 56 "..\..\Views\Tree\Tree.cshtml"
}
#line default
#line hidden

        public Tree()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Tree\Tree.cshtml"
 if ( Model.Options.RenderMode == TreeRenderMode.NodesOnly )
{

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 6 "..\..\Views\Tree\Tree.cshtml"
     Write(Nodes( Model.TopLevelNodes ));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Tree\Tree.cshtml"
}
else
{
    var attrs = Model.Options.TreeAttributes ?? new int[0].ToDictionary( _ => "", _ => "" );
    var id = attrs.ValueOrDefault( "id" ) ?? Html.UniqueId();
    var clss = attrs.ValueOrDefault( "class" ) ?? "Tree";
    this.Stylesheet( "tree.css" );
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 440), Tuple.Create("\"", 453)
            
            #line 15 "..\..\Views\Tree\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 448), Tuple.Create<System.Object, System.Int32>(clss
            
            #line default
            #line hidden
, 448), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 454), Tuple.Create("\"", 462)
            
            #line 15 "..\..\Views\Tree\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 459), Tuple.Create<System.Object, System.Int32>(id
            
            #line default
            #line hidden
, 459), false)
);

            
            #line 15 "..\..\Views\Tree\Tree.cshtml"
                          Write(Attributes( attrs, "class", "id" ));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 15 "..\..\Views\Tree\Tree.cshtml"
                                                              Write(Nodes( Model.TopLevelNodes ));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        //");

WriteLiteral("@ sourceURL=http://lpp/Tree.cshtml\r\n");

            
            #line 18 "..\..\Views\Tree\Tree.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Tree\Tree.cshtml"
         if ( Model.Options.JsModuleHandle.NullOrEmpty() )
        {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("require(");

WriteLiteral(" ");

            
            #line 19 "..\..\Views\Tree\Tree.cshtml"
                                }
        else
        {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("define(\'");

            
            #line 21 "..\..\Views\Tree\Tree.cshtml"
                   Write(Model.Options.JsModuleHandle);

            
            #line default
            #line hidden
WriteLiteral("\',");

WriteLiteral(" ");

            
            #line 21 "..\..\Views\Tree\Tree.cshtml"
                                                               }

            
            #line default
            #line hidden
WriteLiteral("        [\'jQuery\', \'lpp.mvc.controls/tree\'], function($) { $(function(){\r\n       " +
"     $(\"#");

            
            #line 23 "..\..\Views\Tree\Tree.cshtml"
            Write(id);

            
            #line default
            #line hidden
WriteLiteral("\").treeView( \r\n");

            
            #line 24 "..\..\Views\Tree\Tree.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Tree\Tree.cshtml"
                 if ( Model.Options.LoadHive == null )
                {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("null");

WriteLiteral(" ");

            
            #line 25 "..\..\Views\Tree\Tree.cshtml"
                                    }
                else
                {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("function (id) { return \"");

            
            #line 27 "..\..\Views\Tree\Tree.cshtml"
                                           Write(Html.Raw( Url.Action<TreeController>( c => c.Children( id, Model.Options.LoadHive ) ) ));

            
            #line default
            #line hidden
WriteLiteral("\".replace(\"");

            
            #line 27 "..\..\Views\Tree\Tree.cshtml"
                                                                                                                                              Write(id);

            
            #line default
            #line hidden
WriteLiteral("\", id); }");

WriteLiteral(" ");

            
            #line 27 "..\..\Views\Tree\Tree.cshtml"
                                                                                                                                                                       }

            
            #line default
            #line hidden
WriteLiteral("            );\r\n        });});\r\n    </script>\r\n");

            
            #line 31 "..\..\Views\Tree\Tree.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
