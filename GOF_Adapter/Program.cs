using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Adapter
{
    public class OldClass
    {
        public void OldRequest() { Console.WriteLine("Метод старого класса"); }
    }

    public class NewClass
    {
        public virtual void NewRequest() { }
    }

    public class Adapter : NewClass
    {
        private OldClass OldClassObj = new OldClass();
        public override void NewRequest()
        {
            OldClassObj.OldRequest();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NewClass NewClassObj = (NewClass)(new Adapter());
            NewClassObj.NewRequest();
            Console.ReadLine();
        }
    }
}
































//public class OldClass
//{
//    public void OldRequest() { Console.WriteLine("Метод старого класса"); }
//}

//public class NewClass
//{
//    public virtual void NewRequest() { }
//}

//public class Adapter : NewClass
//{
//    private OldClass OldClassObj = new OldClass();
//    public override void NewRequest()
//    {
//        OldClassObj.OldRequest();
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        NewClass NewClassObj = (NewClass)(new Adapter());
//        NewClassObj.NewRequest();
//        Console.ReadLine();
//    }
//}



