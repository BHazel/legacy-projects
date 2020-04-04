**Secret.js** converts text into secret codes using simple string manipulations.

For example, "Hello, World!" if incremented by 2 would be "Jgnnq, Yqtnf!".

## SecretCodeAlgorithm Interface
Defines methods to encrypt and decrypt input text.

**Functions**

||Function||Type||Return Type||Description||
|encrypt()|Instance|String|Encrypt the input text.|
|decrypt()|Instance|String|Decrypt the input text.|
* **encrypt(): String**
Encrypt the input text.

* **decrypt(): String**
Decrypt the input text.

## IncrementationSecretCode Class _(Implements SecretCodeAlgorithm)_
Encrypts text by incrementing the characters by a set amount.  For example, an increment of 5 would encrypt 'A' to 'F'.

**Properties**

||Property||Type||Description||
|increment|Number|The value to increment the text characters by.|
|inputText|String|The input text to encrypt or decrypt.|

**Functions**

||Function||Type||Return Type||Description||
|constructor(Number, String)|Instance|IncrementationSecretCode|Initialises a new instance of the **IncrementationSecretCode** class with specified increment and input text.|
|encrypt()|Instance|String|Encrypt the input text.|
|decrypt()|Instance|String|Decrypt the input text.|
* **constructor(increment, input): IncrementationSecretCode**
Initialises a new instance of the **IncrementationSecretCode** class with specified increment and input text.

||Parameter||Type||Optional||Description||
|increment|Number|Yes (Default = 0)|The value to increment the text characters by.|
|input|String|Yes (Default = "")|The input text to encrypt or decrypt.|
Example:
{code:javascript}
// TypeScript
var incrementation: Farrago.IncrementationSecretCode = new Farrago.IncrementationSecretCode(5, "Hello, World!");

// JavaScript
var incrementation = new Farrago.IncrementationSecretCode(5, "Hello, World!");
{code:javascript}

* **encrypt(): String**
Encrypt the input text.

Errors: Thrown if increment is greater than 25 or less than -25.

Example:
{code:javascript}
// TypeScript
var encryptedText: String = incrementation.encrypt();
    /* Hello, World! => Mjqqt, Btwqi! */
    /* String = "Mjqqt, Btwqi!" */

// JavaScript
var encryptedText = incrementation.encrypt();
    /* Hello, World! => Mjqqt, Btwqi! */
    /* String = "Mjqqt, Btwqi!" */
{code:javascript}

* **decrypt(): String**
Decrypt the input text.

Errors: Thrown if increment is greater than 25 or less than -25.

Example:
{code:javascript}
// TypeScript
var encryptedText: String = incrementation.decrypt();
    /* Mjqqt, Btwqi! => Hello, World! */
    /* String = "Hello, World!" */

// JavaScript
var encryptedText = incrementation.decrypt();
    /* Mjqqt, Btwqi! => Hello, World! */
    /* String = "Hello, World!" */
{code:javascript}

## InversionSecretCode Class _(Implements SecretCodeAlgorithm)_
Encrypts text by inverting the characters of the alphabet.  For example, 'A' will become 'Z'.

**Properties**

||Property||Type||Description||
|inputText|String|The input text to encrypt or decrypt.|

**Functions**

||Function||Type||Return Type||Description||
|constructor(String)|Instance|InversionSecretCode|Initialises a new instance of the **InversionSecretCode** class with specified input text.|
|encrypt()|Instance|String|Encrypt the input text.|
|decrypt()|Instance|String|Decrypt the input text.|
* **constructor(input): InversionSecretCode**
Initialises a new instance of the **InversionSecretCode** class with specified input text.

||Parameter||Type||Optional||Description||
|input|String|Yes (Default = "")|The input text to encrypt or decrypt.|
Example:
{code:javascript}
// TypeScript
var inversion: Farrago.InversionSecretCode = new Farrago.InversionSecretCode("Hello, World!");

// JavaScript
var inversion = new Farrago.InversionSecretCode("Hello, World!");
{code:javascript}

* **encrypt(): String**
Encrypt the input text.
Example:
{code:javascript}
// TypeScript
var encryptedText: String = inversion.encrypt();
    /* Hello, World! => Svool, Dliow! */
    /* encryptedText = "Svool, Dliow!" */

// JavaScript
var encryptedText = inversion.encrypt();
    /* Hello, World! => Svool, Dliow! */
    /* encryptedText = "Svool, Dliow!" */
{code:javascript}

* **decrypt(): String**
Decrypt the input text.
Example:
{code:javascript}
// TypeScript
var encryptedText: String = inversion.decrypt();
    /* Svool, Dliow! => Hello, World! */
    /* encryptedText = "Hello, World!" */

// JavaScript
var encryptedText = inversion.decrypt();
    /* Svool, Dliow! => Hello, World! */
    /* encryptedText = "Hello, World!" */
{code:javascript}