/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication1;

import java.util.Scanner;

/**
 *
 * @author ARPAZ Clase de Variables Primitivas
 */
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner scanner = new Scanner(System.in);
        System.out.println("Proporcione el numero1:");
        int numero1 = Integer.parseInt(scanner.nextLine());
        System.out.println("Proporcione el numero2:");
        int numero2 = Integer.parseInt(scanner.nextLine());
      
        System.out.println(numero1 > numero2 ? "El numero mayor es: " + numero1 : "El numero mayor es: " + numero2);
    }
    

}
