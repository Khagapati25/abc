Feature: CreateOrg

The user can login to vtiger with valid credentials and create org


Scenario Outline: : Create organization with mandatory fields
	Given launch the browser and enter the url
	And in login page enter the username and password and click on login button
	When In home page click on organization link
	And in organization page click on create organization image
	And In create organization page enyer "<OrgName>" and click on save button
	Then Verify "<OrgName>" is created or not


	Examples: 
	| OrgName |
	| Ajio    |
	| Myntra  |
