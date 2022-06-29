using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamdat.Test.SyncTest.Common;

namespace Lamdat.Test.SyncTest.Common
{
    internal class Logger
    {
        internal static void Log(LogSeverity logSeverity, string message)
        {
            Console.WriteLine($"{logSeverity.ToString()}: {message}");
        }
    }
}
