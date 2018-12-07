## R4MVC5

R4MVC5 is a Roslyn based code generator for ASP.NET MVC 5 apps that creates strongly typed helpers that eliminate the use of literal strings in many places.  

It is a modification of R4MVC (re-implementation of [T4MVC](https://github.com/T4MVC/T4MVC) for ASP.NET Core projects) to support MVC5. (This is to allow regeneration of the helpers outside of Visual Studio.)

## Benefits

Instead of

````c#
@Html.ActionLink("Dinner Details", "Details", "Dinners", new { id = Model.DinnerID }, null)
````
R4MVC lets you write
````c#
@Html.ActionLink("Dinner Details", MVC.Dinners.Details(Model.DinnerID))
````

and that's just the beginning!


## Example
(Assuming you're in a shell while this repo's directory)
```CMD
.\src\R4Mvc.Tools\bin\Debug\net461\R4Mvc.Tools.exe generate -p 'C:\Users\Me\Code\SomeMvc5Project\SomeMvc5Project.csproj'
```
You should see some output like the following:
```CMD

  R4Mvc5 Generator Tool v1.0.0

Using: Visual Studio Professional 2017 - 15.8.28010.2048
Project: C:\Users\Me\Code\SomeMvc5Project\SomeMvc5Project.csproj

Creating Workspace ...
Loading project ...
Compiling project ...
Detected MVC version: 5.2.4.0

Processing controller TestMvc5Application.Controllers.HomeController
Processing controller TestMvc5Application.Controllers.UserController

Generating \HomeController.generated.cs
Generating \UserController.generated.cs
Generating \SharedController.generated.cs
Generating \T4MVC.cs

Operation completed in 00:00:05.0435271
```