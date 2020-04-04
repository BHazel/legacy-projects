You will first need to add a web reference within Visual Studio.
* Right-click the _References_ node in Solution Explorer, followed by **Add Service Reference...**.
* In the window which appears click **Advanced...** followed by **Add Web Reference...**.
* Enter the URL for the service into the _URL_ field ([http://labs.bwhazel.co.uk/services/GaussGraphService.asmx](http://labs.bwhazel.co.uk/services/GaussGraphService.asmx)) and enter a name for the reference once found. I have simply named it **BWHazelLabs** for this demo.
Once added, the web reference can be used like any other reference in .NET.
* Add the web reference to the code:
**C#**
{code:c#}
using ProjectNamespace.BWHazelLabs
{code:c#}
**VB.NET**
{code:vb.net}
Imports ProjectNamespace.BWHazelLabs
{code:vb.net}
* Create a new instance of the **GaussGraphService** class and call the **ToCsv()** method:
**C#**
{code:c#}
GaussGraphService service = new GaussGraphService();
string csv = service.ToCsv(gvoutputString);
{code:c#}
**VB.NET**
{code:vb.net}
Dim service As New GaussGraphService()
Dim csv As String = service.ToCsv(gvoutputString)
{code:vb.net}