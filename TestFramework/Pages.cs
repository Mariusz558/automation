using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage 
        {
            get 
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        public static FitnessAndGymPage FitnessAndGymPage
        {
            get
            {
                var fitnessAndGymPage = new FitnessAndGymPage();
                PageFactory.InitElements(Browser.Driver, fitnessAndGymPage);
                return fitnessAndGymPage;
            }
        }

        public static TennisAndSquashPage TennisAndSquashPage 
        {
            get 
            {
                var tennisAndSquashPage = new TennisAndSquashPage();
                PageFactory.InitElements(Browser.Driver, tennisAndSquashPage);
                return tennisAndSquashPage;
            }
        }

        public static SpaPage SpaPage 
        {
            get 
            {
                var spaPage = new SpaPage();
                PageFactory.InitElements(Browser.Driver, spaPage);
                return spaPage;
            }
        }

        public static BodySpacePage BodySpacePage 
        {
            get 
            {
                var bodySpacePage = new BodySpacePage();
                PageFactory.InitElements(Browser.Driver, bodySpacePage);
                return bodySpacePage;
            }
        }

    }

}
