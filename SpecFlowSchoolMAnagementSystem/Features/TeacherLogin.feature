Feature: TeacherLogin

A teacher can login into the application and use the application


Scenario: Enter valid creadentials and login to School Management System
	Given Open the browser
	And Enter the url
	When In login page enter valid credential
	And Click on login button
	Then Verify home page is dsplayed or not
