using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejer1.Models;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Helper helper = new Helper();


        private void tirar_dados_Click(object sender, EventArgs e)
        {
            roll();

        }

        // tira los dados UNA vez 
        private void roll()
        {
            int dado1, dado2, suma;

            helper.tirar_dados(out dado1, out dado2, out suma);
            label1.Text = $"Dado 1: {dado1}";
            label2.Text = $"Dado 2: {dado2}";
            lbl_suma.Text = $"Suma: {suma}";

            int[] conteoSumas = helper.Get_Conteosumas();

            listBox1.Items.Clear();
            listBox1.Items.Add("Suma\tCantidad");
            int suma2 = 0;

            for (int i = 0; i < conteoSumas.Length; i++)
            {
                suma2 = i + 2;
                int cantidad = conteoSumas[i];
                listBox1.Items.Add($"{suma2}\t{cantidad}");
            }
        }

        // Tira los dados 36,000 veces (se traba por un segundo pero funciona)
        private void roll_36k_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto tomara un segundo, el programa no ha crasheado", "Yeet", MessageBoxButtons.OK);
            for (int i = 0; i < 36000; i++)
            {
                roll();
            }

        }
    }
}
