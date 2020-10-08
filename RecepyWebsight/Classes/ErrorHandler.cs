using System;
using System.IO;
using System.Security.Policy;

namespace RecepyWebsight.Classes
{
    public class ErrorHandler : Exception
    {
        public DateTime Time { get; set; }
        public Exception GivenException { get; set; }

        public ErrorHandler(Exception exception)
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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }
        }
    }
}
