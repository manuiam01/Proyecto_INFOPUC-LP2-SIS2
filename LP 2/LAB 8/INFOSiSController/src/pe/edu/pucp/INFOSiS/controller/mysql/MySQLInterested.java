/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;

/**
 *
 * @author JEREMI
 */
public class MySQLInterested {
    
    public int insert(Interested interested){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_INTERESTED(?,?,?,?,?,?,?,?)}");
            cs.setString(1,interested.getFirstName());
            cs.setString(2,interested.getPrimaryLastName());
            cs.setString(3,interested.getMiddleName());
            cs.setString(4,interested.getSecondLastName());
            cs.setString(5,interested.getGender());
            cs.setString(6,interested.getEmail());
            cs.setString(7,interested.getCellPhoneNumber());
            cs.setString(8,interested.getIdNumber());
            cs.registerOutParameter("_idInterested", java.sql.Types.INTEGER);
            result = cs.executeUpdate();
            int id = cs.getInt("idInterested");
            interested.setId(id);
            ArrayList<CourseType> courses = new ArrayList<CourseType>();
            courses = interested.getCourseTypes();
            for(CourseType c : courses){
                String sql = "INSERT into InterestedxCourseType(idInterested,idCourseType) values (?,?);";
                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1,interested.getIdNumber());
                ps.setInt(2,c.getId());
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    public int update(Interested interested){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_INTERESTED(?,?,?,?,?,?,?)}");
            cs.setString(1,interested.getFirstName());
            cs.setString(2,interested.getPrimaryLastName());
            cs.setString(3,interested.getMiddleName());
            cs.setString(4,interested.getSecondLastName());
            cs.setString(5,interested.getGender());
            cs.setString(6,interested.getEmail());
            cs.setString(7,interested.getCellPhoneNumber());
            result = cs.executeUpdate();
            ArrayList<CourseType> courses = new ArrayList<CourseType>();
            courses = interested.getCourseTypes();
            for(CourseType c : courses){
                String sql = "INSERT into InterestedxCourseType(idInterested,idCourseType) values (?,?);";
                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1,interested.getIdNumber());
                ps.setInt(2,c.getId());
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    public int disable(Interested interested){
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "UPDATE Interested set isUnsuscribed = ? where idNumber = ?;";
            PreparedStatement ps = con.prepareStatement(sql);
            ps.setInt(1,0);
            ps.setString(2,interested.getIdNumber());
//            cs.setString(1,course.getName());
//            cs.setBoolean(2,course.getIsActive());
//            cs.setObject(3,course.getSyllabus());
//            cs.setInt(4,id);
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return 0;
    }
    
    public ArrayList<Interested> queryAll(){
        ArrayList<Interested> interested = new ArrayList<Interested>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interns";
            ResultSet rs = sentence.executeQuery(query);
//            while(rs.next()){
//                Intern intern = new Intern();
//                String idIntern = rs.getString("idIntern");
//                int idUser = rs.getInt("idUser");      
//                String idNumber = rs.getString("idNumber");
//                String firstName = rs.getString("firstName");
//                String middleName = rs.getString("middleName");
//                String primaryLastName = rs.getString("primaryLastName");
//                String secondLastName = rs.getString("secondLastName");
//                String emailPUCP = rs.getString("emailPUCP");
//      //          intern.setIdIntern(idIntern);
//                intern.setFirstName(firstName);
//                intern.setMiddleName(middleName);
//                intern.setPrimaryLastName(primaryLastName);
//                intern.setSecondLastName(secondLastName);
//                intern.setEmailPUCP(emailPUCP);
//                interns.add(intern);
//            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }    
        return interested;
    }
    
    public ArrayList<Interested> queryAllByCourseType(CourseType coursetype){
        ArrayList<Interested> interested = new ArrayList<Interested>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interns";
            ResultSet rs = sentence.executeQuery(query);
//            while(rs.next()){
//                Intern intern = new Intern();
//                String idIntern = rs.getString("idIntern");
//                int idUser = rs.getInt("idUser");      
//                String idNumber = rs.getString("idNumber");
//                String firstName = rs.getString("firstName");
//                String middleName = rs.getString("middleName");
//                String primaryLastName = rs.getString("primaryLastName");
//                String secondLastName = rs.getString("secondLastName");
//                String emailPUCP = rs.getString("emailPUCP");
//      //          intern.setIdIntern(idIntern);
//                intern.setFirstName(firstName);
//                intern.setMiddleName(middleName);
//                intern.setPrimaryLastName(primaryLastName);
//                intern.setSecondLastName(secondLastName);
//                intern.setEmailPUCP(emailPUCP);
//                interns.add(intern);
//            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return interested;
    }
}
