using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio (int? nota1, int? nota2, int? nota3) 
        {

            if (nota1 == null && nota2 == null && nota3 == null) 
            {
                return 0;
            }

            int sumaTotal = 0;
            int notasValidas = 0;

            if (nota1 != null && nota1 >= 0 && nota1 <= 10)
            {
                sumaTotal += (int) nota1;
                notasValidas++;
            }

            if (nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                sumaTotal += (int)nota2;
                notasValidas++;
            }

            if (nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                sumaTotal += (int)nota3;
                notasValidas++;
            }

            if (notasValidas == 0) 
            {
                return 0;
            }

            return (double)sumaTotal / notasValidas;
        }
    }
}
