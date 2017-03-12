using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ferromex.ModuloMecanico
{
    public class Mecanico
    {
        public int id { get; set;}
        public string nombre { get; set; }
        public string app { get; set; }
        public string apm { get; set; }
        public string ciudad { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public string colonia { get; set; }
        public int cp { get; set; }
        public string curp { get; set; }
        public string rfc { get; set; }
        public string fecha { get; set; }
        public string telefono { get; set; }

        public Mecanico() { }

        public Mecanico(string pnombre, string papp, string papm, string pciudad, string pcalle, int pnumero, string pcolonia, int pcp, string pcurp, string prfc, string ptel)
        {
            this.nombre = pnombre;
            this.app = papp;
            this.apm = papm;
            this.ciudad = pciudad;
            this.calle = pcalle;
            this.numero = pnumero;
            this.colonia = pcolonia;
            this.cp = pcp;
            this.curp = pcurp;
            this.rfc = prfc;
            this.telefono = ptel;
        }
    }
}

