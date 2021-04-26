Feature: Loginpage
       In order to test the login functionality 
	   As a user
	   I want to be able to validate the login works.

@mytag
Scenario: When a valid credentials are used user should be able to do successful login
	Given I am at the login page
	And I validate that I am at the login page
	When I enter valid credentials
	And I click the loginbutton
	Then I should be logged in successfully

	
@mytag
 Scenario: When invalid username is used should result in faliure of login
	Given I am at the login page
	And I validate that I am at the login page
	When I login with username 'name 1234'
	And I click the loginbutton
	Then I should be not logged in

	@mytag
  Scenario: When password is not valid should result faliure of login
	Given I am at the login page
	And I validate that I am at the login page
	When I login with <username> and with <password>
	And I click the login button
	Then I should not be logged in 
	Examples: 
	| username |  | password |
	| hari123  |  | 12341234 |
	| abc1234  |  | 000test|
