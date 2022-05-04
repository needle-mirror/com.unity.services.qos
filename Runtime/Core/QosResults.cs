using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Qos.Internal;

namespace Unity.Services.Qos
{
    internal class QosResults : IQosResults
    {
        private IQosService _qosService;

        internal QosResults(IQosService qosService)
        {
            _qosService = qosService;
        }

        public Task<IList<QosResult>> GetSortedQosResultsAsync(string service, IList<string> regions)
        {
            return _qosService.GetSortedQosResultsAsync(service, regions);
        }
    }
}
