Feature: Contact Us Page
	In order to find out more about QAWorks exciting services
	As an end user
	I want a contact us page

@ContactUs
Scenario: Valid Submission
	Given I am on the QAWorks Contact Us Page
	And I enter the username "j.Bloggs"
	And I enter the email "j.Bloggs@qaworks.com"
	And I enter a message "Please contact me I want to find out more"
	When I click the send button
	Then I should be able to contact QAWorks successfully

@Ignore
	Scenario: No Username
	Given I am on the QAWorks Contact Us Page
	And I enter the email "j.Bloggs@qaworks.com"
	And I enter a message "Please contact me I want to find out more"
	When I click the send button
	Then I should get a message "Your name is required"

@Ignore
	Scenario: No Email Address
	Given I am on the QAWorks Contact Us Page
	And I enter the username "j.Bloggs"
	And I enter a message "Please contact me I want to find out more"
	When I click the send button
	Then I should get a message "An Email address is required"

@Ignore
	Scenario: No Message
	Given I am on the QAWorks Contact Us Page
	And I enter the username "j.Bloggs"
	And I enter the email "j.Bloggs@qaworks.com"
	When I click the send button
	Then I should get a message "Please type your message"

@Ignore
	Scenario: Invalid Email Address
	Given I am on the QAWorks Contact Us Page
	And I enter the username "j.Bloggs"
	And I enter the email "abc"
	And I enter a message "Please contact me I want to find out more"
	When I click the send button
	Then I should get a message "Invalid Email Address"

@Ignore
	Scenario: Send Without adding any data
	Given I am on the QAWorks Contact Us Page
	When I click the send button
	Then I should get a message "Please type your message"
	And I should get a message "An Email address is required"
	And I should get a message "Your name is required"