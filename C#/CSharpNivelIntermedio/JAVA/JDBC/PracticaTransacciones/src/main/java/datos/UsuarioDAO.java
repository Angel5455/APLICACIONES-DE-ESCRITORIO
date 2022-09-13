package datos;

import static datos.Conexion.*;
import domain.Usuario;
import java.sql.*;
import java.util.*;

public class UsuarioDAO {
    
    private Connection cnnT;

    private static final String SQL_SELECT = "SELECT idusuario, username, password FROM usuarios";
    private static final String SQL_INSERT = "INSERT INTO usuarios(username, password) VALUES(?, ?)";
    private static final String SQL_UPDATE = "UPDATE usuarios SET username = ?, password = ? WHERE idusuario = ?";
    private static final String SQL_DELETE = "DELETE FROM usuarios WHERE idusuario = ?";

    public UsuarioDAO() {
    }

    public UsuarioDAO(Connection cnnT) {
        this.cnnT = cnnT;
    }

    
    
    
    public List<Usuario> seleccionar() throws SQLException {
        Connection conn = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;
        Usuario usuario = null;
        List<Usuario> usuarios = new ArrayList<>();

        try {
             conn = this.cnnT != null ? this.cnnT : getConnection();
            stmt = conn.prepareStatement(SQL_SELECT);
            rs = stmt.executeQuery();
            while (rs.next()) {
                int idUsuario = rs.getInt("idusuario");
                String username = rs.getString("username");
                String password = rs.getString("password");

                usuario = new Usuario(idUsuario, username, password);

                usuarios.add(usuario);
            }
        }  finally {
            try {
                close(rs);
                close(stmt);
                   if (this.cnnT == null) {
                    close(conn);
                }
            } catch (SQLException ex) {
                ex.printStackTrace(System.out);
            }
        }

        return usuarios;
    }

    public int insertar(Usuario usuario) throws SQLException {
        Connection conn = null;
        PreparedStatement stmt = null;
        int registros = 0;
        try {
              conn = this.cnnT != null ? this.cnnT : getConnection();
            stmt = conn.prepareStatement(SQL_INSERT);
            stmt.setString(1, usuario.getUsername());
            stmt.setString(2, usuario.getPassword());
            registros = stmt.executeUpdate();
            if (registros > 0) {
                System.out.println("Registro guardado con exito");
            }
        } finally {
            try {
                close(stmt);
                if (this.cnnT == null) {
                    close(conn);
                }
            } catch (SQLException ex) {
                ex.printStackTrace(System.out);
            }
        }
        return registros;
    }

    public int modificar(Usuario usuario) throws SQLException {
        Connection conn = null;
        PreparedStatement stmt = null;
        int registros = 0;
        try {
              conn = this.cnnT != null ? this.cnnT : getConnection();
            stmt = conn.prepareStatement(SQL_UPDATE);
            stmt.setString(1, usuario.getUsername());
            stmt.setString(2, usuario.getPassword());
            stmt.setInt(3, usuario.getIdUsuario());
            registros = stmt.executeUpdate();
            if (registros > 0) {
                System.out.println("Registro actualizado con exito");
            }
        } finally {
            try {
                close(stmt);
               if (this.cnnT == null) {
                    close(conn);
                }
            } catch (SQLException ex) {
                ex.printStackTrace(System.out);
            }
        }
        return registros;
    }

    public int eliminar(Usuario usuario) throws SQLException {
        Connection conn = null;
        PreparedStatement stmt = null;
        int registros = 0;
        try {
              conn = this.cnnT != null ? this.cnnT : getConnection();
            stmt = conn.prepareStatement(SQL_DELETE);
            stmt.setInt(1, usuario.getIdUsuario());

            registros = stmt.executeUpdate();
            if (registros > 0) {
                System.out.println("Registro Eliminado con exito");
            }
        } finally {
            try {
                close(stmt);
                  if (this.cnnT == null) {
                    close(conn);
                }
            } catch (SQLException ex) {
                ex.printStackTrace(System.out);
            }
        }
        return registros;
    }

}
