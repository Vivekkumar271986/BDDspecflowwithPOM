﻿@Sprint2
Feature:OrangeHRMLogin Login functionality using resuable flow

This feature is to test login feature for Orange HRM website

Background: 
Given User is logged in to the site with username <username> and password <password>

| username | password |
| Admin    | admin123 |

@Sanity
Scenario: Verify Successful Login to orange hrm website using valid credentials
 Then User is navigated to "Dashboard" page