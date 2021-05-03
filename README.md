# **CubeCodingTest** - .NET 5 / Angular 11 project

## Prerequisite 
* Visual Studio 2019
* .NET 5 SDK
* Angular CLI

## Backend

Using command line
* Change directory to `.\backend`
* Run `dotnet build` to build the solution.
* Run `dotnet test` to run unit tests.
* Change directory to `.\CubeCodingTest.Api\bin\Debug\net5.0`. Run `dotnet CubeCodingTest.Api.dll`. The application will run on port 5000 (HTTP) and (HTTPS)

Using Visual Studio
* Run project CubeCodingTest.Api. The application will run on port 53855 (HTTP) and 44381 (HTTPS)


## Frontend

Run `npm install` to install dependencies.

Update `baseApiUrl` in `src\environments\environment.ts` with the port the backend application is running on

Run `ng serve` to run the frontend in development mode. The default port is 4200. Run `ng serve --port <PORT NUMBER>` if you want to run using a different port. Note that you will need update appsettings.json file in .NET Web project to allow CORS for the chosen port. 