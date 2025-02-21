﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsPOO.Datos
{
    public interface IArchivo<T> where T : class
    { 
        T LeerDatos();

        void GuardarDatos(T obj);
    }

}
