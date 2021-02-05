using System;
using System.Collections.Generic;

namespace BlazorTabulator.Data
{
    public class TabulatorData
    {
        public IEnumerable<Object> Dataset { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();
        public TabulatorData()
        {

        }
    }
}
