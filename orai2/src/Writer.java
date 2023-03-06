import java.io.FileWriter;
import java.io.IOException;

public class Writer {
    
    public Writer(){



    }

    public void writeFile(String fileName, boolean mode, String data){

        try {
            
            FileWriter fWriter = new FileWriter(fileName, mode);
           
            fWriter.write(data);
            
            fWriter.close();

        } catch (Exception ex) {
            System.out.println("Hibás valami az írásnál");
        }

    }


}
