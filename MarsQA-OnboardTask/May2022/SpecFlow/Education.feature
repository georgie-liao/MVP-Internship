Feature: Education

As a seller,
I would like to add, edit and delete education on my profile,
So that I can mange my profile successfully

@Add
Scenario: 4_1 Add education on profile 
	Given I logged into portal
	When I add educaiton on profile
	Then Educaiton should be added successfully

	@Edit

Scenario Outline: 4_2 Edit eduction on profile
Given I logged into portal
When I edit '<Country>','<University>','<Title>','<Degree>','<Graduation Year>' on the existing description record 
Then The record shoud have edtied '<Country>','<University>','<Title>','<Degree>','<Graduation Year>'

Examples: 
| Country        | University              | Title     | Degree           | Graduation Year |
| United Kingdom | University of Cambridge | Associate | Associate Degree | 2008            |
| Australia      | University of Australia | B.A       | Bachelor Degree  | 2012            |
| United States  | American University     | PHD       | Doctoral Degree  | 2016            |

@Delete
Scenario: Delete education on profile
Given I logged into portal
When I delete an education record
Then The education record should be deleted successfully