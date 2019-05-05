
import java.util.*;

/**
 * 
 */
public class Student extends Interested {

    /**
     * Default constructor
     */
    public Student() {
    }

    /**
     * 
     */
    private String homePhone;

    /**
     * 
     */
    private ArrayList<String> idPUCPList;

    /**
     * 
     */
    private Date birthDate;

    /**
     * 
     */
    private String address;

    /**
     * Si se usa: https://www.baeldung.com/java-tuples
     * Se podría unir history con state de locación en una especie de tuplas.
     */
    private ArrayList<CourseHistory> history;

    /**
     * 
     */
    private ArrayList<Float> historyGrade;

    /**
     * 
     */
    private ArrayList<String> historyState;

    /**
     * 
     */
    private ArrayList<Voucher> vouchers;



}