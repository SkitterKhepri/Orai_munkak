public class Garden {
    
    Animal animal;

    public Garden(Animal animal){

        this.animal = animal;

    }


    public void playAnimal(){

        animal.play();

    }

    public void speakAnimal(){

        animal.speak();

    }

}
