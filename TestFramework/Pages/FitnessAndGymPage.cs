using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class FitnessAndGymPage
    {
        private static string FitnessPageUrl = "http://centrumformy.com/fitness-i-silownia/";

        public bool IsAtFitnessAndGym()
        {
            return Browser.Url == FitnessPageUrl;
        }
    }
}
