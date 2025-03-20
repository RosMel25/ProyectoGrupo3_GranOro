using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.RecoleccionLN
{
    public class ClsPreciosLG
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsPreciosLG()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso


        public DataTable MostrarPrecio()
        {
            string ProcedimientoBD = "PROCE_PRECIOS.LISTAR_PRECIO";
            string TipoProcedimiento = "CUR_PRECIO";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }


        public DataTable GuardarPrecio(Entidad.ClsPrecio NewPrecio)
        {
            string Procedimiento = "PROCE_PRECIOS.AGREGAR_PRECIO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pMONEDA", "pCAJUELA", "pCUARTILLO" },
                new string[] {NewPrecio.ID_Precio.ToString(),
                    NewPrecio.Nom_Categoria.ToString(),
                    NewPrecio.Tipo_Moneda.ToString(),
                    NewPrecio.Precio_Cajuela.ToString(),
                    NewPrecio.Precio_Cuartilo.ToString()}

                );
        }

        public DataTable EliminarPrecio(Entidad.ClsPrecio NewPrecio)
        {
            string Procedimiento = "PROCE_PRECIOS.ELIMINAR_PRECIO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { NewPrecio.ID_Precio.ToString() }

                );
        }

        public DataTable EditarPrecio(Entidad.ClsPrecio NewPrecio)
        {
            string Procedimiento = "PROCE_PRECIOS.EDITAR_PRECIO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pMONEDA", "pCAJUELA", "pCUARTILLO" },
                new string[] { NewPrecio.ID_Precio.ToString(),
                    NewPrecio.Nom_Categoria.ToString(),
                    NewPrecio.Tipo_Moneda.ToString(),
                    NewPrecio.Precio_Cajuela.ToString(),
                    NewPrecio.Precio_Cuartilo.ToString()}

                );
        }

        public DataTable BuscarPrecio(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_CORTE.BUSCAR_FINCA";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { Newfinca.No_Finca.ToString() }

                );
        }

        #endregion
    }
}
