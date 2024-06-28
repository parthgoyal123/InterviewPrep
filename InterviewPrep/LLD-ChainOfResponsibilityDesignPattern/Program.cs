namespace LLD_ChainOfResponsibilityDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogProcessor logProcessor = new InfoLogProcessor(new DebugLogProcessor(new ErrorLogProcessor(null)));
            logProcessor.Process("INFO", "This is an info log");
            logProcessor.Process("ERROR", "This is a warning log");
            logProcessor.Process("DEBUG", "This is an error log");
        }
    }
}
