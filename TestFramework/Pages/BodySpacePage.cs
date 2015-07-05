using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class BodySpacePage
    {
        private static string BodySpacePageUrl = "http://centrumformy.com/strefa-body-space/";
        public bool IsAtBodySpacePage()
        {
            return Browser.Url == BodySpacePageUrl;
        }
    }
}
