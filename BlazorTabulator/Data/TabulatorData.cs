using System;
using System.Collections.Generic;

namespace BlazorTabulator.Data
{
    public class TabulatorData
    {
        public IEnumerable<Object> Dataset { get; set; }
        public List<TabulatorColumn> Columns { get; set; } = new List<TabulatorColumn>();
        public TabulatorData()
        {

        }
    }
}
