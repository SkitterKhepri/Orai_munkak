import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Connect {
    

    Connection conn;

    public Connect(){

        initComponents();
        conn = null;


    }

    private void initComponents(){

        String url = "jdbc:mysql://localhost:3306/szfesti_elso";


        try{

            Class.forName("com.mysql.jdbc.Driver");
            conn = DriverManager.getConnection(url, "szfesti", "titok");

        }

        catch(ClassNotFoundException ex){

            System.out.println("Driver nem található");

        }

        catch(SQLException ex){

            System.out.println("Hiba a kapcsolódás során");

        }

        if(conn != null){

            System.out.println("juhu");

        }
        else{

            System.out.println("nem juhu");

        }




    }


}
