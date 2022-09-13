
package test;

import datos.*;
import domain.PersonaDTO;
import java.sql.*;
import java.util.*;



public class TestManejoPersonas {
    public static void main(String[] args) {
       
        Connection conexion = null;
     
        try { 
            conexion = Conexion.getConnection();
            if(conexion.getAutoCommit()){
                conexion.setAutoCommit(false);
            }
               PersonaDAO personaDao = new PersonaDaoJDBC(conexion);
               
               
               conexion.commit();
               System.out.println("Se ha hecho commit de la transaccion");
               
               
               
        List<PersonaDTO> personas = personaDao.select();

        for (PersonaDTO persona1 : personas) {

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
