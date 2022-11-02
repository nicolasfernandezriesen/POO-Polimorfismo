using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViolin_Click(object sender, EventArgs e)
        {
            Violin violin = new Violin();
            MessageBox.Show(violin.Afinar());
        }

        private void btnGuitarra_Click(object sender, EventArgs e)
        {
            Guitarra guitarra = new Guitarra();
            MessageBox.Show(guitarra.Afinar());
        }

        private void btnPiano_Click(object sender, EventArgs e)
        {
            Piano piano = new Piano();
            MessageBox.Show(piano.Afinar());
        }
    }
}
