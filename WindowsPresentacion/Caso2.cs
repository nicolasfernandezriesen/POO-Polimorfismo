using Models.LibAjedrez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Caso2 : Form
    {
        public Caso2()
        {
            InitializeComponent();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();
            Caballo caballo = new Caballo();
            Torre torre = new Torre();

            MessageBox.Show("Peon: " + peon.Mover());
            MessageBox.Show("Caballo: " + caballo.Mover());
            MessageBox.Show("Torre: " + torre.Mover());
        }
    }
}
