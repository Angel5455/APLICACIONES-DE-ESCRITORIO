/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package tareas;

import java.util.Arrays;
import java.util.Scanner;

/**
 *
 * @author ARPAZ
 */
public class Tareas {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        imprimir(2,5,3,8); 
        imprimir(10);
        
        
    }
    
    public static void imprimir(int ...numeros){
        
        for(Object num: numeros){
            System.out.println("" + num);
        }
    }
    
    
}
