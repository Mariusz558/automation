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
        //private static string TennisPageTitle = "Centrum Formy - Dąbrowa Górnicza |TENIS  I SQUASH";

        [FindsBy(How = How.LinkText, Using = "TENIS I SQUASH")]
        private IWebElement tennisAndSquashLink; 

        public void GoTo()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }


        public void SelectTennisAndSquash()
        {
            
           //var tennisAndSquashLink = Browser.Driver.FindElement(By.Id("menu-item-179"));
           tennisAndSquashLink.Click();
        }

        /*public bool IsAtTennisAndSquash()
        {
            return Browser.Title == TennisPageTitle;
        }*/

        /*public void SelectMenuItem()
        {
            throw new NotImplementedException();
        }*/
    }
}
