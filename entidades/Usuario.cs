using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    class Usuario: Persona
    {
        private String usuarios;
        private String contra;

        public string Usuarios { get => usuarios; set => usuarios = value; }
        public string Contra { get => contra; set => contra = value; }
    }
}
