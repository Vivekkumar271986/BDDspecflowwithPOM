Feature: Banking project

Lab session for verifying Banking project

Background: 
Given User launches Banking project

@Sanity
Scenario Outline: Verify XYZ Bank login with different Customer logins
	 When I see "//button[@class='btn home']" button
	  And I see "//strong[@class='mainHeading']" heading
	 Then I click "//button[normalize-space()='Customer Login']" button
	 Then I see "//label[normalize-space()='Your Name :']" text
	 Then I click "Hermoine Granger" from "//select[@id='userSelect']" dropdown
	 Then I click "//button[@type='submit']" button
	 Then I see "//strong[contains(text(),'Welcome')]" text
	 Then I see "//span[@class='fontBig ng-binding']" text

  Examples: 
  | username         |
  | Hermoine Granger |
  | Harry Potter     |
  | Ron Weasly       |

@Sanity @Regression
Scenario Outline: Verify XYZ Bank login with Bank Manager login
	 When I see "//button[@class='btn home']" button
	  And I see "//strong[@class='mainHeading']" heading
	 Then I click "//button[normalize-space()='Bank Manager Login']" button
	 Then I see "//button[normalize-space()='Add Customer']" button
	 Then I click "//button[normalize-space()='Add Customer']" button
	 Then I see "//button[normalize-space()='Open Account']" button	 
	 Then I click "//button[normalize-space()='Open Account']" button
	 Then I see "//button[@type='submit']" button
	 Then I fill open account form

 | Customer         | Currency |
 | Hermoine Granger | Dollar   |
 | Harry Potter     | Pound    |
 | Ron Weasly       | Rupee    |