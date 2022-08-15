using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int IdUser { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Puesto_Ocupado { get; set; }
        public static string Departamento { get; set; }
        public static string Turno { get; set; }
    }
}
