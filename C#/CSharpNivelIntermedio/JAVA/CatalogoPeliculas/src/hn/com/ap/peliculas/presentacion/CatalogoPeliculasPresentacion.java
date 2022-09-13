
package hn.com.ap.peliculas.presentacion;

import hn.com.ap.peliculas.servicio.*;
import java.util.Scanner;


public class CatalogoPeliculasPresentacion {
    
    public static void main(String[] args) {
        var opcion = -1; 
        var scan = new Scanner(System.in);
        
        ICatalogoPeliculas catalogo = new CatalogoPeliculasImpl(); 
        
        
//        System.out.println("Ingrese valor del menu");
//        opcion = scan.nextInt(); 
        
        
        while (opcion != 0) {
            System.out.println("***********************************");
            System.out.println("Elige una opcion: \n"
                + "1. Iniciar catalogo peliculas\n"
                + "2. Agregar pelicula\n"
                + "3. Listar peliculas\n"
                + "4. Buscar pelicula\n"
                + "0. Salir");
            opcion = Integer.parseInt(scan.nextLine());
            System.out.println("***********************************");
        
            
             switch(opcion){
                case 1:
                    catalogo.iniciarCatalogoPeliculas();
                    break;
                case 2:
                    System.out.println("Introduce el nombre de la pelicula");
                    var nombrePelicula = scan.nextLine();
                    catalogo.agregarPelicula(nombrePelicula);
                    break;
                case 3:
                    catalogo.listarPeliculas();
                    break;
                case 4:
                    System.out.println("Introduce una pelicula a buscar");
                    var buscar = scan.nextLine();
                    catalogo.buscarPelicula(buscar);
                    break;
                case 0:
                    System.out.println("Hasta Pronto!");
                    break;
                default:
                    System.out.println("Opcion no reconocida");
                    break;
            }
        
            
        }
        
        
    }
    
}
