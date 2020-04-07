using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOfConsum
{
    class Consum
    {
        private double Dato1;
        private double Dato2;
        private double Dato3; 
        private double resultado;


        private double Dato4;
        private double Dato5;
        private double Dato6;
        private double resul;

        public double Resultado
        {
            set { resultado = value; }
            get { return resultado; }
        }
        public double dato1
        {
            set { Dato1 = value; }
            get { return Dato1; }
        }
        public double dato2
        {
            set { Dato2 = value; }
            get { return Dato2; }
        }
        public double dato3
        {
            set { Dato3 = value; }
            get { return Dato3; }
        }



        public double Resul
        {
            set { resul = value; }
            get { return resul; }
        }
        public double dato4
        {
            set { Dato4 = value; }
            get { return Dato4; }
        }
        public double dato5
        {
            set { Dato5 = value; }
            get { return Dato5; }
        }
        public double dato6
        {
            set { Dato6 = value; }
            get { return Dato6; }
        }
        public void Calculo()
        {
            if (dato1 < 130)
            { resultado = (dato1 * dato2); }
            else
            { resultado = (dato1 * dato3); }

        }

        public void Calculos()
        {
            if (dato4 < 130)
            { resul = (dato4 * dato5); }
            else
            { resul = (dato4 * dato6); }

        }
    }
}
