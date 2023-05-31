package control;

import model.TableData;
import view.MainFrame;
import java.util.Vector;
import javax.swing.table.DefaultTableModel;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class FormController implements ActionListener {
    
    private MainFrame mainFrm;
    private DatabaseController dbCtrl;
    private TableData tblData;

    public FormController( DatabaseController dbCtrl ) {

        this.dbCtrl = dbCtrl;
        start();
        bindActionListener();
    }

    private void start() {

        Vector<String> columnNames = new Vector<>();
        tblData = new TableData();
        columnNames = tblData.getTableColumnNames();

        mainFrm = new MainFrame();

        DefaultTableModel model = new DefaultTableModel(null, columnNames);
        mainFrm.getWorkerTable().setModel(model);
        mainFrm.setVisible(true);

        
    }

    private void bindActionListener() {

        mainFrm.getExitBtn().addActionListener( this );
        mainFrm.getLoadBtn().addActionListener( this );
    }

    private void exit() {

        System.exit( 0 );

    }

    private void loadData() {

        
        Vector<String> columnNames = new Vector<>();
        tblData = new TableData();
        columnNames = tblData.getTableColumnNames();
        Vector<Vector<Object>> workerData = new Vector<>();
        workerData = dbCtrl.getWorkerData();


        DefaultTableModel model = new DefaultTableModel(workerData, columnNames);
        mainFrm.getWorkerTable().setModel(model);
       
    }

    @Override
    public void actionPerformed( ActionEvent event ) {

        if( event.getSource() == mainFrm.getExitBtn() ) {
            exit();
        }else if( event.getSource() == mainFrm.getLoadBtn() ) {
            loadData();
        }
    }
}
