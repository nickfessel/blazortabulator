using System;
using Microsoft.AspNetCore.Components;

namespace BlazorTabulator.Data
{
    public class TabulatorColumnData: ComponentBase, IDisposable
    {
        private bool disposedValue;

        [Parameter] public string Title { get; set; }
        [Parameter] public string Field { get; set; }

        private  readonly TabulatorColumn col = new TabulatorColumn();

        public TabulatorColumnData()
        {

        }

        protected override void OnParametersSet()
        {
            col.field = Field;
            col.title = Title;
        }

        [CascadingParameter] public Tabulator OwnerTabulator { get; set; }

        protected override void OnInitialized()
        { 
            OwnerTabulator.tableData.Columns.Add(col);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    OwnerTabulator.tableData.Columns.Remove(col);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~TabulatorColumn()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
