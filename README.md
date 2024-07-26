[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/e4twP-lB)
# Task 01: The Console

<img alt="points bar" align="right" height="36" src="../../blob/badges/.github/badges/points-bar.svg" />

![GitHub Classroom Workflow](../../workflows/GitHub%20Classroom%20Workflow/badge.svg)

***

## Student info

> Write your name, your estimation of how many points you will get, and an estimate of how long it took to make the answer

- Student name: 
- Estimated points: 
- Estimated time (hours): 

***

## Purpose of this task

The purposes of this task are:

- to learn console app
- to learn to use a class in a console app

## Material for the task

> **Following material will help with the task.**

It is recommended that you will check the material before start coding.

1. [Top-level statements - programs without Main methods](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements)
2. [Declare namespaces to organize types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces)
3. [Introduction to classes](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes)
4. [Integral numeric types (C# reference)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

## The Task

Create a console app that can handle arguments, convert argument value to int, instantiate a class and then call a method from that class instance. Create a class that has a method which takes parameters and returns a value. Write information to console.

### Evaluation points

1. Write ```Hello, World of .NET 6!``` to console (without the quotes)
2. Create a calculator class with public method `int? CalculateArea(int, int)`. Use proper C# filename and casing for the class name. Use `ConsoleApp` as the class' namespace. CalculateArea will calculate the the area defined by the parameters. The parameters presents width and height of an area. Area is zero (0) if either of the parameters is zero(0). Negative values in parameters results in null value.
3. The method must return `null` if a parameter is negative, must not error in any case (will return null instead of exception). Must not overflow (returns null instead). Think about the required calculation and the value range of the specified variable type.
4. The app must handle arguments passed to the app. Convert arguments to type `int` and pass to CalculateArea method. Must not error. Use int default value if no argument is given. If arguments are given to the app, write them to console with text `Arguments: x y` where x and y are replaced with argument values. Write this to a new line. Note! if one argument is missing then it won't be printed. If both are missing then nothing is printed on this line.
5. The app must write to console: `Area of x and y is z` where x, y and z are replaced with actual values. Write to new line.

> **Note!** Read the task description and the evaluation points to get the task's specification (what is required to make the app complete).

> **Note!** DO NOT use `Console.ReadLine()`, `Console.ReadKey()` or any other code that expects the user to enter input.

> **Note!** To test the app with arguments you can use dotnet CLI command: `dotnet run -- arg1 arg2`. Arguments are provided after the --

> Sample: running with command `dotnet run -- 1 2` would produce output
>
> ```
> Hello, World of .NET 6!
> Arguments: 1 2
> Area of 1 and 2 is 2
> ```

## Task evaluation

Evaluation points for the task are described above. An evaluation point either works or does not work there is no "it kind of works" step in between. Be sure to test your work. All working evaluation points are added to the task total and will count toward the course total. The task is worth five (5) points. Each evaluation point is checked individually and each will provide one (1) point so there are five checkpoints. Checkpoints are designed so that they may require additional code, that is not checked or tested, to function correctly.

## DevOps

There is a DevOps pipeline added to this task. The pipeline will build the solution and run automated tests on it. The pipeline triggers when a commit is pushed to GitHub on the main branch. So remember to `git commit` and `git push` when you are ready with the task. The automation uses GitHub Actions and some task runners. The automation is in the folder named .github.

> **DO NOT modify the contents of .github or tests folders.**
