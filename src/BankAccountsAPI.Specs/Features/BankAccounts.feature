
Scenario: Create a new bank account
	Given the user is authenticated
	When a basic account application is made
	Then two accounts should be created for that user

Scenario: Retrieve a bank account based on Guid
	Given the user is authenticated
	When user requests an exsiting account
	Then system should return that account

Scenario: System should return a Bad Request If ModelState is Invalid
	Given the user is authenticated
	When user posts to create an account with invalid data
	Then the system should return 300

Scenario: User should be able to update existing account
	Given the user is authenticated
	When user updates an account with valid data
	Then account should be updated

Scenario: User should be able to retrieve all accounts
	Given the user is authenticated
	When user makes a request to retrieve a list of all the active accounts
	Then system should return a list of all the accounts
