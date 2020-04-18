package uk.co.bwhazel.happynumbers
{
	import flash.display.Sprite;
	
	public class Main extends Sprite
	{
		private var unhappyValues:Array = [4, 16, 37, 58, 89, 145, 42, 20];
		
		public function Main()
		{
			isHappy(25, true);
			isHappy(383, true);
			
			trace("Is 174 happy? " + isHappy(174));
		}
		
		public function isHappy(number:int, verbose:Boolean = false):Boolean
		{
			if (verbose)
			{
				trace("Testing whether " + number.toString() + " is happy:");
			}
			var determined:Boolean = false;
			var currentNumber:int = number;
			while (!determined)
			{
				currentNumber = sumDigitSquares(currentNumber, verbose);
				if (currentNumber == 1 || unhappyValues.indexOf(currentNumber) >= 0)
				{
					determined = true;
					if (verbose)
					{
						trace("Happiness of number determined...");
					}
				}
			}
			
			if (currentNumber == 1)
			{
				if (verbose)
				{
					trace(number.toString() + " is happy");
				}
				return true;
			}
			else
			{
				trace(number.toString() + " is unhappy");
				return false;
			}
		}
		
		private function sumDigitSquares(number:int, verbose:Boolean = false):int
		{
			var numberString:String = number.toString();
			var total:Number = 0;
			for (var i:int = 0; i < numberString.length; i++)
			{
				var square:Number = Math.pow(Number(numberString.charAt(i)), 2);
				total += square;
			}
			if (verbose)
			{
				trace("Sum of the squared digits of " + numberString + " is " + total.toString());
			}
			return int(total);
		}
	}
}