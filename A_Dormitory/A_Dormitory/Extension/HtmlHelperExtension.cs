using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Dormitory.Extension
{
    public static class HtmlHelperExtension
    {
        public static MvcHtmlString KnockoutJsDropDownDictList(this HtmlHelper htmlHelper,string options,string name,string id,string optionsCaption,string selectedOptions)
        {
            var myOptionsCaption = string.Format("Choose {0}...", optionsCaption);
            string myString = string.Format("<select class=\"form-control valid\" data-bind=\"options: {0},selectedOptions: {4}, optionsText: 'Name', optionsValue: 'Code', optionsCaption: '{1}'\" id=\"{2}\" name=\"{3}\"></select>", options,myOptionsCaption,id,name,selectedOptions);
            return new MvcHtmlString(myString);
        }
    }
}