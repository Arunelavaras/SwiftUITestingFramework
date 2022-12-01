Feature: Admin1
Background: 
Given user on the homepage   

@smoke
Scenario Outline: Verify Add Job with valid data 
	Given User select admin page 
	When User clicks on Job Title	
	And user click on add button
	And user Enters job title as "Qa tester"
	And User Enters Job Description "Qa data"
	And User Enters add note "note"
	And User clicks on Save button
	Then User sucessfully added job
