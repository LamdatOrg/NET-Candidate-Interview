using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamdat.Test.SyncTest.Common
{
    public interface IConnector<SyncEntity>
    {
        Task<List<SyncEntity>> GetEntities();

        Task SetEntities(List<SyncEntity> entities);
    }
}
