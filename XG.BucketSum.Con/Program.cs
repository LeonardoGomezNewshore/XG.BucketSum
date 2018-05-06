using Castle.Windsor;
using System;
using XG.BucketSum.Business.Patterns.Facade;
using XG.BucketSum.Con.BucketSumService;

namespace XG.BucketSum.Con
{
    public class Program
    {
        static WindsorContainer container;

       
        public static void Main(string[] args)
        {
            BucketSumServiceClient service = new BucketSumServiceClient();
         
            container = new WindsorContainer();
            container.Install(new Con.IoC.SettingWindsor());

            IBucketSumFacade bucketSumFacade = container.Resolve<IBucketSumFacade>();

            var result = service.GetBucketSumConsol(SettingsBucketSum.Default.pathLines);

            Console.WriteLine("Resultado");

            foreach (var item in result) {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
