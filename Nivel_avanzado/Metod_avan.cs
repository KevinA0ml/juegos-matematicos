using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_educativo.Nivel_avanzado
{
  class Metod_avan
    {
        // calculo de ecuacion de primer grado 
        //determinante
        public double ecuacion(int x11, int x22, int y11, int y22)
        {
            double det = (x11 * y22) - (x22 * y11);
            return det;
        }
        public Boolean revisionecua1 (double rx, double ry,  double rsx, double rsy)
        {

            if ((rx == rsx) && (ry == rsy) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Calculo para el sistema de ecuaciones de 3 incognitas
        //calculo del determinante
        public int determinante(int a11, int a22, int a33, int b11, int b22, int b33, int c11, int c22, int c33)
        {
            //determinante segun la regla de sarrus
            int m1 = (a11 * b22 * c33) + (a22 * b33 * c11) + (a33 * b11 * c22);
            int m2 = (c11 * b22 * a33) + (c22 * b33 * a11) + (c33 * b11 * c22);
            return m1 - m2;
        }
        public int ecuacionac(int a11, int a22, int a33, int b11, int b22, int b33, int c11, int c22, int c33)
        {
            int m1 = (a11 * b22 * c33) + (b11 * c22 * a33) + (c11 * a22 * b33);
            int m2 = (b11 * a22 * c33) + (a11 * c22 * b33) * (c11 * b22 * a33);
            return m1 - m2;
        }
        public int ecuacioneb(int a11, int a22, int a33, int b11, int b22, int b33, int c11, int c22, int c33)
        {
            int m1 = (a11 * b22 * c33) + (a22 * b33 * c11) + (a33 * b11 * c22);
            int m2 = (c11 * b22 * a33) + (c22 * b33 * a11) + (c33 * b11 * c22);
            return m1 - m2;
        }
        public Boolean revisionecua3(double ra, double raa, double rb, double rbb, double rc, double rcc)
        {

            if ((ra == raa) && (rb == rbb) && (rc == rcc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Calculo para la Formula general
        // metodo para calculo de la ecuacion 
        public double ecuacion(double a1, double b1, double c1, double resp)
        {
            double tot = ((b1 * b1) - (4 * a1 * c1));

            Math.Round(tot);
            return tot;
        }
        // metodo si es positivo 
        public double ecuamas(double totr, double b1, double c1, double a1)
        {
            double div = 2 * a1;
            double post = (-(b1) + Math.Sqrt(totr));
            double postot = post / div;
            Math.Round(postot, 2);
            return postot;
        }

        // metodo si es negativo 
        public double ecuaneg(double totr, double b1, double c1, double a1)
        {
            double neg = (2 * a1);
            double totn = (-(b1) - Math.Sqrt(totr));
            double negtot = (totn / neg);
            Math.Round(negtot, 2);
            return negtot;
        }
        public Boolean revisiongen(double resp1, double totalpos, double resp2, double totalneg)
        {

            if ((resp1 == totalpos) && (resp2 == totalneg)) 
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        // calculo de la derivada de una ecuacion 
        // cuarta pestaña 
        //CALCULO
         public  double calculoderiv(int a, int b, int c)
        {
            double tot = (Math.Pow(a, 2)) - b + b + c - (Math.Pow(a, 2)) + b - c;
            Math.Round(tot, 2);
            return tot;
        }
        public Boolean revisionderiv(double totm, double ru)
        {

            if ((totm == ru) )
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
