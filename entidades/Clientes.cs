using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    public class Clientes
    {
        int idcliente;
        string nombre;
        string apepat;
        string apemat;
        string telefono;
        string calle;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apepat { get => apepat; set => apepat = value; }
        public string Apemat { get => apemat; set => apemat = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
    }
}
