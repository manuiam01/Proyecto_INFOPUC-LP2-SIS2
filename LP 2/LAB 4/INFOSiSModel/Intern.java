
import java.util.*;

/**
 * 
 */
public class Intern extends Employee {

    /**
     * Default constructor
     */
    public Intern() {
    }

    /**
     * 
     */
    private ArrayList<RoleHistory> history;

    /**
     * 
     */
    private ArrayList<InternAssistance> assistance;

    /**
     * String de 0's y 1's por cada hora de cada de día de la semana, donde 0 es no disponible y 1 es disponible.
     */
    private String weekAvailability;

    /**
     * String de 0's y 1's por cada hora de cada de día de la semana, donde 0 es no agendado y 1 es agendado.
     */
    private String weekSchedule;


}