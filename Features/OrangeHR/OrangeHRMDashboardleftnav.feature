﻿@Sprint3
Feature: OrangeHRMDashboard left nav validation

Test case to verify left nav options

@Regression
Scenario Outline: Verify Admin page
Given User is on login page
 When User enters "<username>" in the "Username" text box
  And User enters "<password>" in the "Password" text box
  And User clicks on the "Login" button
 When User is navigated to "Dashboard" page
 Then User sees "LeftNavDashboard" tab highlighted
 
 Examples:
| username | password |
| Admin    | admin123 |
