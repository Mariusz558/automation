using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
   public class SpaPage
    {
       private static string SpaPageUrl = "http://centrumformy.com/spa-welness/";
        public bool IsAtSpaPage()
        {
            return Browser.Url == SpaPageUrl;
        }
    }
}
