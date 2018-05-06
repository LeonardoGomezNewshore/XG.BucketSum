using System.Collections.Generic;
using System.ServiceModel;

namespace XG.BucketSum.Service
{
    [ServiceContract]
    public interface IBucketSumService
    {
        [OperationContract]
        List<int> GetBucketSumWeb(string data);

        [OperationContract]
        List<int> GetBucketSumConsol(string path);
    }
}
