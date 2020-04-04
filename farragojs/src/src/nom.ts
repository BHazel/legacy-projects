// <copyright file="nom.ts" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2014-2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     nom: Script to create repeating messages.
// </summary>

module Farrago {
    export class RepeatingMessage {
        startText: string;
        repeatText: string;
        endText: string;
        separatorText: string;

        startJoined: boolean = false;
        allowSeparation: boolean = false;

        constructor(start: string = "", repeat: string = "", end: string = "", separator: string = "") {
            this.startText = start;
            this.repeatText = repeat;
            this.endText = end;
            this.separatorText = separator;
        }

        createMessage(count: number): string {
            var outputText: string = "";
            outputText = outputText.concat(this.startText);
            if (this.allowSeparation === true && this.startJoined === false) {
                outputText = outputText.concat(this.separatorText);
            }

            for (var i: number = 0; i < count; i++) {
                outputText = outputText.concat(this.repeatText);
                if (i === count - 1) {
                    outputText = outputText.concat(this.endText);
                } else {
                    if (this.allowSeparation === true) {
                        outputText = outputText.concat(this.separatorText);
                    }
                }
            }

            return outputText;
        }
    }

    export class Nom extends RepeatingMessage {
        static NOM_START: string = "Om";
        static NOM_REPEAT: string = "Nom";
        static NOM_END: string = "!";
        static NOM_SEPARATOR: string = " ";

        constructor(start: string = Farrago.Nom.NOM_START, repeat: string = Farrago.Nom.NOM_REPEAT, end: string = Farrago.Nom.NOM_END, separator: string = Farrago.Nom.NOM_SEPARATOR) {
            super(start, repeat, end, separator);
        }

        nom(count: number, om: boolean): string {
            if (om === true) {
                this.startText = Farrago.Nom.NOM_START;
            }

            return super.createMessage(count);
        }
    }

    export class Lol extends RepeatingMessage {
        static LOL_START_DEFAULT: string = "L";
        static LOL_START_CUSTOM: string = "TR";
        static LOL_REPEAT: string = "OL";
        static LOL_END: string = "!";
        static LOL_SEPARATOR: string = "";

        constructor(start: string = Farrago.Lol.LOL_START_DEFAULT, repeat: string = Farrago.Lol.LOL_REPEAT, end: string = Farrago.Lol.LOL_END, separator: string = Farrago.Lol.LOL_SEPARATOR) {
            super(start, repeat, end, separator);
            this.allowSeparation = false;
            this.startJoined = true;
        }

        lol(count: number, trol: boolean) {
            if (trol === true) {
                this.startText = Farrago.Lol.LOL_START_CUSTOM;
            }

            return super.createMessage(count);
        }
    }
}