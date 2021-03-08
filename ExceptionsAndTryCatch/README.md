# Exceptions and Try / Catch

## Notes

* Exceptions
  * errors that happen at "run time"
    * that means they occur when the program is run
  * Distinct from "compiler errors"
    * compiler errors prevent the program from ever running
  * Very useful during development time to help you harden / strength your code
  * An exception is an object - just like any other C# object - that has useful properties
    * Message
    * Stacktrace

* try / catch
  * used to handle exceptions so the program doesn't abruptly end with an error
  * NOT A BAND-AID to just sprinkle everywhere
  * You have to know how to handle an exception for there to be any value in catching it
  * It's often best to "look before your leap"
  * Where would you use a try / catch?
    * When your code is connecting to an external data source
      * External Web API
      * Connecting to a Database
  * It's common to log errors in a catch block

* The biggest take-away from all this is _**LEARN TO READ THE EXCEPTION MESSAGE**_