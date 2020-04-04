// <copyright file="recmaths.ts" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2014-2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     recmaths: Script to perform recreational mathematics operations.
// </summary>

module Farrago {
    export class RecreationalMaths {
        static UnhappyLoopValues: number[] = [4, 16, 37, 58, 89, 145, 42, 20];

        static isHappy(num: number): boolean {
            var happinessDetermined: boolean = false;
            var currentNumber: number = num;
            while (!happinessDetermined) {
                currentNumber = RecreationalMaths.sumDigitSquares(currentNumber);
                if (currentNumber === 1 || RecreationalMaths.UnhappyLoopValues.indexOf(currentNumber) != -1) {
                    happinessDetermined = true;
                }
            }

            if (currentNumber === 1) {
                return true;
            } else {
                return false;
            }
        }

        static pizzaVolume(thickness: number, radius: number) {
            return Math.PI * Math.pow(radius, 2) * thickness;
        }

        static sumDigitSquares(num: number): number {
            var numberString: string = num.toString();
            var total: number = 0;
            for (var i: number = 0; i < numberString.length; i++) {
                var square: number = Math.pow(Number(numberString.charAt(i)), 2);
                total += square;
            }

            return total;
        }
    }
}