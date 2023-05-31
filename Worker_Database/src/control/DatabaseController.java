package control;

import java.sql.Connection;
import java.util.Vector;

import model.ConnectDatabase;
import model.Queries;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class DatabaseController {
    
    private Connection conn;
    private ConnectDatabase connDb;

    public DatabaseController() {



    }

    private void connect() {

        connDb = new ConnectDatabase();
        connDb.connect();

        conn = connDb.getConnection();


    }

    private void closeConnect() {

        connDb.closeConnect();

    }

    public Vector<Vector<Object>> getWorkerData() {

        connect();
        Queries queries = new Queries();
        String sql = queries.getWorkers();

        Vector<Vector<Object>> workerData = new Vector<>();

        Vector<Object> row;

        try {
            
            Statement statement = conn.createStatement();
            ResultSet rs = statement.executeQuery(sql);


            while(rs.next()){

                row = new Vector<>();
                row.add(rs.getString(1));
                row.add(rs.getString(2));
                row.add(rs.getString(3));
                row.add(rs.getString(4));
                row.add(rs.getString(5));

                workerData.add(row);
                row = null;
            }


        } catch (Exception ex) {
            
            ex.printStackTrace();
        }


        closeConnect();

        return workerData;


    }


}
