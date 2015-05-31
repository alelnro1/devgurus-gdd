using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.BaseDeDatos.Conexion
{
        public class  ObjetoIdNombre { 
            private static String id;
            private static String nombre;
            
            public String get_id()
            {
                return ObjetoIdNombre.id;
            }
            public String get_nombre()

            {
                return ObjetoIdNombre.nombre;
            }
            public String set_id(String id)
            {
                return ObjetoIdNombre.id = id;
            }

            public String set_nombre(String nombre)
            {
                return ObjetoIdNombre.nombre = nombre;
            }
        }
}