using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_FactoryMethod
{
    public abstract class Product { }

    public abstract class Factory
    {
        public abstract Product FactoryMethod();
    }

    public class BrickHouse : Product { }

    public class BrickHouseFactory : Factory
    {
        public override Product FactoryMethod()
        {
            return new BrickHouse();
        }
    }

    public class PanelHouse : Product { }

    public class PanelHouseFactory : Factory
    {
        public override Product FactoryMethod()
        {
            return new PanelHouse();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Factory factory = new BrickHouseFactory();
            Product concreteFactoryA = factory.FactoryMethod();
            Console.ReadLine();

        }
    }
}
