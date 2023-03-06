public class App {
    public static void main(String[] args) throws Exception {
        
        Worker worker = new Worker();

        worker.name = "Béla";
        worker.age = 33;
        worker.salary = 450000;
        worker.working();

        System.out.println(worker.name);
        System.out.println(worker.age);
        System.out.println(worker.salary + "\n");


        Engineer eng = new Engineer();

        eng.name = "Pista";
        eng.age = 46;
        eng.salary = 800000;
        eng.gradeNumber = "AA12345";
        eng.working();

        System.out.println(eng.name);
        System.out.println(eng.age);
        System.out.println(eng.salary);
        System.out.println(eng.gradeNumber + "\n");

        SeniorEngineer sEng = new SeniorEngineer();

        sEng.name = "Mari";
        sEng.age = 51;
        sEng.salary = 950000;
        sEng.gradeNumber = "AAAA4321";
        sEng.bonus = 600;

        System.out.println(sEng.name);
        System.out.println(sEng.age);
        System.out.println(sEng.salary);
        System.out.println(sEng.gradeNumber);
        System.out.println(sEng.bonus);

    }
}
