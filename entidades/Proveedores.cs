using System;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    //----------------------------------------------------------------------------------
    //Clase para crear objetos de tipo Proveedores y manejar los datos de la base de datos.
    //----------------------------------------------------------------------------------
    public class Proveedores
    {
        //----------------------------------------------------------------------------------
        //Atributos del objeto Proveedores para guardar los datos de la base de datos.
        //----------------------------------------------------------------------------------
        private int idProveedor;
        private String nombre;
        private String apepat;
        private String apemat;
        private String domicilio;
        private String empresa;
        private String colonia;
        private String telefono;
        private String correo;
        //----------------------------------------------------------------------------------
        //Métodos de encapsulación de cada atributo.
        //----------------------------------------------------------------------------------
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apepat { get => apepat; set => apepat = value; }
        public string Apemat { get => apemat; set => apemat = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
