var blazortabulator = {
    createTable: function (elem, tableData, tableColumns) {
        tableColumns.forEach((c, index) => {
                    if (c.field === "image.url") {
                        c.cellClick = (e, cell) => {
                            window.open(cell.getRow().getData().image.url);
                        };
                        c.formatter = function (cell, formatterParams, onRendered) {
                            return "<img width=" + cell.getRow().getData().image.width + " height=" + cell.getRow().getData().image.height + " src='" + cell.getRow().getData().image.url + "' alt='" + cell.getRow().getData().image.name + "' />"; 
                        };
                    }
        });

       var table = new Tabulator(elem, {
           height: "311px",
           layout: "fitDataFill",
           columns: tableColumns,
       });
        var tabulatorTable = Tabulator.prototype.findTable("#tabulatorTable")[0];
     },
    updateTable: function (elem, tableData) {
       var tabulatorTable = Tabulator.prototype.findTable("#tabulatorTable")[0];
        tableData.dataset.forEach((t) => { tabulatorTable.addRow(t) });
        tabulatorTable.redraw(true);
    }
};