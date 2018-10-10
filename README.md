# City Info API
## Project Description
This mini project was created while following along with the course "Building Your First API with ASP.NET Core" by Kevin Dockx on Pluralsight

It is intended to be used as a source of reference for future projects.


## Requirements
### Base Requirements
- .NET Core 2.1
- Visual Studio 2017

### Additional NuGet Packages
- Automapper 7.0.1
- Microsoft.EntityFrameworkCore.SqlServer 2.1.4
- NLog.Web.AspNetCore 4.7.0

### Helper Software
Postman - to test API HTTP requests


## Project Contents
- Controllers: As in the C in MVC. These are used to manipulate control the flow of app execution. 
When a request is made it handles these incoming requests, retrieves necessary model data and returns appropriate responses.
- Entities: Used to produce the conceptual data model
- Migrations: To manage incremental changes to relational database schemas.
- Models: Contains primarily Data Transfer Objects (DTO) which are objects that carry data between processes.
- Services: To provide the primary actions and logic that allows to API to function
