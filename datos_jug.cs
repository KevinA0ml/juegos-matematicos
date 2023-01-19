using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_educativo
{
    public class datos_jug
    {
        private  string nombre;
        private string apellidoz;
        private  int puntos = 0;
        private static int estado = 0;
        private static int pos;

        public datos_jug(string nombre,string apellidoz, int puntos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidoz;
            this.Puntos = puntos;
        }

        public datos_jug() { }

        public datos_jug(int estado, int pos)
        {
            this.Pos = pos;
            this.Estado = estado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidoz; set => apellidoz = value;  }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Pos { get => pos; set => pos = value; }
    }
}
