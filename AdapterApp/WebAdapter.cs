using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    internal class WebAdapter : WebRequester
    {
        private Webservice service;

        public void Connect(Webservice webservice)
        {
            this.service = webservice;
        }
        public int request(object request)
        {
            string result = this.ToString(request);
            string respone = service.request(result);
            if (respone != null)
                return 200;
            return 500;
        }

        private string ToString(object request)
        {
            if(request == null)
                return string.Empty;
            return Convert.ToString(request);
        }
    }
}
