@Sprint2
Feature:OrangeHRMLogin Login functionality

This feature is to test login feature for Orange HRM website

#A Scenario in Cucumber represents a single test case for a particular feature. A Scenario Outline is used when you need to run the same scenario multiple times with different sets of input values.

Background: 
Given User is on login page

@Sanity
Scenario Outline: Verify Login for orange hrm website using valid credentials
 When User enters "<username>" in the Username text box
  And User enters "<password>" in the Password text box
  And User clicks on the Login button
 Then User is navigated to home page

Examples:
| username | password |
| Admin    | admin123 |
| User     | User2133 |

@Regression
Scenario Outline: Verify Login for orange hrm website using invalid credentials
 When User enters "<username>" in the Username text box
  And User enters "<password>" in the Password text box
  And User clicks on the Login button
 Then User is on login page and error message is displayed

Examples:
| username | password |
| Admin    | admin134 |
