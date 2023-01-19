using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_educativo.nivelMedio
{
    class Metod_med
    {
        // valores random
        public string valoresr1(int vmen, int vmay)
        {
            Random rb = new Random();
            String ra = Convert.ToString(rb.Next(vmen, vmay));
            return ra;
        }
        public string valoresr2(int vmen, int vmay)
        {
            Random rbd = new Random();
            String rb = Convert.ToString(rbd.Next(vmen, vmay));
            return rb;
        }
        public string valoresr3(int vmen, int vmay)
        {
            Random rb1 = new Random();
            String ra = Convert.ToString(rb1.Next(vmen, vmay));
            return ra;
        }
        public string valoresr4(int vmen, int vmay)
        {
            Random rbd1 = new Random();
            String rb = Convert.ToString(rbd1.Next(vmen, vmay));
            return rb;
        }
        // metodos por parametros para los calculos
        //calculos
        // calculo de la pendiente
        public Boolean revisionpend(double y1, double b1, double x1, double ru)
        {
            double resp = rspendiente(y1, b1, x1);
            if (resp == ru)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double rspendiente(double y1, double b1, double x1)
        {

            double m = (y1 - b1) / x1;

            double respd = (Double)Math.Round(m, 2);
            return respd;
        }

        // calculo de la pendiente por dos puntos
        public Boolean revisionpend2(double t1, double t2, double c1, double c2, double ru)
        {
            double resp = rspendiente2(t1, t2, c1, c2);
            if (resp == ru)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double rspendiente2(double t1, double t2, double c1, double c2)
        {
            double m = (t1 - t2) / (c1 - c2);
            double respd = (double)Math.Round(m, 2);
            return respd;
        }

        // calculo del teorema de pitagoras
        // cateto opuesto
        public Boolean revisionPitagoras1(double ru, double b1, double c1)
        {
            double resp = rspitagoras1(b1, c1);
            if (resp == ru)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double rspitagoras1(double b1, double c1)
        {
            double resp = Math.Sqrt((b1 * b1) - (c1 * c1));
            Math.Round(resp, 2);
            return resp;
        }
        // hipotenusa
        public Boolean revisionPitagoras2(double a1, double ru, double c1)
        {
            double resp = rspitagoras2(a1, c1);
            if (resp == ru)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double rspitagoras2(double a1, double c1)
        {
            double resp2 = Math.Sqrt((a1 * a1) + (c1 * c1));
            Math.Round(resp2, 2);
            return resp2;
        }
        // cateto adyacente
        public Boolean revisionPitagoras3(double a1, double b1, double ru)
        {
            double resp = rspitagoras3(a1, b1);
            if (resp == ru)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double rspitagoras3(double a1, double b1)
        {
            double resp3 = Math.Sqrt((b1 * b1) - (a1 * a1));
            Math.Round(resp3, 2);
            return resp3;
        }
        // circulo geometrico
        public Boolean revisioncirca(double rad, double rarea)
        {
            double resp = area(rad);
            if (resp == rarea)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double area(double rad)
        {
            double b = 2 * Math.PI * rad;
            double resp = Math.Round(b, 2);

            return resp;
        }
        public Boolean revisioncircp(double rad, double rperimetro)
        {
            double resp = perimetro(rad);
            if (resp == rperimetro)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double perimetro(double rad)
        {
            double c = Math.PI * (rad * rad);
            double resp2 = Math.Round(c, 2);
            return resp2;
        }
    }
}