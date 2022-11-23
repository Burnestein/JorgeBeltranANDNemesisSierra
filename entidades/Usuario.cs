using System;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    public class Usuario: Persona
    {
        private int usuarioID;
        private String usuarios;
        private String contra;

        public string Usuarios { get => usuarios; set => usuarios = value; }
        public string Contra { get => contra; set => contra = value; }
        public int UsuarioID { get => usuarioID; set => usuarioID = value; }
    }
}
