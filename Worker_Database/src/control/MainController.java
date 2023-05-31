package control;

import model.ConnectDatabase;

public class MainController {
    
    private FormController formCtrl;
    private DatabaseController dbCtrl;

    public MainController() {

        dbCtrl = new DatabaseController();
        formCtrl = new FormController( dbCtrl );

        // ConnectDatabase conne = new ConnectDatabase();
        // conne.connect();

    }


}
