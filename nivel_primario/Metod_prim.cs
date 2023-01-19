using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_educativo.nivel_primario
{
    internal class Metod_prim
    {
        // valores random
        public string valoresr(int vmen, int vmay)
        {
            Random rb = new Random();
            String ra = Convert.ToString(rb.Next(vmen, vmay));
            return ra;
        }
        public string valoresra(int vmen, int vmay)
        {
            Random rbd = new Random();
            String rb = Convert.ToString(rbd.Next(vmen, vmay));
            return rb;
        }
        // calculo de operaciones 
        // suma 
        public Boolean revisionSum(int a, int b, int ru)
        {
            int resp = rssum(a, b);
            if (resp == ru)
            {
                return true ;
            }
            else
            {
                return false;   
            }
        }
        public int rssum (int a, int b)
        {
            int resp;
            resp = a + b;
            return resp;
        }
        //
        // resta
        public Boolean revisionRes(int a, int b, int ru)
        {
        int resp = rsres(a, b);
            if (resp == ru)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int rsres(int a, int b)
        {
            int resp;
            resp = a - b;
            return resp;
        }
        //
        // multiplicacion
        public Boolean revisioMul(int a, int b, int ru)
        {
            int resp = rsmul(a,b);
                if (ru== resp)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public int rsmul(int a, int b)
        {
            int resp;
            resp = a * b;
            return resp; 
        }
        //
        //division 
        public Boolean revisionDiv(double a, double b, double ru)
        {
            double resp = rsdiv(a, b);
            if (ru == resp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double rsdiv(double a, double b)
        {
            double resp;
            resp = a / b;
            Math.Round(resp,2);
            return resp;
        }
    }
}