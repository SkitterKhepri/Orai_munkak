class Tester1
{
    public static void main(String[] args)
    {
        SzoloSzureteloMunkas munkas1 = new SzoloSzureteloMunkas("Béla",5000,100,0.7);
        SzoloSzureteloMunkas munkas2 = new SzoloSzureteloMunkas("János",6000,120,0.6);
        System.out.println(munkas1.osszehasonlit(munkas2));  // helyes: Bela
        System.out.println(munkas2.getNev() + " sebessege: " + munkas2.getSebesseg());  // helyes: 72
        munkas1.parbaAllit(munkas2);
        System.out.println(munkas2.getNev() + " sebessege parban: " + munkas2.getSebesseg());  // helyes: 79
        System.out.println(munkas1.getNev() + " parja: " + munkas1.getParja());  // Bela parja Janos
        System.out.println(munkas2.getNev() + " parja: " + munkas2.getParja());  // Janos parja Bela
    }
}