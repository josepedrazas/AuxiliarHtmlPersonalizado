using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuxiliarHtmlPersonalizado.Helpers
{
    public static class BootstrapHelpers
    {
        public static MvcHtmlString Etiqueta(this HtmlHelper helper,string target,string text)
        {
            var etiqeta = String.Format("<label for='{0}'>{1}</label>", target, text);
            return MvcHtmlString.Create(etiqeta);
        }
        public static MvcHtmlString Boton(this HtmlHelper helper, string style,string text)
        {
            var boton = String.Format("<button type='submit' class='{0}'>{1}</button>", style, text);
            return MvcHtmlString.Create(boton);
        }
    }
}