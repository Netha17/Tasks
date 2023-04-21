using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DIusingUnity
{
    public  interface Iservice
    {
        string getFacultyName(int id);
    }
    class RegularStaff : Iservice
    {


        public string getFacultyName(int id)
        {
            return "some dummy name of regular emp with id:- " + id;
        }
    }
    class ContractStaff : Iservice
    {
        public string getFacultyName(int id)
        {
            return "some dummy name of contract emp with id:- " + id;
        }
    }
    public class client
    {
        private Iservice iservice;
        //public client(Iservice iservice)
        //{
        //    this.iservice = iservice;
        //}
        [InjectionMethod]
        public void setService(Iservice iservice)
        {
            this.iservice = iservice;
        }
        public string GetDetails(int id)
        {
            return iservice.getFacultyName(id);
        }
    }
    public static class Injector
    {
        public static client sendDependency(string EmpType)
        {
            var container = new UnityContainer();
            if (EmpType=="Regular")
            {
                
                container.RegisterType<Iservice, RegularStaff>();
                

            }
            else
            {
                container.RegisterType<Iservice, ContractStaff>();
                
            }
            var client = container.Resolve<client>();
            return client;

            
        }
    }
    class ConsDI
    {
        public static void Main()
        {
            client c=Injector.sendDependency("Contract");
            string n=c.GetDetails(8);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
