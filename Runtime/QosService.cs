using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Qos.Internal;

[assembly: InternalsVisibleTo("Unity.Services.Qos.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Unity.Services.Qos
{
    /// <summary>
    /// Provides an entry point to the QoS Service, enabling clients to measure the quality of service (QoS) in terms
    /// of latency and packet loss for various regions.
    /// </summary>
    /// <example>
    /// <code lang="cs">
    /// <![CDATA[
    /// using System;
    /// using Unity.Services.Authentication;
    /// using Unity.Services.Core;
    /// using Unity.Services.Qos;
    /// using UnityEngine;
    ///
    /// namespace MyPackage
    /// {
    ///     public class MySample : MonoBehaviour
    ///     {
    ///         public async void RunQos()
    ///         {
    ///             try
    ///             {
    ///                 await UnityServices.InitializeAsync();
    ///                 await AuthenticationService.Instance.SignInAnonymouslyAsync();
    ///                 var serviceName = "multiplay";
    ///                 var qosResults = await QosService.Instance.GetSortedQosResultsAsync(serviceName, null);
    ///             }
    ///             catch (Exception e)
    ///             {
    ///                 Debug.Log(e);
    ///             }
    ///         }
    ///     }
    /// }
    /// ]]>
    /// </code>
    /// </example>
    public static class QosService
    {
        /// <summary>
        /// A static instance of the QoS Service.
        /// </summary>
        public static IQosService Instance { get; internal set; }
    }

    /// <summary>
    /// An interface that allows access to QoS measurements. Your game code should use this interface through
    /// `QosService.Instance`.
    /// </summary>
    public interface IQosService
    {
        /// <summary>
        /// Gets sorted QoS measurements the specified service and regions.
        /// </summary>
        /// <remarks>
        /// `GetSortedQosResultsAsync` doesn't consider the returned regions until applying the services and regions filters.
        ///
        /// If you specify regions, it only includes those regions.
        /// </remarks>
        /// <param name="service">The service to query regions for QoS. `GetSortedQosResultsAsync` only uses measures
        /// regions configured for the specified service.</param>
        /// <param name="regions">The regions to query for QoS. If not null or empty, `GetSortedQosResultsAsync` only uses
        /// regions in the intersection of the specified service and the specified regions for measurements.</param>
        /// <returns>Returns the sorted list of QoS results, ordered from best to worst.</returns>
        Task<IList<QosResult>> GetSortedQosResultsAsync(string service, IList<string> regions);
    }
}
