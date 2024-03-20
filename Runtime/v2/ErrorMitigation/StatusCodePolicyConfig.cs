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
using UnityEngine;

namespace Unity.Services.Qos.V2.ErrorMitigation
{

    /// <summary>
    /// StatusCodePolicyConfig is a class that represents and stores how certain
    /// status codes should be handled. 
    /// </summary>
    internal class StatusCodePolicyConfig
    {   
        IDictionary<long, bool> _statusCodesToHandleDict = new Dictionary<long, bool>()
        {
            {408, true}, // Request Timeout
            {429, true}, // Too Many Requests
            {502, true}, // Bad Gateway
            {503, true}, // Service Unavailable
            {504, true}  // Gateway Timeout
        };

        /// <summary>
        /// Register a status code that should be handled.
        /// </summary>
        /// <param name="code">A long representing the status code to be handled.</param>
        public void HandleStatusCode(long code)
        {
            if (_statusCodesToHandleDict.ContainsKey(code))
            {
                _statusCodesToHandleDict[code] = true;
            }
            else
            {
                _statusCodesToHandleDict.Add(new KeyValuePair<long, bool>(code, true));
            }
        }
        
        /// <summary>
        /// Register a status code that should not be handled. 
        /// </summary>
        /// <param name="code">A long representing the status code to be handled.</param>
        public void DontHandleStatusCode(long code)
        {
            if (_statusCodesToHandleDict.ContainsKey(code))
            {
                _statusCodesToHandleDict[code] = false;
            }
            else
            {
                _statusCodesToHandleDict.Add(new KeyValuePair<long, bool>(code, false));
            }
        }

        /// <summary>
        /// Clear all status codes from the policy.
        /// </summary>
        public void Clear()
        {
            _statusCodesToHandleDict.Clear();
        }

        /// <summary>
        /// Checks if the status code provided is in the list of supported
        /// status codes.
        /// </summary>
        /// <param name="code">A long representing the status code to be handled.</param>
        /// <returns>Returns true if the status code is in the list of handled status codes.</returns>
        public bool IsHandledStatusCode(long code)
        {
            return _statusCodesToHandleDict.Contains(new KeyValuePair<long, bool>(code, true));
        }
    }
}
