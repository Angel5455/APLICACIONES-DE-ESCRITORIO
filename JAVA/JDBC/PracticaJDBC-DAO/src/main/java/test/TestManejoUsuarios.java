
package test;

import datos.Conexion;
import datos.UsuarioDAO;
import datos.UsuarioDaoJDBC;
import domain.UsuarioDTO;
import java.sql.*;
import java.util.List;



public class TestManejoUsuarios {
    public static void main(String[] args) {
        
        Connection conexion = null;
        
        try {
            conexion = Conexion.getConnection();
            if(conexion.getAutoCommit()){
                conexion.setAutoCommit(false);
            }
               UsuarioDAO usuarioDao = new UsuarioDaoJDBC(conexion);
               
//               UsuarioDTO userupdate = new UsuarioDTO(1, "Angel", "arpaz5455");
//               usuarioDao.update(userupdate);
//               
//               UsuarioDTO userinsert = new UsuarioDTO("Messi", "123");
//               usuarioDao.insert(userinsert);
//               
               conexion.commit();
               System.out.println("Se ha hecho commit de la transaccion");
               
                // Imprime listado
        List<UsuarioDTO> usuarios = usuarioDao.select();

        for (UsuarioDTO usuario : usuarios) {
            System.out.println(usuario);
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

        
        //Insertar registros
//        Usuario insert = new Usuario("Ramon", "123"); 
//        usuarioDAO.insertar(insert);
        
        //Modificar registros
//        Usuario update = new Usuario(3, "Ana", "321"); 
//        usuarioDAO.modificar(update);
//        
        //Eliminar registros
//        Usuario delete = new Usuario(3); 
//        usuarioDAO.eliminar(delete);
//        
        
       

                
       
        
    }
}
