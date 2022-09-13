
//Mi clase en Java
public class HolaMundo {

    public static void main(String args[]) {
        var mes = 15;
        var estacion = "";
        
        switch(mes){
            case 1: case 2: case 12:
                estacion = "Invierno";
                break;
            case 3: case 4: case 5:
                estacion = "Primavera";
                break;
            case 6: case 7: case 8:
                estacion = "Verano";
                break;
            case 9: case 10: case 11:
                estacion = "Otonio";
                break;
            default:
                estacion = "Estacion desconocida";
                break; 
            
        }
        System.out.println("estacion = " + estacion);
    }
}
