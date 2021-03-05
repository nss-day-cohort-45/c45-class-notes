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

// Long Way



// Linq Way



// ----------------------------------------------------------------------
// Where

// Long Way



// Linq Way



// ----------------------------------------------------------------------
// First

// Long Way



// Linq Way



// ----------------------------------------------------------------------
// FirstOrDefault

// Long Way



// Linq Way



// ----------------------------------------------------------------------
// All

// Long Way




// Linq Way




// ----------------------------------------------------------------------
// Any

// Long Way


// Linq Way



// ----------------------------------------------------------------------
// Skip

// Long Way



// Linq Way



// ----------------------------------------------------------------------
// Take

// Long Way


// Linq Way



// ----------------------------------------------------------------------
// OrderBy

// Long Way



// Linq Way



// ----------------------------------------------------------------------
// OrderByDescending

// Long Way



// Linq Way






// ----------------------------------------------------------------------
//  Chaining Linq Methods
// ----------------------------------------------------------------------

// List the names of the compiled programming languages in order of creation



// ----------------------------------------------------------------------
//  Query Syntax
// ----------------------------------------------------------------------




// ----------------------------------------------------------------------
//  Some other Linq methods to explore
// ----------------------------------------------------------------------

// Sum
// Count
// Reverse
// Distinct
// GroupBy



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
    return new List<ProgrammingLanguage>() {
        new ProgrammingLanguage() {
            Name = "COBOL",
            YearCreated = 1959,
            Creator = "Grace Hopper",
            Paradigms = new List<string>() { "procedural" },
            IsCompiled = true,
            CanGetWorkDone = true,
        },
        new ProgrammingLanguage() {
            Name = "JavaScript",
            YearCreated = 1995,
            Creator = "	Brendan Eich",
            Paradigms = new List<string>() { "event-driven", "functional", "object oriented" },
            IsCompiled = false,
            CanGetWorkDone = true,
        },
        new ProgrammingLanguage() {
            Name = "C#",
            YearCreated = 2000,
            Creator = "Anders Hejlsberg",
            Paradigms = new List<string>() { "object oriented", "imperative", "functional" },
            IsCompiled = true,
            CanGetWorkDone = true,
        },
        new ProgrammingLanguage() {
            Name = "Python",
            YearCreated = 1991,
            Creator = "Guido van Rossum",
            Paradigms = new List<string>() { "procedural", "object oriented", "imperative" },
            IsCompiled = false,
            CanGetWorkDone = true,
        },
        new ProgrammingLanguage() {
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