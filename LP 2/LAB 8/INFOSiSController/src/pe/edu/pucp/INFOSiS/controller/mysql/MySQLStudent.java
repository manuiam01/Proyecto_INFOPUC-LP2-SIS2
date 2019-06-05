/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOStudent;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;

/**
 *
 * @author tkuser
 */
public class MySQLStudent implements DAOStudent{
    @Override
    public int insertStudent(Student student) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cStmt = con.prepareCall("{call INSERT_STUDENT(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.registerOutParameter("_idStudent", java.sql.Types.INTEGER);
            cStmt.setString("_idNumber", student.getIdNumber());
            cStmt.setInt("_idType", student.getIdType());
            cStmt.setString("_firstName", student.getFirstName());
            cStmt.setString("_middleName", student.getMiddleName());
            cStmt.setString("_primaryLastName", student.getPrimaryLastName());
            cStmt.setString("_secondLastName", student.getSecondLastName());
            cStmt.setString("_gender", student.getGender());
            cStmt.setString("_email", student.getEmail());
            cStmt.setString("_cellPhoneNuber", student.getCellPhoneNumber());
            cStmt.setString("_homePhone", student.getHomePhone());
            cStmt.setString("_address", student.getAddress());
            cStmt.execute();
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int updateStudent(Student student, int id) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cStmt = con.prepareCall("{call UPDATE_STUDENT(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.setInt("_idStudent", id);
            cStmt.setString("_idNumber", student.getIdNumber());
            cStmt.setInt("_idType", student.getIdType());
            cStmt.setString("_firstName", student.getFirstName());
            cStmt.setString("_middleName", student.getMiddleName());
            cStmt.setString("_primaryLastName", student.getPrimaryLastName());
            cStmt.setString("_secondLastName", student.getSecondLastName());
            cStmt.setString("_gender", student.getGender());
            cStmt.setString("_email", student.getEmail());
            cStmt.setString("_cellPhoneNuber", student.getCellPhoneNumber());
            cStmt.setString("_homePhone", student.getHomePhone());
            cStmt.setString("_address", student.getAddress());
            cStmt.execute();
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

}
