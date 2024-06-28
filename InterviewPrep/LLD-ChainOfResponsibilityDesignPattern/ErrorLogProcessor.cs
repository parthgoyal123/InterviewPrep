using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ChainOfResponsibilityDesignPattern
{
    internal class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor nextProcessor) : base(nextProcessor)
        {
        }

        public override void Process(string logType, string log)
        {
            if (logType == "ERROR")
            {
                Console.WriteLine($"Error Log: {log}");
            }
            else
            {
                base.Process(logType, log);
            }
        }
    }
}
