package pe.edu.pucp.INFOSiS.model.bean;
import java.util.*;

/**
 * 
 */
public abstract class Person {

    /**
     * Default constructor
     */
    public Person() {
    }

    /**
     * 
     */
    private String idNumber;

    /**
     * 
     */
    private String idType;

    /**
     * 
     */
    private String firstName;

    /**
     * 
     */
    private String middleName;

    /**
     * 
     */
    private String primaryLastName;

    /**
     * 
     */
    private String secondLastName;

    /**
     * 
     */
    private char gender;

    /**
     * 
     */
    private String email;

    /**
     * 
     */
    private String cellPhoneNumber;

    public Person(String idNumber, String idType, String firstName, String middleName, String primaryLastName, String secondLastName, char gender, String email, String cellPhoneNumber) {
        this.idNumber = idNumber;
        this.idType = idType;
        this.firstName = firstName;
        this.middleName = middleName;
        this.primaryLastName = primaryLastName;
        this.secondLastName = secondLastName;
        this.gender = gender;
        this.email = email;
        this.cellPhoneNumber = cellPhoneNumber;
    }

    public String getIdNumber() {
        return idNumber;
    }

    public void setIdNumber(String idNumber) {
        this.idNumber = idNumber;
    }

    public String getIdType() {
        return idType;
    }

    public void setIdType(String idType) {
        this.idType = idType;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getMiddleName() {
        return middleName;
    }

    public void setMiddleName(String middleName) {
        this.middleName = middleName;
    }

    public String getPrimaryLastName() {
        return primaryLastName;
    }

    public void setPrimaryLastName(String primaryLastName) {
        this.primaryLastName = primaryLastName;
    }

    public String getSecondLastName() {
        return secondLastName;
    }

    public void setSecondLastName(String secondLastName) {
        this.secondLastName = secondLastName;
    }

    public char getGender() {
        return gender;
    }

    public void setGender(char gender) {
        this.gender = gender;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getCellPhoneNumber() {
        return cellPhoneNumber;
    }

    public void setCellPhoneNumber(String cellPhoneNumber) {
        this.cellPhoneNumber = cellPhoneNumber;
    }
    
    

}