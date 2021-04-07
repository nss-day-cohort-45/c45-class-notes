# ASP<span>.</span>NET Core Web API

## Notes

* API
  * Application Programming Interface
  * Thee mechanism some code uses to communicate with some other code
    * Examples
      * https://www.omdbapi.com/ is a Web API that a client app may call out to in order to get movie information. Code in the client app (maybe a React app, maybe a C# app, maybe a python app, etc...) makes HTTP requests to code running on the Open Movie DB API server.
      * ADO<span>.</span>NET is a API that gives C# code the ability to communicate with a database (which is another program)
* UI
  * User Interface
  * The mechanism a human uses to communicate with some code
* ASP<span>.</span>NET Core Web API
  * The Microsoft framework for building web APIs in .NET
  * Since a Web API application is a kind of _ASP<span>.</span>NET Core_ app there are lots of commonalities between Web APIs and MVC apps
  * Basically it's MVC without the V (view)
  * Still has models and controllers
  * The replacement for the "view" is JSON
    * GET requests return JSON
    * POST and PUT requests accept JSON as input
    * DELETE requests don't (usually) use JSON, they just accept an ID and return a successful HTTP Status code (probably a 200 or a 204)
  * Uses `appsettings.json` and `Startup.cs`
* Web API Controllers
  * use C# attributes to specify which HTTP method they respond to
    * `[HttpGet]`
    * `[HttpPost]`
    * `[HttpPut]`
    * `[HttpDelete]`
  * inherit from `ControllerBase` 
  * marked with the `[ApiController]` attribute
* Models
  * Literally just classes with properties for holding data
  * Represent database tables
  * Can use the same `DataAnnotation` attributes as MVC models
* `var` keyword
  * the feature of C# that allows you to skip specifying the type of a _local_ variable if the type can be inferred from the right-hand side of an assignment.
  * called "type inference"
  * Does NOT mean the variable is dynamically typed.
* "Swagger" is a tool built into Web API that helps you visualize/test your API
* Postman is an external tool that can be used to test APIs too
* CORS is a security feature that prevents a JavaScript client from communicating with a Web API server _unless the server **explicitly** grants it permission_. It's usually ok to turn CORS off for development, but it's usually not ok to turn it off in production.
  * CORS can be disabled in the `Startup.cs` `Configure` method
