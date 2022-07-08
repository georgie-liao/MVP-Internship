Feature: 6 OtherInfo

As a seller
I would like to add, edit and delete other information such as availability, hours, and earn target
So that I can manage these information successfully

@Add
Scenario: 6_1 Add availability, hous, and earn target on profile
	Given I logged into portal
	When I add availability, hours, and earn target on profile
	Then availability, hours, and earn target should be added to profile

	@Edit 
	Scenario: 6_2 Edit availability, hous, and earn target on profile
	Given I logged into portal
	When I edit availability, hous, and earn target on profile
	Then The record should have edited availability, hous, and earn target