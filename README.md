### gRPCNetCore
gRPC C# 而且目前也已经支持.NET Core 可以实现完美跨平台。
传统的.NET 可以通过Mono 来实现跨平台调用。
gRPC是一个高性能、通用的开源RPC框架，其由Google主要面向移动应用开发并基于HTTP/2协议标准而设计，基于ProtoBuf(Protocol Buffers)序列化协议开发，且支持众多开发语言。gRPC提供了一种简单的方法来精确地定义服务和为iOS、Android和后台支持服务自动生成可靠性很强的客户端功能库。客户端充分利用高级流和链接功能，从而有助于节省带宽、降低的TCP链接次数、节省CPU使用、和电池寿命。

gRPC支持多种语言，并能够基于语言自动生成客户端和服务端功能库。目前，在GitHub上已提供了C版本grpc、Java版本grpc-java 和 Go版本grpc-go，其它语言的版本正在积极开发中，其中 grpc支持C、C++、Node.js、Python、Ruby、Objective-C、PHP和C#等语言，grpc-java已经支持Android开发。

gRPC已经应用在Google的云服务和对外提供的API中，其主要应用场景如下：

低延迟、高扩展性、分布式的系统
同云服务器进行通信的移动应用客户端
设计语言独立、高效、精确的新协议
便于各方面扩展的分层设计，如认证、负载均衡、日志记录、监控等

参考文档:
官网：https://grpc.io 
相关地址：http://www.infoq.com/cn/news/2015/03/grpc-google-http2-protobuf
