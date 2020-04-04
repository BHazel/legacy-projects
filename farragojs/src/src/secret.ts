// <copyright file="secret.ts" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2014-2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     secret: Script to convert text into secret messages.
// </summary>

module Farrago {
    export interface SecretCodeAlgorithm {
        encrypt(): string;
        decrypt(): string;
    }

    export class IncrementationSecretCode implements SecretCodeAlgorithm {
        increment: number;
        inputText: string;

        constructor(increment: number = 0, input: string = "") {
            this.increment = increment;
            this.inputText = input;
        }

        encrypt(): string {
            return this.doEncryption(true);
        }

        decrypt(): string {
            return this.doEncryption(false);
        }

        private doEncryption(encrypt: boolean): string {
            if (Math.abs(this.increment) > 25) {
                throw new Error("Increment too large; value should be between -25 and 25.");
            }

            var localIncrement: number = encrypt ? this.increment : (-1 * this.increment);
            var outputChar: string = "";
            var outputString: string = "";
            var punctuationRegex: RegExp = new RegExp("\\W");
            var numericRegex: RegExp = new RegExp("\\d");

            for (var i: number = 0; i < this.inputText.length; i++) {
                if (punctuationRegex.test(this.inputText[i])) {
                    outputChar = this.inputText[i];
                } else if (numericRegex.test(this.inputText[i])) {
                    if (Math.abs(this.increment) >= 10) {
                        var mode: number = encrypt ? 1 : -1;
                        var incrementAsString: string = localIncrement.toString();
                        localIncrement = mode * parseInt(incrementAsString[incrementAsString.length - 1]);
                    }

                    if ((this.inputText.charCodeAt(i) + localIncrement) > 57 || (this.inputText.charCodeAt(i) + localIncrement) < 48) {
                        outputChar = this.getOutputCharForRange(encrypt, localIncrement, i, 48, 57);
                    } else {
                        outputChar = String.fromCharCode(this.inputText.charCodeAt(i) + localIncrement);
                    }
                } else if ((this.inputText.charCodeAt(i) >= 65 && this.inputText.charCodeAt(i) <= 90) && ((this.inputText.charCodeAt(i) + localIncrement) > 90 || (this.inputText.charCodeAt(i) + localIncrement) < 65)) {
                    this.getOutputCharForRange(encrypt, localIncrement, i, 65, 90);
                } else if ((this.inputText.charCodeAt(i) >= 97 && this.inputText.charCodeAt(i) <= 122) && ((this.inputText.charCodeAt(i) + localIncrement) > 122 || (this.inputText.charCodeAt(i) + localIncrement) < 97)) {
                    this.getOutputCharForRange(encrypt, localIncrement, i, 97, 122);
                } else {
                    outputChar = String.fromCharCode(this.inputText.charCodeAt(i) + localIncrement);
                }

                outputString = outputString.concat(outputChar);
            }

            return outputString;
        }

        private getOutputCharForRange(encrypt: boolean, increment: number, charPosition: number, boundary1Low: number, boundary1High: number): string {
            var boundary1: number = encrypt ? boundary1High : boundary1Low;
            var boundary2: number = encrypt ? (boundary1Low - 1) : (boundary1High + 1);
            var difference = this.inputText.charCodeAt(charPosition) + increment - boundary1;
            return String.fromCharCode(boundary2 + difference);
        }
    }

    export class InversionSecretCode implements SecretCodeAlgorithm {
        inputText: string;

        encrypt(): string {
            return this.doEncryption();
        }

        decrypt(): string {
            return this.doEncryption();
        }

        constructor(input: string = "") {
            this.inputText = input;
        }

        private doEncryption(): string {
            var outputChar: string = "";
            var outputString: string = "";
            var punctuationRegex: RegExp = new RegExp("\\W");
            var numericRegex: RegExp = new RegExp("\\d");

            for (var i: number = 0; i < this.inputText.length; i++) {
                if (punctuationRegex.test(this.inputText[i])) {
                    outputChar = this.inputText[i];
                } else if (numericRegex.test(this.inputText[i])) {
                    outputChar = this.getOutputCharForRange(i, 11, 47);
                } else if (this.inputText.charCodeAt(i) >= 65 && this.inputText.charCodeAt(i) <= 90) {
                    outputChar = this.getOutputCharForRange(i, 27, 64);
                } else if (this.inputText.charCodeAt(i) >= 97 && this.inputText.charCodeAt(i) <= 122) {
                    outputChar = this.getOutputCharForRange(i, 27, 96);
                }

                outputString = outputString.concat(outputChar);
            }

            return outputString;
        }

        private getOutputCharForRange(charPosition: number, diffSubFrom: number, diffValueToSub: number) {
            var difference: number = diffSubFrom - (this.inputText.charCodeAt(charPosition) - diffValueToSub);
            return String.fromCharCode(diffValueToSub + difference);
        }
    }
}