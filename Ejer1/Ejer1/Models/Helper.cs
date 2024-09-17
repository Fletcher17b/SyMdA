using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Models
{
    internal class Helper
    {
        Random random = new Random();
        private int[] conteoSumas = new int[11];

        public void tirar_dados(out int dado1_out, out int dado2_out, out int suma_out)
        {
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            int suma = dado1 + dado2;

            conteoSumas[suma - 2]++;
            dado1_out = dado1;
            dado2_out = dado2;
            suma_out = suma;

        }


        public int[] Get_Conteosumas()
        {
            return conteoSumas;
        }


    }
}
