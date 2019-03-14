## R4Mvc5

R4Mvc5 is a Roslyn based code generator for ASP.NET MVC 5 apps that creates strongly typed helpers that eliminate the use of literal strings in many places.  

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

#### Benefits of R4Mvc5 over T4MVC
While T4MVC is probably more stable and better maintained, it is implemented in T4 templates that rely on the DTE interface, meaning it can't work outside of VisualStudio, which means you can't use T4MVC.tt with Release Manager and have to track all the `.generated.cs` files. R4Mvc5 _can_ work with Release Manager!

As far as getting this to work with Release Manager for TFS, VSTS, Azure DevOps, or whatever Microsoft has decided to call it, the strategy we're using is to track the EXE and all dependencies in the repo, and have prebuild events for all MVC projects that invokes the EXE. (This gives us the flexibility to patch R4Mvc5 as needed.)

## Example
(Assuming you're in a shell while in this repo's directory)
```CMD
.\src\R4Mvc.Tools\bin\Debug\net461\R4Mvc5.exe generate -p 'C:\Users\Me\Code\SomeMvc5Project\SomeMvc5Project.csproj'
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

Processing controller SomeMvc5Project.Controllers.HomeController
Processing controller SomeMvc5Project.Controllers.UserController

Generating \HomeController.generated.cs
Generating \UserController.generated.cs
Generating \SharedController.generated.cs
Generating \T4MVC.cs

Operation completed in 00:00:05.0435271
```

## Migrating From T4MVC

Here are some loose instructions for how to replace T4MVC for a project called 'MyLameProject':
* Delete all T4MVC _files_ in `MyLameProject` (including template (`.tt`) and settings). (Leave the T4MVCExtensions dependency!)
* Clone this repo wherever you like.
* Build the `R4Mvc.Tools` project. <!-- NOTE TO SELF: Rename project. -->
* Add the project's `src\R4Mvc.Tools\bin\Debug\net461\` (or `src\R4Mvc.Tools\bin\Release\net461\`) to your PATH.
  * Alternatively, add the EXE and dependencies to your solution.
* Open a new shell. Test the following command:
    ```
    R4Mvc5.exe generate -p 'C:\Users\Me\Code\MyLameProject\MyLameProject.csproj'
    ```
  * If it worked, great. Now we'll setup the project to generate code on build.
* In Visual Studio, right click on the `MyLameProject` project file.
* Select `Properties`.
* In the `Build Events` tab, add the following to the "Pre-build event command line" text area:
    ```
    R4Mvc5.exe generate -p "..\MyLameProject.csproj"
    ```
     * A slightly more sophisticated pre-build event (assuming you have the EXE in-tree with the path "Utils/R4Mvc5/" (all the dependencies you need should be in the same directory as the EXE)):
     ```
      if EXIST "$(SolutionDir)\Utils\R4Mvc5\R4Mvc5.exe" ("$(SolutionDir)\Utils\R4Mvc5\R4Mvc5.exe" generate -p "$(ProjectPath)" ) else (exit 2)
     ```
* Save the project.
* **NOTE:** R4Mvc5 doesn't manipulate the project file (or at least, not yet?). If you ran that test command, then you should show all files and add `r4mcv.json` and `T4MVC.generated.cs` to your project file. If you didn't run the command earlier, build the project, watch it fail (it'll generate the files, though), turn show all files off and on again, and add to the solution.
  * **NOTE:** Both `r4mcv.json` and `T4MVC.generated.cs` will probably be renamed soon (as they should be).
* After adding all the generated files to the project, build the project and hope it works.
