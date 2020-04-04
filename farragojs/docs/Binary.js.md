**Binary.js** offers functions to interconvert between decimal and binary (string representation) numbers.

Taking an example decimal number of 73, it can be converted into the string 1001001, the binary representation of the number.  This can then be converted back to 73.

## BinaryConverter Class

**Functions**

||Function||Type||Return Type||Description||
|fromBinary(String)|Static|Number|Convert a binary number to decimal.|
|getBits(String)|Static|Boolean[]()|Convert the binary representation of a number into a bit array.|
|toBinary(Number)|Static|String|Convert a decimal number to its binary representation.|
* **fromBinary(binaryNumber): Number _(Static)_**
Convert a binary number to decimal.

||Parameter||Type||Optional||Description||
|binaryNumber|String|No|The binary number representation.|
Example:
{code:javascript}
// TypeScript
var decimalNumber: Number = Farrago.BinaryConverter.fromBinary("1001001");
    /* decimalNumber: 73 */

// JavaScript
var decimalNumber = Farrago.BinaryConverter.fromBinary("1001001");
    /* decimalNumber: 73 */
{code:javascript}


* **getBits(binaryNumber): Boolean[]() _(Static)_**
Convert the binary representation of a number into a bit array.

||Parameter||Type||Optional||Description||
|binaryNumber|String|No|The binary number representation.|
Example:
{code:javascript}
// TypeScript
var bitArray: Boolean[]() = Farrago.GetBits("1001001");
    /* bitArray: [true, false, false, true, false, false, true](true,-false,-false,-true,-false,-false,-true) */

// JavaScript
var bitArray = Farrago.GetBits("1001001");
    /* bitArray: [true, false, false, true, false, false, true](true,-false,-false,-true,-false,-false,-true) */
{code:javascript}


* **toBinary(decimalNumber): String _(Static)_**
Convert a decimal number to its binary representation.

||Parameter||Type||Optional||Description||
|decimalNumber|String|No|The decimal number.|
Example:
{code:javascript}
// TypeScript
var binaryNumber: String = Farrago.ToBinary(73);
    /* binaryNumber: "1001001" */

// JavaScript
var binaryNumber = Farrago.ToBinary(73);
    /* binaryNumber: "1001001" */
{code:javascript}