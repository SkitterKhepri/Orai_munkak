package model;

import java.util.Vector;

public class TableData {
    
    //private Vector<String> columnNames;

    public TableData() {}

    public Vector<String> getTableColumnNames() {

        Vector<String> columnNames = new Vector<>();

        columnNames.add( "Név" );
        columnNames.add( "Születés" );
        columnNames.add( "Fizetés" );
        columnNames.add( "Beosztás" );
        columnNames.add( "Város" );

        return columnNames;
    }
}
