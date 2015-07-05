using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class HomePage
    {
        static string Url = "http://centrumformy.com";
        private static string PageTitle = "Centrum Formy - Dąbrowa Górnicza |";        

        [FindsBy(How = How.LinkText, Using = "TENIS I SQUASH")]
        private IWebElement tennisAndSquashLink;

        [FindsBy(How = How.LinkText, Using = "FITNESS I SIŁOWNIA")]
        private IWebElement fitnessAndGymLink;

        [FindsBy(How = How.LinkText, Using = "STREFA SPA")]
        private IWebElement spaLink;

        [FindsBy(How = How.LinkText, Using = "STREFA BODY SPACE")]
        private IWebElement bodySpaceLink;

        [FindsBy(How = How.LinkText, Using = "BAWILANDIA")]
        private IWebElement playgroundLink;

        public void GoTo()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectFitnessAndGym()
        {
            fitnessAndGymLink.Click();
        }

        public void SelectTennisAndSquash()
        {
           tennisAndSquashLink.Click();
        }

        public void SelectSpa()
        {
            spaLink.Click();
        }

        public void SelectBodySpace()
        {
            bodySpaceLink.Click();
        }

        public void SelectPlayground()
        {
            playgroundLink.Click();
        }
    }
}
