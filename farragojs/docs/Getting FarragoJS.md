You can download both the source code and compiled JavaScript.
## Source Code

To get the source code, clone the Git repository:

{{
git clone https://git01.codeplex.com/farragojs
cd farragojs
}}
## Compiled JavaScript
Compiled JavaScript can be obtained as a compressed folder from the Downloads page or as NuGet packages.  There are two versions of the compiled JavaScript available:
* **Complete:** All FarragoJS components are in a single _farrago.js_ file.
* **Modular:** Each FarragoJS component is in its own JavaScript file corresponding to its TypeScript file in the repository, i.e. _nom.js_ corresponds to _nom.ts_.

**Compressed Folder (Downloads)**
Download the compressed folder from the Downloads page.  The complete and modular versions can be found in the _complete_ and _modular_ directories respectively.

**NuGet Packages**
The NuGet packages can be downloaded directly through the NuGet Package Manager in Visual Studio although different feeds are used depending on the version you require:
* **Complete:** Available on the official nuget.org package feed already available in Visual Studio.
* **Modular**: Available on my own NuGet feed at [http://nu.bwhazel.co.uk/nuget](http://nu.bwhazel.co.uk/nuget).  Instructions for adding the feed to Visual Studio are available on that site.