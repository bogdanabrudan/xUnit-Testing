﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations.Tests
{
    public static class TestDataShare
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
            }
        }
    }
}
