using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; }
        public TValue Value { get; }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
