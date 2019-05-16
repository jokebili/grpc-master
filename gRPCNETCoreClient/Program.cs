using Grpc.Core;
using GRPCNETCoreDemo;
using Newtonsoft.Json;
using System;
using static Proto.HelloService;

namespace gRPCNETCoreClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("192.168.200.25:15215", ChannelCredentials.Insecure);
            var clients = new HelloServiceClient(channel);



            var result = clients.GetPersons(new Proto.GetPersonsParam() { Place="123"});
            var list= result.List;
            string json= JsonConvert.SerializeObject(list);

            //var client = new gRPC.gRPCClient(channel);
            //var reply = client.SayHello(new HelloRequest { Name = "LineZero" });
            //Console.WriteLine("来自" + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}