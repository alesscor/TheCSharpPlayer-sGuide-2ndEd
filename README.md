# The C # Player's Guide - Second Edition
**C01 - The C\# Programming Language**

-   The language
    -   The language the computers follow: 0's and 1's and the need of give instructions intelligible by human: source code in text files.
        -   \[human\]-&gt;source code-&gt;\[compiler\]-&gt;machine language
        -   every language has its purpose
            -   low level, high level
    -   C\#
        -   general-purpose programming language (desktop apps, server-side, etc)
        -   it's balanced between:
            -   ease of use (Java is easier)
            -   power (C++ is more powerful)

-   .NET Framework
    -   the language platform
    -   two parts
        -   Common Language Runtime (CLR): a virtual machine, which actually executes the code
            -   \[human\]-&gt;source code-&gt;\[C\# compiler\]-&gt;Common Intermediate Language CIL or IL in .exe or .dll-&gt;\[CLR compiler using JIT\]-&gt;binary machine language-&gt;\[machine\]-&gt;executing tasks
            -   IL Disassambler to open the CIL code \#chapter40
        -   the Base Class and Framework Class Libraries (BCL, FCL)
            -   Massive library of code ready to be used

-   C\# and .NET
    -   first released in 2002 C\#1
    -   .NET 4.6+Visual Studio 2015+C\#6.0

**C02 - Installing Visual Studio**

-   Visual Studio 2015 Community downloaded and installed. Required about (6h+10h) and 8GB of free space.
-   On Lubuntu I installed MonoDevelop (mono+monodevelop packages) and Visual Studio Code (there is an ubuntu apt package, mono required to finish installation).
-   First use of VS
    -   Using my personal MS account
    -   Started VS and skipped the Team Services
    -   To use dark IDE theme for «Visual C\#»

**C03 - Hello World: Your First C\# Program**

- Adding a new C# "Console Application" project to E:\workspaces\CSharpProjects\ch003
- .cs extensions for C# source code!!!
- Main code in Program.cs
- Some terms
	- Project: collection of source code and resource files, and other additional information for the compiler to build the project
	- Assembly: it's the project already compiled (.exe for process assembly or .dll for library assembly)
		Solution: combine multiple projects together to accomplish a task or form a complete program. It has information on how the different projects should be connected to each other.

- Explanation of the source code
	- keyword using: to get libraries which are available to be used (details in #chapter26)
	- {} to group code and its possible name with keywords namespace, class and method's signature
		- relation of membership and hierarchy. Main method is member of class `Program` and `Program` is member of namespace `HelloWorld`.

**C04 - Comments**

* Clarifying communication for yourself and other programmers.
* XML Documentation Comments, introduced in #chapter15, automatically populated by the IDE on typing three slashes before a group of code.
* Best comments:
	* timely entered: just after the code or idea is completed.
	* that adds value: dedicated to explain WHY we did the code instead of something else.
	* that explains at least each section of related code.
	* The code is the best comment, make it readable and understandable.

**C05 - Variables**

* Type, name and value to be used and operated
* Copying variables: it doesn't affect the original variable's value.
* Referring a variable: it happens using arrays. Look at #chapter16
* The "type system"
	* a byte to get 256 different states of 0s and 1s or representation of numbers

* The importance of good variable names. Follow the seven rules.

**C06 - The C# Type System**

* Numeric (signed and unsigned)
	* Integral
		* char, (s)byte, (u)short, (u)int, (u)long
	* Floating point
		* float and double
	* decimal
* bool
* string
* Other types

**C07 - Basic Math**

* Operations and operands and operators
	* binary operators
	* unary operators
	* ternary operator (look at #chapter10, it's `<boolean operand>?<operand if true>:<operand if false>;`)








