﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoC.Security.Mvc.Views.Auth
{
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
    using System.Web.Mvc.Html;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web.Caching;
    using System.Web.DynamicData;
    using System.Web.SessionState;
    using System.Web.Profile;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using System.Xml.Linq;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MvcRazorClassGenerator", "1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Auth/_LogOnNative.cshtml")]
    public class _LogOnNative_cshtml : System.Web.Mvc.WebViewPage<BoC.Security.Mvc.ViewModels.LogOnModel>
    {
#line hidden

        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {

WriteLiteral("\r\n\r\n<h2>Log On</h2>\r\n<p>\r\n    Please enter your username and password. ");


                                        Write(Html.ActionLink("Register", "Register"));

WriteLiteral(" if you don\'t have an account.\r\n</p>\r\n");


 using (Html.BeginForm()) {

WriteLiteral("    <div>\r\n        <fieldset>\r\n            <legend>Sign in with a username/passwo" +
"rd</legend>\r\n\r\n            <div class=\"editor-label\">\r\n                ");


           Write(Html.LabelFor(m => m.UserName));

WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");


           Write(Html.TextBoxFor(m => m.UserName));

WriteLiteral("\r\n                ");


           Write(Html.ValidationMessageFor(m => m.UserName));

WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"editor-label\">\r\n                ");


           Write(Html.LabelFor(m => m.Password));

WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");


           Write(Html.PasswordFor(m => m.Password));

WriteLiteral("\r\n                ");


           Write(Html.ValidationMessageFor(m => m.Password));

WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"editor-label\">\r\n                ");


           Write(Html.CheckBoxFor(m => m.RememberMe));

WriteLiteral("\r\n                ");


           Write(Html.LabelFor(m => m.RememberMe));

WriteLiteral("\r\n            </div>\r\n\r\n            <p>\r\n                <input type=\"submit\" val" +
"ue=\"Log On\" />\r\n            </p>\r\n        </fieldset>\r\n    </div>\r\n");


}


        }
    }
}