﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticaConBDD.Models;

namespace PracticaConBDD.Servicios
{
    interface ILocalServicio
    {
        void Alta(Local local);
        void Borrar(Local local);

        void Modificar(Local local, List<Prendum> prendas);
        Local obtenerPorId(int id);
    }
}
