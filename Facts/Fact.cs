﻿using System;
using System.Collections.Generic;

namespace Theraot.Facts
{
    public class Fact
    {
        public static IEnumerable<Tuple<T1, T2>> Query<T1, T2>(IFactCheckBase<T1, T2> check)
        {
            throw new System.NotImplementedException();
        }

        public static void Remove<T1, T2>(IFactCheckBase<T1, T2> p0)
        {
            throw new NotImplementedException();
        }
    }
}