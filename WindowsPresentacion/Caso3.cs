using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Models.LibPersona;

namespace WindowsPresentacion
{
    public partial class Caso3 : Form
    {
        public Caso3()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            Paciente paciente = new Paciente();

            medico.Name = Interaction.InputBox("Ingrese el nombre del medico", "Nombre del Medico");
            medico.LastName = Interaction.InputBox("Ingrese el apellido del medico", "Apellido del medico");
            medico.profesion = Interaction.InputBox("Ingrese el area de la profesion del medico", "Profesion del medico");

            MessageBox.Show(medico.ToString());

            paciente.Name = Interaction.InputBox("Ingerese el nombre del paciente", "Nombre del paciente");
            paciente.LastName = Interaction.InputBox("Ingerese el apellido del paciente", "Apellido del paciente");
            paciente.numPaciente = Convert.ToInt32(Interaction.InputBox("Ingrese el numero del pacietne", "Numero del paciente"));

            MessageBox.Show(paciente.ToString());
        }
    }
}
