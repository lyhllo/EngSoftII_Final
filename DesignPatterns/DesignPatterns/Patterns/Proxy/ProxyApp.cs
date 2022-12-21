using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Proxy
{
    public class ProxyApp
    {
        public ProxyApp() {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            ProxyProxy proxy = new ProxyProxy(realSubject);
            client.ClientCode(proxy);
        }
    }
}
