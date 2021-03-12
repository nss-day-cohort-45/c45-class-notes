# Abstraction, Modeling and Inheritance, Oh My!

## Notes

* Abstraction
  * a concept
  * a thought
  * what's left over when you remove all the uninteresting properties of a thing

* Example - A Car
  * make
  * model
  * color
  * number of wheels
  * type of engine
  * manual or automatic transmission
  * X - wheel drive

* In the example above we might think about a car as a "model"

* Model represents something in the real world
* A model is an abstraction
* Models are often used to predict the future or, at least, try to understand the present (or understand something)
* Example - a weather model
  * a computer program that "models" the actual weather on a planet
  * made up of classes, methods, properties, etc...

* "All models are wrong, some are useful" - George Box

* Classes are models
  * We've created classes for Persons, Dogs, Shiny Hats, etc...
  * We have NOT created Person, Dogs or Shiny Hats

* Inheritance
  * A way to share code between classes - Don't Repeat Yourself (DRY)
  * It's a way to define an `is-a` relationship
    * ex: a `Student` is a `Person`
  * A child class inherits from a parent class
    * child class is also known as a "sub class" or a "derived class"
    * parent class is also known as a "super class" or a "base class"
  * The model of inheritance in programming is one of a child inheriting genetic traits from their parent