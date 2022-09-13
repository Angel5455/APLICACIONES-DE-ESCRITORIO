
package test;

import datos.Conexion;
import datos.PersonaJDBC;
import domain.Persona;
import java.sql.*;
import java.util.*;
import java.util.logging.Level;
import java.util.logging.Logger;


public class TestManejoPersonas {
    public static void main(String[] args) {
       
        Connection conexion = null;
     
        try { 
            conexion = Conexion.getConnection();
            if(conexion.getAutoCommit()){
                conexion.setAutoCommit(false);
            }
               PersonaJDBC personaJdbc = new PersonaJDBC(conexion);
               Persona update = new Persona(8, "Michi", "Gatita", "gmichi@gmail.com", "3585-9982");
               personaJdbc.modificar(update);
               
               Persona insert = new Persona("Horacio", "El Gato", "ghoracio@gmail.com", "3585-9982");
               personaJdbc.insertar(insert);
               
               conexion.commit();
               System.out.println("Se ha hecho commit de la transaccion");
               
               
               
        List<Persona> personas = personaJdbc.seleccionar();

        for (Persona persona1 : personas) {

            System.out.println(persona1);

        }
        
       
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
            System.out.println("Entramos al rollback");
            try {
                conexion.rollback();
            } catch (SQLException ex1) {
                ex1.printStackTrace(System.out);
            }
        }


     

        
    }
}
