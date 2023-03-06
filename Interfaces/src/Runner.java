public class Runner {
    public static void main(String[] args) {

        Cat cat = new Cat();
        Dog dog = new Dog();
        Garden garden = new Garden(cat);

        garden.playAnimal();
        garden.speakAnimal();

        Garden garden2 = new Garden(dog);

        garden2.speakAnimal();
        garden2.playAnimal();


        //virus
        //másik
    }
}
