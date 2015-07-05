using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class TennisAndSquashPage
    {
        //static string Url = "http://centrumformy.com/tenis-i-squash/";
        private static string TennisPageUrl = "http://centrumformy.com/tenis-i-squash/";

        public bool IsAtTennisAndSquash()
        {
            return Browser.Url == TennisPageUrl;             
        }
    }

}
