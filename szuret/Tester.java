//import szuret.*;

class Tester
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

        SzoloSzureteloMunkas munkas3 = new SzoloSzureteloMunkas("Béla",1000,10,0.2);
        SzoloSzureteloMunkas munkas4 = new SzoloSzureteloMunkas("Géza",10000,90,0.4);
        System.out.println("Egyenlo: " +munkas3.equals(munkas1));  // helyes: true
        System.out.println("Egyenlo null-al: " + munkas1.equals(null));  // helyes: false
/*
        SzoloSzuret szuret1 = new SzoloSzuret(2,5000,0.2);
        SzoloSzuret szuret2 = new SzoloSzuret(500);
        szuret1.addMunkas(munkas1);
        System.out.println("Add, find: " + szuret1.findMunkas(munkas3));  // helyes: true
        szuret1.addMunkas(munkas3);
        szuret1.addMunkas(munkas2);
        System.out.println("Add, find: " + szuret1.findMunkas(munkas2));  // helyes: true
        szuret1.addMunkas(munkas4);
        System.out.println("Add, find: " + szuret1.findMunkas(munkas4));  // helyes: false

        System.out.println("Haszon: " + szuret1.calcHaszon());  // helyes: 0
        System.out.println("Idotartam: " + szuret1.calcIdotartam());  // helyes: 0

        szuret2.addMunkas(munkas2);
        szuret2.addMunkas(munkas4);  
        System.out.println("Munkasok szama: " + szuret2.getMunkasokSzama());  // helyes: 2

        SzoloSzuret.setTermesMennyisege(4);
        SzoloSzuret.setFelvasarlasiAr(65);
        SzoloSzuret.setAszuAra(4000);

        System.out.println("Haszon: " + szuret1.calcHaszon());  // helyes: 15632000
        System.out.println("Idotartam: " + szuret1.calcIdotartam());  // helyes: 128

        System.out.println("Haszon: " + szuret2.calcHaszon());  // helyes: -142000
        System.out.println("Idotartam: " + szuret2.calcIdotartam());  // helyes: 17

        System.out.println("Leglassabb: " + szuret2.leglassabb());  // helyes: Geza

        */
	}
}