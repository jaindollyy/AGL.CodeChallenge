# AGL.CodeChallenge

EDITOR

Microsoft Visual Studio Community 2017

INSTRUCTIONS

1. Download solution

2. Build solution to restore Nuget packages

3. Run the project (StartUp Project is AGL.CodeChallenge)

4. Execute the Unit Tests project

SOLUTION DESCRIPTION

The solution consists of 4 projects.

1. AGL.CodeChallenge is a console application to write the ouput to console.
 
2. AGL.CodeChallenge.Data is a class library for data entities

3. AGL.CodeChallenge.Utility is a class library and it has the core logic to consume json and load Person List. It also has a PersonRepository class which is used to group and sort pets in the requested structure.

4. AGL.CodeChallenge.Tests contains tests for PersonRepository function GetCatsByOwnerGender. The tests cover three cases:

a. Valid data and successful execution

b. Valid data by checking null collection 

c. Invalid data with an expected exception

PROGRAMMING CHALLENGE 
A json web service has been set up at the url: http://agl-developer-test.azurewebsites.net/people.json
You need to write some code to consume the json and output a list of all the cats in alphabetical order under a heading of the gender of their owner.
You can write it in any language you like. You can use any libraries/frameworks/SDKs you choose.
Submissions which include tests will be looked upon more favourably
Example:
Male
•	Angel
•	Molly
•	Tigger
Female
•	Gizmo
•	Jasper
Notes
•	Use of language features and/or libraries for grouping/sorting is encouraged. Eg: C# -> LINQ, Java8 -> Stream API, Javascript -> Lodash, Python -> List comprehension
•	Use of libraries for consumption of web services is encouraged. Eg: C# -> HttpClient, Java -> HttpClient, Javascript -> jQuery
•	You can write it in your favourite Text Editor/IDE
•	Submissions will only be accepted via github or bitbucket
