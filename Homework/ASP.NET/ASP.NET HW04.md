# ASP.NET Core 3 Homework 04

## Readings
Read chapter 04, in the Pro ASP.NET Core 3 book.

## Homework Questions
1. What are the .NET SDK command line tools used for? Is there use required? Why or why not?
  - No. There are many things that can be done in the GUI for Visual Studio and Visual Studio Code but somethings cannot be done without the command line utilities.
  - Visual Studio and Visual Studio Code don’t support all the features that are required for ASP.NET Core development, so there are times that using the command line is inevitable.
2. What kind of applications do the following templates create? Run these commands and read the documentation. A brief summary of each template is sufficient.
  - `dotnet new console --help` // Description: A project for creating a command-line application that can run on .NET Core on Windows, Linux and macOS
  - `dotnet new mvc --help` //  A project template for creating an ASP.NET Core application with example ASP.NET Core MVC Views and Controllers. This template can also be used for RESTful HTTP services.
  - `dotnet new web --help` // Description: This template creates a project that is set up with the minimum code and content required for ASP.NET Core
development
3. What, specifically, do the following commands do?
  - `dotnet new globaljson --sdk-version 3.1.101 --output MySolution/MyProject`
    + `new globaljson` creates a json file, `--sdk-version` specifies the sdk version to specify inside the json file. `--output` specifies the directory to place the json file.
  - `dotnet new web --no-https --output MySolution/MyProject --framework netcoreapp3.1`
      + `new web` creates an empty .NET Core web project template.
      + `--no-https` turns https off for the project
      + `--framework` specifies the .NET Core framework version to use
4. What is the purpose of the global.json file?
  -  Specifies the version of .NET Core that will be used.
5. What does the method app.UseStaticFiles() do?
  - This statement adds support for responding to HTTP requests with static content in the wwwroot folder
6. What do the following two commands do?
  - `dotnet build`
      + Builds the solution
  - `dotnet run`
      + Runs the program. This starts the integrated ASP.NET Core HTTP server to listen for HTTP requests on port 5000.
7. (not in book) You can manage packages using the NuGet package manager and the command line tool dotnet add package. What are packages and what are they used for. [Microsoft's Documentation for NuGet]https://docs.microsoft.com/en-us/nuget/what-is-nuget
  - NuGet package is a single ZIP file with the .nupkg extension that contains compiled code (DLLs), other files related to that code, and a descriptive manifest that includes information like the package's version number. 
  - In short, a NuGet package is a shareable unit of code, but does not require nor imply any particular means of sharing.
  - They are written by other developers and shared to help others make use of the software.
8. What are tool packages and what are they used for? [Microsoft Documentation for NuGet tool packages]https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools
  - A .NET Core tool is a special NuGet package that contains a console application.
  - One common example is the Entity Framework Core tools package that installs commands that are used to manage databases in ASP.
10. What are client side packages and what are they used for?
  - Client-side packages contain content that is delivered to the client, such as images, CSS stylesheets, JavaScript files, and static HTML.
11. List two ways that a developer can debug code.
  - 1. Toggle a break point, and start debugging. The application with start and run as normal and halt execution when the breakpoint is hit.
  - 2. Insert Console.WriteLines where you want to in your code to print information to the screen to help you debug it.