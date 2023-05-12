using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySignorileControlesBasicos
{
    public partial class frmCajaDeTexto : Form
    {
        public frmCajaDeTexto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblreflejo.Text = txtReflejo.Text;
        }

        private void frmCajaDeTexto_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblreflejo.ForeColor = Color.Blue;
            }

            if (optRojo.Checked == true)
            {
                lblreflejo.ForeColor = Color.Red;
            }
        }
    }
}
