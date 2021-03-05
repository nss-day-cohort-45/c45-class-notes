// NOTE: In the program we use the "lighter" top-level statement syntax
//       to make these examples easier to read, and to remind you that for
//       very simple programs, it's a useful approach.

using System;
using System.Collections.Generic;
using System.Linq; // The methods we disccuss here come from the "system.Linq" namespace

// ----------------------------------------------------------------------
//  Linq vs Loops
// ----------------------------------------------------------------------

// The examples below will use this "langs" list.
//  Check out the "GetSomeProgrammingLanguages()" method to see the languages in the list
List<ProgrammingLanguage> langs = GetSomeProgrammingLanguages();

// ----------------------------------------------------------------------
// Select
//  "Select" is like "map" in javascript

Console.WriteLine("-------------------");
Console.WriteLine("Select");
Console.WriteLine("-------------------");

// Loop Way
List<string> creators = new List<string>();
foreach (ProgrammingLanguage lang in langs)
{
    creators.Add(lang.Creator);
}
PrintStrings(creators);

// Linq Way
List<string> linqCreators = langs.Select(lang => lang.Creator).ToList();
PrintStrings(linqCreators);

// ----------------------------------------------------------------------
// Where
// "Where is like "filter" in javascript

Console.WriteLine("-------------------");
Console.WriteLine("Where");
Console.WriteLine("-------------------");

// Loop Way
List<ProgrammingLanguage> compiled = new List<ProgrammingLanguage>();
foreach (ProgrammingLanguage lang in langs)
{
    if (lang.IsCompiled)
    {
        compiled.Add(lang);
    }
}
PrintLanguages(compiled);

// Linq Way
List<ProgrammingLanguage> linqCompiled = langs.Where(lang => lang.IsCompiled).ToList();
PrintLanguages(linqCompiled);

// ----------------------------------------------------------------------
// First
// "First" is like "find" in javascript

Console.WriteLine("-------------------");
Console.WriteLine("First");
Console.WriteLine("-------------------");

// Loop Way
ProgrammingLanguage after1990 = null;
foreach (ProgrammingLanguage lang in langs)
{
    if (lang.YearCreated > 1990)
    {
        after1990 = lang;
        break;
    }
}
PrintLanguage(after1990);

// Linq Way
ProgrammingLanguage linqAfter1990 = langs.First(lang => lang.YearCreated > 1990);
PrintLanguage(linqAfter1990);

// ----------------------------------------------------------------------
// FirstOrDefault
// "FirstOrDefault" is also like "find" in javascript

Console.WriteLine("-------------------");
Console.WriteLine("FirstOrDefault");
Console.WriteLine("-------------------");

// loop Way
ProgrammingLanguage after3000 = null;
foreach (ProgrammingLanguage lang in langs)
{
    if (lang.YearCreated > 3000)
    {
        after3000 = lang;
        break;
    }
}
PrintLanguage(after3000);

// Linq Way
ProgrammingLanguage linqAfter3000 = langs.FirstOrDefault(lang => lang.YearCreated > 3000);
PrintLanguage(linqAfter3000);

// ----------------------------------------------------------------------
// All
// "All" is like the "every" method in Javascript

Console.WriteLine("-------------------");
Console.WriteLine("All");
Console.WriteLine("-------------------");

// Loop Way
bool canAllLangsGetWorkDone = true;
foreach (ProgrammingLanguage lang in langs)
{
    if (!lang.CanGetWorkDone)
    {
        canAllLangsGetWorkDone = false;
        break;
    }
}
Console.WriteLine($"canAllLangsGetWorkDone: {canAllLangsGetWorkDone}");

// Linq Way
bool linqCanAllLangsGetWorkDone = langs.All(lang => lang.CanGetWorkDone);
Console.WriteLine($"linqCanAllLangsGetWorkDone: {linqCanAllLangsGetWorkDone}");

// ----------------------------------------------------------------------
// Any
// "Any" is like "some" in javascript

Console.WriteLine("-------------------");
Console.WriteLine("Any");
Console.WriteLine("-------------------");

// Loop Way
bool areAnyNamedGrace = false; // note we start with assming there aren't any
foreach (ProgrammingLanguage lang in langs)
{
    if (lang.Creator.Contains("Grace"))
    {
        areAnyNamedGrace = true;
        break;
    }
}
Console.WriteLine($"areAnyNamedGrace: {areAnyNamedGrace}");

// Linq Way
bool linqAreAnyNamedGrace = langs.Any(lang => lang.Creator.Contains("Grace"));
Console.WriteLine($"linqAreAnyNamedGrace: {linqAreAnyNamedGrace}");

// ----------------------------------------------------------------------
// Skip
// There's not an equivalent array method in javascript
//   ...though you could probably hack something together with "slice"

// "Skip" will jump past some number of elements in the collection and then return the rest

Console.WriteLine("-------------------");
Console.WriteLine("Skip");
Console.WriteLine("-------------------");

// Loop Way
List<ProgrammingLanguage> allButFirstTwo = new List<ProgrammingLanguage>();
for (int i = 2; i < langs.Count; i++) // note the "i" variable starts at 2
{
    ProgrammingLanguage lang = langs[i];
    allButFirstTwo.Add(lang);
}
PrintLanguages(allButFirstTwo);

// Linq Way
List<ProgrammingLanguage> linqAllButFirstTwo = langs.Skip(2).ToList();
PrintLanguages(linqAllButFirstTwo);

// ----------------------------------------------------------------------
// Take
// There's not an equivalent array method in javascript
//   ...though you could probably hack something together with "slice"

// "Take" will take the first few elements from the collection and ignore the rest

Console.WriteLine("-------------------");
Console.WriteLine("Take");
Console.WriteLine("-------------------");

// Long Way
List<ProgrammingLanguage> firstThree = new List<ProgrammingLanguage>();
for (int i = 0; i < 3; i++) // Note the "i" variable ends at 2 (it moves through 0, 1, 2)
{
    ProgrammingLanguage lang = langs[i];
    firstThree.Add(lang);
}

// Linq Way
List<ProgrammingLanguage> linqFirstThree = langs.Take(3).ToList();
PrintLanguages(linqFirstThree);

// ----------------------------------------------------------------------
// OrderBy
// "OrderBy" is like "sort" in javascript

Console.WriteLine("-------------------");
Console.WriteLine("OrderBy");
Console.WriteLine("-------------------");

// Loop Way
// NOPE

// Linq Way
List<ProgrammingLanguage> linqOrderedByYear = langs.OrderBy(lang => lang.YearCreated).ToList();
PrintLanguages(langs);
PrintLanguages(linqOrderedByYear);

// ----------------------------------------------------------------------
// OrderByDescending
// "OrderByDescending" is easier than doing this with a "sort" in javascript

Console.WriteLine("-------------------");
Console.WriteLine("OrderByDescending");
Console.WriteLine("-------------------");

// Loop Way
// Still NOPE

// Linq Way
List<ProgrammingLanguage> linqOrderedByDescendingYear = langs.OrderByDescending(lang => lang.YearCreated).ToList();
PrintLanguages(linqOrderedByDescendingYear);

// ----------------------------------------------------------------------
//  Chaining Linq Methods
// ----------------------------------------------------------------------

// Works like chaining array methods in javascript

Console.WriteLine("-------------------");
Console.WriteLine("Method Chaining");
Console.WriteLine("-------------------");

// List the names of the compiled programming languages in order of creation

List<string> names = langs
    .Where(lang => lang.IsCompiled)
    .OrderBy(lang => lang.YearCreated)
    .Select(lang => lang.Name)
    .ToList();

PrintStrings(names);

// ----------------------------------------------------------------------
//  Query Syntax
// ----------------------------------------------------------------------

// The above code all uses what's called the "method" syntax. It's generally proferfed, 
//  but you'll also see the "query" syntax from time to time.

Console.WriteLine("-------------------");
Console.WriteLine("Query Syntax");
Console.WriteLine("-------------------");

// List the names of the compiled programming languages in order of creation
IEnumerable<string> queryNames =
    from lang in langs
    where lang.IsCompiled
    orderby lang.YearCreated
    select lang.Name;

// Yep, you still have to call ToList()
List<string> queryNamesAsList = queryNames.ToList();

PrintStrings(queryNamesAsList);

// ----------------------------------------------------------------------
//  Some other Linq methods to explore
// ----------------------------------------------------------------------

// Sum
// Count
// Reverse
// Distinct
// GroupBy
// SkipWhile
// TakeWhile
// Single
// SingleOrDefault
// ...there are others...

// ----------------------------------------------------------------------
//  Helper functions
// ----------------------------------------------------------------------

void PrintStrings(List<string> strings)
{
    foreach (string s in strings)
    {
        Console.WriteLine(s);
    }
}

void PrintLanguages(List<ProgrammingLanguage> languages)
{
    foreach (ProgrammingLanguage lang in languages)
    {
        PrintLanguage(lang);
    }
}

void PrintLanguage(ProgrammingLanguage language)
{
    if (language == null)
    {
        Console.WriteLine("Language is null");
        return;
    }

    string paradigmString = string.Join(", ", language.Paradigms);
    string compiledString = language.IsCompiled ? "Yes" : "No";

    Console.WriteLine($@"
Name: {language.Name}
Created: {language.YearCreated}
Creator: {language.Creator}
Paradigms: {paradigmString}
Compiled? {compiledString}
");
}

List<ProgrammingLanguage> GetSomeProgrammingLanguages()
{
    return new List<ProgrammingLanguage>()
    {
        new ProgrammingLanguage()
            {
                Name = "COBOL",
                    YearCreated = 1959,
                    Creator = "Grace Hopper",
                    Paradigms = new List<string>() { "procedural" },
                    IsCompiled = true,
                    CanGetWorkDone = true,
                    },
                    new ProgrammingLanguage()
                    {
                    Name = "JavaScript",
                    YearCreated = 1995,
                    Creator = "Brendan Eich",
                    Paradigms = new List<string>() { "event-driven", "functional", "object oriented" },
                    IsCompiled = false,
                    CanGetWorkDone = true,
                    },
                    new ProgrammingLanguage()
                    {
                    Name = "C#",
                    YearCreated = 2000,
                    Creator = "Anders Hejlsberg",
                    Paradigms = new List<string>() { "object oriented", "imperative", "functional" },
                    IsCompiled = true,
                    CanGetWorkDone = true,
                    },
                    new ProgrammingLanguage()
                    {
                    Name = "Python",
                    YearCreated = 1991,
                    Creator = "Guido van Rossum",
                    Paradigms = new List<string>() { "procedural", "object oriented", "imperative" },
                    IsCompiled = false,
                    CanGetWorkDone = true,
                    },
                    new ProgrammingLanguage()
                    {
                    Name = "C",
                    YearCreated = 1972,
                    Creator = "Dennis Ritchie",
                    Paradigms = new List<string>() { "imperative" },
                    IsCompiled = true,
                    CanGetWorkDone = true,
                    }
    };
}

// ----------------------------------------------------------------------
//  The Programming Langauge class used throughout this example
// ----------------------------------------------------------------------

class ProgrammingLanguage
{
    public string Name { get; set; }
    public int YearCreated { get; set; }
    public string Creator { get; set; }
    public List<string> Paradigms { get; set; }
    public bool IsCompiled { get; set; }
    public bool CanGetWorkDone { get; set; }
}