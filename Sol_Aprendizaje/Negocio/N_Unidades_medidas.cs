using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Unidades_medidas
    {
        public static DataTable Listar_um(string cTexto)
        {
            D_Unidades_medidas Datos = new D_Unidades_medidas();
            return Datos.Listar_um(cTexto);
        }

        public static string Guardar_um(int Opcion, E_Unidades_medidas oUm)
        {
            D_Unidades_medidas Datos = new D_Unidades_medidas();
            return Datos.Guardar_um(Opcion, oUm);
        }

        public static string Eliminar_um(int Codigo)
        {
            D_Unidades_medidas Datos = new D_Unidades_medidas();
            return Datos.Eliminar_um(Codigo);
        }
    }
}
