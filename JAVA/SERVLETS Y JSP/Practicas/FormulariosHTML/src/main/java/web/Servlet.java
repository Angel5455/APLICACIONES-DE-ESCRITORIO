package web;

import java.io.*;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;

@WebServlet("/Servlet")
public class Servlet extends HttpServlet{
    
     @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException {
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();

        String usuario = request.getParameter("usuario");
        String password = request.getParameter("password");
        String tecnologias[] = request.getParameterValues("tecnologia");
        String genero = request.getParameter("genero");
        String ocupacion = request.getParameter("ocupacion");
        String musica[] = request.getParameterValues("musica");
        String comentarios = request.getParameter("comentarios");
             String tecno = "";
             String mus = "";
        
        for (String tecnologia : tecnologias) {
         tecno+= tecnologia + " / ";
          
        }
        
                if (musica != null) {
            for (String m : musica) {
                mus += m + " / ";
            }
        }
        else{
            out.print("Valor no proporcionado");
        }
             
                
        String cadena = "<html>"
                + " <head>"
                + "<title>Resultado Servlet</title>"
                + "</head>"
                + "<body>"
                +"<h1>Parametros procesados por el Servlet:</h1>"
                + "</body>"
                + "</html>"
                + "<table border='1'>"
                + "<tr>"
                + "<td>"
                + "Usuario"
                + "</td>"
                + "<td>"
                + usuario
                + "</td>"      
                + "</tr>"  
                + "<tr>"
                + "<td>"
                + "Password"
                + "</td>"
                + "<td>"
                + password
                + "</td>"      
                + "</tr>" 
                + "<tr>"
                + "<td>"
                + "Teconologias"
                + "</td>"
                + "<td>"
                + tecno
                + "</td>"      
                + "</tr>" 
                + "<tr>"
                + "<td>"
                + "Genero"
                + "</td>"
                + "<td>"
                + genero
                + "</td>"      
                + "</tr>" 
                + "<tr>"
                + "<td>"
                + "Ocupacion"
                + "</td>"
                + "<td>"
                + ocupacion
                + "</td>"      
                + "</tr>" 
                + "<tr>"
                + "<td>"
                + "Música Favorita"
                + "</td>"
                + "<td>"
                + mus
                + "</td>"      
                + "</tr>" 
                + "<tr>"
                + "<td>"
                + "Comentarios"
                + "</td>"
                + "<td>"
                + comentarios
                + "</td>"      
                + "</tr>" 

                
                
                
                + "</table>";
                
        out.print(cadena);
//        
//        
//        out.print("<html>");
//        out.print("<head>");
//        out.print("<title>Resultado Servlet</title>");
//        out.print("</head>");
//        out.print("<body>");
//        out.print("<h1>Parametros procesados por el Servlet:</h1>");
//        out.print("<table border='1'>");
//
//        out.print("<tr>");
//        out.print("<td>");
//        out.print("Usuario");
//        out.print("</td>");
//        out.print("<td>");
//        out.print(usuario);
//        out.print("</td>");
//        out.print("</tr>");
//
//        out.print("<tr>");
//        out.print("<td>");
//        out.print("Password");
//        out.print("</td>");
//        out.print("<td>");
//        out.print(password);
//        out.print("</td>");
//        out.print("</tr>");
//
//        out.print("<tr>");
//        out.print("<td>");
//        out.print("Tecnologías");
//        out.print("</td>");
//        out.print("<td>");
//
//        for (String tecnologia : tecnologias) {
//            out.print(tecnologia);
//            out.print(" / ");
//        }
//
//        out.print("</td>");
//        out.print("</tr>");
//
//        out.print("<tr>");
//        out.print("<td>");
//        out.print("Género");
//        out.print("</td>");
//        out.print("<td>");
//        out.print(genero);
//        out.print("</td>");
//        out.print("</tr>");
//
//        out.print("<tr>");
//        out.print("<td>");
//        out.print("Ocupación");
//        out.print("</td>");
//        out.print("<td>");
//        out.print(ocupacion);
//        out.print("</td>");
//        out.print("</tr>");
//
//        out.print("<tr>");
//        out.print("<td>");
//        out.print("Música Favorita");
//        out.print("</td>");
//        out.print("<td>");
//
//        if (musica != null) {
//            for (String m : musica) {
//                out.print(m);
//                out.print(" / ");
//            }
//        }
//        else{
//            out.print("Valor no proporcionado");
//        }
//
//        out.print("</td>");
//        out.print("</tr>");
//        
//        out.print("<tr>");
//        out.print("<td>");
//        out.print("Comentarios");
//        out.print("</td>");
//        out.print("<td>");
//        out.print(comentarios);
//        out.print("</td>");
//        out.print("</tr>");
//
//        out.print("</table>");
//        out.print("</body>");
//        out.print("</html>");
    }
    
}
