using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using System.Net.Http.Headers;



namespace EmailBox
{
    class Server
    {
        private HttpListener _listener;

        public Server(string[] prefixes)

        {
            _listener = new HttpListener();

            foreach (string prefix in prefixes)
            {
                _listener.Prefixes.Add(prefix);
            }



        }

        public async Task Start()
        {
            _listener?.Start();
          
        }


      





    }
}
