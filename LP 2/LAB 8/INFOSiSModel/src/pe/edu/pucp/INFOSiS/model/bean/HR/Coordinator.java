package pe.edu.pucp.INFOSiS.model.bean.HR;

import java.util.Date;

/**
 * 
 */
public class Coordinator extends Employee {

    public Coordinator() {
    }

    private String department;

    public Coordinator(String department, String idPUCP, String emailPUCP, String address, String homePhone, Date birthDate, String idNumber, String idType, String firstName, String middleName, String primaryLastName, String secondLastName, char gender, String email, String cellPhoneNumber) {
        super(idPUCP, emailPUCP, address, homePhone, birthDate, idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.department = department;
    }

    public String getDepartment() {
        return department;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    
    
}