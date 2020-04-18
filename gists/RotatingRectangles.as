package uk.co.bwhazel.applets.rotatingrectangles
{
	import flash.display.Shape;
	import flash.display.Sprite;
	import flash.events.Event;
	import flash.events.MouseEvent;
	import flash.events.TimerEvent;
	import flash.utils.Timer;
	
	/**
	 * Main program class.
	 * @author Benedict W. Hazel
	 */
	public class RotatingRectangles extends Sprite 
	{
		/**
		 * The number of rectangles to display.
		 */
		private const NUM_RECTANGLES:int = 20;
		
		/**
		 * The upper limit of the rectangle width.
		 */
		private const RECT_WIDTH_LIMIT:Number = 100;
		
		/**
		 * The upper limit of the rectangle height.
		 */
		private const RECT_HEIGHT_LIMIT:Number = 50;
		
		/**
		 * Flag to determine if a timer should be used to rotate the rectangles.
		 * Use a timer if true or mouse click if false.
		 */
		private const USE_TIMER:Boolean = true;
		
		/**
		 * The interval between rotations in milliseconds.
		 */
		private const ROTATE_INTERVAL:Number = 250;
		
		/**
		 * The timer to rotate the rectangles.
		 */
		private var rotationTimer:Timer;
		
		/**
		 * Initialises a new instance of the Main class.
		 */
		public function RotatingRectangles():void 
		{
			this.setBackground();
			this.createRectangles();
			if (this.USE_TIMER == true)
			{
				this.initialiseTimer();
			}
			else
			{
				this.stage.addEventListener(MouseEvent.MOUSE_DOWN, this.mouseDownListener);
			}
		}
		
		/**
		 * Sets the background colour.
		 */
		private function setBackground():void
		{
			this.graphics.beginFill(this.getRandom(0xFFFFFF), 1);
			this.graphics.drawRect(0, 0, this.stage.stageWidth, this.stage.stageHeight);
		}
		
		/**
		 * Creates the rectangle objects to display and adds them to the rectangles array.
		 */
		private function createRectangles():void
		{
			for (var i:int = 0; i < this.NUM_RECTANGLES; i++)
			{	
				var rect:Shape = new Shape();
				rect.graphics.lineStyle(1);
				rect.graphics.beginFill(this.getRandom(0xFFFFFF), 1);
				rect.graphics.drawRect(0, 0, this.RECT_WIDTH_LIMIT, this.RECT_HEIGHT_LIMIT);
				rect.x = this.getRandom(this.stage.stageWidth);
				rect.y = this.getRandom(this.stage.stageHeight);
				rect.width = this.getRandom(this.RECT_WIDTH_LIMIT);
				rect.height = this.getRandom(this.RECT_HEIGHT_LIMIT);
				trace("Rectangle " + (i + 1).toString() + " at (" + rect.x + ", " + rect.y + ") with H:" + rect.height + ", W:" + rect.width);
				this.addChild(rect);
			}
		}
		
		/**
		 * Initialises the timer for rotating the rectangles.
		 */
		private function initialiseTimer()
		{
			this.rotationTimer = new Timer(this.ROTATE_INTERVAL);
			this.rotationTimer.addEventListener(TimerEvent.TIMER, this.timerListener);
			this.rotationTimer.start();
		}
		
		/**
		 * Rotates the rectangles by a random angle.
		 */
		private function rotateRectangles():void
		{
			for (var i:int = 0; i < this.numChildren; i++)
			{
				if (this.getChildAt(i) is Shape)
				{
					this.getChildAt(i).rotation = this.getRandom(360);
				}
			}
		}
		
		/**
		 * Handles the mouse click event (MouseEvent.MOUSE_DOWN)
		 * @param e Information for the event.
		 */
		private function mouseDownListener(e:MouseEvent):void
		{
			this.rotateRectangles();
		}
		/**
		 * Handles the timer event (Timer.TIMER)
		 * @param e Information for the event.
		 */
		private function timerListener(e:TimerEvent):void
		{
			this.rotateRectangles();
		}
		
		/**
		 * Gets a random number between 0 and the specified upper limit.
		 * @param	upperLimit The upper limit of the random number.
		 * @return	A random number between 0 and the upper limit.
		 */
		private function getRandom(upperLimit:Number):Number
		{
			return Math.floor(Math.random() * upperLimit);
		}
	}	
}