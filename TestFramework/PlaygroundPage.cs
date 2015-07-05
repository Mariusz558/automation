using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class PlaygroundPage
    {
        private static string PlaygroundPageUrl = "http://centrumformy.com/bawilandia/";


        public bool IsAtPlaygroundPage()
        {
            return Browser.Url == PlaygroundPageUrl;
        }
    }
}
