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
    /// QosServersResponseBody model
    /// </summary>
    [Preserve]
    [DataContract(Name = "QosServersResponseBody")]
    internal class QosServersResponseBody
    {
        /// <summary>
        /// Creates an instance of QosServersResponseBody.
        /// </summary>
        /// <param name="data">data param</param>
        [Preserve]
        public QosServersResponseBody(QosServersList data)
        {
            Data = data;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public QosServersList Data{ get; }
    
    }
}

