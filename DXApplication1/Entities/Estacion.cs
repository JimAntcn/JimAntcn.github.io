using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Estacion
    {
        private string codHidro;
        private string nombre;
        private string rio;
        private string cuenca;
        private decimal? ancho;
        private int? alto;
        private string dpto;
        private string prov;

        public string CodHidro { get => codHidro; set => codHidro = value; }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rio { get => rio; set => rio = value; }
        public string Cuenca { get => cuenca; set => cuenca = value; }
        public decimal? Ancho { get => ancho; set => ancho = value; }
        public int? Alto { get => alto; set => alto = value; }
        public string Dpto { get => dpto; set => dpto = value; }
        public string Prov { get => prov; set => prov = value; }
       
    }
}
