// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.HttpRepl.Extensions
{
    public static class TimeSpanExtensions
    {
        public static string FormatDuration(this TimeSpan timeSpan)
        {
            if (timeSpan.TotalSeconds < 1d)
            {
                return $"{(int)timeSpan.TotalMilliseconds} ms";
            }
            else
            {
                return $"{Math.Round(timeSpan.TotalSeconds, 2)} s";
            }
        }
    }
}
