#define BOOL_OBJC

#include <stdio.h>
#include <bool.h>

int main(int argc, char* argv[])
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
    Bool values: true, false
    Integer values: 1, 0
*/
