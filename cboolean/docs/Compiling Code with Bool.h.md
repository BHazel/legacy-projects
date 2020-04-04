If the following _#include_ directive is used, ensure _bool.h_ is in the same directory as the code being compiled:

{{
#include "bool.h"
}}
Otherwise, if the following is used:

{{
#include <bool.h>
}}
ensure _bool.h_ is located in the global Includes directory, or the directory it is located is passed to the compiler, e.g. for GCC:

{{
gcc code.c -I directory -o code
}}