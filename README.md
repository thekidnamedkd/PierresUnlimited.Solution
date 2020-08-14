# _DR. SNEUSS' FACTORY_

#### _C# Week 4 Independent Project_

#### By _**KEVIN DAVIS**_

## Description

_An MVC application in C# for Pierre's seeming endless takeover of the world pastry market. He seriously won't stop until he's driven every last mom and pop small business under. This application uses ASP/.NET Core 2.2 and a SQL Database constructed and managed by Entity. It will keep track of the Pierre's many new ventures, specifically his "world famous" line of many-flavored treats. He will do this with a many-to-many relationship between these objects in his database allowing him to view his mad creations from a number of angles and views. It's also important that Pierre be able to protect this super sensitive information, so we will use Identity to help this fine young capitalist protect his data with a login process._

### Specs
| Spec | Input | Output | Done? |
| :-------------     | :------------- | :------------- | :------------- | 
| Program will create a MVC for Bakery. | input: | output:  | [X] |
| Program will create a class for Treat. | input: | output:  | [X] |
| Program will create a class for Flavor. | input: | output:  | [X] |
| Program will create a join table for FlavorTreat. | input: | output:  | [X] |
| Program will create a controller these two classes. | input: | output:  | [X] |
| Program will create a contain CRUD routes for these two class controllers. | input: | output:  | [X] |
| Program will create a contain corresponding CRUD views for the two classes so that users can interact with the database. | input: | output:  | [ ] |
| Program will display many-to-many functionality with usable data in either View set. | input: | output:  | [ ] |
| Program will create a User class for login process. | input: | output:  | [ ] |
| Program will create a Account controller and corresponding Views. | input: | output:  | [ ] |

## Program Setup/Installation Requirements
* _First make sure you have the .NET Core installed for your operating system. If you are unsure go here https://dotnet.microsoft.com/download/dotnet-core/2.2. Find the right version for you and install._
* _Visit the following link: https://github.com/thekidnamedkd/PierresLogin.Solution_
* _Clone the repository to your desired directory._
* _Use the terminal to navigate into to PierresLogin.Solution_
* _Once inside the folder, navigate further to the Bakery folder via the terminal._
* _There you can use the command ```$dotnet restore``` to add the necessary system files to the application._
* _Then you can use the command ```$dotnet ef database update``` to create a MySQL database for the pplication._
* _Once that is complete you can run ```$dotnet run``` to launch the application._
* _If the program successfully launches you should be able to go to http://localhost:5000/ to view the project._

## Known Bugs

_No known bugs at this time._
## Support and contact details

_For questions, comments, or collaboration contact me at thekidnamedkd@gmail.com_

## Technologies Used

* _C#_
* _.NET Core 2.2_
* _Entity_
* _VS Code_
* _MySQL_
* _Git_
* _HTML_
* _CSS_

### License

*GPL license distribution*

Copyright (c) 2020 **_Kevin Davis_**