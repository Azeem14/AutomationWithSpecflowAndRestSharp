using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Vitality_Project_Learnings.Manager;

namespace Vitality_Project_Learnings.Utilities
{
    class Utility : DriverManager
    {

        public void mouseHover(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

    }
}
