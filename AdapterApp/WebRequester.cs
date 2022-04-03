using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    internal interface WebRequester
    {
        int request(Object obj);
    }
}
