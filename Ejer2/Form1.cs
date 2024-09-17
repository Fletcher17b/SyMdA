using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2
{
    public partial class Form1 : Form
    {
        private bool smoking_bool = false;
        private int smoking_index = 0;
        private bool nonsmoking_bool = false;
        private int nonsmoking_index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_Error_MessageBox(string string1)
        {
            MessageBox.Show(string1, "Yitle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbx_smoke_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_nosmoke.Checked)
            {
                chbx_nosmoke.Checked = false;
                nonsmoking_bool = false;
                smoking_bool = true;
            }
            else { smoking_bool = true; }


        }

        private void chbx_nosmoke_CheckedChanged(object sender, EventArgs e)
        {
          
            if (chbx_smoke.Checked)
            {
                chbx_smoke.Checked = false;
                smoking_bool=false;
                nonsmoking_bool = true;
            } else { nonsmoking_bool = true; }

        }

        private void btnreserve_Click(object sender, EventArgs e)
        {
            if(!smoking_bool && !nonsmoking_bool)
            {
                Show_Error_MessageBox("No option selected");
                return;
            }
            bool smokingFull = smoking_index > 5;
            bool nonsmokingFull = nonsmoking_index > 5;

            if (nonsmoking_bool && nonsmoking_index < 6)
            {
                Show_Error_MessageBox("Asiento Reservado");
                nonsmoking_index++;
            }
            

            if (smoking_bool && smoking_index < 6)
            {
                smoking_index++;
            }

            smokingFull = smoking_index > 5;
            nonsmokingFull = nonsmoking_index > 5;

            if (smokingFull && nonsmokingFull)
            {
                Show_Error_MessageBox("All seats are full. Next flight in 3 hours");
            }
            else if (smokingFull && smoking_bool)
            {
                Show_Error_MessageBox("Smoking seats full, next flight in 3 hours");
            }
            else if (nonsmokingFull && nonsmoking_bool)
            {
                Show_Error_MessageBox("Nonsmoking seats full, next flight in 3 hours");
            }
 
        }
    }
}
