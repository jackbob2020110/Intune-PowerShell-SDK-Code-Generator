﻿// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;

    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that support $select and $expand query parameters.
    /// </summary>
    public abstract class GetCmdlet : ODataPowerShellSDKCmdletBase
    {
        public const string OperationName = "Get";

        /// <summary>
        /// The list of $select query option values (i.e. property names).
        /// </summary>
        [Parameter(ParameterSetName = GetCmdlet.OperationName)]
        [Parameter(ParameterSetName = GetOrSearchCmdlet.OperationName)]
        public string[] Select { get; set; }

        /// <summary>
        /// The list of $expand query option values (i.e. property names).
        /// </summary>
        [Parameter(ParameterSetName = GetCmdlet.OperationName)]
        [Parameter(ParameterSetName = GetOrSearchCmdlet.OperationName)]
        public string[] Expand { get; set; }

        internal override string GetHttpMethod()
        {
            return "GET";
        }

        internal override IDictionary<string, string> GetUrlQueryOptions()
        {
            IDictionary<string, string> queryOptions = base.GetUrlQueryOptions();
            if (Select != null && Select.Any())
            {
                queryOptions.Add(ODataConstants.QueryParameters.Select, string.Join(",", Select));
            }
            if (Expand != null && Expand.Any())
            {
                queryOptions.Add(ODataConstants.QueryParameters.Expand, string.Join(",", Expand));
            }

            return queryOptions;
        }
    }
}