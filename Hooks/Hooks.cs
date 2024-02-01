using Vitality_Project_Learnings.Manager;

namespace Vitality_Project_Learnings.Hooks
{
    [Binding]
    class Hooks : DriverManager
    {

        [BeforeFeature]
        public static void setUpDriver()
        {
            DriverManager.getDriver("Chrome");
            driver.Url = "https://ecommerce-playground.lambdatest.io";

        }

        [AfterScenario]
        public static void tearDownDriver()
        {
            driver.Close();
        }
    }
}
