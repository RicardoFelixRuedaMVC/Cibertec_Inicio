using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        
        public static IHtmlString DisplayPriceStatic(double price)
        {
           return new HtmlString(ResultPrice(price));
        }
        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
           return new HtmlString(ResultPrice(price));
        }
        public static IHtmlString DisplayDateOrNullStatic(DateTime? dateCreation)
        {
            return new HtmlString(ResultDateCreation(dateCreation));
        }
        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? dateCreation)
        {
            return new HtmlString(ResultDateCreation(dateCreation));
        }
        private static string ResultPrice(double price)
        {
           return price == 0.0? "<span>FREE!!!</span>":$"<span>{price}</span>";
        }
        private static string ResultDateCreation(DateTime? dateCreation)
        {
           return dateCreation == null?  "<span>Not definition!!!</span>": $"<span>{dateCreation.Value.ToShortDateString()}</span>"; 
        }
    }
}