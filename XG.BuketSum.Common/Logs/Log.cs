using log4net;
using log4net.Config;
using System.Reflection;

namespace XG.BuketSum.Common.Logs
{
    public class Log
    {
        private static ILog log;

        public static ILog Default
        {
            get
            {
                if (log == null)
                {
                    XmlConfigurator.Configure();
                    log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                    return log;
                }

                return log;
            }
        }
    }
}
