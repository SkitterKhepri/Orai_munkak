import javax.swing.JFrame;
import java.awt.*;
import java.awt.event.*;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.GroupLayout;
import javax.swing.JButton;

public class MainFrame extends JFrame{
    
    MainFrame(){

        initComponents();

    }

    private void initComponents(){

        this.setSize(600, 400);
        this.setLocation(700, 350);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setTitle("Első ablak");
        this.setLayout(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        JPanel j1 = new JPanel();
        JPanel j2 = new JPanel();
        JPanel j3 = new JPanel();
        JPanel j4 = new JPanel();
        JButton jb1 = new JButton("Hova?");
        GroupLayout gl = new GroupLayout(j4);
        jb1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e){
                for (int i = 0; i < 7; i++) {
                    JLabel lab = new JLabel("lab"+i);
                    j4.add(lab);
                    j4.revalidate();
                }
            }
        });
        j1.add(jb1);
        j1.setBackground(Color.RED);
        j2.setBackground(Color.blue);
        j3.setBackground(Color.green);
        j4.setBackground(Color.pink);

        gbc.fill = GridBagConstraints.BOTH;

        gbc.weightx = 1;
        gbc.weighty = 1;
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.gridwidth= 3;
        gbc.gridheight= 1;
        this.add(j1,gbc);

        gbc.weightx = 3;
        gbc.weighty = 3;
        gbc.gridx = 1;
        gbc.gridy = 1;
        gbc.gridwidth= 1;
        gbc.gridheight= 1;
        this.add(j2, gbc);

        gbc.weightx = 1;
        gbc.weighty = 3;
        gbc.gridx = 0;
        gbc.gridy = 1;
        gbc.gridwidth= 1;
        gbc.gridheight= 1;
        this.add(j3, gbc);

        gbc.weightx = 1;
        gbc.weighty = 3;
        gbc.gridx = 2;
        gbc.gridy = 1;
        gbc.gridwidth= 1;
        gbc.gridheight= 1;
        this.add(j4, gbc);

        /*
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


        */

    }

}
