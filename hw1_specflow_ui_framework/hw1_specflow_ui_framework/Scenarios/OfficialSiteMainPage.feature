Feature: Official site main page
	In order to get new clients
	As a EPAM's owner
	I want to have easy to navigate and correct official site's (https://www.epam.com/) main page

Scenario: Application is loaded successfully
	Given Browser is opened
	When I navigate to the main page
	Then I should see the right title in browser's tab and Epam's logo in header

