@Sprint2
Feature: OrangeHRMDashboard using data table

Test case to verify left nav options

@Regression
Scenario Outline: Verify Admin page
Given User is on login page
 When User enters "<username>" in the "Username" text box
  And User enters "<password>" in the "Password" text box
  And User clicks on the "Login" button
 Then User is navigated to "Dashboard" page
 When User waits for the "LeftNavDashboard" element to load
 Then User sees "LeftNavDashboard" tab highlighted
 When User clicks on the "LeftNavAdmin" button
 Then User is navigated to "Admin" page
 When User waits for the "Admin" element to load
 Then User selects city and country information

 | city   | country |
 | Delhi  | India   |
 | Boston | USA     |
 
 Examples:
| username | password |
| Admin    | admin123 |
