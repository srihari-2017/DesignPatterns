using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    internal class WebClient
    {
        private WebRequester webRequester;

        public WebClient(WebRequester webRequester)
        {
            this.webRequester = webRequester;
        }

        public void doWork()
        {
            Object obj = makeObject();
            int status = webRequester.request(obj);
            if (status == 200)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Not OK");
            }
            return;
        }

        private object makeObject()
        {
            string obj = "request";
            return obj;
        }
    }
}
