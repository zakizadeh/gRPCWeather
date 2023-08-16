// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/weatherForecast.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServiceDemo {
  /// <summary>
  /// The weather forecast service definition.
  /// </summary>
  public static partial class WeatherForcast
  {
    static readonly string __ServiceName = "weatherForcast.WeatherForcast";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceDemo.WeatherForecastReply> __Marshaller_weatherForcast_WeatherForecastReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceDemo.WeatherForecastReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Timestamp> __Marshaller_google_protobuf_Timestamp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Timestamp.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceDemo.WeatherForecast> __Marshaller_weatherForcast_WeatherForecast = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceDemo.WeatherForecast.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceDemo.StreamMessage> __Marshaller_weatherForcast_StreamMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceDemo.StreamMessage.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcServiceDemo.WeatherForecastReply> __Method_GetWeatherForecast = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcServiceDemo.WeatherForecastReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWeatherForecast",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_weatherForcast_WeatherForecastReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::GrpcServiceDemo.WeatherForecastReply> __Method_GetWeatherForecastForDate = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::GrpcServiceDemo.WeatherForecastReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWeatherForecastForDate",
        __Marshaller_google_protobuf_Timestamp,
        __Marshaller_weatherForcast_WeatherForecastReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcServiceDemo.WeatherForecast> __Method_GetWeatherForecastStream = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcServiceDemo.WeatherForecast>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetWeatherForecastStream",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_weatherForcast_WeatherForecast);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecastReply> __Method_GetWeatherForecastClientStream = new grpc::Method<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecastReply>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "GetWeatherForecastClientStream",
        __Marshaller_weatherForcast_StreamMessage,
        __Marshaller_weatherForcast_WeatherForecastReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecast> __Method_GetWeatherForecastDuplexStream = new grpc::Method<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecast>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "GetWeatherForecastDuplexStream",
        __Marshaller_weatherForcast_StreamMessage,
        __Marshaller_weatherForcast_WeatherForecast);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServiceDemo.WeatherForecastReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for WeatherForcast</summary>
    public partial class WeatherForcastClient : grpc::ClientBase<WeatherForcastClient>
    {
      /// <summary>Creates a new client for WeatherForcast</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WeatherForcastClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for WeatherForcast that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WeatherForcastClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WeatherForcastClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WeatherForcastClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcServiceDemo.WeatherForecastReply GetWeatherForecast(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWeatherForecast(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcServiceDemo.WeatherForecastReply GetWeatherForecast(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetWeatherForecast, null, options, request);
      }
      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceDemo.WeatherForecastReply> GetWeatherForecastAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWeatherForecastAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceDemo.WeatherForecastReply> GetWeatherForecastAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetWeatherForecast, null, options, request);
      }
      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcServiceDemo.WeatherForecastReply GetWeatherForecastForDate(global::Google.Protobuf.WellKnownTypes.Timestamp request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWeatherForecastForDate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcServiceDemo.WeatherForecastReply GetWeatherForecastForDate(global::Google.Protobuf.WellKnownTypes.Timestamp request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetWeatherForecastForDate, null, options, request);
      }
      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceDemo.WeatherForecastReply> GetWeatherForecastForDateAsync(global::Google.Protobuf.WellKnownTypes.Timestamp request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWeatherForecastForDateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get weather forecast: Unary RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceDemo.WeatherForecastReply> GetWeatherForecastForDateAsync(global::Google.Protobuf.WellKnownTypes.Timestamp request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetWeatherForecastForDate, null, options, request);
      }
      /// <summary>
      /// Get weather forecast: Server Streaming RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServiceDemo.WeatherForecast> GetWeatherForecastStream(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWeatherForecastStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get weather forecast: Server Streaming RPCs
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServiceDemo.WeatherForecast> GetWeatherForecastStream(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetWeatherForecastStream, null, options, request);
      }
      /// <summary>
      /// Get weather forecast: Client Streaming RPCs
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecastReply> GetWeatherForecastClientStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWeatherForecastClientStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get weather forecast: Client Streaming RPCs
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecastReply> GetWeatherForecastClientStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_GetWeatherForecastClientStream, null, options);
      }
      /// <summary>
      /// Get weather forecast: Bidirectional streaming RPCs
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecast> GetWeatherForecastDuplexStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWeatherForecastDuplexStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get weather forecast: Bidirectional streaming RPCs
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcServiceDemo.StreamMessage, global::GrpcServiceDemo.WeatherForecast> GetWeatherForecastDuplexStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_GetWeatherForecastDuplexStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override WeatherForcastClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WeatherForcastClient(configuration);
      }
    }

  }
}
#endregion
