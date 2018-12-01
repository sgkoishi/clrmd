﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.Diagnostics.Runtime.Interop
{
    [Flags]
    public enum DEBUG_OUTSYM : uint
    {
        DEFAULT = 0,
        FORCE_OFFSET = 1,
        SOURCE_LINE = 2,
        ALLOW_DISPLACEMENT = 4
    }
}