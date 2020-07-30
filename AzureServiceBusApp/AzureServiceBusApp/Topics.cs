using Microsoft.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureServiceBusApp
{
    class Topics
    {
        public string ConnectionString
        {
            get
            {
                return conStr;
            }
            set
            {
                conStr = value;
            }
        }

        private string conStr;

        public Topics()
        {
            //ConnectionString = "Endpoint=sb://sathishqueuedelete-ns.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=35To+GegSMYNlGGKkiFLt5Bo1JcRu9dMZabZl8JFx5A=";
        }

        public void CreateTopic()
        {
            ConnectionString = "Endpoint=sb://sathishqueuedelete-ns.servicebus.windows.net/;SharedAccessKeyName=SAS1Topic;SharedAccessKey=OPzK72ubZc40sPeNN6FZFfdW+GcTFlyztGsaNNhQ+V8=";

            var namespaceManager = NamespaceManager.CreateFromConnectionString(ConnectionString);

            namespaceManager.CreateTopic("TestTopic1");

            if (!namespaceManager.TopicExists("TestTopic1"))
            {
                namespaceManager.CreateTopic("TestTopic1");
            }
        }
    }
}
