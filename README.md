OOTI2020 - Voting Kiosk
=======================

Please add your username to the right column in this google sheet:
https://docs.google.com/spreadsheets/d/1aKw_9hFdiramOvbdWDd9PCemSHPSffnn9OzdXB9tU6o/edit?usp=sharing

This is a little starter project for the OOTI 2020 Continuous Integration class.

We're going to do a simple console application, so we don't waste time building fancy UIs. C# is a pretty powerful language, and I hope that most of you are either already familiar with, or at least know similar languages such as Java, C++ or JavaScript.

Goals for the assignment:
* Make a console based decision making tool. A tool that can help a group of people come to an agreement on important matters, such as what's the best pizza or are dogs better than cats or not.
* It's a simple tool, it does not need to store data. Assume all users just use the same computer after one another.

User roles:
* Administrator: this person can define a questionnaire.
* Voter: one or more people who can *do* the questionnaire.

Typical flow:
* The Administrator configures the questionnaire using a text-based definition language and saves it to a file using e.g. Notepad.
* The Administrator starts the questionnaire and asks the first Voter to sit behind the screen and answer the questions.
* The first Voter asks the second Voter, and so on
* When the last Voter is done, the tool and somehow display conclusive results (eg "cats *are* better than dogs").

Requirements
------------
* .NET 5.0: https://dotnet.microsoft.com/download
* Visual Studio Code: https://code.visualstudio.com/Download
* Install these extensions:
    * C#
    * Live Share

Additionally, you'll need Git if you don't have it yet:

https://git-scm.com/download/

Getting started
---------------

The repository contains a silly example program. Open a terminal in the repository root and run:

```
> dotnet run -p Kiosk
```

This should download all dependencies, compile the Kiosk program, and then ask you an important question about pizza.

To run the automated tests, run:

```
> dotnet test
```

This will run all the tests found in the Kiosk.Test project. You should see one test passing and one test failing.