using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer3.Models
{
    public struct Venta
    {
        public int vendedor;
        public int producto;
        public int VentaTotal;
    }
    internal class Vendedor
    {
        private static float[,] sales = new float[4,5];


        public static void Agregar_Venta(int vendedor, int producto,float venta )
        {
            sales[vendedor-1,producto-1] += venta;
        }

        // int vendedor es un index para recorrer el primer subindice del array
        public static float Ventas_Vendedor(int vendedor)
        {
            float total_ventas_vendedor = 0;
            for (int i = 0; i < 4; i++)
            {
                total_ventas_vendedor += sales[vendedor-1,i];
            }
            return total_ventas_vendedor;
        }

        // int vendedor es un index para recorrer el segundo subindice del array
        public static float Ventas_Producto(int producto)
        {
            
            float total_ventas_producto = 0;
            for (int i = 0;i < 4;i++)
            {
            
                total_ventas_producto += sales[i,producto];

            }
            return total_ventas_producto;
        }
        public static float[,] Get_Sales() { return sales; }
        

        

    }
}
