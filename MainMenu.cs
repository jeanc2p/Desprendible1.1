using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesprendibleTrabajador1._2
{
    public partial class MainMenu : Form
    {

        Nomina myNomina = new Nomina();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalarioDia.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Electricista" ? "20000" :
                comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Programador" ? "80000" :
                comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Abogado" ? "12000" :
                comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Arquitecto" ? "40000" :
                comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Aseador" ? "8000" : "0";
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myNomina.Nombre = txtNombre.Text;
                myNomina.Identificacion =  Convert.ToInt32( txtID1.Text);
                myNomina.Cargo = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                myNomina.AsignacionDias = Decimal.Parse(txtSalarioDia.Text);
                myNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);

                if (radioButtonMasculino.Checked == true)
                    myNomina.Genero = radioButtonMasculino.Text;
                if (radioButtonFemenino.Checked == true)
                    myNomina.Genero = radioButtonFemenino.Text;
                if (radioButtonNoBinario.Checked == true)   
                    myNomina.Genero = radioButtonNoBinario.Text;

                



                MessageBox.Show("Se guardó el registro");

            }
            catch
            {
                MessageBox.Show("Falta datos por ingresar");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desprendible myDesprendible = new Desprendible();

            myDesprendible.Show();
            this.Hide();

            myDesprendible.lbNombre.Text = myNomina.Nombre;
            myDesprendible.lbIdentificacion.Text = myNomina.Identificacion.ToString();
            myDesprendible.lbCargo.Text = myNomina.Cargo;
            myDesprendible.lbGenero.Text = myNomina.Genero;
            myDesprendible.lbDiasLaborados.Text = myNomina.DiasLaborados.ToString("0.#");
            myDesprendible.lbSalarioDia.Text = myNomina.AsignacionDias.ToString("C");
            myDesprendible.lbValorDevengado.Text = myNomina.CalcularNomina(myNomina.DiasLaborados, myNomina.AsignacionDias).ToString("C");
            myDesprendible.lbFechaCreacion.Text = DateTime.Now.ToLongDateString();
            myDesprendible.lbHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
