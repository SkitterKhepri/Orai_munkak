package model;

public class Queries {
    
    public Queries() {

    }

    public String getWorkers() {

        String sql = "SELECT name, born, salary, role, city " +
        "FROM workers " +
        "INNER JOIN roles ON workers.roleid = roles.rid " +
        "INNER JOIN cities ON workers.cityid = cities.cid;";

        return sql;

    }
}
