// <copyright file="binary.ts" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2014-2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     binary: Script to perform interconversion of binary and decimal numbers.
// </summary>

module Farrago {
    export class BinaryConverter {
        static toBinary(decimalNumber: number): string {
            var binaryNumber: string = "";
            var divisionTotal: number = decimalNumber;
            var remainder: number = 0;
            while (divisionTotal >= 1) {
                remainder = Math.floor(divisionTotal % 2);
                binaryNumber = remainder.toString().concat(binaryNumber);
                divisionTotal = Math.floor(divisionTotal / 2);
            }

            return binaryNumber;
        }

        static fromBinary(binaryNumber: string): number {
            var bits: boolean[] = BinaryConverter.getBits(binaryNumber);
            var decimalNumber: number = 0;
            for (var i: number = 1; i <= bits.length; i++) {
                if (bits[i - 1] == true) {
                    decimalNumber += Math.pow(2, binaryNumber.length - i);
                }
            }

            return decimalNumber;
        }

        static getBits(binaryNumber: string): boolean[] {
            var bits: boolean[] = [];
            var boolConversion: number = 0;
            for (var i: number = 0; i < binaryNumber.length; i++) {
                boolConversion = Number(binaryNumber.charAt(i));
                bits[i] = Boolean(boolConversion);
            }

            return bits;
        }
    }
}