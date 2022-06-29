using Lamdat.Test.SyncTest.Common;
using Lamdat.Test.SyncTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamdat.Test.SyncTest.Connectors
{
    /// <summary>
    /// Connector that will be implementing the interface IConnector
    /// </summary>
    public class AzureDevOpsConnector : IConnector<SyncEntity>
    {
        private const string WIQL = "SELECT [id] FROM WorkItems WHERE [Work Item Type] = 'Feature' And [System.TeamProject] = 'Lamdat-Unified' ORDER BY [Changed Date] Desc";

        public async Task<List<SyncEntity>> GetEntities()
        {
            //TODO: 3. Implement exception, logger if required
            var api = new TfsClientApi<SyncEntity>(Consts.ADO_URL, Consts.ADO_USERNAME, Consts.ADO_TOKEN, true, "5.0");
            var result = await api.GetWorkItems(WIQL);
            return result;
        }

        public Task SetEntities(List<SyncEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
