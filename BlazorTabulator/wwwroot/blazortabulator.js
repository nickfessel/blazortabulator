var blazortabulator = {
    createTable: function (elem, tableColumns) {
       // alert(JSON.stringify(tableColumns));
       var table = new Tabulator(elem, {
           height: "311px",
           columns: tableColumns,
        });
     },
    updateTable: function (elem, tableData) {
        var tabulatorTable = Tabulator.prototype.findTable("#tabulatorTable")[0];
        tableData.people.forEach((t) => { tabulatorTable.addRow(t)}); // todo: allow any data, not just "people"
    }
};