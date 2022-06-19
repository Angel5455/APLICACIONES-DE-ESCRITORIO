
package test;

import datos.UsuarioDAO;
import domain.Usuario;
import java.util.List;


public class TestManejoUsuarios {
    public static void main(String[] args) {
        UsuarioDAO usuarioDAO = new UsuarioDAO(); 
        
        //Insertar registros
//        Usuario insert = new Usuario("Ramon", "123"); 
//        usuarioDAO.insertar(insert);
        
        //Modificar registros
//        Usuario update = new Usuario(3, "Ana", "321"); 
//        usuarioDAO.modificar(update);
//        
        //Eliminar registros
        Usuario delete = new Usuario(3); 
        usuarioDAO.eliminar(delete);
        
        
        // Imprime listado
        List<Usuario> usuarios = usuarioDAO.seleccionar();

        for (Usuario usuario : usuarios) {
            System.out.println(usuario);
        }


                
       
        
    }
}
