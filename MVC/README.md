# ASP<span>.</span>NET Core MVC

ASP<span>.</span>NET Core is Microsoft web application framework. It is the collection of classes and tools that we use to build a web application in C#.

## Vocabulary

* **Request / Response** - This is a pattern of communication between _clients_ and _servers_. A client sends a _request_ and a server responds with a _response_.
* **Rendering** - The process of dynamically generating HTML using a programming language
* **Client-side Rendered App** - a JavaScript heavy web application that generates HTML in the web browser. Apps build with React, Angular or Vue are examples of client-side apps.
* **Server-side Rendered App** - an application that generates it's HTML on the web server. ASP.NET Core/C#, PHP, Django/Python apps are all examples of server-side rendered apps.
  > Always ask yourself "Where does the code run?" Is it the on the client or the server?
* **MVC (Model View Controller)** - This is a _pattern_ for building server-side web applications using _Model_ classes, _Controller_ classes and _View_ templates
  * **Model** - a class that represents a database table
  * **Controller** - a class with methods that respond to HTTP requests. Each method in a controller responds to a particular route. The code in each method will get data from a database or update data in a database using a _Repository_ and then respond with a _View_.
  * **View** - an HTML template that transforms data into HTML
* **ASP<span>.</span>NET Core MVC** - This is the name of the portion of the _ASP<span>.</span>NET Core_ framework that we use to build a web application that uses the MVC pattern
* **Razor Template (`*.cshtml` files)** - Files that contain a combination of HTML and C# code. Used to render HTML. The _view_ part of MVC

## Some parts of an ASP<span>.</span>NET Core App

* **appsettings.json** - a configuration file for the app. In particular this file will contain a database _connection string_.
* **Startup.cs** - another configuration file for the app. This file contains C# code that runs when the app starts to prepare the application to accept HTTP requests.
* **Folder Structure** - These are the directories that Visual Studio creates when it first makes the project.
  * **Controllers** - Should contain _controller_ classes. Controllers should be named with a "-controller" suffix. For example: _HomeController_ or _WalkersController_.
  * **Models** - Should contain _model_ classes
  * **Views** - Should contain razor, `*.cshtml`, files

## Client vs Server Rendered Apps

### Client

![client rendered](./client-rendered.png)

### Server

![server rendered](./server-rendered.png)