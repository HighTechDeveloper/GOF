using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }

    public abstract class Colleague

    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        { }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("NotifyConcreteColleague1: " + message);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        { }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("NotifyConcreteColleague2: " + message);
        }
    }

    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if (Colleague1 == colleague)
                Colleague1.Notify(msg);
            else if (Colleague2 == colleague)
                Colleague2.Notify(msg);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague1 ConcreteColleague1Obj = new ConcreteColleague1(mediator);
            ConcreteColleague2 ConcreteColleague2Obj = new ConcreteColleague2(mediator);
            mediator.Colleague1 = ConcreteColleague1Obj;
            mediator.Colleague2 = ConcreteColleague2Obj;
            ConcreteColleague1Obj.Send(" Сообщние от ConcreteColleague1Obj");
            ConcreteColleague2Obj.Send(" Сообщние от ConcreteColleague2Obj");
            Console.Read();
        }
    }
}
