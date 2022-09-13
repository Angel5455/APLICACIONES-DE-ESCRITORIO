package paquete2;

import paquete1.Clase1;


public class ClaseHija extends Clase1 {
    
int entero=10; 
    
    public ClaseHija(){
        super();
        this.atributoProtected = "Modificacion atributo protected";
        System.out.println("atributoProtegido = " + this.atributoProtected);
        this.metodoProtected();
    }

    @Override
    public String toString() {
        return "ClaseHija{" + " this.atributoProtected=" +  this.atributoProtected + '}';
    }
    
  
}
