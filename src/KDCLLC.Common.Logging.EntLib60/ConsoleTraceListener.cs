

namespace KDCLLC.Common.Logging.EntLib60
{
    using System;
    using System.Diagnostics;
    using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
    using Microsoft.Practices.EnterpriseLibrary.Logging;
    using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
    using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

      ///<inheritdoc/>
      [ConfigurationElementType(typeof(CustomTraceListenerData))]
      public class ConsoleTraceListener : CustomTraceListener
    {
        ///<inheritdoc/>
        public override void TraceData(TraceEventCache eventCache,
            string source, TraceEventType eventType, int id, object data)
        {
            if (data is LogEntry && Formatter != null)
            {
                var le = (LogEntry)data;
                WriteLine(Formatter.Format(le));
            }
            else
            {
                WriteLine(data.ToString());
            }
        }

        ///<inheritdoc/>
        public override void Write(string message)
        {
            Console.Write(message);
        }

        ///<inheritdoc/>
        public override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
