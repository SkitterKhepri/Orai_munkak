interface Pelda1{
  void Metodus1();
  String Metodus2();
}

interface Pelda2{
  int Metodus3();
}

class Osztaly implements Pelda1, Pelda2{
  String nev;
  int ertek;
  public Osztaly(String nev, int ertek){
    this.nev=nev;
    this.ertek=ertek;
  }
  //@Override
  public void Metodus1(){
    System.out.println("A Példa1-ből származó, itt konkretizált, eljárás-típusú alprogram");
  }
  //@Override  
  public String Metodus2(){
    return this.nev;
  }
  //@Override  
  public int Metodus3(){
    return this.ertek;
  }
}

public class Program{
  public static void main(String[] args){
    Osztaly o=new Osztaly("Bálint Dezső",2023);
    o.Metodus1();
    System.out.println("A Pelda1-ből származó példány nevét kiíró metódus eredménye: "+o.Metodus2());
    System.out.println("A Pelda2-ből származó példányértékét kiíró metódus eredménye: "+o.Metodus3());
  }
}
