import java.io.Reader;
import java.util.ArrayList;

import javax.swing.plaf.synth.SynthPasswordFieldUI;

public class EmployeeController {
    
    EmployeeController(){

        start();

    }


    private void start(){

        ArrayList<Worker> workerList = new ArrayList<>();

        FReader reader = new FReader("dolgozok100.txt");
        reader.readFile();

        workerList = reader.readFile();
        countWorker(workerList);
        getSzolnokName(workerList);
        getSzegedSalarySum(workerList);
    }

    private void countWorker(ArrayList<Worker> workerList){

        int counter = 0;

        for(int i = 0; i < workerList.size(); i++){

            counter++;

        }

        System.out.println("A dolgozók létszáma: " + counter);

    }

    private void getSzolnokName (ArrayList<Worker> workerList){

        for (int i = 0; i < workerList.size(); i++) {
            
            if (workerList.get(i).getCity().matches("Szolnok")){

                System.out.println(workerList.get(i).getName());

            }

        }

    }

    private void getSzegedSalarySum (ArrayList<Worker> workerList){

        int sum = 0;

        for (int i = 0; i < workerList.size(); i++) {
            
            if (workerList.get(i).getCity().matches("Szeged")){

                String salaryStr = workerList.get(i).getSalary();
                int salary = Integer.parseInt(salaryStr);

                sum += salary;

            }

            
        }

        String sumStr = String.valueOf(sum);

        Writer writer = new Writer();
        writer.writeFile("SzegedFizu.txt", true, "Szegediek fizetése:");
        writer.writeFile("SzegedFizu.txt", true, "\n");
        writer.writeFile("SzegedFizu.txt", true, sumStr);



    }



}
