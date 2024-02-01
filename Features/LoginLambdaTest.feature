Feature: Login to Lambdatest

Scenario: Login to Lambda Test Application

	Given user navigates to the LambdaTest application 
	When user click on MyAccount dropdown and click "My Accounts"
	And click on the "login" options
	Then user is redirected to Login page
	And Enter the valid Email ID and Password
	Then Click on Login
