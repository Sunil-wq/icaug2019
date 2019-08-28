Feature: TMFeature
	As a turnup portal i would like to manage time and
	material record in single page

@mtm @automate
Scenario: Turn up admin able to create time and material records
	Given I have loggedin to the turn up portal
	And I have navigate to time and material page
	Then I should be able to create time and material records
