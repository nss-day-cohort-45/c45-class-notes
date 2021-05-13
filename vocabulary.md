# Vocabulary

## value

* Examples
  * 42
  * "mr hotdog man"
  * true
  * false
  * 3.14159
  * { 'name': 'Joe', 'age': '???" }
* Is the real "thing" we're working with
* A value is an object stored in memory in our application

## variable

* the name associated with a value
* variable refers to a value
* variables are assigned values

```cs
// variable = value
int num = 42;
string name = "Robbie";
DateTime dt = DateTime.Now;
```

```js
const dog = {
  'name': 'Sally',
  'age': 12
};

const dog2 = dog;

let num = 42;
num = "this is not a number";
```

## type

* Examples
  * string
  * bool
  * int
  * double
  * DateTime
* a type is a constraint on a value or a variable
  * a `bool` value can ONLY BE `true` or `false`
  * an `int` value can ONLY BE a number without a fractional component
  * a `string` value can be any text
    * "hello, world!"
    * "we praise mr. hotdog man"
    * "42"
    * "int num = 42;"
  * In C# BOTH values and variables have types

## March 16

* SQL - Structured Query Language
  * `SELECT` - keyword we use in sql to query a table or group of tables
  * `INSERT` - add data to a table
  * `UPDATE` - change existing data in a table
  * `DELETE` - remove a record from a table
  * Data Definition Language (DDL)
    * `CREATE TABLE` - make a new table by defining the column names and types
    * `CREATE DATABASE` - make a new database
  * Database - collection of related tables
  * Table - grid / rectangle of data
    * rows and columns
* Variable - A named box to store a value. A name that refers to a value
* Value - data stored in memory. the real thing we're working with when we use variables
  * Our code manipulates values
  * Examples:
    ```cs
    42 // is an int value
    "Hello" // is a string value

    // a Person Object is a value
    new Person() {
      FirstName = "Ron",
      LastName = "Swnson"
    }

    new List<string>()
    new List<Person>()
    ```
* Type
  * a constraint on the possible values that a variable or object can have
  * restricts the values
  * In C# we define a type
    * by giving it a name (e.g. `class` or `interface`)
    * by specifying the properties, fields and methods that it has
  * Examples:
    * a `bool` can ONLY contain `true` or `false` values
    * an `int` can only contain postie and negative numbers without decimal points
    * a `Person` can only contain values for `FirstName` and `LastName`
    * a `List<string>` can only contain an indexed collection os `string` values
* Object
  * is a value in memory in the running program
  * has a type
  * It "lives" in the running program
* Class
  * defines the blueprint an object
    * defines the properties and methods that an object will have
  * it IS the type
  * It "lives" in the source code
* Method
  * defines a piece behavior of an object
  * function that lives on an object and is defined in a class
    * the object is the "context" for the method (aka. "receiver")
  * Often `public`, but can be `private` when only used internally
  ```cs
  listOfStrings.Add("Hello!"); // calling the `Add()` method on a `List<string>`
  ```
* Property
  * is a named part of an object that can store a value
  * lives on an object, but defined in a class
  * stores "state" of an object
  * has a `get;` and probably has a `set;`
  * Often `public`
  ```cs
    public int Number { get; set; }
  ```
* Field
  * another way to store state in an object
  * often `private`
  * often starts with an `_`
  * does NOT have a `get` or a `set`
* Access Modifiers
  * keywords we put on methods, properties and fields to control how code outside the class can use those methods, properties or fields
  * `public` - denotes that a method, property or field can be accessed outside of a class
  * `private`
    * denotes that a method, property or fields can NOT be accessed outside of a class
    * Even child classes cannot see `private` things
    * used to implement "encapsulation"
  * `protected`
    * denotes that a method, property or fields can ONLY BE ACCESSED BY **CHILD** CLASSES
    * used in inheritance
* Interface
  * defines the public properties and methods a class must implement
  * defines the "shape" of a class
  * an interface is a type
    * a variable can be of an interface type
  * almost always starts with the letter "I"
  * Example:
    * `IEnumerable<>` - an interface that's implemented by different collections in c#
      * List<>
      * Dictionary<>
      * Arrays
* Object Relationships
  * Is-a
    * an inheritance or interface relationship
    * am object of a child class is also considered to be an object of the parent class
    * `List<string>` is-a `IEnumerable<string>`
    * `Student` is-a `Person`
  * Has-a
    * represents some kind of "composition"
    * A class "has-a" property
    * A `Person` has-a `FirstName`
* `static`
  * keyword we use on a method or property to specify that it is part of the class and not an object
  * When a method is static, you can call it using the class name
  * a way to write "functions" in C#
  * Example:
  ```cs
  string.IsNullOrWhitespace(someStringVariable);
  ```
* Overloading
  * having methods with the same name on a class
  * methods are determined by their parameters
* Overriding
  * when a child class re-implements a methods from a parent class

## April 15

* Software development
  * Is problem solving, often with a computer, often by writing software, but not always.
* Key / Value Pairs
  * a fundamental pattern in software
  * values are data, "real" things, numbers, text, objects, arrays
  * keys are names for those values
  * Examples
    * variables in our programming languages
    * props in react
    * query string parameters
    * dictionaries in C# / object in javascript
* Classes vs Objects
  * Class is one way of defining a "type"
    * Interface is another way to define a type
  * A "type" is set of constraints on an object
    * the "boolean" type specifies that only "true" and "false" are valid values
    * the "int" type specifies that the value must be a positive or negative whole number
    * In C# a "type" defines the properties and methods that an object must have
  * objects are instances of classes
  * classes and interfaces "live" in our source code
  * objects "live" in the running program
    * physically take up space in a computer's memory
* .NET
  * Programming languages
    * C#
    * Visual Basic .NET (VB.NET)
    * F#
    * .NET provides _compilers_ for these languages
      * a compiler turns source code in to something that can be executed
      * In .net the compiler generates "Intermediate language" (IL), this a type of "byte code"
      * the term "build" is often used to refer compiling
  * A runtime that executes IL code
    * Common Language Runtime (CLR)
  * A set of libraries / classes that provide common, useful functionality
    * Base Class Library (BCL)
    * List<>, Dictionary<>, string, int
* ASP.NET Core
  * Is the set of classes that we use to build web applications
  * It is a web application framework
  * Examples
    * Controller, ControllerBase
    * IConfiguration
    * Startup
    * Views
* Framework vs Library
  * both refer to code other people wrote that we can use for our programs
  * A Library is code the your code calls
    * Example
      * ADO.NET
        * our code creates SqlConnection, etc... and uses them
  * A Framework is code that calls your code
    * Example
      * ASP.NET Core
        * we write Controllers, but ASP.NET invokes those controllers
* Web API
  * REST
  * An API that is access with HTTP verbs
  * Often uses JSON, but might e XML
* JWT
  * JSON Web Token
  * Used to identify a user of a Web API
* Databases
  * DBMS
    * Database Management System
  * Relational
    * SQL
    * Tables
    * Relationships
      * Primary and Foriegn Keys
  * NoSQL
    * A general term for databases that aren't relational
    * Some types of NoSQL Databases
      * Document
      * Key / Value
      * Columnar
      * Graph
