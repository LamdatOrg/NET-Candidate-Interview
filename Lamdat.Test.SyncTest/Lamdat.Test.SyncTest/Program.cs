using Lamdat.Test.SyncTest;
using Lamdat.Test.SyncTest.Common;
using Lamdat.Test.SyncTest.Connectors;
using Lamdat.Test.SyncTest.Entities;
using Lamdat.Test.SyncTest.Services;
using System;

public class App
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        //TODO: 8. Add try catch, logger      

        var adoWrapAzureDevOpsAPIWrapper = new AzureDevOpsConnector();
        var csvConnector = new CSVConnector();
        var connSvc = new ConnectorServices<SyncEntity>();
        connSvc.Sync(adoWrapAzureDevOpsAPIWrapper, csvConnector).Wait();

        Logger.Log(LogSeverity.Info, "Completed!");


    }

}




