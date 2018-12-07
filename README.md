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
