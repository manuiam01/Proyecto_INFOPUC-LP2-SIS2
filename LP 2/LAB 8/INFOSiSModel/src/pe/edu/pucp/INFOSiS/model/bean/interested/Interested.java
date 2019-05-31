package pe.edu.pucp.INFOSiS.model.bean.interested;
import java.util.*;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.Person;

/**
 * 
 */
public class Interested extends Person {

    /**
     * Default constructor
     */
    public Interested() {
    }

    private ArrayList<CourseType> courseTypes;
    private boolean isUnsubscribed;

  

    public Interested(ArrayList<CourseType> courseTypes, boolean isUnsubscribed, String idNumber, String idType, String firstName, String middleName, String primaryLastName, String secondLastName, char gender, String email, String cellPhoneNumber) {
        super(idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.courseTypes = courseTypes;
        this.isUnsubscribed = isUnsubscribed;
    }

    public ArrayList<CourseType> getCourseTypes() {
        return courseTypes;
    }

    public void setCourseTypes(ArrayList<CourseType> courseTypes) {
        this.courseTypes = courseTypes;
    }

    public boolean isIsUnsubscribed() {
        return isUnsubscribed;
    }

    public void setIsUnsubscribed(boolean isUnsubscribed) {
        this.isUnsubscribed = isUnsubscribed;
    }


}