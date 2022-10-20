Feature: LoginVTiger

A user can login to VTiger using valid credentials

#Background: Common Steps
#	Given Open the browser
#	And Enter the url


Scenario: Enter valid creadentials and login to vtiger
	When In login page enter valid credential
	And Click on login button
	Then Verify home page is dsplayed or not

#
#Scenario: Enter valid username and password and login to vtiger
#	When In login page enter valid username "admin" and password "admin"
#	And Click on login button
#	Then Verify home page is dsplayed or not
