When using booleans in your C files, add _bool.h_:

{code:c++}
#include <bool.h>    // or, if not in a global search path...
#include "bool.h"
{code:c++}
The default boolean syntax style is similar to that in C++, but can be set to another computer language via the use of a _#define_ statement. Available statements are outlined in the table below:

|| #define Statement || Programming Language || Boolean Keyword || True/False Keywords || True/False String Representations ||
| _none required_ | C/C++/C# | bool | true/false | true/false |
| #define BOOL_FORTRAN | Fortran | LOGICAL | TRUE/FALSE | T/F |
| #define BOOL_JAVA | Java | boolean | true/false | true/false |
| #define BOOL_OBJC | Objective-C | BOOL | YES/NO | YES/NO |
| #define BOOL_VB | Visual Basic(.NET) | Boolean | True/False | True/False |

A couple of preprocessor macros are available to manipulate booleans as outlined in the table below:

|| Macro || Description ||
| BLINT(boolean) | Returns the integer value of _boolean_ where True = 1 and False = 0 |
| BLSTR(boolean) | Returns the string representation of _boolean_ |

In Bool.h, booleans are simply a type definition (_typedef_) of an unsigned integer, therefore alternatives to _BLINT(boolean)_ are available (see example below).

A simple example using the default setting is outlined below with the expected output:

{code:c++}
#include <stdio.h>
#include <bool.h>

int main(int argc, char* argv[]())
{
    // Declare and initialise boolean variables
    bool b1 = true;
    bool b2 = false;

    // Print the boolean variables as strings to standard output
    printf("Bool values: %s, %s\n", BLSTR(b1), BLSTR(b2));

    // Print integer representation of boolean variables to standard output
    printf("Integer values: %d, %d\n", b1, b2);

    // Declare and initialise integer variables with the boolean values:
    // ...using BLINT(boolean)
    int i1 = BLINT(b1);
    // ...using simple assignment
    int i2 = b2;
    return 0;
}

/*
    Expected Output:
    Bool values: true, false
    Integer values: 1, 0
*/
{code:c++}
To use another programming language keywords, such as Objective-C, simply add the necessary _#define_ statement to the top of the C file above the _#include_ directives. **Note that only one language keywords setting can be used per file.**

The above example using Objective-C keywords is outlined below with expected output:

{code:c++}
#define BOOL_OBJC

#include <stdio.h>
#include <bool.h>

int main(int argc, char* argv[]())
{
    // Declare and initialise boolean variables
    BOOL b1 = YES;
    BOOL b2 = NO;

    // Print the boolean variables as strings to standard output
    printf("Bool values: %s, %s\n", BLSTR(b1), BLSTR(b2));

    // Print integer representation of boolean variables to standard output
    printf("Integer values: %d, %d\n", b1, b2);

    // Declare and initialise integer variables with the boolean values:
    // ...using BLINT(boolean)
    int i1 = BLINT(b1);
    // ...using simple assignment
    int i2 = b2;
    return 0;
}

/*
    Expected Output:
    Bool values: YES, NO
    Integer values: 1, 0
*/
{code:c++}