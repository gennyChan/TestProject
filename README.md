The test solution is composed by 2 projects
- TestProject
- TestFramework

TestProject
Contains the test methods.
SpecFlow was used to specifing test cases using a Gerking sintax
The test project does not have any reference to Selenium, in this way  if Selenium have to be replaced by another framework the test project doesn't have to be edited.

TestFramework
Contains the methods to interact with the login page.
The test framework was developed using the Page Object model paradigm

Test cases can be run using visual studio IDE or using the console command
vstest.console.exe TestProject.dll

It's needed to have the chrome web driver in the C:\WebDriver path 
