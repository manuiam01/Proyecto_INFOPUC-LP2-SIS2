package pe.edu.pucp.INFOSiS.model.bean;
import java.util.*;

/**
 * 
 */
public class User {

    /**
     * Default constructor
     */
    public User() {
    }

    /**
     * 
     */
    private int id;

    /**
     * 
     */
    private String username;

    /**
     * 
     */
    private String password;

    /**
     * 
     */
    private String acces_role;

    /**
     * 
     */
    private boolean isActive;

    public User(int id, String username, String password, String acces_role, boolean isActive) {
        this.id = id;
        this.username = username;
        this.password = password;
        this.acces_role = acces_role;
        this.isActive = isActive;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getAcces_role() {
        return acces_role;
    }

    public void setAcces_role(String acces_role) {
        this.acces_role = acces_role;
    }

    public boolean isIsActive() {
        return isActive;
    }

    public void setIsActive(boolean isActive) {
        this.isActive = isActive;
    }


}