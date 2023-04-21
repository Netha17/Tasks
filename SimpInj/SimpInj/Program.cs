using System;
using System.Collections.Generic;
using System.Linq;
using SimpleInjector;
using System.Text;
using System.Threading.Tasks;

public interface Iservice
{
     void carService();
}
class Maruthi : Iservice
{
    public void carService()
    {
        System.Console.WriteLine("maruthi servicing");
    }

}
class Hyundai : Iservice
{
    public void carService()
    {
        System.Console.WriteLine("hyundai servicing");
    }
}
class Audi: Iservice
{
    public void carService()
    {
        System.Console.WriteLine("audi servicing");
    }

}
class client
{
    private Iservice service;
        public client(Iservice service)
    {
        this.service=service;
    }
    public void makeService()
    {
        service.carService();
    }
}
public static class Injector
{
    public static void sendDependency(string carType)
    {
        Container container = new SimpleInjector.Container();
        if (carType == "hyundai")
        {
            
            container.Register<Iservice, Hyundai>();

        }
        else if (carType=="maruthi")
        {
           
            container.Register<Iservice, Maruthi>();

        }
        else if(carType=="audi")
        {
            container.Register<Iservice, Audi>();
        }
    
        container.Register<client>();
        var car = container.GetInstance<client>();
        car.makeService();
    }
}
public class SimpInj
{
    public static void Main(string[] args)
    {
        string car;
        Console.WriteLine("enter car");
        car= Console.ReadLine();
       Injector.sendDependency(car);
        Console.ReadLine();
    }
}
