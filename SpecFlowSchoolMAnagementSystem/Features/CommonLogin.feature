Feature: CommonLogin

Here in this every user can login into the application and can do their respective tasks.
@tag1
Scenario Outline: Enter valid Credentials and use the application as an Admin, Teacher or Parent
	Given Launch the browser
	And Enter the url to open the application
	When Enter the valid username "<un>" and password "<pw>"
	And click on submit button
	Then Verify the homepage is displayed or not

	Examples: 
	|       un        |   pw    |
	| admin@gmail.com |  12345  |
	| t1@gmail.com    |  12345  |
	| dad1@gmail.com  |  12345  |
