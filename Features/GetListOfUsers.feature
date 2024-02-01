Feature: Retrive List of Users

Scenario Outline: Get list of users

	Given the API endpoint for get list users is available
	When I make a "<Method>" with "<Content Type>" to the endpoint "<Url>" with "<param>"
	Then the response status code should be <Status code>
	And the response should contain a list of users
	And the response body should contain "<Key>" and "<Expected Value>"

Examples:

	| Test case ID | Url                 | param  | Headers          | Method | Content Type     | Status code | Key          | Expected Value                                                           |
	| 101          | /api/users/{pageNo} | path:2 | application/json | Get    | application/json | 200         | data.id      | 2                                                                        |
	| 102          | /api/users/{pageNo} | path:2 | application/json | Get    | application/json | 200         | support.url  | https://reqres.in/#support-heading                                       |
	| 103          | /api/users/{pageNo} | path:2 | application/json | Get    | application/json | 200         | support.text | To keep ReqRes free, contributions towards server costs are appreciated! |
