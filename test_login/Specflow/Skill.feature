Feature: Skill

Login to the Skills
Add update, and delete the Skills
@tag1
Scenario Outline: Add Skill
	Given I logged into the Profile page
	When Navigate to the profile 
	Then Add the '<Addskill>' in skill tab

	Examples: 
	| Addskill |
	| Specflow |
	| Cucumber |
	| Paint    |

Scenario Outline: Editing the Skill
	Given I logged into the Profile page
	When Navigate to the profile
	Then Update the '<Skill>' in the skill tab

	Examples: 
	| Skill |
	| Yoga  |
	| Dance |
	| Music |

Scenario: Delete Skill
	Given I logged into the Profile page
	When Navigate to the profile
	Then Delete the Skill

	
	 

