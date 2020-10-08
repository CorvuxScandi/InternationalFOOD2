using System;
using System.IO;
using System.Security.Policy;

namespace RecepyWebsight.Classes
{
    public class ErrorHandler
    {
        public DateTime Time { get; set; }
        public string GivenException { get; set; }

        public ErrorHandler(string exception)
        {
            this.Time = DateTime.Now;
            this.GivenException = exception;
        }

        public void LogException()
        {
            string filePath = @"..\..\TextFiles\ErrorLog.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("[" + this.Time + "] " + this.GivenException);
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }
        }
    }
}
