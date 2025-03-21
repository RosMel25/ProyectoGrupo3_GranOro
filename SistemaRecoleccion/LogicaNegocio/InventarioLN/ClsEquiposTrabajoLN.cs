using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InventarioLN
{
    public class ClsEquiposTrabajoLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsEquiposTrabajoLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso


        public DataTable GuardarEquipo(Entidad.ClsEquiposTrabajo NewEquipoTrabajo)
        {
            string Procedimiento = "PROCE_Equipos_de_Trabajo.Agregar_Equipo";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pNo_Activo", "pNombre_Equipo", "pTipo_Equipo", "pGarantia_Equipo", "pId_Proveedor", "pNo_Finca" },
                new string[] {NewEquipoTrabajo.No_Activo.ToString(),
                    NewEquipoTrabajo.Nombre_Equipo.ToString(),
                    NewEquipoTrabajo.Tipo_Equipo.ToString(),
                    NewEquipoTrabajo.Garantia_Equipo.ToString(),
                    NewEquipoTrabajo.Id_Proveedor.ToString(),
                    NewEquipoTrabajo.No_Finca.ToString()}

                );
        }

        public DataTable BuscarEquipo(Entidad.ClsEquiposTrabajo NewEquipoTrabajo)
        {
            string Procedimiento = "PROCE_Equipos_de_Trabajo.Buscar_Equipo";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pNo_Activo" },
                new string[] { NewEquipoTrabajo.No_Activo.ToString() }

                );
        }

        public DataTable EditarEquipo(Entidad.ClsEquiposTrabajo NewEquipoTrabajo)
        {
            string Procedimiento = "PROCE_Equipos_de_Trabajo.Editar_Equipo";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pNo_Activo", "pNombre_Equipo", "pTipo_Equipo", "pGarantia_Equipo", "pId_Proveedor", "pNo_Finca" },
                new string[] {NewEquipoTrabajo.No_Activo.ToString(),
                    NewEquipoTrabajo.Nombre_Equipo.ToString(),
                    NewEquipoTrabajo.Tipo_Equipo.ToString(),
                    NewEquipoTrabajo.Garantia_Equipo.ToString(),
                    NewEquipoTrabajo.Id_Proveedor.ToString(),
                    NewEquipoTrabajo.No_Finca.ToString()}

                );
        }

        public DataTable EliminarEquipo(Entidad.ClsEquiposTrabajo NewEquipoTrabajo)
        {
            string Procedimiento = "PROCE_Equipos_de_Trabajo.Eliminar_Equipo";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pNo_Activo" },
                new string[] { NewEquipoTrabajo.No_Activo.ToString() }

                );
        }


        #endregion
    }
}
