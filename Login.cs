using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_educativo
{
 class Login
    {
        //metodo para acceso del usuario
        // METODO DE INGRESO
        public Boolean acceso(string usuario, string clave)
        {
            if ((usuario == "kevin") && (clave == "3930"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
