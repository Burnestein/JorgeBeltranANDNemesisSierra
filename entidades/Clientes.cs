using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    public class Clientes
    {
        private int idcliente;
        private String nombre;
        private String apepat;
        private String apemat;
        private String domicilio;
        private String colonia;
        private String telefono;
        private int limitecredito;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apepat { get => apepat; set => apepat = value; }
        public string Apemat { get => apemat; set => apemat = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Limitecredito { get => limitecredito; set => limitecredito = value; }
    }
}
