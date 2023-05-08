class SzoloSzureteloMunkas implements BetakaritoMunkas{
  private String nev;
  private int oradij;
  private int sebesseg;
  private double lassulas;
  private BetakaritoMunkas parja=null;
  public SzoloSzureteloMunkas(String nev,int oradij,int sebesseg, double lassulas){
    this.nev=nev; //a majdani p�ld�ny kapja meg a param�terk�nt megadott konkr�tumot
    this.oradij=oradij;
    this.sebesseg=sebesseg;
    this.lassulas=lassulas;
  }
  public int getSebesseg(){ //az�rt ker�lt el�bbre, hogy miel�tt haszn�ln�nk m�r legyen meghat�rozott
    return sebesseg*(int)lassulas; //az egy�rtelm� esetekben nem sz�ks�ges a this min�s�t�s
  }
  public BetakaritoMunkas osszehasonlit(BetakaritoMunkas bm){
    if(bm.getSebesseg() < this.getSebesseg()){
      return bm;
    }else{
      return this;
    }
  }
  public void setParja(BetakaritoMunkas bm){

    if(!bm.getParja().equals(null)){

      bm.getParja().setParja(null);
      this.setParja(bm);
    }

    this.parja=bm;
  }

  public void parbaAllit(BetakaritoMunkas bm){
    
    if(!this.equals(bm)){  //megoldani, hogy lehessen új párt állítani lsd(??) jegyzet, van-e párja annak amit új párnak akarok állítani, azt rendezni ötlet:<- ennek 2 paraméter

      this.setParja(bm);
    
      bm.setParja(this);
    }
    else{

      System.out.println("Saját magának nem lehet párja!");
    }

  }
  public String getNev(){
    return this.nev;
  }
  public int getOradij(){
    return this.oradij;
  }
  public BetakaritoMunkas getParja(){
    return this.parja;
  }
  //a getter-ek ellen�rz�tten teszik el�rhet�v� a meghat�rozott tartalmakat, m�g a setter-ek szint�n ellen�rizett keretek k�z�tt a m�dos�t�sokat
  @Override
  public String toString(){ //az Object, mindenki �se oszt�lyban szerepl� fel�ldefini�l�sa
    return nev+" - "+oradij+" - "+sebesseg;
  }
}