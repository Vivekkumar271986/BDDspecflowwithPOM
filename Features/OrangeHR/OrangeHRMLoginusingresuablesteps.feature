@Sprint2
Feature:OrangeHRMLogin Login functionality using resuable flow

This feature is to test login feature for Orange HRM website

Background: 
Given User is logged in to the site with username <username> and password <password>

| username | password |
| Admin    | admin123 |

@Sanity
Scenario: Verify Successful Login to orange hrm website using valid credentials
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