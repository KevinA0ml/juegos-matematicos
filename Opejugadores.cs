using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_educativo
{
    public class Opejugadores
    {
        private static int maxusu = 50;
        private int contusu = 0;
        // crear arreglo para almacenar jugadores
        datos_jug [] misjugadores  = new datos_jug [maxusu];

        // constructor 
        public Opejugadores()
        {
            // crear la instancia 
            datos_jug mijugador;
            mijugador = new datos_jug("kevin","mo", 1);
            misjugadores[contusu] = mijugador;
            contusu++;

            mijugador = new datos_jug("juan","mo", 3);
            misjugadores[contusu] = mijugador;
            contusu++;

        }
        // metodo para control el numero de usuarios
        public int numjug()
        {
            return contusu;
        }
                                                              // revisar
        // metodo para cargar todos los jugadores 
        public datos_jug[] Get_Jugs()
        {
            return misjugadores;
        }
        // metodo para ingresar jugadores
        public string addjugador( datos_jug mijugador)
        {
            if (contusu == maxusu)
            {
                return "se a alcanzado el numero maximo de jugadores";
            }
            misjugadores[contusu] = mijugador;
            contusu++;
            return "jugador agregado correctamente";
        }
        // metodo para encontrar posicion del jugador dntro dl arreglo
        public int posicionjugador (string nombre)
        {
            for (int i = 0; i < contusu; i  ++)
            {
                if (misjugadores[i].Nombre == nombre)
                {
                    return i;
                }
            }
            return -1;
        }
        public int contusuario()
        {
            return contusu;
        }
        // metodo para modificar jugadores de acuerdo a los nuevos puntos obtenidos 
        public string modjugador (datos_jug mijugador , int pos)
        {
            misjugadores[pos].Nombre = mijugador.Nombre;
            misjugadores[pos].Apellidos = mijugador.Apellidos;
            misjugadores[pos].Puntos = mijugador.Puntos;
            return "usuario modificado correctamente";
        }
    }
}
