You can build FarragoJS in any way that the TypeScript compiler will allow!  However, two ways are described below.  Before starting, ensure the TypeScript compiler, {{tsc}} is on the path.

## 1:1 TypeScript:JavaScript Files
This option will generate a separate JavaScript file for each TypeScript file and is the default option for the compiler:

{{
tsc nom.ts recmaths.ts
}}
The generated JavaScript files will take the same filenames as the TypeScript with a {{.js}} filename instead of {{.ts}}.

## Single JavaScript File
This option will generate a single JavaScript file for the whole library:

{{
tsc nom.ts recmaths.ts --out farrago.js
}}