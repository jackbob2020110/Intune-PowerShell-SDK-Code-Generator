﻿// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Graph.GraphODataPowerShellSDKWriter.Generator.Models
{
    public enum CmdletOperationType
    {
        Get,
        GetOrSearch,
        GetStream,
        Post,
        PutRefToSingleEntity,
        PostRefToCollection,
        UpdateStream,
        Patch,
        Delete,
        FunctionReturningEntity,
        FunctionReturningCollection,
        Action,
    }
}
