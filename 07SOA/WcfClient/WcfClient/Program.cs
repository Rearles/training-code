using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.DataService;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new Service1Client())
            {
                Console.WriteLine(client.GetData(4));
                Console.WriteLine(client.GetDataUsingDataContract(new CompositeType
                {
                    BoolValue = true,
                    StringValue = "asdf"
                }).StringValue);
            }
            Console.ReadKey();
        }
    }
}
