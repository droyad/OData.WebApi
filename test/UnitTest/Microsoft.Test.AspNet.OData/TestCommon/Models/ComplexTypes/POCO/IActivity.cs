﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.Test.AspNet.OData.Common.Models
{
    public interface IActivity
    {
        string ActivityName { get; set; }

        void DoActivity();
    }
}
