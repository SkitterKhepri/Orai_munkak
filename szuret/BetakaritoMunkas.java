interface BetakaritoMunkas{
  String osszehasonlit(BetakaritoMunkas bm); //ez egy f�ggv�ny, ami egy BetakaritoMunkas t�pus� �rt�ket ad vissza
  void setParja(BetakaritoMunkas bm);
  void parbaAllit(BetakaritoMunkas bm); //ez pedig egy elj�r�s, amely az adott munk�s p�rjak�nt meghat�rozza a param�terk�nt megadottat
  String getNev();
  int getOradij();
  int getSebesseg();
  String getParja();
}
