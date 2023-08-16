# gRPCWeather
Streaming with gRPC on .NET

If you’re looking for a way to improve your application’s performance, you may want to consider using gRPC. gRPC is a high-performance, open-source universal RPC framework that can run in any environment. An RPC is a method of communication between two systems that allows them to exchange information. 

GRPC uses HTTP/2 as its transport layer, which provides several benefits over traditional HTTP/1.1. HTTP/2 is a binary protocol that multiplexes requests and responses over a single connection and uses header compression to reduce overhead. 

client keeps sending messages one by one to the server via await clientStreamingCall.RequestStream.WriteAsync() call. Finally when it is done sending the messages to the server, reads the result response from the server with the code var response = await clientStreamingCall; and print.


we have two tasks running parallelly, one for streaming the messages “await duplexStreamingCall.RequestStream.WriteAsync(new StreamMessage { Index = i });” and the other task keeps reading messages from the response stream sent from the server side “duplexStreamingCall.ResponseStream.Current” until there is a message available (await duplexStreamingCall.ResponseStream.MoveNext() is true).
If you run the server and client, the output will be as:
![grpsc-output](https://github.com/zakizadeh/gRPCWeather/assets/11499371/b53a1eab-314c-4941-85c9-502cfcdeecba)
