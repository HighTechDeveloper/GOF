using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Singleton
{
    class Singleton
    {
        private static Singleton instance;

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton MyObj1 = Singleton.getInstance();
            Singleton MyObj2 = Singleton.getInstance();

            // проверка на уникальность
            Console.WriteLine(MyObj1.GetHashCode());
            Console.WriteLine(MyObj2.GetHashCode());

            Console.ReadLine();
        }
    }

}
 