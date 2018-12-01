﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Diagnostics.Runtime.Interop
{
    public enum DEBUG_VSOURCE : uint
    {
        INVALID = 0,
        DEBUGGEE = 1,
        MAPPED_IMAGE = 2,
        DUMP_WITHOUT_MEMINFO = 3
    }
}