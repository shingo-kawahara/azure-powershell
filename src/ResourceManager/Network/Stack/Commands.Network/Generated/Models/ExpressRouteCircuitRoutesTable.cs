// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit
    /// </summary>
    public partial class ExpressRouteCircuitRoutesTable
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitRoutesTable() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitRoutesTable(string nextHopType, string addressPrefix = default(string), string nextHopIP = default(string), string asPath = default(string))
        {
            AddressPrefix = addressPrefix;
            NextHopType = nextHopType;
            NextHopIP = nextHopIP;
            AsPath = asPath;
        }

        /// <summary>
        /// Gets AddressPrefix.
        /// </summary>
        [JsonProperty(PropertyName = "addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets NextHopType. Possible values for this property include:
        /// 'VirtualNetworkGateway', 'VnetLocal', 'Internet',
        /// 'VirtualAppliance', 'None'.
        /// </summary>
        [JsonProperty(PropertyName = "nextHopType")]
        public string NextHopType { get; set; }

        /// <summary>
        /// Gets NextHopIP.
        /// </summary>
        [JsonProperty(PropertyName = "nextHopIP")]
        public string NextHopIP { get; set; }

        /// <summary>
        /// Gets AsPath.
        /// </summary>
        [JsonProperty(PropertyName = "asPath")]
        public string AsPath { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (NextHopType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NextHopType");
            }
        }
    }
}
