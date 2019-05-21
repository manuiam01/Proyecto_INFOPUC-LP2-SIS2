/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.all.model.beam;

/**
 *
 * @author alulab14
 */
public class User {
    private String username;
    private String password;
    private int access_role;

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

    public int getAccess_role() {
        return access_role;
    }

    public void setAccess_role(int access_role) {
        this.access_role = access_role;
    }
}