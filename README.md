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

**C08 - User Input**

* Need of get data from user.
* Need of convert from text input to numeric.
* Need to scape characters.

**C09 - More Math**

* Typecasting or casting
	* Implicit casting
		* narrower type to a wider type
	* Explicit casting

* Division by zero
	* Exception on using integral types
	* Infinity on using floating point types

* Other values: NaN for floating points, depending on the operation
* Overflow and underflow after operations and using explicit casting with data loss

**C10 - Decision Making**

* Interesting introduction to conditionals
* Interesting learnable example, using always " because ' is only for characters: 
 ```csharp
Console.WriteLine($"The result is {theResult:0.0000}, and the sign is {((theSign == 0) ? "positive" : "negative" )}." );
 ```
**C11 - Switch Statements**

* No surprises: bool, string and integral types, with the exception on that break is strictly required, which is different from C++ and Java.

**C12 - Looping**

Interesting challenge:

```csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAPyramid {
    class Program {
        static void Main( string[] args) {
            // 1,3,5,7,9
            //int limit = 0;
            for ( int row=0; row < 5; row++) {
                for ( int column=0; column <= 3-row; column++) {
                    Console.Write( " ");
                }
                // row:=2*row+1
                //switch (row) {
                //    case 0:
                //        limit = 1;
                //        break;
                //    case 1:
                //        limit = 3;
                //        break;
                //    case 2:
                //        limit = 5;
                //        break;
                //    case 3:
                //        limit = 7;
                //        break;
                //    case 4:
                //        limit = 9;
                //        break;
                //}
                for ( int column=0; column<2*row+1; column++) {
                    Console.Write( "*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

```

**C13 - Arrays**

* Declare arrays vs create arrays
* Ability to create multi-dimensional arrays like int[,] grid= new int [5,4];
* Ability to iterate arrays with foreach keyword, which is better to be used with implementations of IEnumerable interface.
* Usage of new is required. No delete keyword.

```csharp
// interesting declaration of multiple dimensions
int[,] grid= new int[5,4];
for( int i = 0; i < 5; i++) {
    for( int j = 0; j < 4; j++) {
        grid[i, j] = i * j;
    }
}
// access to the multi-dimensional array
for( int row = 0; row < grid.GetLength(0); row++) {
    for( int column = 0; column < grid.GetLength(1); column++) {
        Console.WriteLine( $"grid[{row}, {column}]: {grid[row,column]}");
    }
}
```

Output:

```
grid[0,0]: 0
grid[0,1]: 0
grid[0,2]: 0
grid[0,3]: 0
grid[1,0]: 0
grid[1,1]: 1
grid[1,2]: 2
grid[1,3]: 3
grid[2,0]: 0
grid[2,1]: 2
grid[2,2]: 4
grid[2,3]: 6
grid[3,0]: 0
grid[3,1]: 3
grid[3,2]: 6
grid[3,3]: 9
grid[4,0]: 0
grid[4,1]: 4
grid[4,2]: 8
grid[4,3]: 12

```

**C14 - Enumerations**

* Brief introduction to "dot operator"
* No surprises but the interpolation interpretation of an enum value is its label.

```csharp
    public enum Months {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        November,
        December
    };
```
**C15 - Methods**

* No surprises, but the mention of the ability to have up 65,500 parameters in a method.
* The /// comments are immediately displayed by IntelliSense.
* There it comes an explanation of recursion on pages 100-101 <3.

**C16 - Value and Reference Types**

* Program's memory
	* Stack
		* Pointer to the current state of execution.
		* For method's frames, containing local variables including parameters in a single method invocation's frame.

	* Heap
		* Dedicated to storing data.


* In a multi-threaded application, each thread has its own stack but share the heap with the others (#chapter37).
* Garbage collector
	* In charge of managing the heap automatically
		* This is an environment with managed heap. Managed by the CLR.
		* This is the reason C# doesn't provide pointers but references. The references are included in the CLR's heap management.


* Value Types and Reference Types
	* The key difference between them: «when you have a variable that is a value type, the actual contents of that variable live where the variable lives. With a reference type, the contents of the variable live on the heap, and the variable itself contains only a reference to the actual content.»
	* The reference type allow nulls.

* The semantic of the type
	* Value type semantic
		* Data of the value inside of a variable
		* On copy: the value (data) is copied

	* Reference type semantic
		* Reference to a location in the heap where the data are stored
		* On copy: the reference is copied

Interesting on string class, it seems it's thread-safe, every "modification" makes a new instance, i.e., another referenced object.
```csharp 
static void Main( string[] args) {
    string aString = "one value";
    Console.WriteLine( $"the value is: {aString}" );
    SecondMethod(aString);
    Console.WriteLine( $"the value is: {aString}" );
    Console.ReadKey();
}
static void SecondMethod( string arg) {
    arg=arg.Insert(arg.Length, "_tail"); // this makes arg to point another string in the heap
    Console.WriteLine( $"the value is: {arg}" );
}
```

**C17 - Classes and Objects**

* A way to structure code mimicking the way the real world works. It breaks it down into manageable pieces and presents it in an intuitive way for programmers to work with.
* Terminology
	* Classes. they all are reference types.
	* Objects or instances of a class


**C26 - Namespace and using directives: #chapter26**

* For the sake of code reuse
	* namespace: identifies a set of related source code's names. A package of related code.
	* using: brings a namespace to be used in the source code


**C37 - Threads**

* In a multi-threaded application, each thread has its own stack but share the heap with the others (referred by #chapter16).

**C40 - C# and the .NET Framework: #chapter40**

* On binary, assembly, high-level languages and compiling
* On virtual machines and the CLR
* Advantages of CLR
	* Memory management
	* Security
	* Multiple high level languages
* Drawbacks of virtual machines
	* Performance
	* Bad for low-level coding
	* Visible source code, code-obfuscation techniques needed
* The .NET Framework: BCL and FCL Class Libraries
	* Very large collection of previously built code and types. It's more massive than C++ and many other languages in terms of the standard library they come with.
	* Its size is similar to Java's. BCL uses the System namespace.
	* The FCL includes the BCL and other libraries related to broad functional areas like database access, GUI, etc.
	* If you need to program a task you suspect somebody could build it before, it could be included in the FCL, so it's better you search for it before.


[finish]



