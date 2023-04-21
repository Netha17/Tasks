using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DIusingUnity
{
    public interface Icar
    {
        int Run();
    }
    public class BMW : Icar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }
    }
    public class Ford : Icar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }

    }
    public class Driver
    {
        private Icar _car = null;
        public Driver(Icar car)
        {
            _car = car;
        }
        public void RunCar()
        {
            Console.WriteLine("Running {0}-{1} mile", _car.GetType().Name, _car.Run());

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<Icar, BMW>();
            var driver = container.Resolve<Driver>();
            driver.RunCar();
            Console.ReadLine();
        }
    }
       
}
