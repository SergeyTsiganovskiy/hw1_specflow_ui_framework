Feature: Official site main page
	In order to get new clients
	As a EPAM's owner
	I want to have easy to navigate and correct official site's (https://www.epam.com/) main page

Scenario: Application is loaded successfully
	Given Browser is opened
	When I navigate to the main page
	Then I should see the right title in browser's tab and Epam's logo in header


Scenario: Main page have correct links to navigate inner chapters 
	Given I am on the main page
	When I navigate each inner chapter
	Then I should be on right page and see correct header


Scenario: 'Contac us' page is opened and have correct information
	Given I am on the loan application screen
	When I click 'Contact us' button
	Then I should be on right page and see correct contact info