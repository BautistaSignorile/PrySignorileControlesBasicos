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
    public partial class frmControlesBasicos : Form
    {
        public frmControlesBasicos()
        {
            InitializeComponent();
        }

        private void frmControlesBasicos_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmControlesBasicos_Click(object sender, EventArgs e)
        {
            lblBienvenido.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmControlesBasicos_Load(object sender, EventArgs e)
        {

        }

        private void lblBienvenido_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void frmControlesBasicos_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmControlesBasicos_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxWidth = this.Width - lblBienvenido.Width;
            int maxHeight = this.Height - lblBienvenido.Height;
            lblBienvenido.Location = new Point(random.Next(maxWidth), random.Next(maxHeight));
        }
    }
}
