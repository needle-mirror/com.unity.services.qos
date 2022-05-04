//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Qos.Http;



namespace Unity.Services.Qos.Models
{
    /// <summary>
    /// QosServersList model
    /// </summary>
    [Preserve]
    [DataContract(Name = "QosServersList")]
    internal class QosServersList
    {
        /// <summary>
        /// Creates an instance of QosServersList.
        /// </summary>
        /// <param name="servers">An array of connection information for QoS servers.</param>
        [Preserve]
        public QosServersList(List<QosServer> servers)
        {
            Servers = servers;
        }

        /// <summary>
        /// An array of connection information for QoS servers.
        /// </summary>
        [Preserve]
        [DataMember(Name = "servers", IsRequired = true, EmitDefaultValue = true)]
        public List<QosServer> Servers{ get; }
    
    }
}
