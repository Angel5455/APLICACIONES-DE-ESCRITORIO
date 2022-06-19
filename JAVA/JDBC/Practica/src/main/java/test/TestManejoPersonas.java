
package test;

import datos.PersonaDAO;
import domain.Persona;
import java.util.List;

public class TestManejoPersonas {
    public static void main(String[] args) {
        PersonaDAO personaDao = new PersonaDAO(); 

        //Insertando objetos de tipo persona a la base de datos
//        Persona insert = new Persona("Michi", "Gatita", "michi@gmail.com", "3385-9477");
//        personaDao.insertar(insert);
        
        //Modificar un registro 
        Persona update = new Persona(5, "Maycol", "Gato", "maycol@gmail.com", "8795-9698");
        personaDao.modificar(update);

        //Eliminando un registro
//         Persona delete = new Persona(7);
//        personaDao.eliminar(delete);

        List<Persona> personas = personaDao.seleccionar();

        for (Persona persona1 : personas) {

            System.out.println(persona1);

        }
        
        
    }
}
