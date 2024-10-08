Feature: Language

Login to the Profile
Add update, and delete the languages

@tag1
Scenario Outline: Add language 
	Given I logged into the Profile site
	When Navigate to the profile tab
	When '<Add>' the Language in language tab

	Examples: 
	 | Add   | 
	 | Spansish	  | 
	 | French     |
	
	 
Scenario Outline: Edited Language
	Given I logged into the Profile site
	When Navigate to the profile tab
	When Edited the '<Language>'

	Examples: 
	 | Language   | 
	 | Telugu	  | 
	 | French     | 

Scenario: Delete Language
	Given I logged into the Profile site
	When Navigate to the profile tab
	When Delete the Language


