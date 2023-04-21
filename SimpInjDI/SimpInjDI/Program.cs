using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DIusingUnity
{
    public interface Iservice
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
        public client(Iservice iservice)
        {
            this.iservice = iservice;
        }
        //[InjectionMethod]
        //public void setService(Iservice iservice)
        //{
        //    this.iservice = iservice;
        //}
        //[Dependency]
        //public Iservice iservice
        //{
        //    get; set;
        //}

        public string GetDetails(int id)
        {
            return iservice.getFacultyName(id);
        }
    }
    public static class Injector
    {
        public static client sendDependency()
        {
            Container container = new Container();
            container.Register<Iservice,ContractStaff>();
            container.Register<client>();
            container.Verify();
            return container.GetInstance<client>();
            

           
            


        }
    }
    class ConsDI
    {
        public static void Main()
        {
            client c = Injector.sendDependency();
            string n = c.GetDetails(890);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
