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


