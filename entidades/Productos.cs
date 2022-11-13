using System;
namespace JorgeBeltranANDNemesisSierra.entidades
{
    //----------------------------------------------------------------------------------
    //Clase para crear objetos de tipo Productos y manejar los datos de la base de datos.
    //----------------------------------------------------------------------------------
    public class Productos {

        //----------------------------------------------------------------------------------
        //Atributos del objeto Productos para guardar los datos de la base de datos.
        //----------------------------------------------------------------------------------
        private int IdProducto;
        private String nombreProducto;
        private int precioCompra;
        private int precioVenta;
        private int codigo;
        private String descripcion;
        //----------------------------------------------------------------------------------
        //Métodos de encapsulación de cada atributo.
        //----------------------------------------------------------------------------------
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public int PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
    }
}
