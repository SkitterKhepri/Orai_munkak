/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package szimulaciogerince;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 *
 * @author Diak
 */
public class SzimulacioGerince {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        /*Helyseg h = new Helyseg(1, "tanterem", 30);*/
        
        Vezerlo vez = new Vezerlo();
        
        for(int i = 1; i < 10; i++){
            Helyseg h = new Helyseg("tanterem"+i, (int)(Math.floor(Math.random()*30+2)));
            //System.out.print(h);
            ActionListener al = new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    h.adatSzolgaltatas();
                }
            };
            vez.Feliratkozas(al);
        }
        
    }
    
}
