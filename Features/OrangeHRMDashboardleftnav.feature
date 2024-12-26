@Sprint3
Feature: OrangeHRMDashboard left nav validation

Test case to verify left nav options

@Regression
Scenario Outline: Verify Admin page
Given User is on login page
 When User enters "<username>" in the "//input[@placeholder='Username']" text box
  And User enters "<password>" in the "//input[@placeholder='Password']" text box
  And User clicks on the Login button
 Then User is navigated to "//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']" page with "//a[@class='oxd-main-menu-item active']" tab highlighted
 
 Examples:
| username | password |
| Admin    | admin123 |
