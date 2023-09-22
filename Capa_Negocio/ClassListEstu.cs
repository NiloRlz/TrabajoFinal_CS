using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Estu;
using Capa_Registro;

namespace Capa_Negocio
{
    public class ClassListEstu
    {
        ClassEstu objd = new ClassEstu();

        public DataTable N_listar_clientes()
        {
            return objd.D_listar_clientes();
        }

        public DataTable N_buscar_clientes(ClassRegistro obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public String N_mantenimiento_cliente(ClassRegistro obje)
        {
            return objd.D_mantenimiento_clientes(obje);
        }
    }
}
