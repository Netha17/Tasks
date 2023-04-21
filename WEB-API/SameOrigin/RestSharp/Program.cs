using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://localhost:44321/api/values/";
            var client= new RestClient(url);
            var request = new RestRequest();
            request.AddParameter("id", 1);
            var response= client.Get(request);
            Console.WriteLine(response.Content.ToString());
            Console.ReadLine();
        }
    }
}
