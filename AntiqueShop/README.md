# Antique Shop

## Live coding to explore C# classes

### The problem

We need to create an application for an Antique Shop. This app will let the antique shop owners predict customer behavior and help them set the price of each item.

The application should contain AntiqueItems and Customers.

AntiqueItems should at least have a name and a price, but might have other properties that the software development team deems appropriate. All properties should be accessible and mutable so adjustments can be made to them.

Customers should have a first name, a last name and a full name, and should have values for a minimum and a maximum amount of money they are willing to spend on an AntiqueItem. None of these items should be modifiable after the Customer object is created, but the name properties should be accessible outside of the object. Customers should also have two lists. One list to contain AntiqueItems they'd like to purchase and another list for items they wish they could purchase, but can't afford. Customers should have the ability to be presented with an item and determine if they would like to purchase it, add it to their wishlist or ignore it. Customers should also have the ability to print a report showing the contents of each of their lists.

### Notes

