using System;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    public class Persona
    {
        private String nombre;
        private String apepat;
        private String apemat;
        private String calle;
        private int numero;
        private String colonia;
        private String estado;
        private String numcelular;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apepat { get => apepat; set => apepat = value; }
        public string Apemat { get => apemat; set => apemat = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Numcelular { get => numcelular; set => numcelular = value; }
    }
}
