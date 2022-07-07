Feature: Skill

As a seller,
I would like to add, edit and delete skills on my profile
So that
I can manage my skills successfully

@Add
Scenario: 3-1 Add Skill on profile
	Given I logged into portal
	When I add skill on profile
	Then The skill should be added successfully

@Edit
Scenario Outline: 3-2 Edit Skill on profile
Given I logged into portal
When I edit '<Skill>' and '<Level>' on the existing skill record
Then The record should have edited '<Skill>' and '<Level>'

Examples: 
| Skill          | Level        |
| Graphic Design | Beginner     |
| Translation    | Intermediate |
| Teaching       | Expert       |

@Delete 
Scenario: 3-3 Delete Skill on profile
Given I logged into portal
When I delete a Skill from existing Skill records
Then The skill record should be deleted successfully
