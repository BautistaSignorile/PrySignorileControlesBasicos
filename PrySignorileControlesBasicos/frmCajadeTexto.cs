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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCajaDeTexto_Load(object sender, EventArgs e)
        {

        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblreflejo.ForeColor = Color.Blue;
                txtReflejo.ForeColor = Color.Blue;
            }
            if (optRojo.Checked == true)
            {
                lblreflejo.ForeColor = Color.Red;
                txtReflejo.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";
            if (chkPicante.Checked == true)
            {
                lblEscribir.Text = "Picante";
                textoConcatenar = textoConcatenar + "Picante";
            }
            if (chkMayonesa.Checked == true)
            {
                lblEscribir.Text = "Mayonesa";
                textoConcatenar = textoConcatenar + " Mayonesa";
            }
            if (chkKetchup.Checked == true)
            {
                lblEscribir.Text = "Kethup";
                textoConcatenar = textoConcatenar + " Ketchup";
            }

            lblEscribir.Text = textoConcatenar;
            cboAdicional.Items.Add(textoConcatenar);
        }
    }
}
