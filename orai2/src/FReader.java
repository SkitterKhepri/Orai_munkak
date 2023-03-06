import java.io.FileReader;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class FReader {
    
    private String fileName;

    FReader(String fileName){

        this.fileName = fileName;

    }

    public ArrayList<Worker> readFile(){

        FileReader fReader = null;

        try {
            
            fReader = new FileReader(fileName);

        } catch (FileNotFoundException ex) {
            
            System.out.println("Hibás file név");

        }

        Scanner scan = new Scanner(fReader);
        String row = scan.nextLine();


        ArrayList<Worker> workerList = new ArrayList<>();

        while (scan.hasNext()) {
            
            row = scan.nextLine();
            String[] rowSp = row.split(":");

            Worker worker = new Worker();
            worker.setName(rowSp[0]);
            worker.setCity(rowSp[1]);
            worker.setAddress(rowSp[2]);
            worker.setSalary(rowSp[3]);
            worker.setBonus(rowSp[4]);
            worker.setBorn(rowSp[5]);
            worker.setHired(rowSp[6]);

            workerList.add(worker);
        }

        return workerList;

    }


}
