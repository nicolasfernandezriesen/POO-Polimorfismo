using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.LibAnimales;

namespace WindowsPresentacion
{
    public partial class Caso4 : Form
    {
        public Caso4()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon("Macho", 7, 156, 30);
            Conejo conejo = new Conejo("Campo", 2, 40, 4);
            Loro loro = new Loro("Blanco", 3, 20, 2);

            MessageBox.Show("Leon= " + leon.Comida() + " Conejo= " + conejo.Imprimir()+ "Loro= " + loro.Comida());
        }
    }
}
