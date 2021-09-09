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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordBox1.Text == "123456")
            {

                MainMenu mymenu = new MainMenu();

                mymenu.Show();
                this.Hide();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
