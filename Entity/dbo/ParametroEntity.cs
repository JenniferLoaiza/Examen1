﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ParametroEntity: DBEntity
    {
        public int? Id_Parametro { get; set; }

        public string  Codigo { get; set; }
        public string  Descripcion  { get; set; }
        public String Valor { get; set; }
        public string Estado { get; set; }
    }
}
