﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RH.Presentacion.MVC_C.Models
{
    public class PersonaModel
    {
        public int IdPersona { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }
    }
}