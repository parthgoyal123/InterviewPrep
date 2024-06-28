using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ChainOfResponsibilityDesignPattern
{
    internal abstract class LogProcessor
    {
        private LogProcessor nextProcessor;

        public LogProcessor(LogProcessor nextProcessor)
        {
            this.nextProcessor = nextProcessor;
        }

        public virtual void Process(string logType, string log)
        {
            if (this.nextProcessor != null)
            {
                this.nextProcessor.Process(logType, log);
            }
        }
    }
}
