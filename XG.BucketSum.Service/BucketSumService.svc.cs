using Castle.Windsor;
using System.Collections.Generic;
using XG.BucketSum.Business.Patterns.Facade;
using System;

namespace XG.BucketSum.Service
{
   
    public class BucketSumService : IBucketSumService
    {
        private readonly WindsorContainer container;
        private readonly IBucketSumFacade bucketSumFacade;

        BucketSumService() {
            this.container = new WindsorContainer();
            container.Install(new BucketSum.Service.Ioc.SettingWindsor());
            this.bucketSumFacade = this.container.Resolve<IBucketSumFacade>();
        }

        public List<int> GetBucketSumConsol(string path)
        {
            return this.bucketSumFacade.GetBucketSumConsol(path);
        }

        public List<int> GetBucketSumWeb(string data)
        {
            return this.bucketSumFacade.GetBucketSumWeb(data);
        }

    }
}
