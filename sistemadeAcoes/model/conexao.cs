﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemadeAcoes.model
{
    internal class conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\daniel.bnoliveira\source\repos\sistemadeAcoes\sistemadeAcoes\dados\bdAcoes.mdf;Integrated Security=True";
        }
    }
}
