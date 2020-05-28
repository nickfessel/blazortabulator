using System;
using System.Collections.Generic;

namespace BlazorTabulator.Data
{
    public class TabulatorData
    {
        public IEnumerable<Person> People { get; set; }
        public List<TabulatorColumn> Columns { get; set; } = new List<TabulatorColumn>();
        public TabulatorData()
        {

        }
    }
}
