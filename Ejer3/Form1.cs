using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejer3.Models;

namespace Ejer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int vendedor, producto, venta;
            

            

            try
            {
                if (Convert.ToDouble(txb_vent.Text) < 0 || string.IsNullOrEmpty(txb_vent.Text))
                {
                    MessageBox.Show("Error: Ventas no pueden ser menores a 0 ", "Yikes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                vendedor = Convert.ToInt32(cmb_vend.SelectedItem);
                producto = Convert.ToInt32(cmb_prod.SelectedItem);
                venta = Convert.ToInt32(txb_vent.Text);

                Vendedor.Agregar_Venta(vendedor, producto, venta);
             //   MessageBox.Show("Venta agregada, yay ", "Yay", MessageBoxButtons.OK);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Yikes", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {
                cmb_vend.SelectedIndex = -1;
                cmb_prod.SelectedIndex = -1;

                dGV1.Rows.Clear();
                

                txb_vent.Clear();
                Show_Productos();
            } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Yikes", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
                
                
        }
            // La parte heavy del codigo
            // Por que DataGridView? Por que al parecer es lo unico que hay para hacer tablas 

           
        public float[,] sales = Vendedor.Get_Sales();

        public void Show_Productos()
        {
            // Doble For para Alimentar la tabla 
            try 
            {
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV1);
                    row.Cells[0].Value = vendedor + 1;
                    for (int producto = 0; producto < 5; producto++)
                    {
                        row.Cells[producto + 1].Value = sales[vendedor, producto];
                    }

                    dGV1.Rows.Add(row);
                }
            } catch (Exception ex) { MessageBox.Show("Error 1: " + ex.Message, "Yikes", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            // para La ultima columna (total producto)
            try
            {
                
                for (int producto = 0; producto < 5; producto++)
                {
                   
                    double total = Vendedor.Ventas_Producto(producto);
                    dGV1.Rows[producto].Cells[6].Value = total;
                }
            }
            catch (Exception ex) { }

            // Para la ultima fila
            try 
            {
                dGV1.Rows.Add("Total vendedor: ");
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    double total = Vendedor.Ventas_Vendedor(vendedor + 1);
                    dGV1.Rows[4].Cells[vendedor + 1].Value = total;
                }

            } catch (Exception ex) { MessageBox.Show("Error 3: " + ex.Message, "Yikes", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }




         
    }
}
