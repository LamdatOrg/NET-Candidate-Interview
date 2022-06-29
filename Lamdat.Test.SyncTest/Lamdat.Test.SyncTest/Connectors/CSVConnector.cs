using Lamdat.Test.SyncTest.Common;
using Lamdat.Test.SyncTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace Lamdat.Test.SyncTest.Connectors
{
    
    internal class CSVConnector : IConnector<SyncEntity>
    {
        public async Task<List<SyncEntity>> GetEntities()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: 4. Implement set entities - into CSV File
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public  async Task SetEntities(List<SyncEntity> entities)
        {
            
        }
    }
}
