# Antique Shop

## Live coding to explore C# classes

### The problem

We need to create an application for an Antique Shop. This app will let the antique shop owners predict customer behavior and help them set the price of each item.

The application should contain AntiqueItems and Customers.

AntiqueItems should at least have a name and a price, but might have other properties that the software development team deems appropriate. All properties should be accessible and mutable so adjustments can be made to them.

Customers should have a first name, a last name and a full name, and should have values for a minimum and a maximum amount of money they are willing to spend on an AntiqueItem. None of these items should be modifiable after the Customer object is created, but the name properties should be accessible outside of the object. Customers should also have two lists. One list to contain AntiqueItems they'd like to purchase and another list for items they wish they could purchase, but can't afford. Customers should have the ability to be presented with an item and determine if they would like to purchase it, add it to their wishlist or ignore it. Customers should also have the ability to print a report showing the contents of each of their lists.

The application should create a list of AntiqueItems and a customer, present each item to the customer to let them decide if they want it and print the report for the customer.

#### Enhancement

As an enhancement to the app let the user create multiple customers and run through all AntiqueItems for each customer, printing a report for each customer.

### Notes

* Class
  * blueprint
  * description of what an object will "look like"
    * aka the "shape" of an object
  * classes "live" in our source code (`*.cs`)
* Object
  * the "real" thing that lives in memory
  * objects "live" in the running program

* Class / Object analogies
  * Blueprint / House
  * Cookie Cutter / Cookie
  * Factory / Product produced by the factory

* How do you know what classes to make?
  * bit of an art
  * think about the _boundaries_ of your app
  * think about the _entities_ of your app
  * Look for the _nouns_ in your application requirements

* Property
  * Part of a class that defines some container of state
  * Has...
    * a name
    * a type
    * an access modifier (e.g. public or private)
    * `get` and/or `set`
      * `get` allows the value of the property to be read
      * `set` allows the value of the property to be written to / changed
  * Generally we make properties `public`
  * In 99.99999% of cases a property will have a `get`
  * There are plenty of use-cases for properties without a `set`
    * "read-only" property who's value doesn't change once it's initially set

* Computed Property
  * A `get`-only property that doesn't save any data, but uses other properties to compute a value when it's accessed;

* Constructor
  * a "special method" in a class that executes when the class is instantiated
  * basically it runs when a `new` object is created
  * `get`-only properties can be set inside the constructor
  * How do you spot a constructor?
    * It has the same name as the class
    * It does NOT have a return type
  * Classes don't have to have constructors
    * only have a constructor if you need to do some work when the object is created

* Field
  * yet another way to store state inside a class
  * almost always private
  * Does NOT have either a `get` or a `set`
  * The naming convention is to begin fields with an `_`

* Method
  * A function defined in a class
  * Is some kind of "action" (aka "operation")
  * provided "behavior" for an object
  * Method can be `public` or `private`
    * `public` methods are accessible throughout the entire application
    * `private` methods are only accessible inside the class
