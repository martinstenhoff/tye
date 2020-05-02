﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
    public class IngressHostMetadata
    {
        public IngressHostMetadata(params string[] hosts)
        {
            Hosts = new List<string>(hosts).AsReadOnly();
        }

        public IReadOnlyList<string> Hosts { get; }
    }
}