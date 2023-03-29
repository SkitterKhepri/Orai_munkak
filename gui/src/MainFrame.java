import javax.swing.JFrame;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;

public class MainFrame extends JFrame{
    
    MainFrame(){

        initComponents();

    }

    private void initComponents(){

        this.setSize(400, 300);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setTitle("Első ablak");
        this.setLayout(null);

        JLabel label01 = new JLabel();
        label01.setText("Szöveg");
        label01.setBounds(110, 110, 50, 30);
        this.add(label01);


        JTextField textField01 = new JTextField(10);
        textField01.setBounds(170, 110, 100, 30);
        this.add(textField01);


        JButton button01 = new JButton();
        button01.setText("Gomb!");
        button01.setBounds(150, 150, 80, 30);
        this.add(button01);

    }

}
