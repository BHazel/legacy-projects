**Nom.js** is a set of classes for creating repeating string messages such as _Om Nom Nom!_ and more.  Messages take a generic form of:

{{
[Start String](Start-String)[Repeated String](Repeated-String)[End String](End-String) with [Separator String](Separator-String) between all.
}}
For example, _Om Nom Nom!_ would be:

| Start String | Om |
| Repeated String | Nom |
| End String | ! |
| Separator String | <SPACE> |

## Remarks
You can build your own messages using the built-in **RepeatingMessage** class although a couple are included with their own default settings which can be used as is or customised.  These are outlined in the table below.  More information on class usage can be found in the API reference beneath.

|| Class || Output String || Start (Default/Extended) || Repeated || End || Separator || Separator Allowed ||
| {{Nom}} | _(Om) Nom Nom!_ | <None> / Om | Nom | ! | <SPACE> | Yes |
| {{Lol}} | _(L/TR)OLOLOL!_ | L / TR | OL | ! | <NONE> | No |

## RepeatingMessage Class

Base class for creating repeating messages.

**Properties**
||Property||Type||Description||
|allowSeparation|Boolean|If {{false}} the separation text value is ignored and all text is joined together.|
|endText|String|The text at the end of the message.|
|repeatText|String|The text to repeat in the message.|
|separatorText|String|The string to separate components of the message.|
|startJoined|Boolean|If {{true}} the start text should be joined to the first repeated word.|
|startText|String|The text at the start of the message.|

**Functions**
||Function||Type||Return Type||Description||
|constructor(String, String, String, String)|Instance|MessageBase|Initialises a new instance of the **RepeatingMessage** class with specified text values|
|createMessage(Number)|Instance|String|Creates a repeating message with the specified count for the repeated text|

* **constructor(start, repeat, end, separator): MessageBase**
Initialises a new instance of the **RepeatingMessage** class with specified text values.

||Parameter||Type||Optional||Description||
|start|String|Yes (Default: "")|The text at the start of the message.|
|repeat|String|Yes (Default: "")|The text to repeat in the message.|
|end|String|Yes (Default: "")|The text at the end of the message.|
|separator|String|Yes (Default: "")|The text to separate components of the message.|
Example:
{code:javascript}
// TypeScript
var message: MessageBase = new Farrago.MessageBase("Om", "Nom", "!", " ");

// JavaScript
var message = new Farrago.MessageBase("Om", "Nom", "!", " ");
{code:javascript}

* **createMessage(count): String**
Creates a repeating message with the specified count for the repeating text.

||Parameter||Type||Optional||Description||
|count|Number|No|The number of times to repeat the repeated text component of the message.|
Example:
{code:javascript}
// TypeScript
var repeatedMessage: string = message.createMessage(5);
    /* Generates: "Om Nom Nom Nom Nom Nom!" */

// JavaScript
var repeatedMessage = message.createMessage(5);
    /* Generates: "Om Nom Nom Nom Nom Nom!" */
{code:javascript}

## Nom Class _(Inherits RepeatingMessage)_

Creates _Om Nom Nom!_ messages.

**Inherited Members**

_All properties and methods of RepeatingMessage_

**Functions**

||Function||Type||Return Type||Description||
|constructor(String)|Instance|Nom|Initialises a new instance of the **Nom** class with specified text values.|
|nom(Number, Boolean)|Instance|String|Creates an _Om Nom Nom!_ message with specified count and flag to determine if _Om_ should be included.|
* **constructor(start): String**
Initialises a new instance of the **Nom** class with specified text values.
||Parameter||Type||Optional||Description||
|start|String|Yes (Default: "Om")|The text at the start of the message.|
Example:
{code:javascript}
// TypeScript
var nomObj: Nom = new Farrago.Nom();

// JavaScript
var nomObj = new Farrago.Nom();
{code:javascript}

* **nom(count, om): String**
Creates an _Om Nom Nom!_ message with specified count and flag to determine if _Om_ should be included.

||Parameter||Type||Optional||Description||
|count|Number|No|The number of times to repeat the repeated text component of the message.|
|om|Boolean|No|Flag to determine if _Om_ should be included at the start of the message.|
Example:
{code:javascript}
// TypeScript
var nomMessage: string = nomObj.nom(5, true);
    /* Generates: "Om Nom Nom Nom Nom Nom!" */

// JavaScript
var nomMessage = nomObj.nom(5, true);
    /* Generates: "Om Nom Nom Nom Nom Nom!" */
{code:javascript}

## Lol Class _(Inherits RepeatingMessage)_

Creates _TROLOLOL!_ messages.

**Inherited Members**

_All properties and methods of RepeatingMessage_

**Functions**

||Function||Type||Return Type||Description||
|constructor(String)|Instance|Lol|Initialises a new instance of the **Lol** class with specified text values.|
|lol(Number, Boolean)|Instance|String|Creates a _TROLOLOL!_ message with specified count and flag to determine if _TROL_ should replace _LOL_ at the start of the message.|
* **constructor(start): String**
Initialises a new instance of the **Lol** class with specified text values.
||Parameter||Type||Optional||Description||
|start|String|Yes (Default: "L")|The text at the start of the message.|
Example:
{code:javascript}
// TypeScript
var lolObj: Lol = new Farrago.Lol();

// JavaScript
var lolObj = new Farrago.Lol();
{code:javascript}

* **lol(count, trol): String**
Creates a _TROLOLOL!_ message with specified count and flag to determine if _TROL_ should replace _LOL_ at the start of the message.

||Parameter||Type||Optional||Description||
|count|Number|No|The number of times to repeat the repeated text component of the message.|
|trol|Boolean|No|Flag to determine if _TROL_ should replace _LOL_ at the start of the message.|
Example:
{code:javascript}
// TypeScript
var lolMessage: string = lolObj.lol(5, true);
    /* Generates: "TROLOLOLOLOL!" */

// JavaScript
var lolMessage = lolObj.nom(5, true);
    /* Generates: "TROLOLOLOLOL!" */
{code:javascript}