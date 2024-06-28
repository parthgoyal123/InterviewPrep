using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ChainOfResponsibilityDesignPattern
{
    internal class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor nextProcessor) : base(nextProcessor)
        {
        }

        public override void Process(string logType, string log)
        {
            if (logType == "INFO")
            {
                Console.WriteLine($"Info Log: {log}");
            }
            else
            {
                base.Process(logType, log);
            }
        }
    }
}
