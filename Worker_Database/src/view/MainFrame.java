package view;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTable;
import javax.swing.JScrollPane;

import java.awt.GridLayout;
import java.awt.BorderLayout;
import java.awt.FlowLayout;

public class MainFrame extends JFrame {
    
    private JButton exitBtn;
    private JButton loadBtn;
    private JTable workerTbl;
    
    public MainFrame() {
        initComponents();
    }

    private void initComponents() {

        this.setTitle( "Dolgozók" );
        this.setSize( 500, 400 );
        this.setDefaultCloseOperation( EXIT_ON_CLOSE );
        this.setLocationRelativeTo( null );
        this.setLayout( new GridLayout( 1, 1 ));
        
        JPanel mainPnl = new JPanel();
        mainPnl.setLayout( new BorderLayout() );
        //this.add( mainPnl );
        
        JPanel northPnl = new JPanel();
        northPnl.setSize( 500, 15 );
        mainPnl.add( northPnl, BorderLayout.NORTH );

        JPanel eastPnl = new JPanel();
        eastPnl.setSize( 15, 400 );
        mainPnl.add( eastPnl, BorderLayout.EAST );

        JPanel southPnl = new JPanel();
        southPnl.setSize( 470, 30 );
        southPnl.setLayout( new FlowLayout( FlowLayout.RIGHT ));
        loadBtn = new JButton( "Betöltés" );
        exitBtn = new JButton( "Kilépés" );
        southPnl.add(loadBtn );
        southPnl.add( exitBtn );
        mainPnl.add( southPnl, BorderLayout.SOUTH );

        JPanel westPnl = new JPanel();
        westPnl.setSize( 15, 400 );
        mainPnl.add( westPnl, BorderLayout.WEST );

        JPanel centerPnl = new JPanel();
        workerTbl = new JTable();
        JScrollPane scroll = new JScrollPane( workerTbl );
        centerPnl.add( scroll );
        mainPnl.add( centerPnl, BorderLayout.CENTER );

        this.add( mainPnl );
    }

    public JButton getExitBtn() { return exitBtn; }
    public JButton getLoadBtn() { return loadBtn; }
    public JTable getWorkerTable() { return workerTbl; }
}
