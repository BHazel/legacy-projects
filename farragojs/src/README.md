FarragoJS Library
=================

**Released under the LGPL v2.1**

FarragoJS is a set of simple functions offering features ranging from useful
to totally pointless! But hey, there's a use for everything, right?

Functionality current includes:

* Binary-decimal interconversion (_binary.js_)
* Simple recreational mathematics (_recmaths.js_)
* String manipulation to create secret and repeating messages (_secret.js_
and _nom.js_).

More information and the API reference can be found on the project web site at
**http://farragojs.codeplex.com**.

Requirements
------------

To compile the source you require:

* NodeJS
* NPM

Once installed you required the following NPM packages:

* Grunt (_grunt_)
* TypeScript (_typescript_)
* TypeScript Grunt Tasks (_grunt-typescript_)

Compiling the Source
--------------------

FarragoJS is written in TypeScript which can be compiled to JavaScript using the
provided Grunt tasks.

The default task generates a single JavaScript file, `farrago.js`, for the library:

    grunt

You can also run `grunt single` to generate this file.

To generate individual JavaScript files for each TypeScript file run:

    grunt modular

Each file is independent of the others: if you only require one component the others
do not need to be installed.