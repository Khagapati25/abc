Feature: AdminEndToEnd

An admin here can login after that he can acess all the modules and can add all the necessary details for classroom
teachers and students.

Scenario: Enter the valid credential to login as an admin
	Given Open Browser
	And Enter the url to launch the application
	When In login page enter valid email "admin@gmail.com" and password "12345"
	And Click on submit button to sucessfully login
	Then Veryify homepage is displayed or not

	Scenario: Goto Classroom module and add a new Classroom
	Given Click on Classroom module
	When Enter name and student count
	And Click on Submit Button to sucessfully create a new Classroom
	Then Verify Classroom is created or not

Scenario: Goto Grade module and add a new Grade
	Given Click on Grade module
	When Enter the necessery details about grade
	And Click on next button to sucessfully create a new Grade
	Then Verify Grade is created or not

Scenario: Goto Subject and add a new Subject
	Given Click on subject module
	When Enter the subject name
	And Click on Submit button to sucessfully create a new Student
	Then Verify Subject is Create or not

Scenario: Goto Teacher module and add a new Teacher
	Given Click on Teachers module
	And Click on Add Teacher feature
	When Enter the necessary details about teacher
	And Click onsubmit button to sucessfully create a new Teacher
	Then  Verify Teacher is created or not

Scenario: Goto Subject routing module and add a new Subject routing
	Given Click on Subject routing module
	And Click on add button
	When Select the option from each drop down
	And Click on submit button to sucessfully create a subject routing
	Then Verify subject routing is created or not


Scenario: Goto Students module and add a new student and guardian
	Given Clcik on Students module
	And Click oon Add Student feature
	When Enter the necessary details of student and guardian
	And Click on next button to sucessfully create a student and guardian

Scenario: Click on logout button to sucessfully logout as an admin
	Given Click on your name in top right corner of the application
	And Click on Signout button
	Then Verify login page is displayed or not