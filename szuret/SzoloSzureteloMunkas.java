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
    double finalSebesseg = 0;
    
    if (this.getParja() == null){

      finalSebesseg = sebesseg * lassulas;
    }
    else{

      finalSebesseg = sebesseg * lassulas * 1.1;
    }
    
    return (int)finalSebesseg;
    
  }
  public String osszehasonlit(BetakaritoMunkas bm){
    if(bm.getSebesseg() < this.getSebesseg()){
      return bm.getNev();
    }else{
      return this.getNev();
    }
  }
  public void setParja(BetakaritoMunkas bm){

    this.parja = bm;
  }

  public void parbaAllit(BetakaritoMunkas bm){
    
    if(!this.equals(bm)){  //megoldani, hogy lehessen új párt állítani lsd(??) jegyzet, van-e párja annak amit új párnak akarok állítani, azt rendezni ötlet:<- ennek 2 paraméter

      if (bm.getParja() == null && this.getParja() == null) {
        
        bm.setParja(this);
        this.setParja(bm);

      }
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
  public String getParja(){
    if (this.parja != null) {
      return this.parja.getNev();
    }
    else{

      return null;
    }
  }
  //a getter-ek ellen�rz�tten teszik el�rhet�v� a meghat�rozott tartalmakat, m�g a setter-ek szint�n ellen�rizett keretek k�z�tt a m�dos�t�sokat
  @Override
  public String toString(){ //az Object, mindenki �se oszt�lyban szerepl� fel�ldefini�l�sa
    return nev+" - "+oradij+" - "+sebesseg;
  }

  @Override
  public boolean equals(Object o){

    BetakaritoMunkas bm = (BetakaritoMunkas) o;

    if (bm != null) {
      
      if(this.getNev() == bm.getNev()){

        return true;
      }
      else{
  
        return false;
      }

    }
    else{

      return false;
    }

  }
}