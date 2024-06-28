using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ChainOfResponsibilityDesignPattern
{
    internal class DebugLogProcessor : LogProcessor
    {
        public DebugLogProcessor(LogProcessor nextProcessor) : base(nextProcessor)
        {
        }

        public override void Process(string logType, string log)
        {
            if (logType == "DEBUG")
            {
                Console.WriteLine($"Debug Log: {log}");
            }
            else
            {
                base.Process(logType, log);
            }
        }
    }
}
