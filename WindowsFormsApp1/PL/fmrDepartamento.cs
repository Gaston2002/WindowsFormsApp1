using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.PL
{
    public partial class fmrDepartamento : Form
    {
        public fmrDepartamento()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion();
            Conexion conexion = new Conexion();

            MessageBox.Show("Conectado ..." + conexion.PruebaConectar());
        }

        private void RecuperarInformacion()
        {
            Departamento departamento = new Departamento();

            int Id = 0; int.TryParse(txtId.Text, out Id);

            departamento.Id = Id;
            departamento.Departamentos = txtNombreDepartamento.Text;

            MessageBox.Show(departamento.Id.ToString());
            MessageBox.Show(departamento.Departamentos);

        }
    }
}
