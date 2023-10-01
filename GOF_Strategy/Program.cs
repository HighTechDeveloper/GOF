using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Strategy
{
    internal class Program
    {
        public class Worker
        {
            public void DoWork(IJob job)
            {
                if (job != null)
                {
                    job.DoJob();
                }
            }
        }

        public interface IJob
        {
            void DoJob();
        }

        class HandJob : IJob
        {
            public void DoJob()
            {
                Console.WriteLine("Hand Job");
            }
        }

        static void Main(string[] args)
        {
            IJob JobObject = (IJob)(new HandJob());

            var worker = new Worker();
            worker.DoWork(JobObject);
            Console.ReadKey();
        }
    }
}
