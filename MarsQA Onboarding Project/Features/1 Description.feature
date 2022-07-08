Feature:1 Description

As a seller,
I would like to add, edit and delte descrption
So that I can manage my profile descrption


@Add
Scenario: 1_1 Add descriptin on profile
	Given I logged into portal
	When I add description on profile
	Then The description should be added successfully

@Edit
Scenario Outline: 1_2 Edit description on profile
Given I logged into portal 
When  I edit '<Description>' on the existing description record 
Then  The record should have the updated '<Description>' 

Examples: 
| Description                |
| Experienced Seller         |
| Certified Graphic Designer |
| Hard worker                |


@Delete
Scenario: 1_3 Delete description on profile
Given I logged into portal 
When I delete description on profile
Then The descrption should be deleted successfully