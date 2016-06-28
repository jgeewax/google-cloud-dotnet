// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/logging/v2/logging_metrics.proto
// Original file comments:
// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Google.Logging.V2 {
  /// <summary>
  ///  Service for configuring logs-based metrics.
  /// </summary>
  public static class MetricsServiceV2
  {
    static readonly string __ServiceName = "google.logging.v2.MetricsServiceV2";

    static readonly Marshaller<global::Google.Logging.V2.ListLogMetricsRequest> __Marshaller_ListLogMetricsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Logging.V2.ListLogMetricsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Logging.V2.ListLogMetricsResponse> __Marshaller_ListLogMetricsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Logging.V2.ListLogMetricsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Logging.V2.GetLogMetricRequest> __Marshaller_GetLogMetricRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Logging.V2.GetLogMetricRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Logging.V2.LogMetric> __Marshaller_LogMetric = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Logging.V2.LogMetric.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Logging.V2.CreateLogMetricRequest> __Marshaller_CreateLogMetricRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Logging.V2.CreateLogMetricRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Logging.V2.UpdateLogMetricRequest> __Marshaller_UpdateLogMetricRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Logging.V2.UpdateLogMetricRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Logging.V2.DeleteLogMetricRequest> __Marshaller_DeleteLogMetricRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Logging.V2.DeleteLogMetricRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly Method<global::Google.Logging.V2.ListLogMetricsRequest, global::Google.Logging.V2.ListLogMetricsResponse> __Method_ListLogMetrics = new Method<global::Google.Logging.V2.ListLogMetricsRequest, global::Google.Logging.V2.ListLogMetricsResponse>(
        MethodType.Unary,
        __ServiceName,
        "ListLogMetrics",
        __Marshaller_ListLogMetricsRequest,
        __Marshaller_ListLogMetricsResponse);

    static readonly Method<global::Google.Logging.V2.GetLogMetricRequest, global::Google.Logging.V2.LogMetric> __Method_GetLogMetric = new Method<global::Google.Logging.V2.GetLogMetricRequest, global::Google.Logging.V2.LogMetric>(
        MethodType.Unary,
        __ServiceName,
        "GetLogMetric",
        __Marshaller_GetLogMetricRequest,
        __Marshaller_LogMetric);

    static readonly Method<global::Google.Logging.V2.CreateLogMetricRequest, global::Google.Logging.V2.LogMetric> __Method_CreateLogMetric = new Method<global::Google.Logging.V2.CreateLogMetricRequest, global::Google.Logging.V2.LogMetric>(
        MethodType.Unary,
        __ServiceName,
        "CreateLogMetric",
        __Marshaller_CreateLogMetricRequest,
        __Marshaller_LogMetric);

    static readonly Method<global::Google.Logging.V2.UpdateLogMetricRequest, global::Google.Logging.V2.LogMetric> __Method_UpdateLogMetric = new Method<global::Google.Logging.V2.UpdateLogMetricRequest, global::Google.Logging.V2.LogMetric>(
        MethodType.Unary,
        __ServiceName,
        "UpdateLogMetric",
        __Marshaller_UpdateLogMetricRequest,
        __Marshaller_LogMetric);

    static readonly Method<global::Google.Logging.V2.DeleteLogMetricRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteLogMetric = new Method<global::Google.Logging.V2.DeleteLogMetricRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "DeleteLogMetric",
        __Marshaller_DeleteLogMetricRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MetricsServiceV2</summary>
    public abstract class MetricsServiceV2Base
    {
      /// <summary>
      ///  Lists logs-based metrics.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Logging.V2.ListLogMetricsResponse> ListLogMetrics(global::Google.Logging.V2.ListLogMetricsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets a logs-based metric.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Logging.V2.LogMetric> GetLogMetric(global::Google.Logging.V2.GetLogMetricRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Creates a logs-based metric.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Logging.V2.LogMetric> CreateLogMetric(global::Google.Logging.V2.CreateLogMetricRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Creates or updates a logs-based metric.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Logging.V2.LogMetric> UpdateLogMetric(global::Google.Logging.V2.UpdateLogMetricRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Deletes a logs-based metric.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLogMetric(global::Google.Logging.V2.DeleteLogMetricRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MetricsServiceV2</summary>
    public class MetricsServiceV2Client : ClientBase<MetricsServiceV2Client>
    {
      /// <summary>Creates a new client for MetricsServiceV2</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MetricsServiceV2Client(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MetricsServiceV2 that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MetricsServiceV2Client(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MetricsServiceV2Client() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MetricsServiceV2Client(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Lists logs-based metrics.
      /// </summary>
      public virtual global::Google.Logging.V2.ListLogMetricsResponse ListLogMetrics(global::Google.Logging.V2.ListLogMetricsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListLogMetrics(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists logs-based metrics.
      /// </summary>
      public virtual global::Google.Logging.V2.ListLogMetricsResponse ListLogMetrics(global::Google.Logging.V2.ListLogMetricsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListLogMetrics, null, options, request);
      }
      /// <summary>
      ///  Lists logs-based metrics.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.ListLogMetricsResponse> ListLogMetricsAsync(global::Google.Logging.V2.ListLogMetricsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListLogMetricsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists logs-based metrics.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.ListLogMetricsResponse> ListLogMetricsAsync(global::Google.Logging.V2.ListLogMetricsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListLogMetrics, null, options, request);
      }
      /// <summary>
      ///  Gets a logs-based metric.
      /// </summary>
      public virtual global::Google.Logging.V2.LogMetric GetLogMetric(global::Google.Logging.V2.GetLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLogMetric(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a logs-based metric.
      /// </summary>
      public virtual global::Google.Logging.V2.LogMetric GetLogMetric(global::Google.Logging.V2.GetLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLogMetric, null, options, request);
      }
      /// <summary>
      ///  Gets a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.LogMetric> GetLogMetricAsync(global::Google.Logging.V2.GetLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLogMetricAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.LogMetric> GetLogMetricAsync(global::Google.Logging.V2.GetLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLogMetric, null, options, request);
      }
      /// <summary>
      ///  Creates a logs-based metric.
      /// </summary>
      public virtual global::Google.Logging.V2.LogMetric CreateLogMetric(global::Google.Logging.V2.CreateLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateLogMetric(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Creates a logs-based metric.
      /// </summary>
      public virtual global::Google.Logging.V2.LogMetric CreateLogMetric(global::Google.Logging.V2.CreateLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateLogMetric, null, options, request);
      }
      /// <summary>
      ///  Creates a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.LogMetric> CreateLogMetricAsync(global::Google.Logging.V2.CreateLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateLogMetricAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Creates a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.LogMetric> CreateLogMetricAsync(global::Google.Logging.V2.CreateLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateLogMetric, null, options, request);
      }
      /// <summary>
      ///  Creates or updates a logs-based metric.
      /// </summary>
      public virtual global::Google.Logging.V2.LogMetric UpdateLogMetric(global::Google.Logging.V2.UpdateLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateLogMetric(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Creates or updates a logs-based metric.
      /// </summary>
      public virtual global::Google.Logging.V2.LogMetric UpdateLogMetric(global::Google.Logging.V2.UpdateLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateLogMetric, null, options, request);
      }
      /// <summary>
      ///  Creates or updates a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.LogMetric> UpdateLogMetricAsync(global::Google.Logging.V2.UpdateLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateLogMetricAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Creates or updates a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Logging.V2.LogMetric> UpdateLogMetricAsync(global::Google.Logging.V2.UpdateLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateLogMetric, null, options, request);
      }
      /// <summary>
      ///  Deletes a logs-based metric.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteLogMetric(global::Google.Logging.V2.DeleteLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteLogMetric(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Deletes a logs-based metric.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteLogMetric(global::Google.Logging.V2.DeleteLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteLogMetric, null, options, request);
      }
      /// <summary>
      ///  Deletes a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLogMetricAsync(global::Google.Logging.V2.DeleteLogMetricRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteLogMetricAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Deletes a logs-based metric.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLogMetricAsync(global::Google.Logging.V2.DeleteLogMetricRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteLogMetric, null, options, request);
      }
      protected override MetricsServiceV2Client NewInstance(ClientBaseConfiguration configuration)
      {
        return new MetricsServiceV2Client(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(MetricsServiceV2Base serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListLogMetrics, serviceImpl.ListLogMetrics)
          .AddMethod(__Method_GetLogMetric, serviceImpl.GetLogMetric)
          .AddMethod(__Method_CreateLogMetric, serviceImpl.CreateLogMetric)
          .AddMethod(__Method_UpdateLogMetric, serviceImpl.UpdateLogMetric)
          .AddMethod(__Method_DeleteLogMetric, serviceImpl.DeleteLogMetric).Build();
    }

  }
}
#endregion
