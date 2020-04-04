// <copyright file="matrix2.ts" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     matrix2: Script to work with 2x2 matrices.
// </summary>

module Farrago {
    export class Matrix2 {
        w: number;
        x: number;
        y: number;
        z: number;

        constructor(w: number = 0, x: number = 0, y: number = 0, z: number = 0) {
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        determinant(): number {
            return (this.w * this.z) - (this.x * this.y);
        }

        trace(): number {
            return this.w + this.z;
        }

        eigenvalues(): number[] {
            var a: number = 1.0;
            var b: number = (-1 * this.w) - this.z;
            var c: number = ((-1 * this.x) * this.y) + (this.w * this.z);

            var discriminant: number = Math.pow(b, 2) - (4 * (a * c));
            if (discriminant < 0) {
                throw new EvalError("Quadratic equation discriminant is less than 0; eigenvalues are complex numbers.");
            }

            var eigenvalue1: number = ((-1 * b) + Math.sqrt(discriminant)) / (2 * a);
            var eigenvalue2: number = ((-1 * b) - Math.sqrt(discriminant)) / (2 * a);

            return [eigenvalue1, eigenvalue2];
        }

        principalEigenvalue(): number {
            if ((this.eigenvalues()[0] / this.trace()) > (this.eigenvalues()[1] / this.trace())) {
                return 0;
            } else {
                return 1;
            }
        }

        eigenvector(eigenvalue: number, value: number): number {
            return (-1 * (this.w - eigenvalue) * value) / this.x;
        }

        eigenvectorRange(start: number, increment: number, total: number): number[][] {
            var eigenvalue1: number = this.eigenvalues()[0];
            var eigenvalue2: number = this.eigenvalues()[1];

            var eigenvectors: number[][] = [];
            var currentValue: number = start;
            for (var i: number = 0; i < total; i++) {
                var eigenvector1: number = this.eigenvector(eigenvalue1, currentValue);
                var eigenvector2: number = this.eigenvector(eigenvalue2, currentValue);
                eigenvectors.push([eigenvector1, eigenvector2]);
                currentValue += increment;
            }

            return eigenvectors;
        }
    }
}