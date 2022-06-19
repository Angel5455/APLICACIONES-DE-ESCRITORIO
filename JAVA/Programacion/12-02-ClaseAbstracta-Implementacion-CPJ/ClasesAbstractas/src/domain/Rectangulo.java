package domain;

public class Rectangulo extends FiguraGeometrica {
    
    public Rectangulo(String tipoFigura){
        super(tipoFigura);
    }
    
    @Override
    public void dibujar(){
        // this.getClass().getSimpleName() = imprime el nombre de la clase
       // System.out.println("Se imprime un: " + this.getClass().getSimpleName());
         System.out.println("Se imprime un: " + super.getTipoFigura());
    }
}
