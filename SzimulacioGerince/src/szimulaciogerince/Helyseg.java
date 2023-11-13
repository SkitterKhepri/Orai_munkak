package szimulaciogerince;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Diak
 */
public class Helyseg {
    
    private static int szamlalo = 0;
    private int h_id;
    private String megnevezes;
    private int alapTerulet;
    
    public Helyseg(/*int h_id, */String megnevezes, int alapTerulet){
        
        szamlalo++;
        this.h_id = szamlalo;
        this.megnevezes = megnevezes;
        this.alapTerulet = alapTerulet;
        
    }
    
    public float adatSzolgaltatas(){
    
        return (float)Math.random()*30;
        
    }
    
}
