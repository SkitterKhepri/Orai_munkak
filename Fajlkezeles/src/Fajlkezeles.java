import java.util.Scanner;
import java.io.FileReader;
import java.io.FileNotFoundException;

public class Fajlkezeles {
    public static void main(String[] args) throws Exception {
        
        String fileName = "gyumolcsok.txt";
        readFile( fileName );
        
    }

    private static void readFile( String fileName ) {

        try {

            FileReader reader = new FileReader( fileName );
            Scanner scan = new Scanner( reader );
            
            while( scan.hasNext() ) {

                String row = scan.nextLine();
                System.out.println( row );
            }
            
        } catch ( FileNotFoundException ex ) {
            
            System.out.println( "Nincs meg a " + fileName + " fájl." );

        }finally {

            System.out.println( "hello" );
        }
        

    }
}
