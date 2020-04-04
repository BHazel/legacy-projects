**RecMaths.js** offers functions to perform recreational mathematical operations.

## RecreationalMaths Class

**Functions**

||Function||Type||Return Type||Description||
|isHappy(Number)|Static|Boolean|Determines if a number is happy.|
|pizzaVolume(Number, Number)|Static|Number|Calculates the volume of a pizza according to the Pizza Theorem.|
|sumDigitSquares(Number)|Number|Static|Calculates the sum of the squares of the digits of a number.|
* **isHappy(num): Number _(Static)_**
Determines if a number is happy.

||Parameter||Type||Optional||Description||
|num|Number|No|The number to test.|
Example:
{code:javascript}
// TypeScript
var happiness: Boolean = Farrago.RecreationalMaths.isHappy(28);
    /* happiness: true */

// JavaScript
var happiness = Farrago.RecreationalMaths.isHappy(28);
    /* happiness: true */
{code:javascript}

* **pizzaVolume(thickness, radius): Number _(Static)_**
Calculates the volume of a pizza according to the Pizza Theorem (Weisstein, Eric W. "Pizza Theorem." From MathWorld--A Wolfram Web Resource. http://mathworld.wolfram.com/PizzaTheorem.html).

||Parameter||Type||Optional||Description||
|thickness|Number|No|The thickness of the pizza.|
|radius|Number|No|The radius of the pizza.|
Example:
{code:javascript}
// TypeScript
var thickness: Number = Farrago.RecreationalMaths.pizzaVolume(2, 30);
    /* thickness: 1413.72 */

// JavaScript
var thickness = Farrago.RecreationalMaths.pizzaVolume(2, 30);
    /* thickness: 1413.72 */
{code:javascript}

* **sumDigitSquares(num): Number _(Static)_**
Calculates the sum of the squares of the digits of a number.

||Parameter||Type||Optional||Description||
|num|Number|No|The number whose squared digits will be summed.|
Example:
{code:javascript}
// TypeScript
var sum: Number = Farrago.RecreationalMaths.sumDigitSquares(28);
    /* thickness: 68 */

// JavaScript
var sum = Farrago.RecreationalMaths.pizzaVolume(28);
    /* thickness: 68 */
{code:javascript}