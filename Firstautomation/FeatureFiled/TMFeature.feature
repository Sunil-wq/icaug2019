Feature: TMFeature
	As a turnup portal i would like to manage time and
	material record in single page

@mtm @automate
Scenario: Turn up admin able to create time and material records
	Given I have loggedin to the turn up portal
	And Navigate to home page
	And I should be able to create time and material records

	
@mtm @automate
Scenario: Turn up admin able to edit time and material records
	Given I have loggedin to the turn up portal
	And Navigate to home page
	And I should be able to edit time and material records

	
@mtm @automate
Scenario: Turn up admin able to delete time and material records
	Given I have loggedin to the turn up portal
	And Navigate to home page
	And I should be able to delete time and material records



	


