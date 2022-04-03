// See https://aka.ms/new-console-template for more information

using AdapterApp;

String webHost = "url";

Webservice service = new Webservice(webHost);

WebAdapter adapter = new WebAdapter();

adapter.Connect(service);

WebClient client = new WebClient(adapter);

client.doWork();