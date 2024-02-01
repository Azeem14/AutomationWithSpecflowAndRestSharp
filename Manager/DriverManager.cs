using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Vitality_Project_Learnings.Manager
{
    class DriverManager
    {
        public static IWebDriver driver;

        public static void getDriver(String browser)
        {
            if (driver == null)
            {
                switch (browser)
                {
                    case "Chrome":
                        driver = new ChromeDriver();
                        break;
                    case "FireFox":
                        driver = new FirefoxDriver();
                        break;
                    case "Edge":
                        driver = new EdgeDriver();
                        break;
                }
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }

        }

    }
}
