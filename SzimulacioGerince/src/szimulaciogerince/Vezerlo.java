/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package szimulaciogerince;

import java.awt.event.ActionListener;
import java.util.TimerTask;


/**
 *
 * @author Diak
 */
public class Vezerlo extends TimerTask {

    private static int aktualis = 1;
    private ActionListener[] adatSzolgaltato = new ActionListener[10];
    //private List<ActionListener>
    
    @Override
    public void run() {
        for(int i =0; i < adatSzolgaltato.length; i++){
            if(adatSzolgaltato[i] != null){
                adatSzolgaltato[i].actionPerformed(new ActionEvent());
            }
        }
    }
    
    public void Feliratkozas(ActionListener al){
    
        
        adatSzolgaltato[aktualis] = al;
    
    }
    
}
