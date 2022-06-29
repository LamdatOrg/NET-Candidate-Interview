using Lamdat.Test.SyncTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamdat.Test.SyncTest.Services
{
    /// <summary>
    /// This is the logic of the syncronization process
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class ConnectorServices<T>
    {
        public async Task Sync(IConnector<T> connectorA, IConnector<T> connectorB)
        {
            
            ///TODO: 6.Add here exception and logger if needed
            var entities = await connectorA.GetEntities();

            //TODO:  7. In parralel run over all entities and write the length of the url field into the Length field

            //TODO:  8. Set Entities - in this example write all the entities into CSV
            await connectorB.SetEntities(entities);


        }
    }
}
