using System.Collections.Generic;

namespace XG.BucketSum.Business.Patterns.Facade
{
    public interface IBucketSumFacade
    {
        List<int> GetBucketSumWeb(string path);
        List<int> GetBucketSumConsol(string data);
    }
}