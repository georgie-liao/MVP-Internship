Feature: 2 Languages

As a seller, 
I would like to add, edit and delelte languages on my profile 
So that I can manage the language on my profile successfully

@Add
Scenario: 2_1 Add language on profile
	Given I logged into portal 
	When I add language on my profile
	Then The language should added successfully

@Edit
Scenario Outline: 2_2 Edit language on profile
Given I logged into portal
When I edite '<Languages>' and '<Level>'on an existing language record
Then The record should have the edited '<Languages>' and '<Level>' 

Examples: 
| Languages | Level            |
| Maori     | Basic            |
| Chinese   | Native/Bilingual |
| Spanish   | Conversational   |


@Delete
Scenario: 2_3 Delete language on profile
Given I logged into portal
When I delete a language from an existing language record
Then The language record should be deleted successfully