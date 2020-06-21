﻿using System.Collections.Generic;

namespace Air.Mapper
{
    public static partial class Mapper<S, D>
    {
        public static Dictionary<DK, D> ToDictionary<SK, DK>(IEnumerable<KeyValuePair<SK, S>> source)
        {
            Dictionary<DK, D> returnValue = null;
            if (source == null)
                return returnValue;

            returnValue = new Dictionary<DK, D>();

            foreach (KeyValuePair<SK, S> sourceEntry in source)
                returnValue.Add(
                    Mapper<SK, DK>.Map(sourceEntry.Key),
                    CompiledFunc(sourceEntry.Value));

            return returnValue;
        }
    }
}
