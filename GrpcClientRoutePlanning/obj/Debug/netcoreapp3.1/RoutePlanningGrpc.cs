// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/routePlanning.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RoutingGrpcService.Protos {
  public static partial class DrivingRouter
  {
    static readonly string __ServiceName = "routePlanning.DrivingRouter";

    static readonly grpc::Marshaller<global::RoutingGrpcService.Protos.RouteRequest> __Marshaller_routePlanning_RouteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RoutingGrpcService.Protos.RouteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RoutingGrpcService.Protos.RouteResponse> __Marshaller_routePlanning_RouteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RoutingGrpcService.Protos.RouteResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::RoutingGrpcService.Protos.RouteRequest, global::RoutingGrpcService.Protos.RouteResponse> __Method_PlanRoute = new grpc::Method<global::RoutingGrpcService.Protos.RouteRequest, global::RoutingGrpcService.Protos.RouteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PlanRoute",
        __Marshaller_routePlanning_RouteRequest,
        __Marshaller_routePlanning_RouteResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RoutingGrpcService.Protos.RoutePlanningReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for DrivingRouter</summary>
    public partial class DrivingRouterClient : grpc::ClientBase<DrivingRouterClient>
    {
      /// <summary>Creates a new client for DrivingRouter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DrivingRouterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DrivingRouter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DrivingRouterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DrivingRouterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DrivingRouterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::RoutingGrpcService.Protos.RouteResponse PlanRoute(global::RoutingGrpcService.Protos.RouteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PlanRoute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RoutingGrpcService.Protos.RouteResponse PlanRoute(global::RoutingGrpcService.Protos.RouteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PlanRoute, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RoutingGrpcService.Protos.RouteResponse> PlanRouteAsync(global::RoutingGrpcService.Protos.RouteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PlanRouteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RoutingGrpcService.Protos.RouteResponse> PlanRouteAsync(global::RoutingGrpcService.Protos.RouteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PlanRoute, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DrivingRouterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DrivingRouterClient(configuration);
      }
    }

  }
}
#endregion
