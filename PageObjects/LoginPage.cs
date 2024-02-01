using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Vitality_Project_Learnings.Manager;
using Vitality_Project_Learnings.Utilities;

namespace Vitality_Project_Learnings.PageObjects
{
    class LoginPage : DriverManager
    {
        Utility utility;

        [FindsBy(How = How.XPath, Using = "//ul[@class=\"navbar-nav horizontal\"]/li/a/div/span")]
        private IList<IWebElement> txtNavbarMenu;

        [FindsBy(How = How.XPath, Using = "//ul[@class=\"navbar-nav horizontal\"]/li/a")]
        private IList<IWebElement> linkNavbarMenu;

        [FindsBy(How = How.XPath, Using = "//a[@class=\"icon-left both dropdown-item\"]/div[@class=\"info\"]/span[contains(text(),\"Login\")]/parent::div/parent::a")]
        private IWebElement linkLogInOption;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"input-email\"]")]
        private IWebElement inputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"input-password\"]")]
        private IWebElement inputPassword;

        [FindsBy(How = How.XPath, Using = "//input[@value=\"Login\"]")]
        private IWebElement btnLogin;

        public LoginPage()
        {

            String pageTitle = driver.Title;
            Console.WriteLine(pageTitle);
            PageFactory.InitElements(driver, this);
            utility = new Utility();
        }


        public void handleNavbarSelection(String option)
        {
            int index = -1;
            foreach (IWebElement element in txtNavbarMenu)
            {
                index++;
                Console.WriteLine(element.Text);
                if (element.Text.Equals(option))
                {
                    break;
                }
            }
            utility.mouseHover(linkNavbarMenu[index]);
            Thread.Sleep(10000);
        }

        public void ValidateRedirectionToApplication()
        {
            Assert.AreEqual(driver.Title, "Your Store");
        }

        public void clickOnLoginOption()
        {
            linkLogInOption.Click();
            Thread.Sleep(10000);
        }

        public void ValidateRedirectionToLoginPage()
        {
            Assert.AreEqual(driver.Title, "Account Login");
        }
        public void enterEmailAndPassword()
        {
            inputEmail.SendKeys("lambda@gmail.com");
            inputPassword.SendKeys("Lambda@123");
        }
        public void clickOnLogInbutton()
        {
            btnLogin.Click();
        }



    }
}
