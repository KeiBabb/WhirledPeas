
# Getting Started
## Environment
* Install VS Code app
* Get most recent .NET Core SDK
* Install Git
  * Create organization
  * Create repository
* Where do you want to keep the DB?
  * Azure SQL Server
  * Local DB: SQL Lite
* Make sure Autosave is on: File -> Autosave

## ASP.NET Core MVC Setup
* Create project folder (in your file system)
* Navigate to the folder in terminal (View -> Integrated Terminal)
* Terminal -> dotnet
* Terminal -> dotnet new //gives you all of the templates you can build
  * Terminal -> When you're in the folder, dotnet new mvc
  * Terminal -> If you just want a single page, dotnet new page
* Create Models folder and build your DB entities (C# classes; see examples)

## Create GitRepository
* Terminal -> git init //only run once locally and never again
* Terminal -> git add -A //use everything in the folder that I'm tracking in this project (ignore hidden files)
  * Run this for every time you add a file
* Create a new file in the main folder called ".gitignore"
  * List folders and files one line at a time in that file and it will be ignored
  * See the list in the current file for examples
* Terminal -> git commit -m "'Put notes here for what's going in"
* Setup Remote
  * Terminal -> git remote add origin https://github.com/KeiBabb/WhirledPeas.git //establishes connection to remote reposity
  * Terminal -> git push -u origin master

## Getting Packages for your Project
* Go to www.nuget.org
* Search for microsoft.entityframeworkcore, click on it
* Select 2.1.1, view the .NET CLI version of the command, copy/paste
* Terminal -> CD (navigate) to project folder. In this case, the Restaurant folder
* Terminal -> Run the code that you copyied from .NET CLI -> dotnet add package Microsoft.EntityFrameworkCore --version 2.1.1
  * That addes the line: <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.1.1" /> to Restaurant.csproj
  * And it adds files to the obj folder or makes a reference to them
* IF you get some errors, try changing back to prior versions 
  * Terninal -> dotnet --version
  * Terminal -> dotnet restore
  * Terminal -> dotnet build
  * Terminal -> dotnet run
    * If it runs on both secure (5001) and open (5000) protocols, Cmd+click to open either one

## Create CRUD Pages
* Go to www.nuget.org
* Search for Microsoft.VisualStudio.Web.CodeGeneration.Design, click on it
* Select 2.1.1, view the .NET CLI version of the command, copy/paste
* Terminal -> CD (navigate) to project folder. In this case, the Restaurant folder
* Terminal -> Run the code that you copyied from .NET CLI -> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.1.1
  * That addes the line: <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="2.1.1" /> to Restaurant.csproj
  * And it adds files to the obj folder or makes a reference to them
* Add this line to the Restaurant.csproj file AFTER the existing <ItemGroup>
  * <ItemGroup>
    * <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
    * <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.0" />
  * </ItemGroup>
* Terminal -> dotnet restore


