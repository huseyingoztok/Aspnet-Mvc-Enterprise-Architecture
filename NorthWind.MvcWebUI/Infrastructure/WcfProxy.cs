using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace NorthWind.MvcWebUI.Infrastructure
{
    public class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string address = string.Format("http://localhost:22934/{0}.svc?wsdl", typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding, address);

            return channel.CreateChannel();

        }
    }
}