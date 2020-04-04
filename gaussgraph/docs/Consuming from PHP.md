**You will require the [NsSOAP](http://sourceforge.net/projects/nusoap) library to consume web services from PHP in this tutorial.**

* Make a reference to the NuSOAP llibrary in the PHP code and add the URL of the web service:
{code:php}
require_once("nusoap/lib/nusoap.php");
$service = 'http://labs.bwhazel.co.uk/services/GaussGraphService.asmx?wsdl';
{code:php}
* Set up the SOAP client provided by NuSOAP:
{code:php}
$soap_client = new nusoap_client($service, 'wsdl');
$soap_client->setDefaultRpcParams(true);
$soap_client_proxy = $client->getProxy();
{code:php}
* Create an array containing the GaussView output and pass it to the web service. Ensure the indexer is named **output**.
{code:php}
$param['output']('output') = $gvoutputString;
$csv_return = $soap_client_proxy->ToCsv($param);
$csv = implode($csv_return);
unset(soap_client);
{code:php}