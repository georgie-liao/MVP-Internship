Feature: Certification

As a seller
I would like to add, edit and delete certification on profile
So that I can manage certification successfully

@Add
Scenario: 5_1 Add Certification on profile
	Given I logged into portal
	When I add certification on profile
	Then The certification should be added successfully

	@Edit
	Scenario Outline: 5_2 Edit Certification on profile
	Given I logged into portal
	When I edit '<Certificate>','<Certificate From>' ,'<Certificate Year >'on the existing Certification record
	Then The record should have the edited '<Certificate>','<Certificate From>' ,'<Certificate Year >'

	Examples: 
	| Certificate                             | Certificate From                  | Certificate Year |
	| Certificate in Applied Science          | Auckland University of Technology | 2009             |
	| Graduate Certificate in Applied Science | University of Otago               | 2011             |
	| Certificate in Teaching                 | University of Wellington          | 2015             |
	
	@Delete
	Scenario: 5_3 Delete certification on profile
	Given I logged into portal
	When I delete a record of existing certification
	Then The recrod should be deleted successfully
