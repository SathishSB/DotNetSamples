using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace AzureServiceBusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue();

            Topics tpc = new Topics();
            tpc.CreateTopic();

            Console.Read();          
        }

        public static void Queue()
        {
            var connectionString = "Endpoint=sb://sathishqueuedelete-ns.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=35To+GegSMYNlGGKkiFLt5Bo1JcRu9dMZabZl8JFx5A=";
            var queueName = "sathishqueuedelete";

            for (int i = 0; i < 6; i++)
            {
                var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

                Console.WriteLine();
                Console.WriteLine("##############################################");
                Console.WriteLine("Message - :" + i);
                Console.WriteLine();

                var message = new BrokeredMessage("This is a test message : " + i);

                SendMessageToQueue(client, message);

                ReceiveMessageFromQueue(client);

                System.Threading.Thread.Sleep(200);

                client.Close();
            }
        }

        public static void SendMessageToQueue(QueueClient client, BrokeredMessage message)
        {
            client.Send(message);
        }

        public static void ReceiveMessageFromQueue(QueueClient client)
        {           
            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });          

        }
    }
}
