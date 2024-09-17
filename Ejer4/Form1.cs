using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        // array que guarda la cantidad de empleados que estan en un rango de salario que coindicide con la posicion en el array
        public int[] brackets_salario = new int[9];
        
        public void CalcularSalario(int ventasBrutas)
        {
            int salario = (int)(200 + 0.09 * ventasBrutas);

            if (salario >= 1000)
            {
                brackets_salario[8]++;
            }
            else if (salario >= 900)
            {
                brackets_salario[7]++;
            }
            else if (salario >= 800)
            {
                brackets_salario[6]++;
            }
            else if (salario >= 700)
            {
                brackets_salario[5]++;
            }
            else if (salario >= 600)
            {
                brackets_salario[4]++;
            }
            else if (salario >= 500)
            {
                brackets_salario[3]++;
            }
            else if (salario >= 400)
            {
                brackets_salario[2]++;
            }
            else if (salario >= 300)
            {
                brackets_salario[1]++;
            }
            else
            {
                brackets_salario[0]++;
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {

            int ventasBrutas = 0;
            if (int.TryParse(txb_input.Text, out ventasBrutas))
            {
                CalcularSalario(ventasBrutas);
                MessageBox.Show("Venta registrada");
            }
            else
            {
                MessageBox.Show("Un valor numérico válido");
            }

            // codigo extraido de stackoverflow, me dio pereza typear todo
            // update: perdi el post

            txb_input.Clear();
            lsb_empleados.Items.Clear();
            lsb_empleados.Items.Add("Rangos de salarios:");
            lsb_empleados.Items.Add($"$200-$299:   {brackets_salario[0]} vendedores");
            lsb_empleados.Items.Add($"$300-$399:   {brackets_salario[1]} vendedores");
            lsb_empleados.Items.Add($"$400-$499:   {brackets_salario[2]} vendedores");
            lsb_empleados.Items.Add($"$500-$599:   {brackets_salario[3]} vendedores");
            lsb_empleados.Items.Add($"$600-$699:   {brackets_salario[4]} vendedores");
            lsb_empleados.Items.Add($"$700-$799:   {brackets_salario[5]} vendedores");
            lsb_empleados.Items.Add($"$800-$899:   {brackets_salario[6]} vendedores");
            lsb_empleados.Items.Add($"$900-$999:   {brackets_salario[7]} vendedores");
            lsb_empleados.Items.Add($"$1000 o más: {brackets_salario[8]} vendedores");
        }
    }
}
