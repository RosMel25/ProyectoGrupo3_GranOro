using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.RecoleccionLN
{
    public class ClsRecoleccionLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsRecoleccionLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }



        #region Metodos CRUD

        public DataTable MostrarRecoleccion()
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.LISTAR_RECOLECCION";
            string TipoProcedimiento = "CUR_RECOLECCION";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }

        public DataTable GuardarRecoleccion(Entidad.Recoleccion.ClsRecolecion NewReco)
        {
            string Procedimiento = "PROCE_RECOLECCION.AGREGAR_RECOLECCION";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] {"pID_RECOLECTOR", "pID_FINCA", "pID_CORTE", "FECHA", "CAJUELAS", "CUARTILLOS", "pID_PRECIO", "PAGO_TOTAL"},
                new string[] {NewReco.Id_Recolector.ToString(),
                    NewReco.No_Finca.ToString(),
                    NewReco.Id_Corte.ToString(),
                    NewReco.Fecha_Recoleccion.ToString(),
                    NewReco.Cajuelas.ToString(),
                    NewReco.Cuartillos.ToString(),
                    NewReco.Id_Precio.ToString(),
                    NewReco.Precio_Total.ToString()}
                );
        }

        public DataTable EliminarRecoleccion(Entidad.Recoleccion.ClsRecolecion NewReco)
        {
            string Procedimiento = "PROCE_RECOLECCION.ELIMINAR_RECOLECCION";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID"},
                new string[] { NewReco.Id_Recoleccion.ToString()}

                );
        }

        public DataTable EditarRecolecion(Entidad.Recoleccion.ClsRecolecion NewReco)
        {
            string Procedimiento = "PROCE_RECOLECCION.EDITAR_RECOLECCION";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pID_RECOLECTOR", "pID_FINCA", "pID_CORTE", "FECHA", "CAJUELAS", "CUARTILLOS", "pID_PRECIO", "PAGO_TOTAL" },
                new string[] { NewReco.Id_Recoleccion.ToString(),
                    NewReco.Id_Recolector.ToString(),
                    NewReco.No_Finca.ToString(),
                    NewReco.Id_Corte.ToString(),
                    NewReco.Fecha_Recoleccion.ToString(),
                    NewReco.Cajuelas.ToString(),
                    NewReco.Cuartillos.ToString(),
                    NewReco.Id_Precio.ToString(),
                    NewReco.Precio_Total.ToString()}
                ); 
        }
        #endregion

        #region Metodos_Busqueda

        public DataTable VerRecolector()
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.LISTAR_DATOSRECOLECTOR";
            string TipoProcedimiento = "CUR_RECOLECTOR";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }
        public DataTable VerFinca()
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.LISTAR_DATOSFINCA";
            string TipoProcedimiento = "CUR_DF";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }
        public DataTable VerCorte(Entidad.Finca.ClsFinca newfinca)
        {
            string Procedimiento = "PROCE_RECOLECCION.LISTAR_DATOSCORTE";
            string TipoProcedimiento = "CUR_CORTE";

            return data.ejecutarProcedimiento_BUSQUEDA(
                Procedimiento,
                new string[] { "pNOMBRE" },
                new string[] { newfinca.No_Finca.ToString() },
                TipoProcedimiento);
        }

        public DataTable VerCategoria()
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.LISTAR_DATOSCATEGORIA";
            string TipoProcedimiento = "CUR_CATE";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }

        #endregion


        #region Panel de Busqueda

        public DataTable MostrarRecoleccionFinca(Entidad.Finca.ClsFinca newfinca)
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.BUSCAR_RECOLECCION_FINCA";
            string TipoProcedimiento = "CUR_RE";

            return data.ejecutarProcedimiento_BUSQUEDA(
                ProcedimientoBD,
                new string[] { "pFINCA" },
                new string[] { newfinca.No_Finca.ToString() },
                TipoProcedimiento);
        }


        public DataTable MostrarRecoleccionRecolector(Entidad.Recoleccion.ClsRecolector newrecolector)
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.BUSCAR_RECOLECCION_RECOLECTOR";
            string TipoProcedimiento = "CUR_RE";

            return data.ejecutarProcedimiento_BUSQUEDA(
                ProcedimientoBD,
                new string[] { "pNOMBRE_RECO" },
                new string[] { newrecolector.Identificacion.ToString() },
                TipoProcedimiento);
        }



        public DataTable MostrarRecoleccionFincaCorte(Entidad.ClsCorte newcorte)
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.BUSCAR_RECOLECCION_CORTE";
            string TipoProcedimiento = "CUR_FE";

            return data.ejecutarProcedimiento_BUSQUEDA(
                ProcedimientoBD,
                new string[] { "pCORTE" },
                new string[] { newcorte.ID_Corte.ToString() },
                TipoProcedimiento);
        }



        public DataTable MostrarRecoleccionFecha(Entidad.Recoleccion.ClsRecolecion newrecoleccion)
        {
            string ProcedimientoBD = "PROCE_RECOLECCION.BUSCAR_RECOLECCION_FECHA";
            string TipoProcedimiento = "CUR_FE";

            return data.ejecutarProcedimiento_BUSQUEDA(
                ProcedimientoBD,
                new string[] { "pFECHA" },
                new string[] { newrecoleccion.Fecha_Recoleccion.ToString() },
                TipoProcedimiento);
        }

        public DataTable VALIDAR_REGISTRO(string user, string contra)
        {
            string Procedimiento = "PROCE_RECOLECCION.REGISTRO_EXISTENTE";
            string TipoProcedimiento = "CUR_CATE";

            return data.ejecutarProcedimiento_BUSQUEDA(
                Procedimiento,
                new string[] { "pRECOLECTOR", "pFECHA" },
                new string[] { user, contra },
                TipoProcedimiento);

        }

        #endregion
    }
}
