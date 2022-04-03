
namespace AdapterApp
{
    internal class Webservice
    {
        private string webHost;

        public Webservice(string webHost)
        {
            this.webHost = webHost;
        }

        internal string request(string result)
        {
            return "Response";
        }
    }
}