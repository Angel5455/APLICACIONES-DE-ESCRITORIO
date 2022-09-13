
package hn.com.ap.peliculas.servicio;

import hn.com.ap.peliculas.datos.*;
import hn.com.ap.peliculas.domain.Pelicula;
import hn.com.ap.peliculas.excepciones.AccesoDatosEx;
import hn.com.ap.peliculas.excepciones.LecturaDatosEx;


public class CatalogoPeliculasImpl implements ICatalogoPeliculas {
    
    private final IAccesoDatos datos; 

    public CatalogoPeliculasImpl() {
        this.datos = new AccesoDatosImpl(); 
    }

    
    
    @Override
    public void agregarPelicula(String nombrePelicula) {
        Pelicula pelicula = new Pelicula(nombrePelicula);
        boolean anexar = false;
        try {
            anexar = datos.existe(NOMBRE_RECURSO);
            datos.escribir(pelicula, NOMBRE_RECURSO, anexar);
        } catch (AccesoDatosEx ex) {
            System.out.println("Error de acceso a datos");
            ex.printStackTrace(System.out);
        }

    }

    @Override
    public void listarPeliculas() {
        
        try {
            var peliculas = this.datos.listar(NOMBRE_RECURSO);
            
            for(var pelicula: peliculas){
                 System.out.println("Pelicula = " + pelicula);
            }
            
            
        } catch (AccesoDatosEx ex) {
             System.out.println("Error de acceso a datos");
               ex.printStackTrace(System.out);
        }
        
        
    }

    @Override
    public void buscarPelicula(String buscar) {
        String resultado = null; 
        try {
            resultado = this.datos.buscar(NOMBRE_RECURSO, buscar);
        } catch (LecturaDatosEx ex) {
            System.out.println("Error de acceso a datos");
            ex.printStackTrace(System.out);
        }
        
          System.out.println("resultado = " + resultado);
    
    }
    
    

    @Override
    public void iniciarCatalogoPeliculas() {
    
        try {
            if (this.datos.existe(NOMBRE_RECURSO)) {
                this.datos.borrar(NOMBRE_RECURSO);
                this.datos.crear(NOMBRE_RECURSO);
            } else {
                this.datos.crear(NOMBRE_RECURSO);
            }
        } catch (AccesoDatosEx ex) {
            System.out.println("Error al iniciar catalogo de peliculas");
            ex.printStackTrace(System.out);
        }

    }
    
    
    
}
