using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Finca
{
    public class ClsFinca
    {
        #region Atributos Privados

        private int _No_Finca;
        private string _Nom_Finca;
        private string _Tam_Finca;
        private string _Ubi_Finca;

        // Atributos de manejo en la base de datos.
        private string _MjsError;
        private string _ValorScalar;
        private DataTable _dtResulatados;

        #endregion



        #region Atributos Publicos

        public int No_Finca { get => _No_Finca; set => _No_Finca = value; }
        public string Nom_Finca { get => _Nom_Finca; set => _Nom_Finca = value; }
        public string Tam_Finca { get => _Tam_Finca; set => _Tam_Finca = value; }
        public string Ubi_Finca { get => _Ubi_Finca; set => _Ubi_Finca = value; }
        public string MjsError { get => _MjsError; set => _MjsError = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public DataTable DtResulatados { get => _dtResulatados; set => _dtResulatados = value; }

        #endregion













    }
}
