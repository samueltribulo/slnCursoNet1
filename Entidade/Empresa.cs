﻿using Entidades.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa:Persona    
    {

        public string CUIT { get; set; }
        public string Contacto { get; set; }

    }
}
