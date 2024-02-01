using Vitality_Project_Learnings.Manager;
using Vitality_Project_Learnings.PageObjects;

namespace Vitality_Project_Learnings.StepDefinitions
{
    [Binding]
    class LoginSteps : DriverManager
    {
        LoginPage loginpage;

        public LoginSteps()
        {
            loginpage = new LoginPage();
        }

        [Given(@"user navigates to the LambdaTest application")]
        public void GivenUserNavigatesToTheLambdaTestApplication()
        {
            loginpage.ValidateRedirectionToApplication();
        }

        [When(@"user click on MyAccount dropdown and click ""([^""]*)""")]
        public void WhenUserClickOnMyAccountDropdownAndSelect(string option)
        {
            loginpage.handleNavbarSelection(option);
        }

        [Then(@"user is redirected to Login page")]
        public void ThenUserIsRedirectedToLoginPage()
        {
            loginpage.ValidateRedirectionToLoginPage();
        }

        [Then(@"Enter the valid Email ID and Password")]
        public void ThenEnterTheValidEmailIDAndPassword()
        {
            loginpage.enterEmailAndPassword();
        }

        [Then(@"Click on Login")]
        public void ThenClickOnLogin()
        {
            loginpage.clickOnLogInbutton();
        }

        [When(@"click on the ""([^""]*)"" options")]
        public void WhenClickOnTheOptions(string login)
        {
            loginpage.clickOnLoginOption();
        }




    }
}
