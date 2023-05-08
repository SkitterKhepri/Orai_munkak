interface BetakaritoMunkas{
  BetakaritoMunkas osszehasonlit(BetakaritoMunkas bm); //ez egy függvény, ami egy BetakaritoMunkas típusú értéket ad vissza
  void setParja(BetakaritoMunkas bm);
  void parbaAllit(BetakaritoMunkas bm); //ez pedig egy eljárás, amely az adott munkás párjaként meghatározza a paraméterként megadottat
  String getNev();
  int getOradij();
  int getSebesseg();
}
