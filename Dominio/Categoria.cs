﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descri {  get; set; }

        public override string ToString()
        {
            return Descri;
        }
    }
}
