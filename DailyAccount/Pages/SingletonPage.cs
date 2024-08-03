using DailyAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccount.Pages
{
    public class SingletonPage
    {
        private static ContentPage currentPage = null;
        private static Dictionary<PageType, ContentPage> tempPage = new Dictionary<PageType, ContentPage>();

      
        public static ContentPage CreatePage(PageType pageTypeName)
        {
            string type = $"DailyAccount.Pages.{pageTypeName}";
            Type t = Type.GetType(type);

            if (tempPage.ContainsKey(pageTypeName))
            {
                currentPage = tempPage[pageTypeName];
            }
            else
            {
                currentPage = Activator.CreateInstance(t) as ContentPage;
                tempPage[pageTypeName] = currentPage;
            }

            return currentPage;
        }
    }
}
