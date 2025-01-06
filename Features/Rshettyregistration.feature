@Sprint1
Feature: Feature to register for Rahulshetty acadamies angular practice session

A short summary of the feature

@Sanity
Scenario Outline: Fill the registration form
	Given I navigate to website
	 When I see "ProtoCommerce" in header
	 Then I fill the registration form
	| Name  | Email          | Password | Gender | DateofBirth	|
	| Vivek | vkum@gmail.com | Vk123    | Male   | 2024-12-23   |