Feature: Login

Scenario: Login to the Hudl site with the right credentials
	Given the user insered the right credential
	When the user click the Login button
	Then Home page is displayed

	Scenario: Login to the Hudl site with the wrong credentials
	Given the user insered the wrong credential
	When the user click the Login button
	Then an error message is displayed

    Scenario: Login to the Hudl site with bad formatted mail 
	Given the user insered the a bad formatted mail and a password
	When the user click the Login button
	Then an error message is displayed

	Scenario: User neeeds help
	Given the user has inserted the mail but does not remember the password
	When the user click the  need help button
	Then  the reset password form is displayed