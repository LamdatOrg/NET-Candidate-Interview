using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamdat.Test.SyncTest.Common
{
    internal class Consts
    {
        //TODO: 1. Set configuration details
        internal const string ADO_USERNAME = "a@b.com";
        internal const string ADO_TOKEN = "ddfdfdgfrrrrrrrrrrrrrrrrrrrrrsdsaddae";
        internal const string ADO_URL = "https://azuredevops.xxx.com/SyncNowCollection";
    }

    public enum LogSeverity
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        Debug = 3

    }

}
